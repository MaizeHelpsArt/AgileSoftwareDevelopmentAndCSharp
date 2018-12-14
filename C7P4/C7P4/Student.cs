using System;

namespace C7P4
{
    public class Student
    {
        public Student()
        {
        }

        public char GetLetterGrade(int score)
        {
            char letterGrade = 'F';
            if (score >= 90)
            {
                letterGrade = 'A';
            }
            return letterGrade;
        }
    }
}