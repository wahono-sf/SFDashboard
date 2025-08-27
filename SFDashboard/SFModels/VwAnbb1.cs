using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAnbb1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Airline Confirm Code")]
        [StringLength(10)]
        public string? AirlineConfirmCode { get; set; }
        [Column("Airline ID")]
        [StringLength(2)]
        public string? AirlineId { get; set; }
        [Column("Assignment Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? AssignmentDate { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Awb Code")]
        [StringLength(3)]
        public string? AwbCode { get; set; }
        [Column("Booked From")]
        [StringLength(50)]
        public string? BookedFrom { get; set; }
        [Column("Commodity Code")]
        [StringLength(10)]
        public string? CommodityCode { get; set; }
        [Column("Commodity Description")]
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Dest Code")]
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column("Dest Name")]
        [StringLength(45)]
        public string? DestName { get; set; }
        [Column("Dimension Type")]
        [StringLength(2)]
        public string? DimensionType { get; set; }
        [Column("Doc Charge Weight", TypeName = "decimal(13, 2)")]
        public decimal? DocChargeWeight { get; set; }
        [Column("First By Airline ID")]
        [StringLength(3)]
        public string? FirstByAirlineId { get; set; }
        [Column("First Flight No")]
        [StringLength(6)]
        public string? FirstFlightNo { get; set; }
        [Column("First To Dest Code")]
        [StringLength(3)]
        public string? FirstToDestCode { get; set; }
        [Column("Fourth By Airline ID")]
        [StringLength(3)]
        public string? FourthByAirlineId { get; set; }
        [Column("Fourth Flight No")]
        [StringLength(6)]
        public string? FourthFlightNo { get; set; }
        [Column("Fourth To Dest Code")]
        [StringLength(3)]
        public string? FourthToDestCode { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [Column("Origin Code")]
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [Column("Origin Name")]
        [StringLength(45)]
        public string? OriginName { get; set; }
        public int? Pcs { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Rounding Flag")]
        [StringLength(1)]
        public string? RoundingFlag { get; set; }
        [Column("Second By Airline ID")]
        [StringLength(3)]
        public string? SecondByAirlineId { get; set; }
        [Column("Second Flight No")]
        [StringLength(6)]
        public string? SecondFlightNo { get; set; }
        [Column("Second To Dest Code")]
        [StringLength(3)]
        public string? SecondToDestCode { get; set; }
        [Column("Third By Airline ID")]
        [StringLength(3)]
        public string? ThirdByAirlineId { get; set; }
        [Column("Third Flight No")]
        [StringLength(6)]
        public string? ThirdFlightNo { get; set; }
        [Column("Third To Dest Code")]
        [StringLength(3)]
        public string? ThirdToDestCode { get; set; }
        [Column("Total No Of Awb")]
        public int? TotalNoOfAwb { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column("Volumetric Weight", TypeName = "decimal(13, 4)")]
        public decimal? VolumetricWeight { get; set; }
        [Column("Volumetric Weight Ratio")]
        public short? VolumetricWeightRatio { get; set; }
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
