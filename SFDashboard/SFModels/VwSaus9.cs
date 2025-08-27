using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSaus9
    {
        [Column("User ID")]
        [StringLength(20)]
        public string UserId { get; set; } = null!;
        [Column("User Group")]
        [StringLength(10)]
        public string UserGroup { get; set; } = null!;
    }
}
