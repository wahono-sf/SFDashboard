using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sadl2")]
    public partial class Sadl2
    {
        [Key]
        [StringLength(10)]
        public string ListNo { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(80)]
        public string? CompanyName { get; set; }
        [StringLength(50)]
        public string? ContactName { get; set; }
        [StringLength(50)]
        public string? EmailAddress { get; set; }
    }
}
