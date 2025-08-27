using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmjm4
    {
        [Column("Job No")]
        [StringLength(20)]
        public string JobNo { get; set; } = null!;
        [Column("Job Line Item No")]
        public int JobLineItemNo { get; set; }
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Container No")]
        [StringLength(500)]
        public string? ContainerNo { get; set; }
        [Column("Container No Flag")]
        [StringLength(1)]
        public string? ContainerNoFlag { get; set; }
        [Column("Done At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DoneAt { get; set; }
        [Column("Done Flag")]
        [StringLength(1)]
        public string? DoneFlag { get; set; }
        [Column("Driver Code")]
        [StringLength(15)]
        public string? DriverCode { get; set; }
        [Column("Driver Name")]
        [StringLength(45)]
        public string? DriverName { get; set; }
        [Column("Email Address Flag")]
        [StringLength(1)]
        public string? EmailAddressFlag { get; set; }
        [Column("Event Line Item No")]
        public int? EventLineItemNo { get; set; }
        [Column("Item Name")]
        [StringLength(50)]
        public string? ItemName { get; set; }
        [Column("Last Alert Email Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastAlertEmailDate { get; set; }
        [Column("Mobile User")]
        [StringLength(10)]
        public string? MobileUser { get; set; }
        [Column("Phone Number")]
        [StringLength(50)]
        public string? PhoneNumber { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
    }
}
