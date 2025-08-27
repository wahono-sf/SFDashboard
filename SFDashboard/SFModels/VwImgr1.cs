using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwImgr1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Bill Qty", TypeName = "decimal(18, 4)")]
        public decimal? BillQty { get; set; }
        [Column("Billable Flag")]
        [StringLength(1)]
        public string? BillableFlag { get; set; }
        [Column("Billing Instruction 1")]
        [StringLength(60)]
        public string? BillingInstruction1 { get; set; }
        [Column("Billing Instruction 2")]
        [StringLength(60)]
        public string? BillingInstruction2 { get; set; }
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
        [Column("Container No")]
        [StringLength(255)]
        public string? ContainerNo { get; set; }
        [Column("Container No 1")]
        [StringLength(13)]
        public string? ContainerNo1 { get; set; }
        [Column("Container No 2")]
        [StringLength(13)]
        public string? ContainerNo2 { get; set; }
        [Column("Container No 3")]
        [StringLength(13)]
        public string? ContainerNo3 { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Customer Grn No")]
        [StringLength(20)]
        public string? CustomerGrnNo { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Customer Address 1")]
        [StringLength(50)]
        public string? CustomerAddress1 { get; set; }
        [Column("Customer Address 2")]
        [StringLength(50)]
        public string? CustomerAddress2 { get; set; }
        [Column("Customer Address 3")]
        [StringLength(50)]
        public string? CustomerAddress3 { get; set; }
        [Column("Customer Address 4")]
        [StringLength(50)]
        public string? CustomerAddress4 { get; set; }
        [Column("Delivery Order No")]
        [StringLength(50)]
        public string? DeliveryOrderNo { get; set; }
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
        [Column("Description 1")]
        [StringLength(50)]
        public string? Description1 { get; set; }
        [Column("Description 2")]
        [StringLength(50)]
        public string? Description2 { get; set; }
        [Column("Edi Count")]
        public int? EdiCount { get; set; }
        [Column("Event Template Name")]
        [StringLength(50)]
        public string? EventTemplateName { get; set; }
        [Column("Execute Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ExecuteDate { get; set; }
        [Column("Freight Amt", TypeName = "decimal(13, 2)")]
        public decimal? FreightAmt { get; set; }
        [Column("Freight Curr Code")]
        [StringLength(3)]
        public string? FreightCurrCode { get; set; }
        [Column("Freight Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? FreightCurrRate { get; set; }
        [Column("Freight Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? FreightLocalAmt { get; set; }
        [Column("Goods Receipt Note No")]
        [StringLength(20)]
        public string GoodsReceiptNoteNo { get; set; } = null!;
        [Column("Hawb Hbl No")]
        [StringLength(50)]
        public string? HawbHblNo { get; set; }
        [Column("Insurance Amt", TypeName = "decimal(13, 2)")]
        public decimal? InsuranceAmt { get; set; }
        [Column("Insurance Curr Code")]
        [StringLength(3)]
        public string? InsuranceCurrCode { get; set; }
        [Column("Insurance Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? InsuranceCurrRate { get; set; }
        [Column("Insurance Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? InsuranceLocalAmt { get; set; }
        [Column("Invoice Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceLocalAmt { get; set; }
        [Column("Invoice No")]
        [StringLength(50)]
        public string? InvoiceNo { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("Job Type")]
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column("Last Bill Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastBillDate { get; set; }
        [Column("Mawb Obl No")]
        [StringLength(50)]
        public string? MawbOblNo { get; set; }
        [Column("Order Type")]
        public int? OrderType { get; set; }
        [Column("Origin Code")]
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [Column("Origin Name")]
        [StringLength(45)]
        public string? OriginName { get; set; }
        [Column("Oth Chg Amt", TypeName = "decimal(13, 2)")]
        public decimal? OthChgAmt { get; set; }
        [Column("Oth Chg Curr Code")]
        [StringLength(3)]
        public string? OthChgCurrCode { get; set; }
        [Column("Oth Chg Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? OthChgCurrRate { get; set; }
        [Column("Oth Chg Local Amt", TypeName = "decimal(13, 2)")]
        public decimal? OthChgLocalAmt { get; set; }
        [Column("Post Flag")]
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [Column("Purchase Order No")]
        [StringLength(20)]
        public string? PurchaseOrderNo { get; set; }
        [Column("Put Away Date Time")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PutAwayDateTime { get; set; }
        [Column("Receipt Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ReceiptDate { get; set; }
        [Column("Receive By")]
        [StringLength(50)]
        public string? ReceiveBy { get; set; }
        [Column("Receive From")]
        [StringLength(50)]
        public string? ReceiveFrom { get; set; }
        [Column("Ref No")]
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Seal No")]
        [StringLength(255)]
        public string? SealNo { get; set; }
        [Column("Source Job No")]
        [StringLength(30)]
        public string? SourceJobNo { get; set; }
        [Column("Table No")]
        [StringLength(10)]
        public string? TableNo { get; set; }
        [Column("Tally By")]
        [StringLength(50)]
        public string? TallyBy { get; set; }
        [Column("Tally Date Time", TypeName = "datetime")]
        public DateTime? TallyDateTime { get; set; }
        [Column("Temponary No")]
        [StringLength(30)]
        public string? TemponaryNo { get; set; }
        [Column("Total CIF Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalCifAmt { get; set; }
        [Column("Total CIF Vat Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalCifVatAmt { get; set; }
        [Column("Total Item")]
        public int? TotalItem { get; set; }
        [Column("Total Receipt Qty")]
        public int? TotalReceiptQty { get; set; }
        [Column("Total Receipt Qty 1")]
        public int? TotalReceiptQty1 { get; set; }
        [Column("Total Receipt Space", TypeName = "decimal(13, 4)")]
        public decimal? TotalReceiptSpace { get; set; }
        [Column("Total Receipt Volume", TypeName = "decimal(13, 4)")]
        public decimal? TotalReceiptVolume { get; set; }
        [Column("Total Receipt Weight", TypeName = "decimal(13, 4)")]
        public decimal? TotalReceiptWeight { get; set; }
        [Column("Total Vat Code")]
        [StringLength(10)]
        public string? TotalVatCode { get; set; }
        [Column("Total Vat Rate", TypeName = "decimal(6, 3)")]
        public decimal? TotalVatRate { get; set; }
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
        [Column("Transport Company Contact Name")]
        [StringLength(50)]
        public string? TransportCompanyContactName { get; set; }
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
        [Column("Vessel Name")]
        [StringLength(80)]
        public string? VesselName { get; set; }
        [Column("Warehouse Code")]
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [Column("Warehouse Name")]
        [StringLength(80)]
        public string? WarehouseName { get; set; }
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
