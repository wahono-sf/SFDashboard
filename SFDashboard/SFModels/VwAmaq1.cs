using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAmaq1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Agent Code")]
        [StringLength(10)]
        public string AgentCode { get; set; } = null!;
        [Column("Agent Name")]
        [StringLength(80)]
        public string? AgentName { get; set; }
        [Column("Airline ID")]
        [StringLength(2)]
        public string AirlineId { get; set; } = null!;
        [Column("Net Rate 01", TypeName = "decimal(13, 3)")]
        public decimal? NetRate01 { get; set; }
        [Column("Net Rate 02", TypeName = "decimal(13, 3)")]
        public decimal? NetRate02 { get; set; }
        [Column("Net Rate 03", TypeName = "decimal(13, 3)")]
        public decimal? NetRate03 { get; set; }
        [Column("Net Rate 04", TypeName = "decimal(13, 3)")]
        public decimal? NetRate04 { get; set; }
        [Column("Net Rate 05", TypeName = "decimal(13, 3)")]
        public decimal? NetRate05 { get; set; }
        [Column("Net Rate 06", TypeName = "decimal(13, 3)")]
        public decimal? NetRate06 { get; set; }
        [Column("Net Rate 07", TypeName = "decimal(13, 3)")]
        public decimal? NetRate07 { get; set; }
        [Column("Net Rate 08", TypeName = "decimal(13, 3)")]
        public decimal? NetRate08 { get; set; }
        [Column("Net Rate 09", TypeName = "decimal(13, 3)")]
        public decimal? NetRate09 { get; set; }
        [Column("Net Rate 10", TypeName = "decimal(13, 3)")]
        public decimal? NetRate10 { get; set; }
        [Column("Net Rate 11", TypeName = "decimal(13, 3)")]
        public decimal? NetRate11 { get; set; }
        [Column("Net Rate 12", TypeName = "decimal(13, 3)")]
        public decimal? NetRate12 { get; set; }
        [Column("Net Rate 13", TypeName = "decimal(13, 3)")]
        public decimal? NetRate13 { get; set; }
        [Column("Net Rate 14", TypeName = "decimal(13, 3)")]
        public decimal? NetRate14 { get; set; }
        [Column("Net Rate 15", TypeName = "decimal(13, 3)")]
        public decimal? NetRate15 { get; set; }
        [Column("Net Rate 16", TypeName = "decimal(13, 3)")]
        public decimal? NetRate16 { get; set; }
        [Column("Net Rate 17", TypeName = "decimal(13, 3)")]
        public decimal? NetRate17 { get; set; }
        [Column("Net Rate 18", TypeName = "decimal(13, 3)")]
        public decimal? NetRate18 { get; set; }
        [Column("Net Rate 19", TypeName = "decimal(13, 3)")]
        public decimal? NetRate19 { get; set; }
        [Column("Net Rate 20", TypeName = "decimal(13, 3)")]
        public decimal? NetRate20 { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Authorise By")]
        [StringLength(50)]
        public string? AuthoriseBy { get; set; }
        [Column("Break Point 01", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint01 { get; set; }
        [Column("Break Point 02", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint02 { get; set; }
        [Column("Break Point 03", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint03 { get; set; }
        [Column("Break Point 04", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint04 { get; set; }
        [Column("Break Point 05", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint05 { get; set; }
        [Column("Break Point 06", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint06 { get; set; }
        [Column("Break Point 07", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint07 { get; set; }
        [Column("Break Point 08", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint08 { get; set; }
        [Column("Break Point 09", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint09 { get; set; }
        [Column("Break Point 10", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint10 { get; set; }
        [Column("Break Point 11", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint11 { get; set; }
        [Column("Break Point 12", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint12 { get; set; }
        [Column("Break Point 13", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint13 { get; set; }
        [Column("Break Point 14", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint14 { get; set; }
        [Column("Break Point 15", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint15 { get; set; }
        [Column("Break Point 16", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint16 { get; set; }
        [Column("Break Point 17", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint17 { get; set; }
        [Column("Break Point 18", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint18 { get; set; }
        [Column("Break Point 19", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint19 { get; set; }
        [Column("Break Point 20", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint20 { get; set; }
        [Column("Commodity Code 01")]
        [StringLength(10)]
        public string? CommodityCode01 { get; set; }
        [Column("Commodity Code 02")]
        [StringLength(10)]
        public string? CommodityCode02 { get; set; }
        [Column("Commodity Code 03")]
        [StringLength(10)]
        public string? CommodityCode03 { get; set; }
        [Column("Commodity Code 04")]
        [StringLength(10)]
        public string? CommodityCode04 { get; set; }
        [Column("Commodity Code 05")]
        [StringLength(10)]
        public string? CommodityCode05 { get; set; }
        [Column("Commodity Code 06")]
        [StringLength(10)]
        public string? CommodityCode06 { get; set; }
        [Column("Commodity Code 07")]
        [StringLength(10)]
        public string? CommodityCode07 { get; set; }
        [Column("Commodity Code 08")]
        [StringLength(10)]
        public string? CommodityCode08 { get; set; }
        [Column("Commodity Code 09")]
        [StringLength(10)]
        public string? CommodityCode09 { get; set; }
        [Column("Commodity Code 10")]
        [StringLength(10)]
        public string? CommodityCode10 { get; set; }
        [Column("Commodity Code 11")]
        [StringLength(10)]
        public string? CommodityCode11 { get; set; }
        [Column("Commodity Code 12")]
        [StringLength(10)]
        public string? CommodityCode12 { get; set; }
        [Column("Commodity Code 13")]
        [StringLength(10)]
        public string? CommodityCode13 { get; set; }
        [Column("Commodity Code 14")]
        [StringLength(10)]
        public string? CommodityCode14 { get; set; }
        [Column("Commodity Code 15")]
        [StringLength(10)]
        public string? CommodityCode15 { get; set; }
        [Column("Commodity Code 16")]
        [StringLength(10)]
        public string? CommodityCode16 { get; set; }
        [Column("Commodity Code 17")]
        [StringLength(10)]
        public string? CommodityCode17 { get; set; }
        [Column("Commodity Code 18")]
        [StringLength(10)]
        public string? CommodityCode18 { get; set; }
        [Column("Commodity Code 19")]
        [StringLength(10)]
        public string? CommodityCode19 { get; set; }
        [Column("Commodity Code 20")]
        [StringLength(10)]
        public string? CommodityCode20 { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Dest Code")]
        [StringLength(3)]
        public string DestCode { get; set; } = null!;
        [Column("Effective Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EffectiveDate { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [Column("Origin Code")]
        [StringLength(3)]
        public string OriginCode { get; set; } = null!;
        [Column("Product Code")]
        [StringLength(10)]
        public string? ProductCode { get; set; }
        [Column("Rate Class Code 01")]
        [StringLength(1)]
        public string? RateClassCode01 { get; set; }
        [Column("Rate Class Code 02")]
        [StringLength(1)]
        public string? RateClassCode02 { get; set; }
        [Column("Rate Class Code 03")]
        [StringLength(1)]
        public string? RateClassCode03 { get; set; }
        [Column("Rate Class Code 04")]
        [StringLength(1)]
        public string? RateClassCode04 { get; set; }
        [Column("Rate Class Code 05")]
        [StringLength(1)]
        public string? RateClassCode05 { get; set; }
        [Column("Rate Class Code 06")]
        [StringLength(1)]
        public string? RateClassCode06 { get; set; }
        [Column("Rate Class Code 07")]
        [StringLength(1)]
        public string? RateClassCode07 { get; set; }
        [Column("Rate Class Code 08")]
        [StringLength(1)]
        public string? RateClassCode08 { get; set; }
        [Column("Rate Class Code 09")]
        [StringLength(1)]
        public string? RateClassCode09 { get; set; }
        [Column("Rate Class Code 10")]
        [StringLength(1)]
        public string? RateClassCode10 { get; set; }
        [Column("Rate Class Code 11")]
        [StringLength(1)]
        public string? RateClassCode11 { get; set; }
        [Column("Rate Class Code 12")]
        [StringLength(1)]
        public string? RateClassCode12 { get; set; }
        [Column("Rate Class Code 13")]
        [StringLength(1)]
        public string? RateClassCode13 { get; set; }
        [Column("Rate Class Code 14")]
        [StringLength(1)]
        public string? RateClassCode14 { get; set; }
        [Column("Rate Class Code 15")]
        [StringLength(1)]
        public string? RateClassCode15 { get; set; }
        [Column("Rate Class Code 16")]
        [StringLength(1)]
        public string? RateClassCode16 { get; set; }
        [Column("Rate Class Code 17")]
        [StringLength(1)]
        public string? RateClassCode17 { get; set; }
        [Column("Rate Class Code 18")]
        [StringLength(1)]
        public string? RateClassCode18 { get; set; }
        [Column("Rate Class Code 19")]
        [StringLength(1)]
        public string? RateClassCode19 { get; set; }
        [Column("Rate Class Code 20")]
        [StringLength(1)]
        public string? RateClassCode20 { get; set; }
        [Column("Ref No")]
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(1)]
        public string Type { get; set; } = null!;
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
