using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class IvAllCreditNoteByJob
    {
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Local Amt", TypeName = "decimal(38, 2)")]
        public decimal? LocalAmt { get; set; }
    }
}
