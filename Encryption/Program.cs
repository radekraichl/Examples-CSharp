using System.Diagnostics;
using System.Security.Cryptography;

string key = Convert.ToBase64String(RandomNumberGenerator.GetBytes(32));
string encryptedText = EncryptString(key, "Hello, World!");
string decryptedText = DecryptString(key, encryptedText);
Console.WriteLine(decryptedText);


static string EncryptString(string key, string plainText)
{
    byte[] iv = new byte[16];

    using Aes aes = Aes.Create();

    aes.Key = Convert.FromBase64String(key);
    aes.IV = iv;

    using MemoryStream memoryStream = new();
    using CryptoStream cryptoStream = new(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
    using (StreamWriter streamWriter = new(cryptoStream))
    {
        streamWriter.Write(plainText);
    }

    return Convert.ToBase64String(memoryStream.ToArray());
}

static string DecryptString(string key, string cipherText)
{
    byte[] iv = new byte[16];
    byte[] buffer = Convert.FromBase64String(cipherText);

    using Aes aes = Aes.Create();

    aes.Key = Convert.FromBase64String(key);
    aes.IV = iv;

    using MemoryStream memoryStream = new(buffer);
    using CryptoStream cryptoStream = new(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read);
    using StreamReader streamReader = new(cryptoStream);

    return streamReader.ReadToEnd();
}
