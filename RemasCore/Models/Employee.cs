using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Remas.Models
{
    public class Employee
    {
        [Key]
        public int EId { get; set; }
        public string CustomerName { get; set; }

        public string Designation { get; set; }

        public string NationId { get; set; }

        public string EmployeeId { get; set; }

        public DateTime DOB { get; set; }

        public string EmployeeEmail { get; set; }
       
        public virtual Attendence Atttendence { get; set; }

        public virtual Perfomance performance { get; set; }
    }
}