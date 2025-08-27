using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rchd1")]
    public partial class Rchd1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(4)]
        public string? Year { get; set; }
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [StringLength(3)]
        public string? AirportCode { get; set; }
        [StringLength(10)]
        public string? GatewayCode { get; set; }
        [StringLength(50)]
        public string? Holiday { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HolidayEndDate { get; set; }
        [StringLength(255)]
        public string? HolidayName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HolidayStartDate { get; set; }
        [StringLength(2)]
        public string? HolidayType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
    }
}
