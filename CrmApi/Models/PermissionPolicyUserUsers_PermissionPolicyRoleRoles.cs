namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PermissionPolicyUserUsers_PermissionPolicyRoleRoles
    {
        public Guid? Roles { get; set; }

        public Guid? Users { get; set; }

        [Key]
        public Guid OID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual PermissionPolicyRole PermissionPolicyRole { get; set; }

        public virtual PermissionPolicyUser PermissionPolicyUser { get; set; }
    }
}
