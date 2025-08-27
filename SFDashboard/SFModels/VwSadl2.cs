using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSadl2
    {
        [Column("List No")]
        [StringLength(10)]
        public string ListNo { get; set; } = null!;
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Company Name")]
        [StringLength(80)]
        public string? CompanyName { get; set; }
        [Column("Contact Name")]
        [StringLength(50)]
        public string? ContactName { get; set; }
        [Column("Email Address")]
        [StringLength(50)]
        public string? EmailAddress { get; set; }
    }
}
