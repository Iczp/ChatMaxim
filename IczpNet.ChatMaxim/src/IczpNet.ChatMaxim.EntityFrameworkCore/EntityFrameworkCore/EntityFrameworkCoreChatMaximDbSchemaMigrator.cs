using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using IczpNet.ChatMaxim.Data;
using Volo.Abp.DependencyInjection;

namespace IczpNet.ChatMaxim.EntityFrameworkCore;

public class EntityFrameworkCoreChatMaximDbSchemaMigrator
    : IChatMaximDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreChatMaximDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ChatMaximDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ChatMaximDbContext>()
            .Database
            .MigrateAsync();
    }
}
