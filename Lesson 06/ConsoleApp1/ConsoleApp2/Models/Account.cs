﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class Account
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime Birth { get; set; } = DateTime.Now;
    }
}
