﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    public class Student
    {
        public string FirstName {get;set;}
        public string LastName { get; set; }

        public int Age { get; set; }

        public Student(string firstName,string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public override string ToString()
        {
            string result = string.Format($"{this.FirstName} {this.LastName} {this.Age}");
            return result;
        }
    }
}
