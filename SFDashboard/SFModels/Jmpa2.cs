using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmpa2")]
    public partial class Jmpa2
    {
        [Key]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(15)]
        public string? AccrualAccCode { get; set; }
    }
}
