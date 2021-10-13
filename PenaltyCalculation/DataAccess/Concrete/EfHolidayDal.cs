using PenaltyCalculation.DataAccess.Abstract;
using PenaltyCalculation.Models;

namespace PenaltyCalculation.DataAccess.Concrete
{
    public class EfHolidayDal : EfGenericDal<Holiday>, IHolidayDal
    {
        public EfHolidayDal(AppDbContext context) : base(context)
        {
        }
    }
}
