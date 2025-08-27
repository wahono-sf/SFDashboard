using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSawf2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Alert To")]
        [StringLength(50)]
        public string? AlertTo { get; set; }
        [Column("Business Rule Code")]
        [StringLength(50)]
        public string? BusinessRuleCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        public int? Duration { get; set; }
        [StringLength(255)]
        public string? Message { get; set; }
        [Column("Status From")]
        [StringLength(3)]
        public string? StatusFrom { get; set; }
        [Column("Status To")]
        [StringLength(3)]
        public string? StatusTo { get; set; }
    }
}
