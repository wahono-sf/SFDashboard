using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwCtdo2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Current Identifier")]
        [StringLength(17)]
        public string? CurrentIdentifier { get; set; }
        [Column("EDI Count")]
        public int? EdiCount { get; set; }
        [Column("New Identifier")]
        [StringLength(17)]
        public string? NewIdentifier { get; set; }
        [Column("Record Type")]
        [StringLength(2)]
        public string? RecordType { get; set; }
    }
}
