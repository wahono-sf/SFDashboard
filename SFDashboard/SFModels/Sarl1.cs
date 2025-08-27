using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sarl1")]
    public partial class Sarl1
    {
        [Key]
        public int TrxNo { get; set; }
        public int? LineItemNo { get; set; }
        [StringLength(10)]
        public string TableName { get; set; } = null!;
        [StringLength(50)]
        public string? PrimaryKeyName { get; set; }
        [StringLength(50)]
        public string? PrimaryKeyValue { get; set; }
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string? WorkStation { get; set; }
    }
}
