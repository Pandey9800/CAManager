using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsaEvent.Services
{
	public class Notify
	{
		private readonly ISnackbar _snack;
		private readonly IDialogService _dialog;
		public Notify(ISnackbar snack, IDialogService dialog)
		{
			_snack = snack;
			_dialog = dialog;
		}
		public async void Message(string msg)
		{
			if (msg.Contains("Error"))
				await _dialog.ShowMessageBox("Error", msg.Split("-")[1], yesText: "OK");
			else if (msg.Contains("Warning"))
				_snack.Add(msg.Split("-")[1], Severity.Warning);
			else
				_snack.Add(msg, Severity.Success);
		}
	}
}
