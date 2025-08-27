using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rcvy2")]
    public partial class Rcvy2
    {
        [Key]
        [Column("VoyageID")]
        [StringLength(12)]
        public string VoyageId { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [Column("ETA", TypeName = "datetime")]
        public DateTime? Eta { get; set; }
        [StringLength(10)]
        public string? PortOfDischargeCode { get; set; }
    }
}
