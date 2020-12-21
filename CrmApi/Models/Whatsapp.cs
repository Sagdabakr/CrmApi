namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Whatsapp")]
    public partial class Whatsapp
    {
        [Key]
        public Guid Oid { get; set; }

        public Guid? Key { get; set; }

        [StringLength(100)]
        public string PhoneNumber { get; set; }

        public Guid? Customers { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        public virtual CounteryCodePhone CounteryCodePhone { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
