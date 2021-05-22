using ConsoleApp4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {

        //static event Action<string, string> MessageEvent;
        static void Main(string[] args)
        {
            //MessageEvent += MessageHandler;

            //MessageEvent("vasya", "Hello");

            Chat chat = new Chat();
            ChatClient client1 = new ChatClient(chat) { Username = "vasya" };
            ChatClient client2 = new ChatClient(chat) { Username = "petya" };
            ChatClient client3 = new ChatClient(chat) { Username = "masha" };
            ChatClient client4 = new ChatClient(chat) { Username = "kolya" };

            chat.AddClient(client1);
            chat.AddClient(client2);
            chat.AddClient(client3);
            chat.AddClient(client4);


            client1.SendMessage("Hello!");
            chat.RemoveClient(client2);
            client3.SendMessage("Hi!");

            Thread.Sleep(2000);
            chat.AddClient(new ChatClient(chat) { Username = "gosha" });

            Console.Read();
        }

        static void MessageHandler(string from, string message)
        {
            Console.WriteLine($"[{from}] {message}");
        }
    }
}
