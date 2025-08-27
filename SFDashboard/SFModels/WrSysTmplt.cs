using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("wrSysTmplt")]
    public partial class WrSysTmplt
    {
        [Key]
        public int TrxNo { get; set; }
        [Column("UserID")]
        [StringLength(20)]
        public string UserId { get; set; } = null!;
        [StringLength(50)]
        public string TmpltName { get; set; } = null!;
        [StringLength(50)]
        public string? ViewName { get; set; }
        [StringLength(2000)]
        public string? FieldNames { get; set; }
        [StringLength(200)]
        public string? CboBox0 { get; set; }
        [StringLength(200)]
        public string? CboBox1 { get; set; }
        [StringLength(200)]
        public string? CboBox2 { get; set; }
        [StringLength(200)]
        public string? CboBox3 { get; set; }
        [StringLength(200)]
        public string? CboBox4 { get; set; }
        [StringLength(200)]
        public string? CboBox5 { get; set; }
        [StringLength(2000)]
        public string? ColHdrNames { get; set; }
        [StringLength(2000)]
        public string? ColWids { get; set; }
        [StringLength(50)]
        public string? GroupBy { get; set; }
        [StringLength(50)]
        public string? Order1 { get; set; }
        [StringLength(50)]
        public string? Order2 { get; set; }
        [StringLength(50)]
        public string? Order3 { get; set; }
        [Column("IsNot3_cboStatus")]
        [StringLength(50)]
        public string? IsNot3CboStatus { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(2000)]
        public string? SumOf { get; set; }
    }
}
