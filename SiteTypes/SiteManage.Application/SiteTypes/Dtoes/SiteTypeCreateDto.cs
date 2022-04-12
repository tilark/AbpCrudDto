using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;
namespace SiteManage.SiteTypes.Dtoes
{
    [AutoMapTo(typeof(SiteType))]
    public class SiteTypeCreateDto
    {
        public string Name { get; set; }
        public decimal Order { get; set; }
        public string Remark { get; set; }
    }
}
