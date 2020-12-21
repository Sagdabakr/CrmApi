namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SparPart")]
    public partial class SparPart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SparPart()
        {
            SNSparParts = new HashSet<SNSparPart>();
        }

        [Key]
        public Guid Oid { get; set; }

        [StringLength(100)]
        public string PartNumber { get; set; }

        public string Description { get; set; }

        public Guid? StoreName { get; set; }

        [StringLength(100)]
        public string StandardRate { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SNSparPart> SNSparParts { get; set; }

        public virtual Store Store { get; set; }
    }
}
