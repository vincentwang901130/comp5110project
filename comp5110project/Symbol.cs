using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp5110project
{
    public class Symbol : Formula
    {
        private char letter;

        public Symbol(char l)
        {
            // Input must be a letter between a and z.
            if (charIsEnglishLetter(l))
            {
                letter = l;
            }
            else
            {
                throwException();
            }
        }

        public char getLetter()
        {
            return letter;
        }
        public String toString()
        {
            char[] charArr = new char[1];
            charArr[0] = letter;
            return new String(charArr);
        }
        public static Boolean charIsEnglishLetter(char l)
        {
            return ((l >= 'a') && (l <= 'z'));
        }
        private void throwException()
        {
            throw new Exception("Input to Symbol(char) must be an English letter");
        }
    }
}
