using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwImso1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Contact Name")]
        [StringLength(50)]
        public string? ContactName { get; set; }
        [Column("Contact Email")]
        [StringLength(50)]
        public string? ContactEmail { get; set; }
        [Column("Contact Fax")]
        [StringLength(30)]
        public string? ContactFax { get; set; }
        [Column("Contact Tel")]
        [StringLength(30)]
        public string? ContactTel { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(50)]
        public string? CustomerAddress1 { get; set; }
        [StringLength(50)]
        public string? CustomerAddress2 { get; set; }
        [StringLength(50)]
        public string? CustomerAddress3 { get; set; }
        [StringLength(50)]
        public string? CustomerAddress4 { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Delivery Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DeliveryDate { get; set; }
        [Column("Delivery Term")]
        [StringLength(20)]
        public string? DeliveryTerm { get; set; }
        [Column("Delivery To Address 1")]
        [StringLength(50)]
        public string? DeliveryToAddress1 { get; set; }
        [Column("Delivery To Address 2")]
        [StringLength(50)]
        public string? DeliveryToAddress2 { get; set; }
        [Column("Delivery To Address 3")]
        [StringLength(50)]
        public string? DeliveryToAddress3 { get; set; }
        [Column("Delivery To Address 4")]
        [StringLength(50)]
        public string? DeliveryToAddress4 { get; set; }
        [Column("Delivery To Code")]
        [StringLength(10)]
        public string? DeliveryToCode { get; set; }
        [Column("Delivery To Name")]
        [StringLength(80)]
        public string? DeliveryToName { get; set; }
        [Column("Delivery Type")]
        [StringLength(5)]
        public string? DeliveryType { get; set; }
        [Column("Expiry Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ExpiryDate { get; set; }
        [Column("Footer 1")]
        [StringLength(80)]
        public string? Footer1 { get; set; }
        [Column("Footer 2")]
        [StringLength(80)]
        public string? Footer2 { get; set; }
        [Column("Footer 3")]
        [StringLength(80)]
        public string? Footer3 { get; set; }
        [Column("Footer 4")]
        [StringLength(80)]
        public string? Footer4 { get; set; }
        [Column("Footer 5")]
        [StringLength(80)]
        public string? Footer5 { get; set; }
        [Column("Market Name")]
        [StringLength(80)]
        public string? MarketName { get; set; }
        [Column("Order Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? OrderDate { get; set; }
        [Column("Order Type")]
        [StringLength(1)]
        public string? OrderType { get; set; }
        [Column("Payment Term")]
        [StringLength(3)]
        public string? PaymentTerm { get; set; }
        [Column("Print Count")]
        public byte? PrintCount { get; set; }
        [Column("Prospect Flag")]
        [StringLength(1)]
        public string? ProspectFlag { get; set; }
        [Column("Purchase Order No")]
        [StringLength(20)]
        public string? PurchaseOrderNo { get; set; }
        [Column("Ref No")]
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("Sales Order No")]
        [StringLength(20)]
        public string? SalesOrderNo { get; set; }
        [Column("Template Name")]
        [StringLength(50)]
        public string? TemplateName { get; set; }
        [Column("Term And Condition")]
        [StringLength(3000)]
        public string? TermAndCondition { get; set; }
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
        [Column("Vat Code")]
        [StringLength(10)]
        public string? VatCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column("Warehouse Code")]
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
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
