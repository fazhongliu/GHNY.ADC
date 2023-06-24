using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace GHNY.ADC.Web;

[Dependency(ReplaceServices = true)]
public class ADCBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ADC";
}
