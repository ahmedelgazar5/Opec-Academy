﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpecDataBase.DAL.Models
{
    public class Language
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public bool IsDeleted { get; set; } = false;
    }
}
