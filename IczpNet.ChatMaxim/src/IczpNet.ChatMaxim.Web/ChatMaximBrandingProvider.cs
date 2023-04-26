using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace IczpNet.ChatMaxim.Web;

[Dependency(ReplaceServices = true)]
public class ChatMaximBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ChatMaxim";
}
