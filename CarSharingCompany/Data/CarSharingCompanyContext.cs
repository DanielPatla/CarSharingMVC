using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarSharingCompany.Models;

namespace CarSharingCompany.Data
{
    public class CarSharingCompanyContext : DbContext
    {
        public CarSharingCompanyContext (DbContextOptions<CarSharingCompanyContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Car { get; set; }
    }
}
