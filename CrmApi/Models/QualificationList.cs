namespace CrmApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QualificationList")]
    public partial class QualificationList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QualificationList()
        {
            QualificationFileDatas = new HashSet<QualificationFileData>();
        }

        [Key]
        public Guid Oid { get; set; }

        public DateTime? Date { get; set; }

        public DateTime? EndDate { get; set; }

        public Guid? Qualification { get; set; }

        public Guid? ManPower { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        public virtual ManPower ManPower1 { get; set; }

        public virtual Qualification Qualification1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QualificationFileData> QualificationFileDatas { get; set; }
    }
}
