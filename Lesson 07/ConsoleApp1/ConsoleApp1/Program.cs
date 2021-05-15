using ConsoleApp1.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // -= ArrayList =-
            //ArrayList list = new ArrayList();
            //list.Add(10);
            //list.Add(true);
            //list.Add("Hello");
            //list.AddRange(new int[] { 1, 2, 3, 4, 5 });

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            // -= Stack =-
            //Stack stack = new Stack();
            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);
            //stack.Push(40);
            //stack.Pop();
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            // -= Queue =-
            //Queue queue = new Queue();
            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //queue.Enqueue(30);

            //queue.Dequeue();

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            // -= Hashtable =-
            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(1, "Hello");
            //hashtable.Add(2, "World");
            //hashtable.Add('a', 10);

            //foreach (var key in hashtable.Keys)
            //{
            //    Console.WriteLine(hashtable[key]);
            //}

            // -= SortedList =-
            //SortedList list = new SortedList();
            //list.Add(10, 1);
            //list.Add(-5, 190);
            //list.Add(13, 250);

            //foreach (var key in list.Keys)
            //{
            //    Console.WriteLine(list[key]);
            //}


            // -= Generics =-

            //List<int> list = new List<int>();
            //List<List<int>> dList = new List<List<int>>();

            //List<Person> people = new List<Person>();

            Dictionary<string, int> dict = new Dictionary<string, int>();
            string str = "Lorem ipsum dolor sit amet, lorem consectetur adipiscing elit, sed do lorem eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            var words = str.Split(new char[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var w in words)
            {
                int val;
                string key = w.ToLower();
                if (dict.TryGetValue(key, out val))
                {
                    //val++;
                    //dict[w] = val;
                    dict[key]++;
                }
                else
                {
                    dict.Add(key, 1);
                }
            }

            foreach (var key in dict.Keys)
            {
                Console.WriteLine($"{key} = {dict[key]}");
            }
            

            Console.WriteLine("Hello World!");
        }
    }
}
