using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwPlvi2Job
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
    }
}
