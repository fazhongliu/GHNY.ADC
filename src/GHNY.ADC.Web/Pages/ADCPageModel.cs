using GHNY.ADC.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace GHNY.ADC.Web.Pages;

public abstract class ADCPageModel : AbpPageModel
{
    protected ADCPageModel()
    {
        LocalizationResourceType = typeof(ADCResource);
    }
}
