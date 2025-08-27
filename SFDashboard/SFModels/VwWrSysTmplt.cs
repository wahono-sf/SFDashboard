using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwWrSysTmplt
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("User ID")]
        [StringLength(20)]
        public string UserId { get; set; } = null!;
        [Column("Tmplt Name")]
        [StringLength(50)]
        public string TmpltName { get; set; } = null!;
        [Column("View Name")]
        [StringLength(50)]
        public string? ViewName { get; set; }
        [Column("Field Names")]
        [StringLength(2000)]
        public string? FieldNames { get; set; }
        [Column("Cbo Box 0")]
        [StringLength(200)]
        public string? CboBox0 { get; set; }
        [Column("Cbo Box 1")]
        [StringLength(200)]
        public string? CboBox1 { get; set; }
        [Column("Cbo Box 2")]
        [StringLength(200)]
        public string? CboBox2 { get; set; }
        [Column("Cbo Box 3")]
        [StringLength(200)]
        public string? CboBox3 { get; set; }
        [Column("Cbo Box 4")]
        [StringLength(200)]
        public string? CboBox4 { get; set; }
        [Column("Cbo Box 5")]
        [StringLength(200)]
        public string? CboBox5 { get; set; }
        [Column("Col Hdr Names")]
        [StringLength(2000)]
        public string? ColHdrNames { get; set; }
        [Column("Col Wids")]
        [StringLength(2000)]
        public string? ColWids { get; set; }
        [Column("Group By")]
        [StringLength(50)]
        public string? GroupBy { get; set; }
        [Column("Order 1")]
        [StringLength(50)]
        public string? Order1 { get; set; }
        [Column("Order 2")]
        [StringLength(50)]
        public string? Order2 { get; set; }
        [Column("Order 3")]
        [StringLength(50)]
        public string? Order3 { get; set; }
        [Column("IsNot3 cboStatus")]
        [StringLength(50)]
        public string? IsNot3CboStatus { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Sum Of")]
        [StringLength(2000)]
        public string? SumOf { get; set; }
    }
}
