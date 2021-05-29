using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FileStream
            /*string data = "Hello world";
            // перевод строки в байты
            byte[] buff = Encoding.UTF8.GetBytes(data);

            
            // открытие потока
            FileStream fs = new FileStream("data.txt", FileMode.Create, FileAccess.Write);
            //запись данных в файл
            fs.Write(buff, 0, buff.Length);
            Console.WriteLine("Success write!");
            // закрытие потока
            fs.Close();
            */

            // конструкция 'using', доступна только дле тех объектов, которые реализовывают интерфейс 'IDisposable'
            /*using(FileStream fs = new FileStream("data.txt", FileMode.Open, FileAccess.Read))
            {
                //byte[] buff = new byte[100];
                //fs.Read(buff, 0, buff.Length);

                //// перевод байт в строку
                //string data = Encoding.UTF8.GetString(buff);

                //Console.WriteLine("Success read!");
                //Console.WriteLine(data);

                //List<byte> bytes = new List<byte>();
                //int b;

                //while((b = fs.ReadByte()) != -1)
                //{
                //    bytes.Add((byte)b);
                //}

                //string data = Encoding.UTF8.GetString(bytes.ToArray());
                //Console.WriteLine("Success read!");
                //Console.WriteLine(data);
            }*/
            #endregion

            #region  BinaryWriter/BinaryReader
            //using(FileStream fs = new FileStream("data.dat", FileMode.Create, FileAccess.Write))
            //{
            //    using (BinaryWriter writer = new BinaryWriter(fs, Encoding.UTF8))
            //    {
            //        writer.Write("Good morning!!!");
            //        Console.WriteLine("Success write!");
            //    }
            //}

            //using(FileStream fs = new FileStream("data.dat", FileMode.Open, FileAccess.Read))
            //{
            //    using (BinaryReader reader = new BinaryReader(fs, Encoding.UTF8))
            //    {
            //        string data = reader.ReadString();
            //        Console.WriteLine(data);
            //    }
            //}
            #endregion

            #region StreamWriter/StreamReader
            //using (var fs = new FileStream("data2.txt", FileMode.Create, FileAccess.Write))
            //{
            //    using(StreamWriter writer = new StreamWriter(fs, Encoding.UTF8))
            //    {
            //        writer.WriteLine("Hello!");
            //        writer.WriteLine("How are you?");
            //        writer.WriteLine("I`a fine, thank you!");
            //        Console.WriteLine("Success write!");
            //    }
            //}


            //using(FileStream fs = new FileStream("data2.txt", FileMode.Open, FileAccess.Read))
            //{
            //    using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
            //    {
            //        string line = null;
            //        while ((line = reader.ReadLine()) != null)
            //        {
            //            Console.WriteLine(line);
            //        }
            //    }
            //}
            #endregion

            #region File/FileInfo
            /*
            // проверка файла на существование
            if (File.Exists("data.txt"))
            {
                Console.WriteLine("Exists");
            }
            // чтение файла полностью
            string data = File.ReadAllText("data2.txt");
            Console.WriteLine(data);

            File.Encrypt("data2.txt");
            string text = File.ReadAllText("data2.txt");


            // получение информации о файле размер/доступность/расширение и т.п.
            FileInfo fi = new FileInfo("data2.txt");
            */
            #endregion

            #region Directory/DirectoryInfo
            /*
            // список путей к файлам
            string[] files = Directory.GetFiles("C:\\");

            // список путей к директориям
            string[] directories = Directory.GetDirectories("C:\\");

            //список дисков ОС
            string[] drives = Directory.GetLogicalDrives();


            DirectoryInfo di = new DirectoryInfo("C:\\Program Files");
            */

            #endregion

            #region Path
            /*
            string path = @"C:\Users\us\Downloads\логотипы\646px-Android_robot.png";
            Console.WriteLine(Path.GetRandomFileName());
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            Console.WriteLine(Path.GetExtension(path));
            Console.WriteLine(Path.GetDirectoryName(path));
            foreach (var symb in Path.GetInvalidFileNameChars())
            {
                Console.Write($"{symb} ");
            }
            Console.WriteLine();
            string res = Path.Combine("C:\\", "Program Files", "Android", "Emulator");
            */
            #endregion


            Console.Read();
        }
    }
}
