using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace FRSS.Utility
{
    public class CommonMethod
    {

        public static string ExcelFileName(string formname)
        {
            return formname + "List_" + DateTime.Now.ToString("ddMMyyyy") + "_" + DateTime.Now.ToString("HHmmss") + ".xls";
        }

        public enum FormName
        {
            Dashboard,
            CompMaster,
            CompFinYear
        }

        public static string ToYYYYMMDD(string date)
        {
            if (string.IsNullOrEmpty(date))
            {
                return string.Empty;
            }

            return DateTime.ParseExact(date, "dd/MM/yyyy", null).ToString("yyyy/MM/dd");
        }

        public static string ToYYYYMMDD(DateTime date)
        {
            return date.ToString("yyyy/MM/dd");
        }

        public static string ToDDMMYYYY(DateTime date)
        {
            return date.ToString("dd/MM/yyyy");
        }

        public static string ToDDMMYYYY(string date)
        {
            if (string.IsNullOrEmpty(date))
            {
                return string.Empty;
            }

            return Convert.ToDateTime(date).ToString("dd/MM/yyyy");
        }

        #region Encrypt descypt string

        static string PasswordHash = "P@#Sw0rd";
        static readonly string SaltKey = "S#LT$KEY";
        static readonly string VIKey = "$1B2c3D4e5F6g7H8K";

        public static string Encrypt(string plainText)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
            var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));

            byte[] cipherTextBytes;

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    cipherTextBytes = memoryStream.ToArray();
                    cryptoStream.Close();
                }
                memoryStream.Close();
            }
            return Convert.ToBase64String(cipherTextBytes);
        }

        public static string Decrypt(string encryptedText)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(encryptedText);
            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

            var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
            var memoryStream = new MemoryStream(cipherTextBytes);
            var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
        }

        #endregion
    }
}
