﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3EFCoreDemo.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
        public DateTime HiringDate { get; set; }=DateTime.UtcNow;

        public int DeptId { get; set; }

        public virtual Department WorkFor { get; set; }

    }
}
