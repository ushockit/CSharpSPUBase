using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    // https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=net-5.0
    class AccountModel
    {
        [Required]
        [StringLength(16, MinimumLength = 4, ErrorMessage = "Длина логина должна быть от 4 до 16 символов")]
        public string Login { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Проверьте правильность ввода пароля")]
        [StringLength(12, MinimumLength = 8, ErrorMessage = "Длина пароля должна быть от 8 до 16 символов")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Проверьте правильность ввода email")]
        public string Email { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //dynamic val = 10;
            //val = "Hello";

            //Console.WriteLine(val);

            //dynamic obj = new ExpandoObject();
            //obj.item = new { Name = "Vasya", Address = new { Street = "Kirova" } };
            //obj.sayHi = (Action)(() => { Console.WriteLine("Hi"); });

            //obj.sayHi();
            //Console.WriteLine(obj.item.Address.Street);


            //string json = JsonConvert.SerializeObject(obj);
            //Console.WriteLine(json);


            //string value = "hello";

            //if (value.Length >= 4 && value.Length <= 16)
            //{

            //}

            //if (Regex.IsMatch(value, @"^\w+$"))
            //{

            //}


            var accModel = new AccountModel
            {
                Email = "vasya@gmail.com",
                Login = "vasya",
                Password = "12345678",
                ConfirmPassword = "12345678"
            };

            var results = new List<ValidationResult>();
            var context = new ValidationContext(accModel);

            if (!Validator.TryValidateObject(accModel, context, results, true))
            {
                string errs = string.Join("\n", results.Select(res => res.ErrorMessage));
                Console.WriteLine(errs);
            }
            else
            {
                Console.WriteLine("VALID");
            }







            Console.Read();
        }
    }
}
