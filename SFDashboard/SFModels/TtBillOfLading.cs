using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class TtBillOfLading
    {
        [StringLength(20)]
        public string? BlNo { get; set; }
        [Column("OBLNo")]
        [StringLength(20)]
        public string? Oblno { get; set; }
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtdDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtaDate { get; set; }
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [StringLength(5)]
        public string? PortOfDischargeCode { get; set; }
        [StringLength(45)]
        public string? PortOfDischargeName { get; set; }
        [StringLength(50)]
        public string? VesselCode { get; set; }
        [StringLength(20)]
        public string? VoyageNo { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(13, 6)")]
        public decimal? CurrRate { get; set; }
        public int? TotalPcs { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalGrossWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalChargeWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalVolume { get; set; }
        public int? NoOf20ftContainer { get; set; }
        public int? NoOf40ftContainer { get; set; }
        public int? NoOf45ftContainer { get; set; }
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(5)]
        public string? PortOfLoadingCode { get; set; }
        [StringLength(45)]
        public string? PortOfLoadingName { get; set; }
        [StringLength(13)]
        public string? ContainerNo { get; set; }
    }
}
