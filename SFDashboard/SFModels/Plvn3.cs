using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("plvn3")]
    public partial class Plvn3
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(50)]
        public string? ContactName { get; set; }
        [StringLength(100)]
        public string? Email { get; set; }
        [StringLength(30)]
        public string? Fax { get; set; }
        [StringLength(30)]
        public string? Handphone { get; set; }
        [Column(TypeName = "image")]
        public byte[]? NameCard { get; set; }
        [StringLength(30)]
        public string? Telephone { get; set; }
        [StringLength(20)]
        public string? Title { get; set; }
    }
}
