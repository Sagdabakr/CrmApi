namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HCategory")]
    public partial class HCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HCategory()
        {
            HCategory1 = new HashSet<HCategory>();
        }

        [Key]
        public Guid Oid { get; set; }

        public Guid? Parent { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        public int? ObjectType { get; set; }

        public virtual XPObjectType XPObjectType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HCategory> HCategory1 { get; set; }

        public virtual HCategory HCategory2 { get; set; }

        public virtual OrganizationStructure OrganizationStructure { get; set; }
    }
}
