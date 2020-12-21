namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrganizationStructure")]
    public partial class OrganizationStructure
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrganizationStructure()
        {
            ManPowers = new HashSet<ManPower>();
        }

        [Key]
        public Guid Oid { get; set; }

        [StringLength(100)]
        public string PositionTitle { get; set; }

        public Guid? Responsible { get; set; }

        public virtual HCategory HCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ManPower> ManPowers { get; set; }

        public virtual ManPower ManPower { get; set; }
    }
}
