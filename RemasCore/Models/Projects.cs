using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Remas.Models
{
    public class Projects
    {
        [Key]
        public int ProjectId { get; set; }
        
        public string ProjectName { get; set; }
        
        public DateTime ProjectReciveDate { get; set; }
        
        public DateTime ProjectDeliverDate { get; set; }
        
        public DateTime EstimationTime { get; set; }

        public int NumberOfTalentUse { get; set; }
        public Projects(){
            Performances = new List<Perfomance>();
        }
        public virtual ICollection<Perfomance> Performances { get; set; }



    }
}