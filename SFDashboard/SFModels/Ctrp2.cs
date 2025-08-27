using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("ctrp2")]
    public partial class Ctrp2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public int LineItemNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date3 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date4 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date5 { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Num1 { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Num2 { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Num3 { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Num4 { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Num5 { get; set; }
        [StringLength(50)]
        public string? Text01 { get; set; }
        [StringLength(50)]
        public string? Text02 { get; set; }
        [StringLength(50)]
        public string? Text03 { get; set; }
        [StringLength(50)]
        public string? Text04 { get; set; }
        [StringLength(50)]
        public string? Text05 { get; set; }
        [StringLength(50)]
        public string? Text06 { get; set; }
        [StringLength(50)]
        public string? Text07 { get; set; }
        [StringLength(50)]
        public string? Text08 { get; set; }
        [StringLength(50)]
        public string? Text09 { get; set; }
        [StringLength(50)]
        public string? Text10 { get; set; }
        [StringLength(50)]
        public string? Text11 { get; set; }
        [StringLength(50)]
        public string? Text12 { get; set; }
        [StringLength(50)]
        public string? Text13 { get; set; }
        [StringLength(50)]
        public string? Text14 { get; set; }
        [StringLength(50)]
        public string? Text15 { get; set; }
        [StringLength(50)]
        public string? Text16 { get; set; }
        [StringLength(50)]
        public string? Text17 { get; set; }
        [StringLength(50)]
        public string? Text18 { get; set; }
        [StringLength(50)]
        public string? Text19 { get; set; }
        [StringLength(50)]
        public string? Text20 { get; set; }
    }
}
