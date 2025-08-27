using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwGljv1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Approve By")]
        [StringLength(50)]
        public string? ApproveBy { get; set; }
        [Column("Approve Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ApproveDate { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Bank Code")]
        [StringLength(10)]
        public string? BankCode { get; set; }
        [Column("Cheque Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ChequeDate { get; set; }
        [Column("Clear Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ClearDate { get; set; }
        [Column("Copy Template Name")]
        [StringLength(50)]
        public string? CopyTemplateName { get; set; }
        [Column("Copy Template Remark")]
        [StringLength(255)]
        public string? CopyTemplateRemark { get; set; }
        [Column("Credit Amt", TypeName = "decimal(38, 2)")]
        public decimal CreditAmt { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column("Debit Amt", TypeName = "decimal(38, 2)")]
        public decimal DebitAmt { get; set; }
        [Column("Description 1")]
        [StringLength(100)]
        public string? Description1 { get; set; }
        [Column("Description 2")]
        [StringLength(100)]
        public string? Description2 { get; set; }
        [Column("Doc No")]
        [StringLength(20)]
        public string? DocNo { get; set; }
        [Column("Doc Type")]
        [StringLength(1)]
        public string? DocType { get; set; }
        [Column("Event Template Name")]
        [StringLength(50)]
        public string? EventTemplateName { get; set; }
        [Column("Interbank Flag")]
        [StringLength(1)]
        public string? InterbankFlag { get; set; }
        [Column("Journal Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? JournalDate { get; set; }
        [Column("Journal No")]
        [StringLength(20)]
        public string? JournalNo { get; set; }
        [Column("Journal Type")]
        [StringLength(3)]
        public string? JournalType { get; set; }
        [Column("Local Sub Total Amt", TypeName = "decimal(17, 2)")]
        public decimal? LocalSubTotalAmt { get; set; }
        [Column("Lock By")]
        [StringLength(50)]
        public string? LockBy { get; set; }
        [Column("Lock Flag")]
        [StringLength(1)]
        public string? LockFlag { get; set; }
        [Column("Pay Mode")]
        [StringLength(5)]
        public string? PayMode { get; set; }
        [Column("Post By")]
        [StringLength(50)]
        public string? PostBy { get; set; }
        [Column("Post Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PostDate { get; set; }
        [Column("Post Flag")]
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [Column("Post Mth")]
        [StringLength(6)]
        public string? PostMth { get; set; }
        [Column("Provision Sales Cost Flag")]
        [StringLength(1)]
        public string? ProvisionSalesCostFlag { get; set; }
        [StringLength(20)]
        public string? Reference { get; set; }
        [Column("Ref No")]
        [StringLength(10)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Request By")]
        [StringLength(50)]
        public string? RequestBy { get; set; }
        [Column("Request To")]
        [StringLength(250)]
        public string? RequestTo { get; set; }
        [Column("Sub Total Amt", TypeName = "decimal(17, 2)")]
        public decimal? SubTotalAmt { get; set; }
        [Column("Template Name")]
        [StringLength(50)]
        public string? TemplateName { get; set; }
        [Column("User ID")]
        [StringLength(20)]
        public string? UserId { get; set; }
        [Column("Voucher No")]
        [StringLength(20)]
        public string? VoucherNo { get; set; }
        [Column("Voucher Type")]
        [StringLength(2)]
        public string? VoucherType { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [Column("Branch Code")]
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [Column("Department Code")]
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string CreatedBy { get; set; } = null!;
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string UpdatedBy { get; set; } = null!;
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
