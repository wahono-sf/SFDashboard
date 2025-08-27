using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("saus10")]
    public partial class Saus10
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(20)]
        public string? UserId { get; set; }
        [StringLength(50)]
        public string? Password { get; set; }
        [StringLength(50)]
        public string? WorkStation { get; set; }
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
    }
}
