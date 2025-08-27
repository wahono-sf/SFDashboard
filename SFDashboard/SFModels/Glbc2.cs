using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("glbc2")]
    public partial class Glbc2
    {
        [Key]
        [StringLength(10)]
        public string BankCode { get; set; } = null!;
        [Key]
        [Column("UserID")]
        [StringLength(50)]
        public string UserId { get; set; } = null!;
    }
}
