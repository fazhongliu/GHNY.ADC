using GHNY.ADC.Farm.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace GHNY.ADC.Farm
{
    public interface IFarmerAppService
    {
        Task<List<FarmerDto>> GetListAsync();
        Task<FarmerDto> GetAsync(Guid id);
        Task<FarmerDto> CreateAsync(CreateFarmerDto input);
        Task DeleteAsync(Guid id);
        Task<FarmerDto> UpdateAsync(FarmerDto input);
    }
}
