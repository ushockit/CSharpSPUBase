using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLibrary
{
    public class DbConnection
    {
        private string connectionString = string.Empty;

        public string DbName { get; set; }
        public string User { get; set; }
    }
}
