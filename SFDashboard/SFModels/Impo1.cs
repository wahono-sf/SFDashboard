using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("impo1")]
    public partial class Impo1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(50)]
        public string? Address1 { get; set; }
        [StringLength(50)]
        public string? Address2 { get; set; }
        [StringLength(50)]
        public string? Address3 { get; set; }
        [StringLength(50)]
        public string? Address4 { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryDate { get; set; }
        [StringLength(20)]
        public string? DeliveryTerm { get; set; }
        [StringLength(5)]
        public string? DeliveryType { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
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
        [StringLength(10)]
        public string? ForwarderCode { get; set; }
        [StringLength(80)]
        public string? ForwarderName { get; set; }
        [StringLength(50)]
        public string? ForwarderAddress1 { get; set; }
        [StringLength(50)]
        public string? ForwarderAddress2 { get; set; }
        [StringLength(50)]
        public string? ForwarderAddress3 { get; set; }
        [StringLength(50)]
        public string? ForwarderAddress4 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OrderDate { get; set; }
        [StringLength(5)]
        public string? OrderType { get; set; }
        [StringLength(3)]
        public string? PaymentTerm { get; set; }
        public byte? PrintCount { get; set; }
        [StringLength(20)]
        public string? PurchaseOrderNo { get; set; }
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
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
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [StringLength(80)]
        public string? VendorName { get; set; }
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
