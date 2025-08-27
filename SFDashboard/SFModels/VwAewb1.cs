using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAewb1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Charge Amt", TypeName = "decimal(13, 2)")]
        public decimal? ChargeAmt { get; set; }
        [Column("Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [Column("Commodity Description")]
        [StringLength(2000)]
        public string? CommodityDescription { get; set; }
        [Column("Consignee Name")]
        [StringLength(35)]
        public string? ConsigneeName { get; set; }
        [Column("Consignee Acc Code")]
        [StringLength(14)]
        public string? ConsigneeAccCode { get; set; }
        [Column("Consignee Address")]
        [StringLength(35)]
        public string? ConsigneeAddress { get; set; }
        [Column("Consignee Fax No")]
        [StringLength(25)]
        public string? ConsigneeFaxNo { get; set; }
        [Column("Consignee Place")]
        [StringLength(17)]
        public string? ConsigneePlace { get; set; }
        [Column("Consignee Post Code")]
        [StringLength(9)]
        public string? ConsigneePostCode { get; set; }
        [Column("Consignee State")]
        [StringLength(9)]
        public string? ConsigneeState { get; set; }
        [Column("Consignee Tel No")]
        [StringLength(25)]
        public string? ConsigneeTelNo { get; set; }
        [Column("Consignor Name")]
        [StringLength(35)]
        public string? ConsignorName { get; set; }
        [Column("Cvd Carriage Declaration")]
        [StringLength(12)]
        public string? CvdCarriageDeclaration { get; set; }
        [Column("Cvd Customs Declaration")]
        [StringLength(12)]
        public string? CvdCustomsDeclaration { get; set; }
        [Column("Cvd Curr Code")]
        [StringLength(3)]
        public string? CvdCurrCode { get; set; }
        [Column("Cvd Insurance Declaration")]
        [StringLength(12)]
        public string? CvdInsuranceDeclaration { get; set; }
        [Column("Cvd Weight Flag")]
        [StringLength(1)]
        public string? CvdWeightFlag { get; set; }
        [Column("Cvd Other Flag")]
        [StringLength(1)]
        public string? CvdOtherFlag { get; set; }
        [Column("Fhl Submission Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? FhlSubmissionDateTime { get; set; }
        [Column("Fwb Submission Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? FwbSubmissionDateTime { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column("Harmonized Code 01")]
        [StringLength(18)]
        public string? HarmonizedCode01 { get; set; }
        [Column("Harmonized Code 02")]
        [StringLength(18)]
        public string? HarmonizedCode02 { get; set; }
        [Column("Harmonized Code 03")]
        [StringLength(18)]
        public string? HarmonizedCode03 { get; set; }
        [Column("Oci Country Code 01")]
        [StringLength(2)]
        public string? OciCountryCode01 { get; set; }
        [Column("Oci Country Code 02")]
        [StringLength(2)]
        public string? OciCountryCode02 { get; set; }
        [Column("Oci Country Code 03")]
        [StringLength(2)]
        public string? OciCountryCode03 { get; set; }
        [Column("Oci Country Code 04")]
        [StringLength(2)]
        public string? OciCountryCode04 { get; set; }
        [Column("Oci Country Code 05")]
        [StringLength(2)]
        public string? OciCountryCode05 { get; set; }
        [Column("Oci Country Code 06")]
        [StringLength(2)]
        public string? OciCountryCode06 { get; set; }
        [Column("Oci Country Code 07")]
        [StringLength(2)]
        public string? OciCountryCode07 { get; set; }
        [Column("Oci Country Code 08")]
        [StringLength(2)]
        public string? OciCountryCode08 { get; set; }
        [Column("Oci Country Code 09")]
        [StringLength(2)]
        public string? OciCountryCode09 { get; set; }
        [Column("Oci Custom 01")]
        [StringLength(2)]
        public string? OciCustom01 { get; set; }
        [Column("Oci Custom 02")]
        [StringLength(2)]
        public string? OciCustom02 { get; set; }
        [Column("Oci Custom 03")]
        [StringLength(2)]
        public string? OciCustom03 { get; set; }
        [Column("Oci Custom 04")]
        [StringLength(2)]
        public string? OciCustom04 { get; set; }
        [Column("Oci Custom 05")]
        [StringLength(2)]
        public string? OciCustom05 { get; set; }
        [Column("Oci Custom 06")]
        [StringLength(2)]
        public string? OciCustom06 { get; set; }
        [Column("Oci Custom 07")]
        [StringLength(2)]
        public string? OciCustom07 { get; set; }
        [Column("Oci Custom 08")]
        [StringLength(2)]
        public string? OciCustom08 { get; set; }
        [Column("Oci Custom 09")]
        [StringLength(2)]
        public string? OciCustom09 { get; set; }
        [Column("Oc Info 01")]
        [StringLength(2)]
        public string? OcInfo01 { get; set; }
        [Column("Oc Info 02")]
        [StringLength(2)]
        public string? OcInfo02 { get; set; }
        [Column("Oc Info 03")]
        [StringLength(2)]
        public string? OcInfo03 { get; set; }
        [Column("Oc Info 04")]
        [StringLength(2)]
        public string? OcInfo04 { get; set; }
        [Column("Oc Info 05")]
        [StringLength(2)]
        public string? OcInfo05 { get; set; }
        [Column("Oc Info 06")]
        [StringLength(2)]
        public string? OcInfo06 { get; set; }
        [Column("Oc Info 07")]
        [StringLength(2)]
        public string? OcInfo07 { get; set; }
        [Column("Oc Info 08")]
        [StringLength(2)]
        public string? OcInfo08 { get; set; }
        [Column("Oc Info 09")]
        [StringLength(2)]
        public string? OcInfo09 { get; set; }
        [Column("Oci Supplementary Custom 01")]
        [StringLength(50)]
        public string? OciSupplementaryCustom01 { get; set; }
        [Column("Oci Supplementary Custom 02")]
        [StringLength(50)]
        public string? OciSupplementaryCustom02 { get; set; }
        [Column("Oci Supplementary Custom 03")]
        [StringLength(50)]
        public string? OciSupplementaryCustom03 { get; set; }
        [Column("Oci Supplementary Custom 04")]
        [StringLength(50)]
        public string? OciSupplementaryCustom04 { get; set; }
        [Column("Oci Supplementary Custom 05")]
        [StringLength(50)]
        public string? OciSupplementaryCustom05 { get; set; }
        [Column("Oci Supplementary Custom 06")]
        [StringLength(50)]
        public string? OciSupplementaryCustom06 { get; set; }
        [Column("Oci Supplementary Custom 07")]
        [StringLength(50)]
        public string? OciSupplementaryCustom07 { get; set; }
        [Column("Oci Supplementary Custom 08")]
        [StringLength(50)]
        public string? OciSupplementaryCustom08 { get; set; }
        [Column("Oci Supplementary Custom 09")]
        [StringLength(50)]
        public string? OciSupplementaryCustom09 { get; set; }
        public int? Pcs { get; set; }
        [Column("Special Handling Code 01")]
        [StringLength(3)]
        public string? SpecialHandlingCode01 { get; set; }
        [Column("Special Handling Code 02")]
        [StringLength(3)]
        public string? SpecialHandlingCode02 { get; set; }
        [Column("Special Handling Code 03")]
        [StringLength(3)]
        public string? SpecialHandlingCode03 { get; set; }
        [Column("Special Handling Code 04")]
        [StringLength(3)]
        public string? SpecialHandlingCode04 { get; set; }
        [Column("Special Handling Code 05")]
        [StringLength(3)]
        public string? SpecialHandlingCode05 { get; set; }
        [Column("Special Handling Code 06")]
        [StringLength(3)]
        public string? SpecialHandlingCode06 { get; set; }
        [Column("Special Handling Code 07")]
        [StringLength(3)]
        public string? SpecialHandlingCode07 { get; set; }
        [Column("Special Handling Code 08")]
        [StringLength(3)]
        public string? SpecialHandlingCode08 { get; set; }
        [Column("Special Handling Code 09")]
        [StringLength(3)]
        public string? SpecialHandlingCode09 { get; set; }
        [Column("Shipper Name")]
        [StringLength(35)]
        public string? ShipperName { get; set; }
        [Column("Shipper Address")]
        [StringLength(35)]
        public string? ShipperAddress { get; set; }
        [Column("Shipper Acc Code")]
        [StringLength(14)]
        public string? ShipperAccCode { get; set; }
        [Column("Shipper Country Code")]
        [StringLength(2)]
        public string? ShipperCountryCode { get; set; }
        [Column("Shipper Fax No")]
        [StringLength(25)]
        public string? ShipperFaxNo { get; set; }
        [Column("Shipper Place")]
        [StringLength(17)]
        public string? ShipperPlace { get; set; }
        [Column("Shipper Post Code")]
        [StringLength(9)]
        public string? ShipperPostCode { get; set; }
        [Column("Shipper State")]
        [StringLength(9)]
        public string? ShipperState { get; set; }
        [Column("Shipper Tel No")]
        [StringLength(25)]
        public string? ShipperTelNo { get; set; }
        [Column("Volumetric Weight", TypeName = "decimal(13, 4)")]
        public decimal? VolumetricWeight { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [StringLength(3)]
        public string Status { get; set; } = null!;
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
