﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FileBasedDatabase.Data.Entities
{
    public class BaseDatabase
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Address { get; set; }
        public List<Book> Books { get; set; }
        public List<Visitor> Visitors { get; set; }
    }
}
