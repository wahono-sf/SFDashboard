using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("ctfa1")]
    public partial class Ctfa1
    {
        public int TrxNo { get; set; }
        [StringLength(20)]
        public string? BlNo { get; set; }
        public int? CombinedDay { get; set; }
        [StringLength(1)]
        public string? CombineFlag { get; set; }
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [StringLength(4000)]
        public string? ContainerNo { get; set; }
        public int? DemurrageDay { get; set; }
        public int? DetentionDay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Eta { get; set; }
        public int? Frequency { get; set; }
        [StringLength(3)]
        public string? PortOfDischargeCode { get; set; }
        [StringLength(3)]
        public string? PortOfLoadingCode { get; set; }
        [StringLength(4000)]
        public string? Reason { get; set; }
        [StringLength(4000)]
        public string? Reference { get; set; }
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(4000)]
        public string? Remarks { get; set; }
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [StringLength(50)]
        public string? StatusUpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StatusUpdateDateTime { get; set; }
        [StringLength(1)]
        public string? Type { get; set; }
        [StringLength(50)]
        public string? VesselName { get; set; }
        [StringLength(20)]
        public string? VoyageNo { get; set; }
        [StringLength(3)]
        public string? StatusCode { get; set; }
        [StringLength(50)]
        public string? CreateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDateTime { get; set; }
        [StringLength(50)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDateTime { get; set; }
    }
}
