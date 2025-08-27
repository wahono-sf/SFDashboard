using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmfb1")]
    public partial class Jmfb1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(5)]
        public string? BagType { get; set; }
        public int? Balance { get; set; }
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        public int? Qty { get; set; }
        [StringLength(20)]
        public string? SerialNo { get; set; }
        [StringLength(3)]
        public string? StatusCode { get; set; }
        [StringLength(50)]
        public string? CreateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDateTime { get; set; }
        [StringLength(50)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDateTime { get; set; }
    }
}
