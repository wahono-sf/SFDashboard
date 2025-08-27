using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("wrUseSysBasAndAdv")]
    public partial class WrUseSysBasAndAdv
    {
        [Key]
        [Column("UserID")]
        [StringLength(20)]
        public string UserId { get; set; } = null!;
        [Key]
        [StringLength(50)]
        public string SearchName { get; set; } = null!;
        [StringLength(2000)]
        public string? CharLength { get; set; }
        [StringLength(2000)]
        public string? CriteriaField1 { get; set; }
        [StringLength(2000)]
        public string? CriteriaField2 { get; set; }
        [StringLength(2000)]
        public string? CriteriaField3 { get; set; }
        public int? NoOfSearch { get; set; }
        [StringLength(2000)]
        public string SelectField1 { get; set; } = null!;
        [StringLength(2000)]
        public string? SelectField2 { get; set; }
        [StringLength(2000)]
        public string? SelectField3 { get; set; }
    }
}
