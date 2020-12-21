namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Task")]
    public partial class Task
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Task()
        {
            TaskTasks_ManPowerManPowers = new HashSet<TaskTasks_ManPowerManPowers>();
        }

        [Key]
        public Guid Oid { get; set; }

        [StringLength(100)]
        public string TaskCode { get; set; }

        public int? Status { get; set; }

        [StringLength(100)]
        public string EstimateDuration { get; set; }

        [StringLength(100)]
        public string Summary { get; set; }

        public string Description { get; set; }

        public Guid? WorkOrder { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        public virtual WorkOrder WorkOrder1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskTasks_ManPowerManPowers> TaskTasks_ManPowerManPowers { get; set; }
    }
}
