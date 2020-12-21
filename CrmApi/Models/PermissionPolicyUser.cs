namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PermissionPolicyUser")]
    public partial class PermissionPolicyUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PermissionPolicyUser()
        {
            PermissionPolicyUserUsers_PermissionPolicyRoleRoles = new HashSet<PermissionPolicyUserUsers_PermissionPolicyRoleRoles>();
        }

        [Key]
        public Guid Oid { get; set; }

        public string StoredPassword { get; set; }

        public bool? ChangePasswordOnFirstLogon { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }

        public bool? IsActive { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        public int? ObjectType { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ManPower ManPower { get; set; }

        public virtual XPObjectType XPObjectType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PermissionPolicyUserUsers_PermissionPolicyRoleRoles> PermissionPolicyUserUsers_PermissionPolicyRoleRoles { get; set; }
    }
}
