using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwWrUseSysBasAndAdv
    {
        [Column("Char Length")]
        [StringLength(2000)]
        public string? CharLength { get; set; }
        [Column("Criteria Field 1")]
        [StringLength(2000)]
        public string? CriteriaField1 { get; set; }
        [Column("Criteria Field 2")]
        [StringLength(2000)]
        public string? CriteriaField2 { get; set; }
        [Column("Criteria Field 3")]
        [StringLength(2000)]
        public string? CriteriaField3 { get; set; }
        [Column("No Of Search")]
        public int? NoOfSearch { get; set; }
        [Column("Search Name")]
        [StringLength(50)]
        public string SearchName { get; set; } = null!;
        [Column("Select Field 1")]
        [StringLength(2000)]
        public string SelectField1 { get; set; } = null!;
        [Column("Select Field 2")]
        [StringLength(2000)]
        public string? SelectField2 { get; set; }
        [Column("Select Field 3")]
        [StringLength(2000)]
        public string? SelectField3 { get; set; }
        [Column("User ID")]
        [StringLength(20)]
        public string UserId { get; set; } = null!;
    }
}
