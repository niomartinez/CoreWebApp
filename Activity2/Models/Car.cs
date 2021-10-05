using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2.Models
{
    public class Car
    {
        [DisplayName("Car ID")]
        public int Id { get; set; }

        [DisplayName("Cost of the car")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [DisplayName("Car's Model")]
        public string Model { get; set; }

        [DisplayName("Company who made it")]
        public string Make { get; set; }

        [DisplayName("Car's release date")]
        public DateTime LaunchDate { get; set; }

    }
}
