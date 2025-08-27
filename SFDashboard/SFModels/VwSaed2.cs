using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSaed2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Edi Name")]
        [StringLength(50)]
        public string? EdiName { get; set; }
        [Column("File Name")]
        [StringLength(50)]
        public string? FileName { get; set; }
        [Column("Job No")]
        [StringLength(50)]
        public string? JobNo { get; set; }
        [Column("Msg Status Code")]
        [StringLength(3)]
        public string? MsgStatusCode { get; set; }
        [Column("Msg Type")]
        [StringLength(10)]
        public string? MsgType { get; set; }
        [Column("Ref No 1")]
        [StringLength(50)]
        public string? RefNo1 { get; set; }
        [Column("Ref No 2")]
        [StringLength(50)]
        public string? RefNo2 { get; set; }
        [Column("Ref No 3")]
        [StringLength(50)]
        public string? RefNo3 { get; set; }
        [Column("Ref Type 1")]
        [StringLength(50)]
        public string? RefType1 { get; set; }
        [Column("Ref Type 2")]
        [StringLength(50)]
        public string? RefType2 { get; set; }
        [Column("Ref Type 3")]
        [StringLength(50)]
        public string? RefType3 { get; set; }
        [StringLength(50)]
        public string? Remark { get; set; }
        [StringLength(1)]
        public string? Type { get; set; }
        [Column("Create By")]
        [StringLength(50)]
        public string? CreateBy { get; set; }
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
    }
}
