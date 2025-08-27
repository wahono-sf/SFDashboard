using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("amfq2")]
    public partial class Amfq2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short QuoteLineItemNo { get; set; }
        [StringLength(10)]
        public string? AgentCode { get; set; }
        [StringLength(80)]
        public string? AgentName { get; set; }
        [Column("AirlineID")]
        [StringLength(3)]
        public string? AirlineId { get; set; }
        [StringLength(5)]
        public string? AirportDestCode { get; set; }
        [StringLength(5)]
        public string? AirportOriginCode { get; set; }
        [StringLength(50)]
        public string? ChargeDescription { get; set; }
        [StringLength(1)]
        public string? ChargeType { get; set; }
        [StringLength(50)]
        public string? CommodityCode01 { get; set; }
        [StringLength(50)]
        public string? CommodityCode02 { get; set; }
        [StringLength(50)]
        public string? CommodityCode03 { get; set; }
        [StringLength(50)]
        public string? CommodityCode04 { get; set; }
        [StringLength(50)]
        public string? CommodityCode05 { get; set; }
        [StringLength(50)]
        public string? CommodityCode06 { get; set; }
        [StringLength(50)]
        public string? CommodityCode07 { get; set; }
        [StringLength(50)]
        public string? CommodityCode08 { get; set; }
        [StringLength(50)]
        public string? CommodityCode09 { get; set; }
        [StringLength(50)]
        public string? CommodityCode10 { get; set; }
        [StringLength(50)]
        public string? CommodityCode11 { get; set; }
        [StringLength(50)]
        public string? CommodityCode12 { get; set; }
        [StringLength(50)]
        public string? CommodityCode13 { get; set; }
        [StringLength(50)]
        public string? CommodityCode14 { get; set; }
        [StringLength(50)]
        public string? CommodityCode15 { get; set; }
        [StringLength(50)]
        public string? CommodityCode16 { get; set; }
        [StringLength(50)]
        public string? CommodityCode17 { get; set; }
        [StringLength(50)]
        public string? CommodityCode18 { get; set; }
        [StringLength(50)]
        public string? CommodityCode19 { get; set; }
        [StringLength(50)]
        public string? CommodityCode20 { get; set; }
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress1 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress2 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress3 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress4 { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [StringLength(10)]
        public string? DeliveryAgentCode { get; set; }
        [StringLength(80)]
        public string? DeliveryAgentName { get; set; }
        [StringLength(50)]
        public string? DeliveryAgentAddress1 { get; set; }
        [StringLength(50)]
        public string? DeliveryAgentAddress2 { get; set; }
        [StringLength(50)]
        public string? DeliveryAgentAddress3 { get; set; }
        [StringLength(50)]
        public string? DeliveryAgentAddress4 { get; set; }
        [StringLength(50)]
        public string? DeliveryAgentContact { get; set; }
        [StringLength(50)]
        public string? DeliveryAgentFax { get; set; }
        [StringLength(50)]
        public string? DeliveryAgentTel { get; set; }
        public short? EstTransitTime { get; set; }
        [StringLength(50)]
        public string? EstTransitTimeRemark { get; set; }
        [StringLength(6)]
        public string? FlightNo { get; set; }
        [StringLength(50)]
        public string? Frequency { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [StringLength(10)]
        public string? ProductCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate01 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate02 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate03 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate04 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate05 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate06 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate07 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate08 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate09 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate10 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate11 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate12 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate13 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate14 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate15 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate16 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate17 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate18 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate19 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? QuoteRate20 { get; set; }
        [StringLength(1)]
        public string? RateClassCode01 { get; set; }
        [StringLength(1)]
        public string? RateClassCode02 { get; set; }
        [StringLength(1)]
        public string? RateClassCode03 { get; set; }
        [StringLength(1)]
        public string? RateClassCode04 { get; set; }
        [StringLength(1)]
        public string? RateClassCode05 { get; set; }
        [StringLength(1)]
        public string? RateClassCode06 { get; set; }
        [StringLength(1)]
        public string? RateClassCode07 { get; set; }
        [StringLength(1)]
        public string? RateClassCode08 { get; set; }
        [StringLength(1)]
        public string? RateClassCode09 { get; set; }
        [StringLength(1)]
        public string? RateClassCode10 { get; set; }
        [StringLength(1)]
        public string? RateClassCode11 { get; set; }
        [StringLength(1)]
        public string? RateClassCode12 { get; set; }
        [StringLength(1)]
        public string? RateClassCode13 { get; set; }
        [StringLength(1)]
        public string? RateClassCode14 { get; set; }
        [StringLength(1)]
        public string? RateClassCode15 { get; set; }
        [StringLength(1)]
        public string? RateClassCode16 { get; set; }
        [StringLength(1)]
        public string? RateClassCode17 { get; set; }
        [StringLength(1)]
        public string? RateClassCode18 { get; set; }
        [StringLength(1)]
        public string? RateClassCode19 { get; set; }
        [StringLength(1)]
        public string? RateClassCode20 { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(30)]
        public string? SalesItemCode { get; set; }
        public short? SeqNo { get; set; }
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [StringLength(50)]
        public string? ShipperAddress1 { get; set; }
        [StringLength(50)]
        public string? ShipperAddress2 { get; set; }
        [StringLength(50)]
        public string? ShipperAddress3 { get; set; }
        [StringLength(50)]
        public string? ShipperAddress4 { get; set; }
        [StringLength(50)]
        public string? UserDefine01 { get; set; }
        [StringLength(50)]
        public string? UserDefine02 { get; set; }
        [StringLength(50)]
        public string? UserDefine03 { get; set; }
        [StringLength(50)]
        public string? UserDefine04 { get; set; }
        [StringLength(50)]
        public string? UserDefine05 { get; set; }
        [StringLength(50)]
        public string? UserDefine06 { get; set; }
        [StringLength(50)]
        public string? UserDefine07 { get; set; }
        [StringLength(50)]
        public string? UserDefine08 { get; set; }
        [StringLength(50)]
        public string? UserDefine09 { get; set; }
        [StringLength(50)]
        public string? UserDefine10 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak01 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak02 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak03 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak04 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak05 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak06 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak07 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak08 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak09 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak10 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak11 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak12 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak13 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak14 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak15 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak16 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak17 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak18 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak19 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? WeightBreak20 { get; set; }
        [StringLength(1)]
        public string? WeightType { get; set; }
    }
}
