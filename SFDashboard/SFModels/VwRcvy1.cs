using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRcvy1
    {
        [Column("Voyage ID")]
        [StringLength(12)]
        public string VoyageId { get; set; } = null!;
        [Column("ATA")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Ata { get; set; }
        [Column("ATA Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? AtaDate { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Close Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CloseDateTime { get; set; }
        [Column("Container Type 1")]
        [StringLength(5)]
        public string? ContainerType1 { get; set; }
        [Column("Container Type 2")]
        [StringLength(5)]
        public string? ContainerType2 { get; set; }
        [Column("Container Type 3")]
        [StringLength(5)]
        public string? ContainerType3 { get; set; }
        [Column("Container Type 4")]
        [StringLength(5)]
        public string? ContainerType4 { get; set; }
        [Column("Cut Off Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CutOffDateTime { get; set; }
        [Column("ETA")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Eta { get; set; }
        [Column("ETA Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EtaDate { get; set; }
        [Column("ETD")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Etd { get; set; }
        [Column("ETD Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EtdDate { get; set; }
        [Column("Est Transit Time")]
        public short? EstTransitTime { get; set; }
        [Column("Est Transit Time Remark")]
        [StringLength(50)]
        public string? EstTransitTimeRemark { get; set; }
        [Column("First Via Port Code")]
        [StringLength(5)]
        public string? FirstViaPortCode { get; set; }
        [Column("First Via Port Eta Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FirstViaPortEtaDate { get; set; }
        [Column("First Via Port Etd Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FirstViaPortEtdDate { get; set; }
        [Column("Job Type")]
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column("Max Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? MaxGrossWeight { get; set; }
        [Column("Max Volume", TypeName = "decimal(13, 4)")]
        public decimal? MaxVolume { get; set; }
        [Column("Mother Vessel Name")]
        [StringLength(50)]
        public string? MotherVesselName { get; set; }
        [Column("Mother Voyage")]
        [StringLength(20)]
        public string? MotherVoyage { get; set; }
        [Column("No Of Container 1")]
        public int? NoOfContainer1 { get; set; }
        [Column("No Of Container 2")]
        public int? NoOfContainer2 { get; set; }
        [Column("No Of Container 3")]
        public int? NoOfContainer3 { get; set; }
        [Column("No Of Container 4")]
        public int? NoOfContainer4 { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Nrt { get; set; }
        [Column("Port Of Discharge Code")]
        [StringLength(10)]
        public string? PortOfDischargeCode { get; set; }
        [Column("Port Of Discharge Name")]
        [StringLength(45)]
        public string? PortOfDischargeName { get; set; }
        [Column("Port Of Loading Code")]
        [StringLength(10)]
        public string? PortOfLoadingCode { get; set; }
        [Column("Print Flag")]
        [StringLength(1)]
        public string? PrintFlag { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Second Via Port Code")]
        [StringLength(5)]
        public string? SecondViaPortCode { get; set; }
        [Column("Second Via Port Eta Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? SecondViaPortEtaDate { get; set; }
        [Column("Second Via Port Etd Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? SecondViaPortEtdDate { get; set; }
        [Column("Shippingline Code")]
        [StringLength(12)]
        public string? ShippinglineCode { get; set; }
        [Column("Shippingline Name")]
        [StringLength(80)]
        public string? ShippinglineName { get; set; }
        [Column("Source Trx No")]
        public int? SourceTrxNo { get; set; }
        [StringLength(20)]
        public string? Terminal { get; set; }
        [Column("Third Via Port Code")]
        [StringLength(5)]
        public string? ThirdViaPortCode { get; set; }
        [Column("Third Via Port Eta Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThirdViaPortEtaDate { get; set; }
        [Column("Third Via Port Etd Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ThirdViaPortEtdDate { get; set; }
        [Column("Ucr No")]
        [StringLength(50)]
        public string? UcrNo { get; set; }
        [Column("Vessel Code")]
        [StringLength(50)]
        public string? VesselCode { get; set; }
        [Column("Vessel Name")]
        [StringLength(50)]
        public string? VesselName { get; set; }
        [Column("Voyage No")]
        [StringLength(50)]
        public string? VoyageNo { get; set; }
        [Column("Voyage Type")]
        [StringLength(5)]
        public string? VoyageType { get; set; }
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
