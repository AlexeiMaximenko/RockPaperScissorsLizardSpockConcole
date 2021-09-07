using SecurityDriven.Inferno;
using SecurityDriven.Inferno.Extensions;
using System.Security.Cryptography;
using static SecurityDriven.Inferno.SuiteB;
using static SecurityDriven.Inferno.Utils;
using PBKDF2 = SecurityDriven.Inferno.Kdf.PBKDF2;

namespace iTransitionTask3
    {
    class TurnHMAC
        {
        public static HMAC Get(string turnID)
            {
            var random = new CryptoRandom();
            var sha384 = HmacFactory;
            byte[] derivedKey;
            byte[] turnIdBytes = SafeUTF8.GetBytes(turnID);
            byte[] salt = random.NextBytes(384 / 8);
            PBKDF2 pbkdf2 = new PBKDF2(sha384, turnIdBytes, salt, 256 * 1000);
            derivedKey = pbkdf2.GetBytes(384 / 8);
            HMAC hmac = sha384();
            hmac.Key = derivedKey;
            hmac.ComputeHash(turnIdBytes).ToBase16();
            return hmac;
            }
        }
    }
