using System.Security.Cryptography;
using System.Text;

namespace Security;

internal class Encryption
{
    private const string key = "A7MAN9z0vfaoU+4GCsyGPELHyF/hO6zqnG8qtW45zFQ=";

    private static readonly byte[] iv = new byte[16];

    public static string EncryptString(string plainText)
    {
        if (plainText == null) throw new ArgumentNullException(nameof(plainText));

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

    public static bool TryDecryptString(string cipherText, out string plainText)
    {
        try
        {
            byte[] buffer = Convert.FromBase64String(cipherText);

            using Aes aes = Aes.Create();

            aes.Key = Convert.FromBase64String(key);
            aes.IV = iv;

            using MemoryStream memoryStream = new(buffer);
            using CryptoStream cryptoStream = new(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read);
            using StreamReader streamReader = new(cryptoStream);

            plainText = streamReader.ReadToEnd();
            return true;
        }
        catch (Exception)
        {
            plainText = string.Empty;
            return false;
        }
    }

    public static string ComputeSha256Hash(string plainText)
    {
        using SHA256 sha256Hash = SHA256.Create();

        byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(plainText));

        // Convert byte array to a string   
        StringBuilder builder = new();
        for (int i = 0; i < bytes.Length; i++)
        {
            builder.Append(bytes[i].ToString("x2"));
        }

        return builder.ToString();
    }
}
