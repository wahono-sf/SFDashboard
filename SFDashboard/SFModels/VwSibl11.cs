using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSibl11
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("BL Instruction")]
        [StringLength(4000)]
        public string? BlInstruction { get; set; }
    }
}
