using System.Threading.Tasks;

namespace GHNY.ADC.Data;

public interface IADCDbSchemaMigrator
{
    Task MigrateAsync();
}
