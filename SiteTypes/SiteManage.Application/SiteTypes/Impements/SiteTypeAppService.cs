using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using SiteManage.Authorization;
using SiteManage.SiteInfoes;
using SiteManage.SiteTypes.Dtoes;
using Abp.UI;
using SiteManage.SiteTypes.Inetrfaces;
namespace SiteManage.SiteTypes.Impements
{
    public class SiteTypeAppService : AsyncCrudAppService<SiteType, SiteTypeDto, Guid, SiteTypeSearchDto, SiteTypeCreateDto, SiteTypeUpdateDto>, ISiteTypeAppService
    {
        private readonly IRepository<SiteInfo, Guid> _siteInfoRepository;

        public SiteTypeAppService(IRepository<SiteType, Guid> repository, IRepository<SiteInfo, Guid> siteInfoRepository) : base(repository)
        {
            GetAllPermissionName = PermissionNames.SiteType_Research;
            GetPermissionName = PermissionNames.SiteType_Research;
            CreatePermissionName = PermissionNames.SiteType_Create;
            UpdatePermissionName = PermissionNames.SiteType_Update;
            DeletePermissionName = PermissionNames.SiteType_Delete;
            _siteInfoRepository = siteInfoRepository;
        }

        protected override IQueryable<SiteType> CreateFilteredQuery(SiteTypeSearchDto input)
        {
            return base.CreateFilteredQuery(input).WhereIf(!string.IsNullOrEmpty(input.Name), a => a.Name.Contains(input.Name));
        }
    }
}
