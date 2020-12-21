namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyBranch")]
    public partial class CompanyBranch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompanyBranch()
        {
            BaseAddresses = new HashSet<BaseAddress>();
            Customers = new HashSet<Customer>();
            WorkAreas = new HashSet<WorkArea>();
        }

        [Key]
        public Guid Oid { get; set; }

        [StringLength(100)]
        public string BranchCode { get; set; }

        public Guid? Company { get; set; }

        [StringLength(100)]
        public string EnglishBranchName { get; set; }

        [StringLength(100)]
        public string ArabicBranchName { get; set; }

        public Guid? Country { get; set; }

        public Guid? City { get; set; }

        [StringLength(100)]
        public string PostalCode { get; set; }

        public bool? HeadQuarter { get; set; }

        [StringLength(100)]
        public string MapLatitude { get; set; }

        [StringLength(100)]
        public string MapLongitude { get; set; }

        public DateTime? WorkTimeStart { get; set; }

        public DateTime? WorkTimeEnd { get; set; }

        public int? StartWorkDay { get; set; }

        public int? EndWorkDay { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaseAddress> BaseAddresses { get; set; }

        public virtual City City1 { get; set; }

        public virtual Company Company1 { get; set; }

        public virtual Country Country1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkArea> WorkAreas { get; set; }
    }
}
