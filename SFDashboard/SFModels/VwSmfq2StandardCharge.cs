using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSmfq2StandardCharge
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Quote Line Item No")]
        public int QuoteLineItemNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Carrier Name")]
        [StringLength(80)]
        public string? CarrierName { get; set; }
        [Column("Commodity Code")]
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [Column("Commodity Description")]
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
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
        [Column("Customer Contact Name")]
        [StringLength(50)]
        public string? CustomerContactName { get; set; }
        [Column("Customer Fax")]
        [StringLength(30)]
        public string? CustomerFax { get; set; }
        [Column("Customer Telephone")]
        [StringLength(30)]
        public string? CustomerTelephone { get; set; }
        [Column("Delivery Type")]
        [StringLength(5)]
        public string? DeliveryType { get; set; }
        [Column("Effective Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EffectiveDate { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [Column("Consignee Code")]
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [Column("Consignee Name")]
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [Column("Consignee Address 1")]
        [StringLength(50)]
        public string? ConsigneeAddress1 { get; set; }
        [Column("Consignee Address 2")]
        [StringLength(50)]
        public string? ConsigneeAddress2 { get; set; }
        [Column("Consignee Address 3")]
        [StringLength(50)]
        public string? ConsigneeAddress3 { get; set; }
        [Column("Consignee Address 4")]
        [StringLength(50)]
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
        [StringLength(50)]
        public string? DeliveryAgentAddress1 { get; set; }
        [Column("Delivery Agent Address2")]
        [StringLength(50)]
        public string? DeliveryAgentAddress2 { get; set; }
        [Column("Delivery Agent Address3")]
        [StringLength(50)]
        public string? DeliveryAgentAddress3 { get; set; }
        [Column("Delivery Agent Address4")]
        [StringLength(50)]
        public string? DeliveryAgentAddress4 { get; set; }
        [Column("Demurrage Free Day")]
        public int? DemurrageFreeDay { get; set; }
        [Column("Dest Code")]
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column("Dest Name")]
        [StringLength(45)]
        public string? DestName { get; set; }
        [Column("Detention Free Day")]
        public int? DetentionFreeDay { get; set; }
        [Column("Est Transit Time")]
        public short? EstTransitTime { get; set; }
        [Column("Est Transit Time Remark")]
        [StringLength(50)]
        public string? EstTransitTimeRemark { get; set; }
        [StringLength(50)]
        public string? Frequency { get; set; }
        [Column("Frt Collect Flag")]
        [StringLength(1)]
        public string? FrtCollectFlag { get; set; }
        [Column("Lock Flag")]
        [StringLength(1)]
        public string? LockFlag { get; set; }
        [StringLength(1000)]
        public string? Note { get; set; }
        [Column("Note Code")]
        [StringLength(5)]
        public string? NoteCode { get; set; }
        [Column("Port Of Discharge Code")]
        [StringLength(5)]
        public string? PortOfDischargeCode { get; set; }
        [Column("Port Of Discharge Name")]
        [StringLength(45)]
        public string? PortOfDischargeName { get; set; }
        [Column("Port Of Loading Code")]
        [StringLength(5)]
        public string? PortOfLoadingCode { get; set; }
        [Column("Port Of Loading Name")]
        [StringLength(45)]
        public string? PortOfLoadingName { get; set; }
        [Column("Product Code")]
        [StringLength(10)]
        public string? ProductCode { get; set; }
        [Column("Quote Approve Code")]
        [StringLength(10)]
        public string? QuoteApproveCode { get; set; }
        [Column("Quote Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? QuoteDate { get; set; }
        [Column("Quote No")]
        [StringLength(15)]
        public string? QuoteNo { get; set; }
        [Column("Quote Title")]
        [StringLength(100)]
        public string? QuoteTitle { get; set; }
        [Column("Quote Type")]
        [StringLength(5)]
        public string? QuoteType { get; set; }
        [Column("Ref No")]
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Revision Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? RevisionDate { get; set; }
        [Column("Revision No")]
        public short? RevisionNo { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("Shipper Code")]
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [Column("Shipper Name")]
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [Column("Shipper Address 1")]
        [StringLength(50)]
        public string? ShipperAddress1 { get; set; }
        [Column("Shipper Address 2")]
        [StringLength(50)]
        public string? ShipperAddress2 { get; set; }
        [Column("Shipper Address 3")]
        [StringLength(50)]
        public string? ShipperAddress3 { get; set; }
        [Column("Shipper Address 4")]
        [StringLength(50)]
        public string? ShipperAddress4 { get; set; }
        [Column("Shippingline Code")]
        [StringLength(12)]
        public string? ShippinglineCode { get; set; }
        [Column("Total Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? TotalGrossWeight { get; set; }
        [Column("Total Pcs")]
        public int? TotalPcs { get; set; }
        [Column("Total Volume", TypeName = "decimal(13, 4)")]
        public decimal? TotalVolume { get; set; }
        [Column("Uom Code")]
        [StringLength(50)]
        public string? UomCode { get; set; }
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
        [Column("Via Port Code")]
        [StringLength(10)]
        public string? ViaPortCode { get; set; }
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
