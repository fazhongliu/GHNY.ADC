using System;
using System.Collections.Generic;
using System.Text;
using GHNY.ADC.Localization;
using Volo.Abp.Application.Services;

namespace GHNY.ADC;

/* Inherit your application services from this class.
 */
public abstract class ADCAppService : ApplicationService
{
    protected ADCAppService()
    {
        LocalizationResource = typeof(ADCResource);
    }
}
