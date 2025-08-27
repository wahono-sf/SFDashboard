using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwOmoh1
    {
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Chg Code")]
        [StringLength(2)]
        public string? ChgCode { get; set; }
        [Column("Chg Wt", TypeName = "decimal(12, 4)")]
        public decimal? ChgWt { get; set; }
        [Column("Chg Wt Unit")]
        [StringLength(4)]
        public string? ChgWtUnit { get; set; }
        [Column("Client Code")]
        [StringLength(50)]
        public string? ClientCode { get; set; }
        [Column("Consignee Code")]
        [StringLength(8)]
        public string? ConsigneeCode { get; set; }
        [Column("consignee Name")]
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [Column("Consignee Addr")]
        [StringLength(36)]
        public string? ConsigneeAddr { get; set; }
        [Column("Consignee Addr2")]
        [StringLength(36)]
        public string? ConsigneeAddr2 { get; set; }
        [Column("Consignee Addr 3")]
        [StringLength(36)]
        public string? ConsigneeAddr3 { get; set; }
        [Column("Consignee Addr 4")]
        [StringLength(36)]
        public string? ConsigneeAddr4 { get; set; }
        [Column("Contr Client Code")]
        [StringLength(8)]
        public string? ContrClientCode { get; set; }
        [Column("Curr Code")]
        [StringLength(4)]
        public string? CurrCode { get; set; }
        [Column("Datetime Added")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DatetimeAdded { get; set; }
        [Column("Datetime Cargo Pickup")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DatetimeCargoPickup { get; set; }
        [Column("Datetime Cargo Ready")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DatetimeCargoReady { get; set; }
        [Column("Datetime Changed")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DatetimeChanged { get; set; }
        [Column("Datetime Gst")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DatetimeGst { get; set; }
        [Column("Datetime Inv")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DatetimeInv { get; set; }
        [Column("Datetime Onhand")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DatetimeOnhand { get; set; }
        [Column("Datetime Send")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DatetimeSend { get; set; }
        [Column("Datetime Supplier Notification")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DatetimeSupplierNotification { get; set; }
        [Column("Defc Chg Wt", TypeName = "decimal(12, 4)")]
        public decimal? DefcChgWt { get; set; }
        [Column("Defc Gross Wt", TypeName = "decimal(12, 4)")]
        public decimal? DefcGrossWt { get; set; }
        [Column("Defc Vol Wt", TypeName = "decimal(12, 4)")]
        public decimal? DefcVolWt { get; set; }
        [Column("Delivery No")]
        [StringLength(50)]
        public string? DeliveryNo { get; set; }
        [Column("Delivery Term")]
        [StringLength(4)]
        public string? DeliveryTerm { get; set; }
        [Column("Delivery Term Desc")]
        [StringLength(36)]
        public string? DeliveryTermDesc { get; set; }
        [StringLength(36)]
        public string? Description { get; set; }
        [Column("Exchg Gst", TypeName = "decimal(12, 2)")]
        public decimal? ExchgGst { get; set; }
        [Column("Exchg Rate", TypeName = "decimal(11, 6)")]
        public decimal? ExchgRate { get; set; }
        [Column("Frt Curr Code")]
        [StringLength(4)]
        public string? FrtCurrCode { get; set; }
        [Column("Frt Exchg Rate", TypeName = "decimal(11, 6)")]
        public decimal? FrtExchgRate { get; set; }
        [Column("Gst Amt", TypeName = "decimal(8, 2)")]
        public decimal? GstAmt { get; set; }
        [Column("Gst Code")]
        [StringLength(2)]
        public string? GstCode { get; set; }
        [Column("Gross Wt", TypeName = "decimal(12, 4)")]
        public decimal? GrossWt { get; set; }
        [Column("Gross Wt Unit")]
        [StringLength(4)]
        public string? GrossWtUnit { get; set; }
        [Column("Ins Amt", TypeName = "decimal(12, 2)")]
        public decimal? InsAmt { get; set; }
        [Column("Ins Curr")]
        [StringLength(4)]
        public string? InsCurr { get; set; }
        [Column("Inv No")]
        [StringLength(50)]
        public string? InvNo { get; set; }
        [Column("Issuer Changed")]
        [StringLength(8)]
        public string? IssuerChanged { get; set; }
        [Column("Issuer Code")]
        [StringLength(8)]
        public string? IssuerCode { get; set; }
        [Column("Job No")]
        [StringLength(50)]
        public string? JobNo { get; set; }
        [Column("MAwb OBl No")]
        [StringLength(50)]
        public string? MawbOblNo { get; set; }
        [Column("No Of Pcs", TypeName = "decimal(10, 2)")]
        public decimal? NoOfPcs { get; set; }
        [Column("Obl Job No")]
        [StringLength(12)]
        public string? OblJobNo { get; set; }
        [Column("ONHAND No")]
        [StringLength(50)]
        public string? OnhandNo { get; set; }
        [Column("PO No")]
        [StringLength(50)]
        public string? PoNo { get; set; }
        [Column("Rec Status")]
        [StringLength(2)]
        public string? RecStatus { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Rmk Ind")]
        [StringLength(2)]
        public string? RmkInd { get; set; }
        [Column("Service Ind")]
        [StringLength(2)]
        public string? ServiceInd { get; set; }
        [Column("Shipment Flag")]
        [StringLength(50)]
        public string? ShipmentFlag { get; set; }
        [Column("Shipment ID")]
        [StringLength(16)]
        public string? ShipmentId { get; set; }
        [Column("Shipper Code")]
        [StringLength(50)]
        public string? ShipperCode { get; set; }
        [Column("Shipper Name")]
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [Column("Shipper Address 1")]
        [StringLength(36)]
        public string? ShipperAddress1 { get; set; }
        [Column("Shipper Address 2")]
        [StringLength(36)]
        public string? ShipperAddress2 { get; set; }
        [Column("Shipper Address 3")]
        [StringLength(36)]
        public string? ShipperAddress3 { get; set; }
        [Column("Shipper Address 4")]
        [StringLength(36)]
        public string? ShipperAddress4 { get; set; }
        [Column("Sub Mawb Nbl")]
        [StringLength(50)]
        public string? SubMawbNbl { get; set; }
        [Column("Supplier Curr")]
        [StringLength(4)]
        public string? SupplierCurr { get; set; }
        [Column("Supplier Inv")]
        [StringLength(16)]
        public string? SupplierInv { get; set; }
        [Column("Supplier Name")]
        [StringLength(36)]
        public string? SupplierName { get; set; }
        [Column("Supplier Val", TypeName = "decimal(12, 2)")]
        public decimal? SupplierVal { get; set; }
        [Column("Trk Chg Amt", TypeName = "decimal(10, 2)")]
        public decimal? TrkChgAmt { get; set; }
        [Column("Trk Chg Type")]
        [StringLength(4)]
        public string? TrkChgType { get; set; }
        [Column("Trk Code")]
        [StringLength(8)]
        public string? TrkCode { get; set; }
        [Column("Trk Curr Code")]
        [StringLength(4)]
        public string? TrkCurrCode { get; set; }
        [Column("Trk Name")]
        [StringLength(80)]
        public string? TrkName { get; set; }
        [Column("Vol Wt", TypeName = "decimal(12, 4)")]
        public decimal? VolWt { get; set; }
        [Column("Vol Wt Unit")]
        [StringLength(4)]
        public string? VolWtUnit { get; set; }
        [Column("Vote Charge")]
        [StringLength(16)]
        public string? VoteCharge { get; set; }
        [Column("Zip Code")]
        [StringLength(12)]
        public string? ZipCode { get; set; }
        [StringLength(4)]
        public string? Zone { get; set; }
        [StringLength(3)]
        [Unicode(false)]
        public string Status { get; set; } = null!;
    }
}
