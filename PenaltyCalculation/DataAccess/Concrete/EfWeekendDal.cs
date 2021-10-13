using PenaltyCalculation.DataAccess.Abstract;
using PenaltyCalculation.Models;

namespace PenaltyCalculation.DataAccess.Concrete
{
    public class EfWeekendDal : EfGenericDal<Weekend>, IWeekendDal
    {
        public EfWeekendDal(AppDbContext context) : base(context)
        {
        }
    }
}
