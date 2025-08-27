using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmeg2")]
    public partial class Jmeg2
    {
        [Key]
        [StringLength(20)]
        public string GroupCode { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(10)]
        public string? EventCode { get; set; }
    }
}
