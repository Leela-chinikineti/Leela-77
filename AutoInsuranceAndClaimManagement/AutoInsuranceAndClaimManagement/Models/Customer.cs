using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoInsuranceAndClaimManagement.Models
{
    public class Customer
    {
        [Key]
        public int Customer_Id { get; set; }
        public string Customer_Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string Phone_Num { get; set; }
        public string Email { get; set; }
        public string Blood_Group { get; set; }
        public string Password { get; set; }
        public string Confirm_Password { get; set; }
        
    }
}
