using GHNY.ADC.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace GHNY.ADC;

[DependsOn(
    typeof(ADCEntityFrameworkCoreTestModule)
    )]
public class ADCDomainTestModule : AbpModule
{

}
