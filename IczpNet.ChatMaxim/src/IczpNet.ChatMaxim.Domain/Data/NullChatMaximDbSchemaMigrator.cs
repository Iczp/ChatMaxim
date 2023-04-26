using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace IczpNet.ChatMaxim.Data;

/* This is used if database provider does't define
 * IChatMaximDbSchemaMigrator implementation.
 */
public class NullChatMaximDbSchemaMigrator : IChatMaximDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
