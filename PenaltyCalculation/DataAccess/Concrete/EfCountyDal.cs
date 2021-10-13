using PenaltyCalculation.DataAccess.Abstract;
using PenaltyCalculation.Models;

namespace PenaltyCalculation.DataAccess.Concrete
{
    public class EfCountyDal : EfGenericDal<Country>, ICountryDal
    {
        public EfCountyDal(AppDbContext context) : base(context)
        {
        } 
    }
}
