using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSaug1
    {
        [Column("Group Code")]
        [StringLength(10)]
        public string GroupCode { get; set; } = null!;
        [Column("Access Group 01")]
        [StringLength(10)]
        public string? AccessGroup01 { get; set; }
        [Column("Access Group 02")]
        [StringLength(10)]
        public string? AccessGroup02 { get; set; }
        [Column("Access Group 03")]
        [StringLength(10)]
        public string? AccessGroup03 { get; set; }
        [Column("Access Group 04")]
        [StringLength(10)]
        public string? AccessGroup04 { get; set; }
        [Column("Access Group 05")]
        [StringLength(10)]
        public string? AccessGroup05 { get; set; }
        [Column("Access Group 06")]
        [StringLength(10)]
        public string? AccessGroup06 { get; set; }
        [Column("Access Group 07")]
        [StringLength(10)]
        public string? AccessGroup07 { get; set; }
        [Column("Access Group 08")]
        [StringLength(10)]
        public string? AccessGroup08 { get; set; }
        [Column("Access Group 09")]
        [StringLength(10)]
        public string? AccessGroup09 { get; set; }
        [Column("Access Group 10")]
        [StringLength(10)]
        public string? AccessGroup10 { get; set; }
        [Column("Access Group 11")]
        [StringLength(10)]
        public string? AccessGroup11 { get; set; }
        [Column("Access Group 12")]
        [StringLength(10)]
        public string? AccessGroup12 { get; set; }
        [Column("Access Group 13")]
        [StringLength(10)]
        public string? AccessGroup13 { get; set; }
        [Column("Access Group 14")]
        [StringLength(10)]
        public string? AccessGroup14 { get; set; }
        [Column("Access Group 15")]
        [StringLength(10)]
        public string? AccessGroup15 { get; set; }
        [Column("Access Group 16")]
        [StringLength(10)]
        public string? AccessGroup16 { get; set; }
        [Column("Access Group 17")]
        [StringLength(10)]
        public string? AccessGroup17 { get; set; }
        [Column("Access Group 18")]
        [StringLength(10)]
        public string? AccessGroup18 { get; set; }
        [Column("Access Group 19")]
        [StringLength(10)]
        public string? AccessGroup19 { get; set; }
        [Column("Access Group 20")]
        [StringLength(10)]
        public string? AccessGroup20 { get; set; }
        [Column("Group Leader")]
        [StringLength(20)]
        public string? GroupLeader { get; set; }
        [Column("Group Name")]
        [StringLength(50)]
        public string? GroupName { get; set; }
        [Column("lId")]
        public int LId { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string CreatedBy { get; set; } = null!;
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string UpdatedBy { get; set; } = null!;
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
