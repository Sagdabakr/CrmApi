namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Email")]
    public partial class Email
    {
        [Key]
        public Guid Oid { get; set; }

        [StringLength(100)]
        public string EmailAddress { get; set; }

        public bool? IsPrimary { get; set; }

        public Guid? Customer { get; set; }

        public Guid? ManPower { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        public virtual Customer Customer1 { get; set; }

        public virtual ManPower ManPower1 { get; set; }
    }
}
