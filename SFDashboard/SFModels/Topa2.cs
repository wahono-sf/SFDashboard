using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("topa2")]
    public partial class Topa2
    {
        [Key]
        [StringLength(100)]
        public string ViewName { get; set; } = null!;
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(50)]
        public string? EditType { get; set; }
        [StringLength(100)]
        public string? FieldCaption { get; set; }
        [StringLength(50)]
        public string? FieldName { get; set; }
        [StringLength(1000)]
        public string? SearchFilter { get; set; }
        [StringLength(2000)]
        public string? SearchReturnValue { get; set; }
        [StringLength(50)]
        public string? SearchView { get; set; }
    }
}
