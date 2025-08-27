using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("satb1")]
    public partial class Satb1
    {
        [Key]
        [StringLength(50)]
        public string TableId { get; set; } = null!;
        [StringLength(50)]
        public string? OldTableId { get; set; }
        [StringLength(2)]
        public string? TableCode { get; set; }
        [StringLength(50)]
        public string? TableName { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
    }
}
