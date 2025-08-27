using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwGlbc1
    {
        [Column("Bank Code")]
        [StringLength(10)]
        public string BankCode { get; set; } = null!;
        [Column("Bank Name")]
        [StringLength(50)]
        public string? BankName { get; set; }
        [Column("Acc Code")]
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column("Address 1")]
        [StringLength(50)]
        public string? Address1 { get; set; }
        [Column("Address 2")]
        [StringLength(50)]
        public string? Address2 { get; set; }
        [Column("Address 3")]
        [StringLength(50)]
        public string? Address3 { get; set; }
        [Column("Address 4")]
        [StringLength(50)]
        public string? Address4 { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Bank Acc No")]
        [StringLength(50)]
        public string? BankAccNo { get; set; }
        [Column("Clear Bank Code")]
        [StringLength(10)]
        public string? ClearBankCode { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Gl Balance", TypeName = "decimal(38, 2)")]
        public decimal? GlBalance { get; set; }
        [Column("Lock Curr Code Flag")]
        [StringLength(1)]
        public string? LockCurrCodeFlag { get; set; }
        [Column("Next Cheque No")]
        [StringLength(20)]
        public string? NextChequeNo { get; set; }
        [Column("Payment Limit", TypeName = "decimal(17, 2)")]
        public decimal? PaymentLimit { get; set; }
        [Column("Reconcile Balance", TypeName = "decimal(38, 2)")]
        public decimal? ReconcileBalance { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Swift Code")]
        [StringLength(20)]
        public string? SwiftCode { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
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
