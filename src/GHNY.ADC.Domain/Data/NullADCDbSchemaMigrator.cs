using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace GHNY.ADC.Data;

/* This is used if database provider does't define
 * IADCDbSchemaMigrator implementation.
 */
public class NullADCDbSchemaMigrator : IADCDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
