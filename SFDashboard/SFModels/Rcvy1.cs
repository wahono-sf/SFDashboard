using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rcvy1")]
    public partial class Rcvy1
    {
        [Key]
        [Column("VoyageID")]
        [StringLength(12)]
        public string VoyageId { get; set; } = null!;
        [Column("ATA", TypeName = "datetime")]
        public DateTime? Ata { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CloseDateTime { get; set; }
        [StringLength(5)]
        public string? ContainerType1 { get; set; }
        [StringLength(5)]
        public string? ContainerType2 { get; set; }
        [StringLength(5)]
        public string? ContainerType3 { get; set; }
        [StringLength(5)]
        public string? ContainerType4 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CutOffDateTime { get; set; }
        [Column("ETA", TypeName = "datetime")]
        public DateTime? Eta { get; set; }
        [Column("ETD", TypeName = "datetime")]
        public DateTime? Etd { get; set; }
        public short? EstTransitTime { get; set; }
        [StringLength(50)]
        public string? EstTransitTimeRemark { get; set; }
        [StringLength(5)]
        public string? FirstViaPortCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FirstViaPortEtaDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FirstViaPortEtdDate { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MaxGrossWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MaxVolume { get; set; }
        [StringLength(50)]
        public string? MotherVesselName { get; set; }
        [StringLength(20)]
        public string? MotherVoyage { get; set; }
        public int? NoOfContainer1 { get; set; }
        public int? NoOfContainer2 { get; set; }
        public int? NoOfContainer3 { get; set; }
        public int? NoOfContainer4 { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Nrt { get; set; }
        [StringLength(10)]
        public string? PortOfDischargeCode { get; set; }
        [StringLength(45)]
        public string? PortOfDischargeName { get; set; }
        [StringLength(10)]
        public string? PortOfLoadingCode { get; set; }
        [StringLength(1)]
        public string? PrintFlag { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(5)]
        public string? SecondViaPortCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SecondViaPortEtaDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SecondViaPortEtdDate { get; set; }
        [StringLength(12)]
        public string? ShippinglineCode { get; set; }
        public int? SourceTrxNo { get; set; }
        [StringLength(20)]
        public string? Terminal { get; set; }
        [StringLength(5)]
        public string? ThirdViaPortCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThirdViaPortEtaDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThirdViaPortEtdDate { get; set; }
        [StringLength(50)]
        public string? UcrNo { get; set; }
        [StringLength(50)]
        public string? VesselCode { get; set; }
        [StringLength(50)]
        public string? VoyageNo { get; set; }
        [StringLength(5)]
        public string? VoyageType { get; set; }
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
