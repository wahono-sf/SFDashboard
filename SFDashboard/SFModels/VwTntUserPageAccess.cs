using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTntUserPageAccess
    {
        [Column("lUserId")]
        [StringLength(20)]
        public string LUserId { get; set; } = null!;
        [Column("sFunNo")]
        [StringLength(10)]
        public string SFunNo { get; set; } = null!;
        [Column("sFunName")]
        [StringLength(50)]
        public string? SFunName { get; set; }
        [Column("sFunUrl")]
        [StringLength(100)]
        public string? SFunUrl { get; set; }
        public int? TabsOrder { get; set; }
    }
}
