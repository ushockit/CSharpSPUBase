using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        const int SIZE = 4;
        const int ZERO = 0;
        static string username;
        static int[,] gameField = new int[SIZE, SIZE];
        static Random rnd = new Random();
        //позиция 0 на поле
        static int emptyCellRow;
        static int emptyCellCol;

        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            username = "Vasya";
            //username = Console.ReadLine();

            Start();

            Console.Read();
        }

        static void Start()
        {
            //инициализация
            Init();
            //перемешивание массива
            Shuffle();

            while(true)
            {
                //очистка консоли
                Console.Clear();
                //текст приветствия пользователя
                WelcomeText();
                //вывод поля
                DrawField();

                ConsoleKeyInfo key = Console.ReadKey();

                //обработка нажатой клавиши
                ProccessKey(key.Key);
            }
        }

        static void WelcomeText()
        {
            Console.WriteLine($"Hello, {username}");
        }

        static void ProccessKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    MoveToUp();
                    break;
                case ConsoleKey.DownArrow:
                    MoveToDown();
                    break;
                case ConsoleKey.LeftArrow:
                    MoveToLeft();
                    break;
                case ConsoleKey.RightArrow:
                    MoveToRight();
                    break;
            }
        }

        static void MoveToRight()
        {
            if (emptyCellCol > 0)
            {
                int tmp = gameField[emptyCellRow, emptyCellCol - 1];
                gameField[emptyCellRow, emptyCellCol - 1] = ZERO;
                gameField[emptyCellRow, emptyCellCol] = tmp;
                emptyCellCol--;
            }
        }

        static void MoveToLeft()
        {
            if (emptyCellCol < SIZE - 1)
            {
                int tmp = gameField[emptyCellRow, emptyCellCol + 1];
                gameField[emptyCellRow, emptyCellCol + 1] = ZERO;
                gameField[emptyCellRow, emptyCellCol] = tmp;
                emptyCellCol++;
            }
        }

        static void MoveToDown()
        {
            throw new NotImplementedException();
        }

        static void MoveToUp()
        {
            throw new NotImplementedException();
        }

        static void DrawField()
        {
            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    if (gameField[i, j] != ZERO)
                        Console.Write($"{gameField[i, j], 3}");
                    else
                        Console.Write($"{" ", 3}");
                }
                Console.WriteLine();
            }
        }
        static void Init()
        {
            //инициализация позиции нуля
            emptyCellCol = emptyCellRow = SIZE - 1;

            int counter = 1;
            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    gameField[i, j] = counter++;
                }
            }
            gameField[SIZE - 1, SIZE - 1] = ZERO;
        }

        static void Shuffle()
        {

            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    int i1 = rnd.Next(0, SIZE);
                    int j1 = rnd.Next(0, SIZE);
                    int i2 = rnd.Next(0, SIZE);
                    int j2 = rnd.Next(0, SIZE);

                    int tmp = gameField[i1, j1];
                    gameField[i1, j1] = gameField[i2, j2];
                    gameField[i2, j2] = tmp;
                }
            }
            MoveZeroToLastCell();
        }

        static void MoveZeroToLastCell()
        {
            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    if (gameField[i, j] == ZERO)
                    {
                        gameField[i, j] = gameField[SIZE - 1, SIZE - 1];
                        gameField[SIZE - 1, SIZE - 1] = ZERO;
                        return;
                    }
                }
            }
        }
    }
}
