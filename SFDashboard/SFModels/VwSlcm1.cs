using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSlcm1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amount { get; set; }
        [Column("Backup Amount", TypeName = "decimal(13, 2)")]
        public decimal? BackupAmount { get; set; }
        [Column("Backup End Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? BackupEndDate { get; set; }
        [Column("Backup Flag")]
        [StringLength(1)]
        public string? BackupFlag { get; set; }
        [Column("Backup Invoice Remark")]
        [StringLength(80)]
        public string? BackupInvoiceRemark { get; set; }
        [Column("Backup Start Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? BackupStartDate { get; set; }
        [Column("Billing Cycle")]
        [StringLength(3)]
        public string? BillingCycle { get; set; }
        [Column("Cloud Flag")]
        [StringLength(1)]
        public string? CloudFlag { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("End Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EndDate { get; set; }
        [Column("Invoice Remark")]
        [StringLength(80)]
        public string? InvoiceRemark { get; set; }
        [StringLength(80)]
        public string? Module { get; set; }
        [Column("No Of User")]
        public int? NoOfUser { get; set; }
        [StringLength(1000)]
        public string? Note { get; set; }
        [Column("Others Remarks")]
        [StringLength(80)]
        public string? OthersRemarks { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Start Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? StartDate { get; set; }
        [StringLength(1)]
        public string? Type { get; set; }
        [StringLength(20)]
        public string? Version { get; set; }
        [Column("Yearly Amount", TypeName = "decimal(16, 2)")]
        public decimal? YearlyAmount { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [StringLength(3)]
        public string Status { get; set; } = null!;
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
    }
}
