using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace cryptoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "Oturarak ayakta alkışlıyorum";

            Console.WriteLine(MD5Hash(data));
            Console.WriteLine(SHA1Hash(data));
            Console.WriteLine(SHA256Hash(data));
            Console.WriteLine(SHA384Hash(data));
            Console.WriteLine(SHA512Hash(data));

            Console.ReadKey();
        }

        // MD5
        public static string MD5Hash(string Data)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //Data byte dizisine dönüştürülüyor.
            byte[] hash = md5.ComputeHash(Encoding.ASCII.GetBytes(Data));   

            StringBuilder stringBuilder = new StringBuilder();

            foreach (byte b in hash)
            {
                //{0:x4} gibi formatlar da kullanılabilir.
                stringBuilder.AppendFormat("{0:x2}", b); 
            }
            return stringBuilder.ToString();
        }

        // SHA1
        public static string SHA1Hash(string Data)
        {
            SHA1 sha1 = new SHA1Managed();

            //Data byte dizisine dönüştürülüyor.
            byte[] hash = sha1.ComputeHash(Encoding.ASCII.GetBytes(Data));

            StringBuilder stringBuilder = new StringBuilder();

            foreach  (byte b in hash)
            {
                stringBuilder.AppendFormat("{0:x2}", b);
            }
            return stringBuilder.ToString();
        }

        // SHA256
        public static string SHA256Hash(string Data)
        {
            SHA256 sha256 = new SHA256Managed();  // SHA256CryptoServiceProvider() da kullanılabilir. Aynı sonucu alırız.

            //Data byte dizisine dönüştürülüyor.
            byte[] hash = sha256.ComputeHash(Encoding.ASCII.GetBytes(Data)); 

            StringBuilder stringBuilder = new StringBuilder();

            foreach (byte b in hash)
            {
                //{0:x4} gibi formatlar da kullanılabilir.
                stringBuilder.AppendFormat("{0:x2}", b);
            }
            return stringBuilder.ToString();
        }

        // SHA384
        public static string SHA384Hash(string Data)
        {
            SHA384 sha384 = new SHA384Managed();

            //Data byte dizisine dönüştürülüyor.
            byte[] hash = sha384.ComputeHash(Encoding.ASCII.GetBytes(Data));
            
            StringBuilder stringBuilder = new StringBuilder();

            foreach (byte b in hash)
            {
                stringBuilder.AppendFormat("{0:x2}", b);
            }
            return stringBuilder.ToString();
        }

        // SHA512
        public static string SHA512Hash(string Data)
        {
            SHA512 sha512 = new SHA512Managed();

            //Data byte dizisine dönüştürülüyor.
            byte[] hash = sha512.ComputeHash(Encoding.ASCII.GetBytes(Data));
            
            StringBuilder stringBuilder = new StringBuilder();

            foreach (byte b in hash)
            {
                stringBuilder.AppendFormat("{0:x2}", b);
            }
            return stringBuilder.ToString();
        }
    }
}
