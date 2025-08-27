using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSibl6
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Final Consignee Code")]
        [StringLength(10)]
        public string? FinalConsigneeCode { get; set; }
        [Column("Final Consignee Name")]
        [StringLength(80)]
        public string? FinalConsigneeName { get; set; }
        [Column("Final Consignee Address 1")]
        [StringLength(45)]
        public string? FinalConsigneeAddress1 { get; set; }
        [Column("Final Consignee Address 2")]
        [StringLength(45)]
        public string? FinalConsigneeAddress2 { get; set; }
        [Column("Final Consignee Address 3")]
        [StringLength(45)]
        public string? FinalConsigneeAddress3 { get; set; }
        [Column("Final Consignee Address 4")]
        [StringLength(45)]
        public string? FinalConsigneeAddress4 { get; set; }
        [Column("Final Notify Code")]
        [StringLength(10)]
        public string? FinalNotifyCode { get; set; }
        [Column("Final Notify Name")]
        [StringLength(80)]
        public string? FinalNotifyName { get; set; }
        [Column("Final Notify Address 1")]
        [StringLength(45)]
        public string? FinalNotifyAddress1 { get; set; }
        [Column("Final Notify Address 2")]
        [StringLength(45)]
        public string? FinalNotifyAddress2 { get; set; }
        [Column("Final Notify Address 3")]
        [StringLength(45)]
        public string? FinalNotifyAddress3 { get; set; }
        [Column("Final Notify Address 4")]
        [StringLength(45)]
        public string? FinalNotifyAddress4 { get; set; }
        [Column("Final Shipper Code")]
        [StringLength(10)]
        public string? FinalShipperCode { get; set; }
        [Column("Final Shipper Name")]
        [StringLength(80)]
        public string? FinalShipperName { get; set; }
        [Column("Final Shipper Address 1")]
        [StringLength(45)]
        public string? FinalShipperAddress1 { get; set; }
        [Column("Final Shipper Address 2")]
        [StringLength(45)]
        public string? FinalShipperAddress2 { get; set; }
        [Column("Final Shipper Address 3")]
        [StringLength(45)]
        public string? FinalShipperAddress3 { get; set; }
        [Column("Final Shipper Address 4")]
        [StringLength(45)]
        public string? FinalShipperAddress4 { get; set; }
        [Column("Switch Also Notify Code")]
        [StringLength(10)]
        public string? SwitchAlsoNotifyCode { get; set; }
        [Column("Switch Also Notify Name")]
        [StringLength(80)]
        public string? SwitchAlsoNotifyName { get; set; }
        [Column("Switch Also Notify Address 1")]
        [StringLength(45)]
        public string? SwitchAlsoNotifyAddress1 { get; set; }
        [Column("Switch Also Notify Address 2")]
        [StringLength(45)]
        public string? SwitchAlsoNotifyAddress2 { get; set; }
        [Column("Switch Also Notify Address 3")]
        [StringLength(45)]
        public string? SwitchAlsoNotifyAddress3 { get; set; }
        [Column("Switch Also Notify Address 4")]
        [StringLength(45)]
        public string? SwitchAlsoNotifyAddress4 { get; set; }
        [Column("Switch Bl Issue Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? SwitchBlIssueDate { get; set; }
        [Column("Switch Bl Issue Place")]
        [StringLength(45)]
        public string? SwitchBlIssuePlace { get; set; }
        [Column("Switch Consignee Code")]
        [StringLength(10)]
        public string? SwitchConsigneeCode { get; set; }
        [Column("Switch Consignee Name")]
        [StringLength(80)]
        public string? SwitchConsigneeName { get; set; }
        [Column("Switch Consignee Address 1")]
        [StringLength(45)]
        public string? SwitchConsigneeAddress1 { get; set; }
        [Column("Switch Consignee Address 2")]
        [StringLength(45)]
        public string? SwitchConsigneeAddress2 { get; set; }
        [Column("Switch Consignee Address 3")]
        [StringLength(45)]
        public string? SwitchConsigneeAddress3 { get; set; }
        [Column("Switch Consignee Address 4")]
        [StringLength(45)]
        public string? SwitchConsigneeAddress4 { get; set; }
        [Column("Switch Delivery Agent Code")]
        [StringLength(10)]
        public string? SwitchDeliveryAgentCode { get; set; }
        [Column("Switch Delivery Agent Name")]
        [StringLength(80)]
        public string? SwitchDeliveryAgentName { get; set; }
        [Column("Switch Delivery Agent Address 1")]
        [StringLength(45)]
        public string? SwitchDeliveryAgentAddress1 { get; set; }
        [Column("Switch Delivery Agent Address 2")]
        [StringLength(45)]
        public string? SwitchDeliveryAgentAddress2 { get; set; }
        [Column("Switch Delivery Agent Address 3")]
        [StringLength(45)]
        public string? SwitchDeliveryAgentAddress3 { get; set; }
        [Column("Switch Delivery Agent Address 4")]
        [StringLength(45)]
        public string? SwitchDeliveryAgentAddress4 { get; set; }
        [Column("Switch Laden Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? SwitchLadenDate { get; set; }
        [Column("Switch No Of Origin Bl")]
        public byte? SwitchNoOfOriginBl { get; set; }
        [Column("Switch Notify Code")]
        [StringLength(10)]
        public string? SwitchNotifyCode { get; set; }
        [Column("Switch Notify Name")]
        [StringLength(80)]
        public string? SwitchNotifyName { get; set; }
        [Column("Switch Notify Address 1")]
        [StringLength(45)]
        public string? SwitchNotifyAddress1 { get; set; }
        [Column("Switch Notify Address 2")]
        [StringLength(45)]
        public string? SwitchNotifyAddress2 { get; set; }
        [Column("Switch Notify Address 3")]
        [StringLength(45)]
        public string? SwitchNotifyAddress3 { get; set; }
        [Column("Switch Notify Address 4")]
        [StringLength(45)]
        public string? SwitchNotifyAddress4 { get; set; }
        [Column("Switch Payable At")]
        [StringLength(45)]
        public string? SwitchPayableAt { get; set; }
        [Column("Switch Place Of Delivery")]
        [StringLength(45)]
        public string? SwitchPlaceOfDelivery { get; set; }
        [Column("Switch Place Of Receipt")]
        [StringLength(45)]
        public string? SwitchPlaceOfReceipt { get; set; }
        [Column("Switch Port Of Discharge Code")]
        [StringLength(5)]
        public string? SwitchPortOfDischargeCode { get; set; }
        [Column("Switch Port Of Discharge Name")]
        [StringLength(45)]
        public string? SwitchPortOfDischargeName { get; set; }
        [Column("Switch Port Of Loading Code")]
        [StringLength(5)]
        public string? SwitchPortOfLoadingCode { get; set; }
        [Column("Switch Port Of Loading Name")]
        [StringLength(45)]
        public string? SwitchPortOfLoadingName { get; set; }
        [Column("Switch Pre Carriage")]
        [StringLength(80)]
        public string? SwitchPreCarriage { get; set; }
        [Column("Switch Shipper Code")]
        [StringLength(10)]
        public string? SwitchShipperCode { get; set; }
        [Column("Switch Shipper Name")]
        [StringLength(80)]
        public string? SwitchShipperName { get; set; }
        [Column("Switch Shipper Address 1")]
        [StringLength(45)]
        public string? SwitchShipperAddress1 { get; set; }
        [Column("Switch Shipper Address 2")]
        [StringLength(45)]
        public string? SwitchShipperAddress2 { get; set; }
        [Column("Switch Shipper Address 3")]
        [StringLength(45)]
        public string? SwitchShipperAddress3 { get; set; }
        [Column("Switch Shipper Address 4")]
        [StringLength(45)]
        public string? SwitchShipperAddress4 { get; set; }
        [Column("Switch Total Pcs In Word")]
        [StringLength(255)]
        public string? SwitchTotalPcsInWord { get; set; }
        [Column("Switch Vessel Name")]
        [StringLength(50)]
        public string? SwitchVesselName { get; set; }
        [Column("Switch Voyage No")]
        [StringLength(20)]
        public string? SwitchVoyageNo { get; set; }
    }
}
