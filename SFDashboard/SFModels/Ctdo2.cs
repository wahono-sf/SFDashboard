using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("Ctdo2")]
    public partial class Ctdo2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(17)]
        public string? CurrentIdentifier { get; set; }
        public int? EdiCount { get; set; }
        [StringLength(17)]
        public string? NewIdentifier { get; set; }
        [StringLength(2)]
        public string? RecordType { get; set; }
    }
}
