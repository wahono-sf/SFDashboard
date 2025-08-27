using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("WicePO2")]
    public partial class WicePo2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        public int? Qty { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        public long SeqNo { get; set; }

        [ForeignKey("TrxNo")]
        [InverseProperty("WicePo2s")]
        public virtual WicePo1 TrxNoNavigation { get; set; } = null!;
    }
}
