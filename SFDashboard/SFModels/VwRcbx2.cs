using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRcbx2
    {
        [Column("Box Code")]
        [StringLength(5)]
        public string BoxCode { get; set; } = null!;
        [Column("City Code")]
        [StringLength(50)]
        public string? CityCode { get; set; }
        [Column("Unit Price", TypeName = "decimal(13, 2)")]
        public decimal? UnitPrice { get; set; }
    }
}
