using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("aewb1")]
    public partial class Aewb1
    {
        [Key]
        public int TrxNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ChargeAmt { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [StringLength(2000)]
        public string? CommodityDescription { get; set; }
        [StringLength(35)]
        public string? ConsigneeName { get; set; }
        [StringLength(14)]
        public string? ConsigneeAccCode { get; set; }
        [StringLength(35)]
        public string? ConsigneeAddress { get; set; }
        [StringLength(25)]
        public string? ConsigneeFaxNo { get; set; }
        [StringLength(17)]
        public string? ConsigneePlace { get; set; }
        [StringLength(9)]
        public string? ConsigneePostCode { get; set; }
        [StringLength(9)]
        public string? ConsigneeState { get; set; }
        [StringLength(25)]
        public string? ConsigneeTelNo { get; set; }
        [StringLength(35)]
        public string? ConsignorName { get; set; }
        [StringLength(12)]
        public string? CvdCarriageDeclaration { get; set; }
        [StringLength(12)]
        public string? CvdCustomsDeclaration { get; set; }
        [StringLength(3)]
        public string? CvdCurrCode { get; set; }
        [StringLength(12)]
        public string? CvdInsuranceDeclaration { get; set; }
        [StringLength(1)]
        public string? CvdWeightFlag { get; set; }
        [StringLength(1)]
        public string? CvdOtherFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FhlSubmissionDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FwbSubmissionDateTime { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [StringLength(18)]
        public string? HarmonizedCode01 { get; set; }
        [StringLength(18)]
        public string? HarmonizedCode02 { get; set; }
        [StringLength(18)]
        public string? HarmonizedCode03 { get; set; }
        [StringLength(2)]
        public string? OciCountryCode01 { get; set; }
        [StringLength(2)]
        public string? OciCountryCode02 { get; set; }
        [StringLength(2)]
        public string? OciCountryCode03 { get; set; }
        [StringLength(2)]
        public string? OciCountryCode04 { get; set; }
        [StringLength(2)]
        public string? OciCountryCode05 { get; set; }
        [StringLength(2)]
        public string? OciCountryCode06 { get; set; }
        [StringLength(2)]
        public string? OciCountryCode07 { get; set; }
        [StringLength(2)]
        public string? OciCountryCode08 { get; set; }
        [StringLength(2)]
        public string? OciCountryCode09 { get; set; }
        [StringLength(2)]
        public string? OciCustom01 { get; set; }
        [StringLength(2)]
        public string? OciCustom02 { get; set; }
        [StringLength(2)]
        public string? OciCustom03 { get; set; }
        [StringLength(2)]
        public string? OciCustom04 { get; set; }
        [StringLength(2)]
        public string? OciCustom05 { get; set; }
        [StringLength(2)]
        public string? OciCustom06 { get; set; }
        [StringLength(2)]
        public string? OciCustom07 { get; set; }
        [StringLength(2)]
        public string? OciCustom08 { get; set; }
        [StringLength(2)]
        public string? OciCustom09 { get; set; }
        [StringLength(2)]
        public string? OcInfo01 { get; set; }
        [StringLength(2)]
        public string? OcInfo02 { get; set; }
        [StringLength(2)]
        public string? OcInfo03 { get; set; }
        [StringLength(2)]
        public string? OcInfo04 { get; set; }
        [StringLength(2)]
        public string? OcInfo05 { get; set; }
        [StringLength(2)]
        public string? OcInfo06 { get; set; }
        [StringLength(2)]
        public string? OcInfo07 { get; set; }
        [StringLength(2)]
        public string? OcInfo08 { get; set; }
        [StringLength(2)]
        public string? OcInfo09 { get; set; }
        [StringLength(50)]
        public string? OciSupplementaryCustom01 { get; set; }
        [StringLength(50)]
        public string? OciSupplementaryCustom02 { get; set; }
        [StringLength(50)]
        public string? OciSupplementaryCustom03 { get; set; }
        [StringLength(50)]
        public string? OciSupplementaryCustom04 { get; set; }
        [StringLength(50)]
        public string? OciSupplementaryCustom05 { get; set; }
        [StringLength(50)]
        public string? OciSupplementaryCustom06 { get; set; }
        [StringLength(50)]
        public string? OciSupplementaryCustom07 { get; set; }
        [StringLength(50)]
        public string? OciSupplementaryCustom08 { get; set; }
        [StringLength(50)]
        public string? OciSupplementaryCustom09 { get; set; }
        public int? Pcs { get; set; }
        [StringLength(3)]
        public string? SpecialHandlingCode01 { get; set; }
        [StringLength(3)]
        public string? SpecialHandlingCode02 { get; set; }
        [StringLength(3)]
        public string? SpecialHandlingCode03 { get; set; }
        [StringLength(3)]
        public string? SpecialHandlingCode04 { get; set; }
        [StringLength(3)]
        public string? SpecialHandlingCode05 { get; set; }
        [StringLength(3)]
        public string? SpecialHandlingCode06 { get; set; }
        [StringLength(3)]
        public string? SpecialHandlingCode07 { get; set; }
        [StringLength(3)]
        public string? SpecialHandlingCode08 { get; set; }
        [StringLength(3)]
        public string? SpecialHandlingCode09 { get; set; }
        [StringLength(35)]
        public string? ShipperName { get; set; }
        [StringLength(35)]
        public string? ShipperAddress { get; set; }
        [StringLength(14)]
        public string? ShipperAccCode { get; set; }
        [StringLength(2)]
        public string? ShipperCountryCode { get; set; }
        [StringLength(25)]
        public string? ShipperFaxNo { get; set; }
        [StringLength(17)]
        public string? ShipperPlace { get; set; }
        [StringLength(9)]
        public string? ShipperPostCode { get; set; }
        [StringLength(9)]
        public string? ShipperState { get; set; }
        [StringLength(25)]
        public string? ShipperTelNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? VolumetricWeight { get; set; }
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
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
    }
}
