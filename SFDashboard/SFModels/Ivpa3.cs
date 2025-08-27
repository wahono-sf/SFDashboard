using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("ivpa3")]
    public partial class Ivpa3
    {
        [Key]
        public int UniqueKey { get; set; }
        [StringLength(15)]
        public string? OutlayVatAccCode { get; set; }
        [StringLength(30)]
        public string? OutlayVatItemCode { get; set; }
        [Key]
        public int LineItemNo { get; set; }
    }
}
