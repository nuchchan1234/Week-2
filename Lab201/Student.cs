using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student
    {
        public string Name;
        public string StudentID;
        private int year;
        public int YearOfBirth
        {
            get { return year; }
            set
            {
                if (value >= 1950 && value <= 2000)
                {
                    year = value;


                }
                else
                {
                    Console.WriteLine("{0}: error try setting invalid year-of-birth value!", StudentID);
                }
            }
        }
        public bool isActive;
        public Student()
        {
            this.Name = "John Doe";
            this.StudentID = "Unknown";
            this.YearOfBirth = 1995;
            this.isActive = false;
        }
        public Student(string n, string id)
        {
            this.Name = n;
            this.StudentID = id;
            this.YearOfBirth = 1995;
            this.isActive = true;
        }
        public Student(string n, string id, int y)
        {
            this.Name = n;
            this.StudentID = id;
            this.YearOfBirth = y;
            this.isActive = true;


        }
        public Student(string Name, string StudentID, int YearOfBirth, bool isActive)
        {
            this.Name = Name;
            this.StudentID = StudentID;
            this.YearOfBirth = YearOfBirth;
            this.isActive = isActive;
        }

        public int getAge()
        {
            
            int y = YearOfBirth;
            return DateTime.Now.Year - y;
        }

        public override string ToString()
        {
            string active;
            if (isActive == true)
            {
                active = "is active student";
            }
            else
            {
                active = "is NOT active student";
            }


            return "[Student: " + Name + "( " + StudentID + ") , age= " + getAge() + " ," + active + "]";

        }

    }
}
