using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sawf2")]
    public partial class Sawf2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(50)]
        public string? AlertTo { get; set; }
        [StringLength(50)]
        public string? BusinessRuleCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        public int? Duration { get; set; }
        [StringLength(255)]
        public string? Message { get; set; }
        [StringLength(3)]
        public string? StatusFrom { get; set; }
        [StringLength(3)]
        public string? StatusTo { get; set; }
    }
}
