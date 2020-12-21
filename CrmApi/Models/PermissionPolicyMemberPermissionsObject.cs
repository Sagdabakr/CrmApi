namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PermissionPolicyMemberPermissionsObject")]
    public partial class PermissionPolicyMemberPermissionsObject
    {
        [Key]
        public Guid Oid { get; set; }

        public string Members { get; set; }

        public int? ReadState { get; set; }

        public int? WriteState { get; set; }

        public string Criteria { get; set; }

        public Guid? TypePermissionObject { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        public virtual PermissionPolicyTypePermissionsObject PermissionPolicyTypePermissionsObject { get; set; }
    }
}
