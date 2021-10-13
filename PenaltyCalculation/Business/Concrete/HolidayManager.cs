using PenaltyCalculation.Business.Abstract;
using PenaltyCalculation.DataAccess.Abstract;
using PenaltyCalculation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PenaltyCalculation.Business.Concrete
{
    public class HolidayManager : IHolidayService
    {
        private readonly IHolidayDal _holidayDal;

        public HolidayManager(IHolidayDal holidayDal)
        {
            _holidayDal = holidayDal;
        }

        public List<Holiday> GetAll()
        {
            return _holidayDal.GetAll();
        }
    }
}
