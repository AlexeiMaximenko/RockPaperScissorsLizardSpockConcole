using SecurityDriven.Inferno;
using System.Security.Cryptography;
using System.Text;

namespace iTransitionTask3
    {
    class TurnHMAC
        {
        public static HMACSHA256 Get(string turnName)
            {
            CryptoRandom random = new CryptoRandom();
            byte[] turnIdBytes = Encoding.UTF8.GetBytes(turnName.ToCharArray());
            HMACSHA256 hmac = new HMACSHA256(random.NextBytes(16));
            hmac.ComputeHash(turnIdBytes);
            return hmac;
            }
        }
    }
