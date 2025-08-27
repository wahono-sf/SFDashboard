using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("omoh1")]
    public partial class Omoh1
    {
        [StringLength(2)]
        public string? ChgCode { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? ChgWt { get; set; }
        [StringLength(4)]
        public string? ChgWtUnit { get; set; }
        [StringLength(50)]
        public string? ClientCode { get; set; }
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddr { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddr2 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddr3 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddr4 { get; set; }
        [StringLength(10)]
        public string? ContrClientCode { get; set; }
        [StringLength(4)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatetimeAdded { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatetimeCargoPickup { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatetimeCargoReady { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatetimeChanged { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatetimeGst { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatetimeInv { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatetimeOnhand { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatetimeSend { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatetimeSupplierNotification { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? DefcChgWt { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? DefcGrossWt { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? DefcVolWt { get; set; }
        [StringLength(50)]
        public string? DeliveryNo { get; set; }
        [StringLength(4)]
        public string? DeliveryTerm { get; set; }
        [StringLength(36)]
        public string? DeliveryTermDesc { get; set; }
        [StringLength(36)]
        public string? Description { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal? ExchgGst { get; set; }
        [Column(TypeName = "decimal(11, 6)")]
        public decimal? ExchgRate { get; set; }
        [StringLength(4)]
        public string? FrtCurrCode { get; set; }
        [Column(TypeName = "decimal(11, 6)")]
        public decimal? FrtExchgRate { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? GrossWt { get; set; }
        [StringLength(4)]
        public string? GrossWtUnit { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal? GstAmt { get; set; }
        [StringLength(2)]
        public string? GstCode { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal? InsAmt { get; set; }
        [StringLength(4)]
        public string? InsCurr { get; set; }
        [StringLength(50)]
        public string? InvNo { get; set; }
        [StringLength(8)]
        public string? IssuerChanged { get; set; }
        [StringLength(8)]
        public string? IssuerCode { get; set; }
        [StringLength(50)]
        public string? JobNo { get; set; }
        [StringLength(50)]
        public string? MawbObl { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? NoOfPcs { get; set; }
        [StringLength(30)]
        public string? OblJobNo { get; set; }
        [StringLength(50)]
        public string? OnhandNo { get; set; }
        [StringLength(50)]
        public string? PoNo { get; set; }
        [StringLength(2)]
        public string? RecStatus { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(2)]
        public string? RmkInd { get; set; }
        [StringLength(2)]
        public string? ServiceInd { get; set; }
        [StringLength(50)]
        public string? ShipmentFlag { get; set; }
        [StringLength(16)]
        public string? ShipmentId { get; set; }
        [StringLength(50)]
        public string? ShipperCode { get; set; }
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [StringLength(50)]
        public string? ShipperAddr { get; set; }
        [StringLength(50)]
        public string? ShipperAddr2 { get; set; }
        [StringLength(50)]
        public string? ShipperAddr3 { get; set; }
        [StringLength(50)]
        public string? ShipperAddr4 { get; set; }
        [StringLength(50)]
        public string? SubMawbNbl { get; set; }
        [StringLength(4)]
        public string? SupplierCurr { get; set; }
        [StringLength(16)]
        public string? SupplierInv { get; set; }
        [StringLength(36)]
        public string? SupplierName { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal? SupplierVal { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? TrkChgAmt { get; set; }
        [StringLength(4)]
        public string? TrkChgType { get; set; }
        [StringLength(10)]
        public string? TrkCode { get; set; }
        [StringLength(4)]
        public string? TrkCurrCode { get; set; }
        [StringLength(80)]
        public string? TrkName { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal? VolWt { get; set; }
        [StringLength(4)]
        public string? VolWtUnit { get; set; }
        [StringLength(16)]
        public string? VoteCharge { get; set; }
        [StringLength(12)]
        public string? ZipCode { get; set; }
        [StringLength(4)]
        public string? Zone { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
    }
}
