using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("DT_ONHAND")]
    public partial class DtOnhand
    {
        [Column("ADD_TIME", TypeName = "datetime")]
        public DateTime? AddTime { get; set; }
        [Column("BILL_TO_CODE")]
        [StringLength(8)]
        public string? BillToCode { get; set; }
        [Column("BOND_NO")]
        [StringLength(30)]
        public string? BondNo { get; set; }
        [Column("CASE_NO")]
        [StringLength(4)]
        public string? CaseNo { get; set; }
        [Column("CEN_NO")]
        [StringLength(20)]
        public string? CenNo { get; set; }
        [Column("CLSF_YN")]
        [StringLength(2)]
        public string? ClsfYn { get; set; }
        [Column("CLT_CODE")]
        [StringLength(4)]
        public string? CltCode { get; set; }
        [Column("CNG_CODE")]
        [StringLength(8)]
        public string? CngCode { get; set; }
        [Column("CONSIGNEE_ADDR1")]
        [StringLength(36)]
        public string? ConsigneeAddr1 { get; set; }
        [Column("CONSIGNEE_ADDR2")]
        [StringLength(36)]
        public string? ConsigneeAddr2 { get; set; }
        [Column("CONSIGNEE_ADDR3")]
        [StringLength(36)]
        public string? ConsigneeAddr3 { get; set; }
        [Column("CONSIGNEE_ADDR4")]
        [StringLength(36)]
        public string? ConsigneeAddr4 { get; set; }
        [Column("CONSIGNEE_NAME")]
        [StringLength(75)]
        public string? ConsigneeName { get; set; }
        [Column("CONSIGNEE_SECTOR_CODE")]
        [StringLength(2)]
        public string? ConsigneeSectorCode { get; set; }
        [Column("CONSIGNEE_ZIP_CODE")]
        [StringLength(12)]
        public string? ConsigneeZipCode { get; set; }
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [Column("CTRY_CODE")]
        [StringLength(4)]
        public string? CtryCode { get; set; }
        [Column("DATE_ADDED", TypeName = "datetime")]
        public DateTime? DateAdded { get; set; }
        [Column("DATE_ADDED_JOB", TypeName = "datetime")]
        public DateTime? DateAddedJob { get; set; }
        [Column("DATE_CHANGED", TypeName = "datetime")]
        public DateTime? DateChanged { get; set; }
        [Column("DATE_CHANGED_JOB", TypeName = "datetime")]
        public DateTime? DateChangedJob { get; set; }
        [Column("DELV_THRU_PLEXIS")]
        [StringLength(1)]
        public string? DelvThruPlexis { get; set; }
        [Column("DG_IND")]
        [StringLength(2)]
        public string? DgInd { get; set; }
        [Column("ECCN_NO")]
        [StringLength(30)]
        public string? EccnNo { get; set; }
        [Column("FFR_YN")]
        [StringLength(2)]
        public string? FfrYn { get; set; }
        [Column("FMCS_TYPE")]
        [StringLength(2)]
        public string? FmcsType { get; set; }
        [Column("HAZARDOUS_YN")]
        [StringLength(2)]
        public string? HazardousYn { get; set; }
        [Column("ISSUER_CHANGED")]
        [StringLength(8)]
        public string? IssuerChanged { get; set; }
        [Column("ISSUER_CHANGED_JOB")]
        [StringLength(8)]
        public string? IssuerChangedJob { get; set; }
        [Column("ISSUER_CODE")]
        [StringLength(8)]
        public string? IssuerCode { get; set; }
        [Column("ISSUER_CODE_JOB")]
        [StringLength(8)]
        public string? IssuerCodeJob { get; set; }
        [Column("JOB_NUMBER")]
        [StringLength(12)]
        public string? JobNumber { get; set; }
        [Column("JOB_STATUS")]
        [StringLength(2)]
        public string? JobStatus { get; set; }
        [Column("LC_YN")]
        [StringLength(2)]
        public string? LcYn { get; set; }
        [Column("LIC_NO")]
        [StringLength(14)]
        public string? LicNo { get; set; }
        [Column("LOC_CODE")]
        [StringLength(4)]
        public string? LocCode { get; set; }
        [Column("LUPUS_YN")]
        [StringLength(2)]
        public string? LupusYn { get; set; }
        [Column("MINDEF_CONTRACT_REF")]
        [StringLength(16)]
        public string? MindefContractRef { get; set; }
        [Column("NO_DOC_INV", TypeName = "decimal(5, 0)")]
        public decimal? NoDocInv { get; set; }
        [Column("NO_INV_WH", TypeName = "decimal(5, 0)")]
        public decimal? NoInvWh { get; set; }
        [Column("NO_PCS_WH", TypeName = "decimal(3, 0)")]
        public decimal? NoPcsWh { get; set; }
        [Column("ODD_SIZE_IND")]
        [StringLength(2)]
        public string? OddSizeInd { get; set; }
        [Column("OH_HB_STAT")]
        [StringLength(2)]
        public string? OhHbStat { get; set; }
        [Column("OH_ORG_REF")]
        [StringLength(8)]
        public string? OhOrgRef { get; set; }
        [Column("OH_SED_STAT")]
        [StringLength(2)]
        public string? OhSedStat { get; set; }
        [Column("OH_STAT")]
        [StringLength(2)]
        public string? OhStat { get; set; }
        [Column("OH_TYPE")]
        [StringLength(2)]
        public string? OhType { get; set; }
        [Column("ONHAND_DATE", TypeName = "datetime")]
        public DateTime? OnhandDate { get; set; }
        [Column("OTH_CHRG_YN")]
        [StringLength(2)]
        public string? OthChrgYn { get; set; }
        [Column("OTH_RMKS")]
        [StringLength(200)]
        public string? OthRmks { get; set; }
        [Column("ONHAND_NO")]
        [StringLength(8)]
        public string OnhandNo { get; set; } = null!;
        [Column("PICKUP_SUP_DATE", TypeName = "datetime")]
        public DateTime? PickupSupDate { get; set; }
        [Column("PKR_YN")]
        [StringLength(2)]
        public string? PkrYn { get; set; }
        [Column("PLX_CHK_NO")]
        [StringLength(10)]
        public string? PlxChkNo { get; set; }
        [Column("PRATE_YN")]
        [StringLength(2)]
        public string? PrateYn { get; set; }
        [Column("PRT_TYPE")]
        [StringLength(2)]
        public string? PrtType { get; set; }
        [Column("PUB_YN")]
        [StringLength(2)]
        public string? PubYn { get; set; }
        [Column("RANO_TYPE")]
        [StringLength(2)]
        public string? RanoType { get; set; }
        [Column("READY_SUP_DATE", TypeName = "datetime")]
        public DateTime? ReadySupDate { get; set; }
        [Column("REQUEST_DATE", TypeName = "datetime")]
        public DateTime? RequestDate { get; set; }
        [Column("REQUEST_NUMBER")]
        [StringLength(12)]
        public string? RequestNumber { get; set; }
        [Column("ROUTED_YN")]
        [StringLength(2)]
        public string? RoutedYn { get; set; }
        [Column("RSTR_YN")]
        [StringLength(2)]
        public string? RstrYn { get; set; }
        [Column("SALESMAN_CODE")]
        [StringLength(8)]
        public string? SalesmanCode { get; set; }
        [Column("SALESMAN_NAME")]
        [StringLength(36)]
        public string? SalesmanName { get; set; }
        [Column("SECTOR")]
        [StringLength(2)]
        public string? Sector { get; set; }
        [Column("SHIPPER_ADDR1")]
        [StringLength(36)]
        public string? ShipperAddr1 { get; set; }
        [Column("SHIPPER_ADDR2")]
        [StringLength(36)]
        public string? ShipperAddr2 { get; set; }
        [Column("SHIPPER_ADDR3")]
        [StringLength(36)]
        public string? ShipperAddr3 { get; set; }
        [Column("SHIPPER_ADDR4")]
        [StringLength(36)]
        public string? ShipperAddr4 { get; set; }
        [Column("SHIPPER_NAME")]
        [StringLength(75)]
        public string? ShipperName { get; set; }
        [Column("SHIPPER_SECTOR_CODE")]
        [StringLength(2)]
        public string? ShipperSectorCode { get; set; }
        [Column("SHIPPER_ZIP_CODE")]
        [StringLength(12)]
        public string? ShipperZipCode { get; set; }
        [Column("SHP_CHRG_TYPE")]
        [StringLength(4)]
        public string? ShpChrgType { get; set; }
        [Column("SHP_CODE")]
        [StringLength(8)]
        public string? ShpCode { get; set; }
        [Column("SHP_DATE", TypeName = "datetime")]
        public DateTime? ShpDate { get; set; }
        [Column("SHP_MODE")]
        [StringLength(2)]
        public string? ShpMode { get; set; }
        [Column("SLA_YN")]
        [StringLength(2)]
        public string? SlaYn { get; set; }
        [Column("SPECIAL_EQUIPMT_IND")]
        [StringLength(2)]
        public string? SpecialEquipmtInd { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [Column("TOT_GROSS_LB", TypeName = "decimal(8, 0)")]
        public decimal? TotGrossLb { get; set; }
        [Column("TOT_PCS", TypeName = "decimal(4, 0)")]
        public decimal? TotPcs { get; set; }
        [Column("TOT_INV_VAL", TypeName = "decimal(11, 2)")]
        public decimal? TotInvVal { get; set; }
        [Column("TOT_TRK_PKG", TypeName = "decimal(8, 0)")]
        public decimal? TotTrkPkg { get; set; }
        [Column("TOT_VOL_FT", TypeName = "decimal(8, 1)")]
        public decimal? TotVolFt { get; set; }
        [Column("TOT_VOL_LB", TypeName = "decimal(8, 0)")]
        public decimal? TotVolLb { get; set; }
        [Column("TOT_WT_WH", TypeName = "decimal(8, 0)")]
        public decimal? TotWtWh { get; set; }
        [Column("TRK_BILL_NO")]
        [StringLength(36)]
        public string? TrkBillNo { get; set; }
        [Column("TRK_CHRG_AMT", TypeName = "decimal(10, 2)")]
        public decimal? TrkChrgAmt { get; set; }
        [Column("TRK_CHRG_TYPE")]
        [StringLength(4)]
        public string? TrkChrgType { get; set; }
        [Column("TRK_CHRG_YN")]
        [StringLength(2)]
        public string? TrkChrgYn { get; set; }
        [Column("TRK_CODE")]
        [StringLength(8)]
        public string? TrkCode { get; set; }
        [Column("TRK_DEL_DATE", TypeName = "datetime")]
        public DateTime? TrkDelDate { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [Column("VOTE_CHARGE")]
        [StringLength(10)]
        public string? VoteCharge { get; set; }
        [Column("VSED_YN")]
        [StringLength(2)]
        public string? VsedYn { get; set; }
        [Column("ZIP_CODE")]
        [StringLength(12)]
        public string? ZipCode { get; set; }
    }
}
