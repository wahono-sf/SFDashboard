using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("Jmjs2")]
    public partial class Jmjs2
    {
        [Key]
        [StringLength(10)]
        public string JobStatusCode { get; set; } = null!;
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
    }
}
