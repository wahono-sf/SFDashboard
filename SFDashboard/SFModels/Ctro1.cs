using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("ctro1")]
    public partial class Ctro1
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(20)]
        public string ReleasingOrderNo { get; set; } = null!;
        [StringLength(30)]
        public string? BookingNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CollectionDate { get; set; }
        [StringLength(50)]
        public string? Commodity { get; set; }
        [StringLength(10)]
        public string DepotCode { get; set; } = null!;
        [StringLength(1)]
        public string? DgFlag { get; set; }
        public int? EdiCount { get; set; }
        [StringLength(5)]
        public string EquipmentType { get; set; } = null!;
        [StringLength(1000)]
        public string? InstructionToDepot { get; set; }
        [StringLength(1)]
        public string PreCoolFlag { get; set; } = null!;
        [StringLength(1)]
        public string? PreSetSign { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? PreSetTemperature { get; set; }
        [StringLength(1)]
        public string? PreSetType { get; set; }
        public int Qty { get; set; }
        [Column("ROReleaseDate", TypeName = "datetime")]
        public DateTime? RoreleaseDate { get; set; }
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [StringLength(10)]
        public string? TruckerCode { get; set; }
        [StringLength(80)]
        public string? TruckerName { get; set; }
        [StringLength(3)]
        public string? VoltageCode { get; set; }
    }
}
