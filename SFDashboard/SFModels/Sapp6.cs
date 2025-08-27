using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sapp6")]
    public partial class Sapp6
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(3000)]
        public string? DocumentTemplate { get; set; }
    }
}
