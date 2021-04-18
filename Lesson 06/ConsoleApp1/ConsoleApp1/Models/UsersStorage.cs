using ConsoleApp1.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class UsersStorage : IStorage<User>
    {
        int count;
        public User[] Items { get; set; }

        public UsersStorage(int capacity)
        {
            count = 0;
            Items = new User[capacity];
        }

        public User Find(string username)
        {
            User user = null;

            for (int i = 0; i < count; i++)
            {
                if (Items[i].Username.Equals(username))
                {
                    user = Items[i];
                    break;
                }
            }

            if (user is null)
            {
                throw new UserNotFoundException("User doesn`t exists");
            }

            return user;
        }

        public void Create(User user)
        {
            if (count == Items.Length)
            {
                throw new StorageIsFullException("Storage is full");
            }
            Items[count++] = user;
        }
    }
}
