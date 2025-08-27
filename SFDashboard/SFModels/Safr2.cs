using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("safr2")]
    public partial class Safr2
    {
        [Key]
        [StringLength(10)]
        public string FreightCompanyCode { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(255)]
        public string Action { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime ActionDateTime { get; set; }
        [StringLength(50)]
        public string ContactName { get; set; } = null!;
        [StringLength(50)]
        public string Place { get; set; } = null!;
        [StringLength(50)]
        public string Position { get; set; } = null!;
        [StringLength(20)]
        public string Reference { get; set; } = null!;
        [StringLength(255)]
        public string Response { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime ResponseDateTime { get; set; }
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
    }
}
