using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public int Pages { get; set; }
        public string Description { get; set; }
    }
}
