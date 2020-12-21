namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CounteryCodePhone")]
    public partial class CounteryCodePhone
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CounteryCodePhone()
        {
            Faxes = new HashSet<Fax>();
            FixedPhones = new HashSet<FixedPhone>();
            Mobiles = new HashSet<Mobile>();
            Whatsapps = new HashSet<Whatsapp>();
        }

        [Key]
        public Guid Oid { get; set; }

        [StringLength(100)]
        public string ArabicCounteryName { get; set; }

        [StringLength(100)]
        public string CounteryNumberCode { get; set; }

        [StringLength(100)]
        public string EnglishCounteryName { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fax> Faxes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FixedPhone> FixedPhones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mobile> Mobiles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Whatsapp> Whatsapps { get; set; }
    }
}
