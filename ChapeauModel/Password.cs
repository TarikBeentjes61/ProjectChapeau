using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Password
    {
        private string salt;
        private string hash;

        public Password()
        {

        }
        public Password(string salt, string hash)
        {
            this.salt = salt;
            this.hash = hash;
        }
        //To encrypt a password when a new employee is added
        public Password HashWithSalt(string password, int saltLength, HashAlgorithm hashAlgo)
        {
            RNG rng = new RNG();
            byte[] saltBytes = rng.GenerateRandomCryptographicBytes(saltLength);
            byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);
            List<byte> passwordWithSaltBytes = new List<byte>();
            passwordWithSaltBytes.AddRange(passwordAsBytes);
            passwordWithSaltBytes.AddRange(saltBytes);
            byte[] digestBytes = hashAlgo.ComputeHash(passwordWithSaltBytes.ToArray());
            return new Password(Convert.ToBase64String(saltBytes), Convert.ToBase64String(digestBytes));
        }
        //Returns a bool if hash is equal to given password
        public bool Verify(string password, string salt, string hash)
        {
            HashAlgorithm hashAlgo = SHA256.Create();
            //encrypts the used password
            byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);
            List<byte> passwordWithSaltBytes = new List<byte>();
            passwordWithSaltBytes.AddRange(passwordAsBytes);
            passwordWithSaltBytes.AddRange(Convert.FromBase64String(salt));
            byte[] digestBytes = hashAlgo.ComputeHash(passwordWithSaltBytes.ToArray());

            //checks if password is equal to input
            return hash == Convert.ToBase64String(digestBytes);
        }

    }
}
