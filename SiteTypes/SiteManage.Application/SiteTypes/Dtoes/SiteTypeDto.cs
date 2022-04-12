using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
namespace SiteManage.SiteTypes.Dtoes
{
    [AutoMapFrom(typeof(SiteType))]
    public class SiteTypeDto : FullAuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public decimal Order { get; set; }
        public string Remark { get; set; }
    }
}
