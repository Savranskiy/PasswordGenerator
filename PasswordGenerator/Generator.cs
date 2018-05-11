using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public class Generator
    {
        private readonly string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private readonly string extra = "-?/@$*+=()&#;:";
        public bool IsSpecial { get; set; }
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

            char[] password = new char[Size];
            string charList = IsSpecial ? chars + extra : chars;

            Random rnd = new Random();
            for (int i = 0; i < Size; i++)
            {
                password[i] = charList[rnd.Next(0, charList.Length - 1)];
            }

            return new string(password.OrderBy(x => rnd.Next()).ToArray());
        }
    }
}
