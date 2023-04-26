using IczpNet.ChatMaxim.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace IczpNet.ChatMaxim.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ChatMaximController : AbpControllerBase
{
    protected ChatMaximController()
    {
        LocalizationResource = typeof(ChatMaximResource);
    }
}
