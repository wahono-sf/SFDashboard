using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmwo1")]
    public partial class Jmwo1
    {
        [Key]
        [StringLength(50)]
        public string JobNo { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(8)]
        public string? ContrClientCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CustomVal { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Qty { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? SupplierVal { get; set; }
        [StringLength(10)]
        public string? VoteNo { get; set; }
        [StringLength(20)]
        public string? WorkOrderNo { get; set; }
    }
}
