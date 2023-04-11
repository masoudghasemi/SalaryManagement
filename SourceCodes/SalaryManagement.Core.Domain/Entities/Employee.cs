using Framework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagement.Core.Domain.Entities
{
    public class Employee:BaseEntity
    {

        public  long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long BasicSalary { get; set; }
        public long Allowance { get; set; }
        public long Transportation { get; set; }
        public int Date { get; set; }

        public string OverTimeCalculator { get; set; }

        public int? OverTimeMinutes { get; set; }

        public double? FinalSalary { get; set; }

    }
}
