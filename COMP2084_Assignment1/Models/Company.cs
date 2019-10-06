using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084_Assignment1.Models
{
    public class Company
    {
        [Key]
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string Nationality { get; set; }
        public List<Car> Cars { get; set; }


    }
}
