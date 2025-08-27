using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("ctri1")]
    public partial class Ctri1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(20)]
        public string ReleasingInstructionNo { get; set; } = null!;
        [StringLength(10)]
        public string? DetentionCode { get; set; }
        public int? DetentionFreeDay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DetentionStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtaDate { get; set; }
        [StringLength(5)]
        public string? FirstViaPortCode { get; set; }
        [StringLength(30)]
        public string MasterJobNo { get; set; } = null!;
        [StringLength(10)]
        public string OrganisationCode { get; set; } = null!;
        [StringLength(5)]
        public string? PortOfLoadingCode { get; set; }
        [StringLength(5)]
        public string? PortOfDischargeCode { get; set; }
        [StringLength(5)]
        public string? ReleaseType { get; set; }
        [StringLength(5)]
        public string? ReleasingDestinationCode { get; set; }
        [StringLength(5)]
        public string? SecondViaPortCode { get; set; }
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [StringLength(5)]
        public string? ThirdViaPortCode { get; set; }
        [StringLength(50)]
        public string? VesselName { get; set; }
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
    }
}
