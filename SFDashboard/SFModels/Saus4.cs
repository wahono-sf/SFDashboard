using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("saus4")]
    public partial class Saus4
    {
        [Key]
        [Column("UserID")]
        [StringLength(20)]
        public string UserId { get; set; } = null!;
        [StringLength(4000)]
        public string? Signature { get; set; }
    }
}
