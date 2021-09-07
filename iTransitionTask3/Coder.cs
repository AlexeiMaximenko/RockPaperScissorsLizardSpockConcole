using System;
using System.Security.Cryptography;
using Core.Security.Cryptography;
using System.Text;

class Coder
    {
    public static byte[] GetNewKey()
        {
        byte[] random = new Byte[16];
        RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
        rng.GetBytes(random);
        return random;
        }

    public static string GetHMAC(string key)
        {
        SHA3.Create(key);
        }

    public static string ByteDecoder(byte[] key)
        {
        string result = "";
        for(int i = 0; i < key.Length; i++)
            {
            result += Convert.ToString(key[i]);
            }
        return result;
        }

    }
