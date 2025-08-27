using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTopa2
    {
        [Column("View Name")]
        [StringLength(100)]
        public string ViewName { get; set; } = null!;
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Edit Type")]
        [StringLength(50)]
        public string? EditType { get; set; }
        [Column("Field Caption")]
        [StringLength(100)]
        public string? FieldCaption { get; set; }
        [Column("Field Name")]
        [StringLength(50)]
        public string? FieldName { get; set; }
        [Column("Search Filter")]
        [StringLength(1000)]
        public string? SearchFilter { get; set; }
        [Column("Search Return Value")]
        [StringLength(2000)]
        public string? SearchReturnValue { get; set; }
        [Column("Search View")]
        [StringLength(50)]
        public string? SearchView { get; set; }
    }
}
