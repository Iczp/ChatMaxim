using IczpNet.ChatMaxim.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace IczpNet.ChatMaxim.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ChatMaximEntityFrameworkCoreModule),
    typeof(ChatMaximApplicationContractsModule)
    )]
public class ChatMaximDbMigratorModule : AbpModule
{

}
