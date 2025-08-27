using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("sacd1")]
    public partial class Sacd1
    {
        [StringLength(10)]
        public string? TableName { get; set; }
        [StringLength(50)]
        public string? DatabaseName { get; set; }
    }
}
