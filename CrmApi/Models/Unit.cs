namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Unit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Unit()
        {
            MaterialStores = new HashSet<MaterialStore>();
        }

        [Key]
        public Guid Oid { get; set; }

        [StringLength(100)]
        public string UnitCode { get; set; }

        [StringLength(100)]
        public string EnglishUnitName { get; set; }

        [StringLength(100)]
        public string ArabicUnitName { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialStore> MaterialStores { get; set; }
    }
}
