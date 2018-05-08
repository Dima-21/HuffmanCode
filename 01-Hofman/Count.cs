using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Hofman
{
    struct Count
    {
        public char symbol;
        public int count;
        public bool Found(char s)
        {
            if (symbol == s)
                return true;
            return false;
        }
        public override string ToString()
        {
            return $"{symbol} - {count}"; 
        }

    }
}
