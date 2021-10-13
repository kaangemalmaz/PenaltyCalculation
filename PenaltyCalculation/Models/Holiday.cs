using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PenaltyCalculation.Models
{
    public class Holiday
    {
        [Key]
        public int Id { get; set; }
        public string HolidayName { get; set; }
        public DateTime HolidayDate { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
