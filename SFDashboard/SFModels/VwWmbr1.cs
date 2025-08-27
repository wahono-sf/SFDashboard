using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwWmbr1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Auto Generate Inv Flag")]
        [StringLength(1)]
        public string? AutoGenerateInvFlag { get; set; }
        [Column("Billing Detail Flag")]
        [StringLength(1)]
        public string? BillingDetailFlag { get; set; }
        [Column("Billing Start Day")]
        public int? BillingStartDay { get; set; }
        [Column("Contract No")]
        [StringLength(12)]
        public string? ContractNo { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Effective Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EffectiveDate { get; set; }
        [Column("Expiry Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ExpiryDate { get; set; }
        [Column("Invoice By Batch Flag")]
        [StringLength(1)]
        public string? InvoiceByBatchFlag { get; set; }
        [Column("Min Inv Amt", TypeName = "decimal(13, 2)")]
        public decimal? MinInvAmt { get; set; }
        [Column("No Of Default Cycle")]
        public int? NoOfDefaultCycle { get; set; }
        [Column("On Hold Period")]
        public int? OnHoldPeriod { get; set; }
        [Column("Product Class")]
        [StringLength(10)]
        public string? ProductClass { get; set; }
        [Column("Product Trx No")]
        public int? ProductTrxNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Round Up Flag")]
        [StringLength(1)]
        public string? RoundUpFlag { get; set; }
        [Column("Storage Bill Flag")]
        [StringLength(1)]
        public string? StorageBillFlag { get; set; }
        [Column("Table No")]
        [StringLength(10)]
        public string TableNo { get; set; } = null!;
        [Column("Warehouse Code")]
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
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
