using System.Threading.Tasks;

namespace IczpNet.ChatMaxim.Data;

public interface IChatMaximDbSchemaMigrator
{
    Task MigrateAsync();
}
