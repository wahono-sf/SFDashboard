using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("amfq1")]
    [Index("QuoteNo", Name = "UQ__amfq1__QuoteNo", IsUnique = true)]
    public partial class Amfq1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(15)]
        public string? QuoteNo { get; set; }
        [StringLength(50)]
        public string? ApproveBy { get; set; }
        [StringLength(50)]
        public string? CheckBy { get; set; }
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [StringLength(50)]
        public string? CopyTemplateName { get; set; }
        [StringLength(255)]
        public string? CopyTemplateRemark { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [StringLength(50)]
        public string? CustomerAddress1 { get; set; }
        [StringLength(50)]
        public string? CustomerAddress2 { get; set; }
        [StringLength(50)]
        public string? CustomerAddress3 { get; set; }
        [StringLength(50)]
        public string? CustomerAddress4 { get; set; }
        [StringLength(50)]
        public string? CustomerContactName { get; set; }
        [StringLength(30)]
        public string? CustomerFax { get; set; }
        [StringLength(30)]
        public string? CustomerTelephone { get; set; }
        [StringLength(5)]
        public string? DeliveryType { get; set; }
        [StringLength(3)]
        public string? DestCode { get; set; }
        [StringLength(45)]
        public string? DestName { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? DocChargeWeight { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EffectiveDate { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(50)]
        public string? EventTemplateName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }
        [StringLength(80)]
        public string? Footer1 { get; set; }
        [StringLength(80)]
        public string? Footer2 { get; set; }
        [StringLength(80)]
        public string? Footer3 { get; set; }
        [StringLength(80)]
        public string? Footer4 { get; set; }
        [StringLength(80)]
        public string? Footer5 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [StringLength(80)]
        public string? Header1 { get; set; }
        [StringLength(80)]
        public string? Header2 { get; set; }
        [StringLength(80)]
        public string? Header3 { get; set; }
        [StringLength(80)]
        public string? Header4 { get; set; }
        [StringLength(80)]
        public string? Header5 { get; set; }
        [StringLength(255)]
        public string? JobCostingRemark { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastQuoteDate { get; set; }
        [StringLength(15)]
        public string? LastQuoteNo { get; set; }
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [StringLength(45)]
        public string? OriginName { get; set; }
        public int? Pcs { get; set; }
        [StringLength(10)]
        public string? QuoteApproveCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? QuoteDate { get; set; }
        [StringLength(100)]
        public string? QuoteTitle { get; set; }
        [StringLength(5)]
        public string? QuoteType { get; set; }
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(50)]
        public string? RequestBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RevisionDate { get; set; }
        public short? RevisionNo { get; set; }
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [StringLength(1)]
        public string? ShipmentType { get; set; }
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [StringLength(2000)]
        public string? SpecialInstruction { get; set; }
        [StringLength(50)]
        public string? TemplateName { get; set; }
        [StringLength(3000)]
        public string? TermAndCondition { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
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
        [Column(TypeName = "datetime")]
        public DateTime? ValidateDate { get; set; }
        public int? ValidityDay { get; set; }
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(1)]
        public string? AttachMentFlag { get; set; }
    }
}
