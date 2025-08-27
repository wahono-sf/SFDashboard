using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwWrViewDefine
    {
        [Column("User ID")]
        [StringLength(20)]
        public string UserId { get; set; } = null!;
        [Column("Calendar Field Name")]
        [StringLength(50)]
        public string? CalendarFieldName { get; set; }
        [Column("cbo Is Not")]
        [StringLength(1)]
        public string? CboIsNot { get; set; }
        [Column("cbo Status")]
        [StringLength(1)]
        public string? CboStatus { get; set; }
        [Column("Custom Key")]
        [StringLength(50)]
        public string? CustomKey { get; set; }
        [Column("Group By Field")]
        [StringLength(50)]
        [Unicode(false)]
        public string? GroupByField { get; set; }
        [StringLength(1)]
        public string? Remarks { get; set; }
        [StringLength(200)]
        public string? Period { get; set; }
        [Column("Select Field 1")]
        [StringLength(5000)]
        [Unicode(false)]
        public string? SelectField1 { get; set; }
        [Column("View Content")]
        [StringLength(2000)]
        [Unicode(false)]
        public string? ViewContent { get; set; }
        [Column("View Name")]
        [StringLength(30)]
        public string ViewName { get; set; } = null!;
        [Column("View Order")]
        [StringLength(255)]
        public string? ViewOrder { get; set; }
        [Column("View Width")]
        [StringLength(2000)]
        [Unicode(false)]
        public string? ViewWidth { get; set; }
    }
}
