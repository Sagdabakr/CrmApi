namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Penalty
    {
        [Key]
        public Guid Oid { get; set; }

        [StringLength(100)]
        public string PenaltyNO { get; set; }

        [Column("Penalty")]
        public string Penalty1 { get; set; }

        public Guid? Contract { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        public virtual Contract Contract1 { get; set; }
    }
}
