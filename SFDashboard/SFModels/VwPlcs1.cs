using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwPlcs1
    {
        [Column("Key ID")]
        public int KeyId { get; set; }
        [Column("Acc Code")]
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? Amt { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Branch Code")]
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [Column("Cheque Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ChequeDate { get; set; }
        [Column("Cheque No")]
        [StringLength(20)]
        public string? ChequeNo { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column("Department Code")]
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [StringLength(255)]
        public string? Description { get; set; }
        [Column("Hawb Or H Bl No")]
        [StringLength(30)]
        public string? HawbOrHBlNo { get; set; }
        [Column("Invoice Cheque No")]
        [StringLength(20)]
        public string? InvoiceChequeNo { get; set; }
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("Journal Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? JournalDate { get; set; }
        [Column("Journal No")]
        [StringLength(20)]
        public string? JournalNo { get; set; }
        [Column("Line Item No")]
        public int? LineItemNo { get; set; }
        [Column("Local Amt", TypeName = "decimal(20, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column("Mawb Or O Bl No")]
        [StringLength(30)]
        public string? MawbOrOBlNo { get; set; }
        [Column("Post Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PostDate { get; set; }
        [Column("Post Mth")]
        [StringLength(6)]
        public string? PostMth { get; set; }
        [Column("Purchase Order No")]
        [StringLength(1)]
        [Unicode(false)]
        public string PurchaseOrderNo { get; set; } = null!;
        [Column("Ref No")]
        [StringLength(10)]
        public string? RefNo { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column("Transit No")]
        [StringLength(1)]
        [Unicode(false)]
        public string TransitNo { get; set; } = null!;
        [Column("Trx Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TrxDate { get; set; }
        [Column("Trx Type")]
        [StringLength(1)]
        public string? TrxType { get; set; }
        [Column("Vendor Code")]
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [Column("Vendor Name")]
        [StringLength(80)]
        public string? VendorName { get; set; }
        [Column("Voucher No")]
        [StringLength(20)]
        public string? VoucherNo { get; set; }
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
