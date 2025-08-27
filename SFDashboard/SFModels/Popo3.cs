using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("popo3")]
    public partial class Popo3
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(80)]
        public string? Comments { get; set; }
        [StringLength(50)]
        public string? EnteredBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EventDate { get; set; }
        [StringLength(50)]
        public string? EventLineNo { get; set; }
        [StringLength(50)]
        public string? EventTitle { get; set; }
        [Column("POLine")]
        public int? Poline { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(3)]
        public string? StatusCode { get; set; }
    }
}
