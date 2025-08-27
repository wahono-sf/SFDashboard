using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("imso1")]
    public partial class Imso1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(50)]
        public string? ContactName { get; set; }
        [StringLength(50)]
        public string? ContactEmail { get; set; }
        [StringLength(30)]
        public string? ContactFax { get; set; }
        [StringLength(30)]
        public string? ContactTel { get; set; }
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
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryDate { get; set; }
        [StringLength(20)]
        public string? DeliveryTerm { get; set; }
        [StringLength(10)]
        public string? DeliveryToCode { get; set; }
        [StringLength(80)]
        public string? DeliveryToName { get; set; }
        [StringLength(50)]
        public string? DeliveryToAddress1 { get; set; }
        [StringLength(50)]
        public string? DeliveryToAddress2 { get; set; }
        [StringLength(50)]
        public string? DeliveryToAddress3 { get; set; }
        [StringLength(50)]
        public string? DeliveryToAddress4 { get; set; }
        [StringLength(5)]
        public string? DeliveryType { get; set; }
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
        [StringLength(80)]
        public string? MarketName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OrderDate { get; set; }
        [StringLength(1)]
        public string? OrderType { get; set; }
        [StringLength(3)]
        public string? PaymentTerm { get; set; }
        public byte? PrintCount { get; set; }
        [StringLength(1)]
        public string? ProspectFlag { get; set; }
        [StringLength(20)]
        public string? PurchaseOrderNo { get; set; }
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [StringLength(20)]
        public string? SalesOrderNo { get; set; }
        [StringLength(50)]
        public string? TemplateName { get; set; }
        [StringLength(3000)]
        public string? TermAndCondition { get; set; }
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
        [StringLength(10)]
        public string? VatCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
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
        public string? AttachmentFlag { get; set; }
    }
}
