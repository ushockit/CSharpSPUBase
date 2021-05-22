using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    public class ChatClient
    {
        Chat chat;
        public string Username { get; set; }
        public ChatClient(Chat chat)
        {
            this.chat = chat;
        }

        public void SendMessage(string message)
        {
            chat.Send(Username, message);
        }

        public void ReceiveMessage(string from, string message)
        {
            Console.WriteLine($"{Username}, receive message from {from} - {message}");
        }
        public void ClientConnectedMessage(string username)
        {
            Console.WriteLine($"{Username} receive: {username}, connected!");
        }
        public void ClientDisconnectedMessage(string username)
        {
            Console.WriteLine($"{Username} receive: {username}, disconnected!");
        }
    }
}
