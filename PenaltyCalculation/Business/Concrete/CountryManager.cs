using PenaltyCalculation.Business.Abstract;
using PenaltyCalculation.DataAccess.Abstract;
using PenaltyCalculation.Models;
using System.Collections.Generic;

namespace PenaltyCalculation.Business.Concrete
{
    public class CountryManager : ICountryService
    {
        private readonly ICountryDal _countryDal;

        public CountryManager(ICountryDal countryDal)
        {
            _countryDal = countryDal;
        }

        public Country Get(int id)
        {
            return _countryDal.Get(i => i.Id == id);
        }

        public List<Country> GetAll()
        {
            return _countryDal.GetAll();
        }
    }
}
