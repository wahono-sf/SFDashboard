using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("RoleInfo")]
    public partial class RoleInfo
    {
        [Column("lId")]
        public int LId { get; set; }
        [Column("sCreateBy")]
        [StringLength(50)]
        public string? SCreateBy { get; set; }
        [Column("dCreateDate", TypeName = "datetime")]
        public DateTime? DCreateDate { get; set; }
        [Column("sUpdateBy")]
        [StringLength(50)]
        public string? SUpdateBy { get; set; }
        [Column("dUpdateDate", TypeName = "datetime")]
        public DateTime? DUpdateDate { get; set; }
        [Column("lUpdateCount")]
        public int? LUpdateCount { get; set; }
        [Column("lIsDeleted")]
        public int LIsDeleted { get; set; }
        [Column("sRoleNo")]
        [StringLength(4)]
        public string SRoleNo { get; set; } = null!;
        [Column("sRoleName")]
        [StringLength(20)]
        public string SRoleName { get; set; } = null!;
        [Column("sSearchCode1")]
        [StringLength(255)]
        public string? SSearchCode1 { get; set; }
        [Column("lUserId")]
        [StringLength(20)]
        public string LUserId { get; set; } = null!;
    }
}
