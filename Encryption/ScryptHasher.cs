using Scrypt;

namespace PasswordManagementSystem.Repositories
{
    class ScryptHasher
    {
        private ScryptEncoder encoder = new ScryptEncoder();

        public string encrypt(string plaintext)
        {
            return encoder.Encode(plaintext);
        }

        public bool encrypt(string password, string encryptedPassword)
        {
            return encoder.Compare(password, encryptedPassword);
        }
    }
}
