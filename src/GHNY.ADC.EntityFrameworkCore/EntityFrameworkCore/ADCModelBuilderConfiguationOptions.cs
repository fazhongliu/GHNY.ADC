using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace GHNY.ADC.EntityFrameworkCore
{
    public class ADCModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public ADCModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}
