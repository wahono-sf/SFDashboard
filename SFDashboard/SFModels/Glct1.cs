using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("glct1")]
    public partial class Glct1
    {
        [Key]
        [StringLength(20)]
        public string ContractCode { get; set; } = null!;
        [StringLength(100)]
        public string? ContractDescription { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(100)]
        public string? UserDefine01 { get; set; }
        [StringLength(100)]
        public string? UserDefine02 { get; set; }
        [StringLength(100)]
        public string? UserDefine03 { get; set; }
        [StringLength(100)]
        public string? UserDefine04 { get; set; }
        [StringLength(100)]
        public string? UserDefine05 { get; set; }
        [StringLength(100)]
        public string? UserDefine06 { get; set; }
        [StringLength(100)]
        public string? UserDefine07 { get; set; }
        [StringLength(100)]
        public string? UserDefine08 { get; set; }
        [StringLength(100)]
        public string? UserDefine09 { get; set; }
        [StringLength(100)]
        public string? UserDefine10 { get; set; }
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
    }
}
