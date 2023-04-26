using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace IczpNet.ChatMaxim.Web.Pages;

public class IndexModel : ChatMaximPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
