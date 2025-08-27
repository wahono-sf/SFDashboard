using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("slcu2")]
    public partial class Slcu2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(10)]
        public string? PartyCode { get; set; }
        [StringLength(1)]
        public string? PartyType { get; set; }
        [StringLength(50)]
        public string? Relationship { get; set; }
    }
}
