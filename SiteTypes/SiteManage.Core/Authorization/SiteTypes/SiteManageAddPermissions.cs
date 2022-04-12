using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace SiteManage.Authorization
{
    public static class SiteTypesAddPermissions
    {
        public static void SetPermissions(IPermissionDefinitionContext context)
        {
           var groupName = context.CreatePermission(PermissionNames.SiteType_GroupName, L("SiteType_GroupName"));
            groupName.CreateChildPermission(PermissionNames.SiteType_Create, L("Create"));
            groupName.CreateChildPermission(PermissionNames.SiteType_Research, L("Research"));
            groupName.CreateChildPermission(PermissionNames.SiteType_Update, L("Edit"));
            groupName.CreateChildPermission(PermissionNames.SiteType_Delete, L("Delete"));


        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, SiteManageConsts.LocalizationSourceName);
        }
    }
}
