namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QualificationFileData")]
    public partial class QualificationFileData
    {
        [Key]
        public Guid Oid { get; set; }

        public Guid? File { get; set; }

        public Guid? QualificationList { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        public virtual FileData FileData { get; set; }

        public virtual QualificationList QualificationList1 { get; set; }
    }
}
