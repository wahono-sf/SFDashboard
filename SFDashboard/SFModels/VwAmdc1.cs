using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAmdc1
    {
        [Column("Trx No")]
        public short TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Awb Charge Code")]
        [StringLength(3)]
        public string AwbChargeCode { get; set; } = null!;
        [Column("District Code")]
        [StringLength(5)]
        public string DistrictCode { get; set; } = null!;
        [Column("Quote Rate 01", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate01 { get; set; }
        [Column("Quote Rate 02", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate02 { get; set; }
        [Column("Quote Rate 03", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate03 { get; set; }
        [Column("Quote Rate 04", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate04 { get; set; }
        [Column("Quote Rate 05", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate05 { get; set; }
        [Column("Quote Rate 06", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate06 { get; set; }
        [Column("Quote Rate 07", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate07 { get; set; }
        [Column("Quote Rate 08", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate08 { get; set; }
        [Column("Quote Rate 09", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate09 { get; set; }
        [Column("Quote Rate 10", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate10 { get; set; }
        [Column("Quote Rate 11", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate11 { get; set; }
        [Column("Quote Rate 12", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate12 { get; set; }
        [Column("Quote Rate 13", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate13 { get; set; }
        [Column("Quote Rate 14", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate14 { get; set; }
        [Column("Quote Rate 15", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate15 { get; set; }
        [Column("Quote Rate 16", TypeName = "decimal(13, 3)")]
        public decimal? QuoteRate16 { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Sales Item Code")]
        [StringLength(30)]
        public string? SalesItemCode { get; set; }
        [Column("Weight Break 01", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak01 { get; set; }
        [Column("Weight Break 02", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak02 { get; set; }
        [Column("Weight Break 03", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak03 { get; set; }
        [Column("Weight Break 04", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak04 { get; set; }
        [Column("Weight Break 05", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak05 { get; set; }
        [Column("Weight Break 06", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak06 { get; set; }
        [Column("Weight Break 07", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak07 { get; set; }
        [Column("Weight Break 08", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak08 { get; set; }
        [Column("Weight Break 09", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak09 { get; set; }
        [Column("Weight Break 10", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak10 { get; set; }
        [Column("Weight Break 11", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak11 { get; set; }
        [Column("Weight Break 12", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak12 { get; set; }
        [Column("Weight Break 13", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak13 { get; set; }
        [Column("Weight Break 14", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak14 { get; set; }
        [Column("Weight Break 15", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak15 { get; set; }
        [Column("Weight Break 16", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak16 { get; set; }
        [Column("Weight Type")]
        [StringLength(1)]
        public string? WeightType { get; set; }
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
