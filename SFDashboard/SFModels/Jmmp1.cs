using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmmp1")]
    public partial class Jmmp1
    {
        [Key]
        [StringLength(16)]
        public string ContrNo { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? DateAdded { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
    }
}
