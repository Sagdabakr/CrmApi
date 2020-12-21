namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WorkOrder")]
    public partial class WorkOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkOrder()
        {
            Requests = new HashSet<Request>();
            Tasks = new HashSet<Task>();
            WorkOrderSchedulers = new HashSet<WorkOrderScheduler>();
        }

        [Key]
        public Guid Oid { get; set; }

        public Guid? Scheduler { get; set; }

        [StringLength(100)]
        public string WorkOrderNumber { get; set; }

        public DateTime? WorkOrderDate { get; set; }

        public Guid? Customer { get; set; }

        public Guid? TypeOfService { get; set; }

        public DateTime? PreferredDate { get; set; }

        public DateTime? PreferredTime { get; set; }

        public string Description { get; set; }

        public DateTime? ActualStartDate { get; set; }

        public DateTime? ActualEndDate { get; set; }

        public DateTime? ActualStartTime { get; set; }

        public DateTime? ActualEndTime { get; set; }

        [StringLength(100)]
        public string Duration { get; set; }

        public int? Status { get; set; }

        public DateTime? StatusDate { get; set; }

        public Guid? Request { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        public virtual Customer Customer1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Request> Requests { get; set; }

        public virtual Request Request1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task> Tasks { get; set; }

        public virtual TypeOfService TypeOfService1 { get; set; }

        public virtual WorkOrderScheduler WorkOrderScheduler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrderScheduler> WorkOrderSchedulers { get; set; }
    }
}
