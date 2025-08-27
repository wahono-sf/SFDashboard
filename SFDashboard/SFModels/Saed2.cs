using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("saed2")]
    public partial class Saed2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(50)]
        public string? EdiName { get; set; }
        [StringLength(50)]
        public string? FileName { get; set; }
        [StringLength(50)]
        public string? JobNo { get; set; }
        [StringLength(3)]
        public string? MsgStatusCode { get; set; }
        [StringLength(10)]
        public string? MsgType { get; set; }
        [StringLength(50)]
        public string? RefNo1 { get; set; }
        [StringLength(50)]
        public string? RefNo2 { get; set; }
        [StringLength(50)]
        public string? RefNo3 { get; set; }
        [StringLength(50)]
        public string? RefType1 { get; set; }
        [StringLength(50)]
        public string? RefType2 { get; set; }
        [StringLength(50)]
        public string? RefType3 { get; set; }
        [StringLength(50)]
        public string? Remark { get; set; }
        [StringLength(1)]
        public string? Type { get; set; }
        [StringLength(50)]
        public string? CreateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDateTime { get; set; }
    }
}
