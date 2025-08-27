using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwCsbk1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Agent Code")]
        [StringLength(10)]
        public string? AgentCode { get; set; }
        [Column("Agent Name")]
        [StringLength(80)]
        public string? AgentName { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Booking No")]
        [StringLength(10)]
        public string BookingNo { get; set; } = null!;
        [Column("Booking Customer Code")]
        [StringLength(10)]
        public string? BookingCustomerCode { get; set; }
        [Column("Booking Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? BookingDateTime { get; set; }
        [Column("Charge Rate", TypeName = "decimal(13, 2)")]
        public decimal? ChargeRate { get; set; }
        [Column("Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [Column("Close Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CloseDateTime { get; set; }
        [Column("Collect Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CollectDateTime { get; set; }
        [Column("Collect From Code")]
        [StringLength(10)]
        public string? CollectFromCode { get; set; }
        [Column("Collect From Name")]
        [StringLength(80)]
        public string? CollectFromName { get; set; }
        [Column("Collect From Address 1")]
        [StringLength(45)]
        public string? CollectFromAddress1 { get; set; }
        [Column("Collect From Address 2")]
        [StringLength(45)]
        public string? CollectFromAddress2 { get; set; }
        [Column("Collect From Address 3")]
        [StringLength(45)]
        public string? CollectFromAddress3 { get; set; }
        [Column("Collect From Address 4")]
        [StringLength(45)]
        public string? CollectFromAddress4 { get; set; }
        [Column("Collect From Contact Name")]
        [StringLength(50)]
        public string? CollectFromContactName { get; set; }
        [Column("Collect From Telephone")]
        [StringLength(30)]
        public string? CollectFromTelephone { get; set; }
        [Column("Commodity Code")]
        [StringLength(10)]
        public string? CommodityCode { get; set; }
        [Column("Consignee Code")]
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [Column("Contact Name")]
        [StringLength(50)]
        public string? ContactName { get; set; }
        [Column("Contact Email")]
        [StringLength(50)]
        public string? ContactEmail { get; set; }
        [Column("Contact Fax")]
        [StringLength(30)]
        public string? ContactFax { get; set; }
        [Column("Contact Telephone")]
        [StringLength(30)]
        public string? ContactTelephone { get; set; }
        [Column("Country Code")]
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Customer Address 1")]
        [StringLength(45)]
        public string? CustomerAddress1 { get; set; }
        [Column("Customer Address 2")]
        [StringLength(45)]
        public string? CustomerAddress2 { get; set; }
        [Column("Customer Address 3")]
        [StringLength(45)]
        public string? CustomerAddress3 { get; set; }
        [Column("Customer Address 4")]
        [StringLength(45)]
        public string? CustomerAddress4 { get; set; }
        [Column("Customer Ref No")]
        [StringLength(50)]
        public string? CustomerRefNo { get; set; }
        [Column("Delivery To Code")]
        [StringLength(10)]
        public string? DeliveryToCode { get; set; }
        [Column("Delivery To Name")]
        [StringLength(80)]
        public string? DeliveryToName { get; set; }
        [Column("Delivery To Address 1")]
        [StringLength(45)]
        public string? DeliveryToAddress1 { get; set; }
        [Column("Delivery To Address 2")]
        [StringLength(45)]
        public string? DeliveryToAddress2 { get; set; }
        [Column("Delivery To Address 3")]
        [StringLength(45)]
        public string? DeliveryToAddress3 { get; set; }
        [Column("Delivery To Address 4")]
        [StringLength(45)]
        public string? DeliveryToAddress4 { get; set; }
        [Column("Delivery To Contact Name")]
        [StringLength(50)]
        public string? DeliveryToContactName { get; set; }
        [Column("Delivery To Telephone")]
        [StringLength(30)]
        public string? DeliveryToTelephone { get; set; }
        [Column("Deposit Amt", TypeName = "decimal(13, 2)")]
        public decimal? DepositAmt { get; set; }
        [Column("Discount Amt", TypeName = "decimal(13, 2)")]
        public decimal? DiscountAmt { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column("Internet Booking")]
        [StringLength(1)]
        public string? InternetBooking { get; set; }
        [Column("Item No")]
        public int? ItemNo { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Job Status Code")]
        [StringLength(10)]
        public string? JobStatusCode { get; set; }
        [Column("Job Type")]
        [StringLength(2)]
        public string? JobType { get; set; }
        [Column("Paid Amt", TypeName = "decimal(13, 2)")]
        public decimal? PaidAmt { get; set; }
        [Column("Receipt No")]
        [StringLength(50)]
        public string? ReceiptNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("Special Instruction")]
        [StringLength(3000)]
        public string? SpecialInstruction { get; set; }
        [Column("Surcharge Rate", TypeName = "decimal(13, 2)")]
        public decimal? SurchargeRate { get; set; }
        [Column("Term Code")]
        [StringLength(3)]
        public string? TermCode { get; set; }
        [Column("Total Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalAmt { get; set; }
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
        [Column("Volumetric Weight", TypeName = "decimal(14, 3)")]
        public decimal? VolumetricWeight { get; set; }
        [Column("Voyage ID")]
        [StringLength(10)]
        public string? VoyageId { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string? WorkStation { get; set; }
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
