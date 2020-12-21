namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PermissionPolicyTypePermissionsObject")]
    public partial class PermissionPolicyTypePermissionsObject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PermissionPolicyTypePermissionsObject()
        {
            PermissionPolicyMemberPermissionsObjects = new HashSet<PermissionPolicyMemberPermissionsObject>();
            PermissionPolicyObjectPermissionsObjects = new HashSet<PermissionPolicyObjectPermissionsObject>();
        }

        [Key]
        public Guid Oid { get; set; }

        public Guid? Role { get; set; }

        public string TargetType { get; set; }

        public int? ReadState { get; set; }

        public int? WriteState { get; set; }

        public int? CreateState { get; set; }

        public int? DeleteState { get; set; }

        public int? NavigateState { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PermissionPolicyMemberPermissionsObject> PermissionPolicyMemberPermissionsObjects { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PermissionPolicyObjectPermissionsObject> PermissionPolicyObjectPermissionsObjects { get; set; }

        public virtual PermissionPolicyRole PermissionPolicyRole { get; set; }
    }
}
