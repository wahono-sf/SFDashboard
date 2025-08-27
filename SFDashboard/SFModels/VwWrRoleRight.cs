using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwWrRoleRight
    {
        [Column("Hide Tab")]
        [StringLength(255)]
        public string? HideTab { get; set; }
        [Column("Node Name")]
        [StringLength(30)]
        public string NodeName { get; set; } = null!;
        [Column("Role ID")]
        public int RoleId { get; set; }
        [Column("Usr Right")]
        [StringLength(30)]
        public string? UsrRight { get; set; }
        [Column("View Condition")]
        [StringLength(255)]
        public string? ViewCondition { get; set; }
    }
}
