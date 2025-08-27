using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("saus9")]
    public partial class Saus9
    {
        [Key]
        [Column("UserID")]
        [StringLength(20)]
        public string UserId { get; set; } = null!;
        [Key]
        [StringLength(10)]
        public string UserGroup { get; set; } = null!;
    }
}
