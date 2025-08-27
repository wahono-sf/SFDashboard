using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSadl1
    {
        [Column("List No")]
        [StringLength(10)]
        public string ListNo { get; set; } = null!;
        [Column("List Name")]
        [StringLength(50)]
        public string? ListName { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Create By")]
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Update By")]
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
