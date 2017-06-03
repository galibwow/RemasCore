using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Remas.Models
{
    public class PerformanceStatus
    {
        [Key]
        public int PerformanceStatusId { get; set; }

        public string PerformanceStatusname { get; set; }

       
        public virtual Perfomance performence { get; set; }
    }
}