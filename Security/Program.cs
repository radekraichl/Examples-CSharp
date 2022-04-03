using Security;

SecureKeyValuePair secureKVP = new("Heslo", "12345");

Console.WriteLine($"Key: {secureKVP.Key}");
Console.WriteLine($"Value: {secureKVP.Value}");
Console.WriteLine();

string key = "Heslo";
Console.WriteLine("Porovnávám klíč [{0}]: {1}", key, secureKVP.CompareKey(key));

key = "Kleslo";
Console.WriteLine("Porovnávám klíč [{0}]: {1}", key, secureKVP.CompareKey(key));

Console.WriteLine();

if (Encryption.TryDecryptString(secureKVP.Value, out string decryptedValue))
{
    Console.WriteLine("Heslo: " + decryptedValue);
}

if (secureKVP.TryGetValue("Heslo", out string value))
{
    Console.WriteLine("Heslo: " + value);
}
