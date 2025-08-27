using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("edal1")]
    public partial class Edal1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(20)]
        public string? AwbNo { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("MAwbNo")]
        [StringLength(20)]
        public string? MawbNo { get; set; }
        [StringLength(3)]
        public string? MsgStatus { get; set; }
        [StringLength(3)]
        public string? MsgType { get; set; }
        [StringLength(4000)]
        public string? Remarks { get; set; }
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
    }
}
