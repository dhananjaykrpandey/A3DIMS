using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Paddings;
using System.Text;

namespace A3DIMS
{
    public class ClsCrypto
    { 
        Encoding _encoding;
        IBlockCipherPadding _padding;
        string key = A3DIMS.ArnikaTechnologies.A3DKeyWord;
        private static ClsCrypto _iClsCrypto = null;
        public ClsCrypto()

        {
            _encoding = Encoding.ASCII;
            Pkcs7Padding pkcs = new Pkcs7Padding();
            _padding = pkcs;
             key = A3DIMS.ArnikaTechnologies.A3DKeyWord;

        }
        public static ClsCrypto _IClsCrypto
        {
            get
            {
                if (_iClsCrypto == null)
                {
                    _iClsCrypto = new ClsCrypto();
                }
                return _iClsCrypto;
            }

        }
       
        public string Encrypt(string StrTextToBeEncrypt)
        {
            return AESEncryption(StrTextToBeEncrypt, key, true);
        }

        public string Decrypt(string StrTextToBeDecrypt)
        {
            return AESDecryption(StrTextToBeDecrypt, key, true);
        }

        private string AESEncryption(string plain, string key, bool fips)
        {
            BCEngine bcEngine = new BCEngine(new AesEngine(), _encoding);
            bcEngine.SetPadding(_padding);
            return bcEngine.Encrypt(plain, key);
        }

        private string AESDecryption(string cipher, string key, bool fips)
        {
            BCEngine bcEngine = new BCEngine(new AesEngine(), _encoding);
            bcEngine.SetPadding(_padding);
            return bcEngine.Decrypt(cipher, key);
        }
    }
}
