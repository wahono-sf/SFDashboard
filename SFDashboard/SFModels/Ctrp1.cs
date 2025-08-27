using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("ctrp1")]
    public partial class Ctrp1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(10)]
        public string? ReportId { get; set; }
        [StringLength(50)]
        public string? ReportName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDateTime { get; set; }
    }
}
