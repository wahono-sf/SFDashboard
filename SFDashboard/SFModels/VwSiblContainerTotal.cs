using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSiblContainerTotal
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("No Of OT")]
        public int? NoOfOt { get; set; }
        [Column("No Of FR")]
        public int? NoOfFr { get; set; }
        [Column("No Of RF")]
        public int? NoOfRf { get; set; }
        [Column("No Of 20")]
        public int? NoOf20 { get; set; }
        [Column("No Of 20FR")]
        public int? NoOf20fr { get; set; }
        [Column("No Of 40")]
        public int? NoOf40 { get; set; }
        [Column("No Of 40FR")]
        public int? NoOf40fr { get; set; }
        [Column("No Of 40H")]
        public int? NoOf40h { get; set; }
        [Column("No Of 45")]
        public int? NoOf45 { get; set; }
    }
}
