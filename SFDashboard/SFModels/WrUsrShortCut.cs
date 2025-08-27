using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("wrUsrShortCut")]
    public partial class WrUsrShortCut
    {
        [Key]
        [StringLength(20)]
        public string UserId { get; set; } = null!;
        [Key]
        [StringLength(30)]
        public string NodeName { get; set; } = null!;
        [Key]
        [StringLength(1)]
        public string TextType { get; set; } = null!;
        [StringLength(1)]
        public string? ConnectionString { get; set; }
        [StringLength(50)]
        public string? NodeText { get; set; }
        [StringLength(300)]
        public string? ProgramPaths { get; set; }
        [StringLength(1)]
        public string? ShortCut { get; set; }
        public int? SortNo { get; set; }
        [StringLength(5)]
        public string? Version { get; set; }
    }
}
