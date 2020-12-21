namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseAddress")]
    public partial class BaseAddress
    {
        [Key]
        public Guid Oid { get; set; }

        public string ArabicAddress { get; set; }

        public string EnglishAddress { get; set; }

        public Guid? CompanyBranch { get; set; }

        public Guid? ManPower { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        public virtual CompanyBranch CompanyBranch1 { get; set; }

        public virtual ManPower ManPower1 { get; set; }
    }
}
