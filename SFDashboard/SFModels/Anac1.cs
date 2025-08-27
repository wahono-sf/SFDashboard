using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("anac1")]
    public partial class Anac1
    {
        public Anac1()
        {
            Anat1s = new HashSet<Anat1>();
        }

        [Key]
        [StringLength(3)]
        public string AwbCode { get; set; } = null!;
        [StringLength(50)]
        public string? AwbName { get; set; }
        public int? AwbLength { get; set; }
        [StringLength(1)]
        public string? AwbType { get; set; }
        [StringLength(1)]
        public string? CheckDigitFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastReceiptDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUseDate { get; set; }
        public int? LastYrAwbUse { get; set; }
        public int? MtdAwbUse { get; set; }
        [StringLength(1)]
        public string? NeutralAwbFlag { get; set; }
        public int? QtyOnHand { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        public int? ReorderQty { get; set; }
        public int? YtdAwbUse { get; set; }
        [StringLength(3)]
        public string? StatusCode { get; set; }
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }

        [InverseProperty("AwbCodeNavigation")]
        public virtual ICollection<Anat1> Anat1s { get; set; }
    }
}
