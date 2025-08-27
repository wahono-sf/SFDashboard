using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("tmbi2")]
    public partial class Tmbi2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }

        [ForeignKey("TrxNo")]
        [InverseProperty("Tmbi2s")]
        public virtual Tmbi1 TrxNoNavigation { get; set; } = null!;
    }
}
