using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmce4")]
    public partial class Jmce4
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(4000)]
        public string? ActualClause { get; set; }
        [StringLength(5)]
        public string? Code { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
    }
}
