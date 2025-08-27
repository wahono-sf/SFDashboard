using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTnhs1
    {
        [Column("HS Code")]
        [StringLength(8)]
        public string HsCode { get; set; } = null!;
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Custom Duty Rate", TypeName = "decimal(13, 2)")]
        public decimal? CustomDutyRate { get; set; }
        [Column("Custom Duty Uom Code")]
        [StringLength(3)]
        public string? CustomDutyUomCode { get; set; }
        [StringLength(255)]
        public string? Description { get; set; }
        [Column("Duty Rate Description")]
        [StringLength(300)]
        public string? DutyRateDescription { get; set; }
        [Column("Duty Type")]
        [StringLength(1)]
        public string? DutyType { get; set; }
        [Column("Excise Duty Rate", TypeName = "decimal(13, 2)")]
        public decimal? ExciseDutyRate { get; set; }
        [Column("Excise Duty Uom Code")]
        [StringLength(3)]
        public string? ExciseDutyUomCode { get; set; }
        [Column("Export Ind")]
        [StringLength(1)]
        public string? ExportInd { get; set; }
        [Column("Hs Type")]
        [StringLength(1)]
        public string? HsType { get; set; }
        [Column("Import Ind")]
        [StringLength(1)]
        public string? ImportInd { get; set; }
        [Column("Trans Ind")]
        [StringLength(1)]
        public string? TransInd { get; set; }
        [Column("Uom Code")]
        [StringLength(3)]
        public string? UomCode { get; set; }
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
