using GHNY.ADC.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace GHNY.ADC.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ADCController : AbpControllerBase
{
    protected ADCController()
    {
        LocalizationResource = typeof(ADCResource);
    }
}
