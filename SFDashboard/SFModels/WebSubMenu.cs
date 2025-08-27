using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("WebSubMenu")]
    public partial class WebSubMenu
    {
        [Key]
        public int SequenceId { get; set; }
        public int MasterId { get; set; }
        [StringLength(100)]
        public string? Name { get; set; }
        [StringLength(500)]
        public string? Note { get; set; }
        [StringLength(20)]
        public string? Color { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(200)]
        public string? Link { get; set; }
        [StringLength(20)]
        public string? LinkType { get; set; }
        public int? SortIndex { get; set; }
        public bool? IsRealTime { get; set; }
        [StringLength(50)]
        public string? Role { get; set; }
    }
}
