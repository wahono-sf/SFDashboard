using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class SeFreightCollectByJob
    {
        public int TrxNo { get; set; }
        [Column(TypeName = "decimal(38, 9)")]
        public decimal? Amt { get; set; }
    }
}
