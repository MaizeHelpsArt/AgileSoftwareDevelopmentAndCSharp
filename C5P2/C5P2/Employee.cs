using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5P2
{
    class Employee
    {
        // fileds
        private string employeeId;
        private string employeeName;
        private DateTime datePromoted;

        // properties
        public string EmployeeId { get { return employeeId; } set { employeeId = value; } }
        public string EmployeeName { get { return employeeName; } set { employeeName = value; } }
        public DateTime DatePromoted { get { return datePromoted; } set { datePromoted = value; } }

        // constructor
        public Employee(string employeeId, string employeeName, DateTime datePromoted)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.datePromoted = datePromoted;
        }

        // methods
        public string Promote()
        {
            string message = "";
            if (DatePromoted.AddMonths(3) < DateTime.Now)
            {
                message = "It's time for a promotion!";
                
            }
            return message;
        }
            public override string ToString()
        {
            string str;
            str = string.Format($"{EmployeeId,-10}{EmployeeName,-10}{Promote(), 20}");
            return str;
        }
    }
}
