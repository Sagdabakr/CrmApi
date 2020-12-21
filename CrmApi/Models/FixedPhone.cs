namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FixedPhone")]
    public partial class FixedPhone
    {
        [Key]
        public Guid Oid { get; set; }

        public Guid? Key { get; set; }

        [StringLength(100)]
        public string PhoneNumber { get; set; }

        public Guid? Customer { get; set; }

        public Guid? ManPower { get; set; }

        public bool? IsPrimary { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        public virtual CounteryCodePhone CounteryCodePhone { get; set; }

        public virtual Customer Customer1 { get; set; }

        public virtual ManPower ManPower1 { get; set; }
    }
}
