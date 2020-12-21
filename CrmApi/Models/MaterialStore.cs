namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MaterialStore
    {
        [Key]
        public Guid Oid { get; set; }

        [StringLength(100)]
        public string ItemCode { get; set; }

        public string Description { get; set; }

        public int? Quantity { get; set; }

        public Guid? Unit { get; set; }

        public Guid? GroupsOfItem { get; set; }

        public Guid? Store { get; set; }

        [StringLength(100)]
        public string StanderRate { get; set; }

        [StringLength(100)]
        public string ItemName { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        public virtual GroupsOfItem GroupsOfItem1 { get; set; }

        public virtual Store Store1 { get; set; }

        public virtual Unit Unit1 { get; set; }
    }
}
