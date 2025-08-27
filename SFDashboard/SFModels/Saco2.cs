using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("saco2")]
    public partial class Saco2
    {
        [Key]
        [StringLength(10)]
        public string CompanyCode { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(1)]
        public string? AppendPasswordFlag { get; set; }
        [StringLength(100)]
        public string? FavoriteName { get; set; }
        [StringLength(255)]
        public string? WebSite { get; set; }
    }
}
