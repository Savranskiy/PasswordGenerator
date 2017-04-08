using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public class Generator
    {
        private static char[] specChars = {
            '-', '?', '/', '@', '$', '*', '+',
            '=', '(', ')', '&', '#', ';', ':'
        };

        private static char[] chars = {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
        };

        public bool IsSpecific { get; set; }
        public int Size { get; set; }

        private static Generator instance = null;

        Generator()
        {
            IsSpecific = false;
            Size = 6;
        }
        
        public static Generator GetInstance()
        {
            if (instance == null)
                instance = new Generator();
            return instance;
        }

        /// <summary>
        /// Make chars list with special chars if it"s need.
        /// </summary>
        /// <returns>
        /// List of chars
        /// </returns>
        private char[] CharList()
        {
            if (IsSpecific)
                return chars.Concat(specChars).ToArray();
            return chars;
        }

        /// <summary>
        /// Generate password.
        /// </summary>
        /// <returns>
        /// Generated password
        /// </returns>
        public String Generate()
        {
            if (Size < 6)
                return "Password is too short";

            char[] password = new char[Size];
            char[] charList = CharList();

            Random rnd = new Random();
            for (int i = 0; i < Size; i++)
            {
                int position = rnd.Next(charList.Length);
                password[i] = charList[position];
            }

            return new string(password);
        }
    }
}
