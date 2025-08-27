using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmpa3")]
    public partial class Jmpa3
    {
        [Key]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(10)]
        public string? EventCode { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [StringLength(2)]
        public string? ModuleCode { get; set; }
    }
}
