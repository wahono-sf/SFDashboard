using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmce4
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Actual Clause")]
        [StringLength(4000)]
        public string? ActualClause { get; set; }
        [StringLength(5)]
        public string? Code { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
    }
}
