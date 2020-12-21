namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ResourceResources_EventEvents
    {
        public Guid? Events { get; set; }

        public Guid? Resources { get; set; }

        [Key]
        public Guid OID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual Event Event { get; set; }

        public virtual Resource Resource { get; set; }
    }
}
