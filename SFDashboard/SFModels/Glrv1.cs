using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("glrv1")]
    public partial class Glrv1
    {
        [Key]
        public int TrxNo { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CostCurrRate { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RevaluateDate { get; set; }
    }
}
