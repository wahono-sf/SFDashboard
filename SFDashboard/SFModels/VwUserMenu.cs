using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwUserMenu
    {
        [Column("UserID")]
        [StringLength(20)]
        public string UserId { get; set; } = null!;
        [StringLength(1)]
        public string? AccessRight { get; set; }
        public int RoleId { get; set; }
        [StringLength(30)]
        public string? UsrRight { get; set; }
        [StringLength(30)]
        public string NodeName { get; set; } = null!;
        [StringLength(30)]
        public string? NodeParent { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string? NodeType { get; set; }
        [StringLength(255)]
        public string? CommentText { get; set; }
        [StringLength(100)]
        public string? MenuUrl { get; set; }
        [StringLength(100)]
        public string? MenuUrlEntry { get; set; }
        public int? SortNo { get; set; }
    }
}
