using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSaco2
    {
        [Column("Company Code")]
        [StringLength(10)]
        public string CompanyCode { get; set; } = null!;
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Append Password Flag")]
        [StringLength(1)]
        public string? AppendPasswordFlag { get; set; }
        [Column("Favorite Name")]
        [StringLength(100)]
        public string? FavoriteName { get; set; }
        [Column("Web Site")]
        [StringLength(255)]
        public string? WebSite { get; set; }
    }
}
