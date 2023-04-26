using Volo.Abp.Modularity;

namespace IczpNet.ChatMaxim;

[DependsOn(
    typeof(ChatMaximApplicationModule),
    typeof(ChatMaximDomainTestModule)
    )]
public class ChatMaximApplicationTestModule : AbpModule
{

}
