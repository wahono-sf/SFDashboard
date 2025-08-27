using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("anbb2")]
    public partial class Anbb2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(20)]
        public string? AwbNo { get; set; }
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FlightDate { get; set; }
        [StringLength(6)]
        public string? FlightNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
    }
}
