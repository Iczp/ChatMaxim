using IczpNet.ChatMaxim.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace IczpNet.ChatMaxim.Web.Pages;

public abstract class ChatMaximPageModel : AbpPageModel
{
    protected ChatMaximPageModel()
    {
        LocalizationResourceType = typeof(ChatMaximResource);
    }
}
