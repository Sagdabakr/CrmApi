namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ModelDifference")]
    public partial class ModelDifference
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ModelDifference()
        {
            ModelDifferenceAspects = new HashSet<ModelDifferenceAspect>();
        }

        [Key]
        public Guid Oid { get; set; }

        [StringLength(100)]
        public string UserId { get; set; }

        [StringLength(100)]
        public string ContextId { get; set; }

        public int? Version { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModelDifferenceAspect> ModelDifferenceAspects { get; set; }
    }
}
