using PenaltyCalculation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PenaltyCalculation.Business.Abstract
{
    public interface IWeekendService
    {
        List<Weekend> GetAll();
    }
}
