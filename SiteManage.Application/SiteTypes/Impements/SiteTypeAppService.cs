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
using Abp.Application.Services.Dto;
using Abp.UI;
using SiteManage.SiteTypes.Inetrfaces;
namespace SiteManage.SiteTypes.Impements
{
    public class SiteTypeAppService : AsyncCrudAppService<SiteType, SiteTypeDto, Guid, SiteTypeSearchDto, SiteTypeCreateDto, SiteTypeUpdateDto>, ISiteTypeAppService
    {
        private readonly IRepository<SiteInfo, Guid> _siteInfoRepository;

        public SiteTypeAppService(IRepository<SiteType, Guid> repository, IRepository<SiteInfo, Guid> siteInfoRepository) : base(repository)
        {
            CreatePermissionName = PermissionNames.Pages_Users;
            UpdatePermissionName = PermissionNames.Pages_Users;
            DeletePermissionName = PermissionNames.Pages_Users;
            _siteInfoRepository = siteInfoRepository;
        }

        protected override IQueryable<SiteType> CreateFilteredQuery(SiteTypeSearchDto input)
        {
            return base.CreateFilteredQuery(input).WhereIf(!string.IsNullOrEmpty(input.Name), a => a.Name.Contains(input.Name));
        }

        public override async Task DeleteAsync(EntityDto<Guid> input)
        {
            var query = await _siteInfoRepository.FirstOrDefaultAsync(a => a.SiteTypeId == input.Id);
            if (query != null) throw new UserFriendlyException("网址信息引用该类型，无法删除");
            else
             await base.DeleteAsync(input);
        }
    }
}
