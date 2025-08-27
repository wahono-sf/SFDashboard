using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("satp1")]
    public partial class Satp1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(3)]
        public string? CurrencyCode { get; set; }
        [Column(TypeName = "decimal(13, 6)")]
        public decimal? CurrencyRate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        [StringLength(3)]
        public string? TermCode { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
    }
}
