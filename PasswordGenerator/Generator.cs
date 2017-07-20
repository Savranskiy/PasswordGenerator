using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public class Generator
    {
        const int LAST_INDEX = 61;

        private string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-?/@$*+=()&#;:";
        public bool IsSpecial { get; set; }
        public bool IsNumber { get; set; }
        public bool IsChars { get; set; }
        public int Size { get; set; }

        public Generator()
        {
            IsSpecial = false;
            Size = 6;
        }

        public String Generate()
        {
            if (Size < 6)
                return "Password is too short";

            (int, int) range = MakeRange();
            char[] password = new char[Size];

            Random rnd = new Random();
            for (int i = 0; i < Size; i++)
            {
                password[i] = chars[rnd.Next(range.Item1, range.Item2)];
            }

            return new string(password.OrderBy(x => rnd.Next()).ToArray());
        }

        private (int, int) MakeRange()
        {
            int lastIndex = IsSpecial ? chars.Length - 1 : LAST_INDEX;
            return (0, lastIndex);
        }
    }
}
