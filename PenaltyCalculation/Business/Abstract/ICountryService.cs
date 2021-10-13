using PenaltyCalculation.Models;
using System.Collections.Generic;

namespace PenaltyCalculation.Business.Abstract
{
    public interface ICountryService
    {
        List<Country> GetAll();
        Country Get(int id);
    }
}
