using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("anat2")]
    public partial class Anat2
    {
        [Key]
        public int FormNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(10)]
        public string? AgentCode { get; set; }
        [StringLength(3)]
        public string? AwbCopy { get; set; }
        [StringLength(20)]
        public string AwbNo { get; set; } = null!;
        [StringLength(3)]
        public string? AwbStatusCode { get; set; }
        [StringLength(1)]
        public string? AwbType { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }

        [ForeignKey("FormNo")]
        [InverseProperty("Anat2s")]
        public virtual Anat1 FormNoNavigation { get; set; } = null!;
    }
}
