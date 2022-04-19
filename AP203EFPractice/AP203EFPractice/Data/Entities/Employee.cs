using System;
using System.Collections.Generic;
using System.Text;

namespace AP203EFPractice.Data.Entities
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public double Salary { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
