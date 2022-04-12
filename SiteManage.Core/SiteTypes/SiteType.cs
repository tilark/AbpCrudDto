using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManage.SiteTypes
{
    public class SiteType : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        [Column(TypeName = "decimal(13, 2)")]
        public decimal Order { get; set; }
        public string Remark { get; set; }
    }
}
