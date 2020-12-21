namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContractService")]
    public partial class ContractService
    {
        [Key]
        public Guid Oid { get; set; }

        public Guid? TypeOfService { get; set; }

        public int? NumberOfService { get; set; }

        public Guid? Contract { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        public virtual Contract Contract1 { get; set; }

        public virtual TypeOfService TypeOfService1 { get; set; }
    }
}
