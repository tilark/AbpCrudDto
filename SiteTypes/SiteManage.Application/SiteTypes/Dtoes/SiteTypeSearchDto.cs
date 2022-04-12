using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
namespace SiteManage.SiteTypes.Dtoes
{
    public class SiteTypeSearchDto : PagedAndSortedResultRequestDto
    {
        public SiteTypeSearchDto()
        {
            SkipCount = 0;
            MaxResultCount = 20;
        }
        public SiteTypeSearchDto(int skipCount, int maxResultCount)
        {
            SkipCount = skipCount;
            MaxResultCount = maxResultCount;
        }

        public string Name { get; set; }
    }
}
