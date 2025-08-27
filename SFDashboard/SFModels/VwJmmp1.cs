using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmmp1
    {
        [Column("Contr No")]
        [StringLength(16)]
        public string ContrNo { get; set; } = null!;
        [Column("Date Added")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DateAdded { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
    }
}
