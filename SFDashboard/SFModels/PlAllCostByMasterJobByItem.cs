using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class PlAllCostByMasterJobByItem
    {
        [Column("Master Job No")]
        [StringLength(20)]
        public string? MasterJobNo { get; set; }
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column("Local Amt", TypeName = "decimal(38, 2)")]
        public decimal? LocalAmt { get; set; }
    }
}
