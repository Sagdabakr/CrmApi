namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ReportDataV2
    {
        [Key]
        public Guid Oid { get; set; }

        [StringLength(512)]
        public string ObjectTypeName { get; set; }

        public byte[] Content { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(512)]
        public string ParametersObjectTypeName { get; set; }

        public bool? IsInplaceReport { get; set; }

        [StringLength(512)]
        public string PredefinedReportType { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }
    }
}
