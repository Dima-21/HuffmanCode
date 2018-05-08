using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Hofman
{
    class CountSymbol
    {
        List<Count> count = new List<Count>();

        public void InitCount(string str)
        {
            var unique = str.Distinct();
            foreach (var item in unique)
            {
                count.Add(new Count()
                {
                    symbol = item,
                    count = str.Where(x=> x == item).Count()
                });
            }
            count.Sort((a, b) => a.count - b.count);
        }

        public void Show()
        {
            foreach (var item in count)
                Console.WriteLine(item);
        }


    }
}
