using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rcbp7")]
    public partial class Rcbp7
    {
        [Key]
        [StringLength(10)]
        public string BusinessPartyCode { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(10)]
        public string? DeliveryCode { get; set; }
        [StringLength(80)]
        public string? DeliveryName { get; set; }
        [StringLength(50)]
        public string? DeliveryAddress1 { get; set; }
        [StringLength(50)]
        public string? DeliveryAddress2 { get; set; }
        [StringLength(50)]
        public string? DeliveryAddress3 { get; set; }
        [StringLength(50)]
        public string? DeliveryAddress4 { get; set; }
    }
}
