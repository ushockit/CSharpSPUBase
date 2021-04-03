using System;

namespace ConsoleApp1
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"X = {X} Y = {Y}";
        }

        // -= Перегрузка унарных операторов =-
        public static Point operator ++(Point point)
        {
            point.X += 5;
            point.Y += 5;
            return point;
        }
        public static Point operator --(Point point)
        {
            point.X -= 5;
            point.Y -= 5;
            return point;
        }
        public static Point operator -(Point point) 
        {
            return new Point { X = -point.X, Y = -point.Y };
        }
        
        // -= Перегрузка бинарных операторов =-
        public static Point operator +(Point p1, Point p2)
        {
            return new Point 
            {
                X = p1.X + p2.X,
                Y = p1.Y + p2.Y
            };
        }
        public static Point operator *(Point point, int n)
        {
            return new Point
            {
                X = point.X * n,
                Y = point.Y * n
            };
        }

        // -= Перегрузка логических операторов =-
        public static bool operator >(Point p1, Point p2)
        {
            return p1.X > p2.X && p1.Y > p2.Y;
        }
        public static bool operator <(Point p1, Point p2)
        {
            return !(p1 > p2);
        }

        public static bool operator true(Point point)
        {
            return point.X > 0 && point.Y > 0;
        }
        public static bool operator false(Point point)
        {
            return point.X <= 0 || point.Y <= 0;
        }
        public static Point operator &(Point p1, Point p2)
        {
            if ((p1.X > 0 && p1.Y > 0) && (p2.X > 0 && p2.Y > 0))
            {
                return p2;
            }
            return new Point();
        }

    }
    class Money 
    {
        public decimal Total { get; set; }
        public int IntValue { get => (int)Total; }
        public decimal Rest { get => Total - IntValue; }

        public override string ToString()
        {
            return $"Total = {Total} Int = {IntValue} Rest = {Rest}";
        }

        public static explicit operator decimal(Money money)
        {
            return money.Total;
        }
        public static implicit operator Money(decimal money)
        {
            return new Money { Total = money };
        }
    }

    class MyList
    {
        int count;
        int[] data;

        public int this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }

        public MyList(int capacity)
        {
            data = new int[capacity];
            count = 0;
        }

        public void Add(int value)
        {
            if (count >= data.Length)
            {
                throw new OutOfMemoryException();
            }
            data[count++] = value;
        }

        public void Show()
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{data[i]} ");
            }
            Console.WriteLine();
        }
    }


    public class GameField
    {
        public const int ROAD_NUM = 1;
        int rows;
        int cols;
        int[,] field;

        public int this[int row, int col]
        {
            get 
            {
                if (row > rows -1 || col > cols - 1)
                {
                    throw new IndexOutOfRangeException();
                }
                return field[row, col];
            }
            set 
            {
                field[row, col] = value;
            }
        }
        public (int, int) this[int symb]
        {
            get
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (field[i, j] == symb)
                        {
                            return (i, j);
                        }
                    }
                }
                return (-1, -1);
            }
        }

        public GameField(int rows, int cols)
        {
            field = new int[rows, cols];
            this.rows = rows;
            this.cols = cols;

            Init();
        }

        public void Init()
        {
            Random rnd = new Random();
            int count = 2;
            while (count > 0)
            {
                int n1 = rnd.Next(0, rows);
                int n2 = rnd.Next(0, cols);

                for (int i = 0; i < cols; i++)
                {
                    field[n1, i] = ROAD_NUM;
                }

                for (int i = 0; i < rows; i++)
                {
                    field[i, n2] = ROAD_NUM;
                }

                count--;
            }
        }

        public void DrawField() 
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    switch (field[i, j])
                    {
                        case ROAD_NUM:
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write($"@ ");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"# ");
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }

    public enum Currency
    {
        UAH,
        EUR,
        USD
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point { X = 21, Y = 11 };
            //p++;
            //Console.WriteLine(p);
            //p++;
            //Console.WriteLine(p);
            //p--;
            //Console.WriteLine(p);

            // Унарный минус
            /*Point p2 = -p;
            Console.WriteLine(p2);

            // Сложение двух точек
            Point p3 = p + p2;
            Console.WriteLine(p3);*/

            // Умножение точки на число
            //Console.WriteLine(p);
            //Console.WriteLine(p * 2);

            // Использование перегруженного оператора true
            //if (p)
            //{
            //    Console.WriteLine("Success");
            //}


            /*Point point1 = new Point { X = 10, Y = 20 };
            Point point2 = new Point { X = 5, Y = 17 };

            if (point1 && point2)
            {
                Console.WriteLine("Success");
            }*/


            //Money money = new Money { Total = 567.35m };
            //Console.WriteLine(money);

            //decimal res = (decimal)money;
            //Console.WriteLine(res);

            //Money m2 = 167.9m;
            //Console.WriteLine(m2);


            /*MyList lst = new MyList(15);

            lst.Add(10);
            lst.Add(20);
            lst.Add(30);
            lst.Add(40);


            lst.Show();

            lst[1] = -60;
            lst[3] *= 2;

            lst.Show();*/

            /*GameField gameField = new GameField(10, 15);

            gameField[0, 0] = GameField.ROAD_NUM;
            gameField[1, 0] = GameField.ROAD_NUM;
            gameField[2, 0] = GameField.ROAD_NUM;
            gameField[3, 0] = GameField.ROAD_NUM;
            gameField[4, 0] = GameField.ROAD_NUM;

            gameField[6, 6] = 2;

            gameField.DrawField();


            Console.WriteLine(gameField[2]);*/



            string currency = "USD";
            if (Enum.IsDefined(typeof(Currency), currency))
            {
                Currency res = (Currency)Enum.Parse(typeof(Currency), currency);
                int value = (int)res;
                ;
            }


            Console.WriteLine();
        }
    }
}
