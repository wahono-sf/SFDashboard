using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSaud1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [StringLength(50)]
        public string? Caption { get; set; }
        [Column("Check Box Flag")]
        [StringLength(1)]
        public string? CheckBoxFlag { get; set; }
        [Column("Data Type")]
        [StringLength(1)]
        public string? DataType { get; set; }
        [Column("Field Line")]
        public int? FieldLine { get; set; }
        [Column("Field Value")]
        [StringLength(50)]
        public string? FieldValue { get; set; }
        [Column("Table Name")]
        [StringLength(10)]
        public string? TableName { get; set; }
        [Column("User Define")]
        [StringLength(15)]
        public string? UserDefine { get; set; }
    }
}
