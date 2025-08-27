using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("glbt1")]
    public partial class Glbt1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(50)]
        public string? DatabaseName { get; set; }
        [StringLength(50)]
        public string? LoginId { get; set; }
        [StringLength(50)]
        public string? NewTableName { get; set; }
        [StringLength(50)]
        public string? Password { get; set; }
        [StringLength(80)]
        public string? Remark { get; set; }
        [StringLength(50)]
        public string? TableName { get; set; }
        [StringLength(80)]
        public string? Website { get; set; }
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
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
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
    }
}
