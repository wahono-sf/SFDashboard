using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("savl1")]
    public partial class Savl1
    {
        [Key]
        public int LineItemNo { get; set; }
        [Key]
        [StringLength(50)]
        public string TableName { get; set; } = null!;
        [Key]
        [StringLength(50)]
        public string FieldName { get; set; } = null!;
        [StringLength(50)]
        public string? ActualValue { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
    }
}
