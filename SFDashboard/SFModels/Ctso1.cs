using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("ctso1")]
    public partial class Ctso1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(20)]
        public string StoringOrderNo { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? CompleteDate { get; set; }
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress1 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress2 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress3 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress4 { get; set; }
        [StringLength(50)]
        public string? ConsigneeContactPerson { get; set; }
        [StringLength(50)]
        public string? ConsigneeContactNo { get; set; }
        [StringLength(10)]
        public string? DemurrageCode { get; set; }
        public int? DemurrageFreeDay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DemurrageStartDate { get; set; }
        [StringLength(10)]
        public string? DepotCode { get; set; }
        [StringLength(10)]
        public string? DetentionCode { get; set; }
        public int? DetentionFreeDay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DetentionStartDate { get; set; }
        public int? EdiCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtaDate { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [StringLength(1000)]
        public string? InstructionToDepot { get; set; }
        [StringLength(10)]
        public string OrganisationCode { get; set; } = null!;
        [StringLength(5)]
        public string? PortOfLoadingCode { get; set; }
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(2)]
        public string ReturnType { get; set; } = null!;
        [StringLength(50)]
        public string? SiteCode { get; set; }
        [StringLength(10)]
        public string? TruckerCode { get; set; }
        [StringLength(80)]
        public string? TruckerName { get; set; }
        [StringLength(50)]
        public string? TruckerRefNo { get; set; }
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
