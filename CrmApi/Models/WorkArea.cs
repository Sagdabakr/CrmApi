namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WorkArea")]
    public partial class WorkArea
    {
        [Key]
        public Guid Oid { get; set; }

        [StringLength(100)]
        public string WorkAreaId { get; set; }

        public Guid? CompanyBranch { get; set; }

        public Guid? Company { get; set; }

        public Guid? ManPower { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        public virtual Company Company1 { get; set; }

        public virtual CompanyBranch CompanyBranch1 { get; set; }

        public virtual ManPower ManPower1 { get; set; }
    }
}
