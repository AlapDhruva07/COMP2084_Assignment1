using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084_Assignment1.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string Model { get; set; }
        public DateTime Mfdate { get; set; }

        public string CompanyName { get; set; }

        public Company Company { get; set; }



    }
}
