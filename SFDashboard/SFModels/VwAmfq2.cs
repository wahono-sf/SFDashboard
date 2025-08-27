using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAmfq2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Quote Line Item No")]
        public short QuoteLineItemNo { get; set; }
        [Column("Agent Code")]
        [StringLength(10)]
        public string? AgentCode { get; set; }
        [Column("Agent Name")]
        [StringLength(80)]
        public string? AgentName { get; set; }
        [Column("Airline ID")]
        [StringLength(2)]
        public string? AirlineId { get; set; }
        [Column("Airport Dest Code")]
        [StringLength(5)]
        public string? AirportDestCode { get; set; }
        [Column("Airport Origin Code")]
        [StringLength(5)]
        public string? AirportOriginCode { get; set; }
        [Column("Charge Description")]
        [StringLength(50)]
        public string? ChargeDescription { get; set; }
        [Column("Charge Type")]
        [StringLength(1)]
        public string? ChargeType { get; set; }
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
        [Column("Consignee Code")]
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [Column("Consignee Name")]
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [Column("Consignee Address 1")]
        [StringLength(45)]
        public string? ConsigneeAddress1 { get; set; }
        [Column("Consignee Address 2")]
        [StringLength(45)]
        public string? ConsigneeAddress2 { get; set; }
        [Column("Consignee Address 3")]
        [StringLength(45)]
        public string? ConsigneeAddress3 { get; set; }
        [Column("Consignee Address 4")]
        [StringLength(45)]
        public string? ConsigneeAddress4 { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Delivery Agent Code")]
        [StringLength(10)]
        public string? DeliveryAgentCode { get; set; }
        [Column("Delivery Agent Name")]
        [StringLength(80)]
        public string? DeliveryAgentName { get; set; }
        [Column("Delivery Agent Address1")]
        [StringLength(45)]
        public string? DeliveryAgentAddress1 { get; set; }
        [Column("Delivery Agent Address2")]
        [StringLength(45)]
        public string? DeliveryAgentAddress2 { get; set; }
        [Column("Delivery Agent Address3")]
        [StringLength(45)]
        public string? DeliveryAgentAddress3 { get; set; }
        [Column("Delivery Agent Address4")]
        [StringLength(45)]
        public string? DeliveryAgentAddress4 { get; set; }
        [Column("Delivery Agent Contact")]
        [StringLength(50)]
        public string? DeliveryAgentContact { get; set; }
        [Column("Delivery Agent Fax")]
        [StringLength(50)]
        public string? DeliveryAgentFax { get; set; }
        [Column("Delivery Agent Tel")]
        [StringLength(50)]
        public string? DeliveryAgentTel { get; set; }
        [Column("Est Transit Time")]
        public short? EstTransitTime { get; set; }
        [Column("Est Transit Time Remark")]
        [StringLength(50)]
        public string? EstTransitTimeRemark { get; set; }
        [Column("Flight No")]
        [StringLength(6)]
        public string? FlightNo { get; set; }
        [StringLength(50)]
        public string? Frequency { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [Column("Product Code")]
        [StringLength(10)]
        public string? ProductCode { get; set; }
        [Column("Quote Rate 01", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate01 { get; set; }
        [Column("Quote Rate 02", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate02 { get; set; }
        [Column("Quote Rate 03", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate03 { get; set; }
        [Column("Quote Rate 04", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate04 { get; set; }
        [Column("Quote Rate 05", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate05 { get; set; }
        [Column("Quote Rate 06", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate06 { get; set; }
        [Column("Quote Rate 07", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate07 { get; set; }
        [Column("Quote Rate 08", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate08 { get; set; }
        [Column("Quote Rate 09", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate09 { get; set; }
        [Column("Quote Rate 10", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate10 { get; set; }
        [Column("Quote Rate 11", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate11 { get; set; }
        [Column("Quote Rate 12", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate12 { get; set; }
        [Column("Quote Rate 13", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate13 { get; set; }
        [Column("Quote Rate 14", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate14 { get; set; }
        [Column("Quote Rate 15", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate15 { get; set; }
        [Column("Quote Rate 16", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate16 { get; set; }
        [Column("Quote Rate 17", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate17 { get; set; }
        [Column("Quote Rate 18", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate18 { get; set; }
        [Column("Quote Rate 19", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate19 { get; set; }
        [Column("Quote Rate 20", TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate20 { get; set; }
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
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Sales Item Code")]
        [StringLength(30)]
        public string? SalesItemCode { get; set; }
        [Column("Seq No")]
        public short? SeqNo { get; set; }
        [Column("Shipper Code")]
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [Column("Shipper Name")]
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [Column("Shipper Address 1")]
        [StringLength(45)]
        public string? ShipperAddress1 { get; set; }
        [Column("Shipper Address 2")]
        [StringLength(45)]
        public string? ShipperAddress2 { get; set; }
        [Column("Shipper Address 3")]
        [StringLength(45)]
        public string? ShipperAddress3 { get; set; }
        [Column("Shipper Address 4")]
        [StringLength(45)]
        public string? ShipperAddress4 { get; set; }
        [Column("User Define 01")]
        [StringLength(50)]
        public string? UserDefine01 { get; set; }
        [Column("User Define 02")]
        [StringLength(50)]
        public string? UserDefine02 { get; set; }
        [Column("User Define 03")]
        [StringLength(50)]
        public string? UserDefine03 { get; set; }
        [Column("User Define 04")]
        [StringLength(50)]
        public string? UserDefine04 { get; set; }
        [Column("User Define 05")]
        [StringLength(50)]
        public string? UserDefine05 { get; set; }
        [Column("User Define 06")]
        [StringLength(50)]
        public string? UserDefine06 { get; set; }
        [Column("User Define 07")]
        [StringLength(50)]
        public string? UserDefine07 { get; set; }
        [Column("User Define 08")]
        [StringLength(50)]
        public string? UserDefine08 { get; set; }
        [Column("User Define 09")]
        [StringLength(50)]
        public string? UserDefine09 { get; set; }
        [Column("User Define 10")]
        [StringLength(50)]
        public string? UserDefine10 { get; set; }
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
        [Column("Weight Break 17", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak17 { get; set; }
        [Column("Weight Break 18", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak18 { get; set; }
        [Column("Weight Break 19", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak19 { get; set; }
        [Column("Weight Break 20", TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak20 { get; set; }
        [Column("Weight Type")]
        [StringLength(1)]
        public string? WeightType { get; set; }
    }
}
