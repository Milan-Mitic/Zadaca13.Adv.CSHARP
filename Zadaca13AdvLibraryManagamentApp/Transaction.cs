﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca13AdvLibraryManagamentApp
{
    public class Transaction
    {
        public User User { get; set; }
        public Book Book { get; set; }
        public DateTime Date { get; set; }
    }
}
