using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwCtfa1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Bl No")]
        [StringLength(20)]
        public string? BlNo { get; set; }
        [Column("Combined Day")]
        public int? CombinedDay { get; set; }
        [Column("Combine Flag")]
        [StringLength(1)]
        public string? CombineFlag { get; set; }
        [Column("Consignee Name")]
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [Column("Container No")]
        [StringLength(4000)]
        public string? ContainerNo { get; set; }
        [Column("Demurrage Day")]
        public int? DemurrageDay { get; set; }
        [Column("Detention Day")]
        public int? DetentionDay { get; set; }
        [Column("ETA")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Eta { get; set; }
        public int? Frequency { get; set; }
        [Column("Port Of Discharge Code")]
        [StringLength(3)]
        public string? PortOfDischargeCode { get; set; }
        [Column("Port Of Loading Code")]
        [StringLength(3)]
        public string? PortOfLoadingCode { get; set; }
        [StringLength(4000)]
        public string? Reason { get; set; }
        [StringLength(4000)]
        public string? Reference { get; set; }
        [Column("Ref No")]
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(4000)]
        public string? Remarks { get; set; }
        [Column("Shipper Name")]
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [Column("Status Update By")]
        [StringLength(50)]
        public string? StatusUpdateBy { get; set; }
        [Column("Status Update Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? StatusUpdateDateTime { get; set; }
        [StringLength(1)]
        public string? Type { get; set; }
        [Column("Vessel Name")]
        [StringLength(50)]
        public string? VesselName { get; set; }
        [Column("Voyage No")]
        [StringLength(20)]
        public string? VoyageNo { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string? CreatedBy { get; set; }
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string? UpdatedBy { get; set; }
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string? Status { get; set; }
    }
}
