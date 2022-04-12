using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiteManage.SiteTypes.Dtoes;
namespace SiteManage.SiteTypes.Inetrfaces
{
    public interface ISiteTypeAppService : IAsyncCrudAppService<SiteTypeDto, Guid, SiteTypeSearchDto, SiteTypeCreateDto, SiteTypeUpdateDto>
    {
    }
}
