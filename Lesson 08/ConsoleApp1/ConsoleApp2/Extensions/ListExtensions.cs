using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Extensions
{
    public static class ListExtensions
    {
        public static bool AllEven(this List<int> list)
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Collection is empty");
            }
            foreach (var item in list)
            {
                if (item % 2 != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}