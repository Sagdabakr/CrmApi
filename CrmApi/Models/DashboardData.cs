namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DashboardData")]
    public partial class DashboardData
    {
        [Key]
        public Guid Oid { get; set; }

        public string Content { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        public bool? SynchronizeTitle { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }
    }
}
