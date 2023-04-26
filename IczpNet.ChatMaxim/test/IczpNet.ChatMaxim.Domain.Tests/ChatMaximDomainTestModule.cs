using IczpNet.ChatMaxim.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace IczpNet.ChatMaxim;

[DependsOn(
    typeof(ChatMaximEntityFrameworkCoreTestModule)
    )]
public class ChatMaximDomainTestModule : AbpModule
{

}
