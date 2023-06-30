using GHNY.ADC.Farm.Dtos;
using Scriban.Parsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using static System.Net.Mime.MediaTypeNames;

namespace GHNY.ADC.Farm
{
    public class FarmerAppService : ApplicationService,IFarmerAppService
    {
        private readonly IFarmerRepository _farmerRepository;


        public FarmerAppService(IFarmerRepository farmerRepository)
        {
            _farmerRepository = farmerRepository;
        }
        public async Task<FarmerDto> CreateAsync(CreateFarmerDto input)
        {
            var farmer = ObjectMapper.Map<CreateFarmerDto, Farmer>(input);
             
            return ObjectMapper.Map<Farmer, FarmerDto>(await _farmerRepository.InsertAsync(farmer)); 
        }

        public async Task DeleteAsync(Guid id)
        {
            await _farmerRepository.DeleteAsync(id);
        }

        public async Task<FarmerDto> GetAsync(Guid id)
        {
            return ObjectMapper.Map<Farmer, FarmerDto>(await _farmerRepository.GetDataByFarmId(id));

        }

        public Task<List<FarmerDto>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<FarmerDto> UpdateAsync(FarmerDto input)
        {
            throw new NotImplementedException();
        }
    }
}
