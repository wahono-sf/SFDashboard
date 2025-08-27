using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class IvAllSalesByJobWithVatOutlay
    {
        [Column("Item Job No")]
        [StringLength(30)]
        public string? ItemJobNo { get; set; }
        [Column("Local Amt", TypeName = "decimal(38, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column("Cost Amt", TypeName = "decimal(38, 2)")]
        public decimal? CostAmt { get; set; }
    }
}
