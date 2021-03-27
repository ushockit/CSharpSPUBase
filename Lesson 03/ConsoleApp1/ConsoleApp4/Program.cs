using ConsoleApp4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new SimplePlayer();
            int stepCounter = 0;
            while(true)
            {
                Console.WriteLine(player);

                ConsoleKey key = Console.ReadKey().Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        player.MoveUp();
                        break;
                    case ConsoleKey.DownArrow:
                        player.MoveDown();
                        break;
                    case ConsoleKey.LeftArrow:
                        player.MoveLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        player.MoveRight();
                        break;
                    case ConsoleKey.Q:
                        player.AddHealth();
                        break;
                }
                stepCounter++;


                if (stepCounter == 10)
                {
                    player = HeroPlayer.CreateInstance(player);
                }
            }
        }
    }
}
