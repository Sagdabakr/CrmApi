namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PermissionPolicyRole")]
    public partial class PermissionPolicyRole
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PermissionPolicyRole()
        {
            PermissionPolicyActionPermissionObjects = new HashSet<PermissionPolicyActionPermissionObject>();
            PermissionPolicyNavigationPermissionsObjects = new HashSet<PermissionPolicyNavigationPermissionsObject>();
            PermissionPolicyTypePermissionsObjects = new HashSet<PermissionPolicyTypePermissionsObject>();
            PermissionPolicyUserUsers_PermissionPolicyRoleRoles = new HashSet<PermissionPolicyUserUsers_PermissionPolicyRoleRoles>();
        }

        [Key]
        public Guid Oid { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public bool? IsAdministrative { get; set; }

        public bool? CanEditModel { get; set; }

        public int? PermissionPolicy { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        public int? ObjectType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PermissionPolicyActionPermissionObject> PermissionPolicyActionPermissionObjects { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PermissionPolicyNavigationPermissionsObject> PermissionPolicyNavigationPermissionsObjects { get; set; }

        public virtual XPObjectType XPObjectType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PermissionPolicyTypePermissionsObject> PermissionPolicyTypePermissionsObjects { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PermissionPolicyUserUsers_PermissionPolicyRoleRoles> PermissionPolicyUserUsers_PermissionPolicyRoleRoles { get; set; }
    }
}
