using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace GHNY.ADC.Web.Pages;

public class IndexModel : ADCPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
