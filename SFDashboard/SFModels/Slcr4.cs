using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("slcr4")]
    public partial class Slcr4
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? ReceiptAmt { get; set; }
    }
}
