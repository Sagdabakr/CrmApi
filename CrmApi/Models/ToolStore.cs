namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ToolStore")]
    public partial class ToolStore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ToolStore()
        {
            SNToolsStores = new HashSet<SNToolsStore>();
        }

        [Key]
        public Guid Oid { get; set; }

        public bool? Calibration { get; set; }

        public string Description { get; set; }

        [StringLength(100)]
        public string PartNumber { get; set; }

        public Guid? StoreName { get; set; }

        [StringLength(100)]
        public string StanderRate { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SNToolsStore> SNToolsStores { get; set; }

        public virtual Store Store { get; set; }
    }
}
