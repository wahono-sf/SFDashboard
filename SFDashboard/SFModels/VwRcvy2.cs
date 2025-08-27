using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRcvy2
    {
        [Column("Voyage ID")]
        [StringLength(12)]
        public string VoyageId { get; set; } = null!;
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("ETA")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Eta { get; set; }
        [Column("Port Of Discharge Code")]
        [StringLength(10)]
        public string? PortOfDischargeCode { get; set; }
    }
}
