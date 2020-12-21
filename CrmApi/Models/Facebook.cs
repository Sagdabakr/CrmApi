namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Facebook")]
    public partial class Facebook
    {
        [Key]
        public Guid Oid { get; set; }

        [StringLength(100)]
        public string FacebookEmail { get; set; }

        public Guid? Customers { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
