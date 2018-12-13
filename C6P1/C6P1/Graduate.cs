using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6P1
{
    class Graduate : Student
    {
        // constructor
        public Graduate(string studentId, string studentName, int studentScore) : base(studentId, studentName, studentScore) { }

        // methods
        public string GetLetterGrade()
        {
            string letterGrade;
            if (StudentScore >= 90)
            {
                letterGrade = "A";
            }
            else if (StudentScore >= 80)
            {
                letterGrade = "B";
            }
            else if (StudentScore >= 70)
            {
                letterGrade = "C";
            }
            else if (StudentScore >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }
            return letterGrade;
        }
        public override string ToString()
        {
            string str;
            str = base.ToString() + string.Format($" Letter grade: {GetLetterGrade()}");
            return str;
        }
    }
}
