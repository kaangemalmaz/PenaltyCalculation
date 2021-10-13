using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using PenaltyCalculation.Business.Abstract;
using PenaltyCalculation.DataAccess;
using PenaltyCalculation.Models;
using System;
using System.Diagnostics;
using System.Linq;

namespace PenaltyCalculation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICountryService _countryService;
        private readonly IWeekendService _weekendService;
        private readonly IHolidayService _holidayService;

        public HomeController(AppDbContext context, ICountryService countryService, IWeekendService weekendService, IHolidayService holidayService)
        {
            _countryService = countryService;
            _weekendService = weekendService;
            _holidayService = holidayService;
        }

        public IActionResult Index()
        {
            ViewData["CountryList"] = new SelectList(_countryService.GetAll(), "Id", "CountryName");
            return View();
        }

        [HttpPost]
        public IActionResult Index(HomeViewModel homeViewModel)
        {
            ViewData["CountryList"] = new SelectList(_countryService.GetAll(), "Id", "CountryName");
            homeViewModel.Book.TotalBusinessDay = TotalBussinesDays((DateTime)homeViewModel.Book.CheckOutDate, (DateTime)homeViewModel.Book.ReturnDate, homeViewModel.Country.Id);
            homeViewModel.Book.CalculatedPenalty = TotalPrice((int)homeViewModel.Book.TotalBusinessDay, homeViewModel.Country.Id);
            return View(homeViewModel);
        }

        public int TotalBussinesDays(DateTime checkOutDate, DateTime returnDate, int id)
        {
            int TotalDay = 0;
            var weekendDay = _weekendService.GetAll().Where(i => i.CountryId == id).ToList();
            var holiday = _holidayService.GetAll().Where(i => i.CountryId == id).ToList();

            while (checkOutDate <= returnDate)
            {
                if (weekendDay.All(i => i.WeekendDays.ToString().ToLower() != checkOutDate.DayOfWeek.ToString().ToLower() && !holiday.Any(i => i.HolidayDate.Month == checkOutDate.Month && i.HolidayDate.Day == checkOutDate.Day)))
                {
                    TotalDay += 1;
                }
                checkOutDate = checkOutDate.AddDays(1);
            }

            return TotalDay;
        }

        public string TotalPrice(int TotalDay, int id)
        {
            var country = _countryService.Get(id);
            if (TotalDay > 10)
            {
                return (TotalDay - 10) * country.Price + " " + country.Currenzy;
            }
            else
            {
                return "0" + " " + country.Currenzy;
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
