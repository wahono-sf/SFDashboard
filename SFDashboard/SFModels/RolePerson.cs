using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("RolePerson")]
    public partial class RolePerson
    {
        [Key]
        [Column("lRoleId")]
        [StringLength(20)]
        public string LRoleId { get; set; } = null!;
        [Key]
        [Column("lUserId")]
        [StringLength(20)]
        public string LUserId { get; set; } = null!;
    }
}
