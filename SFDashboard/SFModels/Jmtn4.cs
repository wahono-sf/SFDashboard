using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmtn4")]
    public partial class Jmtn4
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [Key]
        public short CascLineItemNo { get; set; }
        [Key]
        public short ProductLineItemNo { get; set; }
        [StringLength(35)]
        public string? CascCode1 { get; set; }
        [StringLength(35)]
        public string? CascCode2 { get; set; }
        [StringLength(35)]
        public string? CascCode3 { get; set; }
        public short? CascSeqNo { get; set; }
    }
}
