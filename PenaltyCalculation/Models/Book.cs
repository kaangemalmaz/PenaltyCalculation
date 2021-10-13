using System;
using System.ComponentModel.DataAnnotations;

namespace PenaltyCalculation.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime CheckOutDate { get; set; }
        [Required]
        public DateTime ReturnDate { get; set; }
        [Required]
        public int? TotalBusinessDay { get; set; }
        [Required]
        public string CalculatedPenalty { get; set; }
    }
}
