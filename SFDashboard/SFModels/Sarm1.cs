using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sarm1")]
    public partial class Sarm1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(20)]
        public string? TableName { get; set; }
        [StringLength(50)]
        public string? FieldName { get; set; }
        [StringLength(2000)]
        public string? Remark { get; set; }
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
    }
}
