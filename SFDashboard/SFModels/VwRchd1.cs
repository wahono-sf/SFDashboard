using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRchd1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [StringLength(4)]
        public string? Year { get; set; }
        [Column("Country Code")]
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [Column("Airport Code")]
        [StringLength(3)]
        public string? AirportCode { get; set; }
        [Column("Gateway Code")]
        [StringLength(10)]
        public string? GatewayCode { get; set; }
        [StringLength(50)]
        public string? Holiday { get; set; }
        [Column("Holiday End Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? HolidayEndDate { get; set; }
        [Column("Holiday Name")]
        [StringLength(255)]
        public string? HolidayName { get; set; }
        [Column("Holiday Start Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? HolidayStartDate { get; set; }
        [Column("Holiday Type")]
        [StringLength(2)]
        public string? HolidayType { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Date { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string CreatedBy { get; set; } = null!;
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string UpdatedBy { get; set; } = null!;
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
    }
}
