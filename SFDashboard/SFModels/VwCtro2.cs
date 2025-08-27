using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwCtro2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Booking Line Item No")]
        public int BookingLineItemNo { get; set; }
        [Column("Commodity Code")]
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [Column("Commodity Description")]
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [Column("Container No")]
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [Column("Depot Code")]
        [StringLength(10)]
        public string? DepotCode { get; set; }
        [Column("DG Flag")]
        [StringLength(1)]
        public string? DgFlag { get; set; }
        [Column("Driver Pass No")]
        [StringLength(20)]
        public string? DriverPassNo { get; set; }
        [Column("Edi Count")]
        public int? EdiCount { get; set; }
        [Column("Equipment Type")]
        [StringLength(5)]
        public string? EquipmentType { get; set; }
        [Column("Instruction To Depot")]
        [StringLength(1000)]
        public string? InstructionToDepot { get; set; }
        [Column("Release Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ReleaseDate { get; set; }
        [Column("Release Remarks")]
        [StringLength(255)]
        public string? ReleaseRemarks { get; set; }
        [Column("RO Release Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? RoReleaseDate { get; set; }
        [Column("Seal No")]
        [StringLength(30)]
        public string? SealNo { get; set; }
        [Column("Trucker Code")]
        [StringLength(10)]
        public string? TruckerCode { get; set; }
        [Column("Trucker Name")]
        [StringLength(50)]
        public string? TruckerName { get; set; }
        [Column("Vehicle No")]
        [StringLength(25)]
        public string? VehicleNo { get; set; }
    }
}
