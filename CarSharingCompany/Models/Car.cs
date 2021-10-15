using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarSharingCompany.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string CarBrand { get; set; }

        [Display(Name = "Date of production")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:YYYY-MM-DD}", ApplyFormatInEditMode = true)]
        public DateTime ProductionDate { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        [RegularExpression(@"[a-zA-Z0-9""'\s-]*$")]
        public string Model { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [DataType(DataType.Currency)]
        [Range(1, 10000000)]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(30)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Body { get; set; }
    }
}
