using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sabr1")]
    public partial class Sabr1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(50)]
        public string? BusinessRuleCode { get; set; }
        [StringLength(50)]
        public string? BusinessRuleName { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
    }
}
