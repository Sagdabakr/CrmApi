namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ModelDifferenceAspect")]
    public partial class ModelDifferenceAspect
    {
        [Key]
        public Guid Oid { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public string Xml { get; set; }

        public Guid? Owner { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        public virtual ModelDifference ModelDifference { get; set; }
    }
}
