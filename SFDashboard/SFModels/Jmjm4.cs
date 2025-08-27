using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmjm4")]
    public partial class Jmjm4
    {
        [Key]
        [StringLength(30)]
        public string JobNo { get; set; } = null!;
        [Key]
        public int JobLineItemNo { get; set; }
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(500)]
        public string? ContainerNo { get; set; }
        [StringLength(1)]
        public string? ContainerNoFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DoneDateTime { get; set; }
        [StringLength(1)]
        public string? DoneFlag { get; set; }
        [StringLength(15)]
        public string? DriverCode { get; set; }
        [StringLength(45)]
        public string? DriverName { get; set; }
        [StringLength(1)]
        public string? EmailAddressFlag { get; set; }
        public int? EventLineItemNo { get; set; }
        [StringLength(50)]
        public string? ItemName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastAlertEmailDate { get; set; }
        [StringLength(10)]
        public string? MobileUser { get; set; }
        [StringLength(50)]
        public string? PhoneNumber { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
    }
}
