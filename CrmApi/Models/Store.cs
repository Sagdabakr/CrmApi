namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Store")]
    public partial class Store
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Store()
        {
            MaterialStores = new HashSet<MaterialStore>();
            SNSparParts = new HashSet<SNSparPart>();
            SparParts = new HashSet<SparPart>();
            ToolStores = new HashSet<ToolStore>();
        }

        [Key]
        public Guid Oid { get; set; }

        [StringLength(100)]
        public string CodeStore { get; set; }

        [StringLength(100)]
        public string ArabicStoreName { get; set; }

        [StringLength(100)]
        public string EnglishStoreName { get; set; }

        public Guid? StoreType { get; set; }

        public Guid? Country { get; set; }

        public Guid? City { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        public virtual City City1 { get; set; }

        public virtual Country Country1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialStore> MaterialStores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SNSparPart> SNSparParts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SparPart> SparParts { get; set; }

        public virtual StoreType StoreType1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ToolStore> ToolStores { get; set; }
    }
}
