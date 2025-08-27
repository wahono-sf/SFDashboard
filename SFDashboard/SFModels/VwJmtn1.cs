using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmtn1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string JobNo { get; set; } = null!;
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Amended Field Count", TypeName = "decimal(2, 0)")]
        public decimal? AmendedFieldCount { get; set; }
        [Column("Amend Reason 1")]
        [StringLength(70)]
        public string? AmendReason1 { get; set; }
        [Column("Amend Reason 2")]
        [StringLength(70)]
        public string? AmendReason2 { get; set; }
        [Column("Amend Reason 3")]
        [StringLength(70)]
        public string? AmendReason3 { get; set; }
        [Column("Amend Reason 4")]
        [StringLength(70)]
        public string? AmendReason4 { get; set; }
        [Column("App Product Type")]
        [StringLength(2)]
        public string? AppProductType { get; set; }
        [Column("Approve Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ApproveDate { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Awb Bl No")]
        [StringLength(20)]
        public string? AwbBlNo { get; set; }
        [Column("Bg Ind Flag")]
        [StringLength(3)]
        public string? BgIndFlag { get; set; }
        [Column("Blanket Start Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? BlanketStartDate { get; set; }
        [Column("Ca App Date Time")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CaAppDateTime { get; set; }
        [Column("Ca License No 1")]
        [StringLength(35)]
        public string? CaLicenseNo1 { get; set; }
        [Column("Ca License No 2")]
        [StringLength(35)]
        public string? CaLicenseNo2 { get; set; }
        [Column("Ca License No 3")]
        [StringLength(35)]
        public string? CaLicenseNo3 { get; set; }
        [Column("Ca License No 4")]
        [StringLength(35)]
        public string? CaLicenseNo4 { get; set; }
        [Column("Ca License No 5")]
        [StringLength(35)]
        public string? CaLicenseNo5 { get; set; }
        [Column("Cert Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CertDate { get; set; }
        [Column("Cert Detail Line 1")]
        [StringLength(35)]
        public string? CertDetailLine1 { get; set; }
        [Column("Cert Detail Line 2")]
        [StringLength(35)]
        public string? CertDetailLine2 { get; set; }
        [Column("Cert Detail Line 3")]
        [StringLength(35)]
        public string? CertDetailLine3 { get; set; }
        [Column("Cert Detail Line 4")]
        [StringLength(35)]
        public string? CertDetailLine4 { get; set; }
        [Column("Cert Detail Line 5")]
        [StringLength(35)]
        public string? CertDetailLine5 { get; set; }
        [Column("Cert Info 01 Line 01")]
        [StringLength(35)]
        public string? CertInfo01Line01 { get; set; }
        [Column("Cert Info 01 Line 02")]
        [StringLength(35)]
        public string? CertInfo01Line02 { get; set; }
        [Column("Cert Info 01 Line 03")]
        [StringLength(35)]
        public string? CertInfo01Line03 { get; set; }
        [Column("Cert Info 01 Line 04")]
        [StringLength(35)]
        public string? CertInfo01Line04 { get; set; }
        [Column("Cert Info 01 Line 05")]
        [StringLength(35)]
        public string? CertInfo01Line05 { get; set; }
        [Column("Cert Info 02 Line 01")]
        [StringLength(35)]
        public string? CertInfo02Line01 { get; set; }
        [Column("Cert Info 02 Line 02")]
        [StringLength(35)]
        public string? CertInfo02Line02 { get; set; }
        [Column("Cert Info 02 Line 03")]
        [StringLength(35)]
        public string? CertInfo02Line03 { get; set; }
        [Column("Cert Info 02 Line 04")]
        [StringLength(35)]
        public string? CertInfo02Line04 { get; set; }
        [Column("Cert Info 02 Line 05")]
        [StringLength(35)]
        public string? CertInfo02Line05 { get; set; }
        [Column("Cert Info 03 Line 01")]
        [StringLength(35)]
        public string? CertInfo03Line01 { get; set; }
        [Column("Cert Info 03 Line 02")]
        [StringLength(35)]
        public string? CertInfo03Line02 { get; set; }
        [Column("Cert Info 03 Line 03")]
        [StringLength(35)]
        public string? CertInfo03Line03 { get; set; }
        [Column("Cert Info 03 Line 04")]
        [StringLength(35)]
        public string? CertInfo03Line04 { get; set; }
        [Column("Cert Info 03 Line 05")]
        [StringLength(35)]
        public string? CertInfo03Line05 { get; set; }
        [Column("Cert Info 04 Line 01")]
        [StringLength(35)]
        public string? CertInfo04Line01 { get; set; }
        [Column("Cert Info 04 Line 02")]
        [StringLength(35)]
        public string? CertInfo04Line02 { get; set; }
        [Column("Cert Info 04 Line 03")]
        [StringLength(35)]
        public string? CertInfo04Line03 { get; set; }
        [Column("Cert Info 04 Line 04")]
        [StringLength(35)]
        public string? CertInfo04Line04 { get; set; }
        [Column("Cert Info 04 Line 05")]
        [StringLength(35)]
        public string? CertInfo04Line05 { get; set; }
        [Column("Cert Info 05 Line 01")]
        [StringLength(35)]
        public string? CertInfo05Line01 { get; set; }
        [Column("Cert Info 05 Line 02")]
        [StringLength(35)]
        public string? CertInfo05Line02 { get; set; }
        [Column("Cert Info 05 Line 03")]
        [StringLength(35)]
        public string? CertInfo05Line03 { get; set; }
        [Column("Cert Info 05 Line 04")]
        [StringLength(35)]
        public string? CertInfo05Line04 { get; set; }
        [Column("Cert Info 05 Line 05")]
        [StringLength(35)]
        public string? CertInfo05Line05 { get; set; }
        [Column("Cert No")]
        [StringLength(17)]
        public string? CertNo { get; set; }
        [Column("Cert Seq No 1", TypeName = "decimal(4, 0)")]
        public decimal? CertSeqNo1 { get; set; }
        [Column("Cert Seq No 2", TypeName = "decimal(4, 0)")]
        public decimal? CertSeqNo2 { get; set; }
        [Column("Cert Type 1")]
        [StringLength(2)]
        public string? CertType1 { get; set; }
        [Column("Cert Type 2")]
        [StringLength(2)]
        public string? CertType2 { get; set; }
        [Column("Claimant Code")]
        [StringLength(17)]
        public string? ClaimantCode { get; set; }
        [Column("Claimant Company 01")]
        [StringLength(50)]
        public string? ClaimantCompany01 { get; set; }
        [Column("Claimant Company 02")]
        [StringLength(50)]
        public string? ClaimantCompany02 { get; set; }
        [Column("Claimant Name")]
        [StringLength(100)]
        public string? ClaimantName { get; set; }
        [Column("Claimant UEN")]
        [StringLength(17)]
        public string? ClaimantUen { get; set; }
        [Column("Co Flag")]
        [StringLength(1)]
        public string? CoFlag { get; set; }
        [Column("Consignee Code")]
        [StringLength(17)]
        public string? ConsigneeCode { get; set; }
        [Column("Consignee Name 01")]
        [StringLength(35)]
        public string? ConsigneeName01 { get; set; }
        [Column("Consignee Name 02")]
        [StringLength(35)]
        public string? ConsigneeName02 { get; set; }
        [Column("Consignee Address 01")]
        [StringLength(35)]
        public string? ConsigneeAddress01 { get; set; }
        [Column("Consignee Address 02")]
        [StringLength(35)]
        public string? ConsigneeAddress02 { get; set; }
        [Column("Consignee Address 03")]
        [StringLength(35)]
        public string? ConsigneeAddress03 { get; set; }
        [Column("Consignee City Name")]
        [StringLength(35)]
        public string? ConsigneeCityName { get; set; }
        [Column("Consignee Country Code")]
        [StringLength(2)]
        public string? ConsigneeCountryCode { get; set; }
        [Column("Consignee Postal Code")]
        [StringLength(9)]
        public string? ConsigneePostalCode { get; set; }
        [Column("Consignee Subentity Code")]
        [StringLength(9)]
        public string? ConsigneeSubentityCode { get; set; }
        [Column("Consignee Subentity Name")]
        [StringLength(35)]
        public string? ConsigneeSubentityName { get; set; }
        [Column("Cpc 1 Item 1 PC 1")]
        [StringLength(35)]
        public string? Cpc1Item1Pc1 { get; set; }
        [Column("Cpc 1 Item 1 PC 2")]
        [StringLength(35)]
        public string? Cpc1Item1Pc2 { get; set; }
        [Column("Cpc 1 Item 1 PC 3")]
        [StringLength(35)]
        public string? Cpc1Item1Pc3 { get; set; }
        [Column("Cpc 1 Item 2 PC 1")]
        [StringLength(35)]
        public string? Cpc1Item2Pc1 { get; set; }
        [Column("Cpc 1 Item 2 PC 2")]
        [StringLength(35)]
        public string? Cpc1Item2Pc2 { get; set; }
        [Column("Cpc 1 Item 2 PC 3")]
        [StringLength(35)]
        public string? Cpc1Item2Pc3 { get; set; }
        [Column("Cpc 1 Item 3 PC 1")]
        [StringLength(35)]
        public string? Cpc1Item3Pc1 { get; set; }
        [Column("Cpc 1 Item 3 PC 2")]
        [StringLength(35)]
        public string? Cpc1Item3Pc2 { get; set; }
        [Column("Cpc 1 Item 3 PC 3")]
        [StringLength(35)]
        public string? Cpc1Item3Pc3 { get; set; }
        [Column("Cpc 1 Item 4 PC 1")]
        [StringLength(35)]
        public string? Cpc1Item4Pc1 { get; set; }
        [Column("Cpc 1 Item 4 PC 2")]
        [StringLength(35)]
        public string? Cpc1Item4Pc2 { get; set; }
        [Column("Cpc 1 Item 4 PC 3")]
        [StringLength(35)]
        public string? Cpc1Item4Pc3 { get; set; }
        [Column("Cpc 1 Item 5 PC 1")]
        [StringLength(35)]
        public string? Cpc1Item5Pc1 { get; set; }
        [Column("Cpc 1 Item 5 PC 2")]
        [StringLength(35)]
        public string? Cpc1Item5Pc2 { get; set; }
        [Column("Cpc 1 Item 5 PC 3")]
        [StringLength(35)]
        public string? Cpc1Item5Pc3 { get; set; }
        [Column("Cpc 2 Item 1 PC 1")]
        [StringLength(35)]
        public string? Cpc2Item1Pc1 { get; set; }
        [Column("Cpc 2 Item 1 PC 2")]
        [StringLength(35)]
        public string? Cpc2Item1Pc2 { get; set; }
        [Column("Cpc 2 Item 1 PC 3")]
        [StringLength(35)]
        public string? Cpc2Item1Pc3 { get; set; }
        [Column("Cpc 2 Item 2 PC 1")]
        [StringLength(35)]
        public string? Cpc2Item2Pc1 { get; set; }
        [Column("Cpc 2 Item 2 PC 2")]
        [StringLength(35)]
        public string? Cpc2Item2Pc2 { get; set; }
        [Column("Cpc 2 Item 2 PC 3")]
        [StringLength(35)]
        public string? Cpc2Item2Pc3 { get; set; }
        [Column("Cpc 2 Item 3 PC 1")]
        [StringLength(35)]
        public string? Cpc2Item3Pc1 { get; set; }
        [Column("Cpc 2 Item 3 PC 2")]
        [StringLength(35)]
        public string? Cpc2Item3Pc2 { get; set; }
        [Column("Cpc 2 Item 3 PC 3")]
        [StringLength(35)]
        public string? Cpc2Item3Pc3 { get; set; }
        [Column("Cpc 2 Item 4 PC 1")]
        [StringLength(35)]
        public string? Cpc2Item4Pc1 { get; set; }
        [Column("Cpc 2 Item 4 PC 2")]
        [StringLength(35)]
        public string? Cpc2Item4Pc2 { get; set; }
        [Column("Cpc 2 Item 4 PC 3")]
        [StringLength(35)]
        public string? Cpc2Item4Pc3 { get; set; }
        [Column("Cpc 2 Item 5 PC 1")]
        [StringLength(35)]
        public string? Cpc2Item5Pc1 { get; set; }
        [Column("Cpc 2 Item 5 PC 2")]
        [StringLength(35)]
        public string? Cpc2Item5Pc2 { get; set; }
        [Column("Cpc 2 Item 5 PC 3")]
        [StringLength(35)]
        public string? Cpc2Item5Pc3 { get; set; }
        [Column("Cpc 3 Item 1 PC 1")]
        [StringLength(35)]
        public string? Cpc3Item1Pc1 { get; set; }
        [Column("Cpc 3 Item 1 PC 2")]
        [StringLength(35)]
        public string? Cpc3Item1Pc2 { get; set; }
        [Column("Cpc 3 Item 1 PC 3")]
        [StringLength(35)]
        public string? Cpc3Item1Pc3 { get; set; }
        [Column("Cpc 3 Item 2 PC 1")]
        [StringLength(35)]
        public string? Cpc3Item2Pc1 { get; set; }
        [Column("Cpc 3 Item 2 PC 2")]
        [StringLength(35)]
        public string? Cpc3Item2Pc2 { get; set; }
        [Column("Cpc 3 Item 2 PC 3")]
        [StringLength(35)]
        public string? Cpc3Item2Pc3 { get; set; }
        [Column("Cpc 3 Item 3 PC 1")]
        [StringLength(35)]
        public string? Cpc3Item3Pc1 { get; set; }
        [Column("Cpc 3 Item 3 PC 2")]
        [StringLength(35)]
        public string? Cpc3Item3Pc2 { get; set; }
        [Column("Cpc 3 Item 3 PC 3")]
        [StringLength(35)]
        public string? Cpc3Item3Pc3 { get; set; }
        [Column("Cpc 3 Item 4 PC 1")]
        [StringLength(35)]
        public string? Cpc3Item4Pc1 { get; set; }
        [Column("Cpc 3 Item 4 PC 2")]
        [StringLength(35)]
        public string? Cpc3Item4Pc2 { get; set; }
        [Column("Cpc 3 Item 4 PC 3")]
        [StringLength(35)]
        public string? Cpc3Item4Pc3 { get; set; }
        [Column("Cpc 3 Item 5 PC 1")]
        [StringLength(35)]
        public string? Cpc3Item5Pc1 { get; set; }
        [Column("Cpc 3 Item 5 PC 2")]
        [StringLength(35)]
        public string? Cpc3Item5Pc2 { get; set; }
        [Column("Cpc 3 Item 5 PC 3")]
        [StringLength(35)]
        public string? Cpc3Item5Pc3 { get; set; }
        [Column("Cpc 4 Item 1 PC 1")]
        [StringLength(35)]
        public string? Cpc4Item1Pc1 { get; set; }
        [Column("Cpc 4 Item 1 PC 2")]
        [StringLength(35)]
        public string? Cpc4Item1Pc2 { get; set; }
        [Column("Cpc 4 Item 1 PC 3")]
        [StringLength(35)]
        public string? Cpc4Item1Pc3 { get; set; }
        [Column("Cpc 4 Item 2 PC 1")]
        [StringLength(35)]
        public string? Cpc4Item2Pc1 { get; set; }
        [Column("Cpc 4 Item 2 PC 2")]
        [StringLength(35)]
        public string? Cpc4Item2Pc2 { get; set; }
        [Column("Cpc 4 Item 2 PC 3")]
        [StringLength(35)]
        public string? Cpc4Item2Pc3 { get; set; }
        [Column("Cpc 4 Item 3 PC 1")]
        [StringLength(35)]
        public string? Cpc4Item3Pc1 { get; set; }
        [Column("Cpc 4 Item 3 PC 2")]
        [StringLength(35)]
        public string? Cpc4Item3Pc2 { get; set; }
        [Column("Cpc 4 Item 3 PC 3")]
        [StringLength(35)]
        public string? Cpc4Item3Pc3 { get; set; }
        [Column("Cpc 4 Item 4 PC 1")]
        [StringLength(35)]
        public string? Cpc4Item4Pc1 { get; set; }
        [Column("Cpc 4 Item 4 PC 2")]
        [StringLength(35)]
        public string? Cpc4Item4Pc2 { get; set; }
        [Column("Cpc 4 Item 4 PC 3")]
        [StringLength(35)]
        public string? Cpc4Item4Pc3 { get; set; }
        [Column("Cpc 4 Item 5 PC 1")]
        [StringLength(35)]
        public string? Cpc4Item5Pc1 { get; set; }
        [Column("Cpc 4 Item 5 PC 2")]
        [StringLength(35)]
        public string? Cpc4Item5Pc2 { get; set; }
        [Column("Cpc 4 Item 5 PC 3")]
        [StringLength(35)]
        public string? Cpc4Item5Pc3 { get; set; }
        [Column("Cpc 5 Item 1 PC 1")]
        [StringLength(35)]
        public string? Cpc5Item1Pc1 { get; set; }
        [Column("Cpc 5 Item 1 PC 2")]
        [StringLength(35)]
        public string? Cpc5Item1Pc2 { get; set; }
        [Column("Cpc 5 Item 1 PC 3")]
        [StringLength(35)]
        public string? Cpc5Item1Pc3 { get; set; }
        [Column("Cpc 5 Item 2 PC 1")]
        [StringLength(35)]
        public string? Cpc5Item2Pc1 { get; set; }
        [Column("Cpc 5 Item 2 PC 2")]
        [StringLength(35)]
        public string? Cpc5Item2Pc2 { get; set; }
        [Column("Cpc 5 Item 2 PC 3")]
        [StringLength(35)]
        public string? Cpc5Item2Pc3 { get; set; }
        [Column("Cpc 5 Item 3 PC 1")]
        [StringLength(35)]
        public string? Cpc5Item3Pc1 { get; set; }
        [Column("Cpc 5 Item 3 PC 2")]
        [StringLength(35)]
        public string? Cpc5Item3Pc2 { get; set; }
        [Column("Cpc 5 Item 3 PC 3")]
        [StringLength(35)]
        public string? Cpc5Item3Pc3 { get; set; }
        [Column("Cpc 5 Item 4 PC 1")]
        [StringLength(35)]
        public string? Cpc5Item4Pc1 { get; set; }
        [Column("Cpc 5 Item 4 PC 2")]
        [StringLength(35)]
        public string? Cpc5Item4Pc2 { get; set; }
        [Column("Cpc 5 Item 4 PC 3")]
        [StringLength(35)]
        public string? Cpc5Item4Pc3 { get; set; }
        [Column("Cpc 5 Item 5 PC 1")]
        [StringLength(35)]
        public string? Cpc5Item5Pc1 { get; set; }
        [Column("Cpc 5 Item 5 PC 2")]
        [StringLength(35)]
        public string? Cpc5Item5Pc2 { get; set; }
        [Column("Cpc 5 Item 5 PC 3")]
        [StringLength(35)]
        public string? Cpc5Item5Pc3 { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(13, 6)")]
        public decimal? CurrRate { get; set; }
        [Column("Custom Duty Amt", TypeName = "decimal(13, 2)")]
        public decimal? CustomDutyAmt { get; set; }
        [Column("Customs Procedure Code 1")]
        [StringLength(7)]
        public string? CustomsProcedureCode1 { get; set; }
        [Column("Customs Procedure Code 2")]
        [StringLength(7)]
        public string? CustomsProcedureCode2 { get; set; }
        [Column("Customs Procedure Code 3")]
        [StringLength(7)]
        public string? CustomsProcedureCode3 { get; set; }
        [Column("Customs Procedure Code 4")]
        [StringLength(7)]
        public string? CustomsProcedureCode4 { get; set; }
        [Column("Customs Procedure Code 5")]
        [StringLength(7)]
        public string? CustomsProcedureCode5 { get; set; }
        [Column("Dclr Code")]
        [StringLength(3)]
        public string? DclrCode { get; set; }
        [Column("Dclr Ind Flag")]
        [StringLength(1)]
        public string? DclrIndFlag { get; set; }
        [Column("Declarant Party Code")]
        [StringLength(20)]
        public string? DeclarantPartyCode { get; set; }
        [Column("Declaration Code")]
        [StringLength(3)]
        public string? DeclarationCode { get; set; }
        [Column("Declare By")]
        [StringLength(20)]
        public string? DeclareBy { get; set; }
        [Column("Delivery Order No")]
        [StringLength(20)]
        public string? DeliveryOrderNo { get; set; }
        [Column("Doc File Name 01")]
        [StringLength(70)]
        public string? DocFileName01 { get; set; }
        [Column("Doc File Name 02")]
        [StringLength(70)]
        public string? DocFileName02 { get; set; }
        [Column("Doc File Name 03")]
        [StringLength(70)]
        public string? DocFileName03 { get; set; }
        [Column("Doc File Name 04")]
        [StringLength(70)]
        public string? DocFileName04 { get; set; }
        [Column("Doc File Name 05")]
        [StringLength(70)]
        public string? DocFileName05 { get; set; }
        [Column("Doc File Name 06")]
        [StringLength(70)]
        public string? DocFileName06 { get; set; }
        [Column("Doc File Name 07")]
        [StringLength(70)]
        public string? DocFileName07 { get; set; }
        [Column("Doc File Name 08")]
        [StringLength(70)]
        public string? DocFileName08 { get; set; }
        [Column("Doc File Name 09")]
        [StringLength(70)]
        public string? DocFileName09 { get; set; }
        [Column("Doc File Name 10")]
        [StringLength(70)]
        public string? DocFileName10 { get; set; }
        [Column("Doc Type 01")]
        [StringLength(35)]
        public string? DocType01 { get; set; }
        [Column("Doc Type 02")]
        [StringLength(35)]
        public string? DocType02 { get; set; }
        [Column("Doc Type 03")]
        [StringLength(35)]
        public string? DocType03 { get; set; }
        [Column("Doc Type 04")]
        [StringLength(35)]
        public string? DocType04 { get; set; }
        [Column("Doc Type 05")]
        [StringLength(35)]
        public string? DocType05 { get; set; }
        [Column("Doc Type 06")]
        [StringLength(35)]
        public string? DocType06 { get; set; }
        [Column("Doc Type 07")]
        [StringLength(35)]
        public string? DocType07 { get; set; }
        [Column("Doc Type 08")]
        [StringLength(35)]
        public string? DocType08 { get; set; }
        [Column("Doc Type 09")]
        [StringLength(35)]
        public string? DocType09 { get; set; }
        [Column("Doc Type 10")]
        [StringLength(35)]
        public string? DocType10 { get; set; }
        [Column("End Date Of Exhibition")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EndDateOfExhibition { get; set; }
        [Column("End User Code")]
        [StringLength(17)]
        public string? EndUserCode { get; set; }
        [Column("End User Name 01")]
        [StringLength(50)]
        public string? EndUserName01 { get; set; }
        [Column("End User Name 02")]
        [StringLength(50)]
        public string? EndUserName02 { get; set; }
        [Column("End User Address 01")]
        [StringLength(35)]
        public string? EndUserAddress01 { get; set; }
        [Column("End User Address 02")]
        [StringLength(35)]
        public string? EndUserAddress02 { get; set; }
        [Column("End User City Name")]
        [StringLength(35)]
        public string? EndUserCityName { get; set; }
        [Column("End User Country Code")]
        [StringLength(2)]
        public string? EndUserCountryCode { get; set; }
        [Column("End User Postal Code")]
        [StringLength(9)]
        public string? EndUserPostalCode { get; set; }
        [Column("End User Subentity Code")]
        [StringLength(9)]
        public string? EndUserSubentityCode { get; set; }
        [Column("End User Subentity Name")]
        [StringLength(35)]
        public string? EndUserSubentityName { get; set; }
        [Column("Entry Year", TypeName = "decimal(4, 0)")]
        public decimal? EntryYear { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Eta { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Etd { get; set; }
        [Column("Excise Amt", TypeName = "decimal(13, 2)")]
        public decimal? ExciseAmt { get; set; }
        [Column("Exporter Code")]
        [StringLength(17)]
        public string? ExporterCode { get; set; }
        [Column("Exporter Name 01")]
        [StringLength(35)]
        public string? ExporterName01 { get; set; }
        [Column("Exporter Name 02")]
        [StringLength(35)]
        public string? ExporterName02 { get; set; }
        [Column("Exporter Address 01")]
        [StringLength(35)]
        public string? ExporterAddress01 { get; set; }
        [Column("Exporter Address 02")]
        [StringLength(35)]
        public string? ExporterAddress02 { get; set; }
        [Column("Exporter City Name")]
        [StringLength(35)]
        public string? ExporterCityName { get; set; }
        [Column("Exporter Country Code")]
        [StringLength(2)]
        public string? ExporterCountryCode { get; set; }
        [Column("Exporter CRUEI")]
        [StringLength(17)]
        public string? ExporterCruei { get; set; }
        [Column("Exporter Postal Code")]
        [StringLength(9)]
        public string? ExporterPostalCode { get; set; }
        [Column("Exporter Subentity Code")]
        [StringLength(9)]
        public string? ExporterSubentityCode { get; set; }
        [Column("Exporter Subentity Name")]
        [StringLength(35)]
        public string? ExporterSubentityName { get; set; }
        [Column("Ext Reason Code")]
        [StringLength(1)]
        public string? ExtReasonCode { get; set; }
        [Column("Ext Reason 1")]
        [StringLength(70)]
        public string? ExtReason1 { get; set; }
        [Column("Ext Reason 2")]
        [StringLength(70)]
        public string? ExtReason2 { get; set; }
        [Column("Ext Reason 3")]
        [StringLength(70)]
        public string? ExtReason3 { get; set; }
        [Column("Ext Reason 4")]
        [StringLength(70)]
        public string? ExtReason4 { get; set; }
        [Column("Fee Amt", TypeName = "decimal(13, 2)")]
        public decimal? FeeAmt { get; set; }
        [Column("Feeder Vessel Name")]
        [StringLength(50)]
        public string? FeederVesselName { get; set; }
        [Column("Feeder Voyage")]
        [StringLength(17)]
        public string? FeederVoyage { get; set; }
        [Column("Final Dest Code")]
        [StringLength(3)]
        public string? FinalDestCode { get; set; }
        [Column("First Via Port Code")]
        [StringLength(5)]
        public string? FirstViaPortCode { get; set; }
        [Column("Freight Forwarder Code")]
        [StringLength(17)]
        public string? FreightForwarderCode { get; set; }
        [Column("Freight Forwarder Name 01")]
        [StringLength(50)]
        public string? FreightForwarderName01 { get; set; }
        [Column("Freight Forwarder Name 02")]
        [StringLength(50)]
        public string? FreightForwarderName02 { get; set; }
        [Column("Freight Forwarder CRUEI")]
        [StringLength(17)]
        public string? FreightForwarderCruei { get; set; }
        [Column("Gross Wt", TypeName = "decimal(15, 3)")]
        public decimal? GrossWt { get; set; }
        [Column("Gross Wt Uom Code")]
        [StringLength(3)]
        public string? GrossWtUomCode { get; set; }
        [Column("Gsp Donor Country")]
        [StringLength(2)]
        public string? GspDonorCountry { get; set; }
        [Column("Gst Amt", TypeName = "decimal(15, 2)")]
        public decimal? GstAmt { get; set; }
        [Column("Gst Code")]
        [StringLength(3)]
        public string? GstCode { get; set; }
        [Column("Gst Recoverable Flag")]
        [StringLength(1)]
        public string? GstRecoverableFlag { get; set; }
        [Column("Handling Agent Code")]
        [StringLength(17)]
        public string? HandlingAgentCode { get; set; }
        [Column("Handling Agent Name 01")]
        [StringLength(50)]
        public string? HandlingAgentName01 { get; set; }
        [Column("Handling Agent Name 02")]
        [StringLength(50)]
        public string? HandlingAgentName02 { get; set; }
        [Column("Handling Agent CRUEI")]
        [StringLength(17)]
        public string? HandlingAgentCruei { get; set; }
        [StringLength(8)]
        public string? Importer { get; set; }
        [Column("Importer Code")]
        [StringLength(17)]
        public string? ImporterCode { get; set; }
        [Column("Importer Name 01")]
        [StringLength(50)]
        public string? ImporterName01 { get; set; }
        [Column("Importer Name 02")]
        [StringLength(50)]
        public string? ImporterName02 { get; set; }
        [Column("Importer CRUEI")]
        [StringLength(17)]
        public string? ImporterCruei { get; set; }
        [Column("In Conveyance Ref No")]
        [StringLength(17)]
        public string? InConveyanceRefNo { get; set; }
        [Column("In Mawb Obl No")]
        [StringLength(20)]
        public string? InMawbOblNo { get; set; }
        [Column("In Module Code")]
        [StringLength(2)]
        public string? InModuleCode { get; set; }
        [Column("In Transport Identifier")]
        [StringLength(35)]
        public string? InTransportIdentifier { get; set; }
        [Column("In Vessel Loc Code")]
        [StringLength(7)]
        public string? InVesselLocCode { get; set; }
        [Column("In Vessel Loc Name")]
        [StringLength(105)]
        public string? InVesselLocName { get; set; }
        [Column("In Vessel Name")]
        [StringLength(50)]
        public string? InVesselName { get; set; }
        [Column("Inward Carrier Agent Code")]
        [StringLength(17)]
        public string? InwardCarrierAgentCode { get; set; }
        [Column("Inward Carrier Agent Name 01")]
        [StringLength(50)]
        public string? InwardCarrierAgentName01 { get; set; }
        [Column("Inward Carrier Agent Name 02")]
        [StringLength(50)]
        public string? InwardCarrierAgentName02 { get; set; }
        [Column("Inward Carrier Agent CRUEI")]
        [StringLength(17)]
        public string? InwardCarrierAgentCruei { get; set; }
        [Column("Issue Auth ID")]
        [StringLength(17)]
        public string? IssueAuthId { get; set; }
        [Column("Manufacturer Address 01")]
        [StringLength(35)]
        public string? ManufacturerAddress01 { get; set; }
        [Column("Manufacturer Address 02")]
        [StringLength(35)]
        public string? ManufacturerAddress02 { get; set; }
        [Column("Manufacturer City Name")]
        [StringLength(35)]
        public string? ManufacturerCityName { get; set; }
        [Column("Manufacturer Code")]
        [StringLength(17)]
        public string? ManufacturerCode { get; set; }
        [Column("Manufacturer Country Code")]
        [StringLength(2)]
        public string? ManufacturerCountryCode { get; set; }
        [Column("Manufacturer Name 01")]
        [StringLength(35)]
        public string? ManufacturerName01 { get; set; }
        [Column("Manufacturer Name 02")]
        [StringLength(35)]
        public string? ManufacturerName02 { get; set; }
        [Column("Manufacturer Postal Code")]
        [StringLength(9)]
        public string? ManufacturerPostalCode { get; set; }
        [Column("Manufacturer Subentity Code")]
        [StringLength(9)]
        public string? ManufacturerSubentityCode { get; set; }
        [Column("Manufacturer Subentity Name")]
        [StringLength(35)]
        public string? ManufacturerSubentityName { get; set; }
        [Column("Mawb Obl No")]
        [StringLength(20)]
        public string? MawbOblNo { get; set; }
        [Column("MESFlag")]
        [StringLength(1)]
        public string? Mesflag { get; set; }
        [Column("Mindef Flag")]
        [StringLength(1)]
        public string? MindefFlag { get; set; }
        [Column("Module Code")]
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [Column("No Of Copy 1", TypeName = "decimal(2, 0)")]
        public decimal? NoOfCopy1 { get; set; }
        [Column("No Of Copy 2", TypeName = "decimal(2, 0)")]
        public decimal? NoOfCopy2 { get; set; }
        [Column("NRT", TypeName = "decimal(15, 3)")]
        public decimal? Nrt { get; set; }
        [Column("Org App Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? OrgAppDate { get; set; }
        [Column("Out Conveyance Ref No")]
        [StringLength(17)]
        public string? OutConveyanceRefNo { get; set; }
        [Column("Out Mawb Obl No")]
        [StringLength(20)]
        public string? OutMawbOblNo { get; set; }
        [Column("Out Module Code")]
        [StringLength(2)]
        public string? OutModuleCode { get; set; }
        [Column("Out Transport Identifier")]
        [StringLength(35)]
        public string? OutTransportIdentifier { get; set; }
        [Column("Out Vessel Loc Code")]
        [StringLength(7)]
        public string? OutVesselLocCode { get; set; }
        [Column("Out Vessel Loc Name")]
        [StringLength(105)]
        public string? OutVesselLocName { get; set; }
        [Column("Outward Carrier Agent Code")]
        [StringLength(17)]
        public string? OutwardCarrierAgentCode { get; set; }
        [Column("Outward Carrier Agent Name 01")]
        [StringLength(50)]
        public string? OutwardCarrierAgentName01 { get; set; }
        [Column("Outward Carrier Agent Name 02")]
        [StringLength(50)]
        public string? OutwardCarrierAgentName02 { get; set; }
        [Column("Outward Carrier Agent CRUEI")]
        [StringLength(17)]
        public string? OutwardCarrierAgentCruei { get; set; }
        [Column("Pack Type")]
        [StringLength(3)]
        public string? PackType { get; set; }
        [Column("Percent Content", TypeName = "decimal(3, 0)")]
        public decimal? PercentContent { get; set; }
        [Column("Permit App Date Time")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PermitAppDateTime { get; set; }
        [Column("Permit Code")]
        [StringLength(6)]
        public string? PermitCode { get; set; }
        [Column("Permit Count")]
        public int? PermitCount { get; set; }
        [Column("Permit Desc")]
        [StringLength(75)]
        public string? PermitDesc { get; set; }
        [Column("Permit End Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PermitEndDate { get; set; }
        [Column("Permit Indicator")]
        [StringLength(3)]
        public string? PermitIndicator { get; set; }
        [Column("Permit No")]
        [StringLength(17)]
        public string? PermitNo { get; set; }
        [Column("Permit Start Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PermitStartDate { get; set; }
        [Column("Permit Type")]
        [StringLength(7)]
        public string? PermitType { get; set; }
        [Column("Permit Validity Flag")]
        [StringLength(1)]
        public string? PermitValidityFlag { get; set; }
        [Column("Port Of Discharge Code")]
        [StringLength(5)]
        public string? PortOfDischargeCode { get; set; }
        [Column("Port Of Discharge Name")]
        [StringLength(45)]
        public string? PortOfDischargeName { get; set; }
        [Column("Port Of Loading Code")]
        [StringLength(5)]
        public string? PortOfLoadingCode { get; set; }
        [Column("Prev Permit No")]
        [StringLength(35)]
        public string? PrevPermitNo { get; set; }
        public int? Qty { get; set; }
        [Column("Rcp Loc Code")]
        [StringLength(7)]
        public string? RcpLocCode { get; set; }
        [Column("Rcp Loc Name")]
        [StringLength(256)]
        public string? RcpLocName { get; set; }
        [Column("Recipient Mbx 1")]
        [StringLength(17)]
        public string? RecipientMbx1 { get; set; }
        [Column("Recipient Mbx 2")]
        [StringLength(17)]
        public string? RecipientMbx2 { get; set; }
        [Column("Recipient Mbx 3")]
        [StringLength(17)]
        public string? RecipientMbx3 { get; set; }
        [Column("Ref No")]
        [StringLength(30)]
        public string? RefNo { get; set; }
        [Column("Refund Code")]
        [StringLength(4)]
        public string? RefundCode { get; set; }
        [Column("Refund Reason 1")]
        [StringLength(70)]
        public string? RefundReason1 { get; set; }
        [Column("Refund Reason 2")]
        [StringLength(70)]
        public string? RefundReason2 { get; set; }
        [Column("Refund Reason 3")]
        [StringLength(70)]
        public string? RefundReason3 { get; set; }
        [Column("Refund Reason 4")]
        [StringLength(70)]
        public string? RefundReason4 { get; set; }
        [Column("Rel Loc Code")]
        [StringLength(7)]
        public string? RelLocCode { get; set; }
        [Column("Rel Loc Name")]
        [StringLength(256)]
        public string? RelLocName { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Remark 1 Line 1")]
        [StringLength(512)]
        public string? Remark1Line1 { get; set; }
        [Column("Remark 1 Line 2")]
        [StringLength(512)]
        public string? Remark1Line2 { get; set; }
        [Column("Remark 2 Line 1")]
        [StringLength(512)]
        public string? Remark2Line1 { get; set; }
        [Column("Remark 2 Line 2")]
        [StringLength(512)]
        public string? Remark2Line2 { get; set; }
        [Column("Remark 3 Line 1")]
        [StringLength(512)]
        public string? Remark3Line1 { get; set; }
        [Column("Remark 3 Line 2")]
        [StringLength(512)]
        public string? Remark3Line2 { get; set; }
        [Column("Remark 4 Line 1")]
        [StringLength(512)]
        public string? Remark4Line1 { get; set; }
        [Column("Remark 4 Line 2")]
        [StringLength(512)]
        public string? Remark4Line2 { get; set; }
        [Column("Remark 5 Line 1")]
        [StringLength(512)]
        public string? Remark5Line1 { get; set; }
        [Column("Remark 5 Line 2")]
        [StringLength(512)]
        public string? Remark5Line2 { get; set; }
        [Column("Removal Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? RemovalDate { get; set; }
        [Column("Replace Permit No")]
        [StringLength(11)]
        public string? ReplacePermitNo { get; set; }
        [Column("Save Status")]
        [StringLength(3)]
        public string? SaveStatus { get; set; }
        [Column("Send Flag")]
        [StringLength(1)]
        public string? SendFlag { get; set; }
        [Column("Start Date Of Exhibition")]
        [StringLength(10)]
        [Unicode(false)]
        public string? StartDateOfExhibition { get; set; }
        [Column("Str Loc Code")]
        [StringLength(7)]
        public string? StrLocCode { get; set; }
        [Column("Submission Datetime")]
        [StringLength(10)]
        [Unicode(false)]
        public string? SubmissionDatetime { get; set; }
        [Column("Supplier Ind Flag")]
        [StringLength(1)]
        public string? SupplierIndFlag { get; set; }
        [Column("Tn Agent Flag")]
        [StringLength(1)]
        public string? TnAgentFlag { get; set; }
        [Column("Total Amt", TypeName = "decimal(16, 2)")]
        public decimal? TotalAmt { get; set; }
        [Column("Total Ciffob Amt", TypeName = "decimal(16, 2)")]
        public decimal? TotalCiffobAmt { get; set; }
        [Column("Total Customs Amt", TypeName = "decimal(16, 2)")]
        public decimal? TotalCustomsAmt { get; set; }
        [Column("Total Customs Refund Amt", TypeName = "decimal(16, 2)")]
        public decimal? TotalCustomsRefundAmt { get; set; }
        [Column("Total Excise Amt", TypeName = "decimal(16, 2)")]
        public decimal? TotalExciseAmt { get; set; }
        [Column("Total Excise Refund Amt", TypeName = "decimal(16, 2)")]
        public decimal? TotalExciseRefundAmt { get; set; }
        [Column("Total Gst Amt", TypeName = "decimal(16, 2)")]
        public decimal? TotalGstAmt { get; set; }
        [Column("Total Gst Refund Amt", TypeName = "decimal(16, 2)")]
        public decimal? TotalGstRefundAmt { get; set; }
        [Column("Total Line Count", TypeName = "decimal(5, 0)")]
        public decimal? TotalLineCount { get; set; }
        [Column("Total Other Amt", TypeName = "decimal(16, 2)")]
        public decimal? TotalOtherAmt { get; set; }
        [Column("Total Other Refund Amt", TypeName = "decimal(16, 2)")]
        public decimal? TotalOtherRefundAmt { get; set; }
        [Column("Total Out Pack Qty", TypeName = "decimal(8, 0)")]
        public decimal? TotalOutPackQty { get; set; }
        [Column("Total Out Pack Qty Uom Code")]
        [StringLength(3)]
        public string? TotalOutPackQtyUomCode { get; set; }
        [Column("Total Payable Amt", TypeName = "decimal(16, 2)")]
        public decimal? TotalPayableAmt { get; set; }
        [Column("Tradenet Remark")]
        [StringLength(255)]
        public string? TradenetRemark { get; set; }
        [Column("Tradenet Type")]
        [StringLength(10)]
        public string? TradenetType { get; set; }
        [Column("Tran Detail Line 1")]
        [StringLength(35)]
        public string? TranDetailLine1 { get; set; }
        [Column("Tran Detail Line 2")]
        [StringLength(35)]
        public string? TranDetailLine2 { get; set; }
        [Column("Tran Detail Line 3")]
        [StringLength(35)]
        public string? TranDetailLine3 { get; set; }
        [Column("Tran Detail Line 4")]
        [StringLength(35)]
        public string? TranDetailLine4 { get; set; }
        [Column("Tran Detail Line 5")]
        [StringLength(35)]
        public string? TranDetailLine5 { get; set; }
        [Column("Trx Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TrxDate { get; set; }
        [Column("UD1 Line 1")]
        [StringLength(102)]
        public string? Ud1Line1 { get; set; }
        [Column("UD1 Line 2")]
        [StringLength(102)]
        public string? Ud1Line2 { get; set; }
        [Column("UD1 Line 3")]
        [StringLength(102)]
        public string? Ud1Line3 { get; set; }
        [Column("UD1 Line 4")]
        [StringLength(102)]
        public string? Ud1Line4 { get; set; }
        [Column("UD1 Line 5")]
        [StringLength(102)]
        public string? Ud1Line5 { get; set; }
        [Column("UD2 Line 1")]
        [StringLength(102)]
        public string? Ud2Line1 { get; set; }
        [Column("UD2 Line 2")]
        [StringLength(102)]
        public string? Ud2Line2 { get; set; }
        [Column("UD2 Line 3")]
        [StringLength(102)]
        public string? Ud2Line3 { get; set; }
        [Column("UD2 Line 4")]
        [StringLength(102)]
        public string? Ud2Line4 { get; set; }
        [Column("UD2 Line 5")]
        [StringLength(102)]
        public string? Ud2Line5 { get; set; }
        [Column("UD3 Line 1")]
        [StringLength(102)]
        public string? Ud3Line1 { get; set; }
        [Column("UD3 Line 2")]
        [StringLength(102)]
        public string? Ud3Line2 { get; set; }
        [Column("UD3 Line 3")]
        [StringLength(102)]
        public string? Ud3Line3 { get; set; }
        [Column("UD3 Line 4")]
        [StringLength(102)]
        public string? Ud3Line4 { get; set; }
        [Column("UD3 Line 5")]
        [StringLength(102)]
        public string? Ud3Line5 { get; set; }
        [Column("Unit Price", TypeName = "decimal(13, 2)")]
        public decimal? UnitPrice { get; set; }
        [Column("Unit Wt", TypeName = "decimal(13, 4)")]
        public decimal? UnitWt { get; set; }
        [Column("Update Ind Flag")]
        [StringLength(3)]
        public string? UpdateIndFlag { get; set; }
        [Column("Update Permit No")]
        [StringLength(11)]
        public string? UpdatePermitNo { get; set; }
        [Column("Update Req Count", TypeName = "decimal(2, 0)")]
        public decimal? UpdateReqCount { get; set; }
        [Column("Vessel Country")]
        [StringLength(2)]
        public string? VesselCountry { get; set; }
        [Column("Vessel Type")]
        [StringLength(2)]
        public string? VesselType { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string? CreatedBy { get; set; }
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string? UpdatedBy { get; set; }
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string? Status { get; set; }
    }
}
