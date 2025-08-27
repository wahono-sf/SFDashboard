using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("gljv1")]
    [Index("WorkStation", Name = "INDEX_Gljv1_WorkStation")]
    public partial class Gljv1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(50)]
        public string? ApproveBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApproveDate { get; set; }
        [StringLength(10)]
        public string? BankCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ClearDate { get; set; }
        [StringLength(50)]
        public string? CopyTemplateName { get; set; }
        [StringLength(255)]
        public string? CopyTemplateRemark { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(100)]
        public string? Description1 { get; set; }
        [StringLength(100)]
        public string? Description2 { get; set; }
        [StringLength(20)]
        public string? DocNo { get; set; }
        [StringLength(1)]
        public string? DocType { get; set; }
        [StringLength(50)]
        public string? EventTemplateName { get; set; }
        [StringLength(1)]
        public string? InterbankFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? JournalDate { get; set; }
        [StringLength(20)]
        public string? JournalNo { get; set; }
        [StringLength(3)]
        public string? JournalType { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? LocalSubTotalAmt { get; set; }
        [StringLength(50)]
        public string? LockBy { get; set; }
        [StringLength(1)]
        public string? LockFlag { get; set; }
        [StringLength(5)]
        public string? PayMode { get; set; }
        [StringLength(50)]
        public string? PostBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PostDate { get; set; }
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [StringLength(6)]
        public string? PostMth { get; set; }
        [StringLength(1)]
        public string? ProvisionSalesCostFlag { get; set; }
        [StringLength(1)]
        public string? ReconcilFlag { get; set; }
        [StringLength(20)]
        public string? Reference { get; set; }
        [StringLength(10)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(50)]
        public string? RequestBy { get; set; }
        [StringLength(250)]
        public string? RequestTo { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? SubTotalAmt { get; set; }
        [StringLength(50)]
        public string? TemplateName { get; set; }
        [StringLength(20)]
        public string? UserId { get; set; }
        [StringLength(20)]
        public string? VoucherNo { get; set; }
        [StringLength(2)]
        public string? VoucherType { get; set; }
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
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
    }
}
