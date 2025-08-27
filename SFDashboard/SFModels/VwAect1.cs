using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAect1
    {
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Cargo Trf Form No")]
        [StringLength(8)]
        public string CargoTrfFormNo { get; set; } = null!;
        [Column("Container Flag")]
        [StringLength(1)]
        public string? ContainerFlag { get; set; }
        [Column("Dest Company Code")]
        [StringLength(10)]
        public string? DestCompanyCode { get; set; }
        [Column("Division Code")]
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Shipment Confirm Flag")]
        [StringLength(1)]
        public string? ShipmentConfirmFlag { get; set; }
        [Column("Site Code")]
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column("Total Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalCostAmt { get; set; }
        [Column("Total Weight", TypeName = "decimal(38, 4)")]
        public decimal? TotalWeight { get; set; }
        [Column("Trf Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TrfDate { get; set; }
        [Column("Urgent Flag")]
        [StringLength(1)]
        public string? UrgentFlag { get; set; }
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
