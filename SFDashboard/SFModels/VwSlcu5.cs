using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSlcu5
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Ageing Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? AgeingDate { get; set; }
    }
}
