using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace GHNY.ADC.Farm
{

    public interface IFarmerRepository : IBasicRepository<Farmer, Guid>
    {
        Task<Farmer> GetDataByFarmId(Guid farmId);
    }
}
