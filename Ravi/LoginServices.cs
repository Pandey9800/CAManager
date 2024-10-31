using JsaEvent.Data;
using JsaEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace JsaEvent.Services
{
	public interface ILoginService
	{
		UserData? User { get;}
		Task Initialize();
		Task<bool> Login(UserLogin log);
		void Logout();
	}
	public class LoginService : ILoginService
	{
		public UserData? User { get; private set; }
		private IHttpService _Http;
		public LoginService(IHttpService Http)
		{
			_Http = Http;
		}
		public async Task Initialize()
		{
			//SecureStorage.Remove("logUser");
			var json = await SecureStorage.GetAsync("logUser");
			if (json != null)
				User = JsonSerializer.Deserialize<UserData>(json);
			UserDataLog.use = User;
		}
		public async Task<bool> Login(UserLogin log)
		{
			
			User = await _Http.Post<UserData>("Userlogin/loginMobApp" ,log);
			if (User.UserId != null)
			{
				var jsonD = JsonSerializer.Serialize(User);
				await SecureStorage.SetAsync("logUser", jsonD);
				UserDataLog.use = User;
				return true;
			}
			else
				return false;
		
		}
		public void Logout()
		{
			SecureStorage.Remove("logUser");

			User = null;
			UserDataLog.use = null;
		
		}


	}
}
