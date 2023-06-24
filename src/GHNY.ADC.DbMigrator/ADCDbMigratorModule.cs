using GHNY.ADC.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace GHNY.ADC.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ADCEntityFrameworkCoreModule),
    typeof(ADCApplicationContractsModule)
    )]
public class ADCDbMigratorModule : AbpModule
{

}
