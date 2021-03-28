using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

// Token: 0x0200040D RID: 1037
public static class Console
{
	// Token: 0x0600ED9B RID: 60827 RVA: 0x00537FC0 File Offset: 0x005361C0
	public static string Log(string KDGOMEPJIKK, string JBKAHNLOKCE = null)
	{
		if (string.IsNullOrEmpty(KDGOMEPJIKK))
		{
			throw new ArgumentNullException("plainText");
		}
		if (string.IsNullOrEmpty(JBKAHNLOKCE))
		{
			JBKAHNLOKCE = global::Console.IPHNACIJKDE;
		}
		string result = null;
		RijndaelManaged rijndaelManaged = null;
		try
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(JBKAHNLOKCE, global::Console.GJHHINOMDIN);
			rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
			using (MemoryStream memoryStream = new MemoryStream())
			{
				memoryStream.Write(BitConverter.GetBytes(rijndaelManaged.IV.Length), 0, 4);
				memoryStream.Write(rijndaelManaged.IV, 0, rijndaelManaged.IV.Length);
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
				{
					using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
					{
						streamWriter.Write(KDGOMEPJIKK);
					}
				}
				result = Convert.ToBase64String(memoryStream.ToArray());
			}
		}
		finally
		{
			if (rijndaelManaged != null)
			{
				rijndaelManaged.Clear();
			}
		}
		return result;
	}

	// Token: 0x0600ED9C RID: 60828 RVA: 0x00538114 File Offset: 0x00536314
	public static byte[] LogBytes(byte[] FMFLEPJIKAI, string JBKAHNLOKCE)
	{
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(JBKAHNLOKCE, global::Console.GJHHINOMDIN);
		MemoryStream memoryStream = new MemoryStream();
		Aes aes = new AesManaged();
		aes.Key = passwordDeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = passwordDeriveBytes.GetBytes(aes.BlockSize / 8);
		CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(FMFLEPJIKAI, 0, FMFLEPJIKAI.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	// Token: 0x0600ED9D RID: 60829 RVA: 0x00538188 File Offset: 0x00536388
	public static byte[] ErrorBytes(byte[] FMFLEPJIKAI, string JBKAHNLOKCE)
	{
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(JBKAHNLOKCE, global::Console.GJHHINOMDIN);
		MemoryStream memoryStream = new MemoryStream();
		Aes aes = new AesManaged();
		aes.Key = passwordDeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = passwordDeriveBytes.GetBytes(aes.BlockSize / 8);
		CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(FMFLEPJIKAI, 0, FMFLEPJIKAI.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	// Token: 0x0600ED9E RID: 60830 RVA: 0x005381FC File Offset: 0x005363FC
	public static string Error(string FDIAENDNILM, string JBKAHNLOKCE = null)
	{
		if (string.IsNullOrEmpty(FDIAENDNILM))
		{
			throw new ArgumentNullException("cipherText");
		}
		if (string.IsNullOrEmpty(JBKAHNLOKCE))
		{
			JBKAHNLOKCE = global::Console.IPHNACIJKDE;
		}
		RijndaelManaged rijndaelManaged = null;
		string result = null;
		try
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(JBKAHNLOKCE, global::Console.GJHHINOMDIN);
			byte[] buffer = Convert.FromBase64String(FDIAENDNILM);
			using (MemoryStream memoryStream = new MemoryStream(buffer))
			{
				rijndaelManaged = new RijndaelManaged();
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
				rijndaelManaged.IV = global::Console.CLBDFHMODLI(memoryStream);
				ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
				{
					using (StreamReader streamReader = new StreamReader(cryptoStream))
					{
						result = streamReader.ReadToEnd();
					}
				}
			}
		}
		finally
		{
			if (rijndaelManaged != null)
			{
				rijndaelManaged.Clear();
			}
		}
		return result;
	}

	// Token: 0x0600ED9F RID: 60831 RVA: 0x0053832C File Offset: 0x0053652C
	private static byte[] CLBDFHMODLI(Stream BDIMLMKEEKO)
	{
		byte[] array = new byte[4];
		if (BDIMLMKEEKO.Read(array, 0, array.Length) != array.Length)
		{
			throw new SystemException("Stream did not contain properly formatted byte array");
		}
		byte[] array2 = new byte[BitConverter.ToInt32(array, 0)];
		if (BDIMLMKEEKO.Read(array2, 0, array2.Length) != array2.Length)
		{
			throw new SystemException("Did not read byte array properly");
		}
		return array2;
	}

	// Token: 0x04001A9C RID: 6812
	private static string IPHNACIJKDE = "88f00bdf0ad61b16b803971ebe071962";

	// Token: 0x04001A9D RID: 6813
	private static byte[] GJHHINOMDIN = Encoding.ASCII.GetBytes("d264dbba9c2410771b4ad918903b3f4cd9e276a9");
}
