using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwEdct1
    {
        public int TrxNo { get; set; }
        [Column("Customs Entry No")]
        [StringLength(20)]
        public string CustomsEntryNo { get; set; } = null!;
        [Column("EDI No")]
        [StringLength(20)]
        public string? EdiNo { get; set; }
        [Column("Release Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ReleaseDate { get; set; }
        [Column("Release Port")]
        [StringLength(20)]
        public string? ReleasePort { get; set; }
        [Column("Declaration Status")]
        [StringLength(3)]
        public string? DeclarationStatus { get; set; }
    }
}
