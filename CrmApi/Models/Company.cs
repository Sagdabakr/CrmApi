namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Company")]
    public partial class Company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Company()
        {
            CompanyBranches = new HashSet<CompanyBranch>();
            Contracts = new HashSet<Contract>();
            Customers = new HashSet<Customer>();
            WorkAreas = new HashSet<WorkArea>();
        }

        [Key]
        public Guid Oid { get; set; }

        [StringLength(100)]
        public string CompanyCode { get; set; }

        [StringLength(100)]
        public string ArabicCompanyName { get; set; }

        [StringLength(100)]
        public string EnglishCompanyName { get; set; }

        [StringLength(100)]
        public string Website { get; set; }

        public byte[] Logo { get; set; }

        public bool? HasHeadQuarter { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyBranch> CompanyBranches { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contracts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkArea> WorkAreas { get; set; }
    }
}
