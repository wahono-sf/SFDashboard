using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("ctro2")]
    public partial class Ctro2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public int LineItemNo { get; set; }
        [Key]
        public int BookingLineItemNo { get; set; }
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [StringLength(10)]
        public string? DepotCode { get; set; }
        [Column("DGFlag")]
        [StringLength(1)]
        public string? Dgflag { get; set; }
        [StringLength(20)]
        public string? DriverPassNo { get; set; }
        public int? EdiCount { get; set; }
        [StringLength(5)]
        public string? EquipmentType { get; set; }
        [StringLength(1000)]
        public string? InstructionToDepot { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReleaseDate { get; set; }
        [StringLength(255)]
        public string? ReleaseRemarks { get; set; }
        [Column("ROReleaseDate", TypeName = "datetime")]
        public DateTime? RoreleaseDate { get; set; }
        [StringLength(30)]
        public string? SealNo { get; set; }
        [StringLength(10)]
        public string? TruckerCode { get; set; }
        [StringLength(50)]
        public string? TruckerName { get; set; }
        [StringLength(25)]
        public string? VehicleNo { get; set; }
    }
}
