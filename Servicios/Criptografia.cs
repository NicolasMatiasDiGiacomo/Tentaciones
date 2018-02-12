using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Servicios
{
    public class Criptografia
    {
        public string encriptar(string valor)
        {
            TripleDESCryptoServiceProvider tripleDes = new TripleDESCryptoServiceProvider();
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            byte[] valorByte = System.Text.Encoding.Unicode.GetBytes(valor);

            tripleDes.Key = crearNuevoHash("Ten_", tripleDes.KeySize / 8);
            tripleDes.IV = crearNuevoHash("", tripleDes.BlockSize / 8);

            CryptoStream encStream = new CryptoStream(ms, tripleDes.CreateEncryptor(),
                                                      System.Security.Cryptography.CryptoStreamMode.Write);

            encStream.Write(valorByte, 0, valorByte.Length);
            encStream.FlushFinalBlock();
            return Convert.ToBase64String(ms.ToArray());
        }

        public string desencriptar(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                return null;
            }

            TripleDESCryptoServiceProvider tripleDes = new TripleDESCryptoServiceProvider();
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            byte[] valorByte = Convert.FromBase64String(valor);

            tripleDes.Key = crearNuevoHash("Ten_", tripleDes.KeySize / 8);
            tripleDes.IV = crearNuevoHash("", tripleDes.BlockSize / 8);

            CryptoStream decStream = new CryptoStream(ms, tripleDes.CreateDecryptor(),
                                                      System.Security.Cryptography.CryptoStreamMode.Write);

            decStream.Write(valorByte, 0, valorByte.Length);
            decStream.FlushFinalBlock();

            return System.Text.Encoding.Unicode.GetString(ms.ToArray());
        }



        public byte[] crearNuevoHash(string valorHash, int largoHash)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] hash = sha1.ComputeHash(System.Text.Encoding.Unicode.GetBytes(valorHash));
            Array.Resize(ref hash, largoHash);
            return hash;
        }
    }
}
