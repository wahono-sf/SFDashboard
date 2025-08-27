using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("rcbx2")]
    public partial class Rcbx2
    {
        [StringLength(5)]
        public string BoxCode { get; set; } = null!;
        [StringLength(50)]
        public string? CityCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? UnitPrice { get; set; }

        [ForeignKey("BoxCode")]
        public virtual Rcbx1 BoxCodeNavigation { get; set; } = null!;
    }
}
