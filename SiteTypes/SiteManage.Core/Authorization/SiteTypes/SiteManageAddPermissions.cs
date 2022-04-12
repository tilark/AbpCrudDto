using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace SiteManage.Authorization
{
    public static class SiteTypesAddPermissions
    {
        public static void SetPermissions(IPermissionDefinitionContext context)
        {
           var groupName = context.CreatePermission(SiteTypePermissionNames.SiteType_GroupName, L("SiteType_GroupName"));
            groupName.CreateChildPermission(SiteTypePermissionNames.SiteType_Create, L("Create"));
            groupName.CreateChildPermission(SiteTypePermissionNames.SiteType_Research, L("Research"));
            groupName.CreateChildPermission(SiteTypePermissionNames.SiteType_Update, L("Edit"));
            groupName.CreateChildPermission(SiteTypePermissionNames.SiteType_Delete, L("Delete"));


        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, SiteManageConsts.LocalizationSourceName);
        }
    }
}
