using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rcbp6")]
    public partial class Rcbp6
    {
        [Key]
        [StringLength(10)]
        public string BusinessPartyCode { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(5)]
        public string? AreaCode { get; set; }
        [StringLength(3)]
        public string? CityCode { get; set; }
        [StringLength(50)]
        public string? ContactName { get; set; }
        [StringLength(10)]
        public string? CollectFromCode { get; set; }
        [StringLength(80)]
        public string? CollectFromName { get; set; }
        [StringLength(50)]
        public string? CollectFromAddress1 { get; set; }
        [StringLength(50)]
        public string? CollectFromAddress2 { get; set; }
        [StringLength(50)]
        public string? CollectFromAddress3 { get; set; }
        [StringLength(50)]
        public string? CollectFromAddress4 { get; set; }
        [StringLength(30)]
        public string? Handphone { get; set; }
        [StringLength(10)]
        public string? PostalCode { get; set; }
        [StringLength(30)]
        public string? Telephone { get; set; }
    }
}
