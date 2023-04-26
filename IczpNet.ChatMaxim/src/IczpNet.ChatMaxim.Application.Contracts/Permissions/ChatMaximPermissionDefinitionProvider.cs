using IczpNet.ChatMaxim.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace IczpNet.ChatMaxim.Permissions;

public class ChatMaximPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ChatMaximPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ChatMaximPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ChatMaximResource>(name);
    }
}
