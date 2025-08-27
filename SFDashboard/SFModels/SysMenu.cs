using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("SysMenu")]
    public partial class SysMenu
    {
        [Key]
        [Column("sMenuNo")]
        [StringLength(4)]
        public string SMenuNo { get; set; } = null!;
        [Column("sMenuName")]
        [StringLength(40)]
        public string? SMenuName { get; set; }
        [Column("sImage")]
        [StringLength(50)]
        public string? SImage { get; set; }
    }
}
