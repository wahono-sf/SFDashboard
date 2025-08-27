using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRcbp12
    {
        [Column("Business Party Code")]
        [StringLength(10)]
        public string BusinessPartyCode { get; set; } = null!;
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Mth 01 Nex tNo")]
        [StringLength(10)]
        public string? Mth01NexTNo { get; set; }
        [Column("Mth 02 Nex tNo")]
        [StringLength(10)]
        public string? Mth02NexTNo { get; set; }
        [Column("Mth 03 Nex tNo")]
        [StringLength(10)]
        public string? Mth03NexTNo { get; set; }
        [Column("Mth 04 Nex tNo")]
        [StringLength(10)]
        public string? Mth04NexTNo { get; set; }
        [Column("Mth 05 Nex tNo")]
        [StringLength(10)]
        public string? Mth05NexTNo { get; set; }
        [Column("Mth 06 Nex tNo")]
        [StringLength(10)]
        public string? Mth06NexTNo { get; set; }
        [Column("Mth 07 Nex tNo")]
        [StringLength(10)]
        public string? Mth07NexTNo { get; set; }
        [Column("Mth 08 Nex tNo")]
        [StringLength(10)]
        public string? Mth08NexTNo { get; set; }
        [Column("Mth 09 Nex tNo")]
        [StringLength(10)]
        public string? Mth09NexTNo { get; set; }
        [Column("Mth 10 Nex tNo")]
        [StringLength(10)]
        public string? Mth10NexTNo { get; set; }
        [Column("Mth 11 Nex tNo")]
        [StringLength(10)]
        public string? Mth11NexTNo { get; set; }
        [Column("Mth 12 Nex tNo")]
        [StringLength(10)]
        public string? Mth12NexTNo { get; set; }
        [Column("Year Next No")]
        [StringLength(10)]
        public string? YearNextNo { get; set; }
        [StringLength(4)]
        public string Year { get; set; } = null!;
    }
}
