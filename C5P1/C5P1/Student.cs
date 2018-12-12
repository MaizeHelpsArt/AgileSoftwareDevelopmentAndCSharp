using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5P1
{
    class Student
    {
        // fields 
        private string studentName;
        private int studentScore;

        // properties
        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public int StudentScore
        {
            get { return studentScore; }
            set { studentScore = value; }
        }

        // constructors
        public Student(string studentName, int studentScore)
        {
            this.studentName = studentName;
            this.studentScore = studentScore;
        }

        // methods
        public char GetLetterGrade()
        {
            char letterGrade = '\0';
            if (StudentScore >= 90)
            {
                letterGrade = 'A';
            }
            else if (StudentScore >= 80)
            {
                letterGrade = 'B';
            }
            else if (StudentScore >= 70)
            {
                letterGrade = 'C';
            }
            else if (StudentScore >= 60)
            {
                letterGrade = 'D';
            }
            else
            {
                letterGrade = 'F';
            }
            return letterGrade;
        }
        public override string ToString()
        {
            string str;
            str = string.Format($"Name: {StudentName} Letter Grade: {GetLetterGrade()}");
            return str;
        }

    }
}
