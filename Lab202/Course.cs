using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Course
    {
        public string Name;
        private string courseID;
        public string CourseID
        {
            get { return courseID; }

            set
            {
                int snum;
                bool isNumeric = int.TryParse(value, out snum);

                if (value.Length == 6 && isNumeric)
                {
                    courseID = value;
                }

                else
                {
                    Console.WriteLine("{0}: error try setting invalid CourseID!", courseID);
                }
            }

        }
        public string Lecturer;
        private int num;
        public int NumStudents
        {
            get { return num; }
            set
            {
                if (value <= MaxStudents && value >= 0)
                {
                    num = value;

                }
                else
                {

                    Console.WriteLine("{0}: error try setting invalid No. Students!", CourseID);

                }



            }
        }

        private int max;
        public int MaxStudents
        {
            get { return max; }
            set
            {
               if (value >= 0 && value <= 80 && value >= NumStudents)
                {
                    max = value;
                    
                }
                else
                {
                    
                    Console.WriteLine("{0}: error try setting invalid Max No. Students!", CourseID);
                    

                }
                
            }
        }
        

        public Course()
        {
            this.Name = "unknown";
            this.CourseID = "unknown";
            this.Lecturer = "staff";
            this.MaxStudents = 30;
            this.NumStudents = 0;
            
        }

        public Course(string Name, string CourseID)
        {
            this.Name = Name;
            this.CourseID = CourseID;
            this.Lecturer = "staff";
            this.MaxStudents = 30;
            this.NumStudents = 0;

        }
        public Course(string Name, string CourseID,string Lecturer)
        {
            this.Name = Name;
            this.CourseID = CourseID;
            this.Lecturer = Lecturer;
            this.MaxStudents = 30;
            this.NumStudents = 0;


        }
        public Course(string Name, string CourseID, string Lecturer, int MaxStudents)
        {
            this.Name = Name;
            this.CourseID = CourseID;
            this.Lecturer = Lecturer;
            this.MaxStudents = MaxStudents;
            this.NumStudents = 0;
            
        }
        public override string ToString()
        {
           return "[Course: " + Name + "(" + CourseID + "), Lecturer=" + Lecturer + ", has " + NumStudents + " students, max=" + MaxStudents + "]";
            
        }
    }
}
