using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("omdy2")]
    public partial class Omdy2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public int LineItemNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ClearDate { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column(TypeName = "decimal(11, 3)")]
        public decimal? Qty { get; set; }
        [StringLength(100)]
        public string? Remark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SurveyDate { get; set; }
        [StringLength(20)]
        public string? Type { get; set; }
    }
}
