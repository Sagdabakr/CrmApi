namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Emails = new HashSet<Email>();
            Facebooks = new HashSet<Facebook>();
            Faxes = new HashSet<Fax>();
            FixedPhones = new HashSet<FixedPhone>();
            Mobiles = new HashSet<Mobile>();
            Requests = new HashSet<Request>();
            Requests1 = new HashSet<Request>();
            Whatsapps = new HashSet<Whatsapp>();
            WorkOrders = new HashSet<WorkOrder>();
        }

        [Key]
        public Guid Oid { get; set; }

        [StringLength(100)]
        public string CodeCustomer { get; set; }

        public bool? HasPrimaryMobile { get; set; }

        public bool? HasPrimaryEmail { get; set; }

        public bool? HasPrimaryFixedPhone { get; set; }

        public bool? HasPrimaryFax { get; set; }

        [StringLength(100)]
        public string ArabicCustomerName { get; set; }

        [StringLength(100)]
        public string EnglishCustomerName { get; set; }

        public Guid? Company { get; set; }

        public Guid? Branch { get; set; }

        public byte[] Photo { get; set; }

        public virtual Company Company1 { get; set; }

        public virtual CompanyBranch CompanyBranch { get; set; }

        public virtual PermissionPolicyUser PermissionPolicyUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Email> Emails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facebook> Facebooks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fax> Faxes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FixedPhone> FixedPhones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mobile> Mobiles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Request> Requests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Request> Requests1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Whatsapp> Whatsapps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
