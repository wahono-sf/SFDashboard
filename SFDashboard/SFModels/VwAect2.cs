using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAect2
    {
        [Column("Cargo Trf Form No")]
        [StringLength(8)]
        public string CargoTrfFormNo { get; set; } = null!;
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Awb Type")]
        [StringLength(1)]
        public string? AwbType { get; set; }
        [Column("Container No")]
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [StringLength(50)]
        public string? Content { get; set; }
        [Column("Dest Code")]
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column("Flight Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FlightDate { get; set; }
        [Column("Flight No")]
        [StringLength(6)]
        public string? FlightNo { get; set; }
        [Column("M Awb No")]
        [StringLength(20)]
        public string? MAwbNo { get; set; }
        public int? Pcs { get; set; }
        [StringLength(50)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
    }
}
