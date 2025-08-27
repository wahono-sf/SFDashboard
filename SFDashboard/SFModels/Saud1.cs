using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("saud1")]
    public partial class Saud1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(50)]
        public string? Caption { get; set; }
        [StringLength(1)]
        public string? CheckBoxFlag { get; set; }
        [StringLength(1)]
        public string? DataType { get; set; }
        public int? FieldLine { get; set; }
        [StringLength(50)]
        public string? FieldValue { get; set; }
        [StringLength(10)]
        public string? TableName { get; set; }
        [StringLength(15)]
        public string? UserDefine { get; set; }
    }
}
