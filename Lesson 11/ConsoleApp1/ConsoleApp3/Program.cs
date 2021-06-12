using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class AgeValidationAttribute : Attribute
    {
        public int Age { get; set; }

        public AgeValidationAttribute() { }

        public AgeValidationAttribute(int age)
        {
            Age = age;
        }
    }

    public class AccountModel
    {
        [AgeValidation(18)]
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(AccountModel);

            var prop = type.GetProperties()[0];
            var attr = prop.GetCustomAttributes(false)[0];

            

            Console.Read();
        }
    }
}
