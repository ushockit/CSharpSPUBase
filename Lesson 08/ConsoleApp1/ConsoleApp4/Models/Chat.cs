using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    public class Chat
    {
        event Action<string, string> SendMessageEvent;
        event Action<string> NewClientConnectedEvent;
        event Action<string> ClientDisconnectedEvent;
        public void Send(string from, string message)
        {
            //вызов события
            SendMessageEvent(from, message);
        }

        public void AddClient(ChatClient client)
        {
            NewClientConnectedEvent?.Invoke(client.Username);
            SendMessageEvent += client.ReceiveMessage;
            NewClientConnectedEvent += client.ClientConnectedMessage;
            ClientDisconnectedEvent += client.ClientDisconnectedMessage;
        }
        public void RemoveClient(ChatClient client) 
        {
            SendMessageEvent -= client.ReceiveMessage;
            NewClientConnectedEvent -= client.ClientConnectedMessage;
            ClientDisconnectedEvent -= client.ClientDisconnectedMessage;
            ClientDisconnectedEvent?.Invoke(client.Username);
        }
    }
}
