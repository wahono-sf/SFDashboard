using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("wrViewDefine")]
    public partial class WrViewDefine
    {
        [Key]
        [Column("UserID")]
        [StringLength(20)]
        public string UserId { get; set; } = null!;
        [Key]
        [StringLength(60)]
        public string ViewName { get; set; } = null!;
        [StringLength(50)]
        public string? CalendarFieldName { get; set; }
        [Column("cboIsNot")]
        [StringLength(1)]
        public string? CboIsNot { get; set; }
        [Column("cboStatus")]
        [StringLength(2)]
        public string? CboStatus { get; set; }
        [StringLength(50)]
        public string? CustomKey { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? GroupByField { get; set; }
        [StringLength(200)]
        public string? Period { get; set; }
        [StringLength(1)]
        public string? Remarks { get; set; }
        [StringLength(5000)]
        [Unicode(false)]
        public string? SelectField1 { get; set; }
        [StringLength(2000)]
        [Unicode(false)]
        public string? ViewContent { get; set; }
        [StringLength(255)]
        public string? ViewOrder { get; set; }
        [StringLength(2000)]
        [Unicode(false)]
        public string? ViewWidth { get; set; }
    }
}
