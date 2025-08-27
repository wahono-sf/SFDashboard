using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("acva2")]
    public partial class Acva2
    {
        [Key]
        [StringLength(10)]
        public string VatCode { get; set; } = null!;
        [Key]
        [Column(TypeName = "datetime")]
        public DateTime EffectiveDate { get; set; }
        [Column(TypeName = "decimal(9, 3)")]
        public decimal? VatRate { get; set; }
    }
}
