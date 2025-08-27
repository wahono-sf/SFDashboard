using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwWrUsrShortCut
    {
        [Column("Connection String")]
        [StringLength(1)]
        public string? ConnectionString { get; set; }
        [Column("Node Name")]
        [StringLength(30)]
        public string NodeName { get; set; } = null!;
        [Column("Node Text")]
        [StringLength(50)]
        public string? NodeText { get; set; }
        [Column("Program Paths")]
        [StringLength(300)]
        public string? ProgramPaths { get; set; }
        [Column("Short Cut")]
        [StringLength(1)]
        public string? ShortCut { get; set; }
        [Column("Sort No")]
        public int? SortNo { get; set; }
        [Column("Text Type")]
        [StringLength(1)]
        public string TextType { get; set; } = null!;
        [Column("User ID")]
        [StringLength(20)]
        public string UserId { get; set; } = null!;
        [StringLength(5)]
        public string? Version { get; set; }
    }
}
