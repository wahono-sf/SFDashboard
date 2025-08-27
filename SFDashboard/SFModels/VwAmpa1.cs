using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAmpa1
    {
        [Column("Unique Key")]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        [Column("Approve Attachment Flag")]
        [StringLength(1)]
        public string? ApproveAttachmentFlag { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Def Hdr 01")]
        [StringLength(5)]
        public string? DefHdr01 { get; set; }
        [Column("Def Hdr 02")]
        [StringLength(5)]
        public string? DefHdr02 { get; set; }
        [Column("Def Hdr 03")]
        [StringLength(5)]
        public string? DefHdr03 { get; set; }
        [Column("Def Hdr 04")]
        [StringLength(5)]
        public string? DefHdr04 { get; set; }
        [Column("Def Hdr 05")]
        [StringLength(5)]
        public string? DefHdr05 { get; set; }
        [Column("Def Hdr 06")]
        [StringLength(5)]
        public string? DefHdr06 { get; set; }
        [Column("Def Hdr 07")]
        [StringLength(5)]
        public string? DefHdr07 { get; set; }
        [Column("Def Hdr 08")]
        [StringLength(5)]
        public string? DefHdr08 { get; set; }
        [Column("Def Hdr 09")]
        [StringLength(5)]
        public string? DefHdr09 { get; set; }
        [Column("Def Hdr 10")]
        [StringLength(5)]
        public string? DefHdr10 { get; set; }
        [Column("Def Rate Class Code 01")]
        [StringLength(1)]
        public string? DefRateClassCode01 { get; set; }
        [Column("Def Rate Class Code 02")]
        [StringLength(1)]
        public string? DefRateClassCode02 { get; set; }
        [Column("Def Rate Class Code 03")]
        [StringLength(1)]
        public string? DefRateClassCode03 { get; set; }
        [Column("Def Rate Class Code 04")]
        [StringLength(1)]
        public string? DefRateClassCode04 { get; set; }
        [Column("Def Rate Class Code 05")]
        [StringLength(1)]
        public string? DefRateClassCode05 { get; set; }
        [Column("Def Rate Class Code 06")]
        [StringLength(1)]
        public string? DefRateClassCode06 { get; set; }
        [Column("Def Rate Class Code 07")]
        [StringLength(1)]
        public string? DefRateClassCode07 { get; set; }
        [Column("Def Rate Class Code 08")]
        [StringLength(1)]
        public string? DefRateClassCode08 { get; set; }
        [Column("Def Rate Class Code 09")]
        [StringLength(1)]
        public string? DefRateClassCode09 { get; set; }
        [Column("Def Rate Class Code 10")]
        [StringLength(1)]
        public string? DefRateClassCode10 { get; set; }
        [Column("Def Weight Break 01", TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak01 { get; set; }
        [Column("Def Weight Break 02", TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak02 { get; set; }
        [Column("Def Weight Break 03", TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak03 { get; set; }
        [Column("Def Weight Break 04", TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak04 { get; set; }
        [Column("Def Weight Break 05", TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak05 { get; set; }
        [Column("Def Weight Break 06", TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak06 { get; set; }
        [Column("Def Weight Break 07", TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak07 { get; set; }
        [Column("Def Weight Break 08", TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak08 { get; set; }
        [Column("Def Weight Break 09", TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak09 { get; set; }
        [Column("Def Weight Break 10", TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak10 { get; set; }
        [Column("Def Weight Break 11", TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak11 { get; set; }
        [Column("Def Weight Break 12", TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak12 { get; set; }
        [Column("Def Weight Break 13", TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak13 { get; set; }
        [Column("Def Weight Break 14", TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak14 { get; set; }
        [Column("Def Weight Break 15", TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak15 { get; set; }
        [Column("Def Weight Break 16", TypeName = "decimal(13, 4)")]
        public decimal? DefWeightBreak16 { get; set; }
        [Column("Def Weight Type")]
        [StringLength(1)]
        public string? DefWeightType { get; set; }
        [Column("Format Type")]
        [StringLength(1)]
        public string? FormatType { get; set; }
        [Column("Hide Cost Rate Flag")]
        [StringLength(1)]
        public string? HideCostRateFlag { get; set; }
        [Column("Markup Rate", TypeName = "decimal(13, 2)")]
        public decimal? MarkupRate { get; set; }
        [Column("Next Quote No")]
        [StringLength(10)]
        public string? NextQuoteNo { get; set; }
        [Column("Show Job Costing Remark Flag")]
        [StringLength(1)]
        public string? ShowJobCostingRemarkFlag { get; set; }
        [Column("Show Quotation No Flag")]
        [StringLength(1)]
        public string? ShowQuotationNoFlag { get; set; }
        [StringLength(16)]
        public string? Validity { get; set; }
        [Column("Validity Days")]
        public short? ValidityDays { get; set; }
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
