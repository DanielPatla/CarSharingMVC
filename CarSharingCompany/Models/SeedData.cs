using CarSharingCompany.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSharingCompany.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CarSharingCompanyContext(
                serviceProvider.GetRequiredService<DbContextOptions<CarSharingCompanyContext>>()))
            {
                if(context.Car.Any())
                {
                    return;
                }

                context.Car.AddRange(
                    new Car
                    {
                        CarBrand = "Mercedes",
                        ProductionDate = DateTime.Parse("2019-4-17"),
                        Model = "GLS",
                        Body = "SUV",
                        Price = 680000M
                    },

                    new Car
                    {
                        CarBrand = "BMW",
                        ProductionDate = DateTime.Parse("2016-3-8"),
                        Model = "X3",
                        Body = "SUV",
                        Price = 89000M
                    },

                    new Car
                    {
                        CarBrand = "Peugeot",
                        ProductionDate = DateTime.Parse("2017-7-15"),
                        Model = "206",
                        Body = "HatchBack",
                        Price = 59000M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
