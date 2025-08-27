using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("plvi3")]
    public partial class Plvi3
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public int LineItemNo { get; set; }
        [Column(TypeName = "decimal(17, 2)")]
        public decimal? ChequeAmt { get; set; }
        [StringLength(10)]
        public string? ChequeNo { get; set; }
    }
}
