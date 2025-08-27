using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("samt1")]
    public partial class Samt1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(50)]
        public string Code { get; set; } = null!;
        [StringLength(255)]
        public string? Condition { get; set; }
        [StringLength(50)]
        public string? MapCode { get; set; }
        [StringLength(20)]
        public string Type { get; set; } = null!;
    }
}
