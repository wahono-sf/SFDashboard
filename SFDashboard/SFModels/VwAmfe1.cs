using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAmfe1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Airline ID")]
        [StringLength(2)]
        public string AirlineId { get; set; } = null!;
        [Column("Airline Name")]
        [StringLength(50)]
        public string? AirlineName { get; set; }
        [Column("Quote Amt 01", TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt01 { get; set; }
        [Column("Quote Amt 02", TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt02 { get; set; }
        [Column("Quote Amt 03", TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt03 { get; set; }
        [Column("Quote Amt 04", TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt04 { get; set; }
        [Column("Quote Amt 05", TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt05 { get; set; }
        [Column("Quote Amt 06", TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt06 { get; set; }
        [Column("Quote Amt 07", TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt07 { get; set; }
        [Column("Quote Amt 08", TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt08 { get; set; }
        [Column("Quote Amt 09", TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt09 { get; set; }
        [Column("Quote Amt 10", TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt10 { get; set; }
        [Column("Quote Amt 11", TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt11 { get; set; }
        [Column("Quote Amt 12", TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt12 { get; set; }
        [Column("Quote Amt 13", TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt13 { get; set; }
        [Column("Quote Amt 14", TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt14 { get; set; }
        [Column("Quote Amt 15", TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt15 { get; set; }
        [Column("Quote Amt 16", TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt16 { get; set; }
        [Column("Quote Amt 17", TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt17 { get; set; }
        [Column("Quote Amt 18", TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt18 { get; set; }
        [Column("Quote Amt 19", TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt19 { get; set; }
        [Column("Quote Amt 20", TypeName = "decimal(13, 2)")]
        public decimal? QuoteAmt20 { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
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
        [Column("By Airline Code")]
        [StringLength(3)]
        public string? ByAirlineCode { get; set; }
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
        [Column("Customer Code")]
        [StringLength(10)]
        public string CustomerCode { get; set; } = null!;
        [Column("Delivery Type")]
        [StringLength(5)]
        public string? DeliveryType { get; set; }
        [Column("Dest Code")]
        [StringLength(3)]
        public string DestCode { get; set; } = null!;
        [Column("First Flight Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FirstFlightDate { get; set; }
        [Column("Flight No")]
        [StringLength(6)]
        public string? FlightNo { get; set; }
        [Column("Last Quote Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastQuoteDate { get; set; }
        [Column("Last Quote No")]
        [StringLength(10)]
        public string? LastQuoteNo { get; set; }
        [Column("Origin Code")]
        [StringLength(3)]
        public string OriginCode { get; set; } = null!;
        [Column("Quote Approve Code")]
        [StringLength(10)]
        public string? QuoteApproveCode { get; set; }
        [Column("Quote Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? QuoteDate { get; set; }
        [Column("Quote No")]
        [StringLength(10)]
        public string? QuoteNo { get; set; }
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
        [StringLength(10)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Revision No")]
        public short? RevisionNo { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [StringLength(1)]
        public string? Type { get; set; }
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
