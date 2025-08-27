using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmsc2")]
    public partial class Jmsc2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InvoiceDate { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? InvoiceValue { get; set; }
    }
}
