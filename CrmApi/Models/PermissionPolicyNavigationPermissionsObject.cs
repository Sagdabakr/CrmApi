namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PermissionPolicyNavigationPermissionsObject")]
    public partial class PermissionPolicyNavigationPermissionsObject
    {
        [Key]
        public Guid Oid { get; set; }

        public string ItemPath { get; set; }

        public int? NavigateState { get; set; }

        public Guid? Role { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        public virtual PermissionPolicyRole PermissionPolicyRole { get; set; }
    }
}
