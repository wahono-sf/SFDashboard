using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwGlbc2
    {
        [Column("Bank Code")]
        [StringLength(10)]
        public string BankCode { get; set; } = null!;
        [Column("User ID")]
        [StringLength(50)]
        public string UserId { get; set; } = null!;
    }
}
