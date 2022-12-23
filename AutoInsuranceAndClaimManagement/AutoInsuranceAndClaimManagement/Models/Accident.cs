using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoInsuranceAndClaimManagement.Models
{
    public class Accident
    {
        [Key]
        public int Accident_Id { get; set; }


        [ForeignKey("Vehicle_Id")]
        public virtual int Vehicle_Id { get; set; }
        public virtual Vehicle Vehicle { get; set; }


        public string Accident_Location { get; set; }
        public string Accident_Reason { get; set; }

    }
}
