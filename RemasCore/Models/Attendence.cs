using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Remas.Models
{
    public class Attendence
    {
        public Attendence()
        {
            Employees=new List<Employee>();
            }
        [Key]
        public int AtId { get; set; }

        public DateTime Incoming { get; set; }

        public DateTime OutGoing { get; set; }
       
        public virtual ICollection<Employee> Employees { get; set; }
    }
}