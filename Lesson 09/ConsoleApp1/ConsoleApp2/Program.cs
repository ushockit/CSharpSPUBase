using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string regExp = @"(?<country>\+?38\s?)?\(?(?<operator>\d{3})\)?(?<phone>(\s?-?\s?\d{2,3}){3})";
            //            string text = @"Lorem ipsum dolor sit amet, consectetur 
            //adipiscing elit, sed do eiusmod tempor incididunt 
            //ut labore et dolore magna aliqua. 380669083311 Ut enim ad minim
            //veniam,(056)-908-67-85 quis nostrud exercitation +38(073)-980-27-13 ullamco laboris 
            //nisi ut aliquip ex ea commodo consequat. 
            //Duis aute irure dolor +380990878965 in reprehenderit in
            //voluptate velit +38 (073) - 980 - 27 - 13 esse cillum dolore eu fugiat 
            //nulla pariatur. Excepteur sint 0671289543 occaecat 
            //cupidatat non +38 proident, sunt in culpa qui
            //officia deserunt mollit anim id est laborum.";


            //            MatchCollection collection = Regex.Matches(text, regExp);
            //            foreach (Match match in collection)
            //            {
            //                Console.WriteLine($"{match.Value}, {match.Index} idx");
            //                Console.WriteLine($"\t{match.Groups["country"]}");
            //                Console.WriteLine($"\t{match.Groups["operator"]}");
            //                Console.WriteLine($"\t{match.Groups["phone"]}");
            //            }

            string phone = "380669083+-311";
            string regExp = @"^(?<country>\+?38\s?)?\(?(?<operator>\d{3})\)?(?<phone>(\s?-?\s?\d{2,3}){3})$";
            if (Regex.IsMatch(phone, regExp))
            {
                Console.WriteLine("VALID");
            }
            else
            {
                Console.WriteLine("INVALID");
            }



            Console.Read();
        }
    }
}
