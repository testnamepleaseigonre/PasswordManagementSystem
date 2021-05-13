using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace PasswordManagementSystem.Encryption
{
    class AESEncryptor
    {
        private static readonly byte[] Key = Encoding.ASCII.GetBytes("~!@#$%^&*()_+=-0987654321`[],;'/");

        private static readonly byte[] IV = Encoding.ASCII.GetBytes("<>?:{}|ASDJNGHFY");

        private static AesCryptoServiceProvider provider = new AesCryptoServiceProvider();

        private static Encoding encoding = Encoding.GetEncoding("437");


        public void encryptFile(string directory, string fileName)
        {
            try
            {
                byte[] fileBytes = File.ReadAllBytes(directory + fileName + ".txt");
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.Key = Key;
                    AES.IV = IV;
                    byte[] encryptedFileBytes;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(fileBytes, 0, fileBytes.Length);
                            cs.Close();
                        }
                        encryptedFileBytes = ms.ToArray();
                    }
                    File.WriteAllBytes($"{directory + fileName}.enc", encryptedFileBytes);
                    File.Delete($"{directory + fileName}.txt");
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        public void decryptFile(string directory, string fileName)
        {
            try
            {
                byte[] content = File.ReadAllBytes(directory + fileName + ".enc");
                using (var AES = new RijndaelManaged())
                {
                    AES.Key = Key;
                    AES.IV = IV;
                    using (var memStream = new MemoryStream())
                    {
                        CryptoStream cryptoStream = new CryptoStream(memStream, AES.CreateDecryptor(), CryptoStreamMode.Write);
                        cryptoStream.Write(content, 0, content.Length);
                        cryptoStream.FlushFinalBlock();
                        File.WriteAllBytes($"{directory + fileName}.txt", memStream.ToArray());
                        File.Delete($"{directory + fileName}.enc");
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        public string encryptString(string plainText)
        {
            MemoryStream memoryStream = new MemoryStream();
            byte[] encryptionTextBytes = encoding.GetBytes(plainText);
            provider.Key = Key;
            provider.IV = IV;
            CryptoStream cryptoStream = new CryptoStream(memoryStream, provider.CreateEncryptor(), CryptoStreamMode.Write);
            cryptoStream.Write(encryptionTextBytes, 0, encryptionTextBytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] encryptedTextBytes = memoryStream.ToArray();
            return encoding.GetString(encryptedTextBytes);
        }

        public string decryptString(string cipherText)
        {
            byte[] decryptionTextBytes = encoding.GetBytes(cipherText);
            provider.Key = Key;
            provider.IV = IV;
            ICryptoTransform icrypt = provider.CreateDecryptor(provider.Key, provider.IV);
            byte[] decryptedTextBytes = icrypt.TransformFinalBlock(decryptionTextBytes, 0, decryptionTextBytes.Length);
            icrypt.Dispose();
            return encoding.GetString(decryptedTextBytes);
        }

        public string changeFromUnwantedCharacters(string text)
        {
            return text.Replace("\n", "``$%^NAUJASLAINAS$%^``")
                    .Replace("\r", "```$%^NAUJASLAINASERAS$%^```")
                    .Replace(",", "```$%^SEMICOLON$%^```");
        }

        public string changeToUnwantedCharacters(string text)
        {
            return text.Replace("``$%^NAUJASLAINAS$%^``", "\n")
                    .Replace("```$%^NAUJASLAINASERAS$%^```", "\r")
                    .Replace("```$%^SEMICOLON$%^```", ",");
        }
    }
}
