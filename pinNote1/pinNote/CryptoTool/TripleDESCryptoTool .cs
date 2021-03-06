﻿using SecretScrambler.Enums;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SecretScrambler.CryptoTool
{

    //Based off of example found here: https://msdn.microsoft.com/en-us/library/system.security.cryptography.rijndaelmanaged.aspx
    public class TripleDESCryptoTool : iCryptoTool
    {
        private readonly EncryptionTypeEnum EncryptionType = EncryptionTypeEnum.TripleDES;

        private int keySize = 192;

        public string EncryptRun(string message, string password)
        {
            byte[] encryptionResult;

            var IV = GetCurrentIV();

            using (PasswordDeriveBytes pw = new PasswordDeriveBytes(password, IV))
            {
                byte[] pwBytes = pw.GetBytes(keySize / 8);

                using (TripleDESCryptoServiceProvider TripleDESprovider = new TripleDESCryptoServiceProvider())
                {
                    TripleDESprovider.Key = pwBytes;
                    TripleDESprovider.IV = IV;

                    ICryptoTransform encryptor = TripleDESprovider.CreateEncryptor(TripleDESprovider.Key, TripleDESprovider.IV);

                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter sw = new StreamWriter(cs))
                            {
                                sw.Write(message);
                            }
                            encryptionResult = ms.ToArray();
                        }
                    }
                }
            }

            return Convert.ToBase64String(encryptionResult);
        }


        public string DecryptRun(string message, string password)
        {
            string decryptionResult = null;

            //message as bytes
            byte[] messageBytes = Convert.FromBase64String(message);// = Encoding.ASCII.GetBytes(message);

            var IV = GetCurrentIV();

            using (PasswordDeriveBytes pw = new PasswordDeriveBytes(password, IV))
            {
                byte[] pwBytes = pw.GetBytes(keySize / 8);

                using (TripleDESCryptoServiceProvider TripleDESprovider = new TripleDESCryptoServiceProvider())
                {
                    TripleDESprovider.Key = pwBytes;
                    TripleDESprovider.IV = IV;

                    ICryptoTransform decryptor = TripleDESprovider.CreateDecryptor(TripleDESprovider.Key, TripleDESprovider.IV);

                    using (MemoryStream ms = new MemoryStream(messageBytes))
                    {
                        using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader sr = new StreamReader(cs))
                            {
                                decryptionResult = sr.ReadToEnd();
                            }

                        }
                    }
                }
            }

            return decryptionResult;
        }

        public EncryptionTypeEnum GetEncryptionType()
        {
            return EncryptionType;
        }

        public byte[] GetCurrentIV()
        {
            var hardCoded = "c2/8PUyajsE=";
           
            var customTripleDES = ConfigurationManager.AppSettings["CustomTripleDesIV"];

            var ivStr = (!string.IsNullOrEmpty(customTripleDES)) ? customTripleDES : hardCoded;

            byte[] IV = Convert.FromBase64String(ivStr);

            return IV;
        }

        public string GenerateNewIVString()
        {
            var tdes = new TripleDESCryptoServiceProvider();
            tdes.KeySize = keySize;
            tdes.GenerateIV();

            var ivStr = Convert.ToBase64String(tdes.IV);
           

            return ivStr;
        }
    }
}
