using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("omtx5")]
    public partial class Omtx5
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(1500)]
        public string? Cost { get; set; }
        [StringLength(1000)]
        public string? RailingRemark { get; set; }
        [StringLength(1500)]
        public string? Selling { get; set; }
    }
}
