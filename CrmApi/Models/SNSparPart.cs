namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SNSparPart")]
    public partial class SNSparPart
    {
        [Key]
        public Guid Oid { get; set; }

        [StringLength(100)]
        public string ItemCode { get; set; }

        [StringLength(100)]
        public string SerialNumber { get; set; }

        public Guid? SparPart { get; set; }

        public Guid? StoreName { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        public virtual SparPart SparPart1 { get; set; }

        public virtual Store Store { get; set; }
    }
}
