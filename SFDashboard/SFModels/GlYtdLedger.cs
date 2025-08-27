using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class GlYtdLedger
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Trx Type")]
        [StringLength(1)]
        public string? TrxType { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Amt { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(13, 6)")]
        public decimal? CurrRate { get; set; }
        [Column("Customer Or Vendor Code")]
        [StringLength(10)]
        public string? CustomerOrVendorCode { get; set; }
        [Column("Customer Or Vendor Name")]
        [StringLength(80)]
        public string? CustomerOrVendorName { get; set; }
        [StringLength(255)]
        public string? Description { get; set; }
        [Column("Financial Year")]
        [StringLength(4)]
        public string? FinancialYear { get; set; }
        [Column("Local Amt", TypeName = "decimal(20, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column("Acc Code")]
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column("Acc Description")]
        [StringLength(50)]
        public string? AccDescription { get; set; }
        [Column("Analysis Code 1")]
        [StringLength(15)]
        public string? AnalysisCode1 { get; set; }
        [Column("Analysis Code 2")]
        [StringLength(15)]
        public string? AnalysisCode2 { get; set; }
        [Column("Analysis Code 3")]
        [StringLength(15)]
        public string? AnalysisCode3 { get; set; }
        [Column("H Awb Or H Bl No")]
        [StringLength(20)]
        public string? HAwbOrHBlNo { get; set; }
        [Column("Invoice No")]
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Journal No")]
        [StringLength(20)]
        public string? JournalNo { get; set; }
        [Column("M Awb Or O Bl No")]
        [StringLength(20)]
        public string? MAwbOrOBlNo { get; set; }
        [Column("Post Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PostDate { get; set; }
        [Column("Post Mth")]
        [StringLength(6)]
        public string? PostMth { get; set; }
        [Column("Receipt Or Voucher No")]
        [StringLength(20)]
        public string? ReceiptOrVoucherNo { get; set; }
        [Column("Cheque No Or Reference")]
        [StringLength(20)]
        public string? ChequeNoOrReference { get; set; }
        [Column("Ref No")]
        [StringLength(10)]
        public string? RefNo { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column("Trx Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TrxDate { get; set; }
        [Column("Heading Flag")]
        [StringLength(1)]
        public string? HeadingFlag { get; set; }
        [Column("Control Acc Flag")]
        [StringLength(1)]
        public string? ControlAccFlag { get; set; }
        [Column("Keep Ytd Gl Flag")]
        [StringLength(1)]
        public string? KeepYtdGlFlag { get; set; }
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
