using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmce3")]
    public partial class Jmce3
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public int LineItem { get; set; }
        [StringLength(3)]
        public string? Code { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(50)]
        public string? ReferenceNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(10)]
        public string? Station { get; set; }
        [StringLength(1)]
        public string? TypeOfDate { get; set; }
    }
}
