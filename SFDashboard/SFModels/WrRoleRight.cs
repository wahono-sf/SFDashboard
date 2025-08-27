using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("wrRoleRight")]
    public partial class WrRoleRight
    {
        [Key]
        public int RoleId { get; set; }
        [Key]
        [StringLength(30)]
        public string NodeName { get; set; } = null!;
        [StringLength(255)]
        public string? HideTab { get; set; }
        [StringLength(30)]
        public string? UsrRight { get; set; }
        [StringLength(255)]
        public string? ViewCondition { get; set; }
    }
}
