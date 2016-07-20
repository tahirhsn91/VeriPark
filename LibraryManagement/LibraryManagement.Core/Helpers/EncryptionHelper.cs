using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Core.Helpers
{
    public class EncryptionHelper
    {
        private static string passPhrase = "Tahir Hassan";
        public static string Encrypt(string plainText)
        {
            return Common.Helpers.EncryptionHelper.Encrypt(plainText, passPhrase);
        }

        public static string Decrypt(string cipherText)
        {
            return Common.Helpers.EncryptionHelper.Decrypt(cipherText, passPhrase);
        }
    }
}
