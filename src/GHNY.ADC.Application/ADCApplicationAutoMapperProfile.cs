using AutoMapper;
using GHNY.ADC.Farm;
using GHNY.ADC.Farm.Dtos;

namespace GHNY.ADC;

public class ADCApplicationAutoMapperProfile : Profile
{
    public ADCApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Farmer, FarmerDto>();
        CreateMap<CreateFarmerDto, Farmer>(MemberList.Source);
    }
}
