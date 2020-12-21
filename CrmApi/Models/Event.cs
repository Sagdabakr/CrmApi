namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Event")]
    public partial class Event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Event()
        {
            Event1 = new HashSet<Event>();
            ResourceResources_EventEvents = new HashSet<ResourceResources_EventEvents>();
        }

        [Key]
        public Guid Oid { get; set; }

        public string ResourceIds { get; set; }

        public Guid? RecurrencePattern { get; set; }

        [StringLength(250)]
        public string Subject { get; set; }

        public string Description { get; set; }

        public DateTime? StartOn { get; set; }

        public DateTime? EndOn { get; set; }

        public bool? AllDay { get; set; }

        [StringLength(100)]
        public string Location { get; set; }

        public int? Label { get; set; }

        public int? Status { get; set; }

        public int? Type { get; set; }

        public double? RemindIn { get; set; }

        [StringLength(200)]
        public string ReminderInfoXml { get; set; }

        public DateTime? AlarmTime { get; set; }

        public bool? IsPostponed { get; set; }

        public string RecurrenceInfoXml { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        public int? ObjectType { get; set; }

        public virtual XPObjectType XPObjectType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event> Event1 { get; set; }

        public virtual Event Event2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResourceResources_EventEvents> ResourceResources_EventEvents { get; set; }

        public virtual WorkOrderScheduler WorkOrderScheduler { get; set; }
    }
}
