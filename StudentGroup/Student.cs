using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
    class Student
    {
        // Fields
        private string firstName;
        private string lastName;
        private string fn;
        private string telephone;
        private string email;
        private List<int> marks;
        private int groupNumber;

        // Constructor
        public Student(string firstName, string lastName, string fn, string telephone, string email, List<int> marks, int groupNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.fn = fn;
            this.telephone = telephone;
            this.email = email;
            this.marks = marks;
            this.groupNumber = groupNumber;
        }

        //Properties

        public string FirstName
        {
            set { this.firstName = value; }
            get { return this.firstName; }
        }

        public string LastName
        {
            set { this.lastName = value; }
            get { return this.lastName; }
        }

        public string FN
        {
            set { this.fn = value; }
            get { return this.fn; }
        }

        public string Telephone
        {
            set { this.telephone = value; }
            get { return this.telephone; }
        }

        public string Email
        {
            set { this.email = value; }
            get { return this.email; }
        }

        public List<int> Marks
        {
            get { return this.marks; }
        }

        public int GroupNumber
        {
            set{ this.groupNumber = value; }
            get { return this.groupNumber; }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Name : {this.firstName} {this.lastName} . FN : {this.fn} . Telephone : {this.telephone} . Email : {this.email} . Group Number : {this.groupNumber}");
            result.Append("Marks : ");
            for (int i = 0; i < marks.Count; i++)
            {
                if(i == marks.Count -1) result.Append($"{marks[i]}");
                else result.Append($"{marks[i]} , ");
            }
            return result.ToString();
        }
    }
}
