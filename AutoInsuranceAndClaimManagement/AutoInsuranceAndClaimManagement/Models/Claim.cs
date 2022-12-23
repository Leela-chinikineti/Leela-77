using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoInsuranceAndClaimManagement.Models
{
    public class Claim
    {
        [Key]
        public int Claim_Id { get; set; }


        [ForeignKey("Vehicle_Id")]
        public virtual int Vehicle_Id { get; set; }
        public virtual Vehicle Vehicle { get; set; }


        public int Claim_Amount { get; set; }
        public DateTime Approved_Date { get; set; }

        public int Approved_Amount { get; set; }
        public string Claim_Status { get; set; }



    }
}
