using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSmfd1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("App Combine Day")]
        public int? AppCombineDay { get; set; }
        [Column("App Demurrage Day")]
        public int? AppDemurrageDay { get; set; }
        [Column("App Detention Day")]
        public int? AppDetentionDay { get; set; }
        [Column("App Ref No")]
        [StringLength(30)]
        public string? AppRefNo { get; set; }
        [Column("Approved By")]
        [StringLength(50)]
        public string? ApprovedBy { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Bl No")]
        [StringLength(30)]
        public string? BlNo { get; set; }
        [Column("Booking Ref No")]
        [StringLength(50)]
        public string? BookingRefNo { get; set; }
        [Column("Customer Ref No")]
        [StringLength(50)]
        public string? CustomerRefNo { get; set; }
        [StringLength(255)]
        public string? Email { get; set; }
        [Column("Eta Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EtaDate { get; set; }
        [Column("Eta Pod")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EtaPod { get; set; }
        [Column("Obl No")]
        [StringLength(30)]
        public string? OblNo { get; set; }
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
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Requested By")]
        [StringLength(50)]
        public string? RequestedBy { get; set; }
        [Column("Vessel Code")]
        [StringLength(50)]
        public string? VesselCode { get; set; }
        [Column("Voyage No")]
        [StringLength(20)]
        public string? VoyageNo { get; set; }
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
