using AutoInsuranceAndClaimManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoInsuranceAndClaimManagement.Context
{
    public class AutoInsuranceAndClaimManagementDbContext:DbContext
    {
        public AutoInsuranceAndClaimManagementDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Policy> Policy { get; set; }
        public DbSet<Claim> Claim { get; set; }
        public DbSet<Accident> Accident { get; set; }
    }
}
