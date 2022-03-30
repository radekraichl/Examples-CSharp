namespace Security
{
    internal struct SecureKeyValuePair
    {
        public string Key { get; init; }
        public string Value { get; init; }

        public SecureKeyValuePair(string key, string value)
        {
            Key = Encryption.ComputeSha256Hash(key);
            Value = Encryption.EncryptString(value);
        }

        public bool CompareKey(string key) => Encryption.ComputeSha256Hash(key) == Key;

        public bool TryGetValue(string key, out string value)
        {
            value = string.Empty;

            if (key == null)
            {
                return false;
            }

            if (CompareKey(key) && Encryption.TryDecryptString(Value, out string text))
            {
                value = text;
                return true;
            }

            return false;
        }
    }
}
