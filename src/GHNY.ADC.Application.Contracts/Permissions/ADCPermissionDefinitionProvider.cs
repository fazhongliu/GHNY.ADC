using GHNY.ADC.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace GHNY.ADC.Permissions;

public class ADCPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ADCPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ADCPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ADCResource>(name);
    }
}
