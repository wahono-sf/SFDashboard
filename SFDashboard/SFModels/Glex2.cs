using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("glex2")]
    public partial class Glex2
    {
        [Key]
        [StringLength(3)]
        public string CurrCode { get; set; } = null!;
        [Key]
        [Column(TypeName = "datetime")]
        public DateTime EffectiveDate { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CostCurrRate { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? MarkupRate { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? OrgCurrRate { get; set; }
        [StringLength(50)]
        public string? Remark { get; set; }
    }
}
