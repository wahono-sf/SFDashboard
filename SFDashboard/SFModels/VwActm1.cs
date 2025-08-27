using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwActm1
    {
        [Column("Term Code")]
        [StringLength(3)]
        public string TermCode { get; set; } = null!;
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Discount Date Flag")]
        [StringLength(1)]
        public string? DiscountDateFlag { get; set; }
        [Column("Discount Day")]
        public short? DiscountDay { get; set; }
        [Column("Discount Percent", TypeName = "decimal(6, 3)")]
        public decimal? DiscountPercent { get; set; }
        [Column("Net Date Flag")]
        [StringLength(1)]
        public string? NetDateFlag { get; set; }
        [Column("Net Day")]
        public short? NetDay { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Service Charge Min Amt", TypeName = "decimal(13, 2)")]
        public decimal? ServiceChargeMinAmt { get; set; }
        [Column("Service Charge Percent", TypeName = "decimal(6, 3)")]
        public decimal? ServiceChargePercent { get; set; }
        [Column("Shipment Date Flag")]
        [StringLength(1)]
        public string? ShipmentDateFlag { get; set; }
        [Column("Term Description")]
        [StringLength(50)]
        public string? TermDescription { get; set; }
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
