﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLoadingIncludeLoad.Models
{
    internal class Position
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<User> Users { get; set; } = new();
    }
}
