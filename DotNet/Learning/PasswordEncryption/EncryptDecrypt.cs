using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Security;

namespace PasswordEncryption
{
	class EncryptDecrypt
	{
		static void Main(string[] args)
		{
			string testPassword = "w1n$huttle";
			string encX = Encrypt(ToSecureString(testPassword));
			Console.WriteLine("encxxx = "  + encX);
			string decX = Decrypt(encX);
			Console.WriteLine("dncxxx = " + decX);
			Console.ReadKey();

		}
		private const string MagicPrefix = "!~@/";
		static byte[] entropy = System.Text.Encoding.Unicode.GetBytes("Too deep we delved there, and woke the nameless fear.");

		/// <summary>
		/// Encrypt the string
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static string Encrypt(SecureString input)
		{
			string toEncrypt = ToInsecureString(input);
			byte[] keyArray;
			byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

			string key = "Winshuttle";
			MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
			keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
			hashmd5.Clear();

			TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
			tdes.Key = keyArray;
			tdes.Mode = CipherMode.ECB;
			tdes.Padding = PaddingMode.PKCS7;

			ICryptoTransform cTransform = tdes.CreateEncryptor();
			byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
			tdes.Clear();

			return MagicPrefix + Convert.ToBase64String(resultArray, 0, resultArray.Length);
		}

		/// <summary>
		/// DeCrypt a string using dual encryption method. Return a DeCrypted clear string
		/// </summary>
		/// <param name="cipherString">encrypted string</param>
		/// <returns></returns>
		public static string Decrypt(string cipherString)
		{
			try
			{
				if (cipherString.StartsWith(MagicPrefix))
				{
					cipherString = cipherString.Substring(MagicPrefix.Length);
					byte[] keyArray;
					byte[] toEncryptArray = Convert.FromBase64String(cipherString);

					string key = "Winshuttle";
					MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
					keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
					hashmd5.Clear();

					TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
					tdes.Key = keyArray;
					tdes.Mode = CipherMode.ECB;
					tdes.Padding = PaddingMode.PKCS7;

					ICryptoTransform cTransform = tdes.CreateDecryptor();
					byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

					tdes.Clear();

					return UTF8Encoding.UTF8.GetString(resultArray);
				}
				else
				{
					return cipherString;
				}
			}
			catch (Exception)
			{
				// Something wrong with key. Try old decryption
				return null;
			}
		}
		
		
		/// <summary>
		/// Converts given string to a secure string.
		/// </summary>
		/// <param name="input">Input String.</param>
		/// <returns>Output Secure String.</returns>
		public static SecureString ToSecureString(string input)
		{
			SecureString secure = new SecureString();
			foreach (char c in input)
			{
				secure.AppendChar(c);
			}
			secure.MakeReadOnly();
			return secure;
		}

		/// <summary>
		/// Converts a Secure String to a string.
		/// </summary>
		/// <param name="input">Input Secure String.</param>
		/// <returns>Output string.</returns>
		public static string ToInsecureString(SecureString input)
		{
			string returnValue = string.Empty;
			IntPtr ptr = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(input);
			try
			{
				returnValue = System.Runtime.InteropServices.Marshal.PtrToStringBSTR(ptr);
			}
			finally
			{
				System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(ptr);
			}
			return returnValue;
		}
	}
}
