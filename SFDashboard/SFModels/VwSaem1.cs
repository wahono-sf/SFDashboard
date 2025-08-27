using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSaem1
    {
        [Column("Employee No")]
        [StringLength(10)]
        public string EmployeeNo { get; set; } = null!;
        [Column("Employee Name")]
        [StringLength(50)]
        public string? EmployeeName { get; set; }
        [Column("Acc No")]
        [StringLength(15)]
        public string? AccNo { get; set; }
        [Column("Birth Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? BirthDateTime { get; set; }
        [Column("Bonus Amt", TypeName = "decimal(13, 2)")]
        public decimal? BonusAmt { get; set; }
        [Column("City Code")]
        [StringLength(3)]
        public string? CityCode { get; set; }
        [Column("Country Code")]
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [Column("Footer 1")]
        [StringLength(80)]
        public string? Footer1 { get; set; }
        [Column("Footer 2")]
        [StringLength(80)]
        public string? Footer2 { get; set; }
        [Column("Footer 3")]
        [StringLength(80)]
        public string? Footer3 { get; set; }
        [Column("Footer 4")]
        [StringLength(80)]
        public string? Footer4 { get; set; }
        [Column("Footer 5")]
        [StringLength(80)]
        public string? Footer5 { get; set; }
        [Column("Join Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? JoinDate { get; set; }
        [Column("Print Count")]
        public byte? PrintCount { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Salary Amt", TypeName = "decimal(13, 2)")]
        public decimal? SalaryAmt { get; set; }
        [StringLength(1)]
        public string? Sex { get; set; }
        [StringLength(30)]
        public string? Telephone { get; set; }
        [Column("Work From Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? WorkFromTime { get; set; }
        [Column("Work To Time")]
        [StringLength(5)]
        [Unicode(false)]
        public string? WorkToTime { get; set; }
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
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
