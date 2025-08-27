using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("saem2")]
    public partial class Saem2
    {
        [Key]
        [StringLength(10)]
        public string EmpolyeeNo { get; set; } = null!;
        [Key]
        public short LineItemNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
    }
}
