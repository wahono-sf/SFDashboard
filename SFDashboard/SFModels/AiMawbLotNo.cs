using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class AiMawbLotNo
    {
        [Column("Awb No")]
        [StringLength(20)]
        public string? AwbNo { get; set; }
        [Column("Lot No")]
        [StringLength(50)]
        public string? LotNo { get; set; }
    }
}
