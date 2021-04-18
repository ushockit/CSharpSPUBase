using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDemo.Models
{
    public class DatabaseConnection : IDisposable
    {
        public void Connect()
        {

        }
        public void Close()
        {
            Console.WriteLine("Закрытие подключения...");
        }
        private bool isDisposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (!isDisposed)
                {
                    Close();
                }
                isDisposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
