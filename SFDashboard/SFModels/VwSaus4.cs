using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSaus4
    {
        [Column("User ID")]
        [StringLength(20)]
        public string UserId { get; set; } = null!;
        [StringLength(4000)]
        public string? Signature { get; set; }
    }
}
