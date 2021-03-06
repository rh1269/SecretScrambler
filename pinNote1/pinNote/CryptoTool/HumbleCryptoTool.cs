﻿using SecretScrambler.Enums;
using SecretScrambler.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecretScrambler.CryptoTool
{
    /// <summary>
    /// HumbleCrypt - Quick, Simple, Basic Encryption strategy.  Significantly less secure than the other CryptoTools.
    /// </summary>
    public class HumbleCryptoTool : iCryptoTool
    {
        private readonly EncryptionTypeEnum EncryptionType = EncryptionTypeEnum.Humble;

        public string EncryptRun(string message, string password)
        {
            //Requires int
            int shiftBy = TransformHelper.PasswordStrToKeyInt(password);

            byte[] bytesToShift = Encoding.Unicode.GetBytes(message);

            int byteCount = bytesToShift.Length;

            var shifted = new byte[byteCount];

            for (int x = 0; x < byteCount; x++)
            {
                var b = bytesToShift[x];

                byte temp;

                if (x % 2 == 0)
                {
                    temp = (byte)(b + shiftBy);
                }
                else
                {
                    temp = (byte)(b - shiftBy);
                }

                shifted[x] = temp;
            }

            var shiftedString = Encoding.Unicode.GetString(shifted);

            return shiftedString;
        }


        public string DecryptRun(string message, string password)
        {
            //Requires int
            int shiftBy = TransformHelper.PasswordStrToKeyInt(password);

            byte[] bytesToShift = Encoding.Unicode.GetBytes(message);

            int byteCount = bytesToShift.Length;
            var shifted = new byte[byteCount];

            for (int x = 0; x < byteCount; x++)
            {
                var b = bytesToShift[x];

                byte temp;

                if (x % 2 == 0)
                {
                    temp = (byte)(b - shiftBy);
                }
                else
                {
                    temp = (byte)(b + shiftBy);
                }

                shifted[x] = temp;
            }

            var shiftedString = Encoding.Unicode.GetString(shifted);

            return shiftedString;
        }

        public EncryptionTypeEnum GetEncryptionType()
        {
            return EncryptionType;
        }

        public byte[] GetCurrentIV()
        {
            return null;
        }

        public string GenerateNewIVString()
        {
            return string.Empty;
        }
    }
}
