using System;
using System.Collections;

namespace ConsoleApp2
{
    class List<T> : IEnumerable, IEnumerator
    {
        T[] data;
        int count;
        int index;

        public List(int capacity)
        {
            count = 0;
            index = -1;
            data = new T[capacity];
        }

        public object Current => data[index];

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            return ++index < count;
        }

        public void Reset()
        {
            index = -1;
        }

        public void Add(T item)
        {
            if (count == data.Length)
            {
                throw new OutOfMemoryException();
            }
            data[count++] = item;
        }
    }


    class Person : IComparable<Person>, ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Person person)
        {
            return LastName.CompareTo(person.LastName);
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName} {Birth}";
        }
    }

    class PeopleComparer : IComparer
    {
        public int Compare(object o1, object o2)
        {
            Person p1 = o1 as Person;
            Person p2 = o2 as Person;

            return p1.Birth > p2.Birth ? 1 : p1.Birth < p2.Birth ? -1 : 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] arr = new int[] { 1, 2, 3, 4, 5, };

            foreach (var item in arr)
            {
                Console.Write(item);
            }
            Console.WriteLine();*/


            List<int> list = new List<int>(15);

            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //ForEach(list);

            Person[] people = new Person[]
            {
                new Person { FirstName = "First name 7", LastName = "Last name 7", Birth = new DateTime(1990, 10, 20) },
                new Person { FirstName = "First name 1", LastName = "Last name 1", Birth = new DateTime(2000, 03, 15) },
                new Person { FirstName = "First name 3", LastName = "Last name 3", Birth = new DateTime(1988, 01, 17) },
            };

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine(new string('-', 15));

            //Array.Sort(people);
            Array.Sort(people, new PeopleComparer());

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine(new string('-', 15));



            Person p = new Person { FirstName = "First name 7", LastName = "Last name 7", Birth = new DateTime(1990, 10, 20) };

            Person p2 = p.Clone() as Person;

        }

        static void ForEach(IEnumerable enumerable)
        {
            IEnumerator enumerator = enumerable.GetEnumerator();
            enumerator.Reset();

            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
