using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("smfd1")]
    public partial class Smfd1
    {
        [Key]
        public int TrxNo { get; set; }
        public int? AppCombineDay { get; set; }
        public int? AppDemurrageDay { get; set; }
        public int? AppDetentionDay { get; set; }
        [StringLength(30)]
        public string? AppRefNo { get; set; }
        [StringLength(50)]
        public string? ApprovedBy { get; set; }
        [StringLength(30)]
        public string? BlNo { get; set; }
        [StringLength(50)]
        public string? BookingRefNo { get; set; }
        [StringLength(50)]
        public string? CustomerRefNo { get; set; }
        [StringLength(255)]
        public string? Email { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtaDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtaPod { get; set; }
        [StringLength(30)]
        public string? OblNo { get; set; }
        [StringLength(5)]
        public string? PortOfDischargeCode { get; set; }
        [StringLength(45)]
        public string? PortOfDischargeName { get; set; }
        [StringLength(5)]
        public string? PortOfLoadingCode { get; set; }
        [StringLength(45)]
        public string? PortOfLoadingName { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(50)]
        public string? RequestedBy { get; set; }
        [StringLength(50)]
        public string? VesselCode { get; set; }
        [StringLength(20)]
        public string? VoyageNo { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
    }
}
