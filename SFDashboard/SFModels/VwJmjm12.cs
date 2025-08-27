using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmjm12
    {
        [Column("Job Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? JobDate { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("Awb Bl No")]
        [StringLength(30)]
        public string? AwbBlNo { get; set; }
        [Column("Mawb Obl No")]
        [StringLength(30)]
        public string? MawbOblNo { get; set; }
        [Column("Branch Code")]
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [Column("Commodity Description")]
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Department Code")]
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
        [Column("Etd Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EtdDate { get; set; }
        [Column("Eta Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EtaDate { get; set; }
        [Column("Job Mth")]
        [StringLength(6)]
        public string? JobMth { get; set; }
        [Column("Job Type")]
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column("Gross Weight", TypeName = "decimal(38, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column("Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [Column("Module Code")]
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [Column(TypeName = "decimal(38, 4)")]
        public decimal? Volume { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("Shipment Type")]
        [StringLength(3)]
        public string? ShipmentType { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
        [Column("Vessel Name")]
        [StringLength(50)]
        public string? VesselName { get; set; }
        [Column("Flight Or Voyage No")]
        [StringLength(20)]
        public string? FlightOrVoyageNo { get; set; }
        [Column("User Define 01")]
        [StringLength(255)]
        public string? UserDefine01 { get; set; }
        [Column("User Define 02")]
        [StringLength(255)]
        public string? UserDefine02 { get; set; }
        [Column("User Define 03")]
        [StringLength(255)]
        public string? UserDefine03 { get; set; }
        [Column("User Define 04")]
        [StringLength(255)]
        public string? UserDefine04 { get; set; }
        [Column("User Define 05")]
        [StringLength(255)]
        public string? UserDefine05 { get; set; }
        [Column("User Define 06")]
        [StringLength(255)]
        public string? UserDefine06 { get; set; }
        [Column("User Define 07")]
        [StringLength(255)]
        public string? UserDefine07 { get; set; }
        [Column("User Define 08")]
        [StringLength(255)]
        public string? UserDefine08 { get; set; }
        [Column("User Define 09")]
        [StringLength(255)]
        public string? UserDefine09 { get; set; }
        [Column("User Define 10")]
        [StringLength(255)]
        public string? UserDefine10 { get; set; }
        [Column("User Define 11")]
        [StringLength(255)]
        public string? UserDefine11 { get; set; }
        [Column("User Define 12")]
        [StringLength(255)]
        public string? UserDefine12 { get; set; }
        [Column("User Define 13")]
        [StringLength(255)]
        public string? UserDefine13 { get; set; }
        [Column("User Define 14")]
        [StringLength(255)]
        public string? UserDefine14 { get; set; }
        [Column("User Define 15")]
        [StringLength(255)]
        public string? UserDefine15 { get; set; }
        [Column("User Define 16")]
        [StringLength(255)]
        public string? UserDefine16 { get; set; }
        [Column("User Define 17")]
        [StringLength(255)]
        public string? UserDefine17 { get; set; }
        [Column("User Define 18")]
        [StringLength(255)]
        public string? UserDefine18 { get; set; }
        [Column("User Define 19")]
        [StringLength(255)]
        public string? UserDefine19 { get; set; }
        [Column("User Define 20")]
        [StringLength(255)]
        public string? UserDefine20 { get; set; }
        [Column("User Group")]
        [StringLength(10)]
        public string? UserGroup { get; set; }
        [Column("Contact Name")]
        [StringLength(50)]
        public string? ContactName { get; set; }
        [Column("Customer Ref No")]
        [StringLength(50)]
        public string? CustomerRefNo { get; set; }
        [Column("Container Flag")]
        [StringLength(1)]
        [Unicode(false)]
        public string ContainerFlag { get; set; } = null!;
        [Column("Container No")]
        [StringLength(1000)]
        public string? ContainerNo { get; set; }
        [Column("Container Seal No Type")]
        [StringLength(2000)]
        public string? ContainerSealNoType { get; set; }
        public int? Pcs { get; set; }
        [Column("Total Contianer")]
        [StringLength(50)]
        public string? TotalContianer { get; set; }
    }
}
