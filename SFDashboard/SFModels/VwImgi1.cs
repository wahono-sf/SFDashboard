using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwImgi1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Bill Qty", TypeName = "decimal(18, 4)")]
        public decimal? BillQty { get; set; }
        [Column("Collect From Code")]
        [StringLength(10)]
        public string? CollectFromCode { get; set; }
        [Column("Collect From Name")]
        [StringLength(80)]
        public string? CollectFromName { get; set; }
        [Column("Collect From Address 1")]
        [StringLength(50)]
        public string? CollectFromAddress1 { get; set; }
        [Column("Collect From Address 2")]
        [StringLength(50)]
        public string? CollectFromAddress2 { get; set; }
        [Column("Collect From Address 3")]
        [StringLength(50)]
        public string? CollectFromAddress3 { get; set; }
        [Column("Collect From Address 4")]
        [StringLength(50)]
        public string? CollectFromAddress4 { get; set; }
        [Column("Collect From Contact Name")]
        [StringLength(50)]
        public string? CollectFromContactName { get; set; }
        [Column("Complete By")]
        [StringLength(50)]
        public string? CompleteBy { get; set; }
        [Column("Complete Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CompleteDate { get; set; }
        [Column("Contact Name")]
        [StringLength(50)]
        public string? ContactName { get; set; }
        [Column("Container No")]
        [StringLength(255)]
        public string? ContainerNo { get; set; }
        [Column("Custmer Gin No")]
        [StringLength(20)]
        public string? CustmerGinNo { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Billable Flag")]
        [StringLength(1)]
        public string? BillableFlag { get; set; }
        [Column("Billing Instruction 1")]
        [StringLength(60)]
        public string? BillingInstruction1 { get; set; }
        [Column("Billing Instruction 2")]
        [StringLength(60)]
        public string? BillingInstruction2 { get; set; }
        [Column("Delivery To Code")]
        [StringLength(10)]
        public string? DeliveryToCode { get; set; }
        [Column("Delivery To Name")]
        [StringLength(80)]
        public string? DeliveryToName { get; set; }
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
        [Column("Delivery To Contact Name")]
        [StringLength(50)]
        public string? DeliveryToContactName { get; set; }
        [Column("Delivery Order No")]
        [StringLength(2000)]
        public string? DeliveryOrderNo { get; set; }
        [Column("Description 1")]
        [StringLength(50)]
        public string? Description1 { get; set; }
        [Column("Description 2")]
        [StringLength(50)]
        public string? Description2 { get; set; }
        [Column("Dest Code")]
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column("Dest Name")]
        [StringLength(45)]
        public string? DestName { get; set; }
        [Column("Driver Code 1")]
        [StringLength(15)]
        public string? DriverCode1 { get; set; }
        [Column("Driver Code 2")]
        [StringLength(15)]
        public string? DriverCode2 { get; set; }
        [Column("Driver Name 1")]
        [StringLength(80)]
        public string? DriverName1 { get; set; }
        [Column("Driver Name 2")]
        [StringLength(80)]
        public string? DriverName2 { get; set; }
        [Column("EDI Count")]
        public int? EdiCount { get; set; }
        [Column("Event Template Name")]
        [StringLength(50)]
        public string? EventTemplateName { get; set; }
        [Column("Goods Issue Note No")]
        [StringLength(20)]
        public string GoodsIssueNoteNo { get; set; } = null!;
        [Column("HAwb HBl No")]
        [StringLength(50)]
        public string? HawbHblNo { get; set; }
        [Column("Invoice No")]
        [StringLength(2000)]
        public string? InvoiceNo { get; set; }
        [Column("Issue By")]
        [StringLength(50)]
        public string? IssueBy { get; set; }
        [Column("Issue Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? IssueDate { get; set; }
        [Column("Issue To")]
        [StringLength(50)]
        public string? IssueTo { get; set; }
        [Column("Issue Type")]
        [StringLength(10)]
        public string? IssueType { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("Last Bill Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastBillDate { get; set; }
        [Column("MAwb OBl No")]
        [StringLength(50)]
        public string? MawbOblNo { get; set; }
        [Column("Packing Trx No")]
        public int? PackingTrxNo { get; set; }
        [Column("Pick Date Time")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PickDateTime { get; set; }
        [Column("Post Flag")]
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [Column("Print Count")]
        public byte? PrintCount { get; set; }
        [Column("Purchase Order No")]
        [StringLength(20)]
        public string? PurchaseOrderNo { get; set; }
        [Column("Ref No")]
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(2000)]
        public string? Remark { get; set; }
        [Column("Order Type")]
        public int? OrderType { get; set; }
        [Column("Sales Order No")]
        [StringLength(20)]
        public string? SalesOrderNo { get; set; }
        [Column("Scrap Flag")]
        [StringLength(1)]
        public string? ScrapFlag { get; set; }
        [Column("Seal No")]
        [StringLength(255)]
        public string? SealNo { get; set; }
        [Column("Serial No")]
        [StringLength(2000)]
        public string? SerialNo { get; set; }
        [Column("Shipping Weight", TypeName = "decimal(13, 4)")]
        public decimal? ShippingWeight { get; set; }
        [Column("Source Job No")]
        [StringLength(30)]
        public string? SourceJobNo { get; set; }
        [Column("Table No")]
        [StringLength(10)]
        public string? TableNo { get; set; }
        [Column("Total Issue Dimension")]
        [StringLength(2000)]
        public string? TotalIssueDimension { get; set; }
        [Column("Total Issue Qty")]
        public int? TotalIssueQty { get; set; }
        [Column("Total Issue Qty 1")]
        public int? TotalIssueQty1 { get; set; }
        [Column("Total Issue Space", TypeName = "decimal(13, 4)")]
        public decimal? TotalIssueSpace { get; set; }
        [Column("Total Issue Volume", TypeName = "decimal(13, 4)")]
        public decimal? TotalIssueVolume { get; set; }
        [Column("Total Issue Weight", TypeName = "decimal(13, 4)")]
        public decimal? TotalIssueWeight { get; set; }
        [Column("Total Item")]
        public int? TotalItem { get; set; }
        [Column("Transport Company Code")]
        [StringLength(10)]
        public string? TransportCompanyCode { get; set; }
        [Column("Transport Company Name")]
        [StringLength(80)]
        public string? TransportCompanyName { get; set; }
        [Column("Transport Company Address 1")]
        [StringLength(50)]
        public string? TransportCompanyAddress1 { get; set; }
        [Column("Transport Company Address 2")]
        [StringLength(50)]
        public string? TransportCompanyAddress2 { get; set; }
        [Column("Transport Company Address 3")]
        [StringLength(50)]
        public string? TransportCompanyAddress3 { get; set; }
        [Column("Transport Company Address 4")]
        [StringLength(50)]
        public string? TransportCompanyAddress4 { get; set; }
        [Column("Transport Job No")]
        [StringLength(30)]
        public string? TransportJobNo { get; set; }
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
        [Column("User Define 11")]
        [StringLength(50)]
        public string? UserDefine11 { get; set; }
        [Column("User Define 12")]
        [StringLength(50)]
        public string? UserDefine12 { get; set; }
        [Column("User Define 13")]
        [StringLength(50)]
        public string? UserDefine13 { get; set; }
        [Column("User Define 14")]
        [StringLength(50)]
        public string? UserDefine14 { get; set; }
        [Column("User Define 15")]
        [StringLength(50)]
        public string? UserDefine15 { get; set; }
        [Column("User Define 16")]
        [StringLength(50)]
        public string? UserDefine16 { get; set; }
        [Column("User Define 17")]
        [StringLength(50)]
        public string? UserDefine17 { get; set; }
        [Column("User Define 18")]
        [StringLength(50)]
        public string? UserDefine18 { get; set; }
        [Column("User Define 19")]
        [StringLength(50)]
        public string? UserDefine19 { get; set; }
        [Column("User Define 20")]
        [StringLength(50)]
        public string? UserDefine20 { get; set; }
        [Column("Vehicle No 1")]
        [StringLength(12)]
        public string? VehicleNo1 { get; set; }
        [Column("Vehicle No 2")]
        [StringLength(12)]
        public string? VehicleNo2 { get; set; }
        [Column("Vessel Name")]
        [StringLength(80)]
        public string? VesselName { get; set; }
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
