using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAeaw6
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        [Column("Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? CostAmt { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(1)]
        public string? Type { get; set; }
    }
}
