using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwCtro1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Releasing Order No")]
        [StringLength(20)]
        public string ReleasingOrderNo { get; set; } = null!;
        [Column("Booking No")]
        [StringLength(30)]
        public string? BookingNo { get; set; }
        [Column("Collection Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CollectionDate { get; set; }
        [StringLength(50)]
        public string? Commodity { get; set; }
        [Column("Depot Code")]
        [StringLength(10)]
        public string DepotCode { get; set; } = null!;
        [Column("Dg Flag")]
        [StringLength(1)]
        public string? DgFlag { get; set; }
        [Column("Edi Count")]
        public int? EdiCount { get; set; }
        [Column("Equipment Type")]
        [StringLength(5)]
        public string EquipmentType { get; set; } = null!;
        [Column("Instruction To Depot")]
        [StringLength(1000)]
        public string? InstructionToDepot { get; set; }
        [Column("Pre Cool Flag")]
        [StringLength(1)]
        public string PreCoolFlag { get; set; } = null!;
        [Column("Pre Set Sign")]
        [StringLength(1)]
        public string? PreSetSign { get; set; }
        [Column("Pre Set Temperature", TypeName = "decimal(5, 2)")]
        public decimal? PreSetTemperature { get; set; }
        [Column("Pre Set Type")]
        [StringLength(1)]
        public string? PreSetType { get; set; }
        public int Qty { get; set; }
        [Column("Ro Release Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? RoReleaseDate { get; set; }
        [Column("Shipper Code")]
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [Column("Shipper Name")]
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [Column("Trucker Code")]
        [StringLength(10)]
        public string? TruckerCode { get; set; }
        [Column("Trucker Name")]
        [StringLength(80)]
        public string? TruckerName { get; set; }
        [Column("Voltage Code")]
        [StringLength(3)]
        public string? VoltageCode { get; set; }
    }
}
