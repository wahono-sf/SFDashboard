using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("saug1")]
    public partial class Saug1
    {
        [Key]
        [StringLength(10)]
        public string GroupCode { get; set; } = null!;
        [StringLength(10)]
        public string? AccessGroup01 { get; set; }
        [StringLength(10)]
        public string? AccessGroup02 { get; set; }
        [StringLength(10)]
        public string? AccessGroup03 { get; set; }
        [StringLength(10)]
        public string? AccessGroup04 { get; set; }
        [StringLength(10)]
        public string? AccessGroup05 { get; set; }
        [StringLength(10)]
        public string? AccessGroup06 { get; set; }
        [StringLength(10)]
        public string? AccessGroup07 { get; set; }
        [StringLength(10)]
        public string? AccessGroup08 { get; set; }
        [StringLength(10)]
        public string? AccessGroup09 { get; set; }
        [StringLength(10)]
        public string? AccessGroup10 { get; set; }
        [StringLength(10)]
        public string? AccessGroup11 { get; set; }
        [StringLength(10)]
        public string? AccessGroup12 { get; set; }
        [StringLength(10)]
        public string? AccessGroup13 { get; set; }
        [StringLength(10)]
        public string? AccessGroup14 { get; set; }
        [StringLength(10)]
        public string? AccessGroup15 { get; set; }
        [StringLength(10)]
        public string? AccessGroup16 { get; set; }
        [StringLength(10)]
        public string? AccessGroup17 { get; set; }
        [StringLength(10)]
        public string? AccessGroup18 { get; set; }
        [StringLength(10)]
        public string? AccessGroup19 { get; set; }
        [StringLength(10)]
        public string? AccessGroup20 { get; set; }
        [StringLength(20)]
        public string? GroupLeader { get; set; }
        [StringLength(50)]
        public string? GroupName { get; set; }
        [Column("lId")]
        public int LId { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
    }
}
