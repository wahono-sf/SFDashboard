using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSabr1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Business Rule Code")]
        [StringLength(50)]
        public string? BusinessRuleCode { get; set; }
        [Column("Business Rule Name")]
        [StringLength(50)]
        public string BusinessRuleName { get; set; } = null!;
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
