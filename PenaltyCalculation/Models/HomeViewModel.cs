using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace PenaltyCalculation.Models
{
    public class HomeViewModel
    {
        public Book Book { get; set; }
        public Country Country { get; set; }
    }
}
