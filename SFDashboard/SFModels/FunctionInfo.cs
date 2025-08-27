using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("FunctionInfo")]
    public partial class FunctionInfo
    {
        [Key]
        [Column("sFunNo")]
        [StringLength(10)]
        public string SFunNo { get; set; } = null!;
        [Column("sFunName")]
        [StringLength(50)]
        public string? SFunName { get; set; }
        [Column("sFunUrl")]
        [StringLength(100)]
        public string? SFunUrl { get; set; }
        [Column("sImage")]
        [StringLength(100)]
        public string? SImage { get; set; }
        [Column("sParentNo")]
        [StringLength(10)]
        public string? SParentNo { get; set; }
        [Column("lType")]
        public int? LType { get; set; }
        public int? TabsOrder { get; set; }
        [StringLength(1)]
        public string? UserFlag { get; set; }
    }
}
