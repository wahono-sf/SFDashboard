using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("anbb1")]
    public partial class Anbb1
    {
        public Anbb1()
        {
            Anbb3s = new HashSet<Anbb3>();
        }

        [Key]
        public int TrxNo { get; set; }
        [StringLength(10)]
        public string? AirlineConfirmCode { get; set; }
        [Column("AirlineID")]
        [StringLength(2)]
        public string? AirlineId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AssignmentDate { get; set; }
        [StringLength(3)]
        public string? AwbCode { get; set; }
        [StringLength(50)]
        public string? BookedFrom { get; set; }
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [StringLength(3)]
        public string? DestCode { get; set; }
        [StringLength(45)]
        public string? DestName { get; set; }
        [StringLength(2)]
        public string? DimType { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DocChargeWeight { get; set; }
        [Column("FirstByAirlineID")]
        [StringLength(3)]
        public string? FirstByAirlineId { get; set; }
        [StringLength(6)]
        public string? FirstFlightNo { get; set; }
        [StringLength(3)]
        public string? FirstToDestCode { get; set; }
        [Column("FourthByAirlineID")]
        [StringLength(3)]
        public string? FourthByAirlineId { get; set; }
        [StringLength(6)]
        public string? FourthFlightNo { get; set; }
        [StringLength(3)]
        public string? FourthToDestCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [StringLength(45)]
        public string? OriginName { get; set; }
        public int? Pcs { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(1)]
        public string? RoundingFlag { get; set; }
        [Column("SecondByAirlineID")]
        [StringLength(3)]
        public string? SecondByAirlineId { get; set; }
        [StringLength(6)]
        public string? SecondFlightNo { get; set; }
        [StringLength(3)]
        public string? SecondToDestCode { get; set; }
        [Column("ThirdByAirlineID")]
        [StringLength(3)]
        public string? ThirdByAirlineId { get; set; }
        [StringLength(6)]
        public string? ThirdFlightNo { get; set; }
        [StringLength(3)]
        public string? ThirdToDestCode { get; set; }
        public int? TotalNoOfAwb { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? VolumetricWeight { get; set; }
        public short? VolumetricWeightRatio { get; set; }
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
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }

        [InverseProperty("TrxNoNavigation")]
        public virtual ICollection<Anbb3> Anbb3s { get; set; }
    }
}
