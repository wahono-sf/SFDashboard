using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwWhpa1
    {
        [Column("Unique Key")]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        [Column("Address 1")]
        [StringLength(45)]
        public string? Address1 { get; set; }
        [Column("Address 2")]
        [StringLength(45)]
        public string? Address2 { get; set; }
        [Column("Address 3")]
        [StringLength(45)]
        public string? Address3 { get; set; }
        [Column("Address 4")]
        [StringLength(45)]
        public string? Address4 { get; set; }
        [Column("Add Lot No Flag")]
        [StringLength(1)]
        public string? AddLotNoFlag { get; set; }
        [Column("Billing Type")]
        [StringLength(10)]
        public string? BillingType { get; set; }
        [Column("Contact Name")]
        [StringLength(50)]
        public string? ContactName { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Default Storage Charge Code")]
        [StringLength(30)]
        public string? DefaultStorageChargeCode { get; set; }
        [Column("Document Footer 1")]
        [StringLength(255)]
        public string? DocumentFooter1 { get; set; }
        [Column("Document Footer 2")]
        [StringLength(255)]
        public string? DocumentFooter2 { get; set; }
        [StringLength(30)]
        public string? Fax { get; set; }
        [Column("Feet Square", TypeName = "decimal(13, 2)")]
        public decimal? FeetSquare { get; set; }
        [Column("Last Run Eod Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastRunEodDate { get; set; }
        [Column("Meter Square", TypeName = "decimal(13, 2)")]
        public decimal? MeterSquare { get; set; }
        [Column("Next Contract No")]
        [StringLength(7)]
        public string? NextContractNo { get; set; }
        [StringLength(50)]
        public string? Position { get; set; }
        [Column("Renew Notice Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? RenewNoticeDate { get; set; }
        [Column("Show Billing Detail Flag")]
        [StringLength(1)]
        public string? ShowBillingDetailFlag { get; set; }
        [StringLength(30)]
        public string? TelePhone { get; set; }
        [Column("Terminate Notice", TypeName = "decimal(13, 2)")]
        public decimal? TerminateNotice { get; set; }
        [Column("Uom Code")]
        [StringLength(3)]
        public string? UomCode { get; set; }
        [Column("Warehouse Name")]
        [StringLength(80)]
        public string? WarehouseName { get; set; }
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
