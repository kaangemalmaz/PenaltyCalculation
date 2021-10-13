using System.ComponentModel.DataAnnotations;

namespace PenaltyCalculation.Models
{
    public class Weekend
    {
        [Key]
        public int Id { get; set; }
        public string WeekendDays { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
