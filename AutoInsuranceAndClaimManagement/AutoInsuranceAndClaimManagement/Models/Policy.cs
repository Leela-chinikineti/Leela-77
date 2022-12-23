using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AutoInsuranceAndClaimManagement.Models
{
    public class Policy
    {
        [Key]
        public int Policy_Id { get; set; }

       
       
        [ForeignKey("Vehicle_Id")]
        public virtual int Vehicle_Id { get; set; }
        public virtual Vehicle Vehicle { get; set; }

        public string Policy_Type { get; set; }
        public int Policy_Amount { get; set; }
        public string Aadhar_Num { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public string policy_Status { get; set; }

    }
}
