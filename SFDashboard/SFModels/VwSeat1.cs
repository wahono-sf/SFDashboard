using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSeat1
    {
        [Column("Email Template")]
        [StringLength(3000)]
        public string? EmailTemplate { get; set; }
        [Column("Group Name")]
        [StringLength(4)]
        public string? GroupName { get; set; }
    }
}
