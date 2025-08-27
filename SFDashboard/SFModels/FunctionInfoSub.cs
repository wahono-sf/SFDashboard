using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("FunctionInfoSub")]
    public partial class FunctionInfoSub
    {
        [Column("sFunNo")]
        [StringLength(10)]
        public string SFunNo { get; set; } = null!;
        [Column("lSubId")]
        public int LSubId { get; set; }
        [Column("sCode")]
        [StringLength(20)]
        public string? SCode { get; set; }
        [Column("sName")]
        [StringLength(50)]
        public string? SName { get; set; }
        [Column("bFlag")]
        public bool? BFlag { get; set; }
        [StringLength(1)]
        public string? SubType { get; set; }
    }
}
