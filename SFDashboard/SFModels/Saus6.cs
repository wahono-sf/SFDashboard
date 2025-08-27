using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("saus6")]
    public partial class Saus6
    {
        [Key]
        [Column("UserID")]
        [StringLength(20)]
        public string UserId { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        public int? FrequentReportTrxNo { get; set; }
    }
}
