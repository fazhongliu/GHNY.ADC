using GHNY.ADC.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace GHNY.ADC.Farm
{
    public class FarmerRepository : EfCoreRepository<ADCDbContext, Farmer, Guid>, IFarmerRepository
    {
        public FarmerRepository(IDbContextProvider<ADCDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<Farmer> GetDataByFarmId(Guid farmId)
        {
            return await (await GetDbSetAsync()).Where(a => a.Id == farmId).FirstOrDefaultAsync();
        }
    }
}