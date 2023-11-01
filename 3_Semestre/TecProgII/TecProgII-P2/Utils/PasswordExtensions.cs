using static BCrypt.Net.BCrypt;

namespace TecProgII_P2.Utils
{
    public static class PasswordExtensions
    {
        private const int WorkFactor = 12;

        public static string CodifyPassword(string password)
        {
            return HashPassword(password, WorkFactor);
        }

        public static bool ComparePassword(string password, string hash)
        {
            return Verify(password, hash);
        }
    }
}
