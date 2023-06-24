using Volo.Abp.Modularity;

namespace GHNY.ADC;

[DependsOn(
    typeof(ADCApplicationModule),
    typeof(ADCDomainTestModule)
    )]
public class ADCApplicationTestModule : AbpModule
{

}
