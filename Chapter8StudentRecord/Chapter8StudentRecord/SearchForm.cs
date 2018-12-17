﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Chapter8StudentRecord
{
    public partial class SearchForm : Form
    {
        // a list that includes all students
        List<Student> allStudent = new List<Student>();

        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("student.txt"))
            {
                string id;
                while ((id = sr.ReadLine()) != null)
                {
                    string name = sr.ReadLine();
                    int score = int.Parse(sr.ReadLine());

                    // create a student object
                    Student s = new Student(id, name, score);

                    // add to list
                    allStudent.Add(s);


                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // search the list, find the student by id
            Student s = allStudent.Find(x => x.StudentId == searchTextBox.Text);
            if (s != null)
            {
                idLabel.Text = s.StudentId;
                nameLabel.Text = s.StudentName;
                gradeLabel.Text = s.GetLetterGrade().ToString();
            }
            else
            {
                MessageBox.Show("No student found");
                idLabel.Text = string.Empty;
                nameLabel.Text = string.Empty;
                gradeLabel.Text = string.Empty;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Student ID; " + idLabel.Text, new Font("Courier New", 12, FontStyle.Regular), Brushes.Black, 100, 200);
            e.Graphics.DrawString("Student Name; " + nameLabel.Text, new Font("Courier New", 12, FontStyle.Regular), Brushes.Black, 100, 215);
            e.Graphics.DrawString("Student Grade; " + gradeLabel.Text, new Font("Courier New", 12, FontStyle.Regular), Brushes.Black, 100, 230);
        }
    }
}
