using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmtn8")]
    public partial class Jmtn8
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [StringLength(30)]
        public string? ContainerSealNo { get; set; }
        [StringLength(5)]
        public string? ContainerType { get; set; }
        [Column(TypeName = "decimal(9, 0)")]
        public decimal? Weight { get; set; }
    }
}
