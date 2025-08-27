using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sibl11")]
    public partial class Sibl11
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(4000)]
        public string? BlInstruction { get; set; }
    }
}
