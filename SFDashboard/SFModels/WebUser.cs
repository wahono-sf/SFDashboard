using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("WebUser")]
    public partial class WebUser
    {
        [Key]
        public int SequenceId { get; set; }
        [StringLength(50)]
        public string? Name { get; set; }
        [StringLength(50)]
        public string? Pwd { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(50)]
        public string? Tel { get; set; }
        [StringLength(50)]
        public string? Role { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? CustId { get; set; }
        [StringLength(500)]
        public string? Remark { get; set; }
    }
}
