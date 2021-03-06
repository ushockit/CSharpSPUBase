using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01
{
    class Program
    {
        static void Main(string[] args)
        {
            //вывод на консоль без перевода строки
            Console.Write("Hello");
            Console.Write(" world!!!");

            //вывод на консоль с переводом строки
            Console.WriteLine();
            Console.WriteLine("Hello");
            Console.WriteLine(" world!!!");

            Console.WriteLine("Hello" + " world");


            int a = 10;
            bool _bool = true;
            char _char = 'z';
            double _double = 5.35;
            decimal _decimal = 10.8m;
            string _string = "Hello";


            Console.WriteLine("a = " + a);

            //упрощение экранирования
            Console.WriteLine(@"C:\Program Files\Some Folder");

            //интерполяция
            Console.WriteLine($"Value - {a}");
            string name = "Vasya";
            Console.WriteLine($"Hello, {name}");

            string s1 = "Hello world";

            // -= Ввод данных с клавиатуры =-
            /*Console.Write("Enter your string: ");
            //ожидание ввода строки
            string str = Console.ReadLine();
            Console.WriteLine($"Your string '{str}'");*/

            //Console.Write("Enter symb: ");
            //ConsoleKeyInfo key = Console.ReadKey();
            //if (key.Key == ConsoleKey.G)
            //{
            //    Console.WriteLine("Hello C#");
            //}
            //Console.WriteLine($"Symb '{key.KeyChar}'");


            /*if (key.Key == ConsoleKey.S &&
                key.Modifiers == ConsoleModifiers.Control)
            {
                Console.WriteLine("Ctrl + S");
            }*/


            /*string str = Console.ReadLine();
            //преобразование из строки в число
            int b = int.Parse(str);*/
            //int b = int.Parse(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());

            //string[] words = new string[] { "Word 1", "Word 2", "Word 3", "Word 4", "Word 5" };

            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}

            /*foreach (string w in words)
            {
                Console.WriteLine(w);
            }*/

            /*string str = " Hello world";
            Console.WriteLine(str);
            Console.WriteLine($"Length = {str.Length}");
            Console.WriteLine($"Substring = {str.Substring(2, 3)}");
            Console.WriteLine($"Trim = {str.Trim()}");
            //строка начинается с пробела
            if (str.StartsWith(" ")) 
            {
                Console.WriteLine("True");
            }*/
            string str = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.";

            //разбиение строки на массив слов
            string[] words = str.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);


            /*int[] nums = new int[10];
            //класс для генерирования случайных чисел
            Random rnd = new Random();

            //заполнение массива случайными числами
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(10, 100);
                Console.WriteLine(nums[i]);
            }*/

            Random rnd = new Random();
            //объявление двумерного массива
            /*int[,] dArr = new int[5, 7];
            Console.WriteLine($"Total size = {dArr.Length}");
            Console.WriteLine($"Rows = {dArr.GetLength(0)}");
            Console.WriteLine($"Cols = {dArr.GetLength(1)}");

            for (int i = 0; i < dArr.GetLength(0); i++)
            {
                for (int j = 0; j < dArr.GetLength(1); j++)
                {
                    dArr[i, j] = rnd.Next(10, 20);
                    Console.Write($"{dArr[i, j]} ");
                }
                Console.WriteLine();
            }*/

            //Двумерный рваный массив
            /*int[][] dArr = new int[10][];

            for (int i = 0; i < dArr.GetLength(0); i++)
            {
                //создание массива с случайным кол-вом ячеек
                dArr[i] = new int[rnd.Next(5, 15)];
                for (int j = 0; j < dArr[i].Length; j++)
                {
                    dArr[i][j] = rnd.Next(10, 20);
                    Console.Write($"{dArr[i][j]} ");
                }
                Console.WriteLine();
            }*/



            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(10, 20);
            }

            int[] arr2 = new int[arr.Length];

            //копирование одного массива в другой
            Array.Copy(arr, arr2, arr.Length);





            Console.Read();
        }
    }
}
