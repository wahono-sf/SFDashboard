using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("aepa2")]
    public partial class Aepa2
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(50)]
        public string? CopyNo { get; set; }
        [StringLength(50)]
        public string? DocumentName { get; set; }
        [StringLength(500)]
        public string? JobType { get; set; }
        [StringLength(1)]
        public string? ShipmentType { get; set; }
    }
}
