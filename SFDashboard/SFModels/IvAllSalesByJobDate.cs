using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class IvAllSalesByJobDate
    {
        [Column("Item Job No")]
        [StringLength(20)]
        public string? ItemJobNo { get; set; }
        [Column("Local Amt", TypeName = "decimal(38, 2)")]
        public decimal? LocalAmt { get; set; }
        [Column("Post Mth")]
        [StringLength(6)]
        public string? PostMth { get; set; }
    }
}
