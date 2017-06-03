using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Remas.Models
{
    public class Perfomance
    {
        [Key]
        public int PerformanceId { get; set; }

       
        public virtual ICollection<PerformanceStatus> PerformanceStatus { get; set; }

        public string IssueFund { get; set; }
      
        public virtual Projects project { get; set; }

        
        public virtual ICollection<Employee> Employee { get; set; }

    }
}