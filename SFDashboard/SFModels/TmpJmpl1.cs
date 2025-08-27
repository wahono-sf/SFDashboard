using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("tmp_Jmpl1")]
    public partial class TmpJmpl1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? LocalAmt { get; set; }
        [StringLength(2)]
        public string? Type { get; set; }
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
    }
}
