using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("ivpa2")]
    public partial class Ivpa2
    {
        [Key]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        [StringLength(100)]
        public string? CopyName { get; set; }
        public byte? CopyNo { get; set; }
        [StringLength(1)]
        public string? TrxType { get; set; }
        [Key]
        public int LineItemNo { get; set; }
    }
}
