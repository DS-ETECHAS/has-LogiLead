using Konscious.Security.Cryptography;
using System.Text;

namespace LogiLead.api.Services
{
    public class HashService
    {
        public string HashPassword(string password)
        {
            using var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password));

            argon2.Salt = CreateSalt();
            argon2.DegreeOfParallelism = 8; // or any other number
            argon2.MemorySize = 65536; // in KB
            argon2.Iterations = 4;

            return Convert.ToBase64String(argon2.GetBytes(16)); // or another size
        }

        public bool VerifyPassword(string password, string hash)
        {
            var passwordHashBytes = Convert.FromBase64String(hash);
            var passwordBytes = Encoding.UTF8.GetBytes(password);

            // Create a new instance of Argon2 with the same parameters and compare
            using var argon2 = new Argon2id(passwordBytes)
            {
                Salt = passwordHashBytes,
                DegreeOfParallelism = 8,
                MemorySize = 65536,
                Iterations = 4
            };

            var newHash = argon2.GetBytes(16);
            return newHash.SequenceEqual(passwordHashBytes);
        }

        public byte[] CreateSalt()
        {
            var buffer = new byte[16];
            var rng = new Random();
            rng.NextBytes(buffer);
            return buffer;
        }
    }
}
