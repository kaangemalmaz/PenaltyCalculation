using PenaltyCalculation.DataAccess.Abstract;
using PenaltyCalculation.Models;

namespace PenaltyCalculation.DataAccess.Concrete
{
    public class EfBookDal : EfGenericDal<Book>, IBookDal
    {
        public EfBookDal(AppDbContext context) : base(context)
        {
        }
    }
}
