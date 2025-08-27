using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("sibl6")]
    public partial class Sibl6
    {
        public int TrxNo { get; set; }
        [StringLength(10)]
        public string? FinalConsigneeCode { get; set; }
        [StringLength(80)]
        public string? FinalConsigneeName { get; set; }
        [StringLength(50)]
        public string? FinalConsigneeAddress1 { get; set; }
        [StringLength(50)]
        public string? FinalConsigneeAddress2 { get; set; }
        [StringLength(50)]
        public string? FinalConsigneeAddress3 { get; set; }
        [StringLength(50)]
        public string? FinalConsigneeAddress4 { get; set; }
        [StringLength(10)]
        public string? FinalNotifyCode { get; set; }
        [StringLength(80)]
        public string? FinalNotifyName { get; set; }
        [StringLength(50)]
        public string? FinalNotifyAddress1 { get; set; }
        [StringLength(50)]
        public string? FinalNotifyAddress2 { get; set; }
        [StringLength(50)]
        public string? FinalNotifyAddress3 { get; set; }
        [StringLength(50)]
        public string? FinalNotifyAddress4 { get; set; }
        [StringLength(10)]
        public string? FinalShipperCode { get; set; }
        [StringLength(80)]
        public string? FinalShipperName { get; set; }
        [StringLength(50)]
        public string? FinalShipperAddress1 { get; set; }
        [StringLength(50)]
        public string? FinalShipperAddress2 { get; set; }
        [StringLength(50)]
        public string? FinalShipperAddress3 { get; set; }
        [StringLength(50)]
        public string? FinalShipperAddress4 { get; set; }
        [StringLength(10)]
        public string? SwitchAlsoNotifyCode { get; set; }
        [StringLength(80)]
        public string? SwitchAlsoNotifyName { get; set; }
        [StringLength(50)]
        public string? SwitchAlsoNotifyAddress1 { get; set; }
        [StringLength(50)]
        public string? SwitchAlsoNotifyAddress2 { get; set; }
        [StringLength(50)]
        public string? SwitchAlsoNotifyAddress3 { get; set; }
        [StringLength(50)]
        public string? SwitchAlsoNotifyAddress4 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SwitchBlIssueDate { get; set; }
        [StringLength(45)]
        public string? SwitchBlIssuePlace { get; set; }
        [StringLength(10)]
        public string? SwitchConsigneeCode { get; set; }
        [StringLength(80)]
        public string? SwitchConsigneeName { get; set; }
        [StringLength(50)]
        public string? SwitchConsigneeAddress1 { get; set; }
        [StringLength(50)]
        public string? SwitchConsigneeAddress2 { get; set; }
        [StringLength(50)]
        public string? SwitchConsigneeAddress3 { get; set; }
        [StringLength(50)]
        public string? SwitchConsigneeAddress4 { get; set; }
        [StringLength(10)]
        public string? SwitchDeliveryAgentCode { get; set; }
        [StringLength(80)]
        public string? SwitchDeliveryAgentName { get; set; }
        [StringLength(50)]
        public string? SwitchDeliveryAgentAddress1 { get; set; }
        [StringLength(50)]
        public string? SwitchDeliveryAgentAddress2 { get; set; }
        [StringLength(50)]
        public string? SwitchDeliveryAgentAddress3 { get; set; }
        [StringLength(50)]
        public string? SwitchDeliveryAgentAddress4 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SwitchLadenDate { get; set; }
        public byte? SwitchNoOfOriginBl { get; set; }
        [StringLength(10)]
        public string? SwitchNotifyCode { get; set; }
        [StringLength(80)]
        public string? SwitchNotifyName { get; set; }
        [StringLength(50)]
        public string? SwitchNotifyAddress1 { get; set; }
        [StringLength(50)]
        public string? SwitchNotifyAddress2 { get; set; }
        [StringLength(50)]
        public string? SwitchNotifyAddress3 { get; set; }
        [StringLength(50)]
        public string? SwitchNotifyAddress4 { get; set; }
        [StringLength(45)]
        public string? SwitchPayableAt { get; set; }
        [StringLength(45)]
        public string? SwitchPlaceOfDelivery { get; set; }
        [StringLength(45)]
        public string? SwitchPlaceOfReceipt { get; set; }
        [StringLength(5)]
        public string? SwitchPortOfDischargeCode { get; set; }
        [StringLength(45)]
        public string? SwitchPortOfDischargeName { get; set; }
        [StringLength(5)]
        public string? SwitchPortOfLoadingCode { get; set; }
        [StringLength(45)]
        public string? SwitchPortOfLoadingName { get; set; }
        [StringLength(80)]
        public string? SwitchPreCarriage { get; set; }
        [StringLength(10)]
        public string? SwitchShipperCode { get; set; }
        [StringLength(80)]
        public string? SwitchShipperName { get; set; }
        [StringLength(50)]
        public string? SwitchShipperAddress1 { get; set; }
        [StringLength(50)]
        public string? SwitchShipperAddress2 { get; set; }
        [StringLength(50)]
        public string? SwitchShipperAddress3 { get; set; }
        [StringLength(50)]
        public string? SwitchShipperAddress4 { get; set; }
        [StringLength(255)]
        public string? SwitchTotalPcsInWord { get; set; }
        [StringLength(50)]
        public string? SwitchVesselName { get; set; }
        [StringLength(20)]
        public string? SwitchVoyageNo { get; set; }
    }
}
