using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoInsuranceAndClaimManagement.Models
{
    public class Vehicle
    {
        [Key]
        public int Vehicle_Id { get; set; }

        [ForeignKey("Customer_Id")]
        public virtual int Customer_Id { get; set; }
        public virtual Customer Customer { get; set; }

        public string Vehicle_Name { get; set; }
        public string Register_Num { get; set; }
        public string Vehicle_Type { get; set; }
        public string Color { get; set; }
        public string Manufacturer { get; set; }
        public DateTime Register_Date { get; set; }
        public int Vehicle_CC { get; set; }
        public string Vehicle_UsuageType { get; set; }

      

    }
}
