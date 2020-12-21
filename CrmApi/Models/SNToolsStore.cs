namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SNToolsStore")]
    public partial class SNToolsStore
    {
        [Key]
        public Guid Oid { get; set; }

        [StringLength(100)]
        public string ItemCode { get; set; }

        public Guid? ToolsStore { get; set; }

        [StringLength(100)]
        public string SerialNumber { get; set; }

        [StringLength(100)]
        public string BinLocation { get; set; }

        public int? ServiceableState { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        public virtual ToolStore ToolStore { get; set; }
    }
}
