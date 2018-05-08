using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Hofman
{
    class Program
    {
        static void Main(string[] args)
        {
            CountSymbol hc = new CountSymbol();
            hc.InitCount("Hello");
            hc.Show();
        }
    }
}
