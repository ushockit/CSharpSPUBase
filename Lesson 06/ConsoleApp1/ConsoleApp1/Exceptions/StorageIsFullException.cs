using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exceptions
{
    public class StorageIsFullException : ApplicationException
    {
        string _message;
        public override string Message => _message;
        public StorageIsFullException(string message) : base(message)
        {
            _message = message;
        }
    }
}
