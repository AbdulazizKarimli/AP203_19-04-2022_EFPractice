using System;
using System.Collections.Generic;
using System.Text;

namespace AP203EFPractice.Data.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
