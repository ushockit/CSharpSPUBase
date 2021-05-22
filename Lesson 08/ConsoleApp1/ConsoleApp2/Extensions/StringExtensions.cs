using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Extensions
{
    public static class StringExtensions
    {
        public static bool IsValidEmail(this string str)
        {
            return str.Length > 0 && str.Contains('@');
        }
    }
}
