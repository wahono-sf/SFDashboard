using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sebk5")]
    public partial class Sebk5
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(5)]
        public string? Ems { get; set; }
        [StringLength(20)]
        public string? FlashPoint { get; set; }
        [StringLength(20)]
        public string? Imco { get; set; }
        [StringLength(1)]
        public string? MarinePollutantFlag { get; set; }
        [StringLength(5)]
        public string? PackingCode { get; set; }
        [StringLength(50)]
        public string? ProductName { get; set; }
        [StringLength(5)]
        public string? PsaGroup { get; set; }
        [StringLength(80)]
        public string? Psn { get; set; }
        [StringLength(20)]
        public string? UnNo { get; set; }
        [StringLength(1)]
        public string? WeightRestrictFlag { get; set; }

        [ForeignKey("TrxNo")]
        [InverseProperty("Sebk5s")]
        public virtual Sebk1 TrxNoNavigation { get; set; } = null!;
    }
}
