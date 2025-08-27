using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("saem1")]
    public partial class Saem1
    {
        [Key]
        [StringLength(10)]
        public string EmployeeNo { get; set; } = null!;
        [StringLength(50)]
        public string? EmployeeName { get; set; }
        [StringLength(15)]
        public string? AccNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BirthDateTime { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BonusAmt { get; set; }
        [StringLength(3)]
        public string? CityCode { get; set; }
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(80)]
        public string? Footer1 { get; set; }
        [StringLength(80)]
        public string? Footer2 { get; set; }
        [StringLength(80)]
        public string? Footer3 { get; set; }
        [StringLength(80)]
        public string? Footer4 { get; set; }
        [StringLength(80)]
        public string? Footer5 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? JoinDate { get; set; }
        public byte? PrintCount { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? SalaryAmt { get; set; }
        [StringLength(1)]
        public string? Sex { get; set; }
        [StringLength(30)]
        public string? Telephone { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkFromTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkToTime { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
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
