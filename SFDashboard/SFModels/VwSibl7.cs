using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSibl7
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("EMS")]
        [StringLength(5)]
        public string? Ems { get; set; }
        [Column("Flash Point")]
        [StringLength(20)]
        public string? FlashPoint { get; set; }
        [Column("IMCO")]
        [StringLength(20)]
        public string? Imco { get; set; }
        [Column("Marine Pollutant Flag")]
        [StringLength(1)]
        public string? MarinePollutantFlag { get; set; }
        [Column("Packing Code")]
        [StringLength(5)]
        public string? PackingCode { get; set; }
        [Column("Product Name")]
        [StringLength(50)]
        public string? ProductName { get; set; }
        [Column("PSA Group")]
        [StringLength(5)]
        public string? PsaGroup { get; set; }
        [Column("PSN")]
        [StringLength(80)]
        public string? Psn { get; set; }
        [Column("Un No")]
        [StringLength(20)]
        public string? UnNo { get; set; }
        [Column("Weight Restrict Flag")]
        [StringLength(1)]
        public string? WeightRestrictFlag { get; set; }
    }
}
