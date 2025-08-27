using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmtn8
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Container No")]
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [Column("Container Seal No")]
        [StringLength(30)]
        public string? ContainerSealNo { get; set; }
        [Column("Container Type")]
        [StringLength(5)]
        public string? ContainerType { get; set; }
        [Column(TypeName = "decimal(9, 0)")]
        public decimal? Weight { get; set; }
    }
}
