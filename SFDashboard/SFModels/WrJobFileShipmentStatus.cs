using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("wrJobFileShipmentStatus")]
    public partial class WrJobFileShipmentStatus
    {
        [Key]
        [StringLength(50)]
        public string JobNo { get; set; } = null!;
        [StringLength(10)]
        public string? TableName { get; set; }
        [StringLength(1000)]
        public string? LogFile { get; set; }
    }
}
