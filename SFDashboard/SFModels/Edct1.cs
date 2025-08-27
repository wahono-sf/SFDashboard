using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("edct1")]
    public partial class Edct1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(20)]
        public string CustomsEntryNo { get; set; } = null!;
        [StringLength(3)]
        public string? DeclarationStatus { get; set; }
        [Column("EDINo")]
        [StringLength(20)]
        public string? Edino { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReleaseDate { get; set; }
        [StringLength(20)]
        public string? ReleasePort { get; set; }
    }
}
