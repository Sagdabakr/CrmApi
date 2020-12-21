namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PermissionPolicyActionPermissionObject")]
    public partial class PermissionPolicyActionPermissionObject
    {
        [Key]
        public Guid Oid { get; set; }

        [StringLength(100)]
        public string ActionId { get; set; }

        public Guid? Role { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        public virtual PermissionPolicyRole PermissionPolicyRole { get; set; }
    }
}
