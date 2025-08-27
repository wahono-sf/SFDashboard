using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("TntGroupMap")]
    public partial class TntGroupMap
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(100)]
        public string? Module { get; set; }
        [StringLength(100)]
        public string? Url { get; set; }
        [StringLength(100)]
        public string? Api { get; set; }
    }
}
