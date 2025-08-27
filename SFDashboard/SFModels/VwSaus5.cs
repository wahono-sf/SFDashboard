using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSaus5
    {
        [Column("User Id")]
        [StringLength(20)]
        public string UserId { get; set; } = null!;
        [Column("Document Search Name")]
        [StringLength(50)]
        public string DocumentSearchName { get; set; } = null!;
        [StringLength(1)]
        public string? Flag { get; set; }
    }
}
