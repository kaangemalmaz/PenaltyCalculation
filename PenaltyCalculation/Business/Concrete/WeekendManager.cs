using PenaltyCalculation.Business.Abstract;
using PenaltyCalculation.DataAccess.Abstract;
using PenaltyCalculation.Models;
using System.Collections.Generic;

namespace PenaltyCalculation.Business.Concrete
{
    public class WeekendManager : IWeekendService
    {
        private readonly IWeekendDal _weekendDal;

        public WeekendManager(IWeekendDal weekendDal)
        {
            _weekendDal = weekendDal;
        }

        public List<Weekend> GetAll()
        {
            return _weekendDal.GetAll();
        }
    }
}
