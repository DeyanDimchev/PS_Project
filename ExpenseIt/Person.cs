﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseIt
{
    internal class Person
    {
        public string Name { get; set; }
        public string Department;
        public List<Expense> Expenses;
    }
}
