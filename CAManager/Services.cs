using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAManager
{
    class Services
    {
        public static User User;
        private string conStr = Properties.Settings.Default.CAMConnectionString;
        public SqlCommand CreateSqlConnection(string storeProcedureName)
        {
            //for store procedure
            SqlConnection conn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(storeProcedureName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }

        public void MessageBoxError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public string Encrypt(string clearText)
        {
            string EncryptionKey = "KMDRE23870FDR3S";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        public string Decrypt(string cipherText)
        {
            string EncryptionKey = "KMDRE23870FDR3S";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        internal SqlConnection CreateSqlConnection()
        {
            throw new NotImplementedException();
        }


        public DataTable getCompany(string searchText = null)
        {
            SqlConnection conn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("[sp_companySelect]",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if(!string.IsNullOrEmpty(searchText))
                cmd.Parameters.AddWithValue("@searchText", searchText);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getBillRprt(Int64 CompanyCode)
        {
            SqlConnection conn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("[sp_fileRegSelect]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@role", User.role);
            cmd.Parameters.AddWithValue("@CompanyCode",CompanyCode);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getUser(string searchText = null)
        {
            SqlConnection conn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("[sp_selectUser]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (!string.IsNullOrEmpty(searchText))
                cmd.Parameters.AddWithValue("@searchText", searchText);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getFees(string searchText = null)
        {
            SqlConnection conn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("[sp_selectFees]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (!string.IsNullOrEmpty(searchText))
                cmd.Parameters.AddWithValue("@searchText", searchText);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable getFirm(string searchText = null)
        {
            SqlConnection conn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("sp_firmMasterSelect", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable getReportInvoice(Int64 ii)
        {
            SqlConnection conn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("sp_InvoiceSel", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CompanyCode", ii);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
