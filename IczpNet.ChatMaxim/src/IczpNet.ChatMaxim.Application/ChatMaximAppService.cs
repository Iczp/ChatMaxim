using System;
using System.Collections.Generic;
using System.Text;
using IczpNet.ChatMaxim.Localization;
using Volo.Abp.Application.Services;

namespace IczpNet.ChatMaxim;

/* Inherit your application services from this class.
 */
public abstract class ChatMaximAppService : ApplicationService
{
    protected ChatMaximAppService()
    {
        LocalizationResource = typeof(ChatMaximResource);
    }
}
