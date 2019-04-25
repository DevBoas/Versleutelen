using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;

namespace Versleutelen
{
    class DESEncrypt
    {

        static TripleDES CreateDES(string key)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            TripleDES des = new TripleDESCryptoServiceProvider();
            des.Key = md5.ComputeHash(Encoding.Unicode.GetBytes(key));
            des.IV = new byte[des.BlockSize / 8];
            return des;
        }

        public string EncryptString(string userInput, string password)
        {
            if (userInput == "")
                return "";
            byte[] userInputBytes = Encoding.Unicode.GetBytes(userInput);
            MemoryStream myStream = new MemoryStream();
            TripleDES des = CreateDES(password);
            CryptoStream cryptStream = new CryptoStream(myStream, des.CreateEncryptor(), CryptoStreamMode.Write);
            cryptStream.Write(userInputBytes, 0, userInputBytes.Length);
            cryptStream.FlushFinalBlock();
            return Convert.ToBase64String(myStream.ToArray());
        }

        public string DecryptString(string encryptedText, string password)
        {
            string Decrypt = "";
            try
            {
                byte[] encryptedTextBytes = Convert.FromBase64String(encryptedText);
                MemoryStream myStream = new MemoryStream();
                TripleDES des = CreateDES(password);
                CryptoStream decryptStream = new CryptoStream(myStream, des.CreateDecryptor(), CryptoStreamMode.Write);
                decryptStream.Write(encryptedTextBytes, 0, encryptedTextBytes.Length);
                decryptStream.FlushFinalBlock();
                Decrypt = Encoding.Unicode.GetString(myStream.ToArray());
            }
            catch
            {
                MessageBox.Show("Couldn't decrypt");
            }
            return Decrypt;
        }

    }
}
