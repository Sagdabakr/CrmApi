namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TaskTasks_ManPowerManPowers
    {
        public Guid? ManPowers { get; set; }

        public Guid? Tasks { get; set; }

        [Key]
        public Guid OID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual ManPower ManPower { get; set; }

        public virtual Task Task { get; set; }
    }
}
