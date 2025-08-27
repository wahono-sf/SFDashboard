using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("acit3")]
    public partial class Acit3
    {
        [Key]
        [StringLength(30)]
        public string ItemCode { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(1)]
        public string? TrxType { get; set; }
    }
}
