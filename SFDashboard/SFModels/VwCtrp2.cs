using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwCtrp2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Date 1")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Date1 { get; set; }
        [Column("Date 2")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Date2 { get; set; }
        [Column("Date 3")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Date3 { get; set; }
        [Column("Date 4")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Date4 { get; set; }
        [Column("Date 5")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Date5 { get; set; }
        [Column("Num 1", TypeName = "decimal(18, 4)")]
        public decimal? Num1 { get; set; }
        [Column("Num 2", TypeName = "decimal(18, 4)")]
        public decimal? Num2 { get; set; }
        [Column("Num 3", TypeName = "decimal(18, 4)")]
        public decimal? Num3 { get; set; }
        [Column("Num 4", TypeName = "decimal(18, 4)")]
        public decimal? Num4 { get; set; }
        [Column("Num 5", TypeName = "decimal(18, 4)")]
        public decimal? Num5 { get; set; }
        [Column("Text 01")]
        [StringLength(50)]
        public string? Text01 { get; set; }
        [Column("Text 02")]
        [StringLength(50)]
        public string? Text02 { get; set; }
        [Column("Text 03")]
        [StringLength(50)]
        public string? Text03 { get; set; }
        [Column("Text 04")]
        [StringLength(50)]
        public string? Text04 { get; set; }
        [Column("Text 05")]
        [StringLength(50)]
        public string? Text05 { get; set; }
        [Column("Text 06")]
        [StringLength(50)]
        public string? Text06 { get; set; }
        [Column("Text 07")]
        [StringLength(50)]
        public string? Text07 { get; set; }
        [Column("Text 08")]
        [StringLength(50)]
        public string? Text08 { get; set; }
        [Column("Text 09")]
        [StringLength(50)]
        public string? Text09 { get; set; }
        [Column("Text 10")]
        [StringLength(50)]
        public string? Text10 { get; set; }
        [Column("Text 11")]
        [StringLength(50)]
        public string? Text11 { get; set; }
        [Column("Text 12")]
        [StringLength(50)]
        public string? Text12 { get; set; }
        [Column("Text 13")]
        [StringLength(50)]
        public string? Text13 { get; set; }
        [Column("Text 14")]
        [StringLength(50)]
        public string? Text14 { get; set; }
        [Column("Text 15")]
        [StringLength(50)]
        public string? Text15 { get; set; }
        [Column("Text 16")]
        [StringLength(50)]
        public string? Text16 { get; set; }
        [Column("Text 17")]
        [StringLength(50)]
        public string? Text17 { get; set; }
        [Column("Text 18")]
        [StringLength(50)]
        public string? Text18 { get; set; }
        [Column("Text 19")]
        [StringLength(50)]
        public string? Text19 { get; set; }
        [Column("Text 20")]
        [StringLength(50)]
        public string? Text20 { get; set; }
    }
}
