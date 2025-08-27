using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class AeMawbLotNo
    {
        [Column("Awb No")]
        [StringLength(20)]
        public string AwbNo { get; set; } = null!;
        [Column("Lot No")]
        [StringLength(255)]
        public string? LotNo { get; set; }
    }
}
