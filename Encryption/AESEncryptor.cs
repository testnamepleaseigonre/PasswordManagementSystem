using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace PasswordManagementSystem.Encryption
{
    class AESEncryptor
    {
        private static readonly byte[] Key = Encoding.ASCII.GetBytes("~!@#$%^&*()_+=-0987654321`[],;'/");

        private static readonly byte[] IV = Encoding.ASCII.GetBytes("<>?:{}|ASDJNGHFY");

        public void EncryptAesManaged(string raw)
        {
            try
            {
                // Create Aes that generates a new key and initialization vector (IV).    
                // Same key must be used in encryption and decryption    
                using (AesManaged aes = new AesManaged())
                {
                    // Encrypt string    
                    byte[] encrypted = Encrypt(raw);
                    // Print encrypted string    
                    Console.WriteLine($"Encrypted data: {System.Text.Encoding.UTF8.GetString(encrypted)}");
                    // Decrypt the bytes to a string.    
                    string decrypted = Decrypt(encrypted, aes.Key, aes.IV);
                    Console.WriteLine(aes.Key);
                    Console.WriteLine();
                    // Print decrypted string. It should be same as raw data    
                    Console.WriteLine($"Decrypted data: {decrypted}");
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            Console.ReadKey();
        }

        public byte[] Encrypt(string plainText)
        {
            byte[] encrypted;
            // Create a new AesManaged.    
            using (AesManaged aes = new AesManaged())
            {
                // Create encryptor    
                ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);
                // Create MemoryStream    
                using (MemoryStream ms = new MemoryStream())
                {
                    // Create crypto stream using the CryptoStream class. This class is the key to encryption    
                    // and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream    
                    // to encrypt    
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        // Create StreamWriter and write data to a stream    
                        using (StreamWriter sw = new StreamWriter(cs))
                            sw.Write(plainText);
                            encrypted = ms.ToArray();
                    }
                }
            }
            // Return encrypted data    
            return encrypted;
        }
        public string Decrypt(byte[] cipherText, byte[] Key, byte[] IV)
        {
            string plaintext = null;
            // Create AesManaged    
            using (AesManaged aes = new AesManaged())
            {
                // Create a decryptor    
                ICryptoTransform decryptor = aes.CreateDecryptor(Key, IV);
                // Create the streams used for decryption.    
                using (MemoryStream ms = new MemoryStream(cipherText))
                {
                    // Create crypto stream    
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        // Read crypto stream    
                        using (StreamReader reader = new StreamReader(cs))
                            plaintext = reader.ReadToEnd();
                    }
                }
            }
            return plaintext;
        }

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
            catch(Exception exc)
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
                        //string withoutExtension = Path.ChangeExtension(file, null);
                        //File.Move(file, withoutExtension);
                        File.Delete($"{directory + fileName}.enc");
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
