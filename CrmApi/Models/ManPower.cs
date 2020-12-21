namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ManPower")]
    public partial class ManPower
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ManPower()
        {
            BaseAddresses = new HashSet<BaseAddress>();
            Emails = new HashSet<Email>();
            FixedPhones = new HashSet<FixedPhone>();
            Mobiles = new HashSet<Mobile>();
            OrganizationStructures = new HashSet<OrganizationStructure>();
            QualificationLists = new HashSet<QualificationList>();
            TaskTasks_ManPowerManPowers = new HashSet<TaskTasks_ManPowerManPowers>();
            WorkAreas = new HashSet<WorkArea>();
        }

        [Key]
        public Guid Oid { get; set; }

        public bool? HasPrimaryMobile { get; set; }

        public bool? HasPrimaryFixedPhone { get; set; }

        public bool? HasPrimaryEmail { get; set; }

        [StringLength(100)]
        public string ManPowerId { get; set; }

        [StringLength(100)]
        public string ArabicName { get; set; }

        [StringLength(100)]
        public string EnglishName { get; set; }

        public Guid? Shift { get; set; }

        public Guid? Trade { get; set; }

        public Guid? Country { get; set; }

        public Guid? City { get; set; }

        public Guid? Grade { get; set; }

        public Guid? Specialization { get; set; }

        public byte[] Image { get; set; }

        public Guid? Position { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaseAddress> BaseAddresses { get; set; }

        public virtual City City1 { get; set; }

        public virtual Country Country1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Email> Emails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FixedPhone> FixedPhones { get; set; }

        public virtual Grade Grade1 { get; set; }

        public virtual PermissionPolicyUser PermissionPolicyUser { get; set; }

        public virtual OrganizationStructure OrganizationStructure { get; set; }

        public virtual Shift Shift1 { get; set; }

        public virtual Specialization Specialization1 { get; set; }

        public virtual Trade Trade1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mobile> Mobiles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationStructure> OrganizationStructures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QualificationList> QualificationLists { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskTasks_ManPowerManPowers> TaskTasks_ManPowerManPowers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkArea> WorkAreas { get; set; }
    }
}
