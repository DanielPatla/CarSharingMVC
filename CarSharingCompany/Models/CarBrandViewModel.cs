using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSharingCompany.Models
{
    public class CarBrandViewModel
    {
        public List<Car> Cars { get; set; }
        public SelectList CarBrands { get; set; }
        public string CarBrand { get; set; }
        public string SearchString { get; set; }

    }
}
