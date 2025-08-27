using Microsoft.EntityFrameworkCore;
using SFDashboard.SFModels;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SFDashboard.Models
{
    public partial class SFDbContext : DbContext
    {
        public SFDbContext(DbContextOptions<SFDbContext> options) : base(options)
        {

        }

        #region Dbset
        public virtual DbSet<Acar1> Acar1s { get; set; } = null!;
        public virtual DbSet<Accg1> Accg1s { get; set; } = null!;
        public virtual DbSet<Accm1> Accm1s { get; set; } = null!;
        public virtual DbSet<Acct1> Acct1s { get; set; } = null!;
        public virtual DbSet<Acct2> Acct2s { get; set; } = null!;
        public virtual DbSet<Acdv1> Acdv1s { get; set; } = null!;
        public virtual DbSet<Acft1> Acft1s { get; set; } = null!;
        public virtual DbSet<Acit1> Acit1s { get; set; } = null!;
        public virtual DbSet<Acit2> Acit2s { get; set; } = null!;
        public virtual DbSet<Acit3> Acit3s { get; set; } = null!;
        public virtual DbSet<Actm1> Actm1s { get; set; } = null!;
        public virtual DbSet<Acva1> Acva1s { get; set; } = null!;
        public virtual DbSet<Acva2> Acva2s { get; set; } = null!;
        public virtual DbSet<Acvr1> Acvr1s { get; set; } = null!;
        public virtual DbSet<Acws1> Acws1s { get; set; } = null!;
        public virtual DbSet<Acwt1> Acwt1s { get; set; } = null!;
        public virtual DbSet<AeAllInvoiceByMaster> AeAllInvoiceByMasters { get; set; } = null!;
        public virtual DbSet<AeAwbPreparation> AeAwbPreparations { get; set; } = null!;
        public virtual DbSet<AeAwbReference> AeAwbReferences { get; set; } = null!;
        public virtual DbSet<AeEpic> AeEpics { get; set; } = null!;
        public virtual DbSet<AeInvoice1> AeInvoice1s { get; set; } = null!;
        public virtual DbSet<AeInvoice2> AeInvoice2s { get; set; } = null!;
        public virtual DbSet<AeMawbLotNo> AeMawbLotNos { get; set; } = null!;
        public virtual DbSet<AePaymentVoucher1> AePaymentVoucher1s { get; set; } = null!;
        public virtual DbSet<Aeaw1> Aeaw1s { get; set; } = null!;
        public virtual DbSet<Aeaw2> Aeaw2s { get; set; } = null!;
        public virtual DbSet<Aeaw3> Aeaw3s { get; set; } = null!;
        public virtual DbSet<Aeaw4> Aeaw4s { get; set; } = null!;
        public virtual DbSet<Aeaw5> Aeaw5s { get; set; } = null!;
        public virtual DbSet<Aeaw6> Aeaw6s { get; set; } = null!;
        public virtual DbSet<Aebk1> Aebk1s { get; set; } = null!;
        public virtual DbSet<Aebk2> Aebk2s { get; set; } = null!;
        public virtual DbSet<Aebk3> Aebk3s { get; set; } = null!;
        public virtual DbSet<Aeca1> Aeca1s { get; set; } = null!;
        public virtual DbSet<Aect1> Aect1s { get; set; } = null!;
        public virtual DbSet<Aect2> Aect2s { get; set; } = null!;
        public virtual DbSet<Aeiv1> Aeiv1s { get; set; } = null!;
        public virtual DbSet<Aeiv2> Aeiv2s { get; set; } = null!;
        public virtual DbSet<Aemp1> Aemp1s { get; set; } = null!;
        public virtual DbSet<Aemp2> Aemp2s { get; set; } = null!;
        public virtual DbSet<Aepa1> Aepa1s { get; set; } = null!;
        public virtual DbSet<Aepa2> Aepa2s { get; set; } = null!;
        public virtual DbSet<Aepv1> Aepv1s { get; set; } = null!;
        public virtual DbSet<Aepv2> Aepv2s { get; set; } = null!;
        public virtual DbSet<Aewb1> Aewb1s { get; set; } = null!;
        public virtual DbSet<AiAllInvoiceByJob> AiAllInvoiceByJobs { get; set; } = null!;
        public virtual DbSet<AiAwbEntry> AiAwbEntries { get; set; } = null!;
        public virtual DbSet<AiAwbReference> AiAwbReferences { get; set; } = null!;
        public virtual DbSet<AiDeliveryOrder> AiDeliveryOrders { get; set; } = null!;
        public virtual DbSet<AiInvoice1> AiInvoice1s { get; set; } = null!;
        public virtual DbSet<AiInvoice2> AiInvoice2s { get; set; } = null!;
        public virtual DbSet<AiMawbLotNo> AiMawbLotNos { get; set; } = null!;
        public virtual DbSet<AiPaymentVoucher1> AiPaymentVoucher1s { get; set; } = null!;
        public virtual DbSet<Aiaw1> Aiaw1s { get; set; } = null!;
        public virtual DbSet<Aiaw2> Aiaw2s { get; set; } = null!;
        public virtual DbSet<Aido1> Aido1s { get; set; } = null!;
        public virtual DbSet<Aiiv1> Aiiv1s { get; set; } = null!;
        public virtual DbSet<Aiiv2> Aiiv2s { get; set; } = null!;
        public virtual DbSet<Aipa1> Aipa1s { get; set; } = null!;
        public virtual DbSet<Aipv1> Aipv1s { get; set; } = null!;
        public virtual DbSet<Aipv2> Aipv2s { get; set; } = null!;
        public virtual DbSet<Amac1> Amac1s { get; set; } = null!;
        public virtual DbSet<Amac2> Amac2s { get; set; } = null!;
        public virtual DbSet<Amac3> Amac3s { get; set; } = null!;
        public virtual DbSet<Amad1> Amad1s { get; set; } = null!;
        public virtual DbSet<Amad2> Amad2s { get; set; } = null!;
        public virtual DbSet<Amah1> Amah1s { get; set; } = null!;
        public virtual DbSet<Amaq1> Amaq1s { get; set; } = null!;
        public virtual DbSet<Ambr1> Ambr1s { get; set; } = null!;
        public virtual DbSet<Amdc1> Amdc1s { get; set; } = null!;
        public virtual DbSet<Amfe1> Amfe1s { get; set; } = null!;
        public virtual DbSet<Amfq1> Amfq1s { get; set; } = null!;
        public virtual DbSet<Amfq2> Amfq2s { get; set; } = null!;
        public virtual DbSet<Amfq3> Amfq3s { get; set; } = null!;
        public virtual DbSet<Amfq4> Amfq4s { get; set; } = null!;
        public virtual DbSet<Amfq5> Amfq5s { get; set; } = null!;
        public virtual DbSet<Amfq6> Amfq6s { get; set; } = null!;
        public virtual DbSet<Amic1> Amic1s { get; set; } = null!;
        public virtual DbSet<Amid1> Amid1s { get; set; } = null!;
        public virtual DbSet<Amid2> Amid2s { get; set; } = null!;
        public virtual DbSet<Amie1> Amie1s { get; set; } = null!;
        public virtual DbSet<Amif1> Amif1s { get; set; } = null!;
        public virtual DbSet<Amio1> Amio1s { get; set; } = null!;
        public virtual DbSet<Amio2> Amio2s { get; set; } = null!;
        public virtual DbSet<Amir1> Amir1s { get; set; } = null!;
        public virtual DbSet<Ampa1> Ampa1s { get; set; } = null!;
        public virtual DbSet<Amqo1> Amqo1s { get; set; } = null!;
        public virtual DbSet<Amqo2> Amqo2s { get; set; } = null!;
        public virtual DbSet<Anac1> Anac1s { get; set; } = null!;
        public virtual DbSet<Anam1> Anam1s { get; set; } = null!;
        public virtual DbSet<Anat1> Anat1s { get; set; } = null!;
        public virtual DbSet<Anat2> Anat2s { get; set; } = null!;
        public virtual DbSet<Anbb1> Anbb1s { get; set; } = null!;
        public virtual DbSet<Anbb2> Anbb2s { get; set; } = null!;
        public virtual DbSet<Anbb3> Anbb3s { get; set; } = null!;
        public virtual DbSet<Ancf1> Ancf1s { get; set; } = null!;
        public virtual DbSet<Asjd1> Asjd1s { get; set; } = null!;
        public virtual DbSet<Asjd2> Asjd2s { get; set; } = null!;
        public virtual DbSet<Asjd3> Asjd3s { get; set; } = null!;
        public virtual DbSet<Asst1> Asst1s { get; set; } = null!;
        public virtual DbSet<AvailPort> AvailPorts { get; set; } = null!;
        public virtual DbSet<Brba1> Brba1s { get; set; } = null!;
        public virtual DbSet<Brtx1> Brtx1s { get; set; } = null!;
        public virtual DbSet<CgShptInfo> CgShptInfos { get; set; } = null!;
        public virtual DbSet<CmsMessage> CmsMessages { get; set; } = null!;
        public virtual DbSet<Csbk1> Csbk1s { get; set; } = null!;
        public virtual DbSet<Csbk2> Csbk2s { get; set; } = null!;
        public virtual DbSet<Ctcl1> Ctcl1s { get; set; } = null!;
        public virtual DbSet<Ctdo1> Ctdo1s { get; set; } = null!;
        public virtual DbSet<Ctdo2> Ctdo2s { get; set; } = null!;
        public virtual DbSet<Ctfa1> Ctfa1s { get; set; } = null!;
        public virtual DbSet<Ctri1> Ctri1s { get; set; } = null!;
        public virtual DbSet<Ctro1> Ctro1s { get; set; } = null!;
        public virtual DbSet<Ctro2> Ctro2s { get; set; } = null!;
        public virtual DbSet<Ctrp1> Ctrp1s { get; set; } = null!;
        public virtual DbSet<Ctrp2> Ctrp2s { get; set; } = null!;
        public virtual DbSet<Ctso1> Ctso1s { get; set; } = null!;
        public virtual DbSet<Ctso2> Ctso2s { get; set; } = null!;
        public virtual DbSet<DischargePort> DischargePorts { get; set; } = null!;
        public virtual DbSet<DtOnhand> DtOnhands { get; set; } = null!;
        public virtual DbSet<Edal1> Edal1s { get; set; } = null!;
        public virtual DbSet<Edci1> Edci1s { get; set; } = null!;
        public virtual DbSet<Edct1> Edct1s { get; set; } = null!;
        public virtual DbSet<Editrf> Editrves { get; set; } = null!;
        public virtual DbSet<Edpk1> Edpk1s { get; set; } = null!;
        public virtual DbSet<FunctionInfo> FunctionInfos { get; set; } = null!;
        public virtual DbSet<FunctionInfoSub> FunctionInfoSubs { get; set; } = null!;
        public virtual DbSet<GlAccCodeYear> GlAccCodeYears { get; set; } = null!;
        public virtual DbSet<GlAccountBalance> GlAccountBalances { get; set; } = null!;
        public virtual DbSet<GlAllBankTransaction> GlAllBankTransactions { get; set; } = null!;
        public virtual DbSet<GlAllCheque> GlAllCheques { get; set; } = null!;
        public virtual DbSet<GlBalanceSheetAcc> GlBalanceSheetAccs { get; set; } = null!;
        public virtual DbSet<GlBankTransaction> GlBankTransactions { get; set; } = null!;
        public virtual DbSet<GlChartOfAccount> GlChartOfAccounts { get; set; } = null!;
        public virtual DbSet<GlProfitLossAcc> GlProfitLossAccs { get; set; } = null!;
        public virtual DbSet<GlPst> GlPsts { get; set; } = null!;
        public virtual DbSet<GlYtdLedger> GlYtdLedgers { get; set; } = null!;
        public virtual DbSet<Glbc1> Glbc1s { get; set; } = null!;
        public virtual DbSet<Glbc2> Glbc2s { get; set; } = null!;
        public virtual DbSet<Glbc3> Glbc3s { get; set; } = null!;
        public virtual DbSet<Glbh1> Glbh1s { get; set; } = null!;
        public virtual DbSet<Glbh2> Glbh2s { get; set; } = null!;
        public virtual DbSet<Glbl1> Glbl1s { get; set; } = null!;
        public virtual DbSet<Glbt1> Glbt1s { get; set; } = null!;
        public virtual DbSet<Glcc1> Glcc1s { get; set; } = null!;
        public virtual DbSet<Glcf1> Glcf1s { get; set; } = null!;
        public virtual DbSet<Glch1> Glch1s { get; set; } = null!;
        public virtual DbSet<Glch2> Glch2s { get; set; } = null!;
        public virtual DbSet<Glct1> Glct1s { get; set; } = null!;
        public virtual DbSet<Gldc1> Gldc1s { get; set; } = null!;
        public virtual DbSet<Gleh1> Gleh1s { get; set; } = null!;
        public virtual DbSet<Glex1> Glex1s { get; set; } = null!;
        public virtual DbSet<Glex2> Glex2s { get; set; } = null!;
        public virtual DbSet<Glfa1> Glfa1s { get; set; } = null!;
        public virtual DbSet<Glfb1> Glfb1s { get; set; } = null!;
        public virtual DbSet<Glfv1> Glfv1s { get; set; } = null!;
        public virtual DbSet<Gljv1> Gljv1s { get; set; } = null!;
        public virtual DbSet<Gljv2> Gljv2s { get; set; } = null!;
        public virtual DbSet<GljvPost> GljvPosts { get; set; } = null!;
        public virtual DbSet<Glml1> Glml1s { get; set; } = null!;
        public virtual DbSet<Gloc1> Gloc1s { get; set; } = null!;
        public virtual DbSet<Glpa1> Glpa1s { get; set; } = null!;
        public virtual DbSet<Glpa2> Glpa2s { get; set; } = null!;
        public virtual DbSet<Glpp1> Glpp1s { get; set; } = null!;
        public virtual DbSet<Glrv1> Glrv1s { get; set; } = null!;
        public virtual DbSet<Glyl1> Glyl1s { get; set; } = null!;
        public virtual DbSet<Glyl2> Glyl2s { get; set; } = null!;
        public virtual DbSet<GridSet> GridSets { get; set; } = null!;
        public virtual DbSet<GridSetPerson> GridSetPeople { get; set; } = null!;
        public virtual DbSet<IaOhInv> IaOhInvs { get; set; } = null!;
        public virtual DbSet<ImGoodsIssue> ImGoodsIssues { get; set; } = null!;
        public virtual DbSet<ImGoodsRcvBarCode> ImGoodsRcvBarCodes { get; set; } = null!;
        public virtual DbSet<ImGoodsRcvIssue> ImGoodsRcvIssues { get; set; } = null!;
        public virtual DbSet<ImGoodsReceive> ImGoodsReceives { get; set; } = null!;
        public virtual DbSet<ImGrnByPackingNo> ImGrnByPackingNos { get; set; } = null!;
        public virtual DbSet<ImPurchaseOrder> ImPurchaseOrders { get; set; } = null!;
        public virtual DbSet<Imcc1> Imcc1s { get; set; } = null!;
        public virtual DbSet<Imcc2> Imcc2s { get; set; } = null!;
        public virtual DbSet<Imga1> Imga1s { get; set; } = null!;
        public virtual DbSet<Imga2> Imga2s { get; set; } = null!;
        public virtual DbSet<Imgd1> Imgd1s { get; set; } = null!;
        public virtual DbSet<Imgd2> Imgd2s { get; set; } = null!;
        public virtual DbSet<Imgi1> Imgi1s { get; set; } = null!;
        public virtual DbSet<Imgi2> Imgi2s { get; set; } = null!;
        public virtual DbSet<Imgi3> Imgi3s { get; set; } = null!;
        public virtual DbSet<Imgi4> Imgi4s { get; set; } = null!;
        public virtual DbSet<Imgi5> Imgi5s { get; set; } = null!;
        public virtual DbSet<Imgi6> Imgi6s { get; set; } = null!;
        public virtual DbSet<Imgr1> Imgr1s { get; set; } = null!;
        public virtual DbSet<Imgr2> Imgr2s { get; set; } = null!;
        public virtual DbSet<Imgr3> Imgr3s { get; set; } = null!;
        public virtual DbSet<Imia1> Imia1s { get; set; } = null!;
        public virtual DbSet<Imip1> Imip1s { get; set; } = null!;
        public virtual DbSet<Imit1> Imit1s { get; set; } = null!;
        public virtual DbSet<Imit2> Imit2s { get; set; } = null!;
        public virtual DbSet<Imlt1> Imlt1s { get; set; } = null!;
        public virtual DbSet<Imlt2> Imlt2s { get; set; } = null!;
        public virtual DbSet<Imms1> Imms1s { get; set; } = null!;
        public virtual DbSet<Impa1> Impa1s { get; set; } = null!;
        public virtual DbSet<Impc1> Impc1s { get; set; } = null!;
        public virtual DbSet<Impm1> Impm1s { get; set; } = null!;
        public virtual DbSet<Impm2> Impm2s { get; set; } = null!;
        public virtual DbSet<Impn1> Impn1s { get; set; } = null!;
        public virtual DbSet<Impo1> Impo1s { get; set; } = null!;
        public virtual DbSet<Impo2> Impo2s { get; set; } = null!;
        public virtual DbSet<Impo3> Impo3s { get; set; } = null!;
        public virtual DbSet<Impo4> Impo4s { get; set; } = null!;
        public virtual DbSet<Impr1> Impr1s { get; set; } = null!;
        public virtual DbSet<Impr2> Impr2s { get; set; } = null!;
        public virtual DbSet<Impr3> Impr3s { get; set; } = null!;
        public virtual DbSet<Impv1> Impv1s { get; set; } = null!;
        public virtual DbSet<Impv2> Impv2s { get; set; } = null!;
        public virtual DbSet<Imsd1> Imsd1s { get; set; } = null!;
        public virtual DbSet<Imsl1> Imsl1s { get; set; } = null!;
        public virtual DbSet<Imsn1> Imsn1s { get; set; } = null!;
        public virtual DbSet<Imso1> Imso1s { get; set; } = null!;
        public virtual DbSet<Imso2> Imso2s { get; set; } = null!;
        public virtual DbSet<Imso3> Imso3s { get; set; } = null!;
        public virtual DbSet<Inms1> Inms1s { get; set; } = null!;
        public virtual DbSet<IvAccInvoice1> IvAccInvoice1s { get; set; } = null!;
        public virtual DbSet<IvAccInvoice2> IvAccInvoice2s { get; set; } = null!;
        public virtual DbSet<IvAccInvoiceRecoverAcc> IvAccInvoiceRecoverAccs { get; set; } = null!;
        public virtual DbSet<IvAccInvoiceRecoverAccByRefNo> IvAccInvoiceRecoverAccByRefNos { get; set; } = null!;
        public virtual DbSet<IvAccInvoiceSummary> IvAccInvoiceSummaries { get; set; } = null!;
        public virtual DbSet<IvAccSalesByJob> IvAccSalesByJobs { get; set; } = null!;
        public virtual DbSet<IvAllCreditInvoiceByJob> IvAllCreditInvoiceByJobs { get; set; } = null!;
        public virtual DbSet<IvAllCreditInvoiceByMasterJob> IvAllCreditInvoiceByMasterJobs { get; set; } = null!;
        public virtual DbSet<IvAllCreditInvoiceWithVatByJob> IvAllCreditInvoiceWithVatByJobs { get; set; } = null!;
        public virtual DbSet<IvAllCreditInvoiceWithVatByMasterJob> IvAllCreditInvoiceWithVatByMasterJobs { get; set; } = null!;
        public virtual DbSet<IvAllCreditNoteByJob> IvAllCreditNoteByJobs { get; set; } = null!;
        public virtual DbSet<IvAllCreditNoteByMasterJob> IvAllCreditNoteByMasterJobs { get; set; } = null!;
        public virtual DbSet<IvAllCreditNoteWithVatByJob> IvAllCreditNoteWithVatByJobs { get; set; } = null!;
        public virtual DbSet<IvAllCreditNoteWithVatByMasterJob> IvAllCreditNoteWithVatByMasterJobs { get; set; } = null!;
        public virtual DbSet<IvAllDebitNoteByJob> IvAllDebitNoteByJobs { get; set; } = null!;
        public virtual DbSet<IvAllDebitNoteByMasterJob> IvAllDebitNoteByMasterJobs { get; set; } = null!;
        public virtual DbSet<IvAllDebitNoteWithVatByJob> IvAllDebitNoteWithVatByJobs { get; set; } = null!;
        public virtual DbSet<IvAllDebitNoteWithVatByMasterJob> IvAllDebitNoteWithVatByMasterJobs { get; set; } = null!;
        public virtual DbSet<IvAllInternalBillingByJob> IvAllInternalBillingByJobs { get; set; } = null!;
        public virtual DbSet<IvAllInternalBillingByMasterJob> IvAllInternalBillingByMasterJobs { get; set; } = null!;
        public virtual DbSet<IvAllInvoice1> IvAllInvoice1s { get; set; } = null!;
        public virtual DbSet<IvAllInvoice2> IvAllInvoice2s { get; set; } = null!;
        public virtual DbSet<IvAllInvoice2ImportJob> IvAllInvoice2ImportJobs { get; set; } = null!;
        public virtual DbSet<IvAllInvoice2NoVatByJob> IvAllInvoice2NoVatByJobs { get; set; } = null!;
        public virtual DbSet<IvAllInvoiceByJob> IvAllInvoiceByJobs { get; set; } = null!;
        public virtual DbSet<IvAllInvoiceJob> IvAllInvoiceJobs { get; set; } = null!;
        public virtual DbSet<IvAllInvoiceJobInvoiceNo> IvAllInvoiceJobInvoiceNos { get; set; } = null!;
        public virtual DbSet<IvAllInvoiceSummary> IvAllInvoiceSummaries { get; set; } = null!;
        public virtual DbSet<IvAllInvoiceTransfer> IvAllInvoiceTransfers { get; set; } = null!;
        public virtual DbSet<IvAllInvoiceVat> IvAllInvoiceVats { get; set; } = null!;
        public virtual DbSet<IvAllInvoiceVatByInvoice> IvAllInvoiceVatByInvoices { get; set; } = null!;
        public virtual DbSet<IvAllInvoiceWithVatByJob> IvAllInvoiceWithVatByJobs { get; set; } = null!;
        public virtual DbSet<IvAllInvoiceWithVatByMasterJob> IvAllInvoiceWithVatByMasterJobs { get; set; } = null!;
        public virtual DbSet<IvAllInvoiceWithoutCnByJob> IvAllInvoiceWithoutCnByJobs { get; set; } = null!;
        public virtual DbSet<IvAllSales2> IvAllSales2s { get; set; } = null!;
        public virtual DbSet<IvAllSalesByJob> IvAllSalesByJobs { get; set; } = null!;
        public virtual DbSet<IvAllSalesByJobDate> IvAllSalesByJobDates { get; set; } = null!;
        public virtual DbSet<IvAllSalesByJobWithVatOutlay> IvAllSalesByJobWithVatOutlays { get; set; } = null!;
        public virtual DbSet<IvAllSalesByMasterJob> IvAllSalesByMasterJobs { get; set; } = null!;
        public virtual DbSet<IvAllSalesDistribution> IvAllSalesDistributions { get; set; } = null!;
        public virtual DbSet<IvAllSalesWithVatByJob> IvAllSalesWithVatByJobs { get; set; } = null!;
        public virtual DbSet<IvAllSalesWithoutCnByJob> IvAllSalesWithoutCnByJobs { get; set; } = null!;
        public virtual DbSet<IvAllTsFreightCollectByMasterJob> IvAllTsFreightCollectByMasterJobs { get; set; } = null!;
        public virtual DbSet<IvExp> IvExps { get; set; } = null!;
        public virtual DbSet<IvInvoiceByAeHouse> IvInvoiceByAeHouses { get; set; } = null!;
        public virtual DbSet<IvPst> IvPsts { get; set; } = null!;
        public virtual DbSet<IvTrf> IvTrves { get; set; } = null!;
        public virtual DbSet<Ivch1> Ivch1s { get; set; } = null!;
        public virtual DbSet<Ivch2> Ivch2s { get; set; } = null!;
        public virtual DbSet<IvchPost> IvchPosts { get; set; } = null!;
        public virtual DbSet<Ivci1> Ivci1s { get; set; } = null!;
        public virtual DbSet<Ivcr1> Ivcr1s { get; set; } = null!;
        public virtual DbSet<Ivcr2> Ivcr2s { get; set; } = null!;
        public virtual DbSet<Ivcr3> Ivcr3s { get; set; } = null!;
        public virtual DbSet<IvcrPost> IvcrPosts { get; set; } = null!;
        public virtual DbSet<IvcrReversePost> IvcrReversePosts { get; set; } = null!;
        public virtual DbSet<Ivpa1> Ivpa1s { get; set; } = null!;
        public virtual DbSet<Ivpa2> Ivpa2s { get; set; } = null!;
        public virtual DbSet<Ivpa3> Ivpa3s { get; set; } = null!;
        public virtual DbSet<JmAllInformation> JmAllInformations { get; set; } = null!;
        public virtual DbSet<JmAllInvoicePurchase2> JmAllInvoicePurchase2s { get; set; } = null!;
        public virtual DbSet<JmAllInvoiceVendorInvoice> JmAllInvoiceVendorInvoices { get; set; } = null!;
        public virtual DbSet<JmChargeWeightRatio> JmChargeWeightRatios { get; set; } = null!;
        public virtual DbSet<JmGglInformation> JmGglInformations { get; set; } = null!;
        public virtual DbSet<JmGglMasterDump> JmGglMasterDumps { get; set; } = null!;
        public virtual DbSet<JmGrossWeightRatio> JmGrossWeightRatios { get; set; } = null!;
        public virtual DbSet<JmJobAccPl> JmJobAccPls { get; set; } = null!;
        public virtual DbSet<JmJobAccPlTranshipment> JmJobAccPlTranshipments { get; set; } = null!;
        public virtual DbSet<JmJobAccPlWithDistributionCost> JmJobAccPlWithDistributionCosts { get; set; } = null!;
        public virtual DbSet<JmJobAccPlWithDistributionCostByJob> JmJobAccPlWithDistributionCostByJobs { get; set; } = null!;
        public virtual DbSet<JmJobAccPlWithDistributionCostGrossWeight> JmJobAccPlWithDistributionCostGrossWeights { get; set; } = null!;
        public virtual DbSet<JmJobAccPlWithDistributionInternalCost> JmJobAccPlWithDistributionInternalCosts { get; set; } = null!;
        public virtual DbSet<JmJobAccPlWithDistributionProvisionCost> JmJobAccPlWithDistributionProvisionCosts { get; set; } = null!;
        public virtual DbSet<JmJobAccPlWithNonMatchProvisionCost> JmJobAccPlWithNonMatchProvisionCosts { get; set; } = null!;
        public virtual DbSet<JmJobAccrualSalesCostSummary> JmJobAccrualSalesCostSummaries { get; set; } = null!;
        public virtual DbSet<JmJobAccrualSummary> JmJobAccrualSummaries { get; set; } = null!;
        public virtual DbSet<JmJobActualCostByItem> JmJobActualCostByItems { get; set; } = null!;
        public virtual DbSet<JmJobActualCostCurrTypeGroupByJob> JmJobActualCostCurrTypeGroupByJobs { get; set; } = null!;
        public virtual DbSet<JmJobActualCostWithDistributionByJob> JmJobActualCostWithDistributionByJobs { get; set; } = null!;
        public virtual DbSet<JmJobActualCostWithDistributionByJob2> JmJobActualCostWithDistributionByJob2s { get; set; } = null!;
        public virtual DbSet<JmJobActualPl> JmJobActualPls { get; set; } = null!;
        public virtual DbSet<JmJobActualPl1> JmJobActualPl1s { get; set; } = null!;
        public virtual DbSet<JmJobActualPl2> JmJobActualPl2s { get; set; } = null!;
        public virtual DbSet<JmJobActualPl3> JmJobActualPl3s { get; set; } = null!;
        public virtual DbSet<JmJobActualPlCost> JmJobActualPlCosts { get; set; } = null!;
        public virtual DbSet<JmJobActualPlNoVat> JmJobActualPlNoVats { get; set; } = null!;
        public virtual DbSet<JmJobActualPlNonMatchProvision> JmJobActualPlNonMatchProvisions { get; set; } = null!;
        public virtual DbSet<JmJobActualPlProvisionCost> JmJobActualPlProvisionCosts { get; set; } = null!;
        public virtual DbSet<JmJobActualPlSummary> JmJobActualPlSummaries { get; set; } = null!;
        public virtual DbSet<JmJobActualPlWithAccrual> JmJobActualPlWithAccruals { get; set; } = null!;
        public virtual DbSet<JmJobActualPlWithDistributionCost> JmJobActualPlWithDistributionCosts { get; set; } = null!;
        public virtual DbSet<JmJobActualPlWithDistributionCost3> JmJobActualPlWithDistributionCost3s { get; set; } = null!;
        public virtual DbSet<JmJobActualPlWithDistributionCostByCurr> JmJobActualPlWithDistributionCostByCurrs { get; set; } = null!;
        public virtual DbSet<JmJobActualPlWithDistributionCostByJob> JmJobActualPlWithDistributionCostByJobs { get; set; } = null!;
        public virtual DbSet<JmJobActualPlWithDistributionCostNoVatByJob> JmJobActualPlWithDistributionCostNoVatByJobs { get; set; } = null!;
        public virtual DbSet<JmJobActualPlWithDistributionCostTeu> JmJobActualPlWithDistributionCostTeus { get; set; } = null!;
        public virtual DbSet<JmJobActualPlWithDistributionCostVolume> JmJobActualPlWithDistributionCostVolumes { get; set; } = null!;
        public virtual DbSet<JmJobActualPlWithDistributionInternalCost> JmJobActualPlWithDistributionInternalCosts { get; set; } = null!;
        public virtual DbSet<JmJobActualPlWithDistributionProvisionCost> JmJobActualPlWithDistributionProvisionCosts { get; set; } = null!;
        public virtual DbSet<JmJobActualPlWithNonMatchProvisionCost> JmJobActualPlWithNonMatchProvisionCosts { get; set; } = null!;
        public virtual DbSet<JmJobActualPlWithProvisionCost> JmJobActualPlWithProvisionCosts { get; set; } = null!;
        public virtual DbSet<JmJobActualPlWithVatOutlay> JmJobActualPlWithVatOutlays { get; set; } = null!;
        public virtual DbSet<JmJobActualProvisionCost> JmJobActualProvisionCosts { get; set; } = null!;
        public virtual DbSet<JmJobActualSalesByItem> JmJobActualSalesByItems { get; set; } = null!;
        public virtual DbSet<JmJobActualSalesCostProvisionCost> JmJobActualSalesCostProvisionCosts { get; set; } = null!;
        public virtual DbSet<JmJobActualSalesCurrTypeGroupByJob> JmJobActualSalesCurrTypeGroupByJobs { get; set; } = null!;
        public virtual DbSet<JmJobActualSalesNonMatchCostProvisionCost> JmJobActualSalesNonMatchCostProvisionCosts { get; set; } = null!;
        public virtual DbSet<JmJobActualSalesProvisionCost> JmJobActualSalesProvisionCosts { get; set; } = null!;
        public virtual DbSet<JmJobActualSalesWithDistributionByJob> JmJobActualSalesWithDistributionByJobs { get; set; } = null!;
        public virtual DbSet<JmJobActualSalesWithDistributionByJob2> JmJobActualSalesWithDistributionByJob2s { get; set; } = null!;
        public virtual DbSet<JmJobActualSalesWithDistributionProvisionCost> JmJobActualSalesWithDistributionProvisionCosts { get; set; } = null!;
        public virtual DbSet<JmJobCashCostCn> JmJobCashCostCns { get; set; } = null!;
        public virtual DbSet<JmJobCashCostCnSale> JmJobCashCostCnSales { get; set; } = null!;
        public virtual DbSet<JmJobCost> JmJobCosts { get; set; } = null!;
        public virtual DbSet<JmJobCostCn> JmJobCostCns { get; set; } = null!;
        public virtual DbSet<JmJobCostCnSale> JmJobCostCnSales { get; set; } = null!;
        public virtual DbSet<JmJobCostngByType> JmJobCostngByTypes { get; set; } = null!;
        public virtual DbSet<JmJobDocNo> JmJobDocNos { get; set; } = null!;
        public virtual DbSet<JmJobInternalProvisionSummaryByJob> JmJobInternalProvisionSummaryByJobs { get; set; } = null!;
        public virtual DbSet<JmJobInternalProvisionSummaryByMasterJob> JmJobInternalProvisionSummaryByMasterJobs { get; set; } = null!;
        public virtual DbSet<JmJobInvoiceCashCostCn> JmJobInvoiceCashCostCns { get; set; } = null!;
        public virtual DbSet<JmJobMaster> JmJobMasters { get; set; } = null!;
        public virtual DbSet<JmJobOperationCostByJob> JmJobOperationCostByJobs { get; set; } = null!;
        public virtual DbSet<JmJobPl> JmJobPls { get; set; } = null!;
        public virtual DbSet<JmJobPlAccrualActualByJobItemTrxNoByItem> JmJobPlAccrualActualByJobItemTrxNoByItems { get; set; } = null!;
        public virtual DbSet<JmJobPlByMasterJob> JmJobPlByMasterJobs { get; set; } = null!;
        public virtual DbSet<JmJobPlDetail> JmJobPlDetails { get; set; } = null!;
        public virtual DbSet<JmJobPlProvisionActualByItem> JmJobPlProvisionActualByItems { get; set; } = null!;
        public virtual DbSet<JmJobPlProvisionActualByJobItemTrxNo> JmJobPlProvisionActualByJobItemTrxNos { get; set; } = null!;
        public virtual DbSet<JmJobPlProvisionPostActualByItem> JmJobPlProvisionPostActualByItems { get; set; } = null!;
        public virtual DbSet<JmJobPlProvisionPostActualByJobItemTrxNo> JmJobPlProvisionPostActualByJobItemTrxNos { get; set; } = null!;
        public virtual DbSet<JmJobPostSalesProvisionCost> JmJobPostSalesProvisionCosts { get; set; } = null!;
        public virtual DbSet<JmJobProvisionByMasterJob> JmJobProvisionByMasterJobs { get; set; } = null!;
        public virtual DbSet<JmJobProvisionByMasterJobByItem> JmJobProvisionByMasterJobByItems { get; set; } = null!;
        public virtual DbSet<JmJobProvisionCost> JmJobProvisionCosts { get; set; } = null!;
        public virtual DbSet<JmJobProvisionCostBalanceByItem> JmJobProvisionCostBalanceByItems { get; set; } = null!;
        public virtual DbSet<JmJobProvisionCostBalanceNoCashByItem> JmJobProvisionCostBalanceNoCashByItems { get; set; } = null!;
        public virtual DbSet<JmJobProvisionCostByItem> JmJobProvisionCostByItems { get; set; } = null!;
        public virtual DbSet<JmJobProvisionCostByItemDescription> JmJobProvisionCostByItemDescriptions { get; set; } = null!;
        public virtual DbSet<JmJobProvisionCostByJob> JmJobProvisionCostByJobs { get; set; } = null!;
        public virtual DbSet<JmJobProvisionCostWithDistributionCostVolume> JmJobProvisionCostWithDistributionCostVolumes { get; set; } = null!;
        public virtual DbSet<JmJobProvisionCostWithDistributionCostVolumeByJob> JmJobProvisionCostWithDistributionCostVolumeByJobs { get; set; } = null!;
        public virtual DbSet<JmJobProvisionCostWithDistributionCostVolumeWithInternalJob> JmJobProvisionCostWithDistributionCostVolumeWithInternalJobs { get; set; } = null!;
        public virtual DbSet<JmJobProvisionCostWithDistributionCostVolumeWithInternalJobFlagByJob> JmJobProvisionCostWithDistributionCostVolumeWithInternalJobFlagByJobs { get; set; } = null!;
        public virtual DbSet<JmJobProvisionSalesByItem> JmJobProvisionSalesByItems { get; set; } = null!;
        public virtual DbSet<JmJobProvisionSalesCostSummary> JmJobProvisionSalesCostSummaries { get; set; } = null!;
        public virtual DbSet<JmJobProvisionSalesProvisionCost> JmJobProvisionSalesProvisionCosts { get; set; } = null!;
        public virtual DbSet<JmJobProvisionSummary> JmJobProvisionSummaries { get; set; } = null!;
        public virtual DbSet<JmJobProvisionSummaryByJob> JmJobProvisionSummaryByJobs { get; set; } = null!;
        public virtual DbSet<JmJobProvisionSummaryByMasterJob> JmJobProvisionSummaryByMasterJobs { get; set; } = null!;
        public virtual DbSet<JmJobProvisionSummaryNoVat> JmJobProvisionSummaryNoVats { get; set; } = null!;
        public virtual DbSet<JmJobProvisionSummaryNoVatByInvoice> JmJobProvisionSummaryNoVatByInvoices { get; set; } = null!;
        public virtual DbSet<JmJobProvisionSummaryNoVatGroupByInvoice> JmJobProvisionSummaryNoVatGroupByInvoices { get; set; } = null!;
        public virtual DbSet<JmJobProvisionSummaryWithDistribution> JmJobProvisionSummaryWithDistributions { get; set; } = null!;
        public virtual DbSet<JmJobProvisionSummaryWithDistributionByJob> JmJobProvisionSummaryWithDistributionByJobs { get; set; } = null!;
        public virtual DbSet<JmJobProvisionWithDistributionCost> JmJobProvisionWithDistributionCosts { get; set; } = null!;
        public virtual DbSet<JmJobSale> JmJobSales { get; set; } = null!;
        public virtual DbSet<JmJobSalesDate> JmJobSalesDates { get; set; } = null!;
        public virtual DbSet<JmJobStatus> JmJobStatuses { get; set; } = null!;
        public virtual DbSet<JmMasterJobAccCostByItem> JmMasterJobAccCostByItems { get; set; } = null!;
        public virtual DbSet<JmMasterJobAccCostByItemWithVat> JmMasterJobAccCostByItemWithVats { get; set; } = null!;
        public virtual DbSet<JmMasterJobAccCostDistribution> JmMasterJobAccCostDistributions { get; set; } = null!;
        public virtual DbSet<JmMasterJobAccCostDistributionByJob> JmMasterJobAccCostDistributionByJobs { get; set; } = null!;
        public virtual DbSet<JmMasterJobAccCostDistributionByJobWithVat> JmMasterJobAccCostDistributionByJobWithVats { get; set; } = null!;
        public virtual DbSet<JmMasterJobAccCostDistributionWithVat> JmMasterJobAccCostDistributionWithVats { get; set; } = null!;
        public virtual DbSet<JmMasterJobAccSalesByItem> JmMasterJobAccSalesByItems { get; set; } = null!;
        public virtual DbSet<JmMasterJobAccSalesByItemWithVat> JmMasterJobAccSalesByItemWithVats { get; set; } = null!;
        public virtual DbSet<JmMasterJobAccSalesCostDistribution> JmMasterJobAccSalesCostDistributions { get; set; } = null!;
        public virtual DbSet<JmMasterJobAccSalesCostDistributionWithVat> JmMasterJobAccSalesCostDistributionWithVats { get; set; } = null!;
        public virtual DbSet<JmMasterJobAccSalesDistribution> JmMasterJobAccSalesDistributions { get; set; } = null!;
        public virtual DbSet<JmMasterJobAccSalesDistributionByJob> JmMasterJobAccSalesDistributionByJobs { get; set; } = null!;
        public virtual DbSet<JmMasterJobAccSalesDistributionByJobWithVat> JmMasterJobAccSalesDistributionByJobWithVats { get; set; } = null!;
        public virtual DbSet<JmMasterJobAccSalesDistributionWithVat> JmMasterJobAccSalesDistributionWithVats { get; set; } = null!;
        public virtual DbSet<JmMasterJobAccrualSalesCostSummary> JmMasterJobAccrualSalesCostSummaries { get; set; } = null!;
        public virtual DbSet<JmMasterJobAccrualSalesCostSummaryDistribution> JmMasterJobAccrualSalesCostSummaryDistributions { get; set; } = null!;
        public virtual DbSet<JmMasterJobAccrualSummaryDistribution> JmMasterJobAccrualSummaryDistributions { get; set; } = null!;
        public virtual DbSet<JmMasterJobActualCost> JmMasterJobActualCosts { get; set; } = null!;
        public virtual DbSet<JmMasterJobActualCostByItem> JmMasterJobActualCostByItems { get; set; } = null!;
        public virtual DbSet<JmMasterJobActualCostByItem2> JmMasterJobActualCostByItem2s { get; set; } = null!;
        public virtual DbSet<JmMasterJobActualCostByItem3> JmMasterJobActualCostByItem3s { get; set; } = null!;
        public virtual DbSet<JmMasterJobActualCostByItemWithVat> JmMasterJobActualCostByItemWithVats { get; set; } = null!;
        public virtual DbSet<JmMasterJobActualCostDistribution> JmMasterJobActualCostDistributions { get; set; } = null!;
        public virtual DbSet<JmMasterJobActualCostDistribution2> JmMasterJobActualCostDistribution2s { get; set; } = null!;
        public virtual DbSet<JmMasterJobActualCostDistribution3> JmMasterJobActualCostDistribution3s { get; set; } = null!;
        public virtual DbSet<JmMasterJobActualSalesByItem> JmMasterJobActualSalesByItems { get; set; } = null!;
        public virtual DbSet<JmMasterJobActualSalesByItem2> JmMasterJobActualSalesByItem2s { get; set; } = null!;
        public virtual DbSet<JmMasterJobActualSalesByItem3> JmMasterJobActualSalesByItem3s { get; set; } = null!;
        public virtual DbSet<JmMasterJobActualSalesDistribution> JmMasterJobActualSalesDistributions { get; set; } = null!;
        public virtual DbSet<JmMasterJobActualSalesDistribution2> JmMasterJobActualSalesDistribution2s { get; set; } = null!;
        public virtual DbSet<JmMasterJobActualSalesDistribution3> JmMasterJobActualSalesDistribution3s { get; set; } = null!;
        public virtual DbSet<JmMasterJobProvisionCost> JmMasterJobProvisionCosts { get; set; } = null!;
        public virtual DbSet<JmMasterJobProvisionCostByItem> JmMasterJobProvisionCostByItems { get; set; } = null!;
        public virtual DbSet<JmMasterJobProvisionCostDistribution> JmMasterJobProvisionCostDistributions { get; set; } = null!;
        public virtual DbSet<JmMasterJobProvisionSalesCostSummary> JmMasterJobProvisionSalesCostSummaries { get; set; } = null!;
        public virtual DbSet<JmMasterJobProvisionSalesCostSummaryDistribution> JmMasterJobProvisionSalesCostSummaryDistributions { get; set; } = null!;
        public virtual DbSet<JmMasterJobProvisionSummary> JmMasterJobProvisionSummaries { get; set; } = null!;
        public virtual DbSet<JmMasterJobProvisionSummaryDistribution> JmMasterJobProvisionSummaryDistributions { get; set; } = null!;
        public virtual DbSet<JmNoOfHouseJob> JmNoOfHouseJobs { get; set; } = null!;
        public virtual DbSet<JmNoOfJobRatio> JmNoOfJobRatios { get; set; } = null!;
        public virtual DbSet<JmNonMasterJobAccPlByItem> JmNonMasterJobAccPlByItems { get; set; } = null!;
        public virtual DbSet<JmNonMasterJobActualPlByItem> JmNonMasterJobActualPlByItems { get; set; } = null!;
        public virtual DbSet<JmNonMasterJobActualPlByItem2> JmNonMasterJobActualPlByItem2s { get; set; } = null!;
        public virtual DbSet<JmNonMasterJobActualPlByItem3> JmNonMasterJobActualPlByItem3s { get; set; } = null!;
        public virtual DbSet<JmNonMasterJobActualPlByItemCurr> JmNonMasterJobActualPlByItemCurrs { get; set; } = null!;
        public virtual DbSet<JmNonMasterJobProvisionCostByItem> JmNonMasterJobProvisionCostByItems { get; set; } = null!;
        public virtual DbSet<JmNonMasterJobProvisionSummary> JmNonMasterJobProvisionSummaries { get; set; } = null!;
        public virtual DbSet<JmNonMatchJobProvisionCost> JmNonMatchJobProvisionCosts { get; set; } = null!;
        public virtual DbSet<JmNonMatchJobProvisionCostByItem> JmNonMatchJobProvisionCostByItems { get; set; } = null!;
        public virtual DbSet<JmNonMatchJobProvisionCostByJob> JmNonMatchJobProvisionCostByJobs { get; set; } = null!;
        public virtual DbSet<JmNonMatchJobProvisionCostByMasterJob> JmNonMatchJobProvisionCostByMasterJobs { get; set; } = null!;
        public virtual DbSet<JmNonMatchJobProvisionSale> JmNonMatchJobProvisionSales { get; set; } = null!;
        public virtual DbSet<JmNonMatchProvCostByJob> JmNonMatchProvCostByJobs { get; set; } = null!;
        public virtual DbSet<JmNonMatchProvisionCostByJob> JmNonMatchProvisionCostByJobs { get; set; } = null!;
        public virtual DbSet<JmPcsRatio> JmPcsRatios { get; set; } = null!;
        public virtual DbSet<JmSalesCostProvSummary> JmSalesCostProvSummaries { get; set; } = null!;
        public virtual DbSet<JmSeaJobActualPlWithDistributionCost> JmSeaJobActualPlWithDistributionCosts { get; set; } = null!;
        public virtual DbSet<JmSeaJobActualPlWithDistributionCostByJob> JmSeaJobActualPlWithDistributionCostByJobs { get; set; } = null!;
        public virtual DbSet<JmTeuRatio> JmTeuRatios { get; set; } = null!;
        public virtual DbSet<JmUnbillJob> JmUnbillJobs { get; set; } = null!;
        public virtual DbSet<JmVolumeRatio> JmVolumeRatios { get; set; } = null!;
        public virtual DbSet<Jmaj1> Jmaj1s { get; set; } = null!;
        public virtual DbSet<Jmce1> Jmce1s { get; set; } = null!;
        public virtual DbSet<Jmce2> Jmce2s { get; set; } = null!;
        public virtual DbSet<Jmce3> Jmce3s { get; set; } = null!;
        public virtual DbSet<Jmce4> Jmce4s { get; set; } = null!;
        public virtual DbSet<Jmcs1> Jmcs1s { get; set; } = null!;
        public virtual DbSet<Jmct1> Jmct1s { get; set; } = null!;
        public virtual DbSet<Jmdo1> Jmdo1s { get; set; } = null!;
        public virtual DbSet<Jmdt1> Jmdt1s { get; set; } = null!;
        public virtual DbSet<Jmdt2> Jmdt2s { get; set; } = null!;
        public virtual DbSet<Jmdt3> Jmdt3s { get; set; } = null!;
        public virtual DbSet<Jmdt4> Jmdt4s { get; set; } = null!;
        public virtual DbSet<Jmeg1> Jmeg1s { get; set; } = null!;
        public virtual DbSet<Jmeg2> Jmeg2s { get; set; } = null!;
        public virtual DbSet<Jmfb1> Jmfb1s { get; set; } = null!;
        public virtual DbSet<Jmje1> Jmje1s { get; set; } = null!;
        public virtual DbSet<Jmje2> Jmje2s { get; set; } = null!;
        public virtual DbSet<Jmjm1> Jmjm1s { get; set; } = null!;
        public virtual DbSet<Jmjm2> Jmjm2s { get; set; } = null!;
        public virtual DbSet<Jmjm3> Jmjm3s { get; set; } = null!;
        public virtual DbSet<Jmjm4> Jmjm4s { get; set; } = null!;
        public virtual DbSet<Jmjm5> Jmjm5s { get; set; } = null!;
        public virtual DbSet<Jmjm6> Jmjm6s { get; set; } = null!;
        public virtual DbSet<Jmjm7> Jmjm7s { get; set; } = null!;
        public virtual DbSet<JmjmProvisionActualSalesProvisionActualCost> JmjmProvisionActualSalesProvisionActualCosts { get; set; } = null!;
        public virtual DbSet<Jmjs1> Jmjs1s { get; set; } = null!;
        public virtual DbSet<Jmjs2> Jmjs2s { get; set; } = null!;
        public virtual DbSet<Jmjt1> Jmjt1s { get; set; } = null!;
        public virtual DbSet<Jmmp1> Jmmp1s { get; set; } = null!;
        public virtual DbSet<Jmpa1> Jmpa1s { get; set; } = null!;
        public virtual DbSet<Jmpa2> Jmpa2s { get; set; } = null!;
        public virtual DbSet<Jmpa3> Jmpa3s { get; set; } = null!;
        public virtual DbSet<Jmpj1> Jmpj1s { get; set; } = null!;
        public virtual DbSet<Jmpt1> Jmpt1s { get; set; } = null!;
        public virtual DbSet<JmptPost> JmptPosts { get; set; } = null!;
        public virtual DbSet<Jmrk1> Jmrk1s { get; set; } = null!;
        public virtual DbSet<Jmsc1> Jmsc1s { get; set; } = null!;
        public virtual DbSet<Jmsc2> Jmsc2s { get; set; } = null!;
        public virtual DbSet<Jmtn1> Jmtn1s { get; set; } = null!;
        public virtual DbSet<Jmtn2> Jmtn2s { get; set; } = null!;
        public virtual DbSet<Jmtn3> Jmtn3s { get; set; } = null!;
        public virtual DbSet<Jmtn4> Jmtn4s { get; set; } = null!;
        public virtual DbSet<Jmtn5> Jmtn5s { get; set; } = null!;
        public virtual DbSet<Jmtn6> Jmtn6s { get; set; } = null!;
        public virtual DbSet<Jmtn8> Jmtn8s { get; set; } = null!;
        public virtual DbSet<Jmwo1> Jmwo1s { get; set; } = null!;
        public virtual DbSet<LoadingPort> LoadingPorts { get; set; } = null!;
        public virtual DbSet<Omdy1> Omdy1s { get; set; } = null!;
        public virtual DbSet<Omdy2> Omdy2s { get; set; } = null!;
        public virtual DbSet<Omlc1> Omlc1s { get; set; } = null!;
        public virtual DbSet<Omoh1> Omoh1s { get; set; } = null!;
        public virtual DbSet<Omor1> Omor1s { get; set; } = null!;
        public virtual DbSet<Omor2> Omor2s { get; set; } = null!;
        public virtual DbSet<Ompa1> Ompa1s { get; set; } = null!;
        public virtual DbSet<Omsr1> Omsr1s { get; set; } = null!;
        public virtual DbSet<Omtx1> Omtx1s { get; set; } = null!;
        public virtual DbSet<Omtx2> Omtx2s { get; set; } = null!;
        public virtual DbSet<Omtx3> Omtx3s { get; set; } = null!;
        public virtual DbSet<Omtx4> Omtx4s { get; set; } = null!;
        public virtual DbSet<Omtx5> Omtx5s { get; set; } = null!;
        public virtual DbSet<Omtx6> Omtx6s { get; set; } = null!;
        public virtual DbSet<Omtx7> Omtx7s { get; set; } = null!;
        public virtual DbSet<PlAccCostByJob> PlAccCostByJobs { get; set; } = null!;
        public virtual DbSet<PlAccPurcahseRecoverAcc> PlAccPurcahseRecoverAccs { get; set; } = null!;
        public virtual DbSet<PlAccPurchase1> PlAccPurchase1s { get; set; } = null!;
        public virtual DbSet<PlAccPurchase2> PlAccPurchase2s { get; set; } = null!;
        public virtual DbSet<PlAccPurchaseRecoverAccByRefNo> PlAccPurchaseRecoverAccByRefNos { get; set; } = null!;
        public virtual DbSet<PlAccPurchaseSummary> PlAccPurchaseSummaries { get; set; } = null!;
        public virtual DbSet<PlAdvancePayment> PlAdvancePayments { get; set; } = null!;
        public virtual DbSet<PlAllActualCostByJob> PlAllActualCostByJobs { get; set; } = null!;
        public virtual DbSet<PlAllCashPurchaseByMasterJob> PlAllCashPurchaseByMasterJobs { get; set; } = null!;
        public virtual DbSet<PlAllCashPurchaseJob> PlAllCashPurchaseJobs { get; set; } = null!;
        public virtual DbSet<PlAllCashPurchaseMasterJob> PlAllCashPurchaseMasterJobs { get; set; } = null!;
        public virtual DbSet<PlAllCost2> PlAllCost2s { get; set; } = null!;
        public virtual DbSet<PlAllCostByJob> PlAllCostByJobs { get; set; } = null!;
        public virtual DbSet<PlAllCostByJobDate> PlAllCostByJobDates { get; set; } = null!;
        public virtual DbSet<PlAllCostByJobWithVatOutlay> PlAllCostByJobWithVatOutlays { get; set; } = null!;
        public virtual DbSet<PlAllCostByMasterJob> PlAllCostByMasterJobs { get; set; } = null!;
        public virtual DbSet<PlAllCostByMasterJobByItem> PlAllCostByMasterJobByItems { get; set; } = null!;
        public virtual DbSet<PlAllCostDistribution> PlAllCostDistributions { get; set; } = null!;
        public virtual DbSet<PlAllCostWithCnByJob> PlAllCostWithCnByJobs { get; set; } = null!;
        public virtual DbSet<PlAllCostWithVatByJob> PlAllCostWithVatByJobs { get; set; } = null!;
        public virtual DbSet<PlAllNonCashPurchaseByJob> PlAllNonCashPurchaseByJobs { get; set; } = null!;
        public virtual DbSet<PlAllNonCashPurchaseByMasterJob> PlAllNonCashPurchaseByMasterJobs { get; set; } = null!;
        public virtual DbSet<PlAllNonCashPurchaseWithVatByJob> PlAllNonCashPurchaseWithVatByJobs { get; set; } = null!;
        public virtual DbSet<PlAllNonCashPurchaseWithVatByMasterJob> PlAllNonCashPurchaseWithVatByMasterJobs { get; set; } = null!;
        public virtual DbSet<PlAllPayment1> PlAllPayment1s { get; set; } = null!;
        public virtual DbSet<PlAllPaymentSummary> PlAllPaymentSummaries { get; set; } = null!;
        public virtual DbSet<PlAllPaymentVoucherByJob> PlAllPaymentVoucherByJobs { get; set; } = null!;
        public virtual DbSet<PlAllPaymentVoucherByMasterJob> PlAllPaymentVoucherByMasterJobs { get; set; } = null!;
        public virtual DbSet<PlAllPaymentVoucherWithVatByJob> PlAllPaymentVoucherWithVatByJobs { get; set; } = null!;
        public virtual DbSet<PlAllPaymentVoucherWithVatByMasterJob> PlAllPaymentVoucherWithVatByMasterJobs { get; set; } = null!;
        public virtual DbSet<PlAllPurchase1> PlAllPurchase1s { get; set; } = null!;
        public virtual DbSet<PlAllPurchase2> PlAllPurchase2s { get; set; } = null!;
        public virtual DbSet<PlAllPurchase2ImportJob> PlAllPurchase2ImportJobs { get; set; } = null!;
        public virtual DbSet<PlAllPurchase2NoProvision> PlAllPurchase2NoProvisions { get; set; } = null!;
        public virtual DbSet<PlAllPurchaseByJob> PlAllPurchaseByJobs { get; set; } = null!;
        public virtual DbSet<PlAllPurchaseByJobItem> PlAllPurchaseByJobItems { get; set; } = null!;
        public virtual DbSet<PlAllPurchaseJob> PlAllPurchaseJobs { get; set; } = null!;
        public virtual DbSet<PlAllPurchaseSummary> PlAllPurchaseSummaries { get; set; } = null!;
        public virtual DbSet<PlAllPurchaseTransfer> PlAllPurchaseTransfers { get; set; } = null!;
        public virtual DbSet<PlAllPurchaseVat> PlAllPurchaseVats { get; set; } = null!;
        public virtual DbSet<PlAllPurchaseWithVatByMasterJob> PlAllPurchaseWithVatByMasterJobs { get; set; } = null!;
        public virtual DbSet<PlAllTfcCostBySeaExportMasterJob> PlAllTfcCostBySeaExportMasterJobs { get; set; } = null!;
        public virtual DbSet<PlCashPurchase1> PlCashPurchase1s { get; set; } = null!;
        public virtual DbSet<PlCashPurchase2> PlCashPurchase2s { get; set; } = null!;
        public virtual DbSet<PlInvoicePaymentDate> PlInvoicePaymentDates { get; set; } = null!;
        public virtual DbSet<PlPst> PlPsts { get; set; } = null!;
        public virtual DbSet<PlSlTransaction> PlSlTransactions { get; set; } = null!;
        public virtual DbSet<PlSlVat> PlSlVats { get; set; } = null!;
        public virtual DbSet<PlTrf> PlTrves { get; set; } = null!;
        public virtual DbSet<PlVendorInvoice1> PlVendorInvoice1s { get; set; } = null!;
        public virtual DbSet<PlVendorInvoice2> PlVendorInvoice2s { get; set; } = null!;
        public virtual DbSet<PlVendorInvoiceByInvoice> PlVendorInvoiceByInvoices { get; set; } = null!;
        public virtual DbSet<PlVendorPayment1> PlVendorPayment1s { get; set; } = null!;
        public virtual DbSet<PlVendorPayment2> PlVendorPayment2s { get; set; } = null!;
        public virtual DbSet<Plaj1> Plaj1s { get; set; } = null!;
        public virtual DbSet<PlajPost> PlajPosts { get; set; } = null!;
        public virtual DbSet<Plcp1> Plcp1s { get; set; } = null!;
        public virtual DbSet<Plcp2> Plcp2s { get; set; } = null!;
        public virtual DbSet<PlcpPost> PlcpPosts { get; set; } = null!;
        public virtual DbSet<Plcs1> Plcs1s { get; set; } = null!;
        public virtual DbSet<Plcs2> Plcs2s { get; set; } = null!;
        public virtual DbSet<PlcsPost> PlcsPosts { get; set; } = null!;
        public virtual DbSet<Plhp1> Plhp1s { get; set; } = null!;
        public virtual DbSet<Plpa1> Plpa1s { get; set; } = null!;
        public virtual DbSet<Plpm1> Plpm1s { get; set; } = null!;
        public virtual DbSet<Plpm2> Plpm2s { get; set; } = null!;
        public virtual DbSet<Plpm3> Plpm3s { get; set; } = null!;
        public virtual DbSet<PlpmPost> PlpmPosts { get; set; } = null!;
        public virtual DbSet<Plti1> Plti1s { get; set; } = null!;
        public virtual DbSet<Pltx1> Pltx1s { get; set; } = null!;
        public virtual DbSet<PltxCheck> PltxChecks { get; set; } = null!;
        public virtual DbSet<PltxCheck2> PltxCheck2s { get; set; } = null!;
        public virtual DbSet<Plvi1> Plvi1s { get; set; } = null!;
        public virtual DbSet<Plvi2> Plvi2s { get; set; } = null!;
        public virtual DbSet<Plvi3> Plvi3s { get; set; } = null!;
        public virtual DbSet<Plvi4> Plvi4s { get; set; } = null!;
        public virtual DbSet<Plvi5> Plvi5s { get; set; } = null!;
        public virtual DbSet<Plvi6> Plvi6s { get; set; } = null!;
        public virtual DbSet<PlviPost> PlviPosts { get; set; } = null!;
        public virtual DbSet<Plvn1> Plvn1s { get; set; } = null!;
        public virtual DbSet<Plvn2> Plvn2s { get; set; } = null!;
        public virtual DbSet<Plvn3> Plvn3s { get; set; } = null!;
        public virtual DbSet<Plvn4> Plvn4s { get; set; } = null!;
        public virtual DbSet<Plvt1> Plvt1s { get; set; } = null!;
        public virtual DbSet<Plvx1> Plvx1s { get; set; } = null!;
        public virtual DbSet<Poev1> Poev1s { get; set; } = null!;
        public virtual DbSet<Popo1> Popo1s { get; set; } = null!;
        public virtual DbSet<Popo2> Popo2s { get; set; } = null!;
        public virtual DbSet<Popo3> Popo3s { get; set; } = null!;
        public virtual DbSet<PortCode> PortCodes { get; set; } = null!;
        public virtual DbSet<PowerLevel> PowerLevels { get; set; } = null!;
        public virtual DbSet<PvExp> PvExps { get; set; } = null!;
        public virtual DbSet<RcAirportCode> RcAirportCodes { get; set; } = null!;
        public virtual DbSet<RcShippingLine> RcShippingLines { get; set; } = null!;
        public virtual DbSet<Rcal1> Rcal1s { get; set; } = null!;
        public virtual DbSet<Rcam1> Rcam1s { get; set; } = null!;
        public virtual DbSet<Rcap1> Rcap1s { get; set; } = null!;
        public virtual DbSet<Rcbo1> Rcbo1s { get; set; } = null!;
        public virtual DbSet<Rcbp1> Rcbp1s { get; set; } = null!;
        public virtual DbSet<Rcbp10> Rcbp10s { get; set; } = null!;
        public virtual DbSet<Rcbp11> Rcbp11s { get; set; } = null!;
        public virtual DbSet<Rcbp12> Rcbp12s { get; set; } = null!;
        public virtual DbSet<Rcbp2> Rcbp2s { get; set; } = null!;
        public virtual DbSet<Rcbp3> Rcbp3s { get; set; } = null!;
        public virtual DbSet<Rcbp4> Rcbp4s { get; set; } = null!;
        public virtual DbSet<Rcbp5> Rcbp5s { get; set; } = null!;
        public virtual DbSet<Rcbp6> Rcbp6s { get; set; } = null!;
        public virtual DbSet<Rcbp7> Rcbp7s { get; set; } = null!;
        public virtual DbSet<Rcbp8> Rcbp8s { get; set; } = null!;
        public virtual DbSet<Rcbp9> Rcbp9s { get; set; } = null!;
        public virtual DbSet<Rcbt1> Rcbt1s { get; set; } = null!;
        public virtual DbSet<Rcbx1> Rcbx1s { get; set; } = null!;
        public virtual DbSet<Rcbx2> Rcbx2s { get; set; } = null!;
        public virtual DbSet<Rccc1> Rccc1s { get; set; } = null!;
        public virtual DbSet<Rccd1> Rccd1s { get; set; } = null!;
        public virtual DbSet<Rccf1> Rccf1s { get; set; } = null!;
        public virtual DbSet<Rccf2> Rccf2s { get; set; } = null!;
        public virtual DbSet<Rccm1> Rccm1s { get; set; } = null!;
        public virtual DbSet<Rcco1> Rcco1s { get; set; } = null!;
        public virtual DbSet<Rcct1> Rcct1s { get; set; } = null!;
        public virtual DbSet<Rccy1> Rccy1s { get; set; } = null!;
        public virtual DbSet<Rccy2> Rccy2s { get; set; } = null!;
        public virtual DbSet<Rccy3> Rccy3s { get; set; } = null!;
        public virtual DbSet<Rcdc1> Rcdc1s { get; set; } = null!;
        public virtual DbSet<Rcdg1> Rcdg1s { get; set; } = null!;
        public virtual DbSet<Rcdl1> Rcdl1s { get; set; } = null!;
        public virtual DbSet<Rcdp1> Rcdp1s { get; set; } = null!;
        public virtual DbSet<Rchc1> Rchc1s { get; set; } = null!;
        public virtual DbSet<Rchd1> Rchd1s { get; set; } = null!;
        public virtual DbSet<Rcit1> Rcit1s { get; set; } = null!;
        public virtual DbSet<Rcla1> Rcla1s { get; set; } = null!;
        public virtual DbSet<Rcnt1> Rcnt1s { get; set; } = null!;
        public virtual DbSet<Rcpb1> Rcpb1s { get; set; } = null!;
        public virtual DbSet<Rcpc1> Rcpc1s { get; set; } = null!;
        public virtual DbSet<Rcpm1> Rcpm1s { get; set; } = null!;
        public virtual DbSet<Rcpt1> Rcpt1s { get; set; } = null!;
        public virtual DbSet<Rcsl1> Rcsl1s { get; set; } = null!;
        public virtual DbSet<Rcsm1> Rcsm1s { get; set; } = null!;
        public virtual DbSet<Rcsm2> Rcsm2s { get; set; } = null!;
        public virtual DbSet<Rcsp1> Rcsp1s { get; set; } = null!;
        public virtual DbSet<Rcsp2> Rcsp2s { get; set; } = null!;
        public virtual DbSet<Rctc1> Rctc1s { get; set; } = null!;
        public virtual DbSet<Rctl1> Rctl1s { get; set; } = null!;
        public virtual DbSet<Rcum1> Rcum1s { get; set; } = null!;
        public virtual DbSet<Rcun1> Rcun1s { get; set; } = null!;
        public virtual DbSet<Rcvs1> Rcvs1s { get; set; } = null!;
        public virtual DbSet<Rcvy1> Rcvy1s { get; set; } = null!;
        public virtual DbSet<Rcvy2> Rcvy2s { get; set; } = null!;
        public virtual DbSet<RoleInfo> RoleInfos { get; set; } = null!;
        public virtual DbSet<RolePerson> RolePeople { get; set; } = null!;
        public virtual DbSet<SaDatabaseColumnName> SaDatabaseColumnNames { get; set; } = null!;
        public virtual DbSet<SaDatabaseComment> SaDatabaseComments { get; set; } = null!;
        public virtual DbSet<SaDatabaseConstraintName> SaDatabaseConstraintNames { get; set; } = null!;
        public virtual DbSet<SaDatabaseIndex> SaDatabaseIndices { get; set; } = null!;
        public virtual DbSet<SaDatabaseIndexCheck> SaDatabaseIndexChecks { get; set; } = null!;
        public virtual DbSet<SaDatabaseObjectName> SaDatabaseObjectNames { get; set; } = null!;
        public virtual DbSet<SaDatabasePrimaryKey> SaDatabasePrimaryKeys { get; set; } = null!;
        public virtual DbSet<SaSystemField> SaSystemFields { get; set; } = null!;
        public virtual DbSet<SaUserLog> SaUserLogs { get; set; } = null!;
        public virtual DbSet<Saaa1> Saaa1s { get; set; } = null!;
        public virtual DbSet<Saal1> Saal1s { get; set; } = null!;
        public virtual DbSet<Saat1> Saat1s { get; set; } = null!;
        public virtual DbSet<Sabr1> Sabr1s { get; set; } = null!;
        public virtual DbSet<Sacb1> Sacb1s { get; set; } = null!;
        public virtual DbSet<Sacd1> Sacd1s { get; set; } = null!;
        public virtual DbSet<Saco1> Saco1s { get; set; } = null!;
        public virtual DbSet<Saco2> Saco2s { get; set; } = null!;
        public virtual DbSet<Saco3> Saco3s { get; set; } = null!;
        public virtual DbSet<Saco4> Saco4s { get; set; } = null!;
        public virtual DbSet<Saco5> Saco5s { get; set; } = null!;
        public virtual DbSet<Saco6> Saco6s { get; set; } = null!;
        public virtual DbSet<Sadl1> Sadl1s { get; set; } = null!;
        public virtual DbSet<Sadl2> Sadl2s { get; set; } = null!;
        public virtual DbSet<Saed1> Saed1s { get; set; } = null!;
        public virtual DbSet<Saed2> Saed2s { get; set; } = null!;
        public virtual DbSet<Sael1> Sael1s { get; set; } = null!;
        public virtual DbSet<Saem1> Saem1s { get; set; } = null!;
        public virtual DbSet<Saem2> Saem2s { get; set; } = null!;
        public virtual DbSet<Safd1> Safd1s { get; set; } = null!;
        public virtual DbSet<Safm1> Safm1s { get; set; } = null!;
        public virtual DbSet<Safm2> Safm2s { get; set; } = null!;
        public virtual DbSet<Safr1> Safr1s { get; set; } = null!;
        public virtual DbSet<Safr2> Safr2s { get; set; } = null!;
        public virtual DbSet<Sahd1> Sahd1s { get; set; } = null!;
        public virtual DbSet<Sajm1> Sajm1s { get; set; } = null!;
        public virtual DbSet<Samt1> Samt1s { get; set; } = null!;
        public virtual DbSet<Sanm1> Sanm1s { get; set; } = null!;
        public virtual DbSet<Sanm2> Sanm2s { get; set; } = null!;
        public virtual DbSet<Sant1> Sant1s { get; set; } = null!;
        public virtual DbSet<Saoh1> Saoh1s { get; set; } = null!;
        public virtual DbSet<Sapa1> Sapa1s { get; set; } = null!;
        public virtual DbSet<Sapb1> Sapb1s { get; set; } = null!;
        public virtual DbSet<Sapl1> Sapl1s { get; set; } = null!;
        public virtual DbSet<Sapp1> Sapp1s { get; set; } = null!;
        public virtual DbSet<Sapp2> Sapp2s { get; set; } = null!;
        public virtual DbSet<Sapp3> Sapp3s { get; set; } = null!;
        public virtual DbSet<Sapp4> Sapp4s { get; set; } = null!;
        public virtual DbSet<Sapp5> Sapp5s { get; set; } = null!;
        public virtual DbSet<Sapp6> Sapp6s { get; set; } = null!;
        public virtual DbSet<Sard1> Sard1s { get; set; } = null!;
        public virtual DbSet<Sarl1> Sarl1s { get; set; } = null!;
        public virtual DbSet<Sarm1> Sarm1s { get; set; } = null!;
        public virtual DbSet<Sarn1> Sarn1s { get; set; } = null!;
        public virtual DbSet<Sasc1> Sasc1s { get; set; } = null!;
        public virtual DbSet<Satb1> Satb1s { get; set; } = null!;
        public virtual DbSet<Satb2> Satb2s { get; set; } = null!;
        public virtual DbSet<Satp1> Satp1s { get; set; } = null!;
        public virtual DbSet<Saud1> Saud1s { get; set; } = null!;
        public virtual DbSet<Saug1> Saug1s { get; set; } = null!;
        public virtual DbSet<Saus1> Saus1s { get; set; } = null!;
        public virtual DbSet<Saus10> Saus10s { get; set; } = null!;
        public virtual DbSet<Saus11> Saus11s { get; set; } = null!;
        public virtual DbSet<Saus2> Saus2s { get; set; } = null!;
        public virtual DbSet<Saus3> Saus3s { get; set; } = null!;
        public virtual DbSet<Saus4> Saus4s { get; set; } = null!;
        public virtual DbSet<Saus5> Saus5s { get; set; } = null!;
        public virtual DbSet<Saus6> Saus6s { get; set; } = null!;
        public virtual DbSet<Saus7> Saus7s { get; set; } = null!;
        public virtual DbSet<Saus8> Saus8s { get; set; } = null!;
        public virtual DbSet<Saus9> Saus9s { get; set; } = null!;
        public virtual DbSet<Savl1> Savl1s { get; set; } = null!;
        public virtual DbSet<Sawf1> Sawf1s { get; set; } = null!;
        public virtual DbSet<Sawf2> Sawf2s { get; set; } = null!;
        public virtual DbSet<SeAllInternalBillingByMasterJob> SeAllInternalBillingByMasterJobs { get; set; } = null!;
        public virtual DbSet<SeBlConsolidation> SeBlConsolidations { get; set; } = null!;
        public virtual DbSet<SeBlPreparation> SeBlPreparations { get; set; } = null!;
        public virtual DbSet<SeBlReference> SeBlReferences { get; set; } = null!;
        public virtual DbSet<SeBookingEntry> SeBookingEntries { get; set; } = null!;
        public virtual DbSet<SeChargeWeight> SeChargeWeights { get; set; } = null!;
        public virtual DbSet<SeChargeWeightRatio> SeChargeWeightRatios { get; set; } = null!;
        public virtual DbSet<SeContainer> SeContainers { get; set; } = null!;
        public virtual DbSet<SeCreditInvoiceByJob> SeCreditInvoiceByJobs { get; set; } = null!;
        public virtual DbSet<SeCreditInvoiceByMasterJob> SeCreditInvoiceByMasterJobs { get; set; } = null!;
        public virtual DbSet<SeCreditInvoiceWithVatByMasterJob> SeCreditInvoiceWithVatByMasterJobs { get; set; } = null!;
        public virtual DbSet<SeCreditNoteByJob> SeCreditNoteByJobs { get; set; } = null!;
        public virtual DbSet<SeCreditNoteByMasterJob> SeCreditNoteByMasterJobs { get; set; } = null!;
        public virtual DbSet<SeCreditNoteWithVatByMasterJob> SeCreditNoteWithVatByMasterJobs { get; set; } = null!;
        public virtual DbSet<SeDebitNoteByJob> SeDebitNoteByJobs { get; set; } = null!;
        public virtual DbSet<SeDebitNoteByMasterJob> SeDebitNoteByMasterJobs { get; set; } = null!;
        public virtual DbSet<SeDebitNoteWithVatByMasterJob> SeDebitNoteWithVatByMasterJobs { get; set; } = null!;
        public virtual DbSet<SeFreightCollect> SeFreightCollects { get; set; } = null!;
        public virtual DbSet<SeFreightCollectByJob> SeFreightCollectByJobs { get; set; } = null!;
        public virtual DbSet<SeFreightCollectByJobFreight> SeFreightCollectByJobFreights { get; set; } = null!;
        public virtual DbSet<SeFreightCollectByJobOther> SeFreightCollectByJobOthers { get; set; } = null!;
        public virtual DbSet<SeFreightCollectUsd> SeFreightCollectUsds { get; set; } = null!;
        public virtual DbSet<SeImportRateByJob> SeImportRateByJobs { get; set; } = null!;
        public virtual DbSet<SeImportRateByMasterJob> SeImportRateByMasterJobs { get; set; } = null!;
        public virtual DbSet<SeImportRateExportByJob> SeImportRateExportByJobs { get; set; } = null!;
        public virtual DbSet<SeImportRateExportByMasterJob> SeImportRateExportByMasterJobs { get; set; } = null!;
        public virtual DbSet<SeInvoice1> SeInvoice1s { get; set; } = null!;
        public virtual DbSet<SeInvoice2> SeInvoice2s { get; set; } = null!;
        public virtual DbSet<SeInvoiceJob> SeInvoiceJobs { get; set; } = null!;
        public virtual DbSet<SeJobCosting> SeJobCostings { get; set; } = null!;
        public virtual DbSet<SeJobInvoice> SeJobInvoices { get; set; } = null!;
        public virtual DbSet<SePaymentVoucher1> SePaymentVoucher1s { get; set; } = null!;
        public virtual DbSet<SeShipmentSummary> SeShipmentSummaries { get; set; } = null!;
        public virtual DbSet<SeTranshipmentRateByJob> SeTranshipmentRateByJobs { get; set; } = null!;
        public virtual DbSet<SeTranshipmentRateByMasterJob> SeTranshipmentRateByMasterJobs { get; set; } = null!;
        public virtual DbSet<SeTranshipmentRateExportByJob> SeTranshipmentRateExportByJobs { get; set; } = null!;
        public virtual DbSet<SeTranshipmentRateExportByMasterJob> SeTranshipmentRateExportByMasterJobs { get; set; } = null!;
        public virtual DbSet<SeTsAllCollectByJob> SeTsAllCollectByJobs { get; set; } = null!;
        public virtual DbSet<SeTsAllCollectByMasterJob> SeTsAllCollectByMasterJobs { get; set; } = null!;
        public virtual DbSet<SeTsCostByMasterJob> SeTsCostByMasterJobs { get; set; } = null!;
        public virtual DbSet<SeTsExportFreightCollectByJob> SeTsExportFreightCollectByJobs { get; set; } = null!;
        public virtual DbSet<SeTsExportFreightCollectByMasterJob> SeTsExportFreightCollectByMasterJobs { get; set; } = null!;
        public virtual DbSet<SeTsFreightCollectByJob> SeTsFreightCollectByJobs { get; set; } = null!;
        public virtual DbSet<SeTsFreightCollectByMasterJob> SeTsFreightCollectByMasterJobs { get; set; } = null!;
        public virtual DbSet<SeTsFreightCollectCostByMasterJob> SeTsFreightCollectCostByMasterJobs { get; set; } = null!;
        public virtual DbSet<SeTsSalesByMasterJob> SeTsSalesByMasterJobs { get; set; } = null!;
        public virtual DbSet<Seat1> Seat1s { get; set; } = null!;
        public virtual DbSet<Sebh1> Sebh1s { get; set; } = null!;
        public virtual DbSet<Sebh2> Sebh2s { get; set; } = null!;
        public virtual DbSet<Sebk1> Sebk1s { get; set; } = null!;
        public virtual DbSet<Sebk2> Sebk2s { get; set; } = null!;
        public virtual DbSet<Sebk3> Sebk3s { get; set; } = null!;
        public virtual DbSet<Sebk4> Sebk4s { get; set; } = null!;
        public virtual DbSet<Sebk5> Sebk5s { get; set; } = null!;
        public virtual DbSet<Sebl1> Sebl1s { get; set; } = null!;
        public virtual DbSet<Sebl2> Sebl2s { get; set; } = null!;
        public virtual DbSet<Sebl3> Sebl3s { get; set; } = null!;
        public virtual DbSet<Sebl4> Sebl4s { get; set; } = null!;
        public virtual DbSet<Sebl5> Sebl5s { get; set; } = null!;
        public virtual DbSet<Sebl6> Sebl6s { get; set; } = null!;
        public virtual DbSet<Sebl7> Sebl7s { get; set; } = null!;
        public virtual DbSet<Sebl8> Sebl8s { get; set; } = null!;
        public virtual DbSet<Sebl9> Sebl9s { get; set; } = null!;
        public virtual DbSet<Secp1> Secp1s { get; set; } = null!;
        public virtual DbSet<Secp2> Secp2s { get; set; } = null!;
        public virtual DbSet<Sefp1> Sefp1s { get; set; } = null!;
        public virtual DbSet<Seiv1> Seiv1s { get; set; } = null!;
        public virtual DbSet<Seiv2> Seiv2s { get; set; } = null!;
        public virtual DbSet<Semp1> Semp1s { get; set; } = null!;
        public virtual DbSet<Semp2> Semp2s { get; set; } = null!;
        public virtual DbSet<Sepa1> Sepa1s { get; set; } = null!;
        public virtual DbSet<Sepi1> Sepi1s { get; set; } = null!;
        public virtual DbSet<Sepi2> Sepi2s { get; set; } = null!;
        public virtual DbSet<Sepv1> Sepv1s { get; set; } = null!;
        public virtual DbSet<Sepv2> Sepv2s { get; set; } = null!;
        public virtual DbSet<SiAllInternalBillingByMasterJob> SiAllInternalBillingByMasterJobs { get; set; } = null!;
        public virtual DbSet<SiBlEntry> SiBlEntries { get; set; } = null!;
        public virtual DbSet<SiBlReference> SiBlReferences { get; set; } = null!;
        public virtual DbSet<SiChargeWeight> SiChargeWeights { get; set; } = null!;
        public virtual DbSet<SiChargeWeightRatio> SiChargeWeightRatios { get; set; } = null!;
        public virtual DbSet<SiContainer> SiContainers { get; set; } = null!;
        public virtual DbSet<SiCreditInvoiceByMasterJob> SiCreditInvoiceByMasterJobs { get; set; } = null!;
        public virtual DbSet<SiCreditInvoiceWithVatByMasterJob> SiCreditInvoiceWithVatByMasterJobs { get; set; } = null!;
        public virtual DbSet<SiCreditNoteByMasterJob> SiCreditNoteByMasterJobs { get; set; } = null!;
        public virtual DbSet<SiCreditNoteWithVatByMasterJob> SiCreditNoteWithVatByMasterJobs { get; set; } = null!;
        public virtual DbSet<SiDebitNoteByMasterJob> SiDebitNoteByMasterJobs { get; set; } = null!;
        public virtual DbSet<SiDebitNoteWithVatByMasterJob> SiDebitNoteWithVatByMasterJobs { get; set; } = null!;
        public virtual DbSet<SiFreightCollect> SiFreightCollects { get; set; } = null!;
        public virtual DbSet<SiFreightCollectByJob> SiFreightCollectByJobs { get; set; } = null!;
        public virtual DbSet<SiFreightCollectByMasterJob> SiFreightCollectByMasterJobs { get; set; } = null!;
        public virtual DbSet<SiImportRateByJob> SiImportRateByJobs { get; set; } = null!;
        public virtual DbSet<SiImportRateByMasterJob> SiImportRateByMasterJobs { get; set; } = null!;
        public virtual DbSet<SiInvoice1> SiInvoice1s { get; set; } = null!;
        public virtual DbSet<SiInvoice2> SiInvoice2s { get; set; } = null!;
        public virtual DbSet<SiJobCosting> SiJobCostings { get; set; } = null!;
        public virtual DbSet<SiPaymentVoucher1> SiPaymentVoucher1s { get; set; } = null!;
        public virtual DbSet<SiSeTransportInstruction> SiSeTransportInstructions { get; set; } = null!;
        public virtual DbSet<SiSeTsFreightCollectByJob> SiSeTsFreightCollectByJobs { get; set; } = null!;
        public virtual DbSet<SiSeTsFreightCollectByMasterJob> SiSeTsFreightCollectByMasterJobs { get; set; } = null!;
        public virtual DbSet<SiShipmentSummary> SiShipmentSummaries { get; set; } = null!;
        public virtual DbSet<SiTranshipmentRateByJob> SiTranshipmentRateByJobs { get; set; } = null!;
        public virtual DbSet<SiTranshipmentRateByMasterJob> SiTranshipmentRateByMasterJobs { get; set; } = null!;
        public virtual DbSet<SiTsChargeCollectByJob> SiTsChargeCollectByJobs { get; set; } = null!;
        public virtual DbSet<SiTsChargeCollectByMasterJob> SiTsChargeCollectByMasterJobs { get; set; } = null!;
        public virtual DbSet<SiTsExportAllCollectByJob> SiTsExportAllCollectByJobs { get; set; } = null!;
        public virtual DbSet<SiTsExportAllCollectByMasterJob> SiTsExportAllCollectByMasterJobs { get; set; } = null!;
        public virtual DbSet<SiTsExportFreightCollectByJob> SiTsExportFreightCollectByJobs { get; set; } = null!;
        public virtual DbSet<SiTsExportFreightCollectByMasterJob> SiTsExportFreightCollectByMasterJobs { get; set; } = null!;
        public virtual DbSet<SiTsFreightCollectByJob> SiTsFreightCollectByJobs { get; set; } = null!;
        public virtual DbSet<SiTsFreightCollectByMasterJob> SiTsFreightCollectByMasterJobs { get; set; } = null!;
        public virtual DbSet<SiTsFreightCollectCostByMasterJob> SiTsFreightCollectCostByMasterJobs { get; set; } = null!;
        public virtual DbSet<SiTsFreightCollectSalesByMasterJob> SiTsFreightCollectSalesByMasterJobs { get; set; } = null!;
        public virtual DbSet<Sibl1> Sibl1s { get; set; } = null!;
        public virtual DbSet<Sibl10> Sibl10s { get; set; } = null!;
        public virtual DbSet<Sibl11> Sibl11s { get; set; } = null!;
        public virtual DbSet<Sibl2> Sibl2s { get; set; } = null!;
        public virtual DbSet<Sibl3> Sibl3s { get; set; } = null!;
        public virtual DbSet<Sibl4> Sibl4s { get; set; } = null!;
        public virtual DbSet<Sibl5> Sibl5s { get; set; } = null!;
        public virtual DbSet<Sibl6> Sibl6s { get; set; } = null!;
        public virtual DbSet<Sibl7> Sibl7s { get; set; } = null!;
        public virtual DbSet<Sibl8> Sibl8s { get; set; } = null!;
        public virtual DbSet<Sibl9> Sibl9s { get; set; } = null!;
        public virtual DbSet<Sicp1> Sicp1s { get; set; } = null!;
        public virtual DbSet<Sicp2> Sicp2s { get; set; } = null!;
        public virtual DbSet<Sidi1> Sidi1s { get; set; } = null!;
        public virtual DbSet<Sidi2> Sidi2s { get; set; } = null!;
        public virtual DbSet<Sido1> Sido1s { get; set; } = null!;
        public virtual DbSet<Sido2> Sido2s { get; set; } = null!;
        public virtual DbSet<Siiv1> Siiv1s { get; set; } = null!;
        public virtual DbSet<Siiv2> Siiv2s { get; set; } = null!;
        public virtual DbSet<Sipa1> Sipa1s { get; set; } = null!;
        public virtual DbSet<Sipv1> Sipv1s { get; set; } = null!;
        public virtual DbSet<Sipv2> Sipv2s { get; set; } = null!;
        public virtual DbSet<Sits1> Sits1s { get; set; } = null!;
        public virtual DbSet<Sits2> Sits2s { get; set; } = null!;
        public virtual DbSet<SlAdvancePayment> SlAdvancePayments { get; set; } = null!;
        public virtual DbSet<SlCustomerReceipt1> SlCustomerReceipt1s { get; set; } = null!;
        public virtual DbSet<SlCustomerReceipt2> SlCustomerReceipt2s { get; set; } = null!;
        public virtual DbSet<SlPlTransaction> SlPlTransactions { get; set; } = null!;
        public virtual DbSet<SlPlVat> SlPlVats { get; set; } = null!;
        public virtual DbSet<Slaj1> Slaj1s { get; set; } = null!;
        public virtual DbSet<SlajPost> SlajPosts { get; set; } = null!;
        public virtual DbSet<Slbs1> Slbs1s { get; set; } = null!;
        public virtual DbSet<Slcc1> Slcc1s { get; set; } = null!;
        public virtual DbSet<Slcm1> Slcm1s { get; set; } = null!;
        public virtual DbSet<Slcm2> Slcm2s { get; set; } = null!;
        public virtual DbSet<Slcr1> Slcr1s { get; set; } = null!;
        public virtual DbSet<Slcr2> Slcr2s { get; set; } = null!;
        public virtual DbSet<Slcr3> Slcr3s { get; set; } = null!;
        public virtual DbSet<Slcr4> Slcr4s { get; set; } = null!;
        public virtual DbSet<SlcrPost> SlcrPosts { get; set; } = null!;
        public virtual DbSet<Slcs1> Slcs1s { get; set; } = null!;
        public virtual DbSet<Slcs2> Slcs2s { get; set; } = null!;
        public virtual DbSet<SlcsPost> SlcsPosts { get; set; } = null!;
        public virtual DbSet<Slct1> Slct1s { get; set; } = null!;
        public virtual DbSet<Slcu1> Slcu1s { get; set; } = null!;
        public virtual DbSet<Slcu2> Slcu2s { get; set; } = null!;
        public virtual DbSet<Slcu3> Slcu3s { get; set; } = null!;
        public virtual DbSet<Slcu4> Slcu4s { get; set; } = null!;
        public virtual DbSet<Slcu5> Slcu5s { get; set; } = null!;
        public virtual DbSet<Slcu6> Slcu6s { get; set; } = null!;
        public virtual DbSet<Slpa1> Slpa1s { get; set; } = null!;
        public virtual DbSet<Sltx1> Sltx1s { get; set; } = null!;
        public virtual DbSet<SltxCheck> SltxChecks { get; set; } = null!;
        public virtual DbSet<SltxCheck2> SltxCheck2s { get; set; } = null!;
        public virtual DbSet<Slvx1> Slvx1s { get; set; } = null!;
        public virtual DbSet<Smbr1> Smbr1s { get; set; } = null!;
        public virtual DbSet<Smbr2> Smbr2s { get; set; } = null!;
        public virtual DbSet<Smct1> Smct1s { get; set; } = null!;
        public virtual DbSet<Smct2> Smct2s { get; set; } = null!;
        public virtual DbSet<Smct3> Smct3s { get; set; } = null!;
        public virtual DbSet<Smec1> Smec1s { get; set; } = null!;
        public virtual DbSet<Smec2> Smec2s { get; set; } = null!;
        public virtual DbSet<Smef1> Smef1s { get; set; } = null!;
        public virtual DbSet<Smef2> Smef2s { get; set; } = null!;
        public virtual DbSet<Smfd1> Smfd1s { get; set; } = null!;
        public virtual DbSet<Smfd2> Smfd2s { get; set; } = null!;
        public virtual DbSet<Smfq1> Smfq1s { get; set; } = null!;
        public virtual DbSet<Smfq2> Smfq2s { get; set; } = null!;
        public virtual DbSet<Smfq3> Smfq3s { get; set; } = null!;
        public virtual DbSet<Smfq4> Smfq4s { get; set; } = null!;
        public virtual DbSet<Smfq6> Smfq6s { get; set; } = null!;
        public virtual DbSet<Smhq1> Smhq1s { get; set; } = null!;
        public virtual DbSet<Smhq2> Smhq2s { get; set; } = null!;
        public virtual DbSet<Smht1> Smht1s { get; set; } = null!;
        public virtual DbSet<Smht2> Smht2s { get; set; } = null!;
        public virtual DbSet<Smic1> Smic1s { get; set; } = null!;
        public virtual DbSet<Smic2> Smic2s { get; set; } = null!;
        public virtual DbSet<Smif1> Smif1s { get; set; } = null!;
        public virtual DbSet<Smif2> Smif2s { get; set; } = null!;
        public virtual DbSet<Smiq1> Smiq1s { get; set; } = null!;
        public virtual DbSet<Smiq2> Smiq2s { get; set; } = null!;
        public virtual DbSet<Smit1> Smit1s { get; set; } = null!;
        public virtual DbSet<Smit2> Smit2s { get; set; } = null!;
        public virtual DbSet<Smpa1> Smpa1s { get; set; } = null!;
        public virtual DbSet<Smpa2> Smpa2s { get; set; } = null!;
        public virtual DbSet<Smqt1> Smqt1s { get; set; } = null!;
        public virtual DbSet<Smsa1> Smsa1s { get; set; } = null!;
        public virtual DbSet<Smsa2> Smsa2s { get; set; } = null!;
        public virtual DbSet<Ssjd1> Ssjd1s { get; set; } = null!;
        public virtual DbSet<Ssst1> Ssst1s { get; set; } = null!;
        public virtual DbSet<SysMenu> SysMenus { get; set; } = null!;
        public virtual DbSet<Sysconstraint> Sysconstraints { get; set; } = null!;
        public virtual DbSet<Syssegment> Syssegments { get; set; } = null!;
        public virtual DbSet<Tjms1> Tjms1s { get; set; } = null!;
        public virtual DbSet<Tmbi1> Tmbi1s { get; set; } = null!;
        public virtual DbSet<Tmbi2> Tmbi2s { get; set; } = null!;
        public virtual DbSet<TmpEdiMessage> TmpEdiMessages { get; set; } = null!;
        public virtual DbSet<TmpGlbr1> TmpGlbr1s { get; set; } = null!;
        public virtual DbSet<TmpJmpl1> TmpJmpl1s { get; set; } = null!;
        public virtual DbSet<Tncl1> Tncl1s { get; set; } = null!;
        public virtual DbSet<Tncp1> Tncp1s { get; set; } = null!;
        public virtual DbSet<Tnem1> Tnem1s { get; set; } = null!;
        public virtual DbSet<Tnex1> Tnex1s { get; set; } = null!;
        public virtual DbSet<Tnex2> Tnex2s { get; set; } = null!;
        public virtual DbSet<Tnhs1> Tnhs1s { get; set; } = null!;
        public virtual DbSet<Tnmp1> Tnmp1s { get; set; } = null!;
        public virtual DbSet<Tnpa1> Tnpa1s { get; set; } = null!;
        public virtual DbSet<Tnrc1> Tnrc1s { get; set; } = null!;
        public virtual DbSet<Tnrf1> Tnrf1s { get; set; } = null!;
        public virtual DbSet<Tnrf2> Tnrf2s { get; set; } = null!;
        public virtual DbSet<Tnsl1> Tnsl1s { get; set; } = null!;
        public virtual DbSet<TntGroupMap> TntGroupMaps { get; set; } = null!;
        public virtual DbSet<Tnum1> Tnum1s { get; set; } = null!;
        public virtual DbSet<Toac1> Toac1s { get; set; } = null!;
        public virtual DbSet<Tobk1> Tobk1s { get; set; } = null!;
        public virtual DbSet<Tobk2> Tobk2s { get; set; } = null!;
        public virtual DbSet<Tobk3> Tobk3s { get; set; } = null!;
        public virtual DbSet<Tobk4> Tobk4s { get; set; } = null!;
        public virtual DbSet<Tobk5> Tobk5s { get; set; } = null!;
        public virtual DbSet<Tobk6> Tobk6s { get; set; } = null!;
        public virtual DbSet<Toct1> Toct1s { get; set; } = null!;
        public virtual DbSet<Todo1> Todo1s { get; set; } = null!;
        public virtual DbSet<Todo2> Todo2s { get; set; } = null!;
        public virtual DbSet<Todo3> Todo3s { get; set; } = null!;
        public virtual DbSet<Todr1> Todr1s { get; set; } = null!;
        public virtual DbSet<Todr2> Todr2s { get; set; } = null!;
        public virtual DbSet<Toet1> Toet1s { get; set; } = null!;
        public virtual DbSet<Toiv1> Toiv1s { get; set; } = null!;
        public virtual DbSet<Toiv2> Toiv2s { get; set; } = null!;
        public virtual DbSet<Topa1> Topa1s { get; set; } = null!;
        public virtual DbSet<Topa2> Topa2s { get; set; } = null!;
        public virtual DbSet<Topv1> Topv1s { get; set; } = null!;
        public virtual DbSet<Topv2> Topv2s { get; set; } = null!;
        public virtual DbSet<Torc1> Torc1s { get; set; } = null!;
        public virtual DbSet<Torl1> Torl1s { get; set; } = null!;
        public virtual DbSet<Tosh1> Tosh1s { get; set; } = null!;
        public virtual DbSet<Toso1> Toso1s { get; set; } = null!;
        public virtual DbSet<Toso2> Toso2s { get; set; } = null!;
        public virtual DbSet<Tost1> Tost1s { get; set; } = null!;
        public virtual DbSet<Totc1> Totc1s { get; set; } = null!;
        public virtual DbSet<Totc2> Totc2s { get; set; } = null!;
        public virtual DbSet<Totd1> Totd1s { get; set; } = null!;
        public virtual DbSet<Totd2> Totd2s { get; set; } = null!;
        public virtual DbSet<Tovl1> Tovl1s { get; set; } = null!;
        public virtual DbSet<Tovm1> Tovm1s { get; set; } = null!;
        public virtual DbSet<Tovm2> Tovm2s { get; set; } = null!;
        public virtual DbSet<Tovt1> Tovt1s { get; set; } = null!;
        public virtual DbSet<Tpts1> Tpts1s { get; set; } = null!;
        public virtual DbSet<TtBillOfLading> TtBillOfLadings { get; set; } = null!;
        public virtual DbSet<Viexp> Viexps { get; set; } = null!;
        public virtual DbSet<VwAcar1> VwAcar1s { get; set; } = null!;
        public virtual DbSet<VwAccg1> VwAccg1s { get; set; } = null!;
        public virtual DbSet<VwAccm1> VwAccm1s { get; set; } = null!;
        public virtual DbSet<VwAcct1> VwAcct1s { get; set; } = null!;
        public virtual DbSet<VwAcct2> VwAcct2s { get; set; } = null!;
        public virtual DbSet<VwAcdv1> VwAcdv1s { get; set; } = null!;
        public virtual DbSet<VwAcft1> VwAcft1s { get; set; } = null!;
        public virtual DbSet<VwAcit1> VwAcit1s { get; set; } = null!;
        public virtual DbSet<VwAcit2> VwAcit2s { get; set; } = null!;
        public virtual DbSet<VwAcit3> VwAcit3s { get; set; } = null!;
        public virtual DbSet<VwActm1> VwActm1s { get; set; } = null!;
        public virtual DbSet<VwAcva1> VwAcva1s { get; set; } = null!;
        public virtual DbSet<VwAcva2> VwAcva2s { get; set; } = null!;
        public virtual DbSet<VwAcvr1> VwAcvr1s { get; set; } = null!;
        public virtual DbSet<VwAcws1> VwAcws1s { get; set; } = null!;
        public virtual DbSet<VwAcwt1> VwAcwt1s { get; set; } = null!;
        public virtual DbSet<VwAeaw1> VwAeaw1s { get; set; } = null!;
        public virtual DbSet<VwAeaw1SubHouseManifest> VwAeaw1SubHouseManifests { get; set; } = null!;
        public virtual DbSet<VwAeaw2> VwAeaw2s { get; set; } = null!;
        public virtual DbSet<VwAeaw3> VwAeaw3s { get; set; } = null!;
        public virtual DbSet<VwAeaw4> VwAeaw4s { get; set; } = null!;
        public virtual DbSet<VwAeaw5> VwAeaw5s { get; set; } = null!;
        public virtual DbSet<VwAeaw6> VwAeaw6s { get; set; } = null!;
        public virtual DbSet<VwAeawJob> VwAeawJobs { get; set; } = null!;
        public virtual DbSet<VwAebk1> VwAebk1s { get; set; } = null!;
        public virtual DbSet<VwAebk1DocNo> VwAebk1DocNos { get; set; } = null!;
        public virtual DbSet<VwAebk2> VwAebk2s { get; set; } = null!;
        public virtual DbSet<VwAebk3> VwAebk3s { get; set; } = null!;
        public virtual DbSet<VwAebkCargoSale> VwAebkCargoSales { get; set; } = null!;
        public virtual DbSet<VwAeca1> VwAeca1s { get; set; } = null!;
        public virtual DbSet<VwAect1> VwAect1s { get; set; } = null!;
        public virtual DbSet<VwAect2> VwAect2s { get; set; } = null!;
        public virtual DbSet<VwAeiv1> VwAeiv1s { get; set; } = null!;
        public virtual DbSet<VwAeiv1Vat> VwAeiv1Vats { get; set; } = null!;
        public virtual DbSet<VwAeiv2> VwAeiv2s { get; set; } = null!;
        public virtual DbSet<VwAeiv2Vat> VwAeiv2Vats { get; set; } = null!;
        public virtual DbSet<VwAemp1> VwAemp1s { get; set; } = null!;
        public virtual DbSet<VwAemp2> VwAemp2s { get; set; } = null!;
        public virtual DbSet<VwAepa1> VwAepa1s { get; set; } = null!;
        public virtual DbSet<VwAepa2> VwAepa2s { get; set; } = null!;
        public virtual DbSet<VwAepv1> VwAepv1s { get; set; } = null!;
        public virtual DbSet<VwAepv2> VwAepv2s { get; set; } = null!;
        public virtual DbSet<VwAewb1> VwAewb1s { get; set; } = null!;
        public virtual DbSet<VwAiaw1> VwAiaw1s { get; set; } = null!;
        public virtual DbSet<VwAiaw2> VwAiaw2s { get; set; } = null!;
        public virtual DbSet<VwAiawJob> VwAiawJobs { get; set; } = null!;
        public virtual DbSet<VwAido1> VwAido1s { get; set; } = null!;
        public virtual DbSet<VwAiiv1> VwAiiv1s { get; set; } = null!;
        public virtual DbSet<VwAiiv1Vat> VwAiiv1Vats { get; set; } = null!;
        public virtual DbSet<VwAiiv2> VwAiiv2s { get; set; } = null!;
        public virtual DbSet<VwAiiv2Vat> VwAiiv2Vats { get; set; } = null!;
        public virtual DbSet<VwAipa1> VwAipa1s { get; set; } = null!;
        public virtual DbSet<VwAipv1> VwAipv1s { get; set; } = null!;
        public virtual DbSet<VwAipv2> VwAipv2s { get; set; } = null!;
        public virtual DbSet<VwAmac1> VwAmac1s { get; set; } = null!;
        public virtual DbSet<VwAmac2> VwAmac2s { get; set; } = null!;
        public virtual DbSet<VwAmac3> VwAmac3s { get; set; } = null!;
        public virtual DbSet<VwAmad1> VwAmad1s { get; set; } = null!;
        public virtual DbSet<VwAmad2> VwAmad2s { get; set; } = null!;
        public virtual DbSet<VwAmah1> VwAmah1s { get; set; } = null!;
        public virtual DbSet<VwAmaq1> VwAmaq1s { get; set; } = null!;
        public virtual DbSet<VwAmbr1> VwAmbr1s { get; set; } = null!;
        public virtual DbSet<VwAmdc1> VwAmdc1s { get; set; } = null!;
        public virtual DbSet<VwAmfe1> VwAmfe1s { get; set; } = null!;
        public virtual DbSet<VwAmfq1> VwAmfq1s { get; set; } = null!;
        public virtual DbSet<VwAmfq2> VwAmfq2s { get; set; } = null!;
        public virtual DbSet<VwAmfq3> VwAmfq3s { get; set; } = null!;
        public virtual DbSet<VwAmfq4> VwAmfq4s { get; set; } = null!;
        public virtual DbSet<VwAmfq5> VwAmfq5s { get; set; } = null!;
        public virtual DbSet<VwAmfq6> VwAmfq6s { get; set; } = null!;
        public virtual DbSet<VwAmic1> VwAmic1s { get; set; } = null!;
        public virtual DbSet<VwAmid1> VwAmid1s { get; set; } = null!;
        public virtual DbSet<VwAmid2> VwAmid2s { get; set; } = null!;
        public virtual DbSet<VwAmie1> VwAmie1s { get; set; } = null!;
        public virtual DbSet<VwAmif1> VwAmif1s { get; set; } = null!;
        public virtual DbSet<VwAmio1> VwAmio1s { get; set; } = null!;
        public virtual DbSet<VwAmio2> VwAmio2s { get; set; } = null!;
        public virtual DbSet<VwAmir1> VwAmir1s { get; set; } = null!;
        public virtual DbSet<VwAmpa1> VwAmpa1s { get; set; } = null!;
        public virtual DbSet<VwAmqo1> VwAmqo1s { get; set; } = null!;
        public virtual DbSet<VwAmqo2> VwAmqo2s { get; set; } = null!;
        public virtual DbSet<VwAnac1> VwAnac1s { get; set; } = null!;
        public virtual DbSet<VwAnam1> VwAnam1s { get; set; } = null!;
        public virtual DbSet<VwAnat1> VwAnat1s { get; set; } = null!;
        public virtual DbSet<VwAnat2> VwAnat2s { get; set; } = null!;
        public virtual DbSet<VwAnbb1> VwAnbb1s { get; set; } = null!;
        public virtual DbSet<VwAnbb2> VwAnbb2s { get; set; } = null!;
        public virtual DbSet<VwAnbb3> VwAnbb3s { get; set; } = null!;
        public virtual DbSet<VwAncf1> VwAncf1s { get; set; } = null!;
        public virtual DbSet<VwAsjd1> VwAsjd1s { get; set; } = null!;
        public virtual DbSet<VwAsjd2> VwAsjd2s { get; set; } = null!;
        public virtual DbSet<VwAsjd3> VwAsjd3s { get; set; } = null!;
        public virtual DbSet<VwAsst1> VwAsst1s { get; set; } = null!;
        public virtual DbSet<VwBankTransaction> VwBankTransactions { get; set; } = null!;
        public virtual DbSet<VwBrba1> VwBrba1s { get; set; } = null!;
        public virtual DbSet<VwBrtx1> VwBrtx1s { get; set; } = null!;
        public virtual DbSet<VwCntrIdlingPort> VwCntrIdlingPorts { get; set; } = null!;
        public virtual DbSet<VwCsbk1> VwCsbk1s { get; set; } = null!;
        public virtual DbSet<VwCsbk2> VwCsbk2s { get; set; } = null!;
        public virtual DbSet<VwCtcl1> VwCtcl1s { get; set; } = null!;
        public virtual DbSet<VwCtdo1> VwCtdo1s { get; set; } = null!;
        public virtual DbSet<VwCtdo2> VwCtdo2s { get; set; } = null!;
        public virtual DbSet<VwCtfa1> VwCtfa1s { get; set; } = null!;
        public virtual DbSet<VwCtri1> VwCtri1s { get; set; } = null!;
        public virtual DbSet<VwCtro1> VwCtro1s { get; set; } = null!;
        public virtual DbSet<VwCtro2> VwCtro2s { get; set; } = null!;
        public virtual DbSet<VwCtrp1> VwCtrp1s { get; set; } = null!;
        public virtual DbSet<VwCtrp2> VwCtrp2s { get; set; } = null!;
        public virtual DbSet<VwCtso1> VwCtso1s { get; set; } = null!;
        public virtual DbSet<VwCtso2> VwCtso2s { get; set; } = null!;
        public virtual DbSet<VwEdal1> VwEdal1s { get; set; } = null!;
        public virtual DbSet<VwEdci1> VwEdci1s { get; set; } = null!;
        public virtual DbSet<VwEdct1> VwEdct1s { get; set; } = null!;
        public virtual DbSet<VwEdpk1> VwEdpk1s { get; set; } = null!;
        public virtual DbSet<VwExportAirTrackpoint> VwExportAirTrackpoints { get; set; } = null!;
        public virtual DbSet<VwExportAirTrackpoints20160902> VwExportAirTrackpoints20160902s { get; set; } = null!;
        public virtual DbSet<VwExportSeaTrackpoint> VwExportSeaTrackpoints { get; set; } = null!;
        public virtual DbSet<VwExportSeaTrackpoints20160902> VwExportSeaTrackpoints20160902s { get; set; } = null!;
        public virtual DbSet<VwGlbc1> VwGlbc1s { get; set; } = null!;
        public virtual DbSet<VwGlbc2> VwGlbc2s { get; set; } = null!;
        public virtual DbSet<VwGlbc3> VwGlbc3s { get; set; } = null!;
        public virtual DbSet<VwGlbh1> VwGlbh1s { get; set; } = null!;
        public virtual DbSet<VwGlbh2> VwGlbh2s { get; set; } = null!;
        public virtual DbSet<VwGlbl1> VwGlbl1s { get; set; } = null!;
        public virtual DbSet<VwGlbl1B> VwGlbl1Bs { get; set; } = null!;
        public virtual DbSet<VwGlbl1Bs1> VwGlbl1Bs1s { get; set; } = null!;
        public virtual DbSet<VwGlbl1DebitCredit> VwGlbl1DebitCredits { get; set; } = null!;
        public virtual DbSet<VwGlbl1Pl> VwGlbl1Pls { get; set; } = null!;
        public virtual DbSet<VwGlbl1PlSummary> VwGlbl1PlSummaries { get; set; } = null!;
        public virtual DbSet<VwGlbr1> VwGlbr1s { get; set; } = null!;
        public virtual DbSet<VwGlbt1> VwGlbt1s { get; set; } = null!;
        public virtual DbSet<VwGlcc1> VwGlcc1s { get; set; } = null!;
        public virtual DbSet<VwGlcf1> VwGlcf1s { get; set; } = null!;
        public virtual DbSet<VwGlch1> VwGlch1s { get; set; } = null!;
        public virtual DbSet<VwGlch2> VwGlch2s { get; set; } = null!;
        public virtual DbSet<VwGlct1> VwGlct1s { get; set; } = null!;
        public virtual DbSet<VwGldc1> VwGldc1s { get; set; } = null!;
        public virtual DbSet<VwGleh1> VwGleh1s { get; set; } = null!;
        public virtual DbSet<VwGlex1> VwGlex1s { get; set; } = null!;
        public virtual DbSet<VwGlex2> VwGlex2s { get; set; } = null!;
        public virtual DbSet<VwGlex21> VwGlex21s { get; set; } = null!;
        public virtual DbSet<VwGlfa1> VwGlfa1s { get; set; } = null!;
        public virtual DbSet<VwGlfb1> VwGlfb1s { get; set; } = null!;
        public virtual DbSet<VwGlfv1> VwGlfv1s { get; set; } = null!;
        public virtual DbSet<VwGljv1> VwGljv1s { get; set; } = null!;
        public virtual DbSet<VwGljv2> VwGljv2s { get; set; } = null!;
        public virtual DbSet<VwGljvAcc> VwGljvAccs { get; set; } = null!;
        public virtual DbSet<VwGljvJob> VwGljvJobs { get; set; } = null!;
        public virtual DbSet<VwGlma1> VwGlma1s { get; set; } = null!;
        public virtual DbSet<VwGlml1> VwGlml1s { get; set; } = null!;
        public virtual DbSet<VwGloc1> VwGloc1s { get; set; } = null!;
        public virtual DbSet<VwGlpa1> VwGlpa1s { get; set; } = null!;
        public virtual DbSet<VwGlpa2> VwGlpa2s { get; set; } = null!;
        public virtual DbSet<VwGlpp1> VwGlpp1s { get; set; } = null!;
        public virtual DbSet<VwGlrv1> VwGlrv1s { get; set; } = null!;
        public virtual DbSet<VwGlvx1> VwGlvx1s { get; set; } = null!;
        public virtual DbSet<VwGlwh1> VwGlwh1s { get; set; } = null!;
        public virtual DbSet<VwGlyl1> VwGlyl1s { get; set; } = null!;
        public virtual DbSet<VwGlyl1Jmjm1> VwGlyl1Jmjm1s { get; set; } = null!;
        public virtual DbSet<VwGlyl2> VwGlyl2s { get; set; } = null!;
        public virtual DbSet<VwIaOhInv> VwIaOhInvs { get; set; } = null!;
        public virtual DbSet<VwImcc1> VwImcc1s { get; set; } = null!;
        public virtual DbSet<VwImcc2> VwImcc2s { get; set; } = null!;
        public virtual DbSet<VwImga1> VwImga1s { get; set; } = null!;
        public virtual DbSet<VwImga2> VwImga2s { get; set; } = null!;
        public virtual DbSet<VwImgd1> VwImgd1s { get; set; } = null!;
        public virtual DbSet<VwImgd2> VwImgd2s { get; set; } = null!;
        public virtual DbSet<VwImgi1> VwImgi1s { get; set; } = null!;
        public virtual DbSet<VwImgi2> VwImgi2s { get; set; } = null!;
        public virtual DbSet<VwImgi3> VwImgi3s { get; set; } = null!;
        public virtual DbSet<VwImgi4> VwImgi4s { get; set; } = null!;
        public virtual DbSet<VwImgi5> VwImgi5s { get; set; } = null!;
        public virtual DbSet<VwImgi6> VwImgi6s { get; set; } = null!;
        public virtual DbSet<VwImgr1> VwImgr1s { get; set; } = null!;
        public virtual DbSet<VwImgr2> VwImgr2s { get; set; } = null!;
        public virtual DbSet<VwImgr3> VwImgr3s { get; set; } = null!;
        public virtual DbSet<VwImia1> VwImia1s { get; set; } = null!;
        public virtual DbSet<VwImip1> VwImip1s { get; set; } = null!;
        public virtual DbSet<VwImit1> VwImit1s { get; set; } = null!;
        public virtual DbSet<VwImit2> VwImit2s { get; set; } = null!;
        public virtual DbSet<VwImlt1> VwImlt1s { get; set; } = null!;
        public virtual DbSet<VwImlt2> VwImlt2s { get; set; } = null!;
        public virtual DbSet<VwImms1> VwImms1s { get; set; } = null!;
        public virtual DbSet<VwImpa1> VwImpa1s { get; set; } = null!;
        public virtual DbSet<VwImpc1> VwImpc1s { get; set; } = null!;
        public virtual DbSet<VwImpm1> VwImpm1s { get; set; } = null!;
        public virtual DbSet<VwImpm11> VwImpm11s { get; set; } = null!;
        public virtual DbSet<VwImpm1ActualStatus> VwImpm1ActualStatuses { get; set; } = null!;
        public virtual DbSet<VwImpm1Batch> VwImpm1Batches { get; set; } = null!;
        public virtual DbSet<VwImpm1Imgr1> VwImpm1Imgr1s { get; set; } = null!;
        public virtual DbSet<VwImpm1Issue> VwImpm1Issues { get; set; } = null!;
        public virtual DbSet<VwImpm1Picked> VwImpm1Pickeds { get; set; } = null!;
        public virtual DbSet<VwImpm2> VwImpm2s { get; set; } = null!;
        public virtual DbSet<VwImpmStoreType> VwImpmStoreTypes { get; set; } = null!;
        public virtual DbSet<VwImpn1> VwImpn1s { get; set; } = null!;
        public virtual DbSet<VwImpo1> VwImpo1s { get; set; } = null!;
        public virtual DbSet<VwImpo2> VwImpo2s { get; set; } = null!;
        public virtual DbSet<VwImpo3> VwImpo3s { get; set; } = null!;
        public virtual DbSet<VwImpo4> VwImpo4s { get; set; } = null!;
        public virtual DbSet<VwImportAirTrackpoint> VwImportAirTrackpoints { get; set; } = null!;
        public virtual DbSet<VwImportAirTrackpoints20160902> VwImportAirTrackpoints20160902s { get; set; } = null!;
        public virtual DbSet<VwImportSeaTrackpoint> VwImportSeaTrackpoints { get; set; } = null!;
        public virtual DbSet<VwImportSeaTrackpoints20160902> VwImportSeaTrackpoints20160902s { get; set; } = null!;
        public virtual DbSet<VwImpr1> VwImpr1s { get; set; } = null!;
        public virtual DbSet<VwImpr2> VwImpr2s { get; set; } = null!;
        public virtual DbSet<VwImpr3> VwImpr3s { get; set; } = null!;
        public virtual DbSet<VwImpv1> VwImpv1s { get; set; } = null!;
        public virtual DbSet<VwImpv2> VwImpv2s { get; set; } = null!;
        public virtual DbSet<VwImsd1> VwImsd1s { get; set; } = null!;
        public virtual DbSet<VwImsl1> VwImsl1s { get; set; } = null!;
        public virtual DbSet<VwImsn1> VwImsn1s { get; set; } = null!;
        public virtual DbSet<VwImso1> VwImso1s { get; set; } = null!;
        public virtual DbSet<VwImso2> VwImso2s { get; set; } = null!;
        public virtual DbSet<VwImso3> VwImso3s { get; set; } = null!;
        public virtual DbSet<VwInms1> VwInms1s { get; set; } = null!;
        public virtual DbSet<VwIvch1> VwIvch1s { get; set; } = null!;
        public virtual DbSet<VwIvch1Vat> VwIvch1Vats { get; set; } = null!;
        public virtual DbSet<VwIvch2> VwIvch2s { get; set; } = null!;
        public virtual DbSet<VwIvch2Vat> VwIvch2Vats { get; set; } = null!;
        public virtual DbSet<VwIvchAcc> VwIvchAccs { get; set; } = null!;
        public virtual DbSet<VwIvci1> VwIvci1s { get; set; } = null!;
        public virtual DbSet<VwIvcr1> VwIvcr1s { get; set; } = null!;
        public virtual DbSet<VwIvcr1ForeignAmt> VwIvcr1ForeignAmts { get; set; } = null!;
        public virtual DbSet<VwIvcr1FreightCollect> VwIvcr1FreightCollects { get; set; } = null!;
        public virtual DbSet<VwIvcr1Gst> VwIvcr1Gsts { get; set; } = null!;
        public virtual DbSet<VwIvcr1LocalInvoice> VwIvcr1LocalInvoices { get; set; } = null!;
        public virtual DbSet<VwIvcr1NoDel> VwIvcr1NoDels { get; set; } = null!;
        public virtual DbSet<VwIvcr1NoVatOutLay> VwIvcr1NoVatOutLays { get; set; } = null!;
        public virtual DbSet<VwIvcr1Rebate> VwIvcr1Rebates { get; set; } = null!;
        public virtual DbSet<VwIvcr1Vat> VwIvcr1Vats { get; set; } = null!;
        public virtual DbSet<VwIvcr1VatOutLay> VwIvcr1VatOutLays { get; set; } = null!;
        public virtual DbSet<VwIvcr2> VwIvcr2s { get; set; } = null!;
        public virtual DbSet<VwIvcr21> VwIvcr21s { get; set; } = null!;
        public virtual DbSet<VwIvcr2Job> VwIvcr2Jobs { get; set; } = null!;
        public virtual DbSet<VwIvcr2Plvi2Cost> VwIvcr2Plvi2Costs { get; set; } = null!;
        public virtual DbSet<VwIvcr2Vat> VwIvcr2Vats { get; set; } = null!;
        public virtual DbSet<VwIvcr3> VwIvcr3s { get; set; } = null!;
        public virtual DbSet<VwIvcrAcc> VwIvcrAccs { get; set; } = null!;
        public virtual DbSet<VwIvcrFlag> VwIvcrFlags { get; set; } = null!;
        public virtual DbSet<VwIvcsl> VwIvcsls { get; set; } = null!;
        public virtual DbSet<VwIvpa1> VwIvpa1s { get; set; } = null!;
        public virtual DbSet<VwIvpa2> VwIvpa2s { get; set; } = null!;
        public virtual DbSet<VwIvpa3> VwIvpa3s { get; set; } = null!;
        public virtual DbSet<VwJmaj1> VwJmaj1s { get; set; } = null!;
        public virtual DbSet<VwJmce1> VwJmce1s { get; set; } = null!;
        public virtual DbSet<VwJmce2> VwJmce2s { get; set; } = null!;
        public virtual DbSet<VwJmce3> VwJmce3s { get; set; } = null!;
        public virtual DbSet<VwJmce4> VwJmce4s { get; set; } = null!;
        public virtual DbSet<VwJmcm1> VwJmcm1s { get; set; } = null!;
        public virtual DbSet<VwJmcs1> VwJmcs1s { get; set; } = null!;
        public virtual DbSet<VwJmct1> VwJmct1s { get; set; } = null!;
        public virtual DbSet<VwJmdo1> VwJmdo1s { get; set; } = null!;
        public virtual DbSet<VwJmdt1> VwJmdt1s { get; set; } = null!;
        public virtual DbSet<VwJmdt2> VwJmdt2s { get; set; } = null!;
        public virtual DbSet<VwJmdt3> VwJmdt3s { get; set; } = null!;
        public virtual DbSet<VwJmdt4> VwJmdt4s { get; set; } = null!;
        public virtual DbSet<VwJmeg1> VwJmeg1s { get; set; } = null!;
        public virtual DbSet<VwJmeg2> VwJmeg2s { get; set; } = null!;
        public virtual DbSet<VwJmfb1> VwJmfb1s { get; set; } = null!;
        public virtual DbSet<VwJmje1> VwJmje1s { get; set; } = null!;
        public virtual DbSet<VwJmje2> VwJmje2s { get; set; } = null!;
        public virtual DbSet<VwJmjm1> VwJmjm1s { get; set; } = null!;
        public virtual DbSet<VwJmjm11> VwJmjm11s { get; set; } = null!;
        public virtual DbSet<VwJmjm12> VwJmjm12s { get; set; } = null!;
        public virtual DbSet<VwJmjm1ContainerTotal> VwJmjm1ContainerTotals { get; set; } = null!;
        public virtual DbSet<VwJmjm1Customer> VwJmjm1Customers { get; set; } = null!;
        public virtual DbSet<VwJmjm1DocNo> VwJmjm1DocNos { get; set; } = null!;
        public virtual DbSet<VwJmjm1InvoiceDate> VwJmjm1InvoiceDates { get; set; } = null!;
        public virtual DbSet<VwJmjm1SalesDate> VwJmjm1SalesDates { get; set; } = null!;
        public virtual DbSet<VwJmjm1UserDefine> VwJmjm1UserDefines { get; set; } = null!;
        public virtual DbSet<VwJmjm2> VwJmjm2s { get; set; } = null!;
        public virtual DbSet<VwJmjm2CostAedoc> VwJmjm2CostAedocs { get; set; } = null!;
        public virtual DbSet<VwJmjm2CostAidoc> VwJmjm2CostAidocs { get; set; } = null!;
        public virtual DbSet<VwJmjm2CostInvoice> VwJmjm2CostInvoices { get; set; } = null!;
        public virtual DbSet<VwJmjm2NoInvoice> VwJmjm2NoInvoices { get; set; } = null!;
        public virtual DbSet<VwJmjm2NoInvoiceByJob> VwJmjm2NoInvoiceByJobs { get; set; } = null!;
        public virtual DbSet<VwJmjm2NoInvoiceByMasterJob> VwJmjm2NoInvoiceByMasterJobs { get; set; } = null!;
        public virtual DbSet<VwJmjm2NoPurchase> VwJmjm2NoPurchases { get; set; } = null!;
        public virtual DbSet<VwJmjm2NoPurchaseByJob> VwJmjm2NoPurchaseByJobs { get; set; } = null!;
        public virtual DbSet<VwJmjm2NoPurchaseByMasterJob> VwJmjm2NoPurchaseByMasterJobs { get; set; } = null!;
        public virtual DbSet<VwJmjm2WithInvoice> VwJmjm2WithInvoices { get; set; } = null!;
        public virtual DbSet<VwJmjm3> VwJmjm3s { get; set; } = null!;
        public virtual DbSet<VwJmjm4> VwJmjm4s { get; set; } = null!;
        public virtual DbSet<VwJmjm5> VwJmjm5s { get; set; } = null!;
        public virtual DbSet<VwJmjm6> VwJmjm6s { get; set; } = null!;
        public virtual DbSet<VwJmjm7> VwJmjm7s { get; set; } = null!;
        public virtual DbSet<VwJmjs1> VwJmjs1s { get; set; } = null!;
        public virtual DbSet<VwJmjs2> VwJmjs2s { get; set; } = null!;
        public virtual DbSet<VwJmjt1> VwJmjt1s { get; set; } = null!;
        public virtual DbSet<VwJmmp1> VwJmmp1s { get; set; } = null!;
        public virtual DbSet<VwJmpa1> VwJmpa1s { get; set; } = null!;
        public virtual DbSet<VwJmpa2> VwJmpa2s { get; set; } = null!;
        public virtual DbSet<VwJmpa3> VwJmpa3s { get; set; } = null!;
        public virtual DbSet<VwJmpj1> VwJmpj1s { get; set; } = null!;
        public virtual DbSet<VwJmpt1> VwJmpt1s { get; set; } = null!;
        public virtual DbSet<VwJmrk1> VwJmrk1s { get; set; } = null!;
        public virtual DbSet<VwJmsc1> VwJmsc1s { get; set; } = null!;
        public virtual DbSet<VwJmsc2> VwJmsc2s { get; set; } = null!;
        public virtual DbSet<VwJmtn1> VwJmtn1s { get; set; } = null!;
        public virtual DbSet<VwJmtn2> VwJmtn2s { get; set; } = null!;
        public virtual DbSet<VwJmtn3> VwJmtn3s { get; set; } = null!;
        public virtual DbSet<VwJmtn4> VwJmtn4s { get; set; } = null!;
        public virtual DbSet<VwJmtn5> VwJmtn5s { get; set; } = null!;
        public virtual DbSet<VwJmtn6> VwJmtn6s { get; set; } = null!;
        public virtual DbSet<VwJmtn8> VwJmtn8s { get; set; } = null!;
        public virtual DbSet<VwJmwo1> VwJmwo1s { get; set; } = null!;
        public virtual DbSet<VwMovementEnquiry> VwMovementEnquiries { get; set; } = null!;
        public virtual DbSet<VwOmdy1> VwOmdy1s { get; set; } = null!;
        public virtual DbSet<VwOmdy2> VwOmdy2s { get; set; } = null!;
        public virtual DbSet<VwOmlc1> VwOmlc1s { get; set; } = null!;
        public virtual DbSet<VwOmoh1> VwOmoh1s { get; set; } = null!;
        public virtual DbSet<VwOmor1> VwOmor1s { get; set; } = null!;
        public virtual DbSet<VwOmor2> VwOmor2s { get; set; } = null!;
        public virtual DbSet<VwOmpa1> VwOmpa1s { get; set; } = null!;
        public virtual DbSet<VwOmsr1> VwOmsr1s { get; set; } = null!;
        public virtual DbSet<VwOmtx1> VwOmtx1s { get; set; } = null!;
        public virtual DbSet<VwOmtx11> VwOmtx11s { get; set; } = null!;
        public virtual DbSet<VwOmtx2> VwOmtx2s { get; set; } = null!;
        public virtual DbSet<VwOmtx3> VwOmtx3s { get; set; } = null!;
        public virtual DbSet<VwOmtx4> VwOmtx4s { get; set; } = null!;
        public virtual DbSet<VwOmtx5> VwOmtx5s { get; set; } = null!;
        public virtual DbSet<VwOmtx6> VwOmtx6s { get; set; } = null!;
        public virtual DbSet<VwOmtx7> VwOmtx7s { get; set; } = null!;
        public virtual DbSet<VwPlaj1> VwPlaj1s { get; set; } = null!;
        public virtual DbSet<VwPlcp1> VwPlcp1s { get; set; } = null!;
        public virtual DbSet<VwPlcp2> VwPlcp2s { get; set; } = null!;
        public virtual DbSet<VwPlcpAcc> VwPlcpAccs { get; set; } = null!;
        public virtual DbSet<VwPlcs1> VwPlcs1s { get; set; } = null!;
        public virtual DbSet<VwPlcs2> VwPlcs2s { get; set; } = null!;
        public virtual DbSet<VwPlcsl> VwPlcsls { get; set; } = null!;
        public virtual DbSet<VwPlhp1> VwPlhp1s { get; set; } = null!;
        public virtual DbSet<VwPlpa1> VwPlpa1s { get; set; } = null!;
        public virtual DbSet<VwPlpm1> VwPlpm1s { get; set; } = null!;
        public virtual DbSet<VwPlpm2> VwPlpm2s { get; set; } = null!;
        public virtual DbSet<VwPlpm3> VwPlpm3s { get; set; } = null!;
        public virtual DbSet<VwPlpmAcc> VwPlpmAccs { get; set; } = null!;
        public virtual DbSet<VwPlti1> VwPlti1s { get; set; } = null!;
        public virtual DbSet<VwPltx1> VwPltx1s { get; set; } = null!;
        public virtual DbSet<VwPlvi1> VwPlvi1s { get; set; } = null!;
        public virtual DbSet<VwPlvi1Gst> VwPlvi1Gsts { get; set; } = null!;
        public virtual DbSet<VwPlvi2> VwPlvi2s { get; set; } = null!;
        public virtual DbSet<VwPlvi2Job> VwPlvi2Jobs { get; set; } = null!;
        public virtual DbSet<VwPlvi3> VwPlvi3s { get; set; } = null!;
        public virtual DbSet<VwPlvi4> VwPlvi4s { get; set; } = null!;
        public virtual DbSet<VwPlvi5> VwPlvi5s { get; set; } = null!;
        public virtual DbSet<VwPlvi6> VwPlvi6s { get; set; } = null!;
        public virtual DbSet<VwPlviAcc> VwPlviAccs { get; set; } = null!;
        public virtual DbSet<VwPlvn1> VwPlvn1s { get; set; } = null!;
        public virtual DbSet<VwPlvn2> VwPlvn2s { get; set; } = null!;
        public virtual DbSet<VwPlvn3> VwPlvn3s { get; set; } = null!;
        public virtual DbSet<VwPlvn4> VwPlvn4s { get; set; } = null!;
        public virtual DbSet<VwPlvt1> VwPlvt1s { get; set; } = null!;
        public virtual DbSet<VwPlvx1> VwPlvx1s { get; set; } = null!;
        public virtual DbSet<VwPlvx11> VwPlvx11s { get; set; } = null!;
        public virtual DbSet<VwPlvx1Aug> VwPlvx1Augs { get; set; } = null!;
        public virtual DbSet<VwPlvx1Na> VwPlvx1Nas { get; set; } = null!;
        public virtual DbSet<VwPlvx1Sin> VwPlvx1Sins { get; set; } = null!;
        public virtual DbSet<VwPopo1> VwPopo1s { get; set; } = null!;
        public virtual DbSet<VwPopo2> VwPopo2s { get; set; } = null!;
        public virtual DbSet<VwPopo3> VwPopo3s { get; set; } = null!;
        public virtual DbSet<VwRcab1> VwRcab1s { get; set; } = null!;
        public virtual DbSet<VwRcal1> VwRcal1s { get; set; } = null!;
        public virtual DbSet<VwRcam1> VwRcam1s { get; set; } = null!;
        public virtual DbSet<VwRcap1> VwRcap1s { get; set; } = null!;
        public virtual DbSet<VwRcbo1> VwRcbo1s { get; set; } = null!;
        public virtual DbSet<VwRcbp1> VwRcbp1s { get; set; } = null!;
        public virtual DbSet<VwRcbp10> VwRcbp10s { get; set; } = null!;
        public virtual DbSet<VwRcbp11> VwRcbp11s { get; set; } = null!;
        public virtual DbSet<VwRcbp12> VwRcbp12s { get; set; } = null!;
        public virtual DbSet<VwRcbp2> VwRcbp2s { get; set; } = null!;
        public virtual DbSet<VwRcbp3> VwRcbp3s { get; set; } = null!;
        public virtual DbSet<VwRcbp4> VwRcbp4s { get; set; } = null!;
        public virtual DbSet<VwRcbp5> VwRcbp5s { get; set; } = null!;
        public virtual DbSet<VwRcbp6> VwRcbp6s { get; set; } = null!;
        public virtual DbSet<VwRcbp7> VwRcbp7s { get; set; } = null!;
        public virtual DbSet<VwRcbp8> VwRcbp8s { get; set; } = null!;
        public virtual DbSet<VwRcbp9> VwRcbp9s { get; set; } = null!;
        public virtual DbSet<VwRcbt1> VwRcbt1s { get; set; } = null!;
        public virtual DbSet<VwRcbx1> VwRcbx1s { get; set; } = null!;
        public virtual DbSet<VwRcbx2> VwRcbx2s { get; set; } = null!;
        public virtual DbSet<VwRccc1> VwRccc1s { get; set; } = null!;
        public virtual DbSet<VwRccd1> VwRccd1s { get; set; } = null!;
        public virtual DbSet<VwRccf1> VwRccf1s { get; set; } = null!;
        public virtual DbSet<VwRccf2> VwRccf2s { get; set; } = null!;
        public virtual DbSet<VwRccm1> VwRccm1s { get; set; } = null!;
        public virtual DbSet<VwRcco1> VwRcco1s { get; set; } = null!;
        public virtual DbSet<VwRcct1> VwRcct1s { get; set; } = null!;
        public virtual DbSet<VwRccy1> VwRccy1s { get; set; } = null!;
        public virtual DbSet<VwRccy1HandlingInstruction> VwRccy1HandlingInstructions { get; set; } = null!;
        public virtual DbSet<VwRccy2> VwRccy2s { get; set; } = null!;
        public virtual DbSet<VwRccy3> VwRccy3s { get; set; } = null!;
        public virtual DbSet<VwRcdc1> VwRcdc1s { get; set; } = null!;
        public virtual DbSet<VwRcdg1> VwRcdg1s { get; set; } = null!;
        public virtual DbSet<VwRcdl1> VwRcdl1s { get; set; } = null!;
        public virtual DbSet<VwRcdp1> VwRcdp1s { get; set; } = null!;
        public virtual DbSet<VwRchc1> VwRchc1s { get; set; } = null!;
        public virtual DbSet<VwRchd1> VwRchd1s { get; set; } = null!;
        public virtual DbSet<VwRcit1> VwRcit1s { get; set; } = null!;
        public virtual DbSet<VwRcla1> VwRcla1s { get; set; } = null!;
        public virtual DbSet<VwRcnt1> VwRcnt1s { get; set; } = null!;
        public virtual DbSet<VwRcpb1> VwRcpb1s { get; set; } = null!;
        public virtual DbSet<VwRcpc1> VwRcpc1s { get; set; } = null!;
        public virtual DbSet<VwRcpm1> VwRcpm1s { get; set; } = null!;
        public virtual DbSet<VwRcpt1> VwRcpt1s { get; set; } = null!;
        public virtual DbSet<VwRcsl1> VwRcsl1s { get; set; } = null!;
        public virtual DbSet<VwRcsm1> VwRcsm1s { get; set; } = null!;
        public virtual DbSet<VwRcsm2> VwRcsm2s { get; set; } = null!;
        public virtual DbSet<VwRcsp1> VwRcsp1s { get; set; } = null!;
        public virtual DbSet<VwRcsp2> VwRcsp2s { get; set; } = null!;
        public virtual DbSet<VwRctc1> VwRctc1s { get; set; } = null!;
        public virtual DbSet<VwRctl1> VwRctl1s { get; set; } = null!;
        public virtual DbSet<VwRcum1> VwRcum1s { get; set; } = null!;
        public virtual DbSet<VwRcun1> VwRcun1s { get; set; } = null!;
        public virtual DbSet<VwRcvs1> VwRcvs1s { get; set; } = null!;
        public virtual DbSet<VwRcvy1> VwRcvy1s { get; set; } = null!;
        public virtual DbSet<VwRcvy2> VwRcvy2s { get; set; } = null!;
        public virtual DbSet<VwSaaa1> VwSaaa1s { get; set; } = null!;
        public virtual DbSet<VwSaal1> VwSaal1s { get; set; } = null!;
        public virtual DbSet<VwSaat1> VwSaat1s { get; set; } = null!;
        public virtual DbSet<VwSabr1> VwSabr1s { get; set; } = null!;
        public virtual DbSet<VwSacb1> VwSacb1s { get; set; } = null!;
        public virtual DbSet<VwSacd1> VwSacd1s { get; set; } = null!;
        public virtual DbSet<VwSaco1> VwSaco1s { get; set; } = null!;
        public virtual DbSet<VwSaco2> VwSaco2s { get; set; } = null!;
        public virtual DbSet<VwSaco3> VwSaco3s { get; set; } = null!;
        public virtual DbSet<VwSaco4> VwSaco4s { get; set; } = null!;
        public virtual DbSet<VwSaco5> VwSaco5s { get; set; } = null!;
        public virtual DbSet<VwSaco6> VwSaco6s { get; set; } = null!;
        public virtual DbSet<VwSadl1> VwSadl1s { get; set; } = null!;
        public virtual DbSet<VwSadl2> VwSadl2s { get; set; } = null!;
        public virtual DbSet<VwSaed1> VwSaed1s { get; set; } = null!;
        public virtual DbSet<VwSaed2> VwSaed2s { get; set; } = null!;
        public virtual DbSet<VwSael1> VwSael1s { get; set; } = null!;
        public virtual DbSet<VwSaem1> VwSaem1s { get; set; } = null!;
        public virtual DbSet<VwSaem2> VwSaem2s { get; set; } = null!;
        public virtual DbSet<VwSafd1> VwSafd1s { get; set; } = null!;
        public virtual DbSet<VwSafm1> VwSafm1s { get; set; } = null!;
        public virtual DbSet<VwSafm2> VwSafm2s { get; set; } = null!;
        public virtual DbSet<VwSafr1> VwSafr1s { get; set; } = null!;
        public virtual DbSet<VwSafr2> VwSafr2s { get; set; } = null!;
        public virtual DbSet<VwSahd1> VwSahd1s { get; set; } = null!;
        public virtual DbSet<VwSajm1> VwSajm1s { get; set; } = null!;
        public virtual DbSet<VwSamt1> VwSamt1s { get; set; } = null!;
        public virtual DbSet<VwSanm1> VwSanm1s { get; set; } = null!;
        public virtual DbSet<VwSanm2> VwSanm2s { get; set; } = null!;
        public virtual DbSet<VwSant1> VwSant1s { get; set; } = null!;
        public virtual DbSet<VwSaoh1> VwSaoh1s { get; set; } = null!;
        public virtual DbSet<VwSapa1> VwSapa1s { get; set; } = null!;
        public virtual DbSet<VwSapb1> VwSapb1s { get; set; } = null!;
        public virtual DbSet<VwSapl1> VwSapl1s { get; set; } = null!;
        public virtual DbSet<VwSapp1> VwSapp1s { get; set; } = null!;
        public virtual DbSet<VwSapp2> VwSapp2s { get; set; } = null!;
        public virtual DbSet<VwSapp3> VwSapp3s { get; set; } = null!;
        public virtual DbSet<VwSapp4> VwSapp4s { get; set; } = null!;
        public virtual DbSet<VwSapp5> VwSapp5s { get; set; } = null!;
        public virtual DbSet<VwSapp6> VwSapp6s { get; set; } = null!;
        public virtual DbSet<VwSard1> VwSard1s { get; set; } = null!;
        public virtual DbSet<VwSarl1> VwSarl1s { get; set; } = null!;
        public virtual DbSet<VwSarm1> VwSarm1s { get; set; } = null!;
        public virtual DbSet<VwSarn1> VwSarn1s { get; set; } = null!;
        public virtual DbSet<VwSasc1> VwSasc1s { get; set; } = null!;
        public virtual DbSet<VwSatb1> VwSatb1s { get; set; } = null!;
        public virtual DbSet<VwSatb2> VwSatb2s { get; set; } = null!;
        public virtual DbSet<VwSatp1> VwSatp1s { get; set; } = null!;
        public virtual DbSet<VwSaud1> VwSaud1s { get; set; } = null!;
        public virtual DbSet<VwSaug1> VwSaug1s { get; set; } = null!;
        public virtual DbSet<VwSaus1> VwSaus1s { get; set; } = null!;
        public virtual DbSet<VwSaus10> VwSaus10s { get; set; } = null!;
        public virtual DbSet<VwSaus11> VwSaus11s { get; set; } = null!;
        public virtual DbSet<VwSaus2> VwSaus2s { get; set; } = null!;
        public virtual DbSet<VwSaus3> VwSaus3s { get; set; } = null!;
        public virtual DbSet<VwSaus4> VwSaus4s { get; set; } = null!;
        public virtual DbSet<VwSaus5> VwSaus5s { get; set; } = null!;
        public virtual DbSet<VwSaus6> VwSaus6s { get; set; } = null!;
        public virtual DbSet<VwSaus7> VwSaus7s { get; set; } = null!;
        public virtual DbSet<VwSaus8> VwSaus8s { get; set; } = null!;
        public virtual DbSet<VwSaus9> VwSaus9s { get; set; } = null!;
        public virtual DbSet<VwSavl1> VwSavl1s { get; set; } = null!;
        public virtual DbSet<VwSawf1> VwSawf1s { get; set; } = null!;
        public virtual DbSet<VwSawf2> VwSawf2s { get; set; } = null!;
        public virtual DbSet<VwSearchCriteriaExport> VwSearchCriteriaExports { get; set; } = null!;
        public virtual DbSet<VwSearchCriteriaImport> VwSearchCriteriaImports { get; set; } = null!;
        public virtual DbSet<VwSeat1> VwSeat1s { get; set; } = null!;
        public virtual DbSet<VwSebh1> VwSebh1s { get; set; } = null!;
        public virtual DbSet<VwSebh2> VwSebh2s { get; set; } = null!;
        public virtual DbSet<VwSebk1> VwSebk1s { get; set; } = null!;
        public virtual DbSet<VwSebk2> VwSebk2s { get; set; } = null!;
        public virtual DbSet<VwSebk21> VwSebk21s { get; set; } = null!;
        public virtual DbSet<VwSebk3> VwSebk3s { get; set; } = null!;
        public virtual DbSet<VwSebk4> VwSebk4s { get; set; } = null!;
        public virtual DbSet<VwSebk5> VwSebk5s { get; set; } = null!;
        public virtual DbSet<VwSebkContainer> VwSebkContainers { get; set; } = null!;
        public virtual DbSet<VwSebkNomination> VwSebkNominations { get; set; } = null!;
        public virtual DbSet<VwSebkTranshipment> VwSebkTranshipments { get; set; } = null!;
        public virtual DbSet<VwSebl1> VwSebl1s { get; set; } = null!;
        public virtual DbSet<VwSebl1C> VwSebl1Cs { get; set; } = null!;
        public virtual DbSet<VwSebl1HouseSubHouse> VwSebl1HouseSubHouses { get; set; } = null!;
        public virtual DbSet<VwSebl1NoCnDn> VwSebl1NoCnDns { get; set; } = null!;
        public virtual DbSet<VwSebl1T> VwSebl1Ts { get; set; } = null!;
        public virtual DbSet<VwSebl1W> VwSebl1Ws { get; set; } = null!;
        public virtual DbSet<VwSebl2> VwSebl2s { get; set; } = null!;
        public virtual DbSet<VwSebl21> VwSebl21s { get; set; } = null!;
        public virtual DbSet<VwSebl22> VwSebl22s { get; set; } = null!;
        public virtual DbSet<VwSebl2Container> VwSebl2Containers { get; set; } = null!;
        public virtual DbSet<VwSebl3> VwSebl3s { get; set; } = null!;
        public virtual DbSet<VwSebl4> VwSebl4s { get; set; } = null!;
        public virtual DbSet<VwSebl5> VwSebl5s { get; set; } = null!;
        public virtual DbSet<VwSebl6> VwSebl6s { get; set; } = null!;
        public virtual DbSet<VwSebl7> VwSebl7s { get; set; } = null!;
        public virtual DbSet<VwSebl8> VwSebl8s { get; set; } = null!;
        public virtual DbSet<VwSebl9> VwSebl9s { get; set; } = null!;
        public virtual DbSet<VwSeblContainer> VwSeblContainers { get; set; } = null!;
        public virtual DbSet<VwSeblContainerTotal> VwSeblContainerTotals { get; set; } = null!;
        public virtual DbSet<VwSeblJob> VwSeblJobs { get; set; } = null!;
        public virtual DbSet<VwSeblNonTranshipment> VwSeblNonTranshipments { get; set; } = null!;
        public virtual DbSet<VwSeblTranshipment> VwSeblTranshipments { get; set; } = null!;
        public virtual DbSet<VwSeblTsVolByMaster> VwSeblTsVolByMasters { get; set; } = null!;
        public virtual DbSet<VwSecp1> VwSecp1s { get; set; } = null!;
        public virtual DbSet<VwSecp2> VwSecp2s { get; set; } = null!;
        public virtual DbSet<VwSecsl> VwSecsls { get; set; } = null!;
        public virtual DbSet<VwSefp1> VwSefp1s { get; set; } = null!;
        public virtual DbSet<VwSeiv1> VwSeiv1s { get; set; } = null!;
        public virtual DbSet<VwSeiv1Vat> VwSeiv1Vats { get; set; } = null!;
        public virtual DbSet<VwSeiv2> VwSeiv2s { get; set; } = null!;
        public virtual DbSet<VwSeiv2Vat> VwSeiv2Vats { get; set; } = null!;
        public virtual DbSet<VwSemp1> VwSemp1s { get; set; } = null!;
        public virtual DbSet<VwSemp2> VwSemp2s { get; set; } = null!;
        public virtual DbSet<VwSepa1> VwSepa1s { get; set; } = null!;
        public virtual DbSet<VwSepi1> VwSepi1s { get; set; } = null!;
        public virtual DbSet<VwSepi2> VwSepi2s { get; set; } = null!;
        public virtual DbSet<VwSepv1> VwSepv1s { get; set; } = null!;
        public virtual DbSet<VwSepv2> VwSepv2s { get; set; } = null!;
        public virtual DbSet<VwSibl1> VwSibl1s { get; set; } = null!;
        public virtual DbSet<VwSibl10> VwSibl10s { get; set; } = null!;
        public virtual DbSet<VwSibl11> VwSibl11s { get; set; } = null!;
        public virtual DbSet<VwSibl1CfsHouse> VwSibl1CfsHouses { get; set; } = null!;
        public virtual DbSet<VwSibl1ContainerType> VwSibl1ContainerTypes { get; set; } = null!;
        public virtual DbSet<VwSibl1HouseSubHouse> VwSibl1HouseSubHouses { get; set; } = null!;
        public virtual DbSet<VwSibl1NonMaster> VwSibl1NonMasters { get; set; } = null!;
        public virtual DbSet<VwSibl1WarehouseCharge> VwSibl1WarehouseCharges { get; set; } = null!;
        public virtual DbSet<VwSibl2> VwSibl2s { get; set; } = null!;
        public virtual DbSet<VwSibl21> VwSibl21s { get; set; } = null!;
        public virtual DbSet<VwSibl3> VwSibl3s { get; set; } = null!;
        public virtual DbSet<VwSibl4> VwSibl4s { get; set; } = null!;
        public virtual DbSet<VwSibl5> VwSibl5s { get; set; } = null!;
        public virtual DbSet<VwSibl6> VwSibl6s { get; set; } = null!;
        public virtual DbSet<VwSibl7> VwSibl7s { get; set; } = null!;
        public virtual DbSet<VwSibl8> VwSibl8s { get; set; } = null!;
        public virtual DbSet<VwSibl9> VwSibl9s { get; set; } = null!;
        public virtual DbSet<VwSiblContainer> VwSiblContainers { get; set; } = null!;
        public virtual DbSet<VwSiblContainerTotal> VwSiblContainerTotals { get; set; } = null!;
        public virtual DbSet<VwSiblJob> VwSiblJobs { get; set; } = null!;
        public virtual DbSet<VwSiblNonTranshipment> VwSiblNonTranshipments { get; set; } = null!;
        public virtual DbSet<VwSiblTranshipment> VwSiblTranshipments { get; set; } = null!;
        public virtual DbSet<VwSiblTsVolByMaster> VwSiblTsVolByMasters { get; set; } = null!;
        public virtual DbSet<VwSicp1> VwSicp1s { get; set; } = null!;
        public virtual DbSet<VwSicp2> VwSicp2s { get; set; } = null!;
        public virtual DbSet<VwSidi1> VwSidi1s { get; set; } = null!;
        public virtual DbSet<VwSidi2> VwSidi2s { get; set; } = null!;
        public virtual DbSet<VwSidi21> VwSidi21s { get; set; } = null!;
        public virtual DbSet<VwSido1> VwSido1s { get; set; } = null!;
        public virtual DbSet<VwSido2> VwSido2s { get; set; } = null!;
        public virtual DbSet<VwSido21> VwSido21s { get; set; } = null!;
        public virtual DbSet<VwSiiv1> VwSiiv1s { get; set; } = null!;
        public virtual DbSet<VwSiiv1Vat> VwSiiv1Vats { get; set; } = null!;
        public virtual DbSet<VwSiiv2> VwSiiv2s { get; set; } = null!;
        public virtual DbSet<VwSiiv2Vat> VwSiiv2Vats { get; set; } = null!;
        public virtual DbSet<VwSipa1> VwSipa1s { get; set; } = null!;
        public virtual DbSet<VwSipv1> VwSipv1s { get; set; } = null!;
        public virtual DbSet<VwSipv2> VwSipv2s { get; set; } = null!;
        public virtual DbSet<VwSlaj1> VwSlaj1s { get; set; } = null!;
        public virtual DbSet<VwSlbs1> VwSlbs1s { get; set; } = null!;
        public virtual DbSet<VwSlcc1> VwSlcc1s { get; set; } = null!;
        public virtual DbSet<VwSlcm1> VwSlcm1s { get; set; } = null!;
        public virtual DbSet<VwSlcm2> VwSlcm2s { get; set; } = null!;
        public virtual DbSet<VwSlcr1> VwSlcr1s { get; set; } = null!;
        public virtual DbSet<VwSlcr1Wht> VwSlcr1Whts { get; set; } = null!;
        public virtual DbSet<VwSlcr2> VwSlcr2s { get; set; } = null!;
        public virtual DbSet<VwSlcr3> VwSlcr3s { get; set; } = null!;
        public virtual DbSet<VwSlcr4> VwSlcr4s { get; set; } = null!;
        public virtual DbSet<VwSlcrAcc> VwSlcrAccs { get; set; } = null!;
        public virtual DbSet<VwSlcs1> VwSlcs1s { get; set; } = null!;
        public virtual DbSet<VwSlcs2> VwSlcs2s { get; set; } = null!;
        public virtual DbSet<VwSlct1> VwSlct1s { get; set; } = null!;
        public virtual DbSet<VwSlcu1> VwSlcu1s { get; set; } = null!;
        public virtual DbSet<VwSlcu2> VwSlcu2s { get; set; } = null!;
        public virtual DbSet<VwSlcu3> VwSlcu3s { get; set; } = null!;
        public virtual DbSet<VwSlcu4> VwSlcu4s { get; set; } = null!;
        public virtual DbSet<VwSlcu5> VwSlcu5s { get; set; } = null!;
        public virtual DbSet<VwSlcu6> VwSlcu6s { get; set; } = null!;
        public virtual DbSet<VwSlpa1> VwSlpa1s { get; set; } = null!;
        public virtual DbSet<VwSltx1> VwSltx1s { get; set; } = null!;
        public virtual DbSet<VwSltx1CreditNote> VwSltx1CreditNotes { get; set; } = null!;
        public virtual DbSet<VwSltx1NoCn> VwSltx1NoCns { get; set; } = null!;
        public virtual DbSet<VwSltx1Payment> VwSltx1Payments { get; set; } = null!;
        public virtual DbSet<VwSltx1VatOutLay> VwSltx1VatOutLays { get; set; } = null!;
        public virtual DbSet<VwSlvx1> VwSlvx1s { get; set; } = null!;
        public virtual DbSet<VwSlvx11> VwSlvx11s { get; set; } = null!;
        public virtual DbSet<VwSlvx12> VwSlvx12s { get; set; } = null!;
        public virtual DbSet<VwSlvx1Aug> VwSlvx1Augs { get; set; } = null!;
        public virtual DbSet<VwSlvx1Ira> VwSlvx1Iras { get; set; } = null!;
        public virtual DbSet<VwSlvx1NoVat> VwSlvx1NoVats { get; set; } = null!;
        public virtual DbSet<VwSlvx1Sin> VwSlvx1Sins { get; set; } = null!;
        public virtual DbSet<VwSmbr1> VwSmbr1s { get; set; } = null!;
        public virtual DbSet<VwSmbr2> VwSmbr2s { get; set; } = null!;
        public virtual DbSet<VwSmct1> VwSmct1s { get; set; } = null!;
        public virtual DbSet<VwSmct1A> VwSmct1As { get; set; } = null!;
        public virtual DbSet<VwSmct1NonDg> VwSmct1NonDgs { get; set; } = null!;
        public virtual DbSet<VwSmct1NonDg2StandardCharge> VwSmct1NonDg2StandardCharges { get; set; } = null!;
        public virtual DbSet<VwSmct1NonDg3StandardCharge> VwSmct1NonDg3StandardCharges { get; set; } = null!;
        public virtual DbSet<VwSmct2> VwSmct2s { get; set; } = null!;
        public virtual DbSet<VwSmct3> VwSmct3s { get; set; } = null!;
        public virtual DbSet<VwSmec1> VwSmec1s { get; set; } = null!;
        public virtual DbSet<VwSmec2> VwSmec2s { get; set; } = null!;
        public virtual DbSet<VwSmef1> VwSmef1s { get; set; } = null!;
        public virtual DbSet<VwSmef2> VwSmef2s { get; set; } = null!;
        public virtual DbSet<VwSmfd1> VwSmfd1s { get; set; } = null!;
        public virtual DbSet<VwSmfd2> VwSmfd2s { get; set; } = null!;
        public virtual DbSet<VwSmfq1> VwSmfq1s { get; set; } = null!;
        public virtual DbSet<VwSmfq2> VwSmfq2s { get; set; } = null!;
        public virtual DbSet<VwSmfq2StandardCharge> VwSmfq2StandardCharges { get; set; } = null!;
        public virtual DbSet<VwSmfq3> VwSmfq3s { get; set; } = null!;
        public virtual DbSet<VwSmfq3NonDg2> VwSmfq3NonDg2s { get; set; } = null!;
        public virtual DbSet<VwSmfq3NonDg3> VwSmfq3NonDg3s { get; set; } = null!;
        public virtual DbSet<VwSmfq3StandardCharge> VwSmfq3StandardCharges { get; set; } = null!;
        public virtual DbSet<VwSmfq3Uom> VwSmfq3Uoms { get; set; } = null!;
        public virtual DbSet<VwSmfq4> VwSmfq4s { get; set; } = null!;
        public virtual DbSet<VwSmfq6> VwSmfq6s { get; set; } = null!;
        public virtual DbSet<VwSmhq1> VwSmhq1s { get; set; } = null!;
        public virtual DbSet<VwSmhq2> VwSmhq2s { get; set; } = null!;
        public virtual DbSet<VwSmht1> VwSmht1s { get; set; } = null!;
        public virtual DbSet<VwSmht2> VwSmht2s { get; set; } = null!;
        public virtual DbSet<VwSmic1> VwSmic1s { get; set; } = null!;
        public virtual DbSet<VwSmic2> VwSmic2s { get; set; } = null!;
        public virtual DbSet<VwSmif1> VwSmif1s { get; set; } = null!;
        public virtual DbSet<VwSmif2> VwSmif2s { get; set; } = null!;
        public virtual DbSet<VwSmiq1> VwSmiq1s { get; set; } = null!;
        public virtual DbSet<VwSmiq2> VwSmiq2s { get; set; } = null!;
        public virtual DbSet<VwSmit1> VwSmit1s { get; set; } = null!;
        public virtual DbSet<VwSmit2> VwSmit2s { get; set; } = null!;
        public virtual DbSet<VwSmpa1> VwSmpa1s { get; set; } = null!;
        public virtual DbSet<VwSmpa2> VwSmpa2s { get; set; } = null!;
        public virtual DbSet<VwSmqt1> VwSmqt1s { get; set; } = null!;
        public virtual DbSet<VwSmsa1> VwSmsa1s { get; set; } = null!;
        public virtual DbSet<VwSmsa2> VwSmsa2s { get; set; } = null!;
        public virtual DbSet<VwSsjd1> VwSsjd1s { get; set; } = null!;
        public virtual DbSet<VwSsst1> VwSsst1s { get; set; } = null!;
        public virtual DbSet<VwTestGlex1> VwTestGlex1s { get; set; } = null!;
        public virtual DbSet<VwTjms1> VwTjms1s { get; set; } = null!;
        public virtual DbSet<VwTmbi1> VwTmbi1s { get; set; } = null!;
        public virtual DbSet<VwTmbi2> VwTmbi2s { get; set; } = null!;
        public virtual DbSet<VwTmpJmpl1> VwTmpJmpl1s { get; set; } = null!;
        public virtual DbSet<VwTmpJmpl1ByJob> VwTmpJmpl1ByJobs { get; set; } = null!;
        public virtual DbSet<VwTmpJmpl1Internal> VwTmpJmpl1Internals { get; set; } = null!;
        public virtual DbSet<VwTncl1> VwTncl1s { get; set; } = null!;
        public virtual DbSet<VwTncp1> VwTncp1s { get; set; } = null!;
        public virtual DbSet<VwTnem1> VwTnem1s { get; set; } = null!;
        public virtual DbSet<VwTnex1> VwTnex1s { get; set; } = null!;
        public virtual DbSet<VwTnex2> VwTnex2s { get; set; } = null!;
        public virtual DbSet<VwTnhs1> VwTnhs1s { get; set; } = null!;
        public virtual DbSet<VwTnmp1> VwTnmp1s { get; set; } = null!;
        public virtual DbSet<VwTnpa1> VwTnpa1s { get; set; } = null!;
        public virtual DbSet<VwTnrc1> VwTnrc1s { get; set; } = null!;
        public virtual DbSet<VwTnrf1> VwTnrf1s { get; set; } = null!;
        public virtual DbSet<VwTnrf2> VwTnrf2s { get; set; } = null!;
        public virtual DbSet<VwTnsl1> VwTnsl1s { get; set; } = null!;
        public virtual DbSet<VwTntRoleFunction> VwTntRoleFunctions { get; set; } = null!;
        public virtual DbSet<VwTntUserPageAccess> VwTntUserPageAccesses { get; set; } = null!;
        public virtual DbSet<VwTntWmstrackingBalance> VwTntWmstrackingBalances { get; set; } = null!;
        public virtual DbSet<VwTntWmstrackingMovement> VwTntWmstrackingMovements { get; set; } = null!;
        public virtual DbSet<VwTntWmstrackingMovement20180206Bk> VwTntWmstrackingMovement20180206Bks { get; set; } = null!;
        public virtual DbSet<VwTnum1> VwTnum1s { get; set; } = null!;
        public virtual DbSet<VwToac1> VwToac1s { get; set; } = null!;
        public virtual DbSet<VwTobk1> VwTobk1s { get; set; } = null!;
        public virtual DbSet<VwTobk2> VwTobk2s { get; set; } = null!;
        public virtual DbSet<VwTobk21> VwTobk21s { get; set; } = null!;
        public virtual DbSet<VwTobk3> VwTobk3s { get; set; } = null!;
        public virtual DbSet<VwTobk4> VwTobk4s { get; set; } = null!;
        public virtual DbSet<VwTobk5> VwTobk5s { get; set; } = null!;
        public virtual DbSet<VwTobk6> VwTobk6s { get; set; } = null!;
        public virtual DbSet<VwTobkContainer> VwTobkContainers { get; set; } = null!;
        public virtual DbSet<VwToct1> VwToct1s { get; set; } = null!;
        public virtual DbSet<VwTodo1> VwTodo1s { get; set; } = null!;
        public virtual DbSet<VwTodo2> VwTodo2s { get; set; } = null!;
        public virtual DbSet<VwTodo3> VwTodo3s { get; set; } = null!;
        public virtual DbSet<VwTodr1> VwTodr1s { get; set; } = null!;
        public virtual DbSet<VwTodr2> VwTodr2s { get; set; } = null!;
        public virtual DbSet<VwToet1> VwToet1s { get; set; } = null!;
        public virtual DbSet<VwToiv1> VwToiv1s { get; set; } = null!;
        public virtual DbSet<VwToiv1Vat> VwToiv1Vats { get; set; } = null!;
        public virtual DbSet<VwToiv2> VwToiv2s { get; set; } = null!;
        public virtual DbSet<VwToiv2Vat> VwToiv2Vats { get; set; } = null!;
        public virtual DbSet<VwTopa1> VwTopa1s { get; set; } = null!;
        public virtual DbSet<VwTopa2> VwTopa2s { get; set; } = null!;
        public virtual DbSet<VwTopv1> VwTopv1s { get; set; } = null!;
        public virtual DbSet<VwTopv2> VwTopv2s { get; set; } = null!;
        public virtual DbSet<VwTorc1> VwTorc1s { get; set; } = null!;
        public virtual DbSet<VwTorl1> VwTorl1s { get; set; } = null!;
        public virtual DbSet<VwTosh1> VwTosh1s { get; set; } = null!;
        public virtual DbSet<VwToso1> VwToso1s { get; set; } = null!;
        public virtual DbSet<VwToso2> VwToso2s { get; set; } = null!;
        public virtual DbSet<VwTost1> VwTost1s { get; set; } = null!;
        public virtual DbSet<VwTotc1> VwTotc1s { get; set; } = null!;
        public virtual DbSet<VwTotc2> VwTotc2s { get; set; } = null!;
        public virtual DbSet<VwTotd1> VwTotd1s { get; set; } = null!;
        public virtual DbSet<VwTotd2> VwTotd2s { get; set; } = null!;
        public virtual DbSet<VwTotr1> VwTotr1s { get; set; } = null!;
        public virtual DbSet<VwTovl1> VwTovl1s { get; set; } = null!;
        public virtual DbSet<VwTovm1> VwTovm1s { get; set; } = null!;
        public virtual DbSet<VwTovm2> VwTovm2s { get; set; } = null!;
        public virtual DbSet<VwTovt1> VwTovt1s { get; set; } = null!;
        public virtual DbSet<VwTpts1> VwTpts1s { get; set; } = null!;
        public virtual DbSet<VwTranshipment> VwTranshipments { get; set; } = null!;
        public virtual DbSet<VwWhbt1> VwWhbt1s { get; set; } = null!;
        public virtual DbSet<VwWhbt2> VwWhbt2s { get; set; } = null!;
        public virtual DbSet<VwWhiv1> VwWhiv1s { get; set; } = null!;
        public virtual DbSet<VwWhiv1Vat> VwWhiv1Vats { get; set; } = null!;
        public virtual DbSet<VwWhiv2> VwWhiv2s { get; set; } = null!;
        public virtual DbSet<VwWhiv2Vat> VwWhiv2Vats { get; set; } = null!;
        public virtual DbSet<VwWhpa1> VwWhpa1s { get; set; } = null!;
        public virtual DbSet<VwWhpv1> VwWhpv1s { get; set; } = null!;
        public virtual DbSet<VwWhpv2> VwWhpv2s { get; set; } = null!;
        public virtual DbSet<VwWhsf1> VwWhsf1s { get; set; } = null!;
        public virtual DbSet<VwWhst1> VwWhst1s { get; set; } = null!;
        public virtual DbSet<VwWhwh1> VwWhwh1s { get; set; } = null!;
        public virtual DbSet<VwWhwh2> VwWhwh2s { get; set; } = null!;
        public virtual DbSet<VwWicepo1> VwWicepo1s { get; set; } = null!;
        public virtual DbSet<VwWicepo2> VwWicepo2s { get; set; } = null!;
        public virtual DbSet<VwWmbc1> VwWmbc1s { get; set; } = null!;
        public virtual DbSet<VwWmbr1> VwWmbr1s { get; set; } = null!;
        public virtual DbSet<VwWmbr2> VwWmbr2s { get; set; } = null!;
        public virtual DbSet<VwWmbt1> VwWmbt1s { get; set; } = null!;
        public virtual DbSet<VwWmbt1OpenBal> VwWmbt1OpenBals { get; set; } = null!;
        public virtual DbSet<VwWmbt2> VwWmbt2s { get; set; } = null!;
        public virtual DbSet<VwWmct1> VwWmct1s { get; set; } = null!;
        public virtual DbSet<VwWmcy1> VwWmcy1s { get; set; } = null!;
        public virtual DbSet<VwWmvl1> VwWmvl1s { get; set; } = null!;
        public virtual DbSet<VwWrApplist> VwWrApplists { get; set; } = null!;
        public virtual DbSet<VwWrApplist2> VwWrApplist2s { get; set; } = null!;
        public virtual DbSet<VwWrGridFlag> VwWrGridFlags { get; set; } = null!;
        public virtual DbSet<VwWrLanguageList> VwWrLanguageLists { get; set; } = null!;
        public virtual DbSet<VwWrMainControl> VwWrMainControls { get; set; } = null!;
        public virtual DbSet<VwWrMessage> VwWrMessages { get; set; } = null!;
        public virtual DbSet<VwWrMultiLanguage> VwWrMultiLanguages { get; set; } = null!;
        public virtual DbSet<VwWrNote> VwWrNotes { get; set; } = null!;
        public virtual DbSet<VwWrPersonRole> VwWrPersonRoles { get; set; } = null!;
        public virtual DbSet<VwWrRoleRight> VwWrRoleRights { get; set; } = null!;
        public virtual DbSet<VwWrSysTmplt> VwWrSysTmplts { get; set; } = null!;
        public virtual DbSet<VwWrUseSysBasAndAdv> VwWrUseSysBasAndAdvs { get; set; } = null!;
        public virtual DbSet<VwWrUser> VwWrUsers { get; set; } = null!;
        public virtual DbSet<VwWrUserControl> VwWrUserControls { get; set; } = null!;
        public virtual DbSet<VwWrUsrShortCut> VwWrUsrShortCuts { get; set; } = null!;
        public virtual DbSet<VwWrViewDefine> VwWrViewDefines { get; set; } = null!;
        public virtual DbSet<WebSubMenu> WebSubMenus { get; set; } = null!;
        public virtual DbSet<WebUser> WebUsers { get; set; } = null!;
        public virtual DbSet<WhCheckCustBill> WhCheckCustBills { get; set; } = null!;
        public virtual DbSet<WhScan> WhScans { get; set; } = null!;
        public virtual DbSet<Whbt1> Whbt1s { get; set; } = null!;
        public virtual DbSet<Whbt2> Whbt2s { get; set; } = null!;
        public virtual DbSet<Whiv1> Whiv1s { get; set; } = null!;
        public virtual DbSet<Whiv2> Whiv2s { get; set; } = null!;
        public virtual DbSet<Whpa1> Whpa1s { get; set; } = null!;
        public virtual DbSet<Whpv1> Whpv1s { get; set; } = null!;
        public virtual DbSet<Whpv2> Whpv2s { get; set; } = null!;
        public virtual DbSet<Whsf1> Whsf1s { get; set; } = null!;
        public virtual DbSet<Whst1> Whst1s { get; set; } = null!;
        public virtual DbSet<Whwh1> Whwh1s { get; set; } = null!;
        public virtual DbSet<Whwh2> Whwh2s { get; set; } = null!;
        public virtual DbSet<WicePo1> WicePo1s { get; set; } = null!;
        public virtual DbSet<WicePo2> WicePo2s { get; set; } = null!;
        public virtual DbSet<Wmbc1> Wmbc1s { get; set; } = null!;
        public virtual DbSet<Wmbr1> Wmbr1s { get; set; } = null!;
        public virtual DbSet<Wmbr2> Wmbr2s { get; set; } = null!;
        public virtual DbSet<Wmbt1> Wmbt1s { get; set; } = null!;
        public virtual DbSet<Wmbt2> Wmbt2s { get; set; } = null!;
        public virtual DbSet<Wmct1> Wmct1s { get; set; } = null!;
        public virtual DbSet<Wmcy1> Wmcy1s { get; set; } = null!;
        public virtual DbSet<Wmvl1> Wmvl1s { get; set; } = null!;
        public virtual DbSet<WrAppList> WrAppLists { get; set; } = null!;
        public virtual DbSet<WrAppList2> WrAppList2s { get; set; } = null!;
        public virtual DbSet<WrAppointment> WrAppointments { get; set; } = null!;
        public virtual DbSet<WrAppointmentCategory> WrAppointmentCategories { get; set; } = null!;
        public virtual DbSet<WrDisplayFormTitle> WrDisplayFormTitles { get; set; } = null!;
        public virtual DbSet<WrGridFlag> WrGridFlags { get; set; } = null!;
        public virtual DbSet<WrJobFileShipmentStatus> WrJobFileShipmentStatuses { get; set; } = null!;
        public virtual DbSet<WrLanguageList> WrLanguageLists { get; set; } = null!;
        public virtual DbSet<WrMainControl> WrMainControls { get; set; } = null!;
        public virtual DbSet<WrMessage> WrMessages { get; set; } = null!;
        public virtual DbSet<WrMultiLanguage> WrMultiLanguages { get; set; } = null!;
        public virtual DbSet<WrNote> WrNotes { get; set; } = null!;
        public virtual DbSet<WrPersonRole> WrPersonRoles { get; set; } = null!;
        public virtual DbSet<WrRoleRight> WrRoleRights { get; set; } = null!;
        public virtual DbSet<WrSysTmplt> WrSysTmplts { get; set; } = null!;
        public virtual DbSet<WrUseSysBasAndAdv> WrUseSysBasAndAdvs { get; set; } = null!;
        public virtual DbSet<WrUser> WrUsers { get; set; } = null!;
        public virtual DbSet<WrUserControl> WrUserControls { get; set; } = null!;
        public virtual DbSet<WrUserNotify> WrUserNotifies { get; set; } = null!;
        public virtual DbSet<WrUsrShortCut> WrUsrShortCuts { get; set; } = null!;
        public virtual DbSet<WrViewDefine> WrViewDefines { get; set; } = null!;
        public virtual DbSet<VwUserMenu> VwUserMenus { get; set; } = null!;

        #endregion

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Chinese_PRC_CI_AS");

            modelBuilder.Entity<Acar1>(entity =>
            {
                entity.HasKey(e => e.AreaCode)
                    .IsClustered(false);

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Accg1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Accm1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Acct1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Acct2>(entity =>
            {
                entity.HasKey(e => new { e.QuoteTableNo, e.LineItemNo });
            });

            modelBuilder.Entity<Acdv1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Acft1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Acit1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecoverableFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Acit2>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.LineItemNo })
                    .HasName("PK_acit2_1");
            });

            modelBuilder.Entity<Acit3>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.LineItemNo });
            });

            modelBuilder.Entity<Actm1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Acva1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Acva2>(entity =>
            {
                entity.HasKey(e => new { e.VatCode, e.EffectiveDate });
            });

            modelBuilder.Entity<Acvr1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Acws1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Acwt1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AeAllInvoiceByMaster>(entity =>
            {
                entity.ToView("ae_All_Invoice_By_Master");
            });

            modelBuilder.Entity<AeAwbPreparation>(entity =>
            {
                entity.ToView("ae_Awb_Preparation");

                entity.Property(e => e.CargoReceiptDate).IsFixedLength();

                entity.Property(e => e.ConfirmArrivalDate).IsFixedLength();

                entity.Property(e => e.ConfirmDepartureDate).IsFixedLength();

                entity.Property(e => e.ExecuteDate).IsFixedLength();

                entity.Property(e => e.FirstEtaDate).IsFixedLength();

                entity.Property(e => e.FirstEtaTime).IsFixedLength();

                entity.Property(e => e.FirstFlightDate).IsFixedLength();

                entity.Property(e => e.FirstFlightTime).IsFixedLength();

                entity.Property(e => e.FourthEtaDate).IsFixedLength();

                entity.Property(e => e.FourthEtaTime).IsFixedLength();

                entity.Property(e => e.FourthFlightDate).IsFixedLength();

                entity.Property(e => e.FourthFlightTime).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.LodgeDate).IsFixedLength();

                entity.Property(e => e.PickupDate).IsFixedLength();

                entity.Property(e => e.PickupFfDate).IsFixedLength();

                entity.Property(e => e.PreAlertDestDate).IsFixedLength();

                entity.Property(e => e.ReceiveFfDate).IsFixedLength();

                entity.Property(e => e.SecondEtaDate).IsFixedLength();

                entity.Property(e => e.SecondEtaTime).IsFixedLength();

                entity.Property(e => e.SecondFlightDate).IsFixedLength();

                entity.Property(e => e.SecondFlightTime).IsFixedLength();

                entity.Property(e => e.ThirdEtaDate).IsFixedLength();

                entity.Property(e => e.ThirdEtaTime).IsFixedLength();

                entity.Property(e => e.ThirdFlightDate).IsFixedLength();

                entity.Property(e => e.ThirdFlightTime).IsFixedLength();

                entity.Property(e => e.TrfDate).IsFixedLength();
            });

            modelBuilder.Entity<AeAwbReference>(entity =>
            {
                entity.ToView("ae_Awb_Reference");

                entity.Property(e => e.CargoReceiptDate).IsFixedLength();

                entity.Property(e => e.ConfirmArrivalDate).IsFixedLength();

                entity.Property(e => e.ConfirmDepartureDate).IsFixedLength();

                entity.Property(e => e.ExecuteDate).IsFixedLength();

                entity.Property(e => e.FirstEtaDate).IsFixedLength();

                entity.Property(e => e.FirstEtaTime).IsFixedLength();

                entity.Property(e => e.FirstFlightDate).IsFixedLength();

                entity.Property(e => e.FirstFlightTime).IsFixedLength();

                entity.Property(e => e.FourthEtaDate).IsFixedLength();

                entity.Property(e => e.FourthEtaTime).IsFixedLength();

                entity.Property(e => e.FourthFlightDate).IsFixedLength();

                entity.Property(e => e.FourthFlightTime).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.LodgeDate).IsFixedLength();

                entity.Property(e => e.PickupDate).IsFixedLength();

                entity.Property(e => e.PickupFfDate).IsFixedLength();

                entity.Property(e => e.PreAlertDestDate).IsFixedLength();

                entity.Property(e => e.ReceiveFfDate).IsFixedLength();

                entity.Property(e => e.SecondEtaDate).IsFixedLength();

                entity.Property(e => e.SecondEtaTime).IsFixedLength();

                entity.Property(e => e.SecondFlightDate).IsFixedLength();

                entity.Property(e => e.SecondFlightTime).IsFixedLength();

                entity.Property(e => e.ThirdEtaDate).IsFixedLength();

                entity.Property(e => e.ThirdEtaTime).IsFixedLength();

                entity.Property(e => e.ThirdFlightDate).IsFixedLength();

                entity.Property(e => e.ThirdFlightTime).IsFixedLength();

                entity.Property(e => e.TrfDate).IsFixedLength();
            });

            modelBuilder.Entity<AeEpic>(entity =>
            {
                entity.ToView("ae_EPIC");

                entity.Property(e => e.FirstFlightDate).IsFixedLength();
            });

            modelBuilder.Entity<AeInvoice1>(entity =>
            {
                entity.ToView("ae_Invoice_1");

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.FlightDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();
            });

            modelBuilder.Entity<AeInvoice2>(entity =>
            {
                entity.ToView("ae_Invoice_2");
            });

            modelBuilder.Entity<AeMawbLotNo>(entity =>
            {
                entity.ToView("ae_Mawb_LotNo");
            });

            modelBuilder.Entity<AePaymentVoucher1>(entity =>
            {
                entity.ToView("ae_Payment_Voucher_1");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Aeaw1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FaxCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Aeaw2>(entity =>
            {
                entity.HasKey(e => new { e.AwbNo, e.LineItemNo });
            });

            modelBuilder.Entity<Aeaw3>(entity =>
            {
                entity.HasKey(e => new { e.AwbNo, e.PcsSeqNo });
            });

            modelBuilder.Entity<Aeaw4>(entity =>
            {
                entity.HasKey(e => new { e.AwbNo, e.LineItemNo })
                    .HasName("PK_Aeaw4");
            });

            modelBuilder.Entity<Aeaw5>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo })
                    .HasName("PK_Aeaw5");
            });

            modelBuilder.Entity<Aeaw6>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo })
                    .HasName("PK_Aeaw6");
            });

            modelBuilder.Entity<Aebk1>(entity =>
            {
                entity.HasKey(e => e.BookingNo)
                    .HasName("PK_Aebk1_1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FaxCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Aebk2>(entity =>
            {
                entity.HasKey(e => new { e.BookingNo, e.LineItemNo });
            });

            modelBuilder.Entity<Aebk3>(entity =>
            {
                entity.HasKey(e => new { e.BookingNo, e.PickupNo });
            });

            modelBuilder.Entity<Aeca1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Aect1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Aect2>(entity =>
            {
                entity.HasKey(e => new { e.CargoTrfFormNo, e.LineItemNo });

                entity.Property(e => e.FlightDate).HasDefaultValueSql("(31 / 12 / 1899)");

                entity.HasOne(d => d.CargoTrfFormNoNavigation)
                    .WithMany(p => p.Aect2s)
                    .HasForeignKey(d => d.CargoTrfFormNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aect2_aect1");
            });

            modelBuilder.Entity<Aeiv1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InvoiceAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceCostAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceLocalAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.PostFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WithHoldingTaxAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Aeiv2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Aeiv2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aeiv2_aeiv1");
            });

            modelBuilder.Entity<Aemp1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FaxCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");

                entity.HasOne(d => d.DivisionCodeNavigation)
                    .WithMany(p => p.Aemp1s)
                    .HasForeignKey(d => d.DivisionCode)
                    .HasConstraintName("FK_aemp1_acdv1");
            });

            modelBuilder.Entity<Aemp2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Aepa1>(entity =>
            {
                entity.HasKey(e => e.UniqueKey)
                    .IsClustered(false);

                entity.Property(e => e.AgentAccCode).HasComment("The Account Code of the Company default as Shipper Account Code in MAWB");

                entity.Property(e => e.AgentAddress1).HasComment("Default the Address 1 of the Company as Shipper Address 1 in the MAWB");

                entity.Property(e => e.AgentAddress2).HasComment("Default the Address 2 of the Company as Shipper Address 2 in the MAWB");

                entity.Property(e => e.AgentAddress3).HasComment("Default the Address 3 of the Company as Shipper Address 3 in the MAWB");

                entity.Property(e => e.AgentAddress4).HasComment("Default the Address 4 of the Company as Shipper Address 4 in the MAWB");

                entity.Property(e => e.AgentCode).HasComment("The Business Party Code of the Company. Default as Shipper Code in the MAWB");

                entity.Property(e => e.AgentIataCode).HasComment("The IATA Code of the Company");

                entity.Property(e => e.AgentName).HasComment("Default the Name of the Company as Shipper Name in the MAWB");

                entity.Property(e => e.AgentPartyType).HasComment("Set filter Party Type for anat1 form to search Customer Code.");

                entity.Property(e => e.AutoHawbNoFlag).HasComment("Allow HAWB No. to auto generate");

                entity.Property(e => e.AutoMawbNoFlag).HasComment("Allow MAWB No. to auto generate");

                entity.Property(e => e.AwbCurrCode).HasComment("Default the Currency Code in the AWB");

                entity.Property(e => e.BankAccCode).HasComment("Default the Bank Acc Code to the Payment Voucher");

                entity.Property(e => e.BankCode).HasComment("Define the BankCode to default the BankCode in ivcr1_5");

                entity.Property(e => e.BookingCreateJobNoFlag).HasComment("Set as N, confirm booking don't generate job no");

                entity.Property(e => e.CargoManifestPrefix).HasComment("NOT IN USE");

                entity.Property(e => e.CashAccCode).HasComment("Default the Cash Acc Code to the Cash Receipt");

                entity.Property(e => e.ChangeMasterAwbNoFlag).HasComment("If set as N, it will not prompt the message and it will not change the Job No of the House");

                entity.Property(e => e.ChargeWtFlag).HasComment("Set as Y, aeaw1 form tick auto-compute check box, the system should not recompute ChargeWt; Set as N should recompute.");

                entity.Property(e => e.ConsolBookingFlag).HasComment("If set as 'N', then it will disable the button New Booking on the Consol screen");

                entity.Property(e => e.ConsolShowAwbFlag).HasComment("If set as 'Y', then it will default the check box 'Show Awb' as ticked");

                entity.Property(e => e.CourierItemCode).HasComment("Pull the Rate from smct2 base on CourierItemCode to Csbk1’s Charge Rate");

                entity.Property(e => e.CourierSurchargeRate).HasComment("Define the Surcharge Rate to csbk1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CsrDate).HasComment("NOT IN USE");

                entity.Property(e => e.DcNotePrefix).HasComment("NOT IN USE");

                entity.Property(e => e.DcNoteSeqNo).HasComment("NOT IN USE");

                entity.Property(e => e.DefaultCommodityDescription).HasComment("Default the Commoditiy Description when entering a new AWB");

                entity.Property(e => e.DefaultOther).HasComment("Default the Other Charge as P - Prepaid or C- Collect when entering a new AWB");

                entity.Property(e => e.DefaultSameAsConsigneeFlag).HasComment("Default the Notify Party as SAME AS CONSIGNEE");

                entity.Property(e => e.DefaultUomCode).HasComment("Default the Unit of Measurement Code when entering a new AWB. The code must be a valid code in UOM Table");

                entity.Property(e => e.DefaultVolumetricWeightRatio).HasComment("Default the Volume/Weight Ratio in Dimension tab in aebk1/aeaw1 when the Unit is 'CM'. \r\ne.g if set as '5000', then the Volume/weight Ratio will default as '5000' for 'CM', and the Volumetric Weight = Total Dimension / 5000");

                entity.Property(e => e.DefaultWeightValue).HasComment("Default the Freight Charge as P - Prepaid or C- Collect when entering a new AWB");

                entity.Property(e => e.DepartureAirportName).HasComment("NOT IN USE");

                entity.Property(e => e.DeviceaddrCcn).HasComment("NOT IN USE");

                entity.Property(e => e.DimensionSeparation).HasComment("Define the symbol when load the dimension to Description & Remarks on the Rate tab");

                entity.Property(e => e.DocumentFooter1).HasComment("Print to footer 1 of the Air Export related documents");

                entity.Property(e => e.DocumentFooter2).HasComment("Print to footer 2 of the Air Export related documents");

                entity.Property(e => e.EcFreightFlag).HasComment("if set as 'Y' then show the 'ecFreight' button instead of the button 'FHL Message' and 'Fwb Message'. when click the button 'ecFreight', just like click the button 'FHL Message' and  'Fwb Message' to export data to the file at same time");

                entity.Property(e => e.FilterConsigneeFlag).HasComment("If set as 'Y', then 1) show only those consignee under the same CityCode (base on the Destination City Code). \r\n2) After selecting the Consignee Code, system should be able to default the corresponding OverSea Agent Code (by comparing both the Destination City Code and Consignee Code).");

                entity.Property(e => e.FontType).HasComment("Define the font type for the aeaw1.Description 1-12 and CommodityDescription 1-14");

                entity.Property(e => e.FrtItemCode1).HasComment("Define the Item Code for the Freight Charge. It must be a valid code in Charge List in Account Reference");

                entity.Property(e => e.FrtItemCode2).HasComment("Define the Item Code for the Freight Charge. It must be a valid code in Charge List in Account Reference");

                entity.Property(e => e.FrtItemCode3).HasComment("Define the Item Code for the Freight Charge. It must be a valid code in Charge List in Account Reference");

                entity.Property(e => e.FscItemCode).HasComment("Default the Fuel Surcharges Item Code in Ivcr1. It must be a valid code in Charge List in Account Reference");

                entity.Property(e => e.HawbNoFlag).HasComment("J to default the HAWB same as Job No. H to create the HAWB no. base on the HAWB Prefix and Next HAWB No.");

                entity.Property(e => e.HawbPrefix).HasComment("HAWB Prefix Format: YY,MM,DST");

                entity.Property(e => e.IssItemCode).HasComment("Default the Insurance and Security Surcharges Item Code in Ivcr1. It must be a valid code in Charge List in Account Reference");

                entity.Property(e => e.JobDateType).HasComment("Job Date is defined as FLD for First Flight Date or JCD Job Creation Date");

                entity.Property(e => e.JobNoFlag).HasComment("Job running no. is created by C - Continously, M - Monthly, S - Shipment Type");

                entity.Property(e => e.JobPrefix1).HasComment("Job Prefix 1 Format select one value from YY,MM,DST or FXX");

                entity.Property(e => e.JobPrefix2).HasComment("Job Prefix 2 Format select one value from YY,MM,DST or FXX");

                entity.Property(e => e.JobPrefix3).HasComment("Job Prefix 3 Format select one value from YY,MM,DST or FXX");

                entity.Property(e => e.JobPrefix4).HasComment("Job Prefix 4 Format select one value from YY,MM,DST or FXX");

                entity.Property(e => e.JobPrefix5).HasComment("Job Prefix 5 Format select one value from YY,MM,DST or FXX");

                entity.Property(e => e.K1).HasComment("For Malaysia Custom System Form K1");

                entity.Property(e => e.K2).HasComment("For Malaysia Custom System Form K2");

                entity.Property(e => e.K3).HasComment("For Malaysia Custom System Form K3");

                entity.Property(e => e.K4).HasComment("For Malaysia Custom System Form K4");

                entity.Property(e => e.K5).HasComment("For Malaysia Custom System Form K5");

                entity.Property(e => e.K6).HasComment("For Malaysia Custom System Form K6");

                entity.Property(e => e.K7).HasComment("For Malaysia Custom System Form K7");

                entity.Property(e => e.K8).HasComment("For Malaysia Custom System Form K8");

                entity.Property(e => e.K9).HasComment("For Malaysia Custom System Form K9");

                entity.Property(e => e.LastPostDate).HasComment("NOT IN USE");

                entity.Property(e => e.LinkToCcnFlag).HasComment("NOT IN USE");

                entity.Property(e => e.LinkToMarketFlag).HasComment("NOT IN USE");

                entity.Property(e => e.LocalCityCode).HasComment("Default the Airport Code to Airport of Departure. It must be a valid Airport Code");

                entity.Property(e => e.MthToKeep).HasComment("NOT IN USE");

                entity.Property(e => e.MultiBookingFlag).HasComment("Allow the Booking entry in multiple AWB");

                entity.Property(e => e.NextBookingNo).HasComment("NOT IN USE");

                entity.Property(e => e.NextCargoTrfFormNo).HasComment("NOT IN USE");

                entity.Property(e => e.NextCollectNo).HasComment("NOT IN USE");

                entity.Property(e => e.NextColoadJobNo).HasComment("NOT IN USE");

                entity.Property(e => e.NextConsolJobNo).HasComment("NOT IN USE");

                entity.Property(e => e.NextDirectJobNo).HasComment("NOT IN USE");

                entity.Property(e => e.NextHawbNo).HasComment("Next No. to create the HAWB");

                entity.Property(e => e.NextInvoiceNo).HasComment("NOT IN USE");

                entity.Property(e => e.NextJobNo).HasComment("Next Job No when Job No Flag is set as C");

                entity.Property(e => e.NextJobNoMth01).HasComment("Next Job No for Mth 01 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth02).HasComment("Next Job No for Mth 02 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth03).HasComment("Next Job No for Mth 03 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth04).HasComment("Next Job No for Mth 04 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth05).HasComment("Next Job No for Mth 05 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth06).HasComment("Next Job No for Mth 06 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth07).HasComment("Next Job No for Mth 07 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth08).HasComment("Next Job No for Mth 08 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth09).HasComment("Next Job No for Mth 09 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth10).HasComment("Next Job No for Mth 10 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth11).HasComment("Next Job No for Mth 11 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth12).HasComment("Next Job No for Mth 12 when Job No Flag is set as M");

                entity.Property(e => e.NextSmawbJobNo).HasComment("NOT IN USE");

                entity.Property(e => e.NextTrfDate).HasComment("NOT IN USE");

                entity.Property(e => e.OthChgByAgentAirline).HasDefaultValueSql("('Y')");

                entity.Property(e => e.OtherChargeSpace).HasComment("Define the spacing between each charge on the Other Charges under the Charge Info tab in aeaw1");

                entity.Property(e => e.PartyNameLength).HasComment("Define the space between each charge in Charges Tab in aeaw1");

                entity.Property(e => e.PlaceOfExecute).HasComment("The place of the AWB executed");

                entity.Property(e => e.PostBy).HasComment("NOT IN USE");

                entity.Property(e => e.Print2DimensionSetOnRightFlag).HasComment("Define the spacing between each charge for Other Charges on the Charge Info tab in aeaw1 form");

                entity.Property(e => e.Print3DimensionSetFlag).HasComment("set as 'Y' to default the 'Print 3 Dimension Set' check-box as ticked in Load Dimension screen");

                entity.Property(e => e.PromptZeroPcsFlag).HasComment("Prompt user when Pcs is zero");

                entity.Property(e => e.SenderTtyAddr).HasComment("NOT IN USE");

                entity.Property(e => e.SetAutoComputeFlag).HasComment("Create new aeaw1 record, default if Auto Compute is ticked");

                entity.Property(e => e.SetChgWtDecPlace).HasComment("Set the decimal place of the Charge Weight");

                entity.Property(e => e.SetCommodityLength).HasComment("Set the Commodity Description Length");

                entity.Property(e => e.SetGrossWtDecPlace).HasComment("Set the decimal place of the Gross Weight");

                entity.Property(e => e.SetVolWtDecPlace).HasComment("Set the decimal place of the Volumetric Weight");

                entity.Property(e => e.ShowGrossWeightFlag).HasComment("Show the Gross Weight column in Dimension screen");

                entity.Property(e => e.SlacFlag).HasComment("If set as Y, then the SLAC Qty should be mandatory");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.TotalDimRoundUpFlag).HasComment("To round up the total dimension.If set Y, e.g 12.1 will round up to 13.0, if set T, e.g 12.1 will round up to 12.5. Recommend to set as Y");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UseMawbInventoryFlag).HasComment("Use the AWB Inventory to enter new AWB instead of auto-update the new AWB no to the AWB inventory table.");
            });

            modelBuilder.Entity<Aepv1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PostFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Aepv2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Aepv2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aepv2_aepv1");
            });

            modelBuilder.Entity<Aewb1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_Aewb1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<AiAllInvoiceByJob>(entity =>
            {
                entity.ToView("ai_All_Invoice_By_Job");
            });

            modelBuilder.Entity<AiAwbEntry>(entity =>
            {
                entity.ToView("ai_Awb_Entry");

                entity.Property(e => e.CargoReadyDate).IsFixedLength();

                entity.Property(e => e.CargoReceiptDate).IsFixedLength();

                entity.Property(e => e.DocReleaseDate).IsFixedLength();

                entity.Property(e => e.FirstEtaDate).IsFixedLength();

                entity.Property(e => e.FirstEtaTime).IsFixedLength();

                entity.Property(e => e.FirstEtdDate).IsFixedLength();

                entity.Property(e => e.FirstEtdTime).IsFixedLength();

                entity.Property(e => e.FirstFlightDate).IsFixedLength();

                entity.Property(e => e.FirstFlightTime).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.PermitDate).IsFixedLength();

                entity.Property(e => e.SecondEtaDate).IsFixedLength();

                entity.Property(e => e.SecondEtaTime).IsFixedLength();

                entity.Property(e => e.SecondEtdDate).IsFixedLength();

                entity.Property(e => e.SecondEtdTime).IsFixedLength();

                entity.Property(e => e.ThirdEtaDate).IsFixedLength();

                entity.Property(e => e.ThirdEtaTime).IsFixedLength();

                entity.Property(e => e.ThirdEtdDate).IsFixedLength();

                entity.Property(e => e.ThirdEtdTime).IsFixedLength();

                entity.Property(e => e.TrkReceiptDate).IsFixedLength();
            });

            modelBuilder.Entity<AiAwbReference>(entity =>
            {
                entity.ToView("ai_Awb_Reference");

                entity.Property(e => e.CargoReadyDate).IsFixedLength();

                entity.Property(e => e.CargoReceiptDate).IsFixedLength();

                entity.Property(e => e.DocReleaseDate).IsFixedLength();

                entity.Property(e => e.FirstEtaDate).IsFixedLength();

                entity.Property(e => e.FirstEtaTime).IsFixedLength();

                entity.Property(e => e.FirstEtdDate).IsFixedLength();

                entity.Property(e => e.FirstEtdTime).IsFixedLength();

                entity.Property(e => e.FirstFlightDate).IsFixedLength();

                entity.Property(e => e.FirstFlightTime).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.PermitDate).IsFixedLength();

                entity.Property(e => e.SecondEtaDate).IsFixedLength();

                entity.Property(e => e.SecondEtaTime).IsFixedLength();

                entity.Property(e => e.SecondEtdDate).IsFixedLength();

                entity.Property(e => e.SecondEtdTime).IsFixedLength();

                entity.Property(e => e.ThirdEtaDate).IsFixedLength();

                entity.Property(e => e.ThirdEtaTime).IsFixedLength();

                entity.Property(e => e.ThirdEtdDate).IsFixedLength();

                entity.Property(e => e.ThirdEtdTime).IsFixedLength();

                entity.Property(e => e.TrkReceiptDate).IsFixedLength();
            });

            modelBuilder.Entity<AiDeliveryOrder>(entity =>
            {
                entity.ToView("ai_Delivery_Order");

                entity.Property(e => e.FlightDate).IsFixedLength();
            });

            modelBuilder.Entity<AiInvoice1>(entity =>
            {
                entity.ToView("ai_Invoice_1");

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.FlightDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();
            });

            modelBuilder.Entity<AiInvoice2>(entity =>
            {
                entity.ToView("ai_Invoice_2");
            });

            modelBuilder.Entity<AiMawbLotNo>(entity =>
            {
                entity.ToView("ai_Mawb_LotNo");
            });

            modelBuilder.Entity<AiPaymentVoucher1>(entity =>
            {
                entity.ToView("ai_Payment_Voucher_1");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Aiaw1>(entity =>
            {
                entity.Property(e => e.AvailablePcs).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FaxCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.TranshipmentFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Aiaw2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo })
                    .HasName("PK__aiaw2__B354485D0BA3FEE5");
            });

            modelBuilder.Entity<Aido1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Aiiv1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PostFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WithHoldingTaxAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Aiiv2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Aiiv2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aiiv2_aiiv1");
            });

            modelBuilder.Entity<Aipa1>(entity =>
            {
                entity.HasKey(e => e.UniqueKey)
                    .IsClustered(false);

                entity.Property(e => e.BankAccCode).HasComment("Bank Account Code@vw_glch1,acc code");

                entity.Property(e => e.BankCode).HasComment("Define the BankCode to default the BankCode in ivcr1_5");

                entity.Property(e => e.Cafcode).HasComment("Define the CAF charge code when click the Freight button on the Job Costing");

                entity.Property(e => e.CafminAmt).HasComment("Define the CAF Min Amt");

                entity.Property(e => e.Cafrate).HasComment("Define the CAF Rate");

                entity.Property(e => e.CashAccCode).HasComment("Default the Cash Acc Code to the Cash Receipt");

                entity.Property(e => e.CashReceiptPrefix).HasComment("NOT IN USE");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DefaultOther).HasComment("Default the Other Charge as P - Prepaid or C- Collect when entering a new AWB");

                entity.Property(e => e.DefaultUomCode).HasComment("Default the Unit of Measurement Code when entering a new AWB. The code must be a valid code in UOM Table");

                entity.Property(e => e.DefaultWeightValue).HasComment("Default the Freight Charge as P - Prepaid or C- Collect when entering a new AWB");

                entity.Property(e => e.DocAttachLabel1).HasComment("Define the 1st Documents Attached label name on the Case Marks tab in aido1");

                entity.Property(e => e.DocAttachLabel2).HasComment("Define the 2nd Documents Attached label name on the Case Marks tab in aido1");

                entity.Property(e => e.DocAttachLabel3).HasComment("Define the 3rd Documents Attached label name on the Case Marks tab in aido1");

                entity.Property(e => e.DocAttachLabel4).HasComment("Define the 4th Documents Attached label name on the Case Marks tab in aido1");

                entity.Property(e => e.DocAttachLabel5).HasComment("Define the 5th Documents Attached label name on the Case Marks tab in aido1");

                entity.Property(e => e.DocAttachLabel6).HasComment("Define the 6th Documents Attached label name on the Case Marks tab in aido1");

                entity.Property(e => e.DocAttachLabel7).HasComment("Define the 7th Documents Attached label name on the Case Marks tab in aido1");

                entity.Property(e => e.DocAttachLabel8).HasComment("Define the 8th Documents Attached label name on the Case Marks tab in aido1");

                entity.Property(e => e.DocumentFooter1).HasComment("Print to Footer 1 of the Air Import related documents");

                entity.Property(e => e.DocumentFooter2).HasComment("Print to Footer 2 of the Air Import related documents");

                entity.Property(e => e.Fcbcode).HasComment("Define the FCB charge code when click the Freight button on the Job Costing");

                entity.Property(e => e.FcbminAmt).HasComment("Define the FCB Min Amt");

                entity.Property(e => e.Fcbrate).HasComment("Defint the FCB Rate");

                entity.Property(e => e.FrtChgColCode).HasComment("Default Freight Charge Collect Item Code in the Job Costing.  It must be a valid code in Charge List in Account Reference");

                entity.Property(e => e.FrtChgColMinAmt).HasComment("Default Freight Charge Collect minimum amount in the Job Costing");

                entity.Property(e => e.FrtChgColRate).HasComment("Default Freight Charge Collect unit rate in the Job Costing");

                entity.Property(e => e.FrtItemCode).HasComment("Define the Item Code for the Freight Charge. It must be a valid code in Charge List in Account Reference");

                entity.Property(e => e.JobDateType).HasComment("Job Date is always update as Create Date.");

                entity.Property(e => e.JobNoAutoFlag).HasComment("Job running no. is created by Job running no. is created by C - Continously, M - Monthly, S - Shipment Type");

                entity.Property(e => e.JobPrefix1).HasComment("Job Prefix 1 Format select one value from YY,MM,DST or FXX");

                entity.Property(e => e.JobPrefix2).HasComment("Job Prefix 2 Format select one value from YY,MM,DST or FXX");

                entity.Property(e => e.JobPrefix3).HasComment("Job Prefix 3 Format select one value from YY,MM,DST or FXX");

                entity.Property(e => e.JobPrefix4).HasComment("Job Prefix 4 Format select one value from YY,MM,DST or FXX");

                entity.Property(e => e.JobPrefix5).HasComment("Job Prefix 5 Format select one value from YY,MM,DST or FXX");

                entity.Property(e => e.K1).HasComment("For Malaysia Custom System Form K1");

                entity.Property(e => e.K2).HasComment("For Malaysia Custom System Form K2");

                entity.Property(e => e.K3).HasComment("For Malaysia Custom System Form K3");

                entity.Property(e => e.K4).HasComment("For Malaysia Custom System Form K4");

                entity.Property(e => e.K5).HasComment("For Malaysia Custom System Form K5");

                entity.Property(e => e.K6).HasComment("For Malaysia Custom System Form K6");

                entity.Property(e => e.K7).HasComment("For Malaysia Custom System Form K7");

                entity.Property(e => e.K8).HasComment("For Malaysia Custom System Form K8");

                entity.Property(e => e.K9).HasComment("For Malaysia Custom System Form K9");

                entity.Property(e => e.LastPostDate).HasComment("NOT IN USE");

                entity.Property(e => e.MarkupCode).HasComment("NOT IN USE");

                entity.Property(e => e.MarkupRate).HasComment("Foreign Exchnage Rate markup in percentage");

                entity.Property(e => e.NextCashReceiptNo).HasComment("NOT IN USE");

                entity.Property(e => e.NextColoadJobNo).HasComment("NOT IN USE");

                entity.Property(e => e.NextConsolJobNo).HasComment("NOT IN USE");

                entity.Property(e => e.NextConsolManifestNo).HasComment("NOT IN USE");

                entity.Property(e => e.NextDeliveryOrderNo).HasComment("Next Delivery Order No");

                entity.Property(e => e.NextDirectJobNo).HasComment("NOT IN USE");

                entity.Property(e => e.NextDirectManifestNo).HasComment("NOT IN USE");

                entity.Property(e => e.NextJobNo).HasComment("Next Job No when Job No Flag is set as C");

                entity.Property(e => e.NextJobNoMth01).HasComment("Next Job No for Mth 01 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth02).HasComment("Next Job No for Mth 02 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth03).HasComment("Next Job No for Mth 03 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth04).HasComment("Next Job No for Mth 04 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth05).HasComment("Next Job No for Mth 05 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth06).HasComment("Next Job No for Mth 06 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth07).HasComment("Next Job No for Mth 07 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth08).HasComment("Next Job No for Mth 08 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth09).HasComment("Next Job No for Mth 09 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth10).HasComment("Next Job No for Mth 10 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth11).HasComment("Next Job No for Mth 11 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth12).HasComment("Next Job No for Mth 12 when Job No Flag is set as M");

                entity.Property(e => e.NextSmawbJobNo).HasComment("NOT IN USE");

                entity.Property(e => e.NextTrfDate).HasComment("NOT IN USE");

                entity.Property(e => e.PostBy).HasComment("NOT IN USE");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Aipv1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PostFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Aipv2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Aipv2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aipv2_aipv1");
            });

            modelBuilder.Entity<Amac1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .IsClustered(false);

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CommodityCode01Navigation)
                    .WithMany(p => p.Amac1CommodityCode01Navigations)
                    .HasForeignKey(d => d.CommodityCode01)
                    .HasConstraintName("FK_amac1_rccm1");

                entity.HasOne(d => d.CommodityCode02Navigation)
                    .WithMany(p => p.Amac1CommodityCode02Navigations)
                    .HasForeignKey(d => d.CommodityCode02)
                    .HasConstraintName("FK_amac1_rccm11");

                entity.HasOne(d => d.CommodityCode03Navigation)
                    .WithMany(p => p.Amac1CommodityCode03Navigations)
                    .HasForeignKey(d => d.CommodityCode03)
                    .HasConstraintName("FK_amac1_rccm12");

                entity.HasOne(d => d.CommodityCode04Navigation)
                    .WithMany(p => p.Amac1CommodityCode04Navigations)
                    .HasForeignKey(d => d.CommodityCode04)
                    .HasConstraintName("FK_amac1_rccm13");

                entity.HasOne(d => d.CommodityCode05Navigation)
                    .WithMany(p => p.Amac1CommodityCode05Navigations)
                    .HasForeignKey(d => d.CommodityCode05)
                    .HasConstraintName("FK_amac1_rccm14");

                entity.HasOne(d => d.CommodityCode06Navigation)
                    .WithMany(p => p.Amac1CommodityCode06Navigations)
                    .HasForeignKey(d => d.CommodityCode06)
                    .HasConstraintName("FK_amac1_rccm15");

                entity.HasOne(d => d.CommodityCode07Navigation)
                    .WithMany(p => p.Amac1CommodityCode07Navigations)
                    .HasForeignKey(d => d.CommodityCode07)
                    .HasConstraintName("FK_amac1_rccm16");

                entity.HasOne(d => d.CommodityCode08Navigation)
                    .WithMany(p => p.Amac1CommodityCode08Navigations)
                    .HasForeignKey(d => d.CommodityCode08)
                    .HasConstraintName("FK_amac1_rccm17");

                entity.HasOne(d => d.CommodityCode09Navigation)
                    .WithMany(p => p.Amac1CommodityCode09Navigations)
                    .HasForeignKey(d => d.CommodityCode09)
                    .HasConstraintName("FK_amac1_rccm18");

                entity.HasOne(d => d.CommodityCode10Navigation)
                    .WithMany(p => p.Amac1CommodityCode10Navigations)
                    .HasForeignKey(d => d.CommodityCode10)
                    .HasConstraintName("FK_amac1_rccm19");

                entity.HasOne(d => d.CommodityCode11Navigation)
                    .WithMany(p => p.Amac1CommodityCode11Navigations)
                    .HasForeignKey(d => d.CommodityCode11)
                    .HasConstraintName("FK_amac1_rccm110");

                entity.HasOne(d => d.CommodityCode12Navigation)
                    .WithMany(p => p.Amac1CommodityCode12Navigations)
                    .HasForeignKey(d => d.CommodityCode12)
                    .HasConstraintName("FK_amac1_rccm111");

                entity.HasOne(d => d.CommodityCode13Navigation)
                    .WithMany(p => p.Amac1CommodityCode13Navigations)
                    .HasForeignKey(d => d.CommodityCode13)
                    .HasConstraintName("FK_amac1_rccm112");

                entity.HasOne(d => d.CommodityCode14Navigation)
                    .WithMany(p => p.Amac1CommodityCode14Navigations)
                    .HasForeignKey(d => d.CommodityCode14)
                    .HasConstraintName("FK_amac1_rccm113");

                entity.HasOne(d => d.CommodityCode15Navigation)
                    .WithMany(p => p.Amac1CommodityCode15Navigations)
                    .HasForeignKey(d => d.CommodityCode15)
                    .HasConstraintName("FK_amac1_rccm114");

                entity.HasOne(d => d.CommodityCode16Navigation)
                    .WithMany(p => p.Amac1CommodityCode16Navigations)
                    .HasForeignKey(d => d.CommodityCode16)
                    .HasConstraintName("FK_amac1_rccm115");

                entity.HasOne(d => d.CommodityCode17Navigation)
                    .WithMany(p => p.Amac1CommodityCode17Navigations)
                    .HasForeignKey(d => d.CommodityCode17)
                    .HasConstraintName("FK_amac1_rccm116");

                entity.HasOne(d => d.CommodityCode18Navigation)
                    .WithMany(p => p.Amac1CommodityCode18Navigations)
                    .HasForeignKey(d => d.CommodityCode18)
                    .HasConstraintName("FK_amac1_rccm117");

                entity.HasOne(d => d.CommodityCode19Navigation)
                    .WithMany(p => p.Amac1CommodityCode19Navigations)
                    .HasForeignKey(d => d.CommodityCode19)
                    .HasConstraintName("FK_amac1_rccm118");

                entity.HasOne(d => d.CommodityCode20Navigation)
                    .WithMany(p => p.Amac1CommodityCode20Navigations)
                    .HasForeignKey(d => d.CommodityCode20)
                    .HasConstraintName("FK_amac1_rccm119");

                entity.HasOne(d => d.DestCodeNavigation)
                    .WithMany(p => p.Amac1DestCodeNavigations)
                    .HasForeignKey(d => d.DestCode)
                    .HasConstraintName("FK_amac1_rcap11");

                entity.HasOne(d => d.OriginCodeNavigation)
                    .WithMany(p => p.Amac1OriginCodeNavigations)
                    .HasForeignKey(d => d.OriginCode)
                    .HasConstraintName("FK_amac1_rcap1");
            });

            modelBuilder.Entity<Amac2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Amac3>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Amad1>(entity =>
            {
                entity.HasKey(e => e.BusinessPartyCode)
                    .IsClustered(false);

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Amad2>(entity =>
            {
                entity.HasKey(e => new { e.BusinessPartyCode, e.LineItemNo });

                entity.HasOne(d => d.BusinessPartyCodeNavigation)
                    .WithMany(p => p.Amad2s)
                    .HasForeignKey(d => d.BusinessPartyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_amad2_amad1");
            });

            modelBuilder.Entity<Amah1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PrintFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Amaq1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .IsClustered(false);

                entity.HasIndex(e => new { e.OriginCode, e.DestCode, e.AgentCode, e.AirlineId, e.Type }, "IX_amaq1_1")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Ambr1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .IsClustered(false);

                entity.HasIndex(e => new { e.OriginCode, e.DestCode, e.DeliveryType }, "IX_ambr1")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Amdc1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .IsClustered(false);

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AwbChargeCodeNavigation)
                    .WithMany(p => p.Amdc1s)
                    .HasForeignKey(d => d.AwbChargeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_amdc1_rchc1");

                entity.HasOne(d => d.DistrictCodeNavigation)
                    .WithMany(p => p.Amdc1s)
                    .HasForeignKey(d => d.DistrictCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_amdc1_rcdc1_1");

                entity.HasOne(d => d.SalesItemCodeNavigation)
                    .WithMany(p => p.Amdc1s)
                    .HasForeignKey(d => d.SalesItemCode)
                    .HasConstraintName("FK_amdc1_acit1_1");
            });

            modelBuilder.Entity<Amfe1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .IsClustered(false);

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Amfq1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_amfq1_1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Amfq2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.QuoteLineItemNo })
                    .HasName("PK_amfq2_1");
            });

            modelBuilder.Entity<Amfq3>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.QuoteLineItemNo, e.LineItemNo })
                    .HasName("PK_Amfq3");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Amfq4>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.QuoteLineItemNo, e.LineItemNo });
            });

            modelBuilder.Entity<Amfq5>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.Property(e => e.ActualCostAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.Amt).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostCurrRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostUnitRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.LocalAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.Qty).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Amfq6>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Amic1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .IsClustered(false);

                entity.HasIndex(e => new { e.OriginCode, e.DestCode, e.AirlineId, e.Type }, "IX_amic1")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Amid1>(entity =>
            {
                entity.HasKey(e => e.BusinessPartyCode)
                    .IsClustered(false);

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.QuoteTableNoNavigation)
                    .WithMany(p => p.Amid1s)
                    .HasForeignKey(d => d.QuoteTableNo)
                    .HasConstraintName("FK_amid1_amio1");
            });

            modelBuilder.Entity<Amid2>(entity =>
            {
                entity.HasKey(e => new { e.BusinessPartyCode, e.LineItemNo });

                entity.HasOne(d => d.AwbChargeCodeNavigation)
                    .WithMany(p => p.Amid2s)
                    .HasForeignKey(d => d.AwbChargeCode)
                    .HasConstraintName("FK_amid2_rchc1");

                entity.HasOne(d => d.BusinessPartyCodeNavigation)
                    .WithMany(p => p.Amid2s)
                    .HasForeignKey(d => d.BusinessPartyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_amid2__amid1");

                entity.HasOne(d => d.SalesItemCodeNavigation)
                    .WithMany(p => p.Amid2s)
                    .HasForeignKey(d => d.SalesItemCode)
                    .HasConstraintName("FK_amid2_acit1_1");
            });

            modelBuilder.Entity<Amie1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .IsClustered(false);

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Amif1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .IsClustered(false);

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CommodityCode01Navigation)
                    .WithMany(p => p.Amif1CommodityCode01Navigations)
                    .HasForeignKey(d => d.CommodityCode01)
                    .HasConstraintName("FK_amif1_rccm1");

                entity.HasOne(d => d.CommodityCode02Navigation)
                    .WithMany(p => p.Amif1CommodityCode02Navigations)
                    .HasForeignKey(d => d.CommodityCode02)
                    .HasConstraintName("FK_amif1_rccm11");

                entity.HasOne(d => d.CommodityCode03Navigation)
                    .WithMany(p => p.Amif1CommodityCode03Navigations)
                    .HasForeignKey(d => d.CommodityCode03)
                    .HasConstraintName("FK_amif1_rccm12");

                entity.HasOne(d => d.CommodityCode04Navigation)
                    .WithMany(p => p.Amif1CommodityCode04Navigations)
                    .HasForeignKey(d => d.CommodityCode04)
                    .HasConstraintName("FK_amif1_rccm13");

                entity.HasOne(d => d.CommodityCode05Navigation)
                    .WithMany(p => p.Amif1CommodityCode05Navigations)
                    .HasForeignKey(d => d.CommodityCode05)
                    .HasConstraintName("FK_amif1_rccm14");

                entity.HasOne(d => d.CommodityCode06Navigation)
                    .WithMany(p => p.Amif1CommodityCode06Navigations)
                    .HasForeignKey(d => d.CommodityCode06)
                    .HasConstraintName("FK_amif1_rccm15");

                entity.HasOne(d => d.CommodityCode07Navigation)
                    .WithMany(p => p.Amif1CommodityCode07Navigations)
                    .HasForeignKey(d => d.CommodityCode07)
                    .HasConstraintName("FK_amif1_rccm16");

                entity.HasOne(d => d.CommodityCode08Navigation)
                    .WithMany(p => p.Amif1CommodityCode08Navigations)
                    .HasForeignKey(d => d.CommodityCode08)
                    .HasConstraintName("FK_amif1_rccm17");

                entity.HasOne(d => d.CommodityCode09Navigation)
                    .WithMany(p => p.Amif1CommodityCode09Navigations)
                    .HasForeignKey(d => d.CommodityCode09)
                    .HasConstraintName("FK_amif1_rccm18");

                entity.HasOne(d => d.CommodityCode10Navigation)
                    .WithMany(p => p.Amif1CommodityCode10Navigations)
                    .HasForeignKey(d => d.CommodityCode10)
                    .HasConstraintName("FK_amif1_rccm19");

                entity.HasOne(d => d.CommodityCode11Navigation)
                    .WithMany(p => p.Amif1CommodityCode11Navigations)
                    .HasForeignKey(d => d.CommodityCode11)
                    .HasConstraintName("FK_amif1_rccm110");

                entity.HasOne(d => d.CommodityCode12Navigation)
                    .WithMany(p => p.Amif1CommodityCode12Navigations)
                    .HasForeignKey(d => d.CommodityCode12)
                    .HasConstraintName("FK_amif1_rccm111");

                entity.HasOne(d => d.CommodityCode13Navigation)
                    .WithMany(p => p.Amif1CommodityCode13Navigations)
                    .HasForeignKey(d => d.CommodityCode13)
                    .HasConstraintName("FK_amif1_rccm112");

                entity.HasOne(d => d.CommodityCode14Navigation)
                    .WithMany(p => p.Amif1CommodityCode14Navigations)
                    .HasForeignKey(d => d.CommodityCode14)
                    .HasConstraintName("FK_amif1_rccm113");

                entity.HasOne(d => d.CommodityCode15Navigation)
                    .WithMany(p => p.Amif1CommodityCode15Navigations)
                    .HasForeignKey(d => d.CommodityCode15)
                    .HasConstraintName("FK_amif1_rccm114");

                entity.HasOne(d => d.CommodityCode16Navigation)
                    .WithMany(p => p.Amif1CommodityCode16Navigations)
                    .HasForeignKey(d => d.CommodityCode16)
                    .HasConstraintName("FK_amif1_rccm115");

                entity.HasOne(d => d.CommodityCode17Navigation)
                    .WithMany(p => p.Amif1CommodityCode17Navigations)
                    .HasForeignKey(d => d.CommodityCode17)
                    .HasConstraintName("FK_amif1_rccm116");

                entity.HasOne(d => d.CommodityCode18Navigation)
                    .WithMany(p => p.Amif1CommodityCode18Navigations)
                    .HasForeignKey(d => d.CommodityCode18)
                    .HasConstraintName("FK_amif1_rccm117");

                entity.HasOne(d => d.CommodityCode19Navigation)
                    .WithMany(p => p.Amif1CommodityCode19Navigations)
                    .HasForeignKey(d => d.CommodityCode19)
                    .HasConstraintName("FK_amif1_rccm118");

                entity.HasOne(d => d.CommodityCode20Navigation)
                    .WithMany(p => p.Amif1CommodityCode20Navigations)
                    .HasForeignKey(d => d.CommodityCode20)
                    .HasConstraintName("FK_amif1_rccm119");

                entity.HasOne(d => d.CurrCodeNavigation)
                    .WithMany(p => p.Amif1s)
                    .HasForeignKey(d => d.CurrCode)
                    .HasConstraintName("FK_amif1_glex1");

                entity.HasOne(d => d.DestCodeNavigation)
                    .WithMany(p => p.Amif1DestCodeNavigations)
                    .HasForeignKey(d => d.DestCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_amif1_rcap11");

                entity.HasOne(d => d.OriginCodeNavigation)
                    .WithMany(p => p.Amif1OriginCodeNavigations)
                    .HasForeignKey(d => d.OriginCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_amif1_rcap1");
            });

            modelBuilder.Entity<Amio1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Amio2>(entity =>
            {
                entity.HasKey(e => new { e.QuoteTableNo, e.LineItemNo })
                    .IsClustered(false);

                entity.HasOne(d => d.AwbChargeCodeNavigation)
                    .WithMany(p => p.Amio2s)
                    .HasForeignKey(d => d.AwbChargeCode)
                    .HasConstraintName("FK_amio2_rchc1");

                entity.HasOne(d => d.QuoteTableNoNavigation)
                    .WithMany(p => p.Amio2s)
                    .HasForeignKey(d => d.QuoteTableNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_amio2_amio1");

                entity.HasOne(d => d.SalesItemCodeNavigation)
                    .WithMany(p => p.Amio2s)
                    .HasForeignKey(d => d.SalesItemCode)
                    .HasConstraintName("FK_amio2_acit1");
            });

            modelBuilder.Entity<Amir1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .IsClustered(false);

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Ampa1>(entity =>
            {
                entity.HasKey(e => e.UniqueKey)
                    .IsClustered(false);

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrCode).HasComment("Default the Curr Code as Curr Code in Charges in Freight Quotataion");

                entity.Property(e => e.DefHdr01).HasComment("NOT IN USE");

                entity.Property(e => e.DefHdr02).HasComment("NOT IN USE");

                entity.Property(e => e.DefHdr03).HasComment("NOT IN USE");

                entity.Property(e => e.DefHdr04).HasComment("NOT IN USE");

                entity.Property(e => e.DefHdr05).HasComment("NOT IN USE");

                entity.Property(e => e.DefHdr06).HasComment("NOT IN USE");

                entity.Property(e => e.DefHdr07).HasComment("NOT IN USE");

                entity.Property(e => e.DefHdr08).HasComment("NOT IN USE");

                entity.Property(e => e.DefHdr09).HasComment("NOT IN USE");

                entity.Property(e => e.DefHdr10).HasComment("NOT IN USE");

                entity.Property(e => e.DefRateClassCode01).HasComment("Default the Rate Class M, N, Q, C to all Rate Table");

                entity.Property(e => e.DefRateClassCode02).HasComment("Default the Rate Class M, N, Q, C to all Rate Table");

                entity.Property(e => e.DefRateClassCode03).HasComment("Default the Rate Class M, N, Q, C to all Rate Table");

                entity.Property(e => e.DefRateClassCode04).HasComment("Default the Rate Class M, N, Q, C to all Rate Table");

                entity.Property(e => e.DefRateClassCode05).HasComment("Default the Rate Class M, N, Q, C to all Rate Table");

                entity.Property(e => e.DefRateClassCode06).HasComment("Default the Rate Class M, N, Q, C to all Rate Table");

                entity.Property(e => e.DefRateClassCode07).HasComment("Default the Rate Class M, N, Q, C to all Rate Table");

                entity.Property(e => e.DefRateClassCode08).HasComment("Default the Rate Class M, N, Q, C to all Rate Table");

                entity.Property(e => e.DefRateClassCode09).HasComment("Default the Rate Class M, N, Q, C to all Rate Table");

                entity.Property(e => e.DefRateClassCode10).HasComment("Default the Rate Class M, N, Q, C to all Rate Table");

                entity.Property(e => e.DefWeightBreak01).HasComment("Default the Break Point 01 when enter new IATA or Freight Quotation");

                entity.Property(e => e.DefWeightBreak02).HasComment("Default the Break Point 02 when enter new IATA or Freight Quotation");

                entity.Property(e => e.DefWeightBreak03).HasComment("Default the Break Point 03 when enter new IATA or Freight Quotation");

                entity.Property(e => e.DefWeightBreak04).HasComment("Default the Break Point 04 when enter new IATA or Freight Quotation");

                entity.Property(e => e.DefWeightBreak05).HasComment("Default the Break Point 05 when enter new IATA or Freight Quotation");

                entity.Property(e => e.DefWeightBreak06).HasComment("Default the Break Point 06 when enter new IATA or Freight Quotation");

                entity.Property(e => e.DefWeightBreak07).HasComment("Default the Break Point 07 when enter new IATA or Freight Quotation");

                entity.Property(e => e.DefWeightBreak08).HasComment("Default the Break Point 08 when enter new IATA or Freight Quotation");

                entity.Property(e => e.DefWeightBreak09).HasComment("Default the Break Point 09 when enter new IATA or Freight Quotation");

                entity.Property(e => e.DefWeightBreak10).HasComment("Default the Break Point 10 when enter new IATA or Freight Quotation");

                entity.Property(e => e.DefWeightBreak11).HasComment("Default the Break Point 11 when enter new IATA or Freight Quotation");

                entity.Property(e => e.DefWeightBreak12).HasComment("Default the Break Point 12 when enter new IATA or Freight Quotation");

                entity.Property(e => e.DefWeightBreak13).HasComment("Default the Break Point 13 when enter new IATA or Freight Quotation");

                entity.Property(e => e.DefWeightBreak14).HasComment("Default the Break Point 14 when enter new IATA or Freight Quotation");

                entity.Property(e => e.DefWeightBreak15).HasComment("Default the Break Point 15 when enter new IATA or Freight Quotation");

                entity.Property(e => e.DefWeightBreak16).HasComment("Default the Break Point 16 when enter new IATA or Freight Quotation");

                entity.Property(e => e.DefWeightType).HasComment("Default to aeaw1 KaLbFlag");

                entity.Property(e => e.FormatType).HasComment("Quotation No format\r\n- If set as 1, Quotation No format is Quotation Type(2 digits) + Salesman Code(2 digits) + YY + Next No\r\n- If leave blank, Quotation No format is Salesman Code + ‘-‘ + A + No(5 digits)");

                entity.Property(e => e.HideCostRateFlag).HasComment("NOT IN USE");

                entity.Property(e => e.MarkupRate).HasComment("The percentage to mark the Currency Rate");

                entity.Property(e => e.NextQuoteNo).HasComment("Set Next Quote No for Freight Quotation(Amfq1)");

                entity.Property(e => e.ShowJobCostingRemarkFlag).HasComment("Set as Y, show JobCostingRemark as a column instead of picture icon.");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Validity).HasComment("NOT IN USE");

                entity.Property(e => e.ValidityDays).HasComment("Default No. of Day of Validity Days to Freight Quotation");
            });

            modelBuilder.Entity<Amqo1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Amqo2>(entity =>
            {
                entity.HasKey(e => new { e.QuoteTableNo, e.LineItemNo });
            });

            modelBuilder.Entity<Anac1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Anam1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AgentIssueFormNoNavigation)
                    .WithMany(p => p.Anam1AgentIssueFormNoNavigations)
                    .HasForeignKey(d => d.AgentIssueFormNo)
                    .HasConstraintName("FK_anam1_anat1");

                entity.HasOne(d => d.AgentReturnFormNoNavigation)
                    .WithMany(p => p.Anam1AgentReturnFormNoNavigations)
                    .HasForeignKey(d => d.AgentReturnFormNo)
                    .HasConstraintName("FK_anam1_anat11");

                entity.HasOne(d => d.ReceiptFormNoNavigation)
                    .WithMany(p => p.Anam1ReceiptFormNoNavigations)
                    .HasForeignKey(d => d.ReceiptFormNo)
                    .HasConstraintName("FK_anam1_anat12");

                entity.HasOne(d => d.ReleaseFormNoNavigation)
                    .WithMany(p => p.Anam1ReleaseFormNoNavigations)
                    .HasForeignKey(d => d.ReleaseFormNo)
                    .HasConstraintName("FK_anam1_anat13");

                entity.HasOne(d => d.ReturnFormNoNavigation)
                    .WithMany(p => p.Anam1ReturnFormNoNavigations)
                    .HasForeignKey(d => d.ReturnFormNo)
                    .HasConstraintName("FK_anam1_anat14");
            });

            modelBuilder.Entity<Anat1>(entity =>
            {
                entity.HasKey(e => e.FormNo)
                    .IsClustered(false);

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FaxCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AwbCodeNavigation)
                    .WithMany(p => p.Anat1s)
                    .HasForeignKey(d => d.AwbCode)
                    .HasConstraintName("FK_anat1_anac1");
            });

            modelBuilder.Entity<Anat2>(entity =>
            {
                entity.HasKey(e => new { e.FormNo, e.LineItemNo });

                entity.HasOne(d => d.FormNoNavigation)
                    .WithMany(p => p.Anat2s)
                    .HasForeignKey(d => d.FormNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_anat2_anat1");
            });

            modelBuilder.Entity<Anbb1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_vw_Anbb1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Anbb2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Anbb3>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Anbb3s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_anbb3_anbb1");
            });

            modelBuilder.Entity<Ancf1>(entity =>
            {
                entity.HasKey(e => e.AwbCode)
                    .IsClustered(false);

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Asjd1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Asjd2>(entity =>
            {
                entity.HasKey(e => new { e.JobNo, e.LineItemNo })
                    .IsClustered(false);

                entity.HasOne(d => d.CurrCodeNavigation)
                    .WithMany(p => p.Asjd2s)
                    .HasForeignKey(d => d.CurrCode)
                    .HasConstraintName("FK_asjd2_glex1");
            });

            modelBuilder.Entity<Asjd3>(entity =>
            {
                entity.HasKey(e => new { e.JobNo, e.LineItemNo })
                    .IsClustered(false);

                entity.HasOne(d => d.CurrCodeNavigation)
                    .WithMany(p => p.Asjd3s)
                    .HasForeignKey(d => d.CurrCode)
                    .HasConstraintName("FK_asjd3_glex1");
            });

            modelBuilder.Entity<Asst1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AvailPort>(entity =>
            {
                entity.ToView("AvailPort");
            });

            modelBuilder.Entity<Brba1>(entity =>
            {
                entity.HasKey(e => e.BankAccCode)
                    .IsClustered(false);

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Brtx1>(entity =>
            {
                entity.HasKey(e => e.AccCode)
                    .IsClustered(false);

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Csbk1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemNo).HasDefaultValueSql("((1))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Csbk2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Csbk2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_csbk2_csbk1");
            });

            modelBuilder.Entity<Ctcl1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Ctdo1>(entity =>
            {
                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Ctdo2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo })
                    .HasName("PK__Ctdo2__B354485D683B926E");
            });

            modelBuilder.Entity<Ctfa1>(entity =>
            {
                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Ctri1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_RI");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Ctro1>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo })
                    .HasName("PK_RO");

                entity.Property(e => e.PreSetSign).HasDefaultValueSql("(N'+')");

                entity.Property(e => e.PreSetType).HasDefaultValueSql("(N'C')");

                entity.Property(e => e.VoltageCode).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ctro2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo, e.BookingLineItemNo });
            });

            modelBuilder.Entity<Ctrp2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.Property(e => e.LineItemNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Ctso1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_CTS_SO");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Ctso2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo })
                    .HasName("PK_SO_Contr");

                entity.Property(e => e.RvFlag).HasDefaultValueSql("(N'N')");
            });

            modelBuilder.Entity<DischargePort>(entity =>
            {
                entity.ToView("DischargePort");
            });

            modelBuilder.Entity<DtOnhand>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<Edal1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Edci1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Edpk1>(entity =>
            {
                entity.HasKey(e => new { e.CommercialInvoiceNo, e.LineItemNo });
            });

            modelBuilder.Entity<GlAccCodeYear>(entity =>
            {
                entity.ToView("gl_Acc_Code_Year");
            });

            modelBuilder.Entity<GlAccountBalance>(entity =>
            {
                entity.ToView("gl_Account_Balance");
            });

            modelBuilder.Entity<GlAllBankTransaction>(entity =>
            {
                entity.ToView("Gl_All_Bank_Transaction");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();
            });

            modelBuilder.Entity<GlAllCheque>(entity =>
            {
                entity.ToView("gl_All_Cheque");

                entity.Property(e => e.ChequeDate).IsFixedLength();
            });

            modelBuilder.Entity<GlBalanceSheetAcc>(entity =>
            {
                entity.ToView("gl_Balance_Sheet_Acc");
            });

            modelBuilder.Entity<GlBankTransaction>(entity =>
            {
                entity.ToView("gl_Bank_Transaction");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.ClearDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();
            });

            modelBuilder.Entity<GlChartOfAccount>(entity =>
            {
                entity.ToView("gl_Chart_Of_Accounts");
            });

            modelBuilder.Entity<GlProfitLossAcc>(entity =>
            {
                entity.ToView("gl_Profit_Loss_Acc");
            });

            modelBuilder.Entity<GlYtdLedger>(entity =>
            {
                entity.ToView("gl_YTD_Ledger");

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();
            });

            modelBuilder.Entity<Glbc1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Glbc2>(entity =>
            {
                entity.HasKey(e => new { e.BankCode, e.UserId });
            });

            modelBuilder.Entity<Glbc3>(entity =>
            {
                entity.HasKey(e => new { e.BankCode, e.LineItemNo });
            });

            modelBuilder.Entity<Glbh1>(entity =>
            {
                entity.HasKey(e => e.BranchCode)
                    .HasName("PK__Glbh1__1C61B88908B283A1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Glbh2>(entity =>
            {
                entity.HasKey(e => new { e.LineItemNo, e.BranchCode })
                    .HasName("PK__Glbh2__0B4118596A2DFC81");
            });

            modelBuilder.Entity<Glbl1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mth00Balance).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth01Balance).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth01Budget).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth02Balance).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth02Budget).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth03Balance).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth03Budget).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth04Balance).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth04Budget).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth05Balance).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth05Budget).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth06Balance).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth06Budget).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth07Balance).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth07Budget).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth08Balance).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth08Budget).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth09Balance).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth09Budget).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth10Balance).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth10Budget).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth11Balance).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth11Budget).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth12Balance).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth12Budget).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth13Balance).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth13Budget).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth14Balance).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth14Budget).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth15Balance).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth15Budget).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth16Balance).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth16Budget).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth17Balance).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth17Budget).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth18Balance).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mth18Budget).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Glbt1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Glcc1>(entity =>
            {
                entity.HasKey(e => e.CostCenterCode)
                    .HasName("PK__glcc1__5662EF4615840588");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Glcf1>(entity =>
            {
                entity.HasKey(e => e.CashFlowAnalysisCode)
                    .IsClustered(false);

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Glch1>(entity =>
            {
                entity.Property(e => e.AnalysisCode1).HasDefaultValueSql("('')");

                entity.Property(e => e.AnalysisCode2).HasDefaultValueSql("('')");

                entity.Property(e => e.AnalysisCode3).HasDefaultValueSql("('')");

                entity.Property(e => e.AnalysisCode4).HasDefaultValueSql("('')");

                entity.Property(e => e.AnalysisCode5).HasDefaultValueSql("('')");

                entity.Property(e => e.ControlAccFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HeadingFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.KeepForeignBalanceFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.KeepYtdGlFlag).HasDefaultValueSql("('Y')");

                entity.Property(e => e.PostDetailFlag).HasDefaultValueSql("('Y')");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Glch2>(entity =>
            {
                entity.HasKey(e => new { e.AccCode, e.FinancialYear });
            });

            modelBuilder.Entity<Glct1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Gldc1>(entity =>
            {
                entity.HasKey(e => e.DepartmentCode)
                    .HasName("PK__gldc1__6EA8896C256EBDE0");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Gleh1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Glex1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VariancePercent).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Glex2>(entity =>
            {
                entity.HasKey(e => new { e.CurrCode, e.EffectiveDate });
            });

            modelBuilder.Entity<Glfa1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DisposalFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Glfb1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .IsClustered(false);

                entity.Property(e => e.TrxNo).ValueGeneratedNever();

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CurrCodeNavigation)
                    .WithMany(p => p.Glfb1s)
                    .HasForeignKey(d => d.CurrCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_glfb1_glex1");
            });

            modelBuilder.Entity<Glfv1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .IsClustered(false);

                entity.Property(e => e.TrxNo).ValueGeneratedNever();

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CurrCodeNavigation)
                    .WithMany(p => p.Glfv1s)
                    .HasForeignKey(d => d.CurrCode)
                    .HasConstraintName("FK_glfv1_glex1");
            });

            modelBuilder.Entity<Gljv1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .IsClustered(false);

                entity.HasIndex(e => e.RefNo, "INDEX_gljv1_RefNo")
                    .IsClustered();

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PostFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.ReconcilFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Gljv2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Glml1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_glmt1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CurrCodeNavigation)
                    .WithMany(p => p.Glml1s)
                    .HasForeignKey(d => d.CurrCode)
                    .HasConstraintName("FK_glml1_glex1");
            });

            modelBuilder.Entity<Gloc1>(entity =>
            {
                entity.HasKey(e => e.ChargeCode)
                    .IsClustered(false);

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Glpa1>(entity =>
            {
                entity.HasKey(e => e.UniqueKey)
                    .IsClustered(false);

                entity.Property(e => e.AccountDigit).HasComment("Maximal digit of Account Code");

                entity.Property(e => e.AutoPostFlag).HasComment("If set as 'Y', it will call the post store prcedure auotmatically as long as the record exit the form if the record is not posted and not deleted");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrentPeriodIv).HasComment("Control the current period of the Invoice in Accounts");

                entity.Property(e => e.CurrentPeriodJm).HasComment("Control the current period of the Job Management");

                entity.Property(e => e.CurrentPeriodOp).HasComment("Control the current period of the Operation include Invoice and Payment");

                entity.Property(e => e.CurrentPeriodPl).HasComment("Control the current period of the Purchase Ledger");

                entity.Property(e => e.CurrentPeriodSl).HasComment("Control the current period of the Sales Ledger");

                entity.Property(e => e.DateValidate).HasComment("NOT IN USE");

                entity.Property(e => e.DivisionDigit).HasComment("NOT IN USE");

                entity.Property(e => e.ExGainLossAccCode).HasComment("Define the Ex Gain Loss Acc Code");

                entity.Property(e => e.FinancialPeriod).HasComment("No of Financial Period in Financial Year");

                entity.Property(e => e.FinancialYear).HasComment("Default Financial Year to Financial Year in Yearly Posting");

                entity.Property(e => e.FirstCostAccCode).HasComment("Use in the older Balance Sheet or P&L report");

                entity.Property(e => e.FirstSalesAccCode).HasComment("Use in the older Balance Sheet or P&L report");

                entity.Property(e => e.HidePostButtonFlag).HasComment("If set as Y, will hide the Post button for all user, if set as S, will hide the Post button for access right is U, if set as A, will hide the Post button for access right is U and S");

                entity.Property(e => e.JournalPrefix).HasComment("the Ref No. Prefix for Journal Voucher");

                entity.Property(e => e.LocalCurrCode).HasComment("NOT IN USE");

                entity.Property(e => e.MarkupRate).HasComment("If it has value, it will compute the CurrRate from CostCurrRate when Curr Rate is empty (or 0) in glex1 and glex1_1.");

                entity.Property(e => e.NextRefNo).HasComment("NOT IN USE");

                entity.Property(e => e.NoOfYrHistory).HasComment("NOT IN USE");

                entity.Property(e => e.PostOnlineOrBatch).HasComment("O - When Posting will overwrite the exist record in General Ledger, B - when Posting will insert a new record to General Ledger");

                entity.Property(e => e.RetainEarnAccCode).HasComment("Default the Accounts for the Retain Earning during the Yearly Posting");

                entity.Property(e => e.ReversePostOnlineOrBatch).HasComment("O - When Reverse Post will overwrite the exist record in General Ledger, B - When Reverse Posting will insert a new record to General Ledger");

                entity.Property(e => e.SalesAccCode).HasComment("NOT IN USE");

                entity.Property(e => e.SiteDigit).HasComment("NOT IN USE");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Xecurr).HasComment("When parameter is not null or blank, the system should show the button on Glex1 and gleh1 screen.  Use this parameter to post and get the curr rate.");

                entity.Property(e => e.YahooCurr).HasComment("When parameter is not null or blank, the system should show the button on Glex1 and gleh1 screen.  Use this parameter to post and get the curr rate.");

                entity.HasOne(d => d.LocalCurrCodeNavigation)
                    .WithMany(p => p.Glpa1s)
                    .HasForeignKey(d => d.LocalCurrCode)
                    .HasConstraintName("FK_glpa1_glex1");
            });

            modelBuilder.Entity<Glpa2>(entity =>
            {
                entity.Property(e => e.FinancialYear).ValueGeneratedNever();

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");
            });

            modelBuilder.Entity<Glpp1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Glyl1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReconcilFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Glyl2>(entity =>
            {
                entity.Property(e => e.Amt).HasDefaultValueSql("((0))");

                entity.Property(e => e.AuditBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.AuditDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LocalAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<GridSet>(entity =>
            {
                entity.Property(e => e.BFieldVisibleByUser).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<ImGoodsIssue>(entity =>
            {
                entity.ToView("im_Goods_Issue");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ImGoodsRcvBarCode>(entity =>
            {
                entity.ToView("im_GoodsRcvBarCode");

                entity.Property(e => e.LineNo).IsFixedLength();
            });

            modelBuilder.Entity<ImGoodsRcvIssue>(entity =>
            {
                entity.ToView("im_Goods_Rcv_Issue");
            });

            modelBuilder.Entity<ImGoodsReceive>(entity =>
            {
                entity.ToView("im_Goods_Receive");
            });

            modelBuilder.Entity<ImGrnByPackingNo>(entity =>
            {
                entity.ToView("im_GRN_By_PackingNo");

                entity.Property(e => e.ReceiptDate).IsFixedLength();
            });

            modelBuilder.Entity<ImPurchaseOrder>(entity =>
            {
                entity.ToView("im_PurchaseOrder");

                entity.Property(e => e.Eta).IsFixedLength();

                entity.Property(e => e.OrderDate).IsFixedLength();
            });

            modelBuilder.Entity<Imcc1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remark).HasDefaultValueSql("(host_name())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Imcc2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Imga1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_Imga1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Imga2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo })
                    .HasName("PK_Imga2");
            });

            modelBuilder.Entity<Imgd1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Imgd2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Imgi1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Imgi2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Imgi3>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Imgi4>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Imgi5>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.Property(e => e.LineItemNo).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Imgi6>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Imgr1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Imgr2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Imgr2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_imgr2_imgr1");
            });

            modelBuilder.Entity<Imgr3>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Imia1>(entity =>
            {
                entity.Property(e => e.BatchNo).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreateBy)
                    .HasDefaultValueSql("(suser_sname())")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PostFlag).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ProductCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefNo).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StatusCode)
                    .HasDefaultValueSql("('USE')")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreLocation).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreNo).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TrxType).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy)
                    .HasDefaultValueSql("(suser_sname())")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WarehouseCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.WorkStation)
                    .HasDefaultValueSql("(host_name())")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<Imip1>(entity =>
            {
                entity.Property(e => e.CreateBy)
                    .HasDefaultValueSql("(suser_sname())")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InProductCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.InWarehouseCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.OutProductCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.OutWarehouseCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ReferenceNo).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StatusCode)
                    .HasDefaultValueSql("('USE')")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy)
                    .HasDefaultValueSql("(suser_sname())")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Imit1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Imit2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Imlt1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Imlt2>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LineItemNo });

                entity.HasOne(d => d.LotNoNavigation)
                    .WithMany(p => p.Imlt2s)
                    .HasForeignKey(d => d.LotNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_imlt2_imlt1");
            });

            modelBuilder.Entity<Imms1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_imms1_1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Statuscode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Impa1>(entity =>
            {
                entity.Property(e => e.BankAccCode).HasComment("NOT IN USE");

                entity.Property(e => e.BarCodeField).HasComment("Define the field the barcode should read from.");

                entity.Property(e => e.CheckValidPoFlag).HasComment("If set as Y, during \"ASN Excel Upload\", check that PO No is valid from Impo1.PurchaseOrderNo");

                entity.Property(e => e.CompleteFlag).HasComment("Enable/Disable the Completion features");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DefaultAccCode).HasComment("Default Account Code to Account Code in Product Master");

                entity.Property(e => e.DefaultCustomerCode).HasComment("Default Customer Code to Goods Receipt Note / Goods Issue Note");

                entity.Property(e => e.DefaultStoreNo).HasComment("Default Store No to Boods Info in Goods Receipt Note");

                entity.Property(e => e.DefaultWarehouseCode).HasComment("Default Warehouse Code to Goods Receipt Note");

                entity.Property(e => e.FirstDayOfWeek).HasComment("NOT IN USE");

                entity.Property(e => e.HandlingChargeItem).HasComment("NOT IN USE");

                entity.Property(e => e.LockDimensionFlag).HasComment("If set to Y, user cannot change the “DimensionFlag” in the Goods Receipt Note, it will pull the DimensionFlag from the Product Master (Impr1)");

                entity.Property(e => e.NextGoodsIssueNo).HasComment("Next Goods Issue No");

                entity.Property(e => e.NextGoodsReceiptNo).HasComment("Next Goods Receipt No");

                entity.Property(e => e.NextGoodsTransferNo).HasComment("Next Goods Transfer No");

                entity.Property(e => e.NextPurchaseOrderNo).HasComment("NOT IN USE");

                entity.Property(e => e.NextSalesOrderNo).HasComment("NOT IN USE");

                entity.Property(e => e.PromptBalFlag).HasComment("NOT IN USE");

                entity.Property(e => e.SetVolDecPlace).HasComment("Define the decimal places for the computed volume in impr1,impr2 and imgr2");

                entity.Property(e => e.ShowCustInProductFlag).HasComment("NOT IN USE");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.StorageChargeItem).HasComment("Define Warehouse Charge Code for identifying the Warehouse Charge Code in Billing Template during DailyBilling");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Impc1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Impm1>(entity =>
            {
                entity.Property(e => e.BalanceLooseQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceWholeQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(upper(host_name()))");
            });

            modelBuilder.Entity<Impm2>(entity =>
            {
                entity.Property(e => e.AuditBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.AuditDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BalanceLooseQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceWholeQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(upper(host_name()))");
            });

            modelBuilder.Entity<Impn1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Impo1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_Impo1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Impo2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo })
                    .HasName("PK_Impo2");
            });

            modelBuilder.Entity<Impo3>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo })
                    .HasName("PK_Impo3");
            });

            modelBuilder.Entity<Impo4>(entity =>
            {
                entity.Property(e => e.TrxNo).ValueGeneratedNever();
            });

            modelBuilder.Entity<Impr1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Impr2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo })
                    .HasName("PK_Impr2");
            });

            modelBuilder.Entity<Impr3>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo })
                    .HasName("PK_Impr3");
            });

            modelBuilder.Entity<Impv1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Impv2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Imsd1>(entity =>
            {
                entity.Property(e => e.SotrxNo).ValueGeneratedNever();
            });

            modelBuilder.Entity<Imsl1>(entity =>
            {
                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Imso1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_Imso1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Imso2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo })
                    .HasName("PK_Imso2");

                entity.Property(e => e.LocalAmt).IsFixedLength();
            });

            modelBuilder.Entity<Imso3>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo })
                    .HasName("PK_Imso3");
            });

            modelBuilder.Entity<Inms1>(entity =>
            {
                entity.Property(e => e.TrxNo).ValueGeneratedNever();

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<IvAccInvoice1>(entity =>
            {
                entity.ToView("iv_Acc_Invoice_1");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<IvAccInvoice2>(entity =>
            {
                entity.ToView("iv_Acc_Invoice_2");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<IvAccInvoiceRecoverAcc>(entity =>
            {
                entity.ToView("iv_Acc_Invoice_Recover_Acc");
            });

            modelBuilder.Entity<IvAccInvoiceRecoverAccByRefNo>(entity =>
            {
                entity.ToView("iv_Acc_Invoice_Recover_Acc_By_RefNo");
            });

            modelBuilder.Entity<IvAccInvoiceSummary>(entity =>
            {
                entity.ToView("iv_Acc_Invoice_Summary");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<IvAccSalesByJob>(entity =>
            {
                entity.ToView("iv_Acc_Sales_By_Job");
            });

            modelBuilder.Entity<IvAllCreditInvoiceByJob>(entity =>
            {
                entity.ToView("iv_All_Credit_Invoice_By_Job");
            });

            modelBuilder.Entity<IvAllCreditInvoiceByMasterJob>(entity =>
            {
                entity.ToView("iv_All_Credit_Invoice_By_Master_Job");
            });

            modelBuilder.Entity<IvAllCreditInvoiceWithVatByJob>(entity =>
            {
                entity.ToView("iv_All_Credit_Invoice_With_Vat_By_Job");
            });

            modelBuilder.Entity<IvAllCreditInvoiceWithVatByMasterJob>(entity =>
            {
                entity.ToView("iv_All_Credit_Invoice_With_Vat_By_Master_Job");
            });

            modelBuilder.Entity<IvAllCreditNoteByJob>(entity =>
            {
                entity.ToView("iv_All_Credit_Note_By_Job");
            });

            modelBuilder.Entity<IvAllCreditNoteByMasterJob>(entity =>
            {
                entity.ToView("iv_All_Credit_Note_By_Master_Job");
            });

            modelBuilder.Entity<IvAllCreditNoteWithVatByJob>(entity =>
            {
                entity.ToView("iv_All_Credit_Note_With_Vat_By_Job");
            });

            modelBuilder.Entity<IvAllCreditNoteWithVatByMasterJob>(entity =>
            {
                entity.ToView("iv_All_Credit_Note_With_Vat_By_Master_Job");
            });

            modelBuilder.Entity<IvAllDebitNoteByJob>(entity =>
            {
                entity.ToView("iv_All_Debit_Note_By_Job");
            });

            modelBuilder.Entity<IvAllDebitNoteByMasterJob>(entity =>
            {
                entity.ToView("iv_All_Debit_Note_By_Master_Job");
            });

            modelBuilder.Entity<IvAllDebitNoteWithVatByJob>(entity =>
            {
                entity.ToView("iv_All_Debit_Note_With_Vat_By_Job");
            });

            modelBuilder.Entity<IvAllDebitNoteWithVatByMasterJob>(entity =>
            {
                entity.ToView("iv_All_Debit_Note_With_Vat_By_Master_Job");
            });

            modelBuilder.Entity<IvAllInternalBillingByJob>(entity =>
            {
                entity.ToView("iv_All_Internal_Billing_By_Job");
            });

            modelBuilder.Entity<IvAllInternalBillingByMasterJob>(entity =>
            {
                entity.ToView("iv_All_Internal_Billing_By_Master_Job");
            });

            modelBuilder.Entity<IvAllInvoice1>(entity =>
            {
                entity.ToView("iv_All_Invoice_1");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<IvAllInvoice2>(entity =>
            {
                entity.ToView("iv_All_Invoice_2");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<IvAllInvoice2ImportJob>(entity =>
            {
                entity.ToView("iv_All_Invoice_2_Import_Job");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<IvAllInvoice2NoVatByJob>(entity =>
            {
                entity.ToView("iv_All_Invoice_2_No_Vat_By_Job");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<IvAllInvoiceByJob>(entity =>
            {
                entity.ToView("iv_All_invoice_By_Job");
            });

            modelBuilder.Entity<IvAllInvoiceJob>(entity =>
            {
                entity.ToView("Iv_All_Invoice_Job");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<IvAllInvoiceJobInvoiceNo>(entity =>
            {
                entity.ToView("iv_All_Invoice_Job_Invoice_No");
            });

            modelBuilder.Entity<IvAllInvoiceSummary>(entity =>
            {
                entity.ToView("iv_All_Invoice_Summary");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<IvAllInvoiceTransfer>(entity =>
            {
                entity.ToView("iv_All_Invoice_Transfer");

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<IvAllInvoiceVat>(entity =>
            {
                entity.ToView("iv_All_Invoice_Vat");
            });

            modelBuilder.Entity<IvAllInvoiceVatByInvoice>(entity =>
            {
                entity.ToView("iv_All_Invoice_Vat_By_Invoice");
            });

            modelBuilder.Entity<IvAllInvoiceWithVatByJob>(entity =>
            {
                entity.ToView("iv_All_Invoice_With_Vat_By_Job");
            });

            modelBuilder.Entity<IvAllInvoiceWithVatByMasterJob>(entity =>
            {
                entity.ToView("iv_All_Invoice_With_Vat_By_Master_Job");
            });

            modelBuilder.Entity<IvAllInvoiceWithoutCnByJob>(entity =>
            {
                entity.ToView("iv_All_Invoice_Without_Cn_By_Job");
            });

            modelBuilder.Entity<IvAllSales2>(entity =>
            {
                entity.ToView("iv_All_Sales_2");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<IvAllSalesByJob>(entity =>
            {
                entity.ToView("iv_All_Sales_By_Job");
            });

            modelBuilder.Entity<IvAllSalesByJobDate>(entity =>
            {
                entity.ToView("iv_All_Sales_By_Job_Date");
            });

            modelBuilder.Entity<IvAllSalesByJobWithVatOutlay>(entity =>
            {
                entity.ToView("iv_All_Sales_By_Job_With_Vat_Outlay");
            });

            modelBuilder.Entity<IvAllSalesByMasterJob>(entity =>
            {
                entity.ToView("iv_All_Sales_By_Master_Job");
            });

            modelBuilder.Entity<IvAllSalesDistribution>(entity =>
            {
                entity.ToView("iv_All_Sales_Distribution");
            });

            modelBuilder.Entity<IvAllSalesWithVatByJob>(entity =>
            {
                entity.ToView("iv_All_Sales_With_Vat_By_Job");
            });

            modelBuilder.Entity<IvAllSalesWithoutCnByJob>(entity =>
            {
                entity.ToView("iv_All_Sales_Without_Cn_By_Job");
            });

            modelBuilder.Entity<IvAllTsFreightCollectByMasterJob>(entity =>
            {
                entity.ToView("iv_All_Ts_Freight_Collect_By_Master_Job");
            });

            modelBuilder.Entity<IvInvoiceByAeHouse>(entity =>
            {
                entity.ToView("iv_Invoice_By_Ae_House");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();
            });

            modelBuilder.Entity<Ivch1>(entity =>
            {
                entity.Property(e => e.CollectBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FaxCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WithHoldingTaxAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Ivch2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");

                entity.HasOne(d => d.CurrCodeNavigation)
                    .WithMany(p => p.Ivch2s)
                    .HasForeignKey(d => d.CurrCode)
                    .HasConstraintName("FK_ivch2_glex1");

                entity.HasOne(d => d.ItemCodeNavigation)
                    .WithMany(p => p.Ivch2s)
                    .HasForeignKey(d => d.ItemCode)
                    .HasConstraintName("FK_ivch2_acit1");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Ivch2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ivch2_ivch1");

                entity.HasOne(d => d.UomCodeNavigation)
                    .WithMany(p => p.Ivch2s)
                    .HasForeignKey(d => d.UomCode)
                    .HasConstraintName("FK_ivch2_rcum1");

                entity.HasOne(d => d.VatCodeNavigation)
                    .WithMany(p => p.Ivch2s)
                    .HasForeignKey(d => d.VatCode)
                    .HasConstraintName("FK_ivch2_acva1");
            });

            modelBuilder.Entity<Ivci1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_Ivci1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Ivcr1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .IsClustered(false);

                entity.HasIndex(e => e.RefNo, "INDEX_ivcr1_RefNo")
                    .IsClustered();

                entity.Property(e => e.ConsoleFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FaxCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PostFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReconcilFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.TotalLocalVatAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransferFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WithHoldingTaxAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Ivcr2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.Property(e => e.BillTypeFlag).HasDefaultValueSql("('U')");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemTrxNo).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");

                entity.HasOne(d => d.AccCodeNavigation)
                    .WithMany(p => p.Ivcr2s)
                    .HasForeignKey(d => d.AccCode)
                    .HasConstraintName("FK_ivcr2_glch11");

                entity.HasOne(d => d.CurrCodeNavigation)
                    .WithMany(p => p.Ivcr2s)
                    .HasForeignKey(d => d.CurrCode)
                    .HasConstraintName("FK_ivcr2_glex1");

                entity.HasOne(d => d.ItemCodeNavigation)
                    .WithMany(p => p.Ivcr2s)
                    .HasForeignKey(d => d.ItemCode)
                    .HasConstraintName("FK_ivcr2_acit1");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Ivcr2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ivcr2_ivcr1");

                entity.HasOne(d => d.UomCodeNavigation)
                    .WithMany(p => p.Ivcr2s)
                    .HasForeignKey(d => d.UomCode)
                    .HasConstraintName("FK_ivcr2_rcum1");

                entity.HasOne(d => d.VatCodeNavigation)
                    .WithMany(p => p.Ivcr2s)
                    .HasForeignKey(d => d.VatCode)
                    .HasConstraintName("FK_ivcr2_acva11");
            });

            modelBuilder.Entity<Ivpa1>(entity =>
            {
                entity.Property(e => e.AirExportInvoiceType).HasComment("Default Invoice Type for Air Export Invoice Type when Job Type is AE\r\n1-Invoice Type01, 2-Invoice Type 02………0-Invoice Type 10");

                entity.Property(e => e.AirExportPrefix).HasComment("To print on Air Export Invoice");

                entity.Property(e => e.AirImportInvoiceType).HasComment("Default Invoice Type for Air Import Invoice Type when Job Type is AI\r\n1-Invoice Type01, 2-Invoice Type 02………0-Invoice Type 10");

                entity.Property(e => e.AirImportPrefix).HasComment("To print on Air Import Invoice");

                entity.Property(e => e.AutoPostFlag).HasComment("Set as Y, if the record is not posted and not deleted, it will auto post as long as the record exit the form.");

                entity.Property(e => e.BlockInvTemplateFlag).HasComment("NOT IN USE");

                entity.Property(e => e.CashNoteFlag).HasComment("If set as F, Cash Note running No is created by Next Cash Invoice No 1\r\nIf set as T, Cash Note running No is created by Next Invoice No base on Invoice Type");

                entity.Property(e => e.CashReceiptFlag).HasComment("If set as F, Cash Receipt running No is created by Next Cash Receipt No 1\r\nIf set as T, Cash Receipt running No is created by Next Invoice No base on Invoice Type");

                entity.Property(e => e.CashTermCode).HasComment("Define the Term Code in ivcr1 which TrxType=4. If it has value, enter any customer in ivcr1 which TrxType=4, the Term Code will not pull from slcu1 but ivpa1.CashTermCode");

                entity.Property(e => e.CfsReceiptFlag).HasComment("If set as 'Y' then\r\n   a). hide the Address3, Address 4, Postal Code and the button 'Other Billing Address' . Display a textbox to show the below:\r\n         if the ModuleCode of ivcr1.JobNo ='SE' \r\n         POD: sebl1.PortOfDischargeName\r\n         Stuffing Date: sebl1.StuffDate(show datetime)\r\n         Cargo Status: sebl2.CargoStatusCode(top1)\r\n         if the ModuleCode of ivcr1.JobNo='SI'\r\n         POL: sebl1.PortOfLoadingName\r\n         Unstuffing Date: sibl1.UnstuffDate(show datetime)\r\n         Cargo Status: sibl2.CargoStatusCode(top1)");

                entity.Property(e => e.ChangeTypeNewNoFlag).HasComment("If set as ‘Y’, then when change TrxType (enter the TrxType on the Change TrxType screen then click ‘OK’), it should prompt the message ‘Do you want to generate new Invoice No for this shipment?’, if yes, it will delete the current ivcr1 and copy a new record and generate a new Invoice No");

                entity.Property(e => e.ConvertInvToRcpFlag).HasComment("Set as Y when click on the receipt button will prompt user to convert the invoice to cash receipt");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditCheckErrorFlag).HasComment("Verify the customer credit limit in Ivcr1 form. Enter Customer code in Acct ivcr1 form and Billing Party Code in operation ivcr1.if set ivpa1. CreditCheckErrorFlag as Y/A/S/U/N and slcu1.CustomerOnHoldFlag=’Y’,it will prompt the same message as the operation form,it will not allow user to continue.\r\n");

                entity.Property(e => e.CreditNoteFlag).HasComment("If set as F, Credit Note running No is created by Next Credit Note No 1\r\nIf set as T, Credit Note running No is created by Next Invoice No base on Invoice Type");

                entity.Property(e => e.CurrRateFlag).HasComment("NOT IN USE");

                entity.Property(e => e.DebitNoteFlag).HasComment("If set as F, Debit Note running No is created by Next Debit Note No 1\r\nIf set as T, Debit Note running No is created by Next Invoice No base on Invoice Type");

                entity.Property(e => e.DefaultInvoiceDateFlag).HasComment("Default Invoice Date by C - Current Date  or J - Job Date");

                entity.Property(e => e.DefaultInvoiceType).HasComment("Default Invoice Type (08,09 & 10) when enter a new Invoice");

                entity.Property(e => e.DefaultName).HasComment("Default the Name of the Invoice Type.");

                entity.Property(e => e.DeleteInvRight).HasComment("Access Right to Delete the Invoice");

                entity.Property(e => e.Description).HasComment("NOT IN USE");

                entity.Property(e => e.DoNoFlag).HasComment("If set as 'Y', when create Cash Receipt (TrxType=’5’ and ModuleCode=SI), the system should prompt a screen to allow user enter the DeliveryOrderNo to pull the JobNo. It should also check the “Remark” in the Sibl1, if the remark is entered. It should prompt a message box and display the “Remark”.");

                entity.Property(e => e.DocumentFooter1).HasComment("Print to Footer 1 of the Invoice related documents");

                entity.Property(e => e.DocumentFooter2).HasComment("Print to Footer 2 of the Invoice related documents");

                entity.Property(e => e.EmptyInvoiceNoFlag).HasComment("If set as ‘N’, then if the ivcr2 is blank, should not generate InvoiceNo. If set as ‘Y’ or blank use old logic");

                entity.Property(e => e.FixCashTrxType).HasComment("For sea import it fix the Cash Invoice");

                entity.Property(e => e.GoodsDescriptionFlag).HasComment("If set as 'Y', it should pull the CommodityDescription from jmjm1 to ivcr1.GoodsDesecription1");

                entity.Property(e => e.GroupFlag).HasComment("NOT IN USE");

                entity.Property(e => e.GroupInvoiceType01).HasComment("Set Group Invoice Type for Group Invoice node");

                entity.Property(e => e.GroupInvoiceType02).HasComment("Set Group Invoice Type for Group Invoice form");

                entity.Property(e => e.GroupInvoiceType03).HasComment("Set Group Invoice Type for Group Invoice form");

                entity.Property(e => e.GroupInvoiceType04).HasComment("Set Group Invoice Type for Group Invoice form");

                entity.Property(e => e.GroupInvoiceType05).HasComment("Set Group Invoice Type for Group Invoice form");

                entity.Property(e => e.GroupInvoiceType06).HasComment("Set Group Invoice Type for Group Invoice form");

                entity.Property(e => e.GroupInvoiceType07).HasComment("Set Group Invoice Type for Group Invoice form");

                entity.Property(e => e.GroupInvoiceType08).HasComment("Set Group Invoice Type for Group Invoice form");

                entity.Property(e => e.GroupInvoiceType09).HasComment("Set Group Invoice Type for Group Invoice form");

                entity.Property(e => e.GroupInvoiceType10).HasComment("Set Group Invoice Type for Group Invoice form");

                entity.Property(e => e.GroupInvoiceType11).HasComment("Set Group Invoice Type for Group Invoice form");

                entity.Property(e => e.GroupInvoiceType12).HasComment("Set Group Invoice Type for Group Invoice form");

                entity.Property(e => e.GroupInvoiceType13).HasComment("Set Group Invoice Type for Group Invoice form");

                entity.Property(e => e.GroupInvoiceType14).HasComment("Set Group Invoice Type for Group Invoice form");

                entity.Property(e => e.GroupInvoiceType15).HasComment("Set Group Invoice Type for Group Invoice form");

                entity.Property(e => e.HideChgTrxFlag).HasComment("When set as Y, the system will hide 'Chg Trx' button in ivcr1 form");

                entity.Property(e => e.HideOperationUnpostFlag).HasComment("Hide the Unpost button in ivcr1 in operation.\r\n- if set as 'A', then hide the Unpost button for all user\r\n- if set as 'S', then hide the Unpost button for access right ='S' and 'U'\r\n- if set as 'U', then hide the Unpost button for access right='U'");

                entity.Property(e => e.HideSalesCostFlag).HasComment("If set as 'Y', it will hide the sales/cost column in ivcr1 and the total as below abd auto move the invoice total to right");

                entity.Property(e => e.InvSeqNoByJobFlag).HasComment("Set as Y, the ivcr1 invoice no should generate base on top 1 sanm1 setting which numbertype=IVCR and TrxType=1. If create more than invoice for the same job, the second invoice no should be first invoiceno+A");

                entity.Property(e => e.InvoiceFlag).HasComment("If set as F, Invoice running No is created by Next Invoice No 1\r\nIf set as T, Invoice running No is created by Next Invoice No base on Invoice Type");

                entity.Property(e => e.InvoiceFormat).HasComment("Invoice No Format:[PF:Invoice Prefix],[SFX:Suffix],[S:Shipment Type],[MM:01-12],[M:1-9/A-C],[YY:01-99],[Y:0-9]");

                entity.Property(e => e.InvoiceFormatType).HasComment("NOT IN USE");

                entity.Property(e => e.InvoiceNoAutoOrManual)
                    .HasDefaultValueSql("('A')")
                    .HasComment("NOT IN USE");

                entity.Property(e => e.InvoiceType01).HasComment("Default Next Invoice  / Credit Note / Debit Note / Cash Note / Cash Receipt No(base on Trx Type) for Invoice Type 01");

                entity.Property(e => e.InvoiceType02).HasComment("Default Next Invoice  / Credit Note / Debit Note / Cash Note / Cash Receipt No(base on Trx Type) for Invoice Type 02");

                entity.Property(e => e.InvoiceType03).HasComment("Default Next Invoice  / Credit Note / Debit Note / Cash Note / Cash Receipt No(base on Trx Type) for Invoice Type 03");

                entity.Property(e => e.InvoiceType04).HasComment("Default Next Invoice  / Credit Note / Debit Note / Cash Note / Cash Receipt No(base on Trx Type) for Invoice Type 04");

                entity.Property(e => e.InvoiceType05).HasComment("Default Next Invoice  / Credit Note / Debit Note / Cash Note / Cash Receipt No(base on Trx Type) for Invoice Type 05");

                entity.Property(e => e.InvoiceType06).HasComment("Default Next Invoice  / Credit Note / Debit Note / Cash Note / Cash Receipt No(base on Trx Type) for Invoice Type 06");

                entity.Property(e => e.InvoiceType07).HasComment("Default Next Invoice  / Credit Note / Debit Note / Cash Note / Cash Receipt No(base on Trx Type) for Invoice Type 07");

                entity.Property(e => e.InvoiceType08).HasComment("Default Next Invoice  / Credit Note / Debit Note / Cash Note / Cash Receipt No(base on Trx Type) for Invoice Type 08");

                entity.Property(e => e.InvoiceType09).HasComment("Default Next Invoice  / Credit Note / Debit Note / Cash Note / Cash Receipt No(base on Trx Type) for Invoice Type 09");

                entity.Property(e => e.InvoiceType10).HasComment("Default Next Invoice  / Credit Note / Debit Note / Cash Note / Cash Receipt No(base on Trx Type) for Invoice Type 10");

                entity.Property(e => e.IvTypeCurrControlFlag).HasComment("Indicate the Invoice Type to control the currency");

                entity.Property(e => e.KeepOpInvoiceFlag).HasComment("Set Y to keep the operation invoice after Sales Transfer. N to delete the Invoice after Sales Transfer");

                entity.Property(e => e.KeepWhInvoiceFlag).HasComment("");

                entity.Property(e => e.LockAddressFlag).HasComment("Set as Y, lock the Address1-4 in the invoice entry.");

                entity.Property(e => e.LockCloseJobFlag).HasComment("If set as 'Y', then totally lock the ivcr1 record in operation where job is closed. In account, it should not lock but still show the message the ‘This job is already closed.” closed NOT Closed. the back color change to yellow");

                entity.Property(e => e.LockCurrFlag).HasComment("Lock Currency in the invoice entry");

                entity.Property(e => e.LockCurrRateFlag).HasComment("Lock Currency Rate after invoice has invoice no.");

                entity.Property(e => e.LockCustomerFlag).HasComment("Lock Customer after invoice has invoice no.");

                entity.Property(e => e.LockCustomerNameFlag).HasComment("Lock Customer Name in the invoice entry");

                entity.Property(e => e.LockDescriptionFlag).HasComment("Lock Item Description in the invoice entry");

                entity.Property(e => e.LockInvoiceDateFlag).HasComment("Lock Invoice Date after invoice has invoice no and print count>0.\r\nSet U for lock AccessRight='U'\r\nSet S for lock AccessRight='U' and 'S'. \r\nSet A for lock for user");

                entity.Property(e => e.LockInvoiceDay).HasComment("Define the days will lock the invoice in operation. Invoice Date < Current Date - Lock Invoice Day will be locked.");

                entity.Property(e => e.LockInvoiceFlag).HasComment("Lock Invoice after invoice has invoice no.");

                entity.Property(e => e.LockItemScreenFlag).HasComment("Set as Y, it will lock ivcr2 grid under operation");

                entity.Property(e => e.LockJobNoFlag).HasComment("Lock Job No. after invoice has invoice no.");

                entity.Property(e => e.LockPostDateFlag).HasComment("Lock Post Date after invoice has invoice no.");

                entity.Property(e => e.LockPrintInvoiceFlag).HasComment("Lock ivcr1 form when invoice no have value and PrintCount>0. Set as A - lock for all user. S - lock for user which access right = S/U. U - only lock user which access right = U. Y - only lock user which access right = U");

                entity.Property(e => e.LockTermFlag).HasComment("Lock Term in the invoice entry");

                entity.Property(e => e.MinUomCode).HasComment("Define the UomCode in vicr2 when click Charge or Quotation in ivcr1 to pull charges, if the system pull the MinAmt.");

                entity.Property(e => e.MiscellaneousInvoiceType).HasComment("Default Invoice Type for Miscellaneous Invoice Type when Job Type is MS\r\n1-Invoice Type01, 2-Invoice Type 02………0-Invoice Type 10");

                entity.Property(e => e.MiscellaneousPrefix).HasComment("To print on Mis Job Invoice");

                entity.Property(e => e.NegativeInvoiceFlag).HasComment("Allow if the invoice to have negative amount");

                entity.Property(e => e.NextBatchNo).HasComment("When generate the EDI for AR, it will use the NextBatchNo and then update NextBatchNo+1");

                entity.Property(e => e.NextCashInvoiceNo01).HasComment("Default Next Cash invoice no");

                entity.Property(e => e.NextCashInvoiceNo02).HasComment("Default Next Cash Invoice no for Air Import Prefix");

                entity.Property(e => e.NextCashInvoiceNo03).HasComment("Default Next Cash invoice no for Sea Export Prefix");

                entity.Property(e => e.NextCashInvoiceNo04).HasComment("Default Next Cash Invoice no for Sea Import Prefix");

                entity.Property(e => e.NextCashInvoiceNo05).HasComment("Default Next Cash Invoice no for warehouse Prefix");

                entity.Property(e => e.NextCashInvoiceNo06).HasComment("Default Next Cash Invoice no for Transport Prefix");

                entity.Property(e => e.NextCashInvoiceNo07).HasComment("Default Next Cash Invoice no for Miscellaneous Prefix");

                entity.Property(e => e.NextCashInvoiceNo08).HasComment("Default Next Cash Invoice no for Other Invoice Prefix01");

                entity.Property(e => e.NextCashInvoiceNo09).HasComment("Default Next Cash Invoice no for Other Invoice Prefix01");

                entity.Property(e => e.NextCashInvoiceNo10).HasComment("Default Next Cash Invoice no for Other Invoice Prefix01");

                entity.Property(e => e.NextCashReceiptNo01).HasComment("Default Next Cash Receipt no for Air Export Prefix");

                entity.Property(e => e.NextCashReceiptNo02).HasComment("Default Next Cash Invoice no for Air Import Prefix");

                entity.Property(e => e.NextCashReceiptNo03).HasComment("Default Next Cash invoice no for Sea Export Prefix");

                entity.Property(e => e.NextCashReceiptNo04).HasComment("Default Next Cash Invoice no for Sea Import Prefix");

                entity.Property(e => e.NextCashReceiptNo05).HasComment("Default Next Cash Invoice no for warehouse Prefix");

                entity.Property(e => e.NextCashReceiptNo06).HasComment("Default Next Cash Invoice no for Transport Prefix");

                entity.Property(e => e.NextCashReceiptNo07).HasComment("Default Next Cash Invoice no for Other Invoice Prefix01");

                entity.Property(e => e.NextCashReceiptNo08).HasComment("Default Next Cash Invoice no for Other Invoice Prefix02");

                entity.Property(e => e.NextCashReceiptNo09).HasComment("Default Next Cash Invoice no for Other Invoice Prefix03");

                entity.Property(e => e.NextCashReceiptNo10).HasComment("Default Next Cash Receipt no for Other Invoice Prefix03");

                entity.Property(e => e.NextCreditNoteNo01).HasComment("Default Next Cash Receipt no for Air Export Prefix");

                entity.Property(e => e.NextCreditNoteNo02).HasComment("Default Next Cash Receipt no for Air Import Prefix");

                entity.Property(e => e.NextCreditNoteNo03).HasComment("Default Next Cash Receipt no for Sea Export Prefix");

                entity.Property(e => e.NextCreditNoteNo04).HasComment("Default Next Cash Receipt no for Sea Import Prefix");

                entity.Property(e => e.NextCreditNoteNo05).HasComment("Default Next Cash Receipt no for warehouse Prefix");

                entity.Property(e => e.NextCreditNoteNo06).HasComment("Default Next Cash Receipt no for Transport Prefix");

                entity.Property(e => e.NextCreditNoteNo07).HasComment("Default Next Cash Receipt  no for Miscellaneous Prefix");

                entity.Property(e => e.NextCreditNoteNo08).HasComment("Default Next Cash Receipt no for Other Invoice Prefix01");

                entity.Property(e => e.NextCreditNoteNo09).HasComment("Default Next Cash Receipt no for Other Invoice Prefix02");

                entity.Property(e => e.NextCreditNoteNo10).HasComment("Default Next Cash Receipt no for Other Invoice Prefix03");

                entity.Property(e => e.NextDebitNoteNo01).HasComment("Default Next Credit Note no for Air Export Prefix");

                entity.Property(e => e.NextDebitNoteNo02).HasComment("Default Next Credit Note no for Air Import Prefix");

                entity.Property(e => e.NextDebitNoteNo03).HasComment("Default Next Credit Note no for Sea Export Prefix");

                entity.Property(e => e.NextDebitNoteNo04).HasComment("Default Next Credit Note no for Sea Import Prefix");

                entity.Property(e => e.NextDebitNoteNo05).HasComment("Default Next Credit Note no for warehouse Prefix");

                entity.Property(e => e.NextDebitNoteNo06).HasComment("Default Next Credit Note no for Transport Prefix");

                entity.Property(e => e.NextDebitNoteNo07).HasComment("Default Next Credit Note  no for Miscellaneous Prefix");

                entity.Property(e => e.NextDebitNoteNo08).HasComment("Default Next Credit Note no for Other Invoice Prefix01");

                entity.Property(e => e.NextDebitNoteNo09).HasComment("Default Next Credit Note no for Other Invoice Prefix02");

                entity.Property(e => e.NextDebitNoteNo10).HasComment("Default Next Credit Note no for Other Invoice Prefix03");

                entity.Property(e => e.NextInvoiceNo01).HasComment("Default Next Debit Note no for Air Export Prefix");

                entity.Property(e => e.NextInvoiceNo02).HasComment("Default Next Debit Note no for Air Import Prefix");

                entity.Property(e => e.NextInvoiceNo03).HasComment("Default Next Debit Note no for Sea Export Prefix");

                entity.Property(e => e.NextInvoiceNo04).HasComment("Default Next Debit Note no for Sea Import Prefix");

                entity.Property(e => e.NextInvoiceNo05).HasComment("Default Next Debit Note no for warehouse Prefix");

                entity.Property(e => e.NextInvoiceNo06).HasComment("Default Next Debit Note no for Transport Prefix");

                entity.Property(e => e.NextInvoiceNo07).HasComment("Default Next Debit Note  no for Miscellaneous Prefix");

                entity.Property(e => e.NextInvoiceNo08).HasComment("Default Next Debit Note no for Other Invoice Prefix01");

                entity.Property(e => e.NextInvoiceNo09).HasComment("Default Next Debit Note no for Other Invoice Prefix02");

                entity.Property(e => e.NextInvoiceNo10).HasComment("Default Next Debit Note no for Other Invoice Prefix03");

                entity.Property(e => e.NgSignOnCreditNote).HasComment("NOT IN USE");

                entity.Property(e => e.NoOfDaysBackDateInvoice).HasComment("No. of Days allow user to back date the invoice form current date");

                entity.Property(e => e.OnSaveGenerateInvNo).HasComment("Click Save to generate the Invoice No");

                entity.Property(e => e.OperationFlag).HasComment("NOT IN USE");

                entity.Property(e => e.OtherInvoicePrefix01).HasComment("To print on the Invoice that Invoice is Other Invoice Type 01");

                entity.Property(e => e.OtherInvoicePrefix02).HasComment("To print on the Invoice that Invoice is Other Invoice Type 02");

                entity.Property(e => e.OtherInvoicePrefix03).HasComment("To print on the Invoice that Invoice is Other Invoice Type 03");

                entity.Property(e => e.OtherInvoicePrefix04).HasComment("To print on the Invoice that Invoice is Other Invoice Type 04");

                entity.Property(e => e.OtherInvoicePrefix05).HasComment("To print on the Invoice that Invoice is Other Invoice Type 05");

                entity.Property(e => e.OtherInvoicePrefix06).HasComment("To print on the Invoice that Invoice is Other Invoice Type 06");

                entity.Property(e => e.OtherInvoicePrefix07).HasComment("To print on the Invoice that Invoice is Other Invoice Type 07");

                entity.Property(e => e.OtherInvoicePrefix08).HasComment("To print on the Invoice that Invoice is Other Invoice Type 08");

                entity.Property(e => e.OtherInvoicePrefix09).HasComment("To print on the Invoice that Invoice is Other Invoice Type 09");

                entity.Property(e => e.OtherInvoicePrefix10).HasComment("To print on the Invoice that Invoice is Other Invoice Type 10");

                entity.Property(e => e.OtherInvoiceType01).HasComment("Define the Invoice Type 01 to Invoice");

                entity.Property(e => e.OtherInvoiceType02).HasComment("Define the Invoice Type 02 to Invoice");

                entity.Property(e => e.OtherInvoiceType03).HasComment("Define the Invoice Type 03 to Invoice");

                entity.Property(e => e.OtherInvoiceType04).HasComment("Define the Invoice Type 04 to Invoice");

                entity.Property(e => e.OtherInvoiceType05).HasComment("Define the Invoice Type 05 to Invoice");

                entity.Property(e => e.OtherInvoiceType06).HasComment("Define the Invoice Type 06 to Invoice");

                entity.Property(e => e.OtherInvoiceType07).HasComment("Define the Invoice Type 07 to Invoice");

                entity.Property(e => e.OtherInvoiceType08).HasComment("Define the Invoice Type 08 to Invoice");

                entity.Property(e => e.OtherInvoiceType09).HasComment("Define the Invoice Type 09 to Invoice");

                entity.Property(e => e.OtherInvoiceType10).HasComment("Define the Invoice Type 10 to Invoice");

                entity.Property(e => e.OtherJobType01).HasComment("If set as SI, Control Other Invoice Type 01 do not show on Seiv1 and Aeiv1 and Operation Ivcr1\r\nIf set as SE, Control Other Invoice Type 01 do not show on Siiv1");

                entity.Property(e => e.OtherJobType02).HasComment("If set as SI, Control Other Invoice Type 02 do not show on Seiv1 and Aeiv1 and Operation Ivcr1\r\nIf set as SE, Control Other Invoice Type 02 do not show on Siiv1");

                entity.Property(e => e.OtherJobType03).HasComment("If set as SI, Control Other Invoice Type 03 do not show on Seiv1 and Aeiv1 and Operation Ivcr1\r\nIf set as SE, Control Other Invoice Type 03 do not show on Siiv1");

                entity.Property(e => e.OtherJobType04).HasComment("If set as SI, Control Other Invoice Type 03 do not show on Seiv1 and Aeiv1 and Operation Ivcr1 If set as SE, Control Other Invoice Type 03 do not show on Siiv1");

                entity.Property(e => e.OtherJobType05).HasComment("If set as SI, Control Other Invoice Type 03 do not show on Seiv1 and Aeiv1 and Operation Ivcr1 If set as SE, Control Other Invoice Type 03 do not show on Siiv1");

                entity.Property(e => e.OtherJobType06).HasComment("If set as SI, Control Other Invoice Type 03 do not show on Seiv1 and Aeiv1 and Operation Ivcr1 If set as SE, Control Other Invoice Type 03 do not show on Siiv1");

                entity.Property(e => e.OtherJobType07).HasComment("If set as SI, Control Other Invoice Type 03 do not show on Seiv1 and Aeiv1 and Operation Ivcr1 If set as SE, Control Other Invoice Type 03 do not show on Siiv1");

                entity.Property(e => e.OtherJobType08).HasComment("If set as SI, Control Other Invoice Type 03 do not show on Seiv1 and Aeiv1 and Operation Ivcr1 If set as SE, Control Other Invoice Type 03 do not show on Siiv1");

                entity.Property(e => e.OtherJobType09).HasComment("If set as SI, Control Other Invoice Type 03 do not show on Seiv1 and Aeiv1 and Operation Ivcr1 If set as SE, Control Other Invoice Type 03 do not show on Siiv1");

                entity.Property(e => e.OtherJobType10).HasComment("If set as SI, Control Other Invoice Type 03 do not show on Seiv1 and Aeiv1 and Operation Ivcr1 If set as SE, Control Other Invoice Type 03 do not show on Siiv1");

                entity.Property(e => e.OutlayVatItemCode).HasComment("Define the VAT (GST) outlay Item Code for reporting");

                entity.Property(e => e.PostOnlineOrBatch).HasComment("O - Post directly to General Ledger, B - Post by Batch to Sales Journal and then post to General Ledger when posting End of Month");

                entity.Property(e => e.PrintCreditNoteSignFlag).HasComment("To print the credit note with negative sign");

                entity.Property(e => e.PrintUpdInvDateFlag).HasComment("if the Invoice No is blank. When printing the invoice the Invoice Date will change to the Current Date");

                entity.Property(e => e.PromptCreditCheckFlag).HasComment("Verify the customer credit limit and Slcu1.CustomerHoldFlag when entering the invoice in operation. Y - Verify and stop the user to continue (access right ='U'), Verify but give user warning only (access right ='A' or 'S').");

                entity.Property(e => e.PromptDuplicateDocFlag).HasComment("If set as 'Y', then under the Document List if record is already on the list(it mean already been invoiced),  click New button will prompt user 'This Job has already been invoiced......' Just for TrxType=1");

                entity.Property(e => e.ReversePostOnlineOrBatch).HasComment("When Reverse Posting of the invoice, O - delete the record in GL, B - insert the reversal entry in GL");

                entity.Property(e => e.RoundingVatAmtFlag).HasComment("Set as Y, The totalVatAmt will round up to 1 when decimal is >=0.5 else 0.\r\n e.g. 1.5 will be 2 and 1.4 will be 1");

                entity.Property(e => e.SalesAdjustFlag).HasComment("Set Y to show a button to adjust the Invoice Local Amount");

                entity.Property(e => e.SeaExportInvoiceType).HasComment("Default Invoice Type for Sea Export Invoice Type when Job Type is SE\r\n1-Invoice Type01, 2-Invoice Type 02………0-Invoice Type 10");

                entity.Property(e => e.SeaExportPrefix).HasComment("To print on Sea Export Invoice");

                entity.Property(e => e.SeaImportInvoiceType).HasComment("Default Invoice Type for Sea Import Invoice Type when Job Type is SI\r\n1-Invoice Type01, 2-Invoice Type 02………0-Invoice Type 10");

                entity.Property(e => e.SeaImportPrefix).HasComment("To print on Sea Import Invoice");

                entity.Property(e => e.ShowChargeTypeFlag).HasComment("ShowChargeType");

                entity.Property(e => e.ShowMiscFlag).HasComment("Set as Y, show MiscFlag on all account ivcr1 form");

                entity.Property(e => e.ShowOperationPostFlag).HasComment("If set as 'U', then show the Post button in operation ivcr1 for all user.If set as 'S', then show the Post button in operation ivcr1 for access right ='S' or 'A'If set as  'A', then show the Post button in operation ivcr1 for access right='A'.");

                entity.Property(e => e.ShowVatAmtFlag).HasComment("Set as Y, show Vat Amt column after Vat Code in ivcr1 grid. the TotalVatAmt sum from level2.VatAmt column.");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.TransportInvoiceType).HasComment("Default Invoice Type for Transport Invoice Type when Job Type is TP\r\n1-Invoice Type01, 2-Invoice Type 02………0-Invoice Type 10");

                entity.Property(e => e.TransportPrefix).HasComment("To print on Transport Invoice");

                entity.Property(e => e.UpdateBarCodeValue).HasComment("Set as DUTA for one particular customer to print Bar Code");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateVatBaseAmtFlag).HasComment("If set as N, then it will not update the ivcr1.totalExmAmt/TotalStdAmt/TotalZeroAmt when enter or edit the ivcr2.");

                entity.Property(e => e.WareHousePrefix).HasComment("To print on Warehouse Invoice");

                entity.Property(e => e.WarehouseInvoiceType).HasComment("Default Invoice Type for Warehouse Invoice Type when Job Type is WH\r\n1-Invoice Type01, 2-Invoice Type 02………0-Invoice Type 10");
            });

            modelBuilder.Entity<Ivpa2>(entity =>
            {
                entity.HasKey(e => new { e.UniqueKey, e.LineItemNo });

                entity.Property(e => e.UniqueKey).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Ivpa3>(entity =>
            {
                entity.HasKey(e => new { e.UniqueKey, e.LineItemNo });

                entity.Property(e => e.UniqueKey).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<JmAllInformation>(entity =>
            {
                entity.ToView("jm_All_Information");

                entity.Property(e => e.Eta).IsFixedLength();

                entity.Property(e => e.Etd).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.ShipmentDate).IsFixedLength();
            });

            modelBuilder.Entity<JmAllInvoicePurchase2>(entity =>
            {
                entity.ToView("jm_All_Invoice_Purchase_2");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<JmAllInvoiceVendorInvoice>(entity =>
            {
                entity.ToView("jm_All_Invoice_Vendor_Invoice");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.VendorInvoiceDate).IsFixedLength();
            });

            modelBuilder.Entity<JmChargeWeightRatio>(entity =>
            {
                entity.ToView("jm_Charge_Weight_Ratio");
            });

            modelBuilder.Entity<JmGglInformation>(entity =>
            {
                entity.ToView("jm_GGL_Information");

                entity.Property(e => e.Eta).IsFixedLength();

                entity.Property(e => e.Etd).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.ShipmentDate).IsFixedLength();
            });

            modelBuilder.Entity<JmGglMasterDump>(entity =>
            {
                entity.ToView("jm_GGL_Master_Dump");

                entity.Property(e => e.FlightDate).IsFixedLength();
            });

            modelBuilder.Entity<JmGrossWeightRatio>(entity =>
            {
                entity.ToView("jm_Gross_Weight_Ratio");
            });

            modelBuilder.Entity<JmJobAccPl>(entity =>
            {
                entity.ToView("jm_Job_Acc_PL");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<JmJobAccPlTranshipment>(entity =>
            {
                entity.ToView("jm_Job_Acc_PL_Transhipment");
            });

            modelBuilder.Entity<JmJobAccPlWithDistributionCost>(entity =>
            {
                entity.ToView("jm_Job_Acc_PL_With_Distribution_Cost");
            });

            modelBuilder.Entity<JmJobAccPlWithDistributionCostByJob>(entity =>
            {
                entity.ToView("jm_Job_Acc_PL_With_Distribution_Cost_By_Job");
            });

            modelBuilder.Entity<JmJobAccPlWithDistributionCostGrossWeight>(entity =>
            {
                entity.ToView("jm_Job_Acc_PL_With_Distribution_Cost_Gross_Weight");
            });

            modelBuilder.Entity<JmJobAccPlWithDistributionInternalCost>(entity =>
            {
                entity.ToView("jm_Job_Acc_PL_With_Distribution_Internal_Cost");
            });

            modelBuilder.Entity<JmJobAccPlWithDistributionProvisionCost>(entity =>
            {
                entity.ToView("jm_Job_Acc_PL_With_Distribution_Provision_Cost");
            });

            modelBuilder.Entity<JmJobAccPlWithNonMatchProvisionCost>(entity =>
            {
                entity.ToView("jm_Job_Acc_PL_With_Non_Match_Provision_Cost");
            });

            modelBuilder.Entity<JmJobAccrualSalesCostSummary>(entity =>
            {
                entity.ToView("jm_Job_Accrual_Sales_Cost_Summary");
            });

            modelBuilder.Entity<JmJobAccrualSummary>(entity =>
            {
                entity.ToView("jm_Job_Accrual_Summary");
            });

            modelBuilder.Entity<JmJobActualCostByItem>(entity =>
            {
                entity.ToView("jm_Job_Actual_Cost_By_Item");
            });

            modelBuilder.Entity<JmJobActualCostCurrTypeGroupByJob>(entity =>
            {
                entity.ToView("jm_Job_Actual_Cost_Curr_Type_Group_By_Job");
            });

            modelBuilder.Entity<JmJobActualCostWithDistributionByJob>(entity =>
            {
                entity.ToView("jm_Job_Actual_Cost_with_Distribution_By_Job");
            });

            modelBuilder.Entity<JmJobActualCostWithDistributionByJob2>(entity =>
            {
                entity.ToView("jm_Job_Actual_Cost_with_Distribution_By_Job_2");
            });

            modelBuilder.Entity<JmJobActualPl>(entity =>
            {
                entity.ToView("jm_Job_Actual_PL");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<JmJobActualPl1>(entity =>
            {
                entity.ToView("jm_Job_Actual_PL_1");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<JmJobActualPl2>(entity =>
            {
                entity.ToView("jm_Job_Actual_PL_2");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<JmJobActualPl3>(entity =>
            {
                entity.ToView("jm_Job_Actual_PL_3");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<JmJobActualPlCost>(entity =>
            {
                entity.ToView("jm_Job_Actual_PL_Cost");
            });

            modelBuilder.Entity<JmJobActualPlNoVat>(entity =>
            {
                entity.ToView("jm_Job_Actual_PL_No_Vat");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<JmJobActualPlNonMatchProvision>(entity =>
            {
                entity.ToView("jm_Job_Actual_PL_Non_Match_Provision");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<JmJobActualPlProvisionCost>(entity =>
            {
                entity.ToView("jm_Job_Actual_PL_Provision_Cost");
            });

            modelBuilder.Entity<JmJobActualPlSummary>(entity =>
            {
                entity.ToView("jm_Job_Actual_PL_Summary");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<JmJobActualPlWithAccrual>(entity =>
            {
                entity.ToView("jm_Job_Actual_PL_With_Accrual");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<JmJobActualPlWithDistributionCost>(entity =>
            {
                entity.ToView("jm_Job_Actual_PL_With_Distribution_Cost");
            });

            modelBuilder.Entity<JmJobActualPlWithDistributionCost3>(entity =>
            {
                entity.ToView("jm_Job_Actual_PL_With_Distribution_Cost_3");
            });

            modelBuilder.Entity<JmJobActualPlWithDistributionCostByCurr>(entity =>
            {
                entity.ToView("jm_Job_Actual_PL_With_Distribution_Cost_By_Curr");
            });

            modelBuilder.Entity<JmJobActualPlWithDistributionCostByJob>(entity =>
            {
                entity.ToView("jm_Job_Actual_PL_With_Distribution_Cost_By_Job");
            });

            modelBuilder.Entity<JmJobActualPlWithDistributionCostNoVatByJob>(entity =>
            {
                entity.ToView("jm_Job_Actual_PL_With_Distribution_Cost_No_Vat_By_Job");
            });

            modelBuilder.Entity<JmJobActualPlWithDistributionCostTeu>(entity =>
            {
                entity.ToView("jm_Job_Actual_PL_With_Distribution_Cost_Teu");
            });

            modelBuilder.Entity<JmJobActualPlWithDistributionCostVolume>(entity =>
            {
                entity.ToView("jm_Job_Actual_PL_With_Distribution_Cost_Volume");
            });

            modelBuilder.Entity<JmJobActualPlWithDistributionInternalCost>(entity =>
            {
                entity.ToView("jm_Job_Actual_PL_With_Distribution_Internal_Cost");
            });

            modelBuilder.Entity<JmJobActualPlWithDistributionProvisionCost>(entity =>
            {
                entity.ToView("jm_Job_Actual_PL_With_Distribution_Provision_Cost");
            });

            modelBuilder.Entity<JmJobActualPlWithNonMatchProvisionCost>(entity =>
            {
                entity.ToView("jm_Job_Actual_PL_With_Non_Match_Provision_Cost");
            });

            modelBuilder.Entity<JmJobActualPlWithProvisionCost>(entity =>
            {
                entity.ToView("jm_Job_Actual_PL_With_Provision_Cost");
            });

            modelBuilder.Entity<JmJobActualPlWithVatOutlay>(entity =>
            {
                entity.ToView("jm_Job_Actual_PL_With_Vat_Outlay");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<JmJobActualProvisionCost>(entity =>
            {
                entity.ToView("jm_Job_Actual_Provision_Cost");

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<JmJobActualSalesByItem>(entity =>
            {
                entity.ToView("jm_Job_Actual_Sales_By_Item");
            });

            modelBuilder.Entity<JmJobActualSalesCostProvisionCost>(entity =>
            {
                entity.ToView("jm_Job_Actual_Sales_Cost_Provision_Cost");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<JmJobActualSalesCurrTypeGroupByJob>(entity =>
            {
                entity.ToView("Jm_Job_Actual_Sales_Curr_Type_Group_By_Job");
            });

            modelBuilder.Entity<JmJobActualSalesNonMatchCostProvisionCost>(entity =>
            {
                entity.ToView("jm_Job_Actual_Sales_Non_Match_Cost_Provision_Cost");
            });

            modelBuilder.Entity<JmJobActualSalesProvisionCost>(entity =>
            {
                entity.ToView("jm_Job_Actual_Sales_Provision_Cost");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<JmJobActualSalesWithDistributionByJob>(entity =>
            {
                entity.ToView("jm_Job_Actual_Sales_with_Distribution_By_Job");
            });

            modelBuilder.Entity<JmJobActualSalesWithDistributionByJob2>(entity =>
            {
                entity.ToView("jm_Job_Actual_Sales_with_Distribution_By_Job_2");
            });

            modelBuilder.Entity<JmJobActualSalesWithDistributionProvisionCost>(entity =>
            {
                entity.ToView("jm_Job_Actual_Sales_With_Distribution_Provision_Cost");
            });

            modelBuilder.Entity<JmJobCashCostCn>(entity =>
            {
                entity.ToView("jm_Job_Cash_Cost_Cn");
            });

            modelBuilder.Entity<JmJobCashCostCnSale>(entity =>
            {
                entity.ToView("Jm_Job_Cash_Cost_Cn_Sales");
            });

            modelBuilder.Entity<JmJobCost>(entity =>
            {
                entity.ToView("jm_Job_Cost");
            });

            modelBuilder.Entity<JmJobCostCn>(entity =>
            {
                entity.ToView("jm_Job_Cost_Cn");
            });

            modelBuilder.Entity<JmJobCostCnSale>(entity =>
            {
                entity.ToView("Jm_Job_Cost_Cn_Sales");
            });

            modelBuilder.Entity<JmJobCostngByType>(entity =>
            {
                entity.ToView("Jm_Job_Costng_By_Type");
            });

            modelBuilder.Entity<JmJobDocNo>(entity =>
            {
                entity.ToView("jm_Job_Doc_No");
            });

            modelBuilder.Entity<JmJobInternalProvisionSummaryByJob>(entity =>
            {
                entity.ToView("jm_Job_Internal_Provision_Summary_By_Job");
            });

            modelBuilder.Entity<JmJobInternalProvisionSummaryByMasterJob>(entity =>
            {
                entity.ToView("jm_Job_Internal_Provision_Summary_By_Master_Job");
            });

            modelBuilder.Entity<JmJobInvoiceCashCostCn>(entity =>
            {
                entity.ToView("jm_Job_Invoice_Cash_Cost_Cn");
            });

            modelBuilder.Entity<JmJobMaster>(entity =>
            {
                entity.ToView("jm_Job_Master");

                entity.Property(e => e.Eta).IsFixedLength();

                entity.Property(e => e.Etd).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.ShipmentDate).IsFixedLength();
            });

            modelBuilder.Entity<JmJobOperationCostByJob>(entity =>
            {
                entity.ToView("jm_Job_Operation_Cost_By_Job");
            });

            modelBuilder.Entity<JmJobPl>(entity =>
            {
                entity.ToView("jm_Job_PL");
            });

            modelBuilder.Entity<JmJobPlAccrualActualByJobItemTrxNoByItem>(entity =>
            {
                entity.ToView("jm_Job_PL_Accrual_Actual_By_Job_Item_Trx_No_By_Item");

                entity.Property(e => e.Date).IsFixedLength();
            });

            modelBuilder.Entity<JmJobPlByMasterJob>(entity =>
            {
                entity.ToView("jm_Job_PL_By_Master_Job");
            });

            modelBuilder.Entity<JmJobPlDetail>(entity =>
            {
                entity.ToView("jm_Job_PL_Detail");

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();
            });

            modelBuilder.Entity<JmJobPlProvisionActualByItem>(entity =>
            {
                entity.ToView("jm_Job_PL_Provision_Actual_By_Item");
            });

            modelBuilder.Entity<JmJobPlProvisionActualByJobItemTrxNo>(entity =>
            {
                entity.ToView("jm_Job_PL_Provision_Actual_By_Job_Item_Trx_No");
            });

            modelBuilder.Entity<JmJobPlProvisionPostActualByItem>(entity =>
            {
                entity.ToView("jm_Job_PL_Provision_Post_Actual_By_Item");
            });

            modelBuilder.Entity<JmJobPlProvisionPostActualByJobItemTrxNo>(entity =>
            {
                entity.ToView("jm_Job_PL_Provision_Post_Actual_By_Job_Item_Trx_No");
            });

            modelBuilder.Entity<JmJobPostSalesProvisionCost>(entity =>
            {
                entity.ToView("jm_Job_Post_Sales_Provision_Cost");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<JmJobProvisionByMasterJob>(entity =>
            {
                entity.ToView("jm_Job_Provision_By_Master_Job");
            });

            modelBuilder.Entity<JmJobProvisionByMasterJobByItem>(entity =>
            {
                entity.ToView("jm_Job_Provision_By_Master_Job_By_Item");
            });

            modelBuilder.Entity<JmJobProvisionCost>(entity =>
            {
                entity.ToView("jm_Job_Provision_Cost");
            });

            modelBuilder.Entity<JmJobProvisionCostBalanceByItem>(entity =>
            {
                entity.ToView("jm_Job_Provision_Cost_Balance_By_Item");
            });

            modelBuilder.Entity<JmJobProvisionCostBalanceNoCashByItem>(entity =>
            {
                entity.ToView("jm_Job_Provision_Cost_Balance_No_Cash_By_Item");
            });

            modelBuilder.Entity<JmJobProvisionCostByItem>(entity =>
            {
                entity.ToView("jm_Job_Provision_Cost_By_Item");
            });

            modelBuilder.Entity<JmJobProvisionCostByItemDescription>(entity =>
            {
                entity.ToView("jm_Job_Provision_Cost_By_Item_Description");
            });

            modelBuilder.Entity<JmJobProvisionCostByJob>(entity =>
            {
                entity.ToView("jm_Job_Provision_Cost_By_Job");
            });

            modelBuilder.Entity<JmJobProvisionCostWithDistributionCostVolume>(entity =>
            {
                entity.ToView("jm_Job_Provision_Cost_With_Distribution_Cost_Volume");
            });

            modelBuilder.Entity<JmJobProvisionCostWithDistributionCostVolumeByJob>(entity =>
            {
                entity.ToView("jm_Job_Provision_Cost_With_Distribution_Cost_Volume_By_Job");
            });

            modelBuilder.Entity<JmJobProvisionCostWithDistributionCostVolumeWithInternalJob>(entity =>
            {
                entity.ToView("jm_Job_Provision_Cost_With_Distribution_Cost_Volume_With_Internal_Job");
            });

            modelBuilder.Entity<JmJobProvisionCostWithDistributionCostVolumeWithInternalJobFlagByJob>(entity =>
            {
                entity.ToView("jm_Job_Provision_Cost_With_Distribution_Cost_Volume_With_Internal_Job_Flag_By_Job");
            });

            modelBuilder.Entity<JmJobProvisionSalesByItem>(entity =>
            {
                entity.ToView("jm_Job_Provision_Sales_By_Item");
            });

            modelBuilder.Entity<JmJobProvisionSalesCostSummary>(entity =>
            {
                entity.ToView("jm_Job_Provision_Sales_Cost_Summary");
            });

            modelBuilder.Entity<JmJobProvisionSalesProvisionCost>(entity =>
            {
                entity.ToView("jm_Job_Provision_Sales_Provision_Cost");
            });

            modelBuilder.Entity<JmJobProvisionSummary>(entity =>
            {
                entity.ToView("jm_Job_Provision_Summary");
            });

            modelBuilder.Entity<JmJobProvisionSummaryByJob>(entity =>
            {
                entity.ToView("jm_Job_Provision_Summary_By_Job");
            });

            modelBuilder.Entity<JmJobProvisionSummaryByMasterJob>(entity =>
            {
                entity.ToView("jm_Job_Provision_Summary_By_Master_Job");
            });

            modelBuilder.Entity<JmJobProvisionSummaryNoVat>(entity =>
            {
                entity.ToView("jm_Job_Provision_Summary_No_Vat");
            });

            modelBuilder.Entity<JmJobProvisionSummaryNoVatByInvoice>(entity =>
            {
                entity.ToView("jm_Job_Provision_Summary_No_Vat_By_Invoice");
            });

            modelBuilder.Entity<JmJobProvisionSummaryNoVatGroupByInvoice>(entity =>
            {
                entity.ToView("jm_Job_Provision_Summary_No_Vat_Group_By_Invoice");
            });

            modelBuilder.Entity<JmJobProvisionSummaryWithDistribution>(entity =>
            {
                entity.ToView("jm_Job_Provision_Summary_With_Distribution");
            });

            modelBuilder.Entity<JmJobProvisionSummaryWithDistributionByJob>(entity =>
            {
                entity.ToView("jm_Job_Provision_Summary_With_Distribution_by_Job");
            });

            modelBuilder.Entity<JmJobProvisionWithDistributionCost>(entity =>
            {
                entity.ToView("jm_Job_Provision_With_Distribution_Cost");
            });

            modelBuilder.Entity<JmJobSale>(entity =>
            {
                entity.ToView("jm_Job_Sales");
            });

            modelBuilder.Entity<JmJobSalesDate>(entity =>
            {
                entity.ToView("jm_Job_Sales_Date");

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<JmJobStatus>(entity =>
            {
                entity.ToView("Jm_Job_Status");

                entity.Property(e => e.CargoCollectionDate).IsFixedLength();

                entity.Property(e => e.CashInvoiceDate).IsFixedLength();

                entity.Property(e => e.CnDate).IsFixedLength();

                entity.Property(e => e.DOReleaseDate).IsFixedLength();

                entity.Property(e => e.DnDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.MasterCnDate).IsFixedLength();

                entity.Property(e => e.MasterDnDate).IsFixedLength();

                entity.Property(e => e.MasterPvApproveDate).IsFixedLength();

                entity.Property(e => e.MasterPvDate).IsFixedLength();

                entity.Property(e => e.PvApproveDate).IsFixedLength();

                entity.Property(e => e.PvDate).IsFixedLength();

                entity.Property(e => e.VendorInvoiceDate).IsFixedLength();
            });

            modelBuilder.Entity<JmMasterJobAccCostByItem>(entity =>
            {
                entity.ToView("jm_Master_Job_Acc_Cost_By_Item");
            });

            modelBuilder.Entity<JmMasterJobAccCostByItemWithVat>(entity =>
            {
                entity.ToView("jm_Master_Job_Acc_Cost_By_Item_With_Vat");
            });

            modelBuilder.Entity<JmMasterJobAccCostDistribution>(entity =>
            {
                entity.ToView("jm_Master_Job_Acc_Cost_Distribution");
            });

            modelBuilder.Entity<JmMasterJobAccCostDistributionByJob>(entity =>
            {
                entity.ToView("jm_Master_Job_Acc_Cost_Distribution_By_Job");
            });

            modelBuilder.Entity<JmMasterJobAccCostDistributionByJobWithVat>(entity =>
            {
                entity.ToView("jm_Master_Job_Acc_Cost_Distribution_By_Job_With_Vat");
            });

            modelBuilder.Entity<JmMasterJobAccCostDistributionWithVat>(entity =>
            {
                entity.ToView("jm_Master_Job_Acc_Cost_Distribution_With_Vat");
            });

            modelBuilder.Entity<JmMasterJobAccSalesByItem>(entity =>
            {
                entity.ToView("jm_Master_Job_Acc_Sales_By_Item");
            });

            modelBuilder.Entity<JmMasterJobAccSalesByItemWithVat>(entity =>
            {
                entity.ToView("jm_Master_Job_Acc_Sales_By_Item_With_Vat");
            });

            modelBuilder.Entity<JmMasterJobAccSalesCostDistribution>(entity =>
            {
                entity.ToView("jm_Master_Job_Acc_Sales_Cost_Distribution");
            });

            modelBuilder.Entity<JmMasterJobAccSalesCostDistributionWithVat>(entity =>
            {
                entity.ToView("jm_Master_Job_Acc_Sales_Cost_Distribution_With_Vat");
            });

            modelBuilder.Entity<JmMasterJobAccSalesDistribution>(entity =>
            {
                entity.ToView("jm_Master_Job_Acc_Sales_Distribution");
            });

            modelBuilder.Entity<JmMasterJobAccSalesDistributionByJob>(entity =>
            {
                entity.ToView("jm_Master_Job_Acc_Sales_Distribution_By_Job");
            });

            modelBuilder.Entity<JmMasterJobAccSalesDistributionByJobWithVat>(entity =>
            {
                entity.ToView("jm_Master_Job_Acc_Sales_Distribution_By_Job_With_Vat");
            });

            modelBuilder.Entity<JmMasterJobAccSalesDistributionWithVat>(entity =>
            {
                entity.ToView("jm_Master_Job_Acc_Sales_Distribution_With_Vat");
            });

            modelBuilder.Entity<JmMasterJobAccrualSalesCostSummary>(entity =>
            {
                entity.ToView("jm_Master_Job_Accrual_Sales_Cost_Summary");
            });

            modelBuilder.Entity<JmMasterJobAccrualSalesCostSummaryDistribution>(entity =>
            {
                entity.ToView("jm_Master_Job_Accrual_Sales_Cost_Summary_Distribution");
            });

            modelBuilder.Entity<JmMasterJobAccrualSummaryDistribution>(entity =>
            {
                entity.ToView("jm_Master_Job_Accrual_Summary_Distribution");
            });

            modelBuilder.Entity<JmMasterJobActualCost>(entity =>
            {
                entity.ToView("jm_Master_Job_Actual_Cost");
            });

            modelBuilder.Entity<JmMasterJobActualCostByItem>(entity =>
            {
                entity.ToView("jm_Master_Job_Actual_Cost_By_Item");
            });

            modelBuilder.Entity<JmMasterJobActualCostByItem2>(entity =>
            {
                entity.ToView("jm_Master_Job_Actual_Cost_By_Item_2");
            });

            modelBuilder.Entity<JmMasterJobActualCostByItem3>(entity =>
            {
                entity.ToView("jm_Master_Job_Actual_Cost_By_Item_3");
            });

            modelBuilder.Entity<JmMasterJobActualCostByItemWithVat>(entity =>
            {
                entity.ToView("jm_Master_Job_Actual_Cost_By_Item_With_Vat");
            });

            modelBuilder.Entity<JmMasterJobActualCostDistribution>(entity =>
            {
                entity.ToView("jm_Master_Job_Actual_Cost_Distribution");
            });

            modelBuilder.Entity<JmMasterJobActualCostDistribution2>(entity =>
            {
                entity.ToView("jm_Master_Job_Actual_Cost_Distribution_2");
            });

            modelBuilder.Entity<JmMasterJobActualCostDistribution3>(entity =>
            {
                entity.ToView("jm_Master_Job_Actual_Cost_Distribution_3");
            });

            modelBuilder.Entity<JmMasterJobActualSalesByItem>(entity =>
            {
                entity.ToView("jm_Master_Job_Actual_Sales_By_Item");
            });

            modelBuilder.Entity<JmMasterJobActualSalesByItem2>(entity =>
            {
                entity.ToView("jm_Master_Job_Actual_Sales_By_Item_2");
            });

            modelBuilder.Entity<JmMasterJobActualSalesByItem3>(entity =>
            {
                entity.ToView("jm_Master_Job_Actual_Sales_By_Item_3");
            });

            modelBuilder.Entity<JmMasterJobActualSalesDistribution>(entity =>
            {
                entity.ToView("jm_Master_Job_Actual_Sales_Distribution");
            });

            modelBuilder.Entity<JmMasterJobActualSalesDistribution2>(entity =>
            {
                entity.ToView("jm_Master_Job_Actual_Sales_Distribution_2");
            });

            modelBuilder.Entity<JmMasterJobActualSalesDistribution3>(entity =>
            {
                entity.ToView("jm_Master_Job_Actual_Sales_Distribution_3");
            });

            modelBuilder.Entity<JmMasterJobProvisionCost>(entity =>
            {
                entity.ToView("jm_Master_Job_Provision_Cost");
            });

            modelBuilder.Entity<JmMasterJobProvisionCostByItem>(entity =>
            {
                entity.ToView("jm_Master_Job_Provision_Cost_By_Item");
            });

            modelBuilder.Entity<JmMasterJobProvisionCostDistribution>(entity =>
            {
                entity.ToView("jm_Master_Job_Provision_Cost_Distribution");
            });

            modelBuilder.Entity<JmMasterJobProvisionSalesCostSummary>(entity =>
            {
                entity.ToView("jm_Master_Job_Provision_Sales_Cost_Summary");
            });

            modelBuilder.Entity<JmMasterJobProvisionSalesCostSummaryDistribution>(entity =>
            {
                entity.ToView("jm_Master_Job_Provision_Sales_Cost_Summary_Distribution");
            });

            modelBuilder.Entity<JmMasterJobProvisionSummary>(entity =>
            {
                entity.ToView("jm_Master_Job_Provision_Summary");
            });

            modelBuilder.Entity<JmMasterJobProvisionSummaryDistribution>(entity =>
            {
                entity.ToView("jm_Master_Job_Provision_Summary_Distribution");
            });

            modelBuilder.Entity<JmNoOfHouseJob>(entity =>
            {
                entity.ToView("jm_No_of_House_Job");
            });

            modelBuilder.Entity<JmNoOfJobRatio>(entity =>
            {
                entity.ToView("jm_No_of_Job_Ratio");
            });

            modelBuilder.Entity<JmNonMasterJobAccPlByItem>(entity =>
            {
                entity.ToView("jm_Non_Master_Job_Acc_PL_By_Item");
            });

            modelBuilder.Entity<JmNonMasterJobActualPlByItem>(entity =>
            {
                entity.ToView("jm_Non_Master_Job_Actual_PL_By_Item");
            });

            modelBuilder.Entity<JmNonMasterJobActualPlByItem2>(entity =>
            {
                entity.ToView("jm_Non_Master_Job_Actual_PL_By_Item_2");
            });

            modelBuilder.Entity<JmNonMasterJobActualPlByItem3>(entity =>
            {
                entity.ToView("jm_Non_Master_Job_Actual_PL_By_Item_3");
            });

            modelBuilder.Entity<JmNonMasterJobActualPlByItemCurr>(entity =>
            {
                entity.ToView("jm_Non_Master_Job_Actual_PL_By_Item_Curr");
            });

            modelBuilder.Entity<JmNonMasterJobProvisionCostByItem>(entity =>
            {
                entity.ToView("jm_Non_Master_Job_Provision_Cost_By_Item");
            });

            modelBuilder.Entity<JmNonMasterJobProvisionSummary>(entity =>
            {
                entity.ToView("jm_Non_Master_Job_Provision_Summary");
            });

            modelBuilder.Entity<JmNonMatchJobProvisionCost>(entity =>
            {
                entity.ToView("jm_Non_Match_Job_Provision_Cost");
            });

            modelBuilder.Entity<JmNonMatchJobProvisionCostByItem>(entity =>
            {
                entity.ToView("jm_Non_Match_Job_Provision_Cost_By_Item");
            });

            modelBuilder.Entity<JmNonMatchJobProvisionCostByJob>(entity =>
            {
                entity.ToView("jm_Non_Match_Job_Provision_Cost_By_Job");
            });

            modelBuilder.Entity<JmNonMatchJobProvisionCostByMasterJob>(entity =>
            {
                entity.ToView("jm_Non_Match_Job_Provision_Cost_By_Master_Job");
            });

            modelBuilder.Entity<JmNonMatchJobProvisionSale>(entity =>
            {
                entity.ToView("jm_Non_Match_Job_Provision_Sales");
            });

            modelBuilder.Entity<JmNonMatchProvCostByJob>(entity =>
            {
                entity.ToView("jm_Non_Match_Prov_Cost_By_Job");
            });

            modelBuilder.Entity<JmNonMatchProvisionCostByJob>(entity =>
            {
                entity.ToView("jm_Non_Match_Provision_Cost_By_Job");
            });

            modelBuilder.Entity<JmPcsRatio>(entity =>
            {
                entity.ToView("jm_Pcs_Ratio");
            });

            modelBuilder.Entity<JmSalesCostProvSummary>(entity =>
            {
                entity.ToView("jm_Sales_Cost_Prov_Summary");
            });

            modelBuilder.Entity<JmSeaJobActualPlWithDistributionCost>(entity =>
            {
                entity.ToView("jm_Sea_Job_Actual_PL_With_Distribution_Cost");
            });

            modelBuilder.Entity<JmSeaJobActualPlWithDistributionCostByJob>(entity =>
            {
                entity.ToView("jm_Sea_Job_Actual_PL_With_Distribution_Cost_By_Job");
            });

            modelBuilder.Entity<JmTeuRatio>(entity =>
            {
                entity.ToView("jm_Teu_Ratio");
            });

            modelBuilder.Entity<JmUnbillJob>(entity =>
            {
                entity.ToView("jm_Unbill_Job");
            });

            modelBuilder.Entity<JmVolumeRatio>(entity =>
            {
                entity.ToView("jm_Volume_Ratio");
            });

            modelBuilder.Entity<Jmaj1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PostFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Jmce1>(entity =>
            {
                entity.Property(e => e.TrxNo).ValueGeneratedNever();

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Jmce2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Jmce3>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItem });
            });

            modelBuilder.Entity<Jmce4>(entity =>
            {
                entity.Property(e => e.TrxNo).ValueGeneratedNever();
            });

            modelBuilder.Entity<Jmcs1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AccCodeNavigation)
                    .WithMany(p => p.Jmcs1s)
                    .HasForeignKey(d => d.AccCode)
                    .HasConstraintName("FK_jmds1_glch1");
            });

            modelBuilder.Entity<Jmct1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Jmdo1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_Jmdo1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Jmdt1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Jmdt2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.JobNo, e.LineItemNo });

                entity.HasOne(d => d.JobNoNavigation)
                    .WithMany(p => p.Jmdt2s)
                    .HasForeignKey(d => d.JobNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_jmdt2_jmdt1");
            });

            modelBuilder.Entity<Jmdt3>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.JobNo, e.LineItemNo });

                entity.HasOne(d => d.JobNoNavigation)
                    .WithMany(p => p.Jmdt3s)
                    .HasForeignKey(d => d.JobNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_jmdt3_jmdt1");
            });

            modelBuilder.Entity<Jmdt4>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.JobNo, e.LineItemNo });

                entity.HasOne(d => d.JobNoNavigation)
                    .WithMany(p => p.Jmdt4s)
                    .HasForeignKey(d => d.JobNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_jmdt4_jmdt1");
            });

            modelBuilder.Entity<Jmeg1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Jmeg2>(entity =>
            {
                entity.HasKey(e => new { e.GroupCode, e.LineItemNo });
            });

            modelBuilder.Entity<Jmfb1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Jmje1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Jmje2>(entity =>
            {
                entity.HasKey(e => new { e.EventCode, e.LineItemNo })
                    .HasName("PK_jmje3");
            });

            modelBuilder.Entity<Jmjm1>(entity =>
            {
                entity.Property(e => e.BillingFlag).HasDefaultValueSql("('Y')");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.GeneratingBbfeeFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.InvoiceCompleteFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.SuspenseInvoiceAgentFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.SuspenseInvoiceAirlineFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Jmjm2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.JobNo, e.LineItemNo });

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();

                entity.Property(e => e.ActualCostAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.Amt).HasDefaultValueSql("((0))");

                entity.Property(e => e.CloseFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.CostAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostCurrRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostUnitRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.InternalFlag).HasDefaultValueSql("(N'N')");

                entity.Property(e => e.LocalAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.PostFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.Qty).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Jmjm3>(entity =>
            {
                entity.HasKey(e => new { e.JobNo, e.LineItemNo });

                entity.Property(e => e.AutoFlag).HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<Jmjm4>(entity =>
            {
                entity.HasKey(e => new { e.JobNo, e.JobLineItemNo, e.LineItemNo });
            });

            modelBuilder.Entity<Jmjm5>(entity =>
            {
                entity.HasKey(e => new { e.JobNo, e.LineItemNo });
            });

            modelBuilder.Entity<Jmjm6>(entity =>
            {
                entity.HasKey(e => new { e.JobNo, e.LineItemNo });
            });

            modelBuilder.Entity<Jmjm7>(entity =>
            {
                entity.HasKey(e => new { e.JobNo, e.JobLineItemNo, e.EventLineItemNo });
            });

            modelBuilder.Entity<JmjmProvisionActualSalesProvisionActualCost>(entity =>
            {
                entity.ToView("jmjm_Provision_Actual_Sales_Provision_Actual_Cost");
            });

            modelBuilder.Entity<Jmjs1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Jmjs2>(entity =>
            {
                entity.HasKey(e => new { e.JobStatusCode, e.LineItemNo });
            });

            modelBuilder.Entity<Jmjt1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Jmmp1>(entity =>
            {
                entity.HasKey(e => e.ContrNo)
                    .HasName("PK_JMMP1");

                entity.Property(e => e.DateAdded).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Jmpa1>(entity =>
            {
                entity.Property(e => e.AccrueBilledItemFlag).HasComment("Set as Y only the item has billing will provide the Cost Accrual");

                entity.Property(e => e.AdjustPrefix).HasComment("NOT IN USE");

                entity.Property(e => e.AppJobCostingAccessRight).HasComment("If set as 'A' or blank, then only access right ='A' can amend\r\nIf set as 'S', then access right ='A' or 'S' can amend\r\nIf set as 'U', then all users can amend");

                entity.Property(e => e.AutoGenerateProvisionFlag).HasComment("NOT IN USE");

                entity.Property(e => e.ClearingCostAccCode).HasComment("Set Acc Code for WIP in Job Costing");

                entity.Property(e => e.ClearingSalesAccCode).HasComment("Set Acc Code for WIP in Job Costing");

                entity.Property(e => e.ControlJobCostingFlag).HasComment("If set as Y, then it will lock the ivcr1/plvi2 grid. Also disable the button Charges/Quotation/Billing History/Warehouse Charges. When change ivcr1/Plvi1.JobNo, it should not prompt message and don't update job no to level2");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateJobFlag).HasComment("Set Y will allow user to create the Job from the entry form of the Ivcr1,Vendor Invoice and Cash Purchase");

                entity.Property(e => e.DefaultCustomerCodeFlag).HasComment("Set as Y,  it will auto default the customer code from the jmjm1 customer code if user try to remove the customer code under job costing screen.");

                entity.Property(e => e.DefaultDocument).HasComment("Default the Document List to display the Trx Type of Document e.g. IV for Invoice, CN for Credit Note, DN for Debite Note, CI for Cash Invoice, CR for Cash Receipt, 0 for Ivcr1_0, 1 for Ivcr1_1, 2 for Ivcr1_2, 3 for Ivcr1_3, 4 for Ivcr1_4, 5 for Ivcr1_5, 6 for Ivcr1_6, 7 for Ivcr1_7,  8 for Ivcr1_8, 9 for Ivcr1_9");

                entity.Property(e => e.HideCostBackFlag).HasComment("Set as Y, hide Cost Back column under Quotation Costing screen and Job Costing screen.");

                entity.Property(e => e.HideCostFlag).HasComment("Access Right to hide the Cost Column in Job Costing and select from Job Costing in the invoice entry");

                entity.Property(e => e.HideInternalCostingFlag).HasComment("If set as 'Y', then it will hide the Internal Costing button and Internal Costing tab on the Consol");

                entity.Property(e => e.HideJobCostingColumnFlag).HasComment("If set as 'Y', then it will hide the Job Costing button and Job Costing tab on the Consol");

                entity.Property(e => e.HideJobCostingCustomerVendorFlag).HasComment("If set as C, then it will hide the Cust/Customer Name column in Job Costing / Internal Costing\r\nIf set as V, then it will hide the Vendor/Vendor Name column in Job Costing / Internal Costing\r\nIf set as Y, then it will hide the Cust/Customer Name/Vendor/Vendor Name column in Job Costing / Internal Costing");

                entity.Property(e => e.HideJobCostingCustomerVendorNameFlag).HasComment("If set as Y, it will hide the Cust Name/Vendor Name column in Job Costing / Internal Costing");

                entity.Property(e => e.HideJobCostingFlag).HasComment("If set as 'Y', then it will hide the Job Costing button and Job Costing tab on the Consol");

                entity.Property(e => e.ImplementDate).HasComment("NOT IN USE");

                entity.Property(e => e.JobClosingAccessRight).HasComment("Set access right for close job under Event Log tab. A - Only Access Right = A can close; S - Access Right = A&S can close; U - Access Right = U&S&A can close.");

                entity.Property(e => e.JobDateFlag).HasComment("if set as 'Y' then allow user to change the JobDate in Sebl1, Sibl1, Aeaw1, Aiaw1, Tobk1");

                entity.Property(e => e.JobItemTrxNoProvFlag).HasComment("Set as Y, for Job Provision Generation, use Jmjm2.TrxNo not in pl_All_Purchase_2.[Job Item Trx No] /iv_All_Invoice_2.[Job Item Trx No]\r\n to generate provision");

                entity.Property(e => e.JobNoByShipmentFlag).HasComment("Set");

                entity.Property(e => e.JobSeqLength).HasComment("Sepecify the Job Running No.");

                entity.Property(e => e.LastPostDate).HasComment("Define the Last Post Date\r\n1. If PostDate<Last Post Date then prompt ' You have done the posting for this date. You cannot back date the posting'. \r\n2. If the Post Date >= LastPostDate, then proceed the posting.");

                entity.Property(e => e.LockClosedJobFlag).HasComment("If set as Y, in Ivcr1 and Plvi1 F4 seach Job should filter the status =CLS");

                entity.Property(e => e.LockSalesmanFlag).HasComment("If set as Y, Access Right = 'U', will lock the Salesman Code in BL and jmjm1");

                entity.Property(e => e.MasterCostByVol).HasComment("Set as Y, Under Job Costing click Master Cost button, it will use the Volume in jmjm1 to split cost from master to house. It is only for the Module Code =SE and SI.\r\n");

                entity.Property(e => e.NextJournalNo).HasComment("Next Journal No. for the Job Provision Posting");

                entity.Property(e => e.PlsummaryCrNoteFlag).HasComment("If set as Y,  the \"Credit Note To Vendor\" and \"Credit Note To Customer\" under P&L Summary screen should exchange. The \"Grand Total\" compute should also change.(TrxType=3)");

                entity.Property(e => e.ProfitLossOrder).HasComment("Set the sub tab order under Profit & Loss tab. CDS - show Comparision, Details then Summary tab; blank or SDC - show Summary, Details then Comparision");

                entity.Property(e => e.ProvisionPrefix).HasComment("Define the Ref No Prefix for Provision Posting in glyl1");

                entity.Property(e => e.ReopenJobRight).HasComment("Set access right for Re-open Job button under Event Log tab. O - the access right ='U', then the User = the laste update by where statuscode='CLS' also can re-open the Job. A - Only access right = A can click re-open job buttom.");

                entity.Property(e => e.ShowAllInvoicePurchaseFlag).HasComment("If set as 'Y', then show the 'All Invoice' and 'All Payment' tab under the Document List. Those 2 tabs show all the ivcr1 and plvi1 where TrxType in ('1','2','3',3','4','5')");

                entity.Property(e => e.ShowBillingFlag).HasComment("If set as Y, then show on the Document List and only supervisor and above can tick the Billing Flag");

                entity.Property(e => e.ShowJobCostingRemarkFlag).HasComment("Set as Y, Show Job Costing Remark as a column instead of picture icon under Job Costing screen.");

                entity.Property(e => e.ShowSalesmanCostFlag).HasComment("Set as Y, Show Salesman Cost column and Salesman Cost button under Job Costing screen. Blank or N - hide them.");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UnuseField1).HasComment("NOT IN USE");

                entity.Property(e => e.UnuseField2).HasComment("NOT IN USE");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateCustomerFlag).HasComment("If set as Y, when insert the record to jmjm2, will update the Customer Code and Customer Name in Correspondence to jmjm2");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WipPostFlag)
                    .HasDefaultValueSql("('N')")
                    .HasComment("Set as Y, click WIP Post button under Daily Posting it will call the store procedure spi_Jm_Wip_Close");

                entity.Property(e => e.WipPrepaymentAccCode).HasComment("Set Acc Code for WIP in Job Costing");

                entity.Property(e => e.WipProvisionAccCode).HasComment("Set Acc Code for WIP in Job Costing");

                entity.Property(e => e.WipTradeCreditorAccCode).HasComment("Set Acc Code for WIP in Job Costing");

                entity.Property(e => e.WipTradeDebtorAccCode).HasComment("Set Acc Code for WIP in Job Costing");
            });

            modelBuilder.Entity<Jmpa2>(entity =>
            {
                entity.HasKey(e => new { e.UniqueKey, e.LineItemNo });

                entity.Property(e => e.UniqueKey).HasDefaultValueSql("(1)");

                entity.Property(e => e.LineItemNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Jmpa3>(entity =>
            {
                entity.HasKey(e => new { e.UniqueKey, e.LineItemNo });
            });

            modelBuilder.Entity<Jmpj1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Jmpt1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Jmrk1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Jmsc1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Jmsc2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Jmtn1>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.JobNo, e.LineItemNo });

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();

                entity.Property(e => e.AmendedFieldCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PermitCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.TotalLineCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateReqCount).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Jmtn2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Jmtn3>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Jmtn4>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo, e.CascLineItemNo, e.ProductLineItemNo });
            });

            modelBuilder.Entity<Jmtn6>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Jmtn8>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo })
                    .HasName("pk");
            });

            modelBuilder.Entity<Jmwo1>(entity =>
            {
                entity.HasKey(e => new { e.JobNo, e.LineItemNo })
                    .HasName("PK_Jmwo1");
            });

            modelBuilder.Entity<LoadingPort>(entity =>
            {
                entity.ToView("LoadingPort");
            });

            modelBuilder.Entity<Omdy1>(entity =>
            {
                entity.Property(e => e.TrxNo).ValueGeneratedNever();
            });

            modelBuilder.Entity<Omdy2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Omlc1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Ompa1>(entity =>
            {
                entity.HasKey(e => e.UniqueKey)
                    .IsClustered(false);

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UnlockOrderFlag).HasComment("If set as 'Y', then it will always unlock omtx1");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Omtx1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Omtx2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo })
                    .HasName("PK_Omtx2");

                entity.Property(e => e.PutAwayFlag).HasDefaultValueSql("('N')");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Omtx2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_omtx2_omtx1");
            });

            modelBuilder.Entity<Omtx3>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo })
                    .HasName("PK_Omtx3");
            });

            modelBuilder.Entity<Omtx4>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.SortNo });

                entity.Property(e => e.SortNo).ValueGeneratedOnAdd();

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<Omtx5>(entity =>
            {
                entity.Property(e => e.TrxNo).ValueGeneratedNever();
            });

            modelBuilder.Entity<Omtx6>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.HasOne(d => d.CurrCodeNavigation)
                    .WithMany(p => p.Omtx6s)
                    .HasForeignKey(d => d.CurrCode)
                    .HasConstraintName("FK_omtx6_glex1");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Omtx6s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_omtx6_omtx1");

                entity.HasOne(d => d.UomCodeNavigation)
                    .WithMany(p => p.Omtx6s)
                    .HasForeignKey(d => d.UomCode)
                    .HasConstraintName("FK_omtx6_rcum11");

                entity.HasOne(d => d.VatCodeNavigation)
                    .WithMany(p => p.Omtx6s)
                    .HasForeignKey(d => d.VatCode)
                    .HasConstraintName("FK_omtx6_acva11");
            });

            modelBuilder.Entity<Omtx7>(entity =>
            {
                entity.Property(e => e.TrxNo).ValueGeneratedNever();

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("(N'USE')");
            });

            modelBuilder.Entity<PlAccCostByJob>(entity =>
            {
                entity.ToView("pl_Acc_Cost_By_Job");
            });

            modelBuilder.Entity<PlAccPurcahseRecoverAcc>(entity =>
            {
                entity.ToView("pl_Acc_Purcahse_Recover_Acc");
            });

            modelBuilder.Entity<PlAccPurchase1>(entity =>
            {
                entity.ToView("pl_Acc_Purchase_1");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.ClearDate).IsFixedLength();

                entity.Property(e => e.CurrDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.InvoiceAndVatAmt).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.VatDate).IsFixedLength();
            });

            modelBuilder.Entity<PlAccPurchase2>(entity =>
            {
                entity.ToView("pl_Acc_Purchase_2");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PlAccPurchaseRecoverAccByRefNo>(entity =>
            {
                entity.ToView("Pl_Acc_Purchase_Recover_Acc_By_RefNo");
            });

            modelBuilder.Entity<PlAccPurchaseSummary>(entity =>
            {
                entity.ToView("pl_Acc_Purchase_Summary");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<PlAdvancePayment>(entity =>
            {
                entity.ToView("pl_Advance_Payment");
            });

            modelBuilder.Entity<PlAllActualCostByJob>(entity =>
            {
                entity.ToView("pl_All_Actual_Cost_By_Job");
            });

            modelBuilder.Entity<PlAllCashPurchaseByMasterJob>(entity =>
            {
                entity.ToView("pl_All_Cash_Purchase_By_Master_Job");
            });

            modelBuilder.Entity<PlAllCashPurchaseJob>(entity =>
            {
                entity.ToView("pl_All_Cash_Purchase_Job");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<PlAllCashPurchaseMasterJob>(entity =>
            {
                entity.ToView("pl_All_Cash_Purchase_Master_Job");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<PlAllCost2>(entity =>
            {
                entity.ToView("pl_All_Cost_2");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PlAllCostByJob>(entity =>
            {
                entity.ToView("pl_All_Cost_By_Job");
            });

            modelBuilder.Entity<PlAllCostByJobDate>(entity =>
            {
                entity.ToView("pl_All_Cost_By_Job_Date");
            });

            modelBuilder.Entity<PlAllCostByJobWithVatOutlay>(entity =>
            {
                entity.ToView("pl_All_Cost_By_Job_With_Vat_Outlay");
            });

            modelBuilder.Entity<PlAllCostByMasterJob>(entity =>
            {
                entity.ToView("pl_All_Cost_By_Master_Job");
            });

            modelBuilder.Entity<PlAllCostByMasterJobByItem>(entity =>
            {
                entity.ToView("pl_All_Cost_By_Master_Job_By_Item");
            });

            modelBuilder.Entity<PlAllCostDistribution>(entity =>
            {
                entity.ToView("pl_All_Cost_Distribution");
            });

            modelBuilder.Entity<PlAllCostWithCnByJob>(entity =>
            {
                entity.ToView("pl_All_Cost_With_Cn_By_Job");
            });

            modelBuilder.Entity<PlAllCostWithVatByJob>(entity =>
            {
                entity.ToView("pl_All_Cost_With_Vat_By_Job");
            });

            modelBuilder.Entity<PlAllNonCashPurchaseByJob>(entity =>
            {
                entity.ToView("pl_All_Non_Cash_Purchase_By_Job");
            });

            modelBuilder.Entity<PlAllNonCashPurchaseByMasterJob>(entity =>
            {
                entity.ToView("pl_All_Non_Cash_Purchase_By_Master_Job");
            });

            modelBuilder.Entity<PlAllNonCashPurchaseWithVatByJob>(entity =>
            {
                entity.ToView("pl_All_Non_Cash_Purchase_With_Vat_By_Job");
            });

            modelBuilder.Entity<PlAllNonCashPurchaseWithVatByMasterJob>(entity =>
            {
                entity.ToView("pl_All_Non_Cash_Purchase_With_Vat_By_Master_Job");
            });

            modelBuilder.Entity<PlAllPayment1>(entity =>
            {
                entity.ToView("pl_All_Payment_1");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PlAllPaymentSummary>(entity =>
            {
                entity.ToView("pl_All_Payment_Summary");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.PaymentDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<PlAllPaymentVoucherByJob>(entity =>
            {
                entity.ToView("pl_All_Payment_Voucher_By_Job");
            });

            modelBuilder.Entity<PlAllPaymentVoucherByMasterJob>(entity =>
            {
                entity.ToView("pl_All_Payment_Voucher_By_Master_Job");
            });

            modelBuilder.Entity<PlAllPaymentVoucherWithVatByJob>(entity =>
            {
                entity.ToView("pl_All_Payment_Voucher_With_Vat_By_Job");
            });

            modelBuilder.Entity<PlAllPaymentVoucherWithVatByMasterJob>(entity =>
            {
                entity.ToView("pl_All_Payment_Voucher_With_Vat_By_Master_Job");
            });

            modelBuilder.Entity<PlAllPurchase1>(entity =>
            {
                entity.ToView("pl_All_Purchase_1");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PlAllPurchase2>(entity =>
            {
                entity.ToView("pl_All_Purchase_2");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PlAllPurchase2ImportJob>(entity =>
            {
                entity.ToView("pl_All_Purchase_2_Import_Job");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<PlAllPurchase2NoProvision>(entity =>
            {
                entity.ToView("pl_All_Purchase_2_No_Provision");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<PlAllPurchaseByJob>(entity =>
            {
                entity.ToView("pl_All_Purchase_By_Job");
            });

            modelBuilder.Entity<PlAllPurchaseByJobItem>(entity =>
            {
                entity.ToView("pl_All_Purchase_By_Job_Item");
            });

            modelBuilder.Entity<PlAllPurchaseJob>(entity =>
            {
                entity.ToView("pl_All_Purchase_Job");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<PlAllPurchaseSummary>(entity =>
            {
                entity.ToView("pl_All_Purchase_Summary");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<PlAllPurchaseTransfer>(entity =>
            {
                entity.ToView("pl_All_Purchase_Transfer");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<PlAllPurchaseVat>(entity =>
            {
                entity.ToView("pl_All_Purchase_Vat");
            });

            modelBuilder.Entity<PlAllPurchaseWithVatByMasterJob>(entity =>
            {
                entity.ToView("pl_All_Purchase_With_Vat_By_Master_Job");
            });

            modelBuilder.Entity<PlAllTfcCostBySeaExportMasterJob>(entity =>
            {
                entity.ToView("pl_All_TFC_Cost_By_Sea_Export_Master_Job");
            });

            modelBuilder.Entity<PlCashPurchase1>(entity =>
            {
                entity.ToView("pl_Cash_Purchase_1");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PlCashPurchase2>(entity =>
            {
                entity.ToView("pl_Cash_Purchase_2");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<PlInvoicePaymentDate>(entity =>
            {
                entity.ToView("pl_Invoice_Payment_Date");
            });

            modelBuilder.Entity<PlSlTransaction>(entity =>
            {
                entity.ToView("pl_Sl_Transaction");

                entity.Property(e => e.AgeingDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();
            });

            modelBuilder.Entity<PlSlVat>(entity =>
            {
                entity.ToView("pl_Sl_Vat");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<PlVendorInvoice1>(entity =>
            {
                entity.ToView("pl_Vendor_Invoice_1");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.ClearDate).IsFixedLength();

                entity.Property(e => e.CurrDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.InvoiceAndVatAmt).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.VatDate).IsFixedLength();
            });

            modelBuilder.Entity<PlVendorInvoice2>(entity =>
            {
                entity.ToView("pl_Vendor_Invoice_2");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.ClearDate).IsFixedLength();

                entity.Property(e => e.CurrDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.InvoiceAndVatAmt).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.VatDate).IsFixedLength();
            });

            modelBuilder.Entity<PlVendorInvoiceByInvoice>(entity =>
            {
                entity.ToView("pl_Vendor_Invoice_By_Invoice");

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<PlVendorPayment1>(entity =>
            {
                entity.ToView("pl_Vendor_Payment_1");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.ClearDate).IsFixedLength();

                entity.Property(e => e.PaymentDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<PlVendorPayment2>(entity =>
            {
                entity.ToView("pl_Vendor_Payment_2");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.ClearDate).IsFixedLength();

                entity.Property(e => e.PaymentDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<Plaj1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PostFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");

                entity.HasOne(d => d.CurrCodeNavigation)
                    .WithMany(p => p.Plaj1s)
                    .HasForeignKey(d => d.CurrCode)
                    .HasConstraintName("FK_plaj1_glex1");
            });

            modelBuilder.Entity<Plcp1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(N'(suser_sname()')");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");

                entity.HasOne(d => d.CurrCodeNavigation)
                    .WithMany(p => p.Plcp1s)
                    .HasForeignKey(d => d.CurrCode)
                    .HasConstraintName("FK_plcp1_glex1");

                entity.HasOne(d => d.DivisionCodeNavigation)
                    .WithMany(p => p.Plcp1s)
                    .HasForeignKey(d => d.DivisionCode)
                    .HasConstraintName("FK_plcp1_acdv1");
            });

            modelBuilder.Entity<Plcp2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Plcp2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_plcp2_plcp1");
            });

            modelBuilder.Entity<Plcs1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CurrCodeNavigation)
                    .WithMany(p => p.Plcs1s)
                    .HasForeignKey(d => d.CurrCode)
                    .HasConstraintName("FK_plcs1_glex11");
            });

            modelBuilder.Entity<Plcs2>(entity =>
            {
                entity.Property(e => e.Amt).HasDefaultValueSql("((0))");

                entity.Property(e => e.AuditBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.AuditDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.LocalAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<Plhp1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Plpa1>(entity =>
            {
                entity.Property(e => e.AccruedPaymentAccCode).HasComment("Default the Account Code to the Payment Voucher when transferred to Account for the specified Accrued Voucher Type");

                entity.Property(e => e.AccruedVoucherType).HasComment("Specify the Voucher Type for the Payment need to change the account code during the Purchase Transfer");

                entity.Property(e => e.AdjustPrefix).HasComment("Define Ref No Prefix in plaj1");

                entity.Property(e => e.AdvanceAccCode).HasComment("Set Acc Code for Plvi1 Settlement button.");

                entity.Property(e => e.AppGenerateVoucherNoFlag).HasComment("Set as Y, plvi1 and Payment Voucher Approve screen not auto generate the voucher no when save. But when click Approve button;");

                entity.Property(e => e.AutoBalanceFlag).HasComment("if set as 'Y', then it will auto update plvi2 total amout to plvi1, if set as 'N' or leave blank, then use the old logic");

                entity.Property(e => e.AutoPostFlag).HasComment("If set as 'Y', it will call the post store prcedure auotmatically as long as the record exit the form if the record is not posted and not deleted");

                entity.Property(e => e.BankAccCode).HasComment("Default the Account Code in Cash Purchase and Vendor Payment when Bank Code is not specified");

                entity.Property(e => e.BankAccountMandatoryFlag).HasComment("Control");

                entity.Property(e => e.BankCode1).HasComment("Default the Bank Code for Voucher Type 1");

                entity.Property(e => e.BankCode10).HasComment("Default the Bank Code for Voucher Type 10");

                entity.Property(e => e.BankCode11).HasComment("Default the Bank Code for Voucher Type 11");

                entity.Property(e => e.BankCode12).HasComment("Default the Bank Code for Voucher Type 12");

                entity.Property(e => e.BankCode13).HasComment("Default the Bank Code for Voucher Type 13");

                entity.Property(e => e.BankCode14).HasComment("Default the Bank Code for Voucher Type 14");

                entity.Property(e => e.BankCode15).HasComment("Default the Bank Code for Voucher Type 15");

                entity.Property(e => e.BankCode16).HasComment("Default the Bank Code for Voucher Type 16");

                entity.Property(e => e.BankCode17).HasComment("Default the Bank Code for Voucher Type 17");

                entity.Property(e => e.BankCode18).HasComment("Default the Bank Code for Voucher Type 18");

                entity.Property(e => e.BankCode19).HasComment("Default the Bank Code for Voucher Type 19");

                entity.Property(e => e.BankCode2).HasComment("Default the Bank Code for Voucher Type 2");

                entity.Property(e => e.BankCode20).HasComment("Default the Bank Code for Voucher Type 20");

                entity.Property(e => e.BankCode3).HasComment("Default the Bank Code for Voucher Type 3");

                entity.Property(e => e.BankCode4).HasComment("Default the Bank Code for Voucher Type 4");

                entity.Property(e => e.BankCode5).HasComment("Default the Bank Code for Voucher Type 5");

                entity.Property(e => e.BankCode6).HasComment("Default the Bank Code for Voucher Type 6");

                entity.Property(e => e.BankCode7).HasComment("Default the Bank Code for Voucher Type 7");

                entity.Property(e => e.BankCode8).HasComment("Default the Bank Code for Voucher Type 8");

                entity.Property(e => e.BankCode9).HasComment("Default the Bank Code for Voucher Type 9");

                entity.Property(e => e.CashAdvanceAccCode01).HasComment("Click Expense Settlement button, it will default CashAdvanceAccCode01 to plvi2.AccCode base on the CashAdvanceType01");

                entity.Property(e => e.CashAdvanceAccCode02).HasComment("Click Expense Settlement button, it will default CashAdvanceAccCode02 to plvi2.AccCode base on the CashAdvanceType02");

                entity.Property(e => e.CashAdvanceAccCode03).HasComment("Click Expense Settlement button, it will default CashAdvanceAccCode03 to plvi2.AccCode base on the CashAdvanceType03");

                entity.Property(e => e.CashAdvanceAccCode04).HasComment("Click Expense Settlement button, it will default CashAdvanceAccCode04 to plvi2.AccCode base on the CashAdvanceType04");

                entity.Property(e => e.CashAdvanceAccCode05).HasComment("Click Expense Settlement button, it will default CashAdvanceAccCode05 to plvi2.AccCode base on the CashAdvanceType05");

                entity.Property(e => e.CashAdvanceAccCode06).HasComment("Click Expense Settlement button, it will default CashAdvanceAccCode06 to plvi2.AccCode base on the CashAdvanceType06");

                entity.Property(e => e.CashAdvanceAccCode07).HasComment("Click Expense Settlement button, it will default CashAdvanceAccCode07 to plvi2.AccCode base on the CashAdvanceType07");

                entity.Property(e => e.CashAdvanceAccCode08).HasComment("Click Expense Settlement button, it will default CashAdvanceAccCode08 to plvi2.AccCode base on the CashAdvanceType08");

                entity.Property(e => e.CashAdvanceAccCode09).HasComment("Click Expense Settlement button, it will default CashAdvanceAccCode09 to plvi2.AccCode base on the CashAdvanceType09");

                entity.Property(e => e.CashAdvanceAccCode10).HasComment("Click Expense Settlement button, it will default CashAdvanceAccCode10 to plvi2.AccCode base on the CashAdvanceType10");

                entity.Property(e => e.CashAdvanceItemCode).HasComment("");

                entity.Property(e => e.CashAdvanceItemCode01).HasComment("Click Complete Settlement button, it will default the CashAdvanceItemCode01 to plvi2 base on the CashAdvanceType01");

                entity.Property(e => e.CashAdvanceItemCode02).HasComment("Click Complete Settlement button, it will default the CashAdvanceItemCode01 to plvi2 base on the CashAdvanceType01");

                entity.Property(e => e.CashAdvanceItemCode03).HasComment("Click Complete Settlement button, it will default the CashAdvanceItemCode03 to plvi2 base on the CashAdvanceType03");

                entity.Property(e => e.CashAdvanceItemCode04).HasComment("Click Complete Settlement button, it will default the CashAdvanceItemCode04 to plvi2 base on the CashAdvanceType04");

                entity.Property(e => e.CashAdvanceItemCode05).HasComment("Click Complete Settlement button, it will default the CashAdvanceItemCode05 to plvi2 base on the CashAdvanceType05");

                entity.Property(e => e.CashAdvanceItemCode06).HasComment("Click Complete Settlement button, it will default the CashAdvanceItemCode06 to plvi2 base on the CashAdvanceType06");

                entity.Property(e => e.CashAdvanceItemCode07).HasComment("Click Complete Settlement button, it will default the CashAdvanceItemCode07 to plvi2 base on the CashAdvanceType07");

                entity.Property(e => e.CashAdvanceItemCode08).HasComment("Click Complete Settlement button, it will default the CashAdvanceItemCode08 to plvi2 base on the CashAdvanceType08");

                entity.Property(e => e.CashAdvanceItemCode09).HasComment("Click Complete Settlement button, it will default the CashAdvanceItemCode09 to plvi2 base on the CashAdvanceType09");

                entity.Property(e => e.CashAdvanceItemCode10).HasComment("Click Complete Settlement button, it will default the CashAdvanceItemCode10 to plvi2 base on the CashAdvanceType10");

                entity.Property(e => e.CashAdvanceType01).HasComment("Default Cash Advance Type");

                entity.Property(e => e.CashAdvanceType02).HasComment("Set CashAdvanceType02 for plvi1 Cash Advance");

                entity.Property(e => e.CashAdvanceType03).HasComment("Set CashAdvanceType03 for plvi1 Cash Advance");

                entity.Property(e => e.CashAdvanceType04).HasComment("Set CashAdvanceType04 for plvi1 Cash Advance");

                entity.Property(e => e.CashAdvanceType05).HasComment("Set CashAdvanceType05 for plvi1 Cash Advance");

                entity.Property(e => e.CashAdvanceType06).HasComment("Set CashAdvanceType06 for plvi1 Cash Advance");

                entity.Property(e => e.CashAdvanceType07).HasComment("Set CashAdvanceType07 for plvi1 Cash Advance");

                entity.Property(e => e.CashAdvanceType08).HasComment("Set CashAdvanceType08 for plvi1 Cash Advance");

                entity.Property(e => e.CashAdvanceType09).HasComment("Set CashAdvanceType09 for plvi1 Cash Advance");

                entity.Property(e => e.CashAdvanceType10).HasComment("Set CashAdvanceType10 for plvi1 Cash Advance");

                entity.Property(e => e.CashPrefix).HasComment("The Ref No. and Journal No. Prefix for the Cash Purchase");

                entity.Property(e => e.CashVendorCode).HasComment("Default the Vendor Code for the Cash Purchase without Vendor Code for Reporting");

                entity.Property(e => e.CheckChequePostFlag).HasComment("Set as Y,  check the Cheque No and Cheque Date is entered or not when post plvi1 record (TrxType=5,6)");

                entity.Property(e => e.CheckDuplicateItemFlag).HasComment("Set as Y, check the duplicate item code is entered for same job in plvi2.");

                entity.Property(e => e.CheckSalesFlag).HasComment("When entering the Item Code in Vendor Invoice or Cash Purchase, it will prompt user if the Sales is less than the Cost entered");

                entity.Property(e => e.CombineStatementFlag).HasComment("NOT IN USE");

                entity.Property(e => e.CompleteSettlementVoucherType).HasComment("Set Voucher Type for Complete Settlement screen.");

                entity.Property(e => e.CostAdjustFlag).HasComment("Y to show an Adjustment button in the Vendor Invoice to adjust the Local Invoice Amount");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditPrefix).HasComment("The Ref No. and Journal No. Prefix for the Vendor Invoice");

                entity.Property(e => e.CreditorAccCode).HasComment("Default Trade Creditor Account Code in Customer File");

                entity.Property(e => e.DefaultChequePostDate).HasComment("Set as Y, then the Voucher Date in Plcp1 and Payment Date in Plpm1 will default to ChequeDate");

                entity.Property(e => e.DefaultInvoiceDateFlag).HasComment("Set as 'J' to default the Invoice Date as Job Date, Set as 'B' to default the Invoice Date as blank which TrxType=1,2,3");

                entity.Property(e => e.DefaultSearchName).HasComment("If set as 'T', then default TrxNo. If set as 'J', then default Job No. If set as 'M', then default MAWB/Awb No in the combo box");

                entity.Property(e => e.EInvoiceItemCode).HasComment("E Invoice EDI");

                entity.Property(e => e.EditCostingButton).HasComment("Control which button to show under Edit screen(plvi2 edit button).  Can enter M,O,K or blank. Blank means show all.");

                entity.Property(e => e.EditVatBaseAmtFlag).HasComment("If set ‘N’, the system should disable ‘…’ button which nearby the Total Standard text box in plvi1");

                entity.Property(e => e.ExGainLossAccCode).HasComment("Default the Account Code for Foreign Exchange Difference");

                entity.Property(e => e.HideCostFlag).HasComment("Set as Y, hide the Local Amt filed in plvi1/2");

                entity.Property(e => e.HideOperationUnpostFlag).HasComment("Hide the Unpost button in Plvi1 in operation.\r\nIf set as 'A', then hide the Unpost button for all user\r\nIf set as 'S', then hide the Unpost button for access right ='S' and 'U'\r\nIf set as 'U', then hide the Unpost button for access right='U'");

                entity.Property(e => e.HidePaymentInfoFlag).HasComment("If set as 'Y', then hide the 'Invoice No', 'Hire Purchase Code' and ' Purchase Order No' in plvi1_5.");

                entity.Property(e => e.HideZeroProvisionFlag).HasComment("NOT IN USE IN NET SYSFREIGHT");

                entity.Property(e => e.HirePurchaseItemCode).HasComment("Define the HirePurchaseItemCode to plcp1");

                entity.Property(e => e.InvoiceTypeFlag).HasComment("Set as Y, it will show the Invoice Type on plvi1 screen. The value search from savl1");

                entity.Property(e => e.JobType1).HasComment("Default the Job Type for Voucher Type 1");

                entity.Property(e => e.JobType10).HasComment("Default the Job Type for Voucher Type 10");

                entity.Property(e => e.JobType11).HasComment("Default the Job Type for Voucher Type 11");

                entity.Property(e => e.JobType12).HasComment("Default the Job Type for Voucher Type 12");

                entity.Property(e => e.JobType13).HasComment("Default the Job Type for Voucher Type 13");

                entity.Property(e => e.JobType14).HasComment("Default the Job Type for Voucher Type 14");

                entity.Property(e => e.JobType15).HasComment("Default the Job Type for Voucher Type 15");

                entity.Property(e => e.JobType16).HasComment("Default the Job Type for Voucher Type 16");

                entity.Property(e => e.JobType17).HasComment("Default the Job Type for Voucher Type 17");

                entity.Property(e => e.JobType18).HasComment("Default the Job Type for Voucher Type 18");

                entity.Property(e => e.JobType19).HasComment("Default the Job Type for Voucher Type 19");

                entity.Property(e => e.JobType2).HasComment("Default the Job Type for Voucher Type 2");

                entity.Property(e => e.JobType20).HasComment("Default the Job Type for Voucher Type 20");

                entity.Property(e => e.JobType3).HasComment("Default the Job Type for Voucher Type 3");

                entity.Property(e => e.JobType4).HasComment("Default the Job Type for Voucher Type 4");

                entity.Property(e => e.JobType5).HasComment("Default the Job Type for Voucher Type 5");

                entity.Property(e => e.JobType6).HasComment("Default the Job Type for Voucher Type 6");

                entity.Property(e => e.JobType7).HasComment("Default the Job Type for Voucher Type 7");

                entity.Property(e => e.JobType8).HasComment("Default the Job Type for Voucher Type 8");

                entity.Property(e => e.JobType9).HasComment("Default the Job Type for Voucher Type 9");

                entity.Property(e => e.KeepOpPaymentFlag).HasComment("Set Y to keep the operation Payment Voucher after Purchase Transfer. N to delete the Payment Voucher after Purchase Transfer");

                entity.Property(e => e.LinkOpFlag).HasComment("If set as Y, it will check if Charge Item Code have Acc Code in Sepv1 and Sipv1");

                entity.Property(e => e.LockCloseJobFlag).HasComment("Set as Y, lock the plvi1 form (operation) when plvi1 job no status code is CLS. The plvi1 form(Account) only show message in top right.");

                entity.Property(e => e.LockDescriptionFlag).HasComment("Lock the Item Description when enter an item code");

                entity.Property(e => e.LockItemScreenFlag).HasComment("Set as Y, lock plvi2 grid(operation) grid.");

                entity.Property(e => e.LockPaidInvoiceFlag).HasComment("if set as Y, then the plpm2 amt will be locked when PaidInvoiceFlag=C,I or V");

                entity.Property(e => e.LockProvisionDateFlag).HasComment("if set as 'N',  then enter the Post Date in plvi1 for TrxType=0 will not need to check against the glpa1 currentPlperiod is the PostMth is closed");

                entity.Property(e => e.LockVendorNameFlag).HasComment("Lock the Vendor Name when enter the Vendor Code");

                entity.Property(e => e.MandatoryInvoiceNoFlag).HasComment("Set if the Invoice No. in Cash Purchase is mandatory");

                entity.Property(e => e.MultiCurrFlag).HasComment("Allow Multiple Currencies of the Invoice, Cash Purchase or Vendor Payment if the Currency Code is entered to the Bank Code");

                entity.Property(e => e.NextBatchNo).HasComment("When generate the EDI for AP, it will use the NextBatchNo and then update NextBatchNo+1");

                entity.Property(e => e.NextJournalNo).HasComment("Next Journal No to generate when posting");

                entity.Property(e => e.NextWithHoldingTaxNo).HasComment("Default the next running no. of the With Holding Tax in the Payment Voucher which Plvi4.VendorCode link Plvn1.VendorType=WHTVendorType");

                entity.Property(e => e.NextWithHoldingTaxNo1).HasComment("Default the next running no. of the With Holding Tax in the Payment Voucher which Plvi4.VendorCode link Plvn1.VendorType=WHTVendorType1");

                entity.Property(e => e.OriginalCurrRateFlag).HasComment("Default the original currency rate of the invoice when settlement of the invoice");

                entity.Property(e => e.PaymentAdjustFlag).HasComment("Y to show an Adjustment button in the Vendor Payment to adjust the Local Payment Amount");

                entity.Property(e => e.PostAccrualFlag).HasComment("Set Y when posting the Vendor Invoice or Cash Purchase, it will post the Accural Account Code to reverse the accural from Job Costing");

                entity.Property(e => e.PostDetailFlag).HasComment("Specify if the posting should update the Purchase Ledger to General Ledger with Detail. It works only when specify the posting by Batch");

                entity.Property(e => e.PostOnlineOrBatch).HasComment("O - Post directly to General Ledger, B - Post by Batch to Sales Journal and then post to General Ledger when posting End of Month");

                entity.Property(e => e.PostSumOfCostFlag).HasComment("Set as Y,  plvi1.InvoiceLocalAmt =Sum plvi2.LocalAmt + round up(plvi1.VatAmt x plvi1.CurrRate)");

                entity.Property(e => e.PromptDuplicateDocFlag).HasComment("If set as 'Y', then under the Document List if record is already on the list(it mean already been invoiced),  click New button will prompt user 'This Job has already been invoiced......' Just for TrxType=5");

                entity.Property(e => e.PromptNotifyFlag).HasComment("Send the message to Account when operation has prepared a Payment Voucher");

                entity.Property(e => e.ProvisionCostButtonFlag).HasComment("If set as ‘Y’, then click the ‘Cost’ button in plvi1(the TrxType<>’0’) change to pull from plvi2 where plvi1.TrxType=’0’(Provision Cost). It should filter the VendorCode and StatusCode<>’Del’.\r\n- when update the Provision Cost to Vendor Invoice (TrxType<>'0'), the Qty, UnitRate and CurrRate in Vendor Invoice should same as Provision Cost");

                entity.Property(e => e.ReceiptPrefix).HasComment("The Ref No. and Journal No. Prefix for the Vendor Payment");

                entity.Property(e => e.ReversePostOnlineOrBatch).HasComment("When Reverse Posting of the record in Purchase Ledger, O - delete the record in GL, B - insert the reversal entry in GL");

                entity.Property(e => e.RoundOffAccCode).HasComment("Default the Account Code for Rounding Difference");

                entity.Property(e => e.SettlementVoucherType).HasComment("Set Voucher Type for Settlement screen.");

                entity.Property(e => e.ShowAppVoucherFlag).HasComment("Set as Y, click PV button under plpm1 screen, the system will show record which StatusCode='APP'");

                entity.Property(e => e.ShowOperationPostFlag).HasComment("If set as 'U', then show the Post button in operation plvi1 for all user.If set as 'S', then show the Post button in operation plvi1 for access right ='S' or 'A'If set as  'A', then show the Post button in operation plvi1 for access right='A'.");

                entity.Property(e => e.ShowPvPostFlag).HasComment("If set as 'Y', then it will hide  the those records that are not posted in the Vendor Payment screen when user clicks on the “PV” button");

                entity.Property(e => e.ShowVatAmtFlag).HasComment("Set as Y, show Vat Amt column after Vat Code in plvi1,slcr1,plpm1 grid. the TotalVatAmt sum from level 2 VatAmt column.");

                entity.Property(e => e.ShowVendorBalanceFlag).HasComment("NOT IN USE IN NET SYSFREIGHT");

                entity.Property(e => e.SplitCostToTable).HasComment("Set as Y, click Split by in the Vendor Invoice, the system will call screen.");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.StopPaymentVoucherFlag).HasComment("The document list will check and stop user to enter any cost if the user has not entered any Sales Invoice for the Job");

                entity.Property(e => e.UnrealiseAccCode).HasComment("Set Acc Code for Currency Revalucation form to generate gljv1 record for AP.");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateVatFlag).HasComment("NOT IN USE IN NET SYSFREIGHT");

                entity.Property(e => e.UserDefine1).HasComment("NOT IN USE");

                entity.Property(e => e.UserDefine2).HasComment("NOT IN USE");

                entity.Property(e => e.UserDefine3).HasComment("NOT IN USE");

                entity.Property(e => e.VendorCodeLength).HasComment("Define the length of the Vendor Code when auto generate the vendor code exclude the first letter of the name");

                entity.Property(e => e.VoucherFormat).HasComment("PF - Prefix,S - Shipment Type,MM - Month,M - Single Month,YY - Year,Y - Single Year,SFX - Suffix");

                entity.Property(e => e.VoucherNo1).HasComment("Default the next voucher no. for voucher Type 1");

                entity.Property(e => e.VoucherNo10).HasComment("Default the next voucher no. for voucher Type 10");

                entity.Property(e => e.VoucherNo11).HasComment("Default the next voucher no. for voucher Type 11");

                entity.Property(e => e.VoucherNo12).HasComment("Default the next voucher no. for voucher Type 12");

                entity.Property(e => e.VoucherNo13).HasComment("Default the next voucher no. for voucher Type 13");

                entity.Property(e => e.VoucherNo14).HasComment("Default the next voucher no. for voucher Type 14");

                entity.Property(e => e.VoucherNo15).HasComment("Default the next voucher no. for voucher Type 15");

                entity.Property(e => e.VoucherNo16).HasComment("Default the next voucher no. for voucher Type 16");

                entity.Property(e => e.VoucherNo17).HasComment("Default the next voucher no. for voucher Type 17");

                entity.Property(e => e.VoucherNo18).HasComment("Default the next voucher no. for voucher Type 18");

                entity.Property(e => e.VoucherNo19).HasComment("Default the next voucher no. for voucher Type 19");

                entity.Property(e => e.VoucherNo2).HasComment("Default the next voucher no. for voucher Type 2");

                entity.Property(e => e.VoucherNo20).HasComment("Default the next voucher no. for voucher Type 20");

                entity.Property(e => e.VoucherNo3).HasComment("Default the next voucher no. for voucher Type 3");

                entity.Property(e => e.VoucherNo4).HasComment("Default the next voucher no. for voucher Type 4");

                entity.Property(e => e.VoucherNo5).HasComment("Default the next voucher no. for voucher Type 5");

                entity.Property(e => e.VoucherNo6).HasComment("Default the next voucher no. for voucher Type 6");

                entity.Property(e => e.VoucherNo7).HasComment("Default the next voucher no. for voucher Type 7");

                entity.Property(e => e.VoucherNo8).HasComment("Default the next voucher no. for voucher Type 8");

                entity.Property(e => e.VoucherNo9).HasComment("Default the next voucher no. for voucher Type 9");

                entity.Property(e => e.VoucherNoAutoManualFlag).HasComment("A - Auto Voucher No, M - Manual Voucher No , B - Both");

                entity.Property(e => e.VoucherType1).HasComment("Default Voucher Type 1");

                entity.Property(e => e.VoucherType10).HasComment("Default Voucher Type 10");

                entity.Property(e => e.VoucherType10AutoManualFlag).HasComment("Control generate Voucher No for Voucher Type 10. A - Auto Voucher No, M - Manual Voucher No , B - Both");

                entity.Property(e => e.VoucherType11).HasComment("Default Voucher Type 11");

                entity.Property(e => e.VoucherType11AutoManualFlag).HasComment("Control generate Voucher No for Voucher Type 11. A - Auto Voucher No, M - Manual Voucher No , B - Both");

                entity.Property(e => e.VoucherType12).HasComment("Default Voucher Type 12");

                entity.Property(e => e.VoucherType12AutoManualFlag).HasComment("Control generate Voucher No for Voucher Type 12. A - Auto Voucher No, M - Manual Voucher No , B - Both");

                entity.Property(e => e.VoucherType13).HasComment("Default Voucher Type 13");

                entity.Property(e => e.VoucherType13AutoManualFlag).HasComment("Control generate Voucher No for Voucher Type 13. A - Auto Voucher No, M - Manual Voucher No , B - Both");

                entity.Property(e => e.VoucherType14).HasComment("Default Voucher Type 14");

                entity.Property(e => e.VoucherType14AutoManualFlag).HasComment("Control generate Voucher No for Voucher Type 14. A - Auto Voucher No, M - Manual Voucher No , B - Both");

                entity.Property(e => e.VoucherType15).HasComment("Default Voucher Type 15");

                entity.Property(e => e.VoucherType15AutoManualFlag).HasComment("Control generate Voucher No for Voucher Type 15. A - Auto Voucher No, M - Manual Voucher No , B - Both");

                entity.Property(e => e.VoucherType16).HasComment("Default Voucher Type 16");

                entity.Property(e => e.VoucherType16AutoManualFlag).HasComment("Control generate Voucher No for Voucher Type 16. A - Auto Voucher No, M - Manual Voucher No , B - Both");

                entity.Property(e => e.VoucherType17).HasComment("Default Voucher Type 17");

                entity.Property(e => e.VoucherType17AutoManualFlag).HasComment("Control generate Voucher No for Voucher Type 17. A - Auto Voucher No, M - Manual Voucher No , B - Both");

                entity.Property(e => e.VoucherType18).HasComment("Default Voucher Type 18");

                entity.Property(e => e.VoucherType18AutoManualFlag).HasComment("Control generate Voucher No for Voucher Type 18. A - Auto Voucher No, M - Manual Voucher No , B - Both");

                entity.Property(e => e.VoucherType19).HasComment("Default Voucher Type 19");

                entity.Property(e => e.VoucherType19AutoManualFlag).HasComment("Control generate Voucher No for Voucher Type 19. A - Auto Voucher No, M - Manual Voucher No , B - Both");

                entity.Property(e => e.VoucherType1AutoManualFlag).HasComment("Control Voucher No for Voucher Type 1");

                entity.Property(e => e.VoucherType2).HasComment("Default Voucher Type 2");

                entity.Property(e => e.VoucherType20).HasComment("Default Voucher Type 20");

                entity.Property(e => e.VoucherType20AutoManualFlag).HasComment("Control generate Voucher No for Voucher Type 20. A - Auto Voucher No, M - Manual Voucher No , B - Both");

                entity.Property(e => e.VoucherType2AutoManualFlag).HasComment("Control generate Voucher No for Voucher Type 2. A - Auto Voucher No, M - Manual Voucher No , B - Both");

                entity.Property(e => e.VoucherType3).HasComment("Default Voucher Type 3");

                entity.Property(e => e.VoucherType3AutoManualFlag).HasComment("Control generate Voucher No for Voucher Type 1. A - Auto Voucher No, M - Manual Voucher No , B - Both");

                entity.Property(e => e.VoucherType4).HasComment("Default Voucher Type 4");

                entity.Property(e => e.VoucherType4AutoManualFlag).HasComment("Control generate Voucher No for Voucher Type 3. A - Auto Voucher No, M - Manual Voucher No , B - Both");

                entity.Property(e => e.VoucherType5).HasComment("Default Voucher Type 5");

                entity.Property(e => e.VoucherType5AutoManualFlag).HasComment("Control generate Voucher No for Voucher Type 5. A - Auto Voucher No, M - Manual Voucher No , B - Both");

                entity.Property(e => e.VoucherType6).HasComment("Default Voucher Type 6");

                entity.Property(e => e.VoucherType6AutoManualFlag).HasComment("Control generate Voucher No for Voucher Type 6. A - Auto Voucher No, M - Manual Voucher No , B - Both");

                entity.Property(e => e.VoucherType7).HasComment("Default Voucher Type 7");

                entity.Property(e => e.VoucherType7AutoManualFlag).HasComment("Control generate Voucher No for Voucher Type 7. A - Auto Voucher No, M - Manual Voucher No , B - Both");

                entity.Property(e => e.VoucherType8).HasComment("Default Voucher Type 8");

                entity.Property(e => e.VoucherType8AutoManualFlag).HasComment("Control generate Voucher No for Voucher Type 8. A - Auto Voucher No, M - Manual Voucher No , B - Both");

                entity.Property(e => e.VoucherType9).HasComment("Default Voucher Type 9");

                entity.Property(e => e.VoucherType9AutoManualFlag).HasComment("Control generate Voucher No for Voucher Type 9. A - Auto Voucher No, M - Manual Voucher No , B - Both");

                entity.Property(e => e.WholdTaxAccCode).HasComment("Default the Account Code of the With Holding Tax");

                entity.Property(e => e.WhtvendorType).HasComment("Define the VendorType (match plvi4.VendorCode link Plvn1.VendorType) to generate the WithHoldingTaxNo for Next With Holding Tax No");

                entity.Property(e => e.WhtvendorType1).HasComment("Define the VendorType (match plvi4.VendorCode link Plvn1.VendorType) to generate the WithHoldingTaxNo for Next With Holding Tax No 1");
            });

            modelBuilder.Entity<Plpm1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .IsClustered(false);

                entity.HasIndex(e => e.RefNo, "INDEX_plpm1_RefNo")
                    .IsClustered();

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PostFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.ReconcilFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Plpm2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Plpm3>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Plti1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Pltx1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");

                entity.HasOne(d => d.CurrCodeNavigation)
                    .WithMany(p => p.Pltx1s)
                    .HasForeignKey(d => d.CurrCode)
                    .HasConstraintName("FK_pltx1_glex1");
            });

            modelBuilder.Entity<PltxCheck>(entity =>
            {
                entity.ToView("PltxCheck");
            });

            modelBuilder.Entity<PltxCheck2>(entity =>
            {
                entity.ToView("PltxCheck2");
            });

            modelBuilder.Entity<Plvi1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .IsClustered(false);

                entity.HasIndex(e => e.RefNo, "INDEX_plvi1_RefNo")
                    .IsClustered();

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FaxCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.Guid).HasComment("E Invoice EDI");

                entity.Property(e => e.PostFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReconcilFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.TransferFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Plvi2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemTrxNo).ValueGeneratedOnAdd();

                entity.Property(e => e.SplitFlag).HasDefaultValueSql("(N'N')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Plvi2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_plvi2_plvi1");
            });

            modelBuilder.Entity<Plvi3>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Plvi4>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");
            });

            modelBuilder.Entity<Plvi5>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Plvi6>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.DetailLineItemNo, e.LineItemNo });

                entity.Property(e => e.ItemTrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Plvn1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_Plvn1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Plvn2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Plvn3>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Plvn4>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.AgeingDate });
            });

            modelBuilder.Entity<Plvt1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Plvx1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CurrCodeNavigation)
                    .WithMany(p => p.Plvx1s)
                    .HasForeignKey(d => d.CurrCode)
                    .HasConstraintName("FK_plvx1_glex1");
            });

            modelBuilder.Entity<Poev1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Popo1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_POPO2");

                entity.Property(e => e.Postatus).HasDefaultValueSql("(N'Draft')");
            });

            modelBuilder.Entity<Popo2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo })
                    .HasName("PK_Popo2_1");
            });

            modelBuilder.Entity<Popo3>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.Property(e => e.StatusCode).HasDefaultValueSql("(N'USE')");
            });

            modelBuilder.Entity<PortCode>(entity =>
            {
                entity.ToView("PortCodes");
            });

            modelBuilder.Entity<PowerLevel>(entity =>
            {
                entity.HasKey(e => new { e.LRoleId, e.SFunNo, e.LSubId });
            });

            modelBuilder.Entity<RcAirportCode>(entity =>
            {
                entity.ToView("rc_Airport_Code");
            });

            modelBuilder.Entity<RcShippingLine>(entity =>
            {
                entity.ToView("rc_Shipping_Line");
            });

            modelBuilder.Entity<Rcal1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcam1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcap1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcbo1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcbp1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Rcbp11>(entity =>
            {
                entity.HasKey(e => new { e.BusinessPartyCode, e.LineItemNo });

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcbp12>(entity =>
            {
                entity.HasKey(e => new { e.BusinessPartyCode, e.LineItemNo, e.Year })
                    .HasName("PK_rcbp12");
            });

            modelBuilder.Entity<Rcbp2>(entity =>
            {
                entity.HasKey(e => new { e.BusinessPartyCode, e.LineItemNo });
            });

            modelBuilder.Entity<Rcbp3>(entity =>
            {
                entity.HasKey(e => new { e.BusinessPartyCode, e.LineItemNo });
            });

            modelBuilder.Entity<Rcbp4>(entity =>
            {
                entity.HasKey(e => new { e.BusinessPartyCode, e.LineItemNo });
            });

            modelBuilder.Entity<Rcbp6>(entity =>
            {
                entity.HasKey(e => new { e.BusinessPartyCode, e.LineItemNo });
            });

            modelBuilder.Entity<Rcbp7>(entity =>
            {
                entity.HasKey(e => new { e.BusinessPartyCode, e.LineItemNo });
            });

            modelBuilder.Entity<Rcbp8>(entity =>
            {
                entity.HasKey(e => new { e.BusinessPartyCode, e.LineItemNo });
            });

            modelBuilder.Entity<Rcbp9>(entity =>
            {
                entity.HasKey(e => new { e.BusinessPartyCode, e.LineItemNo });
            });

            modelBuilder.Entity<Rcbt1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcbx1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcbx2>(entity =>
            {
                entity.HasOne(d => d.BoxCodeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.BoxCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rcbx2_rcbx1");
            });

            modelBuilder.Entity<Rccc1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_Rccc1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rccd1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rccf1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rccf2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Rccm1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcco1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcct1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rccy1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rccy2>(entity =>
            {
                entity.HasKey(e => new { e.CountryCode, e.LineItemNo });
            });

            modelBuilder.Entity<Rccy3>(entity =>
            {
                entity.HasKey(e => new { e.CountryCode, e.LineItemNo });
            });

            modelBuilder.Entity<Rcdc1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcdg1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_Rcdg1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcdl1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcdp1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rchc1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rchd1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GatewayCode).IsFixedLength();

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcit1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcla1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcnt1>(entity =>
            {
                entity.HasKey(e => e.Network)
                    .IsClustered(false);

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcpb1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcpc1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcpm1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcpt1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcsl1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcsm1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AreaCodeNavigation)
                    .WithMany(p => p.Rcsm1s)
                    .HasForeignKey(d => d.AreaCode)
                    .HasConstraintName("FK_rcsm1_acar1");

                entity.HasOne(d => d.DivisionCodeNavigation)
                    .WithMany(p => p.Rcsm1s)
                    .HasForeignKey(d => d.DivisionCode)
                    .HasConstraintName("FK_rcsm1_acdv1");
            });

            modelBuilder.Entity<Rcsp1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcsp2>(entity =>
            {
                entity.HasKey(e => new { e.PortCode, e.LineItemNo });
            });

            modelBuilder.Entity<Rctc1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_Rctc1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rctl1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcum1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcun1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcvs1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcvy1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rcvy2>(entity =>
            {
                entity.HasKey(e => new { e.VoyageId, e.LineItemNo });
            });

            modelBuilder.Entity<RoleInfo>(entity =>
            {
                entity.Property(e => e.LId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RolePerson>(entity =>
            {
                entity.HasKey(e => new { e.LRoleId, e.LUserId });
            });

            modelBuilder.Entity<SaDatabaseColumnName>(entity =>
            {
                entity.ToView("sa_Database_Column_Name");

                entity.Property(e => e.Tdscollation).IsFixedLength();
            });

            modelBuilder.Entity<SaDatabaseComment>(entity =>
            {
                entity.ToView("sa_Database_Comment");
            });

            modelBuilder.Entity<SaDatabaseConstraintName>(entity =>
            {
                entity.ToView("sa_Database_Constraint_Name");
            });

            modelBuilder.Entity<SaDatabaseIndex>(entity =>
            {
                entity.ToView("sa_Database_Index");

                entity.Property(e => e.First).IsFixedLength();

                entity.Property(e => e.FirstIam).IsFixedLength();

                entity.Property(e => e.Root).IsFixedLength();
            });

            modelBuilder.Entity<SaDatabaseIndexCheck>(entity =>
            {
                entity.ToView("sa_Database_Index_Check");
            });

            modelBuilder.Entity<SaDatabaseObjectName>(entity =>
            {
                entity.ToView("sa_Database_Object_Name");

                entity.Property(e => e.Type).IsFixedLength();

                entity.Property(e => e.Xtype).IsFixedLength();
            });

            modelBuilder.Entity<SaDatabasePrimaryKey>(entity =>
            {
                entity.ToView("sa_Database_Primary_Key");
            });

            modelBuilder.Entity<SaSystemField>(entity =>
            {
                entity.ToView("sa_System_Field");

                entity.Property(e => e.Tdscollation).IsFixedLength();
            });

            modelBuilder.Entity<SaUserLog>(entity =>
            {
                entity.ToView("sa_User_Log");
            });

            modelBuilder.Entity<Saaa1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Saal1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Sabr1>(entity =>
            {
                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");
            });

            modelBuilder.Entity<Sacb1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Saco1>(entity =>
            {
                entity.Property(e => e.CompanyCode).HasComment("Company Code of the Company");

                entity.Property(e => e.AccPostProgram).HasComment("Just for AutoCountEDI");

                entity.Property(e => e.Address1).HasComment("Company Addredss 1");

                entity.Property(e => e.Address2).HasComment("Company Addredss 2");

                entity.Property(e => e.Address3).HasComment("Company Addredss 3");

                entity.Property(e => e.Address4).HasComment("Company Addredss 4");

                entity.Property(e => e.AirAddress1).HasComment("Company Air Office Address 1. To print on Air Freight related Document. If leave blank, system will take Company Address 1");

                entity.Property(e => e.AirAddress2).HasComment("Company Air Office Address 2. To print on Air Freight related Document. If leave blank, system will take Company Address 2");

                entity.Property(e => e.AirAddress3).HasComment("Company Air Office Address 3. To print on Air Freight related Document. If leave blank, system will take Company Address 3");

                entity.Property(e => e.AirAddress4).HasComment("Company Air Office Address 4. To print on Air Freight related Document. If leave blank, system will take Company Address 4");

                entity.Property(e => e.AirCityCode).HasComment("Company Air Office city code");

                entity.Property(e => e.AirCityName).HasComment("Company Air Office city name");

                entity.Property(e => e.AirContactName).HasComment("Company Air Office contact name");

                entity.Property(e => e.AirCountryCode).HasComment("Company Air Office country code");

                entity.Property(e => e.AirEmail).HasComment("Company Air Office email");

                entity.Property(e => e.AirFax).HasComment("Company Air Office fax no");

                entity.Property(e => e.AirPostalCode).HasComment("Company Air Office postal code");

                entity.Property(e => e.AirTelephone).HasComment("Company Air Office telephone no");

                entity.Property(e => e.AlertFlag).HasComment("If set as 'Y', then the system will the user to change the Tradenet password one week before the password expires when login to system.");

                entity.Property(e => e.Announcement).HasComment("Define the Announcement tab in Memo");

                entity.Property(e => e.ArchiveDatabaseFlag).HasComment("If set as 'Y' then New, Edit, Delete all disabled for all forms. When login to the system, it will auto prompt the message ‘ This database was archived. You can view only!’");

                entity.Property(e => e.AttachmentLimit).HasComment("Define the limit of the attachment size");

                entity.Property(e => e.AuditLogFlag)
                    .HasDefaultValueSql("('Y')")
                    .HasComment("Control if system should generate the Audit Log file");

                entity.Property(e => e.AutoGenerateFlag).HasComment("If set as 'N', then the check box of Auto Generate will default as unticked on the Update Customer/Update Vendor button screen in rcbp1.");

                entity.Property(e => e.AutoSearchByName).HasComment("Define which table auto search by Name instead of Code. if set as 'rcbp1, acit1', then for Business Party (rcbp) and Charge Item(acit1) auto search by name");

                entity.Property(e => e.BackupPath).HasComment("Alternate Backup Path");

                entity.Property(e => e.BranchName).HasComment("Barch Office Name");

                entity.Property(e => e.BusinessPartyFormat).HasComment("if set as 3,2,2, System will take first 3 letters from first name, 2 letters from 2nd name and 2 letters from 3rd name\r\nSYSMAGIC SOFTWARE SOLUTION PTE LTD will become SYSSOSO  in business party code\r\nIf there is already exist SYSSOSO in rcbp1 then it will SYSSOSO01,….. also add CT and CY. so that it can take the CityCode or CountryCode from rcbp1 to be part of the Business Party Code. e.g. 3,CT,CY,then it will update SYSMAGIC  as SYSSINSG. If this is setup, it will overwrite the Next Business Party No logic");

                entity.Property(e => e.CargoCommodityFlag).HasComment("Sea Module Cargo Info Tab Commodity from Level1 or Level 2 , Y is Level2");

                entity.Property(e => e.CheckProjectWebSite).HasComment("NOT IN USE");

                entity.Property(e => e.CityCode).HasComment("City code of the Company");

                entity.Property(e => e.CityName).HasComment("City name of the Company");

                entity.Property(e => e.ColorCode).HasComment("not in used");

                entity.Property(e => e.CommonDatabase).HasComment("Set as Y if there are common database for the reference table");

                entity.Property(e => e.CompanyName).HasComment("Company Name need to match with the Licence Key");

                entity.Property(e => e.ContactName).HasComment("Contact Name of the Company");

                entity.Property(e => e.ContainerTrackingFlag).HasComment("if det as 'Y', then when create new sebk1/sebl1 should insert the record to 'Ctri1' and 'Ctro1'. The 'Release Order No' should be the same as the Sebk1/Sebl1 Booking No.");

                entity.Property(e => e.CosacAgentCode).HasComment("When do the FHLMessage, the COSAC Agent Code pull from this field");

                entity.Property(e => e.CountryCode).HasComment("Country Code of the Company");

                entity.Property(e => e.CrNoName).HasComment("Define the Cr No Name in slcu1, plvn1 and saco1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode).HasComment("Local Currency Code using in report");

                entity.Property(e => e.DocumentLocalPathFlag).HasComment("");

                entity.Property(e => e.DocumentPath).HasComment("If the value is d:\\sysfreight\\doc then the system has to attach the document follow the path name. If the value is blank then use back old logic");

                entity.Property(e => e.EDocumentPath).HasComment("When click the button 'Insert eDoc' on the Attachment screen, it will attach the docment to the eDocument path. The path of document for print on the Mobile App.");

                entity.Property(e => e.Edinumber).HasComment("for FWB Message");

                entity.Property(e => e.EdirecipientId).HasComment("for FWB Message");

                entity.Property(e => e.EffectiveDate).HasComment("NOT IN USE");

                entity.Property(e => e.Email).HasComment("Company email address");

                entity.Property(e => e.EtrackAddress).HasComment("the URL of eTrack. If blank, then hardcode as http://sysfreight.net:8081/eTrack");

                entity.Property(e => e.ExpiryDate).HasComment("NOT IN USE");

                entity.Property(e => e.Fax).HasComment("Company fax No.");

                entity.Property(e => e.FontBold).HasComment("If set as 'Y', then set the font as bold in system.");

                entity.Property(e => e.FontSize).HasComment("Define the font size except the grid");

                entity.Property(e => e.FreightDatabase).HasComment("use for CTS");

                entity.Property(e => e.FwbMessageFlag).HasComment("Set Y if customer has the FWB interface");

                entity.Property(e => e.GridFontSize).HasComment("Define the font size in the grid");

                entity.Property(e => e.HideSubMasterFlag).HasComment("NOT IN USE");

                entity.Property(e => e.IataAgentCode).HasComment("IATA Agent Code of the Company");

                entity.Property(e => e.ItemCodeLength).HasComment("Define the length of ItemCode when auto generate the Item Code");

                entity.Property(e => e.LockAccCodeFlag).HasComment("If set as 'Y', then it will lock the Account Code on the Update Customer / Update Vendor button screen in rcbp1. The Account Code will pull from slct1/plvt1.AccCode base on the CustomerType / VendorType");

                entity.Property(e => e.LockBusinessPartyFlag).HasComment("Lock the customer to add/edit Business Party from other form entries");

                entity.Property(e => e.LockBusinessPartyInfoFlag).HasComment("Lock the Business Info tab in Business Party form when Customer or Vendor Code is entered.\r\nSet as U, if the access right =U, then it will be locked\r\nSet as S, if the access right = S or U, then it will be locked\r\nSet as A, then it will be locked for all users.");

                entity.Property(e => e.LockReferenceFlag).HasComment("Lock the customer to add/edit Business Party from other forms");

                entity.Property(e => e.LoginMessage).HasComment("Prompt user when login to the system");

                entity.Property(e => e.LongVesselCodeFlag).HasComment("Set the vessel code same as vessel name 50 characters");

                entity.Property(e => e.MobileAppAddress).HasComment("the URL of Mobile App. If blank, then hardcode as http://www.sysfreight.net:8081/mobileapp");

                entity.Property(e => e.MultipleDatabaseName).HasComment("It will enter the database name with comma separator for multiple database e.g. abcfreight, netfreight. Then it will show a combo box to show the database name from MultipleDatabaseName so the Look for can search record across database");

                entity.Property(e => e.NextBatchNo).HasComment("When generate the EDI, for AR,AP and FM. It will use the NextBatchNo and then it will update the NextBatchNo+1. Remember only completed the file generation then +1");

                entity.Property(e => e.NextBusinessPartyNo).HasComment("Next Auto Generate No. for Business Party");

                entity.Property(e => e.NoOfTabOpen).HasComment("Limit the user open the no. of tab, except the User ID=S");

                entity.Property(e => e.OfficeAirportCode).HasComment("for FWB Message");

                entity.Property(e => e.OfficeDesignator).HasComment("for FWB Message");

                entity.Property(e => e.OfficeFunctionDesignation).HasComment("for FWB Message");

                entity.Property(e => e.PostalCode).HasComment("postal code of the Company");

                entity.Property(e => e.RegistrationNo).HasComment("Company Registry No. of the Company");

                entity.Property(e => e.RenameEnglishLabelFlag).HasComment("control whether for language = English, needs to read from the Multiple Language table. If language is English and the RenameEnglishLabelFlag = \"N\" or blank, do not need to read the Multiple Language table");

                entity.Property(e => e.ReportPath).HasComment("Alternate Report Path");

                entity.Property(e => e.SalesmanCodeAccessRight).HasComment("if set A,S and U so in rcbp1 the SalesmanCode will be disabled (F4 also) by user right of the user. i.e. A will be A can enter only, S will be S and A, U all user can enter.");

                entity.Property(e => e.SeaAddress1).HasComment("Company Sea Office Address 1. To print on Sea Freight related document. If leave blank, system will take Company Address 1");

                entity.Property(e => e.SeaAddress2).HasComment("Company Sea Office Address 2. To print on Sea Freight related document. If leave blank, system will take Company Address 2");

                entity.Property(e => e.SeaAddress3).HasComment("Company Sea Office Address 3. To print on Sea Freight related document. If leave blank, system will take Company Address 3");

                entity.Property(e => e.SeaAddress4).HasComment("Company Sea Office Address 4. To print on Sea Freight related document. If leave blank, system will take Company Address 4");

                entity.Property(e => e.SeaCityCode).HasComment("Company Sea Office city code");

                entity.Property(e => e.SeaCityName).HasComment("Company Sea Office city name");

                entity.Property(e => e.SeaContactName).HasComment("Company Sea Office contact name");

                entity.Property(e => e.SeaCountryCode).HasComment("Company Sea Office country code");

                entity.Property(e => e.SeaEmail).HasComment("Company Sea Office email");

                entity.Property(e => e.SeaFax).HasComment("Company Sea Office fax no");

                entity.Property(e => e.SeaPostalCode).HasComment("Company Sea Office postal code");

                entity.Property(e => e.SeaTelephone).HasComment("Company Sea Office telephone no");

                entity.Property(e => e.SenderAirportCode).HasComment("for FWB Message");

                entity.Property(e => e.SenderFileReference).HasComment("for FWB Message");

                entity.Property(e => e.SenderParticipantCode).HasComment("for FWB Message");

                entity.Property(e => e.SenderParticipantId).HasComment("for FWB Message");

                entity.Property(e => e.SetCurrRateDecPlace).HasComment("Define the decimal for curr rate. e.g set 1, then the curr rate should be 1 decimal; if don’t set or blank or null, the system keep old logic.");

                entity.Property(e => e.SetUnitRateDecPlace).HasComment("Define the decimal for unit rate. e.g set 1, then the unit rate should be 1 decimal; if don’t set or blank or null, the system keep old logic.");

                entity.Property(e => e.ShowHeaderInfoFlag).HasComment("If set as 'Y', then the Telephone/Fax/Website/Email/RegistrationNo from saco1 will show on the report when header is ticked in sapp1");

                entity.Property(e => e.ShowMesflag).HasComment("If set as 'Y', the MES button will appear in the Job entry");

                entity.Property(e => e.ShowPlaceFlag).HasComment("If Set as Y, then show Place in below forms (include the Place under delivery). If blank or N, don’t show.");

                entity.Property(e => e.ShowUserGroupFlag).HasComment("In the Cost Button screen in ivcr1 and plvi1 , if User Group is Y in saco1, the filter (click show all or multiple job or show house) need to show the same User Group as ivcr1.JobNo and plvi1.JobNo.");

                entity.Property(e => e.SiteCode).HasComment("Site Code of the Company. Default as FREIGHT");

                entity.Property(e => e.SqlTimeOut).HasComment("Set SQL time Out. Default is 999");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.SysmagicPicName).HasComment("the picture of the main menu background");

                entity.Property(e => e.SystemUpgradeFlag).HasComment("If set as 'Y', then if there is the new version, it will auto update to version.");

                entity.Property(e => e.TabWidth).HasComment("control tab Width ,if TabWidth=0 or blank , use current width");

                entity.Property(e => e.Telephone).HasComment("Telephone of the Company");

                entity.Property(e => e.TimerFlag).HasComment("if set as 'Y', then the reminder in Message, Note and Reminder will check if there is the reminder and prompt user.");

                entity.Property(e => e.TimerInterval).HasComment("Set the time interval for the Notification in Minute");

                entity.Property(e => e.TradenetFlag).HasComment("If Y the Tradenet button will appear in the Job entry");

                entity.Property(e => e.TradenetUrl).HasComment("Define the URL of the Tradenet");

                entity.Property(e => e.TradenetVersion).HasComment("Default the Tradenet version");

                entity.Property(e => e.TransportAddress1).HasComment("Company Transport Office Address 1. To print on Transport related document. If leave blank, system will take Company Address 1");

                entity.Property(e => e.TransportAddress2).HasComment("Company Transport Office Address 2. To print on Transport related document. If leave blank, system will take Company Address 2");

                entity.Property(e => e.TransportAddress3).HasComment("Company Transport Office Address 3. To print on Transport related document. If leave blank, system will take Company Address 3");

                entity.Property(e => e.TransportAddress4).HasComment("Company Transport Office Address 4. To print on Transport related document. If leave blank, system will take Company Address 4");

                entity.Property(e => e.TransportCityCode).HasComment("Company Transport Office city code");

                entity.Property(e => e.TransportCityName).HasComment("Company Transport Office city name");

                entity.Property(e => e.TransportContactName).HasComment("Company Transport Office contact name");

                entity.Property(e => e.TransportCountryCode).HasComment("Company Transport Office country code");

                entity.Property(e => e.TransportEmail).HasComment("Company Transport Office email");

                entity.Property(e => e.TransportFax).HasComment("Company Transport Office fax no");

                entity.Property(e => e.TransportPostalCode).HasComment("Company Transport Office postal code");

                entity.Property(e => e.TransportTelephone).HasComment("Company Transport Office telephone no");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateCustomerFlag).HasComment("Set N to hide the Update Customer button in Business Party\r\nSet A only User Access is A can see Update Customer button in Business Party\r\nSet S only User Access is A & S can see Update Customer button in Business Party\r\nSet U or leave blank, all user can see Update Customer button in Business Party");

                entity.Property(e => e.UpdateCustomerProgram).HasComment("Just for AutoCountEDI");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateVendorFlag).HasComment("Set N to hide the Update Vendor button in Business Party\r\nSet A only User Access is A can see Update Vendor button in Business Party\r\nSet S only User Access is A & S can see Update Vendor button in Business Party\r\nSet U or leave blank, all user can see Update Vendor button in Business Party");

                entity.Property(e => e.UpdateVendorProgram).HasComment("Just for AutoCountEDI");

                entity.Property(e => e.UpperCaseFlag).HasComment("If set as ‘Y’ and leave blank, then keep current logic, if set as ‘N’, then when enter the value , the system should not auto change to upper case.\r\nThe Sepa1.UpperCaseFlag is higher than saco1.UpperCaseFlag\r\nFor parameter file include grid should not auto cap. It should always use normal letter");

                entity.Property(e => e.UserLicenceKey).HasComment("Enter the SysFreight Licence Key");

                entity.Property(e => e.UserPath).HasComment("NOT IN USE");

                entity.Property(e => e.VatName).HasComment("Alternate name of the Tax Code e.g GST for Singaport");

                entity.Property(e => e.VatRegistrationNo).HasComment("Tax Registration No.of the Company");

                entity.Property(e => e.WebSite).HasComment("Company Website");

                entity.Property(e => e.WhAddress1).HasComment("Company Warehouse Office Address 1. To print on Warehouse related document. If leave blank, system will take Company Address 1");

                entity.Property(e => e.WhAddress2).HasComment("Company Warehouse Office Address 2. To print on Warehouse related document. If leave blank, system will take Company Address 2");

                entity.Property(e => e.WhAddress3).HasComment("Company Warehouse Office Address 3. To print on Warehouse related document. If leave blank, system will take Company Address 3");

                entity.Property(e => e.WhAddress4).HasComment("Company Warehouse Office Address 4. To print on Warehouse related document. If leave blank, system will take Company Address 4");

                entity.Property(e => e.WhCityCode).HasComment("Company Warehouse Office city code");

                entity.Property(e => e.WhCityName).HasComment("Company Warehouse Office city name");

                entity.Property(e => e.WhContactName).HasComment("Company Warehouse Office contact name");

                entity.Property(e => e.WhCountryCode).HasComment("Company Warehouse Office country code");

                entity.Property(e => e.WhEmail).HasComment("Company Warehouse Office email");

                entity.Property(e => e.WhFax).HasComment("Company Warehouse Office fax no");

                entity.Property(e => e.WhPostalCode).HasComment("Company Warehouse Office postal code");

                entity.Property(e => e.WhTelephone).HasComment("Company Warehouse Office telephone no");
            });

            modelBuilder.Entity<Saco2>(entity =>
            {
                entity.HasKey(e => new { e.CompanyCode, e.LineItemNo })
                    .HasName("PK_Saco2");
            });

            modelBuilder.Entity<Saco3>(entity =>
            {
                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Saco4>(entity =>
            {
                entity.Property(e => e.DatabaseName).HasComment("Show on find now database name");

                entity.Property(e => e.ConnectionString).HasComment("web service connection : \"Web Service, Database\" or \"Web Service, Database, Login User, Password\"\r\nDatabase=web.config database name");
            });

            modelBuilder.Entity<Saco5>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK__saco5__BBFC386021734473");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Sadl1>(entity =>
            {
                entity.HasKey(e => e.ListNo)
                    .HasName("PK_Sadl1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Sadl2>(entity =>
            {
                entity.HasKey(e => new { e.ListNo, e.LineItemNo })
                    .HasName("PK_Sadl2");
            });

            modelBuilder.Entity<Saed1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_Saed1");
            });

            modelBuilder.Entity<Saed2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo })
                    .HasName("PK_Saed2");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Sael1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_Sael1");

                entity.Property(e => e.AutoFlag).HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<Saem1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Saem2>(entity =>
            {
                entity.HasKey(e => new { e.EmpolyeeNo, e.LineItemNo });
            });

            modelBuilder.Entity<Safm1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Safr1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Safr2>(entity =>
            {
                entity.HasKey(e => new { e.FreightCompanyCode, e.LineItemNo })
                    .HasName("PK_Safr2");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Sahd1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Samt1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_Samt1");
            });

            modelBuilder.Entity<Sanm1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Sanm2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.Year });
            });

            modelBuilder.Entity<Sant1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_Sant1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Sapb1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_saab1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Sapl1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Sapp1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MgmtReportFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Sapp3>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Sapp4>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.PrimaryKeyName, e.PrimaryKeyValue });
            });

            modelBuilder.Entity<Sapp5>(entity =>
            {
                entity.Property(e => e.TrxNo).ValueGeneratedNever();
            });

            modelBuilder.Entity<Sapp6>(entity =>
            {
                entity.Property(e => e.TrxNo).ValueGeneratedNever();
            });

            modelBuilder.Entity<Sard1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Sarl1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Sarm1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Sarn1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_Sarn1_1");
            });

            modelBuilder.Entity<Sasc1>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Satb1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Satb2>(entity =>
            {
                entity.HasKey(e => new { e.TableId, e.FieldName });

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<Satp1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Saug1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LId).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Saus1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsAccountLocked).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsAdministrator).HasDefaultValueSql("((0))");

                entity.Property(e => e.MsgReminderTime).HasDefaultValueSql("((15))");

                entity.Property(e => e.ReminderTime).HasDefaultValueSql("('Y')");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserEmail).HasDefaultValueSql("('UserEmail')");

                entity.Property(e => e.UserFullName).HasDefaultValueSql("('UserFullName')");
            });

            modelBuilder.Entity<Saus10>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Saus11>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Saus2>(entity =>
            {
                entity.Property(e => e.AccessFlag).HasDefaultValueSql("('Y')");

                entity.Property(e => e.AddFlag).HasDefaultValueSql("('Y')");

                entity.Property(e => e.DeleteFlag).HasDefaultValueSql("('Y')");

                entity.Property(e => e.EditFlag).HasDefaultValueSql("('Y')");

                entity.Property(e => e.RemarkFlag).HasDefaultValueSql("('Y')");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();

                entity.Property(e => e.UndeleteFlag).HasDefaultValueSql("('Y')");

                entity.Property(e => e.ViewFlag).HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<Saus4>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_Saus4");
            });

            modelBuilder.Entity<Saus6>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LineItemNo });
            });

            modelBuilder.Entity<Saus8>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.UserId });
            });

            modelBuilder.Entity<Saus9>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.UserGroup })
                    .HasName("PK_Saus9");
            });

            modelBuilder.Entity<Savl1>(entity =>
            {
                entity.HasKey(e => new { e.LineItemNo, e.TableName, e.FieldName });
            });

            modelBuilder.Entity<Sawf1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Workstation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Sawf2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<SeAllInternalBillingByMasterJob>(entity =>
            {
                entity.ToView("se_All_Internal_Billing_By_Master_Job");
            });

            modelBuilder.Entity<SeBlConsolidation>(entity =>
            {
                entity.ToView("se_Bl_Consolidation");

                entity.Property(e => e.Eta).IsFixedLength();

                entity.Property(e => e.Etd).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();
            });

            modelBuilder.Entity<SeBlPreparation>(entity =>
            {
                entity.ToView("se_Bl_Preparation");

                entity.Property(e => e.BlIssueDate).IsFixedLength();

                entity.Property(e => e.DestEta).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtaDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.LadenDate).IsFixedLength();

                entity.Property(e => e.StuffDate).IsFixedLength();

                entity.Property(e => e.WarehouseBillingDate).IsFixedLength();
            });

            modelBuilder.Entity<SeBlReference>(entity =>
            {
                entity.ToView("se_Bl_Reference");

                entity.Property(e => e.AtaDate).IsFixedLength();

                entity.Property(e => e.BillingDate).IsFixedLength();

                entity.Property(e => e.BlIssueDate).IsFixedLength();

                entity.Property(e => e.BlReadyDate).IsFixedLength();

                entity.Property(e => e.CargoReceiptDate).IsFixedLength();

                entity.Property(e => e.ConfirmArrivalDate).IsFixedLength();

                entity.Property(e => e.ConfirmDepartureDate).IsFixedLength();

                entity.Property(e => e.DestEta).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.FfReceiptDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtaDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.LadenDate).IsFixedLength();

                entity.Property(e => e.LodgeDate).IsFixedLength();

                entity.Property(e => e.PickUpDate).IsFixedLength();

                entity.Property(e => e.PreAlertDestDate).IsFixedLength();

                entity.Property(e => e.RequestDate).IsFixedLength();

                entity.Property(e => e.StuffDate).IsFixedLength();

                entity.Property(e => e.TaxRefundIssueDate).IsFixedLength();

                entity.Property(e => e.TaxRefundReturnDate).IsFixedLength();

                entity.Property(e => e.TruckingDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SeBookingEntry>(entity =>
            {
                entity.ToView("se_Booking_Entry");

                entity.Property(e => e.DestEta).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtaDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.StuffDate).IsFixedLength();
            });

            modelBuilder.Entity<SeChargeWeight>(entity =>
            {
                entity.ToView("se_Charge_Weight");
            });

            modelBuilder.Entity<SeChargeWeightRatio>(entity =>
            {
                entity.ToView("se_Charge_Weight_Ratio");
            });

            modelBuilder.Entity<SeContainer>(entity =>
            {
                entity.ToView("se_Container");

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();
            });

            modelBuilder.Entity<SeCreditInvoiceByJob>(entity =>
            {
                entity.ToView("se_Credit_Invoice_By_Job");
            });

            modelBuilder.Entity<SeCreditInvoiceByMasterJob>(entity =>
            {
                entity.ToView("se_Credit_Invoice_By_Master_Job");
            });

            modelBuilder.Entity<SeCreditInvoiceWithVatByMasterJob>(entity =>
            {
                entity.ToView("se_Credit_Invoice_With_Vat_By_Master_Job");
            });

            modelBuilder.Entity<SeCreditNoteByJob>(entity =>
            {
                entity.ToView("se_Credit_Note_By_Job");
            });

            modelBuilder.Entity<SeCreditNoteByMasterJob>(entity =>
            {
                entity.ToView("se_Credit_Note_By_Master_Job");
            });

            modelBuilder.Entity<SeCreditNoteWithVatByMasterJob>(entity =>
            {
                entity.ToView("se_Credit_Note_With_Vat_By_Master_Job");
            });

            modelBuilder.Entity<SeDebitNoteByJob>(entity =>
            {
                entity.ToView("se_Debit_Note_By_Job");
            });

            modelBuilder.Entity<SeDebitNoteByMasterJob>(entity =>
            {
                entity.ToView("se_Debit_Note_By_Master_Job");
            });

            modelBuilder.Entity<SeDebitNoteWithVatByMasterJob>(entity =>
            {
                entity.ToView("se_Debit_Note_With_Vat_By_Master_Job");
            });

            modelBuilder.Entity<SeFreightCollect>(entity =>
            {
                entity.ToView("se_Freight_Collect");
            });

            modelBuilder.Entity<SeFreightCollectByJob>(entity =>
            {
                entity.ToView("se_Freight_Collect_By_Job");
            });

            modelBuilder.Entity<SeFreightCollectByJobFreight>(entity =>
            {
                entity.ToView("se_Freight_Collect_By_Job_Freight");
            });

            modelBuilder.Entity<SeFreightCollectByJobOther>(entity =>
            {
                entity.ToView("se_Freight_Collect_By_Job_Other");
            });

            modelBuilder.Entity<SeFreightCollectUsd>(entity =>
            {
                entity.ToView("se_Freight_Collect_USD");
            });

            modelBuilder.Entity<SeImportRateByJob>(entity =>
            {
                entity.ToView("se_Import_Rate_By_Job");
            });

            modelBuilder.Entity<SeImportRateByMasterJob>(entity =>
            {
                entity.ToView("se_Import_Rate_By_Master_Job");
            });

            modelBuilder.Entity<SeImportRateExportByJob>(entity =>
            {
                entity.ToView("se_Import_Rate_Export_By_Job");
            });

            modelBuilder.Entity<SeImportRateExportByMasterJob>(entity =>
            {
                entity.ToView("se_Import_Rate_Export_By_Master_Job");
            });

            modelBuilder.Entity<SeInvoice1>(entity =>
            {
                entity.ToView("se_Invoice_1");

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();
            });

            modelBuilder.Entity<SeInvoice2>(entity =>
            {
                entity.ToView("se_Invoice_2");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SeInvoiceJob>(entity =>
            {
                entity.ToView("se_Invoice_Job");

                entity.Property(e => e.AtaDate).IsFixedLength();

                entity.Property(e => e.BillingDate).IsFixedLength();

                entity.Property(e => e.BlIssueDate).IsFixedLength();

                entity.Property(e => e.DestEta).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtaDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.LadenDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.StuffDate).IsFixedLength();

                entity.Property(e => e.TaxRefundIssueDate).IsFixedLength();

                entity.Property(e => e.TaxRefundReturnDate).IsFixedLength();
            });

            modelBuilder.Entity<SeJobCosting>(entity =>
            {
                entity.ToView("se_Job_Costing");

                entity.Property(e => e.BillingDate).IsFixedLength();

                entity.Property(e => e.BlIssueDate).IsFixedLength();

                entity.Property(e => e.BlReadyDate).IsFixedLength();

                entity.Property(e => e.CargoCollectionDate).IsFixedLength();

                entity.Property(e => e.CargoReceiptDate).IsFixedLength();

                entity.Property(e => e.ConfirmArrivalDate).IsFixedLength();

                entity.Property(e => e.ConfirmDepartureDate).IsFixedLength();

                entity.Property(e => e.DeliveryOrderReleaseDate).IsFixedLength();

                entity.Property(e => e.DestEta).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtaDatePod).IsFixedLength();

                entity.Property(e => e.EtaDatePol).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.EtdDatePol).IsFixedLength();

                entity.Property(e => e.FfReceiptDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtaDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.LadenDate).IsFixedLength();

                entity.Property(e => e.LodgeDate).IsFixedLength();

                entity.Property(e => e.PickUpDate).IsFixedLength();

                entity.Property(e => e.PreAlertDestDate).IsFixedLength();

                entity.Property(e => e.RequestDate).IsFixedLength();

                entity.Property(e => e.ShipDate).IsFixedLength();

                entity.Property(e => e.StuffDate).IsFixedLength();

                entity.Property(e => e.TaxRefundIssueDate).IsFixedLength();

                entity.Property(e => e.TaxRefundReturnDate).IsFixedLength();

                entity.Property(e => e.TruckingDate).IsFixedLength();
            });

            modelBuilder.Entity<SeJobInvoice>(entity =>
            {
                entity.ToView("se_Job_Invoice");

                entity.Property(e => e.AtaDate).IsFixedLength();

                entity.Property(e => e.BillingDate).IsFixedLength();

                entity.Property(e => e.BlIssueDate).IsFixedLength();

                entity.Property(e => e.DestEta).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtaDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.LadenDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.StuffDate).IsFixedLength();

                entity.Property(e => e.TaxRefundIssueDate).IsFixedLength();

                entity.Property(e => e.TaxRefundReturnDate).IsFixedLength();
            });

            modelBuilder.Entity<SePaymentVoucher1>(entity =>
            {
                entity.ToView("se_Payment_Voucher_1");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SeShipmentSummary>(entity =>
            {
                entity.ToView("se_Shipment_Summary");
            });

            modelBuilder.Entity<SeTranshipmentRateByJob>(entity =>
            {
                entity.ToView("se_Transhipment_Rate_By_Job");
            });

            modelBuilder.Entity<SeTranshipmentRateByMasterJob>(entity =>
            {
                entity.ToView("se_Transhipment_Rate_By_Master_Job");
            });

            modelBuilder.Entity<SeTranshipmentRateExportByJob>(entity =>
            {
                entity.ToView("se_Transhipment_Rate_Export_By_Job");
            });

            modelBuilder.Entity<SeTranshipmentRateExportByMasterJob>(entity =>
            {
                entity.ToView("se_Transhipment_Rate_Export_By_Master_Job");
            });

            modelBuilder.Entity<SeTsAllCollectByJob>(entity =>
            {
                entity.ToView("se_Ts_All_Collect_By_Job");
            });

            modelBuilder.Entity<SeTsAllCollectByMasterJob>(entity =>
            {
                entity.ToView("se_Ts_All_Collect_By_Master_Job");
            });

            modelBuilder.Entity<SeTsCostByMasterJob>(entity =>
            {
                entity.ToView("se_Ts_Cost_By_Master_Job");
            });

            modelBuilder.Entity<SeTsExportFreightCollectByJob>(entity =>
            {
                entity.ToView("se_Ts_Export_Freight_Collect_By_Job");
            });

            modelBuilder.Entity<SeTsExportFreightCollectByMasterJob>(entity =>
            {
                entity.ToView("se_Ts_Export_Freight_Collect_By_Master_Job");
            });

            modelBuilder.Entity<SeTsFreightCollectByJob>(entity =>
            {
                entity.ToView("se_Ts_Freight_Collect_By_Job");
            });

            modelBuilder.Entity<SeTsFreightCollectByMasterJob>(entity =>
            {
                entity.ToView("se_Ts_Freight_Collect_By_Master_Job");
            });

            modelBuilder.Entity<SeTsFreightCollectCostByMasterJob>(entity =>
            {
                entity.ToView("se_Ts_Freight_Collect_Cost_By_Master_Job");
            });

            modelBuilder.Entity<SeTsSalesByMasterJob>(entity =>
            {
                entity.ToView("Se_Ts_Sales_By_Master_Job");
            });

            modelBuilder.Entity<Sebh1>(entity =>
            {
                entity.Property(e => e.TrxNo).ValueGeneratedNever();

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FaxCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.TableName).HasDefaultValueSql("('Sebh1')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Sebh2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.Property(e => e.ContainerLineItemNo).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Sebh2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sebh2_sebh1");

                entity.HasOne(d => d.UomCodeNavigation)
                    .WithMany(p => p.Sebh2s)
                    .HasForeignKey(d => d.UomCode)
                    .HasConstraintName("FK_sebh2_rcum1");
            });

            modelBuilder.Entity<Sebk1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FaxCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.TableName).HasDefaultValueSql("('Sebk1')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Sebk2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.Property(e => e.ContainerLineItemNo).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Sebk2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sebk2_sebk1");

                entity.HasOne(d => d.UomCodeNavigation)
                    .WithMany(p => p.Sebk2s)
                    .HasForeignKey(d => d.UomCode)
                    .HasConstraintName("FK_sebk2_rcum1");
            });

            modelBuilder.Entity<Sebk3>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.HasOne(d => d.CurrCodeNavigation)
                    .WithMany(p => p.Sebk3s)
                    .HasForeignKey(d => d.CurrCode)
                    .HasConstraintName("FK_sebk3_glex1");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Sebk3s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sebk3_sebk1");

                entity.HasOne(d => d.UomCodeNavigation)
                    .WithMany(p => p.Sebk3s)
                    .HasForeignKey(d => d.UomCode)
                    .HasConstraintName("FK_sebk3_rcum11");

                entity.HasOne(d => d.VatCodeNavigation)
                    .WithMany(p => p.Sebk3s)
                    .HasForeignKey(d => d.VatCode)
                    .HasConstraintName("FK_sebk3_acva11");
            });

            modelBuilder.Entity<Sebk4>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.CargoLineItemNo, e.LineItemNo });

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Sebk4s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sebk4_sebk1");
            });

            modelBuilder.Entity<Sebk5>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo })
                    .HasName("PK_Sebk5");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Sebk5s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sebk5_sebk1");
            });

            modelBuilder.Entity<Sebl1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FaxCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.TableName).HasDefaultValueSql("('Sebl1')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Sebl2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.Property(e => e.ContainerLineItemNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.MarkNoImage).HasDefaultValueSql("(0x89504E470D0A1A0A0000000D49484452000000D20000014F08060000003816906B000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA8640000077749444154785EEDD33111000008C430FC9B0611740C027EC8D1594780C05B60DE0B06081058217902028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F2010081C15A72CF29DD262F30000000049454E44AE426082)");
            });

            modelBuilder.Entity<Sebl3>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Sebl4>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.CargoLineItemNo, e.LineItemNo });
            });

            modelBuilder.Entity<Sebl5>(entity =>
            {
                entity.Property(e => e.TrxNo).ValueGeneratedNever();
            });

            modelBuilder.Entity<Sebl6>(entity =>
            {
                entity.Property(e => e.TrxNo).ValueGeneratedNever();
            });

            modelBuilder.Entity<Sebl7>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo })
                    .HasName("PK_Sebl7");
            });

            modelBuilder.Entity<Sebl8>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo })
                    .HasName("PK_Sebl8");
            });

            modelBuilder.Entity<Sebl9>(entity =>
            {
                entity.Property(e => e.TrxNo).ValueGeneratedNever();
            });

            modelBuilder.Entity<Secp1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CurrCodeNavigation)
                    .WithMany(p => p.Secp1s)
                    .HasForeignKey(d => d.CurrCode)
                    .HasConstraintName("FK_secp1_glex1");
            });

            modelBuilder.Entity<Secp2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Secp2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_secp2_secp1");
            });

            modelBuilder.Entity<Sefp1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_Sefp1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Seiv1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .IsClustered(false);

                entity.HasIndex(e => e.InvoiceNo, "IX_seiv1")
                    .IsClustered();

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FaxCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PostFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WithHoldingTaxAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Seiv2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Seiv2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_seiv2_seiv1");
            });

            modelBuilder.Entity<Semp1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FaxCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");

                entity.HasOne(d => d.DivisionCodeNavigation)
                    .WithMany(p => p.Semp1s)
                    .HasForeignKey(d => d.DivisionCode)
                    .HasConstraintName("FK_semp1_acdv1");
            });

            modelBuilder.Entity<Semp2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.HasOne(d => d.ContainerTypeNavigation)
                    .WithMany(p => p.Semp2s)
                    .HasForeignKey(d => d.ContainerType)
                    .HasConstraintName("FK_semp2_rcco1");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Semp2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_semp2_semp1");

                entity.HasOne(d => d.UomCodeNavigation)
                    .WithMany(p => p.Semp2s)
                    .HasForeignKey(d => d.UomCode)
                    .HasConstraintName("FK_semp2_rcum1");
            });

            modelBuilder.Entity<Sepa1>(entity =>
            {
                entity.Property(e => e.AppendBookingNoFlag).HasComment("When call up the Booking No. it will auto add zero in front of the number");

                entity.Property(e => e.AtaName).HasComment("Define the ATA label in Vessel Schedule and sebk1 the system will update BLAttachmentFlag=Y.");

                entity.Property(e => e.AutoAttachFlag).HasComment("If set as 'Y' and there are more than one record in sebl2,");

                entity.Property(e => e.AutoUpdateBlDateFlag).HasComment("If set as 'N', then when change the ETD of the Master, it should not auto the BL Issue Date and Landen Date of house bl");

                entity.Property(e => e.BankAccCode).HasComment("Default the Bank Acc Code to the payment Voucher");

                entity.Property(e => e.BankCode).HasComment("Define the BankCode to default the BankCode in ivcr1_5");

                entity.Property(e => e.BlCurrCode).HasComment("Default the Currency Code when entering a new B/L");

                entity.Property(e => e.BlDestCodePosition).HasComment("e.g. 4 then when change the Dest Code in sebl1, it will check BlDestCode and if left(BlNo,4,3)=DestCode. It will auto replace the BlNo. with new Dest Code");

                entity.Property(e => e.BlIssuePlace).HasComment("Default the Place of Issue when entering a new B/L");

                entity.Property(e => e.BlSurrenderFlag).HasComment("Default the B/L Surrender when entering a new B/L");

                entity.Property(e => e.BookingCreateJobNoFlag).HasComment("control Sea booking button confrim generate JobNo or not");

                entity.Property(e => e.BookingDestCodePosition).HasComment("e.g. 4 then when change the Dest Code in sebk1, it will check BookingDestCode and if left(BookingNo,4,3)=DestCode. It will auto replace the BookingNo. with new Dest Code");

                entity.Property(e => e.BookingTermAndCondition).HasComment("Define the Booking Term and Condition");

                entity.Property(e => e.CargoLoadReport1).HasComment("Define the report name");

                entity.Property(e => e.CargoLoadReport2).HasComment("Define the report name");

                entity.Property(e => e.CargoLoadReportLabel1).HasComment("Define the 1st button name on the Cargo Load Plan");

                entity.Property(e => e.CargoLoadReportLabel2).HasComment("Define the 2nd button name on the Cargo Load Plan");

                entity.Property(e => e.CashAccCode).HasComment("Default the Cash Acc Code to the Cash Receipt");

                entity.Property(e => e.ChangeBookingNoFlag).HasComment("if set as 'A', then only access right=A can change Booking No. if set as 'S', then access right=A or S can change Booking No. if set as 'U' or blank, then all users can change Booking No");

                entity.Property(e => e.ChangeMasterJobNoFlag).HasComment("If set as N, it will not prompt the message and it will not change the Job No of the House");

                entity.Property(e => e.ChangeSchedule).HasComment("Sebl1.VoyageID <> ' ',the below fields (refer to below) in Consol booking screen and sebl1 if shipment is 'M'  should be locked base on the access right, should not allow right key and left right:\r\nETD / ETA \r\nVessel Code / Vessel Name \r\nVoyage No \r\nPortOfDischargeCode / PortOfDischargeName\r\n\r\n- Blank, use the old logic.(locked  access right  U, refer to \r\n- U, all AccessRights are not locked\r\n- S, locked  AccessRight  U\r\n- A, locked  AccessRight  U,S");

                entity.Property(e => e.CityCode).HasComment("Default the Origin code when entering a new B/L");

                entity.Property(e => e.CloseConsolRight).HasComment("If set as 'U', mean U or above can close consol. S - S or above.");

                entity.Property(e => e.CloseScheduleDay).HasComment("Define the number of day the Vessel Schedule should be closed");

                entity.Property(e => e.ClsConsolBookingAccessRight).HasComment("If set as ‘N’ or leave blank, then current logic,if the sebl1.CloseConsol=’Y’, if set as ‘Y’ or ‘U’, then all user can edit the booking, if set as ‘S’, then only access right =’S’ or ‘A’ can edit the booing, if set as ‘A’, then only access right =’A’ can edit the booking. Except 'Go Master'/'Extra Info'/'Billing Info'button.\r\n- Billing Info allow user to add new or edit\r\n- Extra Info read only");

                entity.Property(e => e.CommodityDescriptionRow).HasComment("Define which line the Commodity Description will default  to Goods Description under the Cargo Info tab");

                entity.Property(e => e.CompanyAddress1).HasComment("Default the Address 1 of the Company as Shipper Address 1 in the OB/L");

                entity.Property(e => e.CompanyAddress2).HasComment("Default the Address 2 of the Company as Shipper Address 2 in the OB/L");

                entity.Property(e => e.CompanyAddress3).HasComment("Default the Address 3 of the Company as Shipper Address 3 in the OB/L");

                entity.Property(e => e.CompanyAddress4).HasComment("Default the Address 4 of the Company as Shipper Address 4 in the OB/L");

                entity.Property(e => e.CompanyCode).HasComment("The Business Party code of the Company. Default as Shipper Code in the OB/L");

                entity.Property(e => e.CompanyName).HasComment("Default the Name of the Company as Shipper Name in the OB/L");

                entity.Property(e => e.ConfirmConsolBookingFlag).HasComment("Set as Y when add a new consol booking need confirmation to generate Master Job No.");

                entity.Property(e => e.ConsolBlFlag).HasComment("Set as N the consol Info screen will not allow user to click Select All and Consol button");

                entity.Property(e => e.ConsolBookingJobType).HasComment("Define the Job Type when click the button 'Consol Booking' to list the Export Job will filter");

                entity.Property(e => e.ConsolSubMasterFlag).HasComment("If set as 'N', it will disable the 'New Sub Master' button on Consol screen.");

                entity.Property(e => e.ContainerMainDatabaseUrl).HasComment("For Sea Booking Container Search Button, set as \"ApiServer,Database,LoginId,Password\"");

                entity.Property(e => e.ContainerType1).HasComment("default the Container Type 1 to sebk1");

                entity.Property(e => e.ContainerType2).HasComment("default the Container Type 2 to sebk1");

                entity.Property(e => e.ContainerType3).HasComment("default the Container Type 3 to sebk1");

                entity.Property(e => e.ContainerType4).HasComment("default the Container Type 4 to sebk1");

                entity.Property(e => e.CopyBookingFlag).HasComment("if set as B mean copy booking sebk1 just copy sebk1 not sebl1");

                entity.Property(e => e.CopyConsolJobType).HasComment("Define which Job Type 's job can be copied on LCL Consol.");

                entity.Property(e => e.CopyContainerDescription).HasComment("When click Copy Container, it will copy the Container and Seal No. and it will copy the CopyContainerDescription also to ghe first row of the Mark");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerPartyType).HasComment("Define the which PartyType when F4 or auto search the Customer Code in sebk1. e.g If set as ''CL,OA',  then F4 search and auto search Customer Code in sebk1, should filter Rcbp1.PartyType is CL, OA, blank or null");

                entity.Property(e => e.DefaultCargoTypeFlag).HasComment("If set as Y, default the Cargo Type = 'LCL'  in Direct Booking if the control of the Cargo Type is not set in INI.");

                entity.Property(e => e.DefaultCloseDate).HasComment("default the Close Date by ETD Date in sebk1 and Consol Booking.\r\ne.g  ‘1’ mean ETD -1 but exclude Sunday and Saturday. Both Add and Edit mode will change.");

                entity.Property(e => e.DefaultCloseDateType).HasComment("If set as ‘ATA’, to default the Close Date by ATA Date in sebk1 and Consol Booking base on the sepa1.DefaultCloseDate. e.g. DefaultCloseDate set as ‘1’, mean ATA-1 but exclude Sunday and Saturday. Both Add and Edit mode will change.\r\nIf set as ‘ETD’ or blank, then default the Close Date by ETD Date.");

                entity.Property(e => e.DefaultCloseTime).HasComment("if DefaultCloseTime has value. e.g. 12:00, then when default the Close Date by ATA or ETD, it will also default the Close Time as 12:00 in sebk1 and Consol Booking");

                entity.Property(e => e.DefaultDocument).HasComment("Default the Document List to display the Trx Type of Document e.g. IV for Invoice, CN for Credit Note, DN for Debite Note, CI for Cash Invoice, CR for Cash Receipt, 0 for Ivcr1_0, 1 for Ivcr1_1, 2 for Ivcr1_2, 3 for Ivcr1_3, 4 for Ivcr1_4, 5 for Ivcr1_5, 6 for Ivcr1_6, 7 for Ivcr1_7,  8 for Ivcr1_8, 9 for Ivcr1_9");

                entity.Property(e => e.DefaultPackage).HasComment("If 'Select Distinct UomCode from sebl2' have more than one records, then update the sepa1.DefaultPackage to sebl1.UomCode, the UomDescription pull from rcum1 base on the UomCode. If 'Select Distinct UomCode from sebl2' only has one record, then update the sebl2.UomCode to sebl1.UomCode. when change the sebl2.UomCode, it should always update to sebl1.UomCode, no matter sebl1.UomCode has value or not");

                entity.Property(e => e.DefaultTransportCompanyCode).HasComment("Default the TransportCompanyCode, Name and address from rcbp1 to sebk1and semp1 when adding a new record (sebk1 don't auto default but add a button \"Default Transport Company\"");

                entity.Property(e => e.DefaultVendorNameFlag).HasComment("Default the Vendor Name of the Payment Voucher as Coloader or Shipping Line");

                entity.Property(e => e.DirectHouseFlag).HasComment("Set as Y then when confirm the House Booking it will auto save as Direct Job when no Master Job is attached.");

                entity.Property(e => e.DocumentFooter1).HasComment("Print to Footer 1 of the Sea Export related documents");

                entity.Property(e => e.DocumentFooter2).HasComment("Print to Footer 2 of the Sea Export related documents");

                entity.Property(e => e.DraftOblnoFlag).HasComment("Set as J the OB/L No. will be the same as Job No. Set as D the OB/L No. will be created from the Draft OB/L No Prefix and Next Draft OB/L No.");

                entity.Property(e => e.DraftOblnoPrefix).HasComment("Define the OB/L Prefix Format:YY,MM,DST or FXX");

                entity.Property(e => e.EtaDay).HasComment("Default the ETA after No. of day in define Eta Day when Etd Flag set as Y");

                entity.Property(e => e.EtdFlag).HasComment("Default the ETD as today date in Direct Booking entry when set as Y");

                entity.Property(e => e.FclCargoDescription).HasComment("Default the Description to the 1st Description in Cargo Info for FCL shipment");

                entity.Property(e => e.FontType).HasComment("Define the font type for the Sebl1.Description XX and CommodityDescriptionXX");

                entity.Property(e => e.FreeStorageDay).HasComment("Define no. of Free Storage day for the cargo when compute the billing");

                entity.Property(e => e.FreightItemCode).HasComment("Define the Item code for the Freight Charge. It must be a valid code in Charge List in Account Reference");

                entity.Property(e => e.HaulierReport1).HasComment("If there is the value, the system should show print button under Haulier screen(click '...' button)");

                entity.Property(e => e.HaulierReport2).HasComment("If there is the value, the system should show print button under Haulier screen(click '...' button)");

                entity.Property(e => e.HaulierReportLabel1).HasComment("Define the button name");

                entity.Property(e => e.HaulierReportLabel2).HasComment("Define the button name");

                entity.Property(e => e.HblNoFlag).HasComment("J to default the HB/L same as Job No. H to create the HB/L No. base on the HBL Prefix and Next HBL No.");

                entity.Property(e => e.HblPrefix).HasComment("HB/L Prefix combination of FXX,DST,ORG,S,YY,Y,MM,M,DD");

                entity.Property(e => e.HblSuffix).HasComment("FXX,NN");

                entity.Property(e => e.HideBlColumnFlag).HasComment("then hide the BL column on the Charge Info tab in sebl1");

                entity.Property(e => e.HideConfirmMessageFlag).HasComment("If set as 'Y' then when confirm booking should not prompt screen. Also if the booking is unconfirmed, when click the button 'B/L Preparation', it should prompt message \"Do you want to confirm this House Booking?\"");

                entity.Property(e => e.HideCountryOfOriginFlag).HasComment("If set as 'Y', then hide the Country Of Origin in sebk1");

                entity.Property(e => e.HouseSeqNoFlag).HasComment("Set as Y to update the House Seq No in Jmjm1 when any house job is create in sea export");

                entity.Property(e => e.InvoiceTrfBy).HasComment("NOT IN USE");

                entity.Property(e => e.JobDateType).HasComment("Job Date is defined as ETD - ETD Date or JCD - Job Creation Date");

                entity.Property(e => e.JobFormatType).HasComment("Set as 0: Direct/Master= 00; House= 01-99. Set as 1: Direct= Z; Master= 0; House= A-Y");

                entity.Property(e => e.JobNoFlag).HasComment("Job running no. is created by C - Continously, M - Monthly, S - Shipment Type");

                entity.Property(e => e.JobNoFormat).HasComment("[FXX:Std Prefix],[SFX:Suffix],[S:Shipment Type],[ORG:Origin Code],[DST:Dest Code],[MM:01-12],[M:1-9/A-C],[YY:01-99],[Y:0-9]");

                entity.Property(e => e.JobPostBy).HasComment("NOT IN USE");

                entity.Property(e => e.JobPrefix1).HasComment("Job Prefix 1 Format select one value from YY,MM,DST or FXX");

                entity.Property(e => e.JobPrefix2).HasComment("Job Prefix 2 Format select one value from YY,MM,DST or FXX");

                entity.Property(e => e.JobPrefix3).HasComment("Job Prefix 3 Format select one value from YY,MM,DST or FXX");

                entity.Property(e => e.JobPrefix4).HasComment("Job Prefix 4 Format select one value from YY,MM,DST or FXX");

                entity.Property(e => e.JobPrefix5).HasComment("Job Prefix 5 Format select one value from YY,MM,DST or FXX");

                entity.Property(e => e.K1).HasComment("For Malaysia Custom System Form K1");

                entity.Property(e => e.K2).HasComment("For Malaysia Custom System Form K2");

                entity.Property(e => e.K3).HasComment("For Malaysia Custom System Form K3");

                entity.Property(e => e.K4).HasComment("For Malaysia Custom System Form K4");

                entity.Property(e => e.K5).HasComment("For Malaysia Custom System Form K5");

                entity.Property(e => e.K6).HasComment("For Malaysia Custom System Form K6");

                entity.Property(e => e.K7).HasComment("For Malaysia Custom System Form K7");

                entity.Property(e => e.K8).HasComment("For Malaysia Custom System Form K8");

                entity.Property(e => e.K9).HasComment("For Malaysia Custom System Form K9");

                entity.Property(e => e.LastInvoiceTrfDate).HasComment("NOT IN USE");

                entity.Property(e => e.LastJobPostDate).HasComment("NOT IN USE");

                entity.Property(e => e.LongSubHouseSuffixFlag).HasComment("For Sub House Job Suffix. Set as Y will be XX, N will be N");

                entity.Property(e => e.ManualVoyageIdFlag).HasComment("Set as Y to manaully create the Voyage ID");

                entity.Property(e => e.NextConsolJobNo).HasComment("Next Consol Job No");

                entity.Property(e => e.NextDirectJobNo).HasComment("Nex Direct Job No");

                entity.Property(e => e.NextDraftOblno).HasComment("Nex OB/L No");

                entity.Property(e => e.NextHblNo).HasComment("Next HB/L No");

                entity.Property(e => e.NextJobNo).HasComment("Next Job No when Job No Flag is set as C");

                entity.Property(e => e.NextJobNoMth01).HasComment("Next Job No for Mth 01 when Job No flag is set as M");

                entity.Property(e => e.NextJobNoMth02).HasComment("Next Job No for Mth 02 when Job No flag is set as M");

                entity.Property(e => e.NextJobNoMth03).HasComment("Next Job No for Mth 03 when Job No flag is set as M");

                entity.Property(e => e.NextJobNoMth04).HasComment("Next Job No for Mth 04 when Job No flag is set as M");

                entity.Property(e => e.NextJobNoMth05).HasComment("Next Job No for Mth 05 when Job No flag is set as M");

                entity.Property(e => e.NextJobNoMth06).HasComment("Next Job No for Mth 06 when Job No flag is set as M");

                entity.Property(e => e.NextJobNoMth07).HasComment("Next Job No for Mth 07 when Job No flag is set as M");

                entity.Property(e => e.NextJobNoMth08).HasComment("Next Job No for Mth 08 when Job No flag is set as M");

                entity.Property(e => e.NextJobNoMth09).HasComment("Next Job No for Mth 09 when Job No flag is set as M");

                entity.Property(e => e.NextJobNoMth10).HasComment("Next Job No for Mth 10 when Job No flag is set as M");

                entity.Property(e => e.NextJobNoMth11).HasComment("Next Job No for Mth 11 when Job No flag is set as M");

                entity.Property(e => e.NextJobNoMth12).HasComment("Next Job No for Mth 12 when Job No flag is set as M");

                entity.Property(e => e.NominationItemCode).HasComment("If sebk1.NominationFlag=Y, define the Charge Item Code when click the button 'Rate Compute' to insert the record to sebl3.");

                entity.Property(e => e.PermitName).HasComment("It will replace the label name of the Permit/Approve No in B/L shipment info");

                entity.Property(e => e.ProfitShareItemCode).HasComment("Define the Item Code to ivcr2 when click the button 'Generate Invoice under the Profit Share tab on Consol Booking.");

                entity.Property(e => e.RebateItemCode).HasComment("Default the Item Code to the Billing Info in B/L when click the Rebate button. It must be valid Item Code in Charge List");

                entity.Property(e => e.SaidToContain).HasComment("Define the words when click the button 'Said To Contain'");

                entity.Property(e => e.SetDescriptionLength).HasComment("Set the Description length in Cargo info");

                entity.Property(e => e.SetDescriptionRow).HasComment("Define the system show the GoodsDescription on the Cargo Info screen. e.g - if set as '17', then the sebl2.GoodsDescription18-20 will be hide. If leave blank, then use current logic, show sebl2.MarkNo1-15");

                entity.Property(e => e.SetMarkRow).HasComment("Define the system show the MarkNo on the Cargo Info screen. e.g - if set as '17', then the sebl2.MarkNo18-20 will be hide. If leave blank, then use current logic, show sebl2.GoodsDescription1-15");

                entity.Property(e => e.SetMarksLength).HasComment("Set the Mark length in Cargo info");

                entity.Property(e => e.ShowActualBookingNo).HasComment("Set as Y to show the House Booking No. on the Consol Booking screen .  Set as N to show the Booking Sequence No. 001,002,..");

                entity.Property(e => e.ShowBlFlag).HasComment("if set as 'Y', the consol screen will show Bl No from sebl1 instead of show Job No.");

                entity.Property(e => e.ShowBookingContainerFlag).HasComment("If set as 'Y', it will use the Multiple Container to compute the NoOf20ftContainer, NoOf40ftContainer and NoOf45ftContainer.");

                entity.Property(e => e.ShowBookingInConsolFlag).HasComment("e.g. If set as 'GP,FC', then the system should only always pull data from Sebk1 on Sebl1(Consol) which job type is 'GP' and 'FC' regardless booking confirm or not");

                entity.Property(e => e.ShowConfirmBookingFlag).HasComment("Y, mean sea export consol button \"consol\" screen only show Status CNF");

                entity.Property(e => e.ShowConsolColumn).HasComment("e.g if leave blank, then those 4 columns – N,T,R,W will show on the grid. If set as ‘N,T’, then just show N and T column. Same the logic for Import Consol");

                entity.Property(e => e.ShowDgCargoConsolFlag).HasComment("if set Y, it will display the UN, IMCO,FP to the Commodity on the consol booking screen. Otherwise it will always show the Commodity Description");

                entity.Property(e => e.ShowDgCargoTabFlag).HasComment("if set as 'Y', then the DG Cargo is 'Y', then show the DG Cargo Tab and hide the '...' button and the below 4 text box - Un No, IMCO, FP, PSN. if set as 'N' or leave blank, then use old logic (don't show the DG Cargo tab even if the DG Cargo is 'Y')");

                entity.Property(e => e.ShowPrintFlag).HasComment("If set as Y, it should show  'Print?' on Sebl1(Consol) screen. Default as 'Y'\r\nCreate house record under sebl1(Consol) and create sebl1 record at node, the PrintFlag always is blank");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.StorageChargeCode).HasComment("Define the Storage Charge Code");

                entity.Property(e => e.SubHouseJobNoFlag).HasComment("If set as 'Y', then it will create the JobNo for sub house job.");

                entity.Property(e => e.TranshipmentRateFlag).HasComment("if set as 'Y' then the Transhipment Rate and Import Rate in sebl1 will be unlock and let user to change and it will update to sibl1 Transhipment Rate and Import Rate directly base on ImportJobNo. If there is no ImportJobNo in sebl1, then it will be lock");

                entity.Property(e => e.UnlockBookingRemarkFlag).HasComment("If set as 'Y', then when Consol is Closed, the booking remark still can edit");

                entity.Property(e => e.UpdBookingToBlFlag).HasComment("The information in Booking will update to BL entry include Shipper, Consignee, Commodity,Delivery Agent, Salesman Code, Notify Party and Also Notify Party");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateMasterContainerFlag).HasComment("Just for Master Job. When set as ‘N’, then when add or edit sebl2 should not update sebl1.NoOf20ftContainer, NoOf40ftContainer and NoOf45ftContainer. If set as ‘Y’ or blank, then use old logic");

                entity.Property(e => e.UpperCaseFlag).HasComment("Allow auto change the Mark and Description to upper case");

                entity.Property(e => e.VoyageNoScheduleFlag).HasComment("Set as Y to pull Vessel Schedule by Voyage No. in the Direct Booking");

                entity.Property(e => e.WarehouseCode).HasComment("Default the Warehouse Code to the Staffing Agent in the new Booking, B/L or Consol Booking");

                entity.HasOne(d => d.BlCurrCodeNavigation)
                    .WithMany(p => p.Sepa1s)
                    .HasForeignKey(d => d.BlCurrCode)
                    .HasConstraintName("FK_sepa1_glex1");
            });

            modelBuilder.Entity<Sepi1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .IsClustered(false);

                entity.HasIndex(e => new { e.VendorCode, e.InvoiceNo }, "IX_sepi1_1")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CurrCodeNavigation)
                    .WithMany(p => p.Sepi1s)
                    .HasForeignKey(d => d.CurrCode)
                    .HasConstraintName("FK_sepi1_glex1");

                entity.HasOne(d => d.DivisionCodeNavigation)
                    .WithMany(p => p.Sepi1s)
                    .HasForeignKey(d => d.DivisionCode)
                    .HasConstraintName("FK_sepi1_acdv1");
            });

            modelBuilder.Entity<Sepi2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.HasOne(d => d.CurrCodeNavigation)
                    .WithMany(p => p.Sepi2s)
                    .HasForeignKey(d => d.CurrCode)
                    .HasConstraintName("FK_sepi2_glex1");

                entity.HasOne(d => d.ItemCodeNavigation)
                    .WithMany(p => p.Sepi2s)
                    .HasForeignKey(d => d.ItemCode)
                    .HasConstraintName("FK_sepi2_acit1");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Sepi2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sepi2_sepi1");

                entity.HasOne(d => d.UomCodeNavigation)
                    .WithMany(p => p.Sepi2s)
                    .HasForeignKey(d => d.UomCode)
                    .HasConstraintName("FK_sepi2_rcum1");
            });

            modelBuilder.Entity<Sepv1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .IsClustered(false);

                entity.HasIndex(e => e.VoucherNo, "IX_sepv1")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PostFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Sepv2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Sepv2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sepv2_sepv1");
            });

            modelBuilder.Entity<SiAllInternalBillingByMasterJob>(entity =>
            {
                entity.ToView("si_All_Internal_Billing_By_Master_Job");
            });

            modelBuilder.Entity<SiBlEntry>(entity =>
            {
                entity.ToView("si_Bl_Entry");

                entity.Property(e => e.BlIssueDate).IsFixedLength();

                entity.Property(e => e.DestEta).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtaDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.LadenDate).IsFixedLength();

                entity.Property(e => e.WarehouseBillingDate).IsFixedLength();
            });

            modelBuilder.Entity<SiBlReference>(entity =>
            {
                entity.ToView("si_Bl_Reference");

                entity.Property(e => e.BillingDate).IsFixedLength();

                entity.Property(e => e.BlIssueDate).IsFixedLength();

                entity.Property(e => e.CargoRcvDate).IsFixedLength();

                entity.Property(e => e.CargoReadyDate).IsFixedLength();

                entity.Property(e => e.CargoReceiptDate).IsFixedLength();

                entity.Property(e => e.DeliveryOrderReleaseDate).IsFixedLength();

                entity.Property(e => e.DestEta).IsFixedLength();

                entity.Property(e => e.DocRcvDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.ExportEta).IsFixedLength();

                entity.Property(e => e.ExportEtd).IsFixedLength();

                entity.Property(e => e.FirstViaEtaDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.LadenDate).IsFixedLength();

                entity.Property(e => e.TrkRcvDateDate).IsFixedLength();

                entity.Property(e => e.TrkReceiptDate).IsFixedLength();

                entity.Property(e => e.TruckingDate).IsFixedLength();

                entity.Property(e => e.UnstuffDate).IsFixedLength();
            });

            modelBuilder.Entity<SiChargeWeight>(entity =>
            {
                entity.ToView("si_Charge_Weight");
            });

            modelBuilder.Entity<SiChargeWeightRatio>(entity =>
            {
                entity.ToView("si_Charge_Weight_Ratio");
            });

            modelBuilder.Entity<SiContainer>(entity =>
            {
                entity.ToView("si_Container");

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();
            });

            modelBuilder.Entity<SiCreditInvoiceByMasterJob>(entity =>
            {
                entity.ToView("si_Credit_Invoice_By_Master_Job");
            });

            modelBuilder.Entity<SiCreditInvoiceWithVatByMasterJob>(entity =>
            {
                entity.ToView("si_Credit_Invoice_With_Vat_By_Master_Job");
            });

            modelBuilder.Entity<SiCreditNoteByMasterJob>(entity =>
            {
                entity.ToView("si_Credit_Note_By_Master_Job");
            });

            modelBuilder.Entity<SiCreditNoteWithVatByMasterJob>(entity =>
            {
                entity.ToView("si_Credit_Note_With_Vat_By_Master_Job");
            });

            modelBuilder.Entity<SiDebitNoteByMasterJob>(entity =>
            {
                entity.ToView("si_Debit_Note_By_Master_Job");
            });

            modelBuilder.Entity<SiDebitNoteWithVatByMasterJob>(entity =>
            {
                entity.ToView("si_Debit_Note_With_Vat_By_Master_Job");
            });

            modelBuilder.Entity<SiFreightCollect>(entity =>
            {
                entity.ToView("si_Freight_Collect");
            });

            modelBuilder.Entity<SiFreightCollectByJob>(entity =>
            {
                entity.ToView("si_Freight_Collect_By_Job");
            });

            modelBuilder.Entity<SiFreightCollectByMasterJob>(entity =>
            {
                entity.ToView("si_Freight_Collect_By_Master_Job");
            });

            modelBuilder.Entity<SiImportRateByJob>(entity =>
            {
                entity.ToView("si_Import_Rate_By_Job");
            });

            modelBuilder.Entity<SiImportRateByMasterJob>(entity =>
            {
                entity.ToView("si_Import_Rate_By_Master_Job");
            });

            modelBuilder.Entity<SiInvoice1>(entity =>
            {
                entity.ToView("si_Invoice_1");

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();
            });

            modelBuilder.Entity<SiInvoice2>(entity =>
            {
                entity.ToView("si_Invoice_2");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SiJobCosting>(entity =>
            {
                entity.ToView("si_Job_Costing");

                entity.Property(e => e.BillingDate).IsFixedLength();

                entity.Property(e => e.BlIssueDate).IsFixedLength();

                entity.Property(e => e.CargoCollectionDate).IsFixedLength();

                entity.Property(e => e.CargoRcvDate).IsFixedLength();

                entity.Property(e => e.CargoReadyDate).IsFixedLength();

                entity.Property(e => e.CargoReceiptDate).IsFixedLength();

                entity.Property(e => e.DeliveryDate).IsFixedLength();

                entity.Property(e => e.DeliveryOrderReleaseDate).IsFixedLength();

                entity.Property(e => e.DestEta).IsFixedLength();

                entity.Property(e => e.DocRcvDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtaTime).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.ExportAtaDate).IsFixedLength();

                entity.Property(e => e.ExportEtaDate).IsFixedLength();

                entity.Property(e => e.ExportEtdDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtaDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.LadenDate).IsFixedLength();

                entity.Property(e => e.ShipDate).IsFixedLength();

                entity.Property(e => e.TrkRcvDateDate).IsFixedLength();

                entity.Property(e => e.TrkReceiptDate).IsFixedLength();

                entity.Property(e => e.TruckingDate).IsFixedLength();

                entity.Property(e => e.UnstuffDate).IsFixedLength();
            });

            modelBuilder.Entity<SiPaymentVoucher1>(entity =>
            {
                entity.ToView("si_Payment_Voucher_1");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SiSeTransportInstruction>(entity =>
            {
                entity.ToView("si_Se_Transport_Instruction");
            });

            modelBuilder.Entity<SiSeTsFreightCollectByJob>(entity =>
            {
                entity.ToView("si_se_Ts_Freight_Collect_By_Job");
            });

            modelBuilder.Entity<SiSeTsFreightCollectByMasterJob>(entity =>
            {
                entity.ToView("si_se_Ts_Freight_Collect_By_Master_Job");
            });

            modelBuilder.Entity<SiShipmentSummary>(entity =>
            {
                entity.ToView("si_Shipment_Summary");
            });

            modelBuilder.Entity<SiTranshipmentRateByJob>(entity =>
            {
                entity.ToView("si_Transhipment_Rate_By_Job");
            });

            modelBuilder.Entity<SiTranshipmentRateByMasterJob>(entity =>
            {
                entity.ToView("si_Transhipment_Rate_By_Master_Job");
            });

            modelBuilder.Entity<SiTsChargeCollectByJob>(entity =>
            {
                entity.ToView("si_Ts_Charge_Collect_By_Job");
            });

            modelBuilder.Entity<SiTsChargeCollectByMasterJob>(entity =>
            {
                entity.ToView("si_Ts_Charge_Collect_By_Master_Job");
            });

            modelBuilder.Entity<SiTsExportAllCollectByJob>(entity =>
            {
                entity.ToView("si_Ts_Export_All_Collect_By_Job");
            });

            modelBuilder.Entity<SiTsExportAllCollectByMasterJob>(entity =>
            {
                entity.ToView("si_Ts_Export_All_Collect_By_Master_Job");
            });

            modelBuilder.Entity<SiTsExportFreightCollectByJob>(entity =>
            {
                entity.ToView("si_Ts_Export_Freight_Collect_By_Job");
            });

            modelBuilder.Entity<SiTsExportFreightCollectByMasterJob>(entity =>
            {
                entity.ToView("si_Ts_Export_Freight_Collect_By_Master_Job");
            });

            modelBuilder.Entity<SiTsFreightCollectByJob>(entity =>
            {
                entity.ToView("si_Ts_Freight_Collect_By_Job");
            });

            modelBuilder.Entity<SiTsFreightCollectByMasterJob>(entity =>
            {
                entity.ToView("si_Ts_Freight_Collect_By_Master_Job");
            });

            modelBuilder.Entity<SiTsFreightCollectCostByMasterJob>(entity =>
            {
                entity.ToView("si_Ts_Freight_Collect_Cost_By_Master_Job");
            });

            modelBuilder.Entity<SiTsFreightCollectSalesByMasterJob>(entity =>
            {
                entity.ToView("si_Ts_Freight_Collect_Sales_By_Master_Job");
            });

            modelBuilder.Entity<Sibl1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FaxCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.TableName).HasDefaultValueSql("('Sibl1')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Sibl10>(entity =>
            {
                entity.Property(e => e.TrxNo).ValueGeneratedNever();
            });

            modelBuilder.Entity<Sibl11>(entity =>
            {
                entity.Property(e => e.TrxNo).ValueGeneratedNever();
            });

            modelBuilder.Entity<Sibl2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.Property(e => e.ContainerLineItemNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.MarkNoImage).HasDefaultValueSql("(0x89504E470D0A1A0A0000000D49484452000000D20000014F08060000003816906B000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA8640000077749444154785EEDD33111000008C430FC9B0611740C027EC8D1594780C05B60DE0B06081058217902028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F201008082940344140487E80402020A400D1040121F901028180900244130484E407080402420A104D1010921F2010081C15A72CF29DD262F30000000049454E44AE426082)");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Sibl2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sibl2_sibl1");
            });

            modelBuilder.Entity<Sibl3>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Sibl3s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sibl3_sibl1");
            });

            modelBuilder.Entity<Sibl4>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.CargoLineItemNo, e.LineItemNo });

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Sibl4s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sibl4_sibl1");
            });

            modelBuilder.Entity<Sibl5>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.Property(e => e.PrintFlag).HasDefaultValueSql("('Y')");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Sibl5s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sibl5_sibl1");
            });

            modelBuilder.Entity<Sibl7>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Sibl8>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Sibl9>(entity =>
            {
                entity.Property(e => e.TrxNo).ValueGeneratedNever();
            });

            modelBuilder.Entity<Sicp1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Sicp2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Sidi1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_sido1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDatetime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FaxCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");

                entity.HasOne(d => d.CommodityCodeNavigation)
                    .WithMany(p => p.Sidi1s)
                    .HasForeignKey(d => d.CommodityCode)
                    .HasConstraintName("FK_sido1_rccm1");

                entity.HasOne(d => d.DivisionCodeNavigation)
                    .WithMany(p => p.Sidi1s)
                    .HasForeignKey(d => d.DivisionCode)
                    .HasConstraintName("FK_sido1_acdv11");
            });

            modelBuilder.Entity<Sidi2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo })
                    .HasName("PK_sido2");

                entity.HasOne(d => d.ContainerTypeNavigation)
                    .WithMany(p => p.Sidi2s)
                    .HasForeignKey(d => d.ContainerType)
                    .HasConstraintName("FK_sido2_rcco1");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Sidi2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sido2_sido11");

                entity.HasOne(d => d.UomCodeNavigation)
                    .WithMany(p => p.Sidi2s)
                    .HasForeignKey(d => d.UomCode)
                    .HasConstraintName("FK_sido2_rcum11");
            });

            modelBuilder.Entity<Sido1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_sidi1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDatetime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FaxCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");

                entity.HasOne(d => d.DivisionCodeNavigation)
                    .WithMany(p => p.Sido1s)
                    .HasForeignKey(d => d.DivisionCode)
                    .HasConstraintName("FK_sidi1_acdv1");
            });

            modelBuilder.Entity<Sido2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo })
                    .HasName("PK_sidi2");

                entity.HasOne(d => d.ContainerTypeNavigation)
                    .WithMany(p => p.Sido2s)
                    .HasForeignKey(d => d.ContainerType)
                    .HasConstraintName("FK_sidi2_rcco1");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Sido2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sidi2_sidi1");

                entity.HasOne(d => d.UomCodeNavigation)
                    .WithMany(p => p.Sido2s)
                    .HasForeignKey(d => d.UomCode)
                    .HasConstraintName("FK_sidi2_rcum1");
            });

            modelBuilder.Entity<Siiv1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .IsClustered(false);

                entity.HasIndex(e => e.InvoiceNo, "IX_siiv1")
                    .IsClustered();

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FaxCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PostFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WithHoldingTaxAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Siiv2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Siiv2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_siiv2_siiv1");
            });

            modelBuilder.Entity<Sipa1>(entity =>
            {
                entity.Property(e => e.AutoMasterFlag).HasComment("If set as N, when create new House Shipment that does not have a Master Job No, then will not insert Master Job rcord into sibl1");

                entity.Property(e => e.AutoUpdateExportBookingFlag).HasComment("If set as 'Y', the Transhipment =Y in sibl1 it will auto update to sebk1 base on the importjobno in sebk1");

                entity.Property(e => e.BankAccCode).HasComment("Default the Bank Acc Code to the Payment Voucher");

                entity.Property(e => e.BankCode).HasComment("Define the BankCode to default the BankCode in ivcr1_5");

                entity.Property(e => e.BlCurrCode).HasComment("Default the Currency Code when entering a new B/L");

                entity.Property(e => e.BlIssuePlace).HasComment("Default the Place of issue When entering a new B/L");

                entity.Property(e => e.CashAccCode).HasComment("Default the Cash Acc Code to the Cash Receipt");

                entity.Property(e => e.CfsStorageChargeCode).HasComment("If it has value, then when click the button 'Charges' in ivcr1 which TrxType=5, it will auto calculate the charges.");

                entity.Property(e => e.CfsUploadFlag).HasComment("If set as Y, then it will display in Sea Import Consol as below base on EDI Count of the master. If EDI count >0 then show Y. Otherwise show N");

                entity.Property(e => e.ChangeMasterJobNoFlag).HasComment("If set as N, it will not prompt the message and it will not change the Job No of the House");

                entity.Property(e => e.CityCode).HasComment("Default the Destination Code when entering a new B/L");

                entity.Property(e => e.CommodityDescriptionRow).HasComment("Define which line the Commodity Description will default  to Goods Description under the Cargo Info tab");

                entity.Property(e => e.ConsolTransportCompanyCode).HasComment("Default to the Haulier in Consol screen(for GP)");

                entity.Property(e => e.ContainerNoBlankFlag).HasComment("If set as 'Y', then if the CargoType is FCL, the Container No in sibl2 can leave blank");

                entity.Property(e => e.CopyConsolJobType).HasComment("Define which Job Type 's job can be copied on LCL Consol.");

                entity.Property(e => e.CopyContainerFlag).HasComment("If set as 'Y', and all the container in master job Multiple Container is not ticked, then it will pull all container from master to house when create new houe");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerPartyType).HasComment("Define the which PartyType when F4 or auto search the Customer Code in sebk1. e.g If set as ''CL,OA',  then F4 search and auto search Customer Code in sebk1, should filter Rcbp1.PartyType is CL, OA, blank or null");

                entity.Property(e => e.DefaultCargoTypeFlag).HasComment("Default the Cargo Type in Import BL if the control of the cargo type is not set in INI.");

                entity.Property(e => e.DefaultConsignee).HasComment("if set as C then it will default the CustomerCode, Customer Name to Consignee Code and Consignee Name when add new sibl1. The address of the Consignee will also default from rcbp1 base on the Consignee Code.");

                entity.Property(e => e.DefaultCustomerCode).HasComment("Default the Customer Code when entering a new B/L");

                entity.Property(e => e.DefaultDocument).HasComment("Default the Document List to display the Trx Type of Document e.g. IV for Invoice, CN for Credit Note, DN for Debite Note, CI for Cash Invoice, CR for Cash Receipt, 0 for Ivcr1_0, 1 for Ivcr1_1, 2 for Ivcr1_2, 3 for Ivcr1_3, 4 for Ivcr1_4, 5 for Ivcr1_5, 6 for Ivcr1_6, 7 for Ivcr1_7,  8 for Ivcr1_8, 9 for Ivcr1_9");

                entity.Property(e => e.DefaultTransportCompanyCode).HasComment("Default the TransportCompanyCode, Name and address from rcbp1 to sibl1 when adding a new record (don't auto default but add a button \"Default Transport Company\"");

                entity.Property(e => e.DefaultVendorNameFlag).HasComment("Default the Vendor Name of the Payment Voucher as Coloader or Shipping Line");

                entity.Property(e => e.DocumentFooter1).HasComment("Print to Footer 1 of the Sea Import related documents");

                entity.Property(e => e.DocumentFooter2).HasComment("Print to Footer 2 of the Sea Import related documents");

                entity.Property(e => e.DraftOblnoFlag).HasComment("NOT IN USE");

                entity.Property(e => e.DraftOblnoPrefix).HasComment("NOT IN USE");

                entity.Property(e => e.EditFrtCollectFlag).HasComment("When it is a transhipment job and the export job is confirmed and the sipa1.LockFreightCollectFlag ='Y', allow user to edit, but it will update to sebl3\r\n- A mean only access right is A will show.\r\n- S mean access right is A or S will show.\r\n- U mean all user will show.");

                entity.Property(e => e.FclTransportCompanyCode).HasComment("Default to the Haulier in Consol screen(for FC)");

                entity.Property(e => e.FreeStorageDay).HasComment("Define no. of Free Storage day for the cargo when compute the billing");

                entity.Property(e => e.FreightCollectItemCode).HasComment("Define the Item Code for the Freight Collect Charge. It must be a valid code in Charge List in Account Reference");

                entity.Property(e => e.FreightItemCode).HasComment("Define the Item Code for the Freight Charge. It must be a valid code in Charge List in Account Reference");

                entity.Property(e => e.GateChargeCode).HasComment("NOT IN USE");

                entity.Property(e => e.HaulierReport1).HasComment("If there is the value, the system should show print button under Haulier screen(click '...' button)");

                entity.Property(e => e.HaulierReport2).HasComment("If there is the value, the system should show print button under Haulier screen(click '...' button)");

                entity.Property(e => e.HaulierReportLabel1).HasComment("Define the button name");

                entity.Property(e => e.HaulierReportLabel2).HasComment("Define the button name");

                entity.Property(e => e.HblNoFlag).HasComment("J to default the HB/L same as Job No.");

                entity.Property(e => e.HblPrefix).HasComment("NOT IN USE");

                entity.Property(e => e.HideTsButtonFlag).HasComment("if set as 'Y', then it will hide Export Info and T/S Info buttons");

                entity.Property(e => e.HouseSeqNoFlag).HasComment("Set as Y to update the House Seq No in Jmjm1 when any house job is create in sea export");

                entity.Property(e => e.InvoiceTrfBy).HasComment("NOT IN USE");

                entity.Property(e => e.JobDateType).HasComment("Job Date is defined as ETA/ETD - ETA Date or JCD - Job Creation Date");

                entity.Property(e => e.JobFormatType).HasComment("Set as 0: Direct/Master= 00; House= 01-99. Set as 1: Direct= Z; Master= 0; House= A-Y");

                entity.Property(e => e.JobNoFlag).HasComment("Job running no. is created by C - Continously, M - Monthly, S - Shipment Type");

                entity.Property(e => e.JobNoFormat).HasComment("[FXX:Std Prefix],[SFX:Suffix],[S:Shipment Type],[ORG:Origin Code],[DST:Dest Code],[MM:01-12],[M:1-9/A-C],[YY:01-99],[Y:0-9]");

                entity.Property(e => e.JobPostBy).HasComment("NOT IN USE");

                entity.Property(e => e.JobPrefix1).HasComment("Job Prefix 1 Format select one value from YY,MM,DST or FXX");

                entity.Property(e => e.JobPrefix2).HasComment("Job Prefix 2 Format select one value from YY,MM,DST or FXX");

                entity.Property(e => e.JobPrefix3).HasComment("Job Prefix 3 Format select one value from YY,MM,DST or FXX");

                entity.Property(e => e.JobPrefix4).HasComment("Job Prefix 4 Format select one value from YY,MM,DST or FXX");

                entity.Property(e => e.JobPrefix5).HasComment("Job Prefix 5 Format select one value from YY,MM,DST or FXX");

                entity.Property(e => e.K1).HasComment("For Malaysia Custom System Form K1");

                entity.Property(e => e.K2).HasComment("For Malaysia Custom System Form K2");

                entity.Property(e => e.K3).HasComment("For Malaysia Custom System Form K3");

                entity.Property(e => e.K4).HasComment("For Malaysia Custom System Form K4");

                entity.Property(e => e.K5).HasComment("For Malaysia Custom System Form K5");

                entity.Property(e => e.K6).HasComment("For Malaysia Custom System Form K6");

                entity.Property(e => e.K7).HasComment("For Malaysia Custom System Form K7");

                entity.Property(e => e.K8).HasComment("For Malaysia Custom System Form K8");

                entity.Property(e => e.K9).HasComment("For Malaysia Custom System Form K9");

                entity.Property(e => e.LastInvoiceTrfDate).HasComment("NOT IN USE");

                entity.Property(e => e.LastJobPostDate).HasComment("NOT IN USE");

                entity.Property(e => e.LockFreightCollectFlag).HasComment("If set as 'N', then it will not lock the Freight Collect. If set as 'Y', for sibl1 transhipment job if already generate export job no(sebl1), the sibl1.FreightCollect will show sebl3 record");

                entity.Property(e => e.LockTranshipmentRateFlag).HasComment("if set as 'Y', then it will lock the Transhipment Rate and Imort Rate in sebl1 and sibl1 for Transhipment Job if the Job is closed either in sebl1 or sibl1");

                entity.Property(e => e.LockTsJobExportCloseFlag).HasComment("set to Y it will lock the sibl2(Cargo Info tab) if the export booking ‘s Master Job in sebl1 CloseConsolFlag =Y");

                entity.Property(e => e.NextConsolJobNo).HasComment("Next Consol Job No");

                entity.Property(e => e.NextDirectJobNo).HasComment("Next Direct Job No");

                entity.Property(e => e.NextDraftOblno).HasComment("NOT IN USE");

                entity.Property(e => e.NextHblNo).HasComment("NOT IN USE");

                entity.Property(e => e.NextJobNo).HasComment("Next Job No when Job No Flag is set as C");

                entity.Property(e => e.NextJobNoMth01).HasComment("Next Job No for Mth 01 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth02).HasComment("Next Job No for Mth 02 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth03).HasComment("Next Job No for Mth 03 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth04).HasComment("Next Job No for Mth 04 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth05).HasComment("Next Job No for Mth 05 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth06).HasComment("Next Job No for Mth 06 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth07).HasComment("Next Job No for Mth 07 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth08).HasComment("Next Job No for Mth 08 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth09).HasComment("Next Job No for Mth 09 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth10).HasComment("Next Job No for Mth 10 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth11).HasComment("Next Job No for Mth 11 when Job No Flag is set as M");

                entity.Property(e => e.NextJobNoMth12).HasComment("Next Job No for Mth 12 when Job No Flag is set as M");

                entity.Property(e => e.PermitName).HasComment("It will replace the label name of the Permit/Approve No in B/L shipment info");

                entity.Property(e => e.PromptTranshipmentInfoFlag).HasComment("If set as 'N', then it will hide the button 'T/S Info' and don't prompt the T/S Info screen. If set as 'Y' or blank, then existing logic");

                entity.Property(e => e.RebateItemCode).HasComment("Define the Rebate Item Code when click the Rebate button under the Billing Info and click the button Transhipment button under the Document List");

                entity.Property(e => e.SetDescriptionLength).HasComment("Set the Description length in Cargo info");

                entity.Property(e => e.SetDescriptionRow).HasComment("Set the Description row in Cargo info");

                entity.Property(e => e.SetMarksLength).HasComment("Set the Mark length in Cargo info");

                entity.Property(e => e.ShowConsolColumn).HasComment("e.g if leave blank, then those 4 columns – N,T,R,W will show on the grid. If set as ‘N,T’, then just show N and T column. Same the logic for Import Consol");

                entity.Property(e => e.ShowDgCargoTabFlag).HasComment("if set as 'Y', then the DG Cargo is 'Y', then show the DG Cargo Tab and hide the '...' button and the below 4 text box - Un No, IMCO, FP, PSN. if set as 'N' or leave blank, then use old logic (don't show the DG Cargo tab even if the DG Cargo is 'Y')");

                entity.Property(e => e.ShowExportInfoFlag).HasComment("If set as ‘Y’, then when transhipmentFlag=’Y’ and there is Export Info will change to show sebk1 details");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.StorageChargeCode).HasComment("Define the Storage Charge Code");

                entity.Property(e => e.TranshipmentBookingNoFlag).HasComment("If set as 'Y', then when click the button 'Create Booking' on T/S Info in sibl1 or click the button 'Consol Booking' in sibl1 to create the booking, the Booking No's Prefix should be sipa1.TranshipmentBookingPrefix , and next no generate accroding sanm1");

                entity.Property(e => e.TranshipmentBookingPrefix).HasComment("Define the  prefix for Booking No when create the booking from sibl1.");

                entity.Property(e => e.TranshipmentHideTabFlag).HasComment("If set as ‘Y’, then when sibl1.TranshipmentFlag=’Y’, hide the ‘Delivery Info’ and ‘Vessel Detail’ tabl in sibl1");

                entity.Property(e => e.TranshipmentItemCode).HasComment("Define the Item Code in ivcr2 when create invoice accroding Transhipment button under the Document List");

                entity.Property(e => e.TranshipmentItemDescription).HasComment("Define the Remark of Item Description in ivcr2 when create invoice accroding Transhipment button under the Document List");

                entity.Property(e => e.TsFrtCollectFlag).HasComment("If set as N, when TranshipmentFlag is Y in sibl1, the Qty, UnitRate, CurrCode, CurrRate, LocalAmt, Amt  in Freight Collect screen do not update to Billing Info screen and Jost Costing.");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ViewExportConsolBookingFlag).HasComment("If set as 'N', then it will not call up sebk1 but it will auto create the booking in export and prompt user “The new export booking xxxxxx is created. “");
            });

            modelBuilder.Entity<Sipv1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .IsClustered(false);

                entity.HasIndex(e => e.VoucherNo, "IX_sipv1")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PostFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Sipv2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Sipv2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sipv2_sipv1");
            });

            modelBuilder.Entity<Sits1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatebyDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CurrCodeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CurrCode)
                    .HasConstraintName("FK_sits1_glex1");

                entity.HasOne(d => d.DivisionCodeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.DivisionCode)
                    .HasConstraintName("FK_sits1_acdv1");
            });

            modelBuilder.Entity<Sits2>(entity =>
            {
                entity.HasOne(d => d.ContainerTypeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ContainerType)
                    .HasConstraintName("FK_sits2_rcco1");
            });

            modelBuilder.Entity<SlAdvancePayment>(entity =>
            {
                entity.ToView("sl_Advance_Payment");
            });

            modelBuilder.Entity<SlCustomerReceipt1>(entity =>
            {
                entity.ToView("sl_Customer_Receipt_1");

                entity.Property(e => e.BankSlipDate).IsFixedLength();

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.ClearDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();
            });

            modelBuilder.Entity<SlCustomerReceipt2>(entity =>
            {
                entity.ToView("sl_Customer_Receipt_2");

                entity.Property(e => e.BankSlipDate).IsFixedLength();

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.ClearDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();
            });

            modelBuilder.Entity<SlPlTransaction>(entity =>
            {
                entity.ToView("sl_Pl_Transaction");

                entity.Property(e => e.AgeingDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();
            });

            modelBuilder.Entity<SlPlVat>(entity =>
            {
                entity.ToView("sl_Pl_Vat");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<Slaj1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PostFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");

                entity.HasOne(d => d.CurrCodeNavigation)
                    .WithMany(p => p.Slaj1s)
                    .HasForeignKey(d => d.CurrCode)
                    .HasConstraintName("FK_slaj1_glex1");

                entity.HasOne(d => d.SalesItemCodeNavigation)
                    .WithMany(p => p.Slaj1s)
                    .HasForeignKey(d => d.SalesItemCode)
                    .HasConstraintName("FK_slaj1_acit1");
            });

            modelBuilder.Entity<Slbs1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Slcc1>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_Slcc1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Slcm1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Slcm2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Slcm2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_slcm2_slcm1");
            });

            modelBuilder.Entity<Slcr1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .IsClustered(false);

                entity.HasIndex(e => e.RefNo, "INDEX_slcr1_RefNo")
                    .IsClustered();

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PostFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.ReconcilFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Slcr2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Slcr2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_slcr2_slcr1");
            });

            modelBuilder.Entity<Slcr3>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Slcr4>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Slcs1>(entity =>
            {
                entity.HasKey(e => e.KeyId)
                    .HasName("PK_slds1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CurrCodeNavigation)
                    .WithMany(p => p.Slcs1s)
                    .HasForeignKey(d => d.CurrCode)
                    .HasConstraintName("FK_slcs1_glex1");
            });

            modelBuilder.Entity<Slcs2>(entity =>
            {
                entity.Property(e => e.Amt).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.LocalAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<Slct1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Slcu1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");

                entity.HasOne(d => d.AreaCodeNavigation)
                    .WithMany(p => p.Slcu1s)
                    .HasForeignKey(d => d.AreaCode)
                    .HasConstraintName("FK_slcu1_acar1");

                entity.HasOne(d => d.CustomerTypeNavigation)
                    .WithMany(p => p.Slcu1s)
                    .HasForeignKey(d => d.CustomerType)
                    .HasConstraintName("FK_slcu1_slct1");

                entity.HasOne(d => d.DivisionCodeNavigation)
                    .WithMany(p => p.Slcu1s)
                    .HasForeignKey(d => d.DivisionCode)
                    .HasConstraintName("FK_slcu1_acdv1");
            });

            modelBuilder.Entity<Slcu2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Slcu3>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Slcu4>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Slcu5>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.AgeingDate });
            });

            modelBuilder.Entity<Slcu6>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Slpa1>(entity =>
            {
                entity.Property(e => e.UniqueKey).HasComment("test");

                entity.Property(e => e.AdjustPrefix).HasComment("Define Ref No Prefix in slaj1/jmaj1");

                entity.Property(e => e.AgeingType).HasComment("NOT IN USE");

                entity.Property(e => e.AgentCode).HasComment("NOT IN USE");

                entity.Property(e => e.AttnName).HasComment("Use in report e.g. Customer Reminder");

                entity.Property(e => e.AutoPostFlag).HasComment("If set as 'Y', it will call the post store prcedure auotmatically as long as the record exit the form if the record is not posted and not deleted");

                entity.Property(e => e.AutoReverseCreditNoteFlag).HasComment("Allow to reverse the Invoice by Credit note");

                entity.Property(e => e.BankAccCode).HasComment("Default the Bank Acc Code to the Customer Receipt if Bank Code is blank");

                entity.Property(e => e.BankCode1).HasComment("Default the Bank Code 1 to the Customer Receipt form when user select Receipt Type 1");

                entity.Property(e => e.BankCode10).HasComment("Default the Bank Code 10 to the Customer Receipt form when user select Receipt Type 10");

                entity.Property(e => e.BankCode11).HasComment("Default the Bank Code 11 to the Customer Receipt form when user select Receipt Type 11");

                entity.Property(e => e.BankCode12).HasComment("Default the Bank Code 12 to the Customer Receipt form when user select Receipt Type 12");

                entity.Property(e => e.BankCode13).HasComment("Default the Bank Code 13 to the Customer Receipt form when user select Receipt Type 13");

                entity.Property(e => e.BankCode14).HasComment("Default the Bank Code 14 to the Customer Receipt form when user select Receipt Type 14");

                entity.Property(e => e.BankCode15).HasComment("Default the Bank Code 15 to the Customer Receipt form when user select Receipt Type 15");

                entity.Property(e => e.BankCode16).HasComment("Default the Bank Code 16 to the Customer Receipt form when user select Receipt Type 16");

                entity.Property(e => e.BankCode17).HasComment("Default the Bank Code 17 to the Customer Receipt form when user select Receipt Type 17");

                entity.Property(e => e.BankCode18).HasComment("Default the Bank Code 18 to the Customer Receipt form when user select Receipt Type 18");

                entity.Property(e => e.BankCode19).HasComment("Default the Bank Code 19 to the Customer Receipt form when user select Receipt Type 19");

                entity.Property(e => e.BankCode2).HasComment("Default the Bank Code 2 to the Customer Receipt form when user select Receipt Type 2");

                entity.Property(e => e.BankCode20).HasComment("Default the Bank Code 20 to the Customer Receipt form when user select Receipt Type 20");

                entity.Property(e => e.BankCode3).HasComment("Default the Bank Code 3 to the Customer Receipt form when user select Receipt Type 3");

                entity.Property(e => e.BankCode4).HasComment("Default the Bank Code 4 to the Customer Receipt form when user select Receipt Type 4");

                entity.Property(e => e.BankCode5).HasComment("Default the Bank Code 5 to the Customer Receipt form when user select Receipt Type 5");

                entity.Property(e => e.BankCode6).HasComment("Default the Bank Code 6 to the Customer Receipt form when user select Receipt Type 6");

                entity.Property(e => e.BankCode7).HasComment("Default the Bank Code 7 to the Customer Receipt form when user select Receipt Type 7");

                entity.Property(e => e.BankCode8).HasComment("Default the Bank Code 8 to the Customer Receipt form when user select Receipt Type 8");

                entity.Property(e => e.BankCode9).HasComment("Default the Bank Code 9 to the Customer Receipt form when user select Receipt Type 9");

                entity.Property(e => e.CashPrefix).HasComment("The Ref No. and Journal No. Prefix for the Cash Receipt");

                entity.Property(e => e.CombineStatementFlag).HasComment("NOT IN USE");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditCheckBookingErrorFlag).HasComment("Verify the Customer credit limit when click Booking confirm or call the confirm booking sreen or click AWB Button in the booking.");

                entity.Property(e => e.CreditCheckErrorFlag).HasComment("Verify the customer credit limit when entering the job in operation. Y - Verify and stop the user to continue. N - Verify but give user warning only");

                entity.Property(e => e.CreditLimitEmailAddress).HasComment("Define Email address. when enter the CustomerCode, the Credit Limit has exceeded it will auto send email");

                entity.Property(e => e.CreditPrefix).HasComment("The Ref No. and Journal No. Prefix for the Invoice");

                entity.Property(e => e.CustomerCodeLength).HasComment("Define the length of the Customer Code when auto generate the customer code exclude the first letter of the name");

                entity.Property(e => e.Designation).HasComment("Use in report e.g. Customer Reminder");

                entity.Property(e => e.ExGainLossAccCode).HasComment("Default the Account Code for Foreign Exchange Difference");

                entity.Property(e => e.InvoiceFlag).HasComment("If set as’Y’, then show the button ‘Invoice’ instead the button ‘Trf’ and ‘Unpaid Invoice’ and hide the button 'Contra', 'Advance' and ExDiff' and also should not check if the balance is '0' or not in slcr1 in operation. Also show the slcr3 instead slcr2 and display only.");

                entity.Property(e => e.LinkOpFlag).HasComment("Link to the Operation Invoice. If N, the Billing Party in the invoice will not link to Customer Code.If set Y, the Billing Party F4 search can not show the Business Party without Customer Code");

                entity.Property(e => e.LockPaidInvoiceFlag).HasComment("if set as Y, then the slcr2 amt will be locked when PaidInvoiceFlag=C,I or V");

                entity.Property(e => e.MultiCurrFlag).HasComment("Allow Multiple Currencies of the Invoice or Customer Receipt if the Currency Code is entered to the Bank Code");

                entity.Property(e => e.NextCashReceiptNo).HasComment("NOT IN USE");

                entity.Property(e => e.NextJournalNo)
                    .HasDefaultValueSql("('1')")
                    .HasComment("Next Journal No to generate when posting");

                entity.Property(e => e.NextOfficialReceiptNo).HasComment("Next Official Receipt No.");

                entity.Property(e => e.NextPostDate).HasComment("NOT IN USE");

                entity.Property(e => e.NextWithHoldingTaxNo).HasComment("Default the next running no. of the With Holding Tax in the Customer Receipt");

                entity.Property(e => e.NoOfDaysPast).HasComment("NOT IN USE");

                entity.Property(e => e.OpCustomerCodeFlag).HasComment("If set as Y, Press F4 or auto search at the Customer Code in aebk1, aeaw1, aiaw1, sebk1, sebl1, sibl1 will filter the rcbp1 only with Customer Code");

                entity.Property(e => e.OriginalCurrRateFlag).HasComment("Default the Original Currency Rate of the invoice when settlement of the invoice");

                entity.Property(e => e.PostDetailFlag).HasComment("Specify if the posting should update the Sales Ledger to General Ledger with Detail. It works only when specify the posting by Batch");

                entity.Property(e => e.PostOnlineOrBatch).HasComment("O - Post directly to General Ledger, B - Post by Batch to Sales Journal and then post to General Ledger when posting End of Month");

                entity.Property(e => e.PromptPostFlag).HasComment("When exit out the Customer Receipt will prompt user if it is not posted.");

                entity.Property(e => e.ReceiptAdjustFlag).HasComment("Y to show an Adjustment button in the Customer Receipt to adjust the Local Receipt Amount");

                entity.Property(e => e.ReceiptPrefix).HasComment("The Ref No. and Journal No. Prefix for the Customer Receipt");

                entity.Property(e => e.ReceiptType1).HasComment("Set the Receipt Type for Customer Receipt form");

                entity.Property(e => e.ReceiptType10).HasComment("Set the Receipt Type for Customer Receipt form");

                entity.Property(e => e.ReceiptType11).HasComment("Set the Receipt Type for Customer Receipt form");

                entity.Property(e => e.ReceiptType12).HasComment("Set the Receipt Type for Customer Receipt form");

                entity.Property(e => e.ReceiptType13).HasComment("Set the Receipt Type for Customer Receipt form");

                entity.Property(e => e.ReceiptType14).HasComment("Set the Receipt Type for Customer Receipt form");

                entity.Property(e => e.ReceiptType15).HasComment("Set the Receipt Type for Customer Receipt form");

                entity.Property(e => e.ReceiptType16).HasComment("Set the Receipt Type for Customer Receipt form");

                entity.Property(e => e.ReceiptType17).HasComment("Set the Receipt Type for Customer Receipt form");

                entity.Property(e => e.ReceiptType18).HasComment("Set the Receipt Type for Customer Receipt form");

                entity.Property(e => e.ReceiptType19).HasComment("Set the Receipt Type for Customer Receipt form");

                entity.Property(e => e.ReceiptType2).HasComment("Set the Receipt Type for Customer Receipt form");

                entity.Property(e => e.ReceiptType20).HasComment("Set the Receipt Type for Customer Receipt form");

                entity.Property(e => e.ReceiptType3).HasComment("Set the Receipt Type for Customer Receipt form");

                entity.Property(e => e.ReceiptType4).HasComment("Set the Receipt Type for Customer Receipt form");

                entity.Property(e => e.ReceiptType5).HasComment("Set the Receipt Type for Customer Receipt form");

                entity.Property(e => e.ReceiptType6).HasComment("Set the Receipt Type for Customer Receipt form");

                entity.Property(e => e.ReceiptType7).HasComment("Set the Receipt Type for Customer Receipt form");

                entity.Property(e => e.ReceiptType8).HasComment("Set the Receipt Type for Customer Receipt form");

                entity.Property(e => e.ReceiptType9).HasComment("Set the Receipt Type for Customer Receipt form");

                entity.Property(e => e.ReversePostOnlineOrBatch).HasComment("When Reverse Posting of the cusotmer receipt, O - delete the record in GL, B - insert the reversal entry in GL");

                entity.Property(e => e.RoundOffAccCode).HasComment("Default the Account Code for Rounding Difference");

                entity.Property(e => e.SalesmanByCustomerFlag).HasComment("NOT IN USE IN NET SYSFREIGHT");

                entity.Property(e => e.ShowCustomerBalanceFlag).HasComment("NOT IN USE IN NET SYSFREIGHT");

                entity.Property(e => e.ShowReceiptButtonFlag).HasComment("When set as Y, it will show Receipt button in slcr1 form.");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UnrealiseAccCode).HasComment("When generate gljv1 record from Currency Revaluation, one Acc Code pull this for AR");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateVatFlag).HasComment("NOT IN USE IN NET SYSFREIGHT");

                entity.Property(e => e.VatRegistrationNo).HasComment("NOT IN USE");

                entity.Property(e => e.VoucherNoAutoManualFlag).HasComment("A - Auto Receipt No, M - Manual Receipt No , B - Both");

                entity.Property(e => e.WholdTaxAccCode).HasComment("Default the Account Code of the With Holding Tax");
            });

            modelBuilder.Entity<Sltx1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<SltxCheck>(entity =>
            {
                entity.ToView("SltxCheck");
            });

            modelBuilder.Entity<SltxCheck2>(entity =>
            {
                entity.ToView("SltxCheck2");
            });

            modelBuilder.Entity<Slvx1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Smbr1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Smbr2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Smbr2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_smbr2_smbr1");
            });

            modelBuilder.Entity<Smct1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Smct2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.Property(e => e.BillTypeFlag).HasDefaultValueSql("('U')");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Smct3>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo, e.ZoneCode });

                entity.Property(e => e.ZoneCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BreakRateType).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.QuoteRate).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<Smec1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Smec2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.HasOne(d => d.CommodityCodeNavigation)
                    .WithMany(p => p.Smec2s)
                    .HasForeignKey(d => d.CommodityCode)
                    .HasConstraintName("FK_smec2_rccm1");

                entity.HasOne(d => d.ContainerType01Navigation)
                    .WithMany(p => p.Smec2ContainerType01Navigations)
                    .HasForeignKey(d => d.ContainerType01)
                    .HasConstraintName("FK_smec2_rcco1");

                entity.HasOne(d => d.ContainerType02Navigation)
                    .WithMany(p => p.Smec2ContainerType02Navigations)
                    .HasForeignKey(d => d.ContainerType02)
                    .HasConstraintName("FK_smec2_rcco11");

                entity.HasOne(d => d.ContainerType03Navigation)
                    .WithMany(p => p.Smec2ContainerType03Navigations)
                    .HasForeignKey(d => d.ContainerType03)
                    .HasConstraintName("FK_smec2_rcco12");

                entity.HasOne(d => d.ContainerType04Navigation)
                    .WithMany(p => p.Smec2ContainerType04Navigations)
                    .HasForeignKey(d => d.ContainerType04)
                    .HasConstraintName("FK_smec2_rcco13");

                entity.HasOne(d => d.ContainerType05Navigation)
                    .WithMany(p => p.Smec2ContainerType05Navigations)
                    .HasForeignKey(d => d.ContainerType05)
                    .HasConstraintName("FK_smec2_rcco14");

                entity.HasOne(d => d.ContainerType06Navigation)
                    .WithMany(p => p.Smec2ContainerType06Navigations)
                    .HasForeignKey(d => d.ContainerType06)
                    .HasConstraintName("FK_smec2_rcco15");

                entity.HasOne(d => d.ContainerType07Navigation)
                    .WithMany(p => p.Smec2ContainerType07Navigations)
                    .HasForeignKey(d => d.ContainerType07)
                    .HasConstraintName("FK_smec2_rcco16");

                entity.HasOne(d => d.ContainerType08Navigation)
                    .WithMany(p => p.Smec2ContainerType08Navigations)
                    .HasForeignKey(d => d.ContainerType08)
                    .HasConstraintName("FK_smec2_rcco17");

                entity.HasOne(d => d.ContainerType09Navigation)
                    .WithMany(p => p.Smec2ContainerType09Navigations)
                    .HasForeignKey(d => d.ContainerType09)
                    .HasConstraintName("FK_smec2_rcco18");

                entity.HasOne(d => d.ContainerType10Navigation)
                    .WithMany(p => p.Smec2ContainerType10Navigations)
                    .HasForeignKey(d => d.ContainerType10)
                    .HasConstraintName("FK_smec2_rcco19");

                entity.HasOne(d => d.ContainerType11Navigation)
                    .WithMany(p => p.Smec2ContainerType11Navigations)
                    .HasForeignKey(d => d.ContainerType11)
                    .HasConstraintName("FK_smec2_rcco110");

                entity.HasOne(d => d.ContainerType12Navigation)
                    .WithMany(p => p.Smec2ContainerType12Navigations)
                    .HasForeignKey(d => d.ContainerType12)
                    .HasConstraintName("FK_smec2_rcco111");

                entity.HasOne(d => d.ContainerType13Navigation)
                    .WithMany(p => p.Smec2ContainerType13Navigations)
                    .HasForeignKey(d => d.ContainerType13)
                    .HasConstraintName("FK_smec2_rcco112");

                entity.HasOne(d => d.ContainerType14Navigation)
                    .WithMany(p => p.Smec2ContainerType14Navigations)
                    .HasForeignKey(d => d.ContainerType14)
                    .HasConstraintName("FK_smec2_rcco113");

                entity.HasOne(d => d.ContainerType15Navigation)
                    .WithMany(p => p.Smec2ContainerType15Navigations)
                    .HasForeignKey(d => d.ContainerType15)
                    .HasConstraintName("FK_smec2_rcco114");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Smec2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_smec2_smec1");
            });

            modelBuilder.Entity<Smef1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Smef2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Smef2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_smef2_smef1");
            });

            modelBuilder.Entity<Smfd1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .IsClustered(false);

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Smfd2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Smfq1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Smfq2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.QuoteLineItemNo });
            });

            modelBuilder.Entity<Smfq3>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.QuoteLineItemNo, e.LineItemNo });

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Smfq4>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo })
                    .HasName("PK_Smfq4");

                entity.Property(e => e.ActualCostAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.Amt).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostCurrRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostUnitRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.LocalAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.Qty).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Smfq6>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Smfq6s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_smfq6_smfq1");
            });

            modelBuilder.Entity<Smhq1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.QuotationTableNoNavigation)
                    .WithMany(p => p.Smhq1s)
                    .HasForeignKey(d => d.QuotationTableNo)
                    .HasConstraintName("FK_smhq1_smht1");
            });

            modelBuilder.Entity<Smhq2>(entity =>
            {
                entity.HasKey(e => new { e.CustomerCode, e.LineItemNo });

                entity.HasOne(d => d.CurrCodeNavigation)
                    .WithMany(p => p.Smhq2s)
                    .HasForeignKey(d => d.CurrCode)
                    .HasConstraintName("FK_smhq2_glex1");

                entity.HasOne(d => d.CustomerCodeNavigation)
                    .WithMany(p => p.Smhq2s)
                    .HasForeignKey(d => d.CustomerCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_smhq2_smhq1");

                entity.HasOne(d => d.SalesItemCodeNavigation)
                    .WithMany(p => p.Smhq2s)
                    .HasForeignKey(d => d.SalesItemCode)
                    .HasConstraintName("FK_smhq2_acit1");

                entity.HasOne(d => d.UomCodeNavigation)
                    .WithMany(p => p.Smhq2s)
                    .HasForeignKey(d => d.UomCode)
                    .HasConstraintName("FK_smhq2_rcum1");
            });

            modelBuilder.Entity<Smht1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Smht2>(entity =>
            {
                entity.HasKey(e => new { e.QuotationTableNo, e.LineItemNo });

                entity.HasOne(d => d.CurrCodeNavigation)
                    .WithMany(p => p.Smht2s)
                    .HasForeignKey(d => d.CurrCode)
                    .HasConstraintName("FK_smht2_glex1");

                entity.HasOne(d => d.QuotationTableNoNavigation)
                    .WithMany(p => p.Smht2s)
                    .HasForeignKey(d => d.QuotationTableNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_smht2_smht1");

                entity.HasOne(d => d.SalesItemCodeNavigation)
                    .WithMany(p => p.Smht2s)
                    .HasForeignKey(d => d.SalesItemCode)
                    .HasConstraintName("FK_smht2_acit1");

                entity.HasOne(d => d.UomCodeNavigation)
                    .WithMany(p => p.Smht2s)
                    .HasForeignKey(d => d.UomCode)
                    .HasConstraintName("FK_smht2_rcum1");
            });

            modelBuilder.Entity<Smic1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Smic2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.HasOne(d => d.CommodityCodeNavigation)
                    .WithMany(p => p.Smic2s)
                    .HasForeignKey(d => d.CommodityCode)
                    .HasConstraintName("FK_smic2_rccm1");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Smic2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_smic2_smic1");
            });

            modelBuilder.Entity<Smif1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CurrCodeNavigation)
                    .WithMany(p => p.Smif1s)
                    .HasForeignKey(d => d.CurrCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_smif1_glex1");
            });

            modelBuilder.Entity<Smif2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.HasOne(d => d.CommodityCodeNavigation)
                    .WithMany(p => p.Smif2s)
                    .HasForeignKey(d => d.CommodityCode)
                    .HasConstraintName("FK_smif2_rccm1");
            });

            modelBuilder.Entity<Smiq1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.QuotationTableNoNavigation)
                    .WithMany(p => p.Smiq1s)
                    .HasForeignKey(d => d.QuotationTableNo)
                    .HasConstraintName("FK_smiq1_smit1");
            });

            modelBuilder.Entity<Smiq2>(entity =>
            {
                entity.HasKey(e => new { e.CustomerCode, e.LineItemNo });

                entity.HasOne(d => d.CustomerCodeNavigation)
                    .WithMany(p => p.Smiq2s)
                    .HasForeignKey(d => d.CustomerCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_smiq2_smiq1");

                entity.HasOne(d => d.SalesItemCodeNavigation)
                    .WithMany(p => p.Smiq2s)
                    .HasForeignKey(d => d.SalesItemCode)
                    .HasConstraintName("FK_smiq2_acit1");

                entity.HasOne(d => d.UomCodeNavigation)
                    .WithMany(p => p.Smiq2s)
                    .HasForeignKey(d => d.UomCode)
                    .HasConstraintName("FK_smiq2_rcum1");
            });

            modelBuilder.Entity<Smit1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Smit2>(entity =>
            {
                entity.HasKey(e => new { e.QuotationTableNo, e.LineItemNo });

                entity.HasOne(d => d.QuotationTableNoNavigation)
                    .WithMany(p => p.Smit2s)
                    .HasForeignKey(d => d.QuotationTableNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_smit2_smit1");

                entity.HasOne(d => d.SalesItemCodeNavigation)
                    .WithMany(p => p.Smit2s)
                    .HasForeignKey(d => d.SalesItemCode)
                    .HasConstraintName("FK_smit2_acit1");

                entity.HasOne(d => d.UomCodeNavigation)
                    .WithMany(p => p.Smit2s)
                    .HasForeignKey(d => d.UomCode)
                    .HasConstraintName("FK_smit2_rcum1");
            });

            modelBuilder.Entity<Smpa1>(entity =>
            {
                entity.HasKey(e => e.UniqueKey)
                    .IsClustered(false);

                entity.Property(e => e.BafItemCode).HasComment("NOT IN USE");

                entity.Property(e => e.CafItemCode).HasComment("Default Caf Item Code in the Freight Quotation.  It must be a valid code in Charge List in Account Reference.The CAF must enter immediately after the Freight Charge.");

                entity.Property(e => e.CheckEffectiveDate).HasComment("If set as N, then in the Job Costing, when click the button 'Charges' or 'Cost', system should not filter EffectiveDate and Expiry Date");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrCode).HasComment("NOT IN USE");

                entity.Property(e => e.DdcItemCode).HasComment("NOT IN USE");

                entity.Property(e => e.DefineUomCode01).HasComment("NOT IN USE");

                entity.Property(e => e.DefineUomCode02).HasComment("NOT IN USE");

                entity.Property(e => e.DefineUomCode03).HasComment("NOT IN USE");

                entity.Property(e => e.DefineUomCode04).HasComment("NOT IN USE");

                entity.Property(e => e.DefineUomCode05).HasComment("NOT IN USE");

                entity.Property(e => e.DefineUomCode06).HasComment("NOT IN USE");

                entity.Property(e => e.DefineUomCode07).HasComment("NOT IN USE");

                entity.Property(e => e.DefineUomCode08).HasComment("NOT IN USE");

                entity.Property(e => e.DefineUomCode09).HasComment("NOT IN USE");

                entity.Property(e => e.DefineUomCode10).HasComment("NOT IN USE");

                entity.Property(e => e.DefineUomCode11).HasComment("NOT IN USE");

                entity.Property(e => e.DefineUomCode12).HasComment("NOT IN USE");

                entity.Property(e => e.DefineUomCode13).HasComment("NOT IN USE");

                entity.Property(e => e.DefineUomCode14).HasComment("NOT IN USE");

                entity.Property(e => e.DefineUomCode15).HasComment("NOT IN USE");

                entity.Property(e => e.Dg20ItemCode).HasComment("Default Dg 20 Item Code in the Freight Quotation.  It must be a valid code in Charge List in Account Reference.");

                entity.Property(e => e.Dg40HcItemCode).HasComment("Default Dg 40 Hc Item Code in the Freight Quotation.  It must be a valid code in Charge List in Account Reference.");

                entity.Property(e => e.Dg40ItemCode).HasComment("Default Dg 40 Item Code in the Freight Quotation.  It must be a valid code in Charge List in Account Reference.");

                entity.Property(e => e.DgLclItemCode).HasComment("Default Dg Lcl Item Code in the Freight Quotation.  It must be a valid code in Charge List in Account Reference.");

                entity.Property(e => e.FormatType).HasComment("Quotation No format\r\n- If set as 1, Quotation No format is Quotation Type(2 digits) + Salesman Code(2 digits) + YY + Next No\r\n- If leave blank, Quotation No format is Salesman Code + ‘-‘ + A + No(5 digits)");

                entity.Property(e => e.Ft20ItemCode).HasComment("Default Ft 20 Item Code in the Freight Quotation.  It must be a valid code in Charge List in Account Reference.");

                entity.Property(e => e.Ft40HcItemCode).HasComment("Default Ft 40 Hc Item Code in the Freight Quotation.  It must be a valid code in Charge List in Account Reference.");

                entity.Property(e => e.Ft40ItemCode).HasComment("Default Ft 40 Item Code in the Freight Quotation.  It must be a valid code in Charge List in Account Reference.");

                entity.Property(e => e.FtLclItemCode).HasComment("Default Ft Lcl Item Code in the Freight Quotation.  It must be a valid code in Charge List in Account Reference.");

                entity.Property(e => e.NextQuoteNo).HasComment("Next Quote No");

                entity.Property(e => e.RevTonCheck).HasComment("Just for Master Job, and ChargeUnite=REV TON RND UP in smct1\r\n1. If set as N, then Qty = Master Job’ Charge Weight\r\n2. If set as Y, then Qty = sum House Job’ Charge Weight or sum SubHouse’s Charge Weight");

                entity.Property(e => e.Sc20ItemCode).HasComment("Default Sc 20 Item Code in the Freight Quotation.  It must be a valid code in Charge List in Account Reference.");

                entity.Property(e => e.Sc40HcItemCode).HasComment("Default Sc 40 Hc Item Code in the Freight Quotation.  It must be a valid code in Charge List in Account Reference.");

                entity.Property(e => e.Sc40ItemCode).HasComment("Default Sc 40  Item Code in the Freight Quotation.  It must be a valid code in Charge List in Account Reference.");

                entity.Property(e => e.ScLclItemCode).HasComment("Default SC Lcl Item Code in the Freight Quotation.  It must be a valid code in Charge List in Account Reference.");

                entity.Property(e => e.ShowJobCostingRemarkFlag).HasComment("Set as Y, Show Job Costing Remark as a column instead of picture icon under Job Costing screen.");

                entity.Property(e => e.ShowLockFlag).HasComment("If set as 'Y' then show the Lock Flag on the Charges tab under the smfq1");

                entity.Property(e => e.ShowQuotationFlag).HasComment("If set as Y. then\r\nwhen there is no quotation in the screen base on the default selection. The quotation button will auto hide on the Job Costing and Billing Info screen under the sebk1");

                entity.Property(e => e.SpaceTermConditionFlag).HasComment("If set as N, then when user enter the Term & Condition in smfq1 and then click Standard Clauses it will not have the space between the clauses.");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.TeuM3flag).HasComment("NOT IN USE");

                entity.Property(e => e.TonKgFlag).HasComment("NOT IN USE");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateSmct1AuditLogFlag).HasComment("If set as 'Y', then when change the smct2 will update the smct1.UpdateBy and UpdateDateTime");

                entity.Property(e => e.UpperCaseFlag).HasComment("If set as ‘Y’, then the Note(include the ImportNote and ExportNote) will auto change to capital");

                entity.Property(e => e.ValidityDays).HasComment("Default Validity Days to Freight Quotation");

                entity.HasOne(d => d.BafItemCodeNavigation)
                    .WithMany(p => p.Smpa1BafItemCodeNavigations)
                    .HasForeignKey(d => d.BafItemCode)
                    .HasConstraintName("FK_smpa1_acit11");

                entity.HasOne(d => d.DdcItemCodeNavigation)
                    .WithMany(p => p.Smpa1DdcItemCodeNavigations)
                    .HasForeignKey(d => d.DdcItemCode)
                    .HasConstraintName("FK_smpa1_acit1");

                entity.HasOne(d => d.DefineUomCode01Navigation)
                    .WithMany(p => p.Smpa1DefineUomCode01Navigations)
                    .HasForeignKey(d => d.DefineUomCode01)
                    .HasConstraintName("FK_smpa1_rcum1_1");

                entity.HasOne(d => d.DefineUomCode02Navigation)
                    .WithMany(p => p.Smpa1DefineUomCode02Navigations)
                    .HasForeignKey(d => d.DefineUomCode02)
                    .HasConstraintName("FK_smpa1_rcum1_2");

                entity.HasOne(d => d.DefineUomCode03Navigation)
                    .WithMany(p => p.Smpa1DefineUomCode03Navigations)
                    .HasForeignKey(d => d.DefineUomCode03)
                    .HasConstraintName("FK_smpa1_rcum1_3");

                entity.HasOne(d => d.DefineUomCode04Navigation)
                    .WithMany(p => p.Smpa1DefineUomCode04Navigations)
                    .HasForeignKey(d => d.DefineUomCode04)
                    .HasConstraintName("FK_smpa1_rcum1_4");

                entity.HasOne(d => d.DefineUomCode05Navigation)
                    .WithMany(p => p.Smpa1DefineUomCode05Navigations)
                    .HasForeignKey(d => d.DefineUomCode05)
                    .HasConstraintName("FK_smpa1_rcum1_5");

                entity.HasOne(d => d.DefineUomCode06Navigation)
                    .WithMany(p => p.Smpa1DefineUomCode06Navigations)
                    .HasForeignKey(d => d.DefineUomCode06)
                    .HasConstraintName("FK_smpa1_rcum1_6");

                entity.HasOne(d => d.DefineUomCode07Navigation)
                    .WithMany(p => p.Smpa1DefineUomCode07Navigations)
                    .HasForeignKey(d => d.DefineUomCode07)
                    .HasConstraintName("FK_smpa1_rcum1_7");

                entity.HasOne(d => d.DefineUomCode08Navigation)
                    .WithMany(p => p.Smpa1DefineUomCode08Navigations)
                    .HasForeignKey(d => d.DefineUomCode08)
                    .HasConstraintName("FK_smpa1_rcum1_8");

                entity.HasOne(d => d.DefineUomCode09Navigation)
                    .WithMany(p => p.Smpa1DefineUomCode09Navigations)
                    .HasForeignKey(d => d.DefineUomCode09)
                    .HasConstraintName("FK_smpa1_rcum1_9");

                entity.HasOne(d => d.DefineUomCode10Navigation)
                    .WithMany(p => p.Smpa1DefineUomCode10Navigations)
                    .HasForeignKey(d => d.DefineUomCode10)
                    .HasConstraintName("FK_smpa1_rcum1_10");

                entity.HasOne(d => d.DefineUomCode11Navigation)
                    .WithMany(p => p.Smpa1DefineUomCode11Navigations)
                    .HasForeignKey(d => d.DefineUomCode11)
                    .HasConstraintName("FK_smpa1_rcum1_11");

                entity.HasOne(d => d.DefineUomCode12Navigation)
                    .WithMany(p => p.Smpa1DefineUomCode12Navigations)
                    .HasForeignKey(d => d.DefineUomCode12)
                    .HasConstraintName("FK_smpa1_rcum1_12");

                entity.HasOne(d => d.DefineUomCode13Navigation)
                    .WithMany(p => p.Smpa1DefineUomCode13Navigations)
                    .HasForeignKey(d => d.DefineUomCode13)
                    .HasConstraintName("FK_smpa1_rcum1_13");

                entity.HasOne(d => d.DefineUomCode14Navigation)
                    .WithMany(p => p.Smpa1DefineUomCode14Navigations)
                    .HasForeignKey(d => d.DefineUomCode14)
                    .HasConstraintName("FK_smpa1_rcum1_14");

                entity.HasOne(d => d.DefineUomCode15Navigation)
                    .WithMany(p => p.Smpa1DefineUomCode15Navigations)
                    .HasForeignKey(d => d.DefineUomCode15)
                    .HasConstraintName("FK_smpa1_rcum1_15");
            });

            modelBuilder.Entity<Smqt1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Smsa1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_Smsa1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Smsa2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo })
                    .HasName("PK_Smsa2");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Smsa2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Smsa2_Smsa1");
            });

            modelBuilder.Entity<Ssjd1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CurrCodeNavigation)
                    .WithMany(p => p.Ssjd1s)
                    .HasForeignKey(d => d.CurrCode)
                    .HasConstraintName("FK_ssjd1_glex1");

                entity.HasOne(d => d.ItemCodeNavigation)
                    .WithMany(p => p.Ssjd1s)
                    .HasForeignKey(d => d.ItemCode)
                    .HasConstraintName("FK_ssjd1_acit1");
            });

            modelBuilder.Entity<Ssst1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.PortOfDischargeCodeNavigation)
                    .WithMany(p => p.Ssst1PortOfDischargeCodeNavigations)
                    .HasForeignKey(d => d.PortOfDischargeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ssst1_rcap11");

                entity.HasOne(d => d.PortOfLoadingCodeNavigation)
                    .WithMany(p => p.Ssst1PortOfLoadingCodeNavigations)
                    .HasForeignKey(d => d.PortOfLoadingCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ssst1_rcap1");

                entity.HasOne(d => d.ShippingLineCodeNavigation)
                    .WithMany(p => p.Ssst1s)
                    .HasForeignKey(d => d.ShippingLineCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ssst1_rcsl1");
            });

            modelBuilder.Entity<Sysconstraint>(entity =>
            {
                entity.ToView("sysconstraints");
            });

            modelBuilder.Entity<Syssegment>(entity =>
            {
                entity.ToView("syssegments");
            });

            modelBuilder.Entity<Tjms1>(entity =>
            {
                entity.Property(e => e.TrxNo).ValueGeneratedNever();
            });

            modelBuilder.Entity<Tmbi1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Tmbi2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Tmbi2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tmbi2_tmbi1");
            });

            modelBuilder.Entity<TmpEdiMessage>(entity =>
            {
                entity.Property(e => e.Sqlstr).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TmpGlbr1>(entity =>
            {
                entity.Property(e => e.TrxNo).ValueGeneratedNever();
            });

            modelBuilder.Entity<Tncl1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Tncp1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK__tncp1__BBFC38606261F230");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Tnem1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Tnex1>(entity =>
            {
                entity.HasKey(e => e.CurrCode)
                    .HasName("PK__tnex1__7B8A6551");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VariancePercent).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Tnex2>(entity =>
            {
                entity.HasKey(e => new { e.CurrCode, e.EffectiveDate })
                    .HasName("PK__tnex2__032B8719");
            });

            modelBuilder.Entity<Tnhs1>(entity =>
            {
                entity.HasKey(e => e.HsCode)
                    .HasName("PK__Tnhs1__212532FD");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Statuscode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Tnmp1>(entity =>
            {
                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");
            });

            modelBuilder.Entity<Tnpa1>(entity =>
            {
                entity.HasKey(e => e.UniqueKey)
                    .HasName("PK__tnpa1__1397C463");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Tnrc1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Tnrf1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Tnrf2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Tnsl1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Tnum1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Toac1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Tobk1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FaxCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Tobk2>(entity =>
            {
                entity.HasKey(e => new { e.BookingNo, e.LineItemNo });

                entity.Property(e => e.ReturnFlag).HasDefaultValueSql("(N'N')");

                entity.HasOne(d => d.BookingNoNavigation)
                    .WithMany(p => p.Tobk2s)
                    .HasForeignKey(d => d.BookingNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tobk2_tobk1");
            });

            modelBuilder.Entity<Tobk3>(entity =>
            {
                entity.HasKey(e => new { e.BookingNo, e.BookingLineItemNo, e.LineItemNo });

                entity.HasOne(d => d.BookingNoNavigation)
                    .WithMany(p => p.Tobk3s)
                    .HasForeignKey(d => d.BookingNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tobk3_tobk1");
            });

            modelBuilder.Entity<Tobk4>(entity =>
            {
                entity.HasKey(e => new { e.BookingNo, e.BookingLineItemNo, e.LineItemNo })
                    .HasName("PK_Tobk4");

                entity.HasOne(d => d.BookingNoNavigation)
                    .WithMany(p => p.Tobk4s)
                    .HasForeignKey(d => d.BookingNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tobk4_tobk1");
            });

            modelBuilder.Entity<Tobk5>(entity =>
            {
                entity.HasKey(e => new { e.BookingNo, e.BookingLineItemNo, e.LineItemNo });
            });

            modelBuilder.Entity<Tobk6>(entity =>
            {
                entity.HasKey(e => new { e.BookingNo, e.LineItemNo });
            });

            modelBuilder.Entity<Toct1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ConfirmCurrentParkAtNavigation)
                    .WithMany(p => p.Toct1ConfirmCurrentParkAtNavigations)
                    .HasForeignKey(d => d.ConfirmCurrentParkAt)
                    .HasConstraintName("FK_toct1_torl1");

                entity.HasOne(d => d.ConfirmLastParkAtNavigation)
                    .WithMany(p => p.Toct1ConfirmLastParkAtNavigations)
                    .HasForeignKey(d => d.ConfirmLastParkAt)
                    .HasConstraintName("FK_toct1_torl11");

                entity.HasOne(d => d.PlanCurrentParkAtNavigation)
                    .WithMany(p => p.Toct1PlanCurrentParkAtNavigations)
                    .HasForeignKey(d => d.PlanCurrentParkAt)
                    .HasConstraintName("FK_toct1_torl12");

                entity.HasOne(d => d.PlanLastParkAtNavigation)
                    .WithMany(p => p.Toct1PlanLastParkAtNavigations)
                    .HasForeignKey(d => d.PlanLastParkAt)
                    .HasConstraintName("FK_toct1_torl13");
            });

            modelBuilder.Entity<Todo1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Todo2>(entity =>
            {
                entity.HasKey(e => new { e.DeliveryOrderNo, e.LineItemNo });

                entity.HasOne(d => d.ContainerTypeNavigation)
                    .WithMany(p => p.Todo2s)
                    .HasForeignKey(d => d.ContainerType)
                    .HasConstraintName("FK_todo2_rcco1");

                entity.HasOne(d => d.DeliveryOrderNoNavigation)
                    .WithMany(p => p.Todo2s)
                    .HasForeignKey(d => d.DeliveryOrderNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_todo2_todo1");

                entity.HasOne(d => d.UomCodeNavigation)
                    .WithMany(p => p.Todo2s)
                    .HasForeignKey(d => d.UomCode)
                    .HasConstraintName("FK_todo2_rcum1");
            });

            modelBuilder.Entity<Todo3>(entity =>
            {
                entity.HasKey(e => new { e.DeliveryOrderNo, e.CargoLineItemNo, e.LineItemNo })
                    .HasName("PK_Todo3");
            });

            modelBuilder.Entity<Todr1>(entity =>
            {
                entity.HasKey(e => e.DriverCode)
                    .HasName("PK_todr1_1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Todr2>(entity =>
            {
                entity.HasKey(e => new { e.DriverCode, e.LineItemNo })
                    .HasName("PK_todr2_1");
            });

            modelBuilder.Entity<Toet1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Toiv1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FaxCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PostFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Toiv2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Toiv2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_toiv2_toiv1");
            });

            modelBuilder.Entity<Topa1>(entity =>
            {
                entity.Property(e => e.Address1).HasComment("Default the Address 1 as Transport Address 1 in the Tobk1");

                entity.Property(e => e.Address2).HasComment("Default the Address 2 as Transport Address 2 in the Tobk1");

                entity.Property(e => e.Address3).HasComment("Default the Address 3 as Transport Address 3 in the Tobk1");

                entity.Property(e => e.Address4).HasComment("Default the Address 4 as Transport Address 4 in the Tobk1");

                entity.Property(e => e.BankCode).HasComment("Define the BankCode to default the BankCode in ivcr1_5");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DocumenationCode).HasComment("NOT IN USE");

                entity.Property(e => e.DocumentFooter1).HasComment("Print to Footer 1 of the Transport related documents");

                entity.Property(e => e.DocumentFooter2).HasComment("Print to Footer 2 of the Transport related documents");

                entity.Property(e => e.DoneFlag).HasComment("If topa1.DoneFlag = \"DRIVER\", tobk1.Driver Code have enter, the \"Done?\" should auto change to \"Y\".\r\nWhen save tobk1,  if \"Done?\" =Y, the system should check if \"Driver Code\" is blank, if blank, system will prompt and prevent user from saving until user updates the Driver Code\"");

                entity.Property(e => e.FilterCustomerCodeFlag).HasComment("If set as 'N', enter Customer Code under Tosh1 grid, the system should not filter rcbp1.PartyType");

                entity.Property(e => e.GlcashAccCode).HasComment("NOT IN USE");

                entity.Property(e => e.JobNoFlag).HasComment("Job running no. is created by C - Continously, M - Monthly ( only for tobk1_3)");

                entity.Property(e => e.JobPrefix1).HasComment("Job Prefix 1 Format select one value from YY,MM,DST or FXX ( only for tobk1_3)");

                entity.Property(e => e.JobPrefix2).HasComment("Job Prefix 2 Format select one value from YY,MM,DST or FXX ( only for tobk1_3)");

                entity.Property(e => e.JobPrefix3).HasComment("Job Prefix 3 Format select one value from YY,MM,DST or FXX ( only for tobk1_3)");

                entity.Property(e => e.JobPrefix4).HasComment("Job Prefix 4 Format select one value from YY,MM,DST or FXX ( only for tobk1_3)");

                entity.Property(e => e.JobPrefix5).HasComment("Job Prefix 5 Format select one value from YY,MM,DST or FXX ( only for tobk1_3)");

                entity.Property(e => e.MonthlyJobSeqNo01).HasComment("Next Job No for Mth 01 when Job No flag is set as M");

                entity.Property(e => e.MonthlyJobSeqNo02).HasComment("Next Job No for Mth 02 when Job No flag is set as M");

                entity.Property(e => e.MonthlyJobSeqNo03).HasComment("Next Job No for Mth 03 when Job No flag is set as M");

                entity.Property(e => e.MonthlyJobSeqNo04).HasComment("Next Job No for Mth 04 when Job No flag is set as M");

                entity.Property(e => e.MonthlyJobSeqNo05).HasComment("Next Job No for Mth 05 when Job No flag is set as M");

                entity.Property(e => e.MonthlyJobSeqNo06).HasComment("Next Job No for Mth 06 when Job No flag is set as M");

                entity.Property(e => e.MonthlyJobSeqNo07).HasComment("Next Job No for Mth 07 when Job No flag is set as M");

                entity.Property(e => e.MonthlyJobSeqNo08).HasComment("Next Job No for Mth 08 when Job No flag is set as M");

                entity.Property(e => e.MonthlyJobSeqNo09).HasComment("Next Job No for Mth 09 when Job No flag is set as M");

                entity.Property(e => e.MonthlyJobSeqNo10).HasComment("Next Job No for Mth 10 when Job No flag is set as M");

                entity.Property(e => e.MonthlyJobSeqNo11).HasComment("Next Job No for Mth 11 when Job No flag is set as M");

                entity.Property(e => e.MonthlyJobSeqNo12).HasComment("Next Job No for Mth 12 when Job No flag is set as M");

                entity.Property(e => e.NextJobNo).HasComment("Next Job No when Job No Flag is set as C");

                entity.Property(e => e.NextTransferDate).HasComment("NOT IN USE");

                entity.Property(e => e.OceanFreightCode).HasComment("NOT IN USE");

                entity.Property(e => e.OddSizeHeight).HasComment("Define the limit height of tobk2");

                entity.Property(e => e.OddSizeLength).HasComment("Define the limit length of tobk2");

                entity.Property(e => e.OddSizeWidth).HasComment("Define the limit width of tobk2");

                entity.Property(e => e.PsaAccCode).HasComment("NOT IN USE");

                entity.Property(e => e.ScheduleFastPrintReportName).HasComment("Define the report name for click the print icon in tosh1.");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.StuffingUnstuffingCode).HasComment("NOT IN USE");

                entity.Property(e => e.StuffingUnstuffingMft).HasComment("NOT IN USE");

                entity.Property(e => e.TransportCompanyCode).HasComment("The Business Party code of the Company. Default as Transport Company Code in the Tobk1");

                entity.Property(e => e.TransportCompanyName).HasComment("The Business Party code of the Company. Default as Transport Company Code in the Tobk1");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WarehouseStorageCode).HasComment("NOT IN USE");
            });

            modelBuilder.Entity<Topa2>(entity =>
            {
                entity.HasKey(e => new { e.ViewName, e.LineItemNo });
            });

            modelBuilder.Entity<Topv1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdiCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Topv2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Topv2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_topv2_topv1");
            });

            modelBuilder.Entity<Torc1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.SalesItemCodeNavigation)
                    .WithMany(p => p.Torc1s)
                    .HasForeignKey(d => d.SalesItemCode)
                    .HasConstraintName("FK_torc1_acit1");
            });

            modelBuilder.Entity<Torl1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Tosh1>(entity =>
            {
                entity.HasKey(e => e.ScheduleId)
                    .HasName("PK_Tosh1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Toso1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Toso2>(entity =>
            {
                entity.HasKey(e => new { e.LineItemNo, e.Sono });
            });

            modelBuilder.Entity<Tost1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Totc1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Totc2>(entity =>
            {
                entity.HasKey(e => new { e.TripCode, e.LineItemNo });
            });

            modelBuilder.Entity<Totd1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Totd2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.HasOne(d => d.ParkingPlaceNavigation)
                    .WithMany(p => p.Totd2s)
                    .HasForeignKey(d => d.ParkingPlace)
                    .HasConstraintName("FK_totd2_torl1");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Totd2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_totd2_totd1");

                entity.HasOne(d => d.VehicleTypeNavigation)
                    .WithMany(p => p.Totd2s)
                    .HasForeignKey(d => d.VehicleType)
                    .HasConstraintName("FK_totd2_tovt1");
            });

            modelBuilder.Entity<Tovl1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ConfirmedCurrentParkAtNavigation)
                    .WithMany(p => p.Tovl1ConfirmedCurrentParkAtNavigations)
                    .HasForeignKey(d => d.ConfirmedCurrentParkAt)
                    .HasConstraintName("FK_tovl1_torl1");

                entity.HasOne(d => d.ConfirmedLastParkAtNavigation)
                    .WithMany(p => p.Tovl1ConfirmedLastParkAtNavigations)
                    .HasForeignKey(d => d.ConfirmedLastParkAt)
                    .HasConstraintName("FK_tovl1_torl11");

                entity.HasOne(d => d.PlanCurrentParkAtNavigation)
                    .WithMany(p => p.Tovl1PlanCurrentParkAtNavigations)
                    .HasForeignKey(d => d.PlanCurrentParkAt)
                    .HasConstraintName("FK_tovl1_torl12");

                entity.HasOne(d => d.PlanLastParkAtNavigation)
                    .WithMany(p => p.Tovl1PlanLastParkAtNavigations)
                    .HasForeignKey(d => d.PlanLastParkAt)
                    .HasConstraintName("FK_tovl1_torl13");

                entity.HasOne(d => d.VehicleTypeNavigation)
                    .WithMany(p => p.Tovl1s)
                    .HasForeignKey(d => d.VehicleType)
                    .HasConstraintName("FK_tovl1_tovt1");
            });

            modelBuilder.Entity<Tovm1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Tovm2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.Property(e => e.Remark).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ServiceType).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VehicleNo).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<Tovt1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Tpts1>(entity =>
            {
                entity.HasKey(e => e.TripType)
                    .IsClustered(false);

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TtBillOfLading>(entity =>
            {
                entity.ToView("tt_BillOfLading");
            });

            modelBuilder.Entity<VwAcar1>(entity =>
            {
                entity.ToView("vw_Acar1");
            });

            modelBuilder.Entity<VwAccg1>(entity =>
            {
                entity.ToView("vw_Accg1");
            });

            modelBuilder.Entity<VwAccm1>(entity =>
            {
                entity.ToView("vw_Accm1");
            });

            modelBuilder.Entity<VwAcct1>(entity =>
            {
                entity.ToView("vw_Acct1");
            });

            modelBuilder.Entity<VwAcct2>(entity =>
            {
                entity.ToView("vw_Acct2");
            });

            modelBuilder.Entity<VwAcdv1>(entity =>
            {
                entity.ToView("vw_Acdv1");
            });

            modelBuilder.Entity<VwAcft1>(entity =>
            {
                entity.ToView("vw_Acft1");
            });

            modelBuilder.Entity<VwAcit1>(entity =>
            {
                entity.ToView("vw_Acit1");
            });

            modelBuilder.Entity<VwAcit2>(entity =>
            {
                entity.ToView("vw_Acit2");
            });

            modelBuilder.Entity<VwAcit3>(entity =>
            {
                entity.ToView("vw_Acit3");
            });

            modelBuilder.Entity<VwActm1>(entity =>
            {
                entity.ToView("vw_Actm1");
            });

            modelBuilder.Entity<VwAcva1>(entity =>
            {
                entity.ToView("vw_Acva1");
            });

            modelBuilder.Entity<VwAcva2>(entity =>
            {
                entity.ToView("vw_Acva2");

                entity.Property(e => e.EffectiveDate).IsFixedLength();
            });

            modelBuilder.Entity<VwAcvr1>(entity =>
            {
                entity.ToView("vw_Acvr1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwAcws1>(entity =>
            {
                entity.ToView("vw_Acws1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwAcwt1>(entity =>
            {
                entity.ToView("vw_Acwt1");
            });

            modelBuilder.Entity<VwAeaw1>(entity =>
            {
                entity.ToView("vw_Aeaw1");

                entity.Property(e => e.CargoReceiptDate).IsFixedLength();

                entity.Property(e => e.ConfirmArrivalDate).IsFixedLength();

                entity.Property(e => e.ConfirmDepartureDate).IsFixedLength();

                entity.Property(e => e.ExecuteDate).IsFixedLength();

                entity.Property(e => e.FirstEtaDate).IsFixedLength();

                entity.Property(e => e.FirstEtaTime).IsFixedLength();

                entity.Property(e => e.FirstFlightDate).IsFixedLength();

                entity.Property(e => e.FirstFlightTime).IsFixedLength();

                entity.Property(e => e.FourthEtaDate).IsFixedLength();

                entity.Property(e => e.FourthEtaTime).IsFixedLength();

                entity.Property(e => e.FourthFlightDate).IsFixedLength();

                entity.Property(e => e.FourthFlightTime).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.LodgeDate).IsFixedLength();

                entity.Property(e => e.PickupDate).IsFixedLength();

                entity.Property(e => e.PickupFfDate).IsFixedLength();

                entity.Property(e => e.PreAlertDestDate).IsFixedLength();

                entity.Property(e => e.ReceiveFfDate).IsFixedLength();

                entity.Property(e => e.SecondEtaDate).IsFixedLength();

                entity.Property(e => e.SecondEtaTime).IsFixedLength();

                entity.Property(e => e.SecondFlightDate).IsFixedLength();

                entity.Property(e => e.SecondFlightTime).IsFixedLength();

                entity.Property(e => e.ThirdEtaDate).IsFixedLength();

                entity.Property(e => e.ThirdEtaTime).IsFixedLength();

                entity.Property(e => e.ThirdFlightDate).IsFixedLength();

                entity.Property(e => e.ThirdFlightTime).IsFixedLength();

                entity.Property(e => e.TrfDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwAeaw1SubHouseManifest>(entity =>
            {
                entity.ToView("vw_Aeaw1_Sub_House_Manifest");

                entity.Property(e => e.CargoReceiptDate).IsFixedLength();

                entity.Property(e => e.ConfirmArrivalDate).IsFixedLength();

                entity.Property(e => e.ConfirmDepartureDate).IsFixedLength();

                entity.Property(e => e.ExecuteDate).IsFixedLength();

                entity.Property(e => e.FirstEtaDate).IsFixedLength();

                entity.Property(e => e.FirstEtaTime).IsFixedLength();

                entity.Property(e => e.FirstFlightDate).IsFixedLength();

                entity.Property(e => e.FirstFlightTime).IsFixedLength();

                entity.Property(e => e.FourthEtaDate).IsFixedLength();

                entity.Property(e => e.FourthEtaTime).IsFixedLength();

                entity.Property(e => e.FourthFlightDate).IsFixedLength();

                entity.Property(e => e.FourthFlightTime).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.LodgeDate).IsFixedLength();

                entity.Property(e => e.PickupDate).IsFixedLength();

                entity.Property(e => e.PickupFfDate).IsFixedLength();

                entity.Property(e => e.PreAlertDestDate).IsFixedLength();

                entity.Property(e => e.ReceiveFfDate).IsFixedLength();

                entity.Property(e => e.SecondEtaDate).IsFixedLength();

                entity.Property(e => e.SecondEtaTime).IsFixedLength();

                entity.Property(e => e.SecondFlightDate).IsFixedLength();

                entity.Property(e => e.SecondFlightTime).IsFixedLength();

                entity.Property(e => e.ThirdEtaDate).IsFixedLength();

                entity.Property(e => e.ThirdEtaTime).IsFixedLength();

                entity.Property(e => e.ThirdFlightDate).IsFixedLength();

                entity.Property(e => e.ThirdFlightTime).IsFixedLength();

                entity.Property(e => e.TrfDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwAeaw2>(entity =>
            {
                entity.ToView("vw_Aeaw2");

                entity.Property(e => e.ReqDate).IsFixedLength();
            });

            modelBuilder.Entity<VwAeaw3>(entity =>
            {
                entity.ToView("vw_Aeaw3");
            });

            modelBuilder.Entity<VwAeaw4>(entity =>
            {
                entity.ToView("vw_Aeaw4");
            });

            modelBuilder.Entity<VwAeaw5>(entity =>
            {
                entity.ToView("vw_Aeaw5");
            });

            modelBuilder.Entity<VwAeaw6>(entity =>
            {
                entity.ToView("vw_Aeaw6");
            });

            modelBuilder.Entity<VwAeawJob>(entity =>
            {
                entity.ToView("vw_Aeaw_Job");
            });

            modelBuilder.Entity<VwAebk1>(entity =>
            {
                entity.ToView("vw_Aebk1");

                entity.Property(e => e.ApproveDate).IsFixedLength();

                entity.Property(e => e.BookingDate).IsFixedLength();

                entity.Property(e => e.ExecuteDate).IsFixedLength();

                entity.Property(e => e.FirstEtaDate).IsFixedLength();

                entity.Property(e => e.FirstEtaTime).IsFixedLength();

                entity.Property(e => e.FirstFlightDate).IsFixedLength();

                entity.Property(e => e.FirstFlightTime).IsFixedLength();

                entity.Property(e => e.FourthEtaDate).IsFixedLength();

                entity.Property(e => e.FourthEtaTime).IsFixedLength();

                entity.Property(e => e.FourthFlightDate).IsFixedLength();

                entity.Property(e => e.FourthFlightTime).IsFixedLength();

                entity.Property(e => e.SecondEtaDate).IsFixedLength();

                entity.Property(e => e.SecondEtaTime).IsFixedLength();

                entity.Property(e => e.SecondFlightDate).IsFixedLength();

                entity.Property(e => e.SecondFlightTime).IsFixedLength();

                entity.Property(e => e.ThirdEtaDate).IsFixedLength();

                entity.Property(e => e.ThirdEtaTime).IsFixedLength();

                entity.Property(e => e.ThirdFlightDate).IsFixedLength();

                entity.Property(e => e.ThirdFlightTime).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwAebk1DocNo>(entity =>
            {
                entity.ToView("vw_Aebk1_Doc_No");

                entity.Property(e => e.ApproveDate).IsFixedLength();

                entity.Property(e => e.BookingDate).IsFixedLength();

                entity.Property(e => e.ExecuteDate).IsFixedLength();

                entity.Property(e => e.FirstEtaDate).IsFixedLength();

                entity.Property(e => e.FirstEtaTime).IsFixedLength();

                entity.Property(e => e.FirstFlightDate).IsFixedLength();

                entity.Property(e => e.FirstFlightTime).IsFixedLength();

                entity.Property(e => e.FourthEtaDate).IsFixedLength();

                entity.Property(e => e.FourthEtaTime).IsFixedLength();

                entity.Property(e => e.FourthFlightDate).IsFixedLength();

                entity.Property(e => e.FourthFlightTime).IsFixedLength();

                entity.Property(e => e.SecondEtaDate).IsFixedLength();

                entity.Property(e => e.SecondEtaTime).IsFixedLength();

                entity.Property(e => e.SecondFlightDate).IsFixedLength();

                entity.Property(e => e.SecondFlightTime).IsFixedLength();

                entity.Property(e => e.ThirdEtaDate).IsFixedLength();

                entity.Property(e => e.ThirdEtaTime).IsFixedLength();

                entity.Property(e => e.ThirdFlightDate).IsFixedLength();

                entity.Property(e => e.ThirdFlightTime).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwAebk2>(entity =>
            {
                entity.ToView("vw_Aebk2");
            });

            modelBuilder.Entity<VwAebk3>(entity =>
            {
                entity.ToView("vw_Aebk3");
            });

            modelBuilder.Entity<VwAebkCargoSale>(entity =>
            {
                entity.ToView("vw_Aebk_Cargo_Sales");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwAeca1>(entity =>
            {
                entity.ToView("vw_Aeca1");

                entity.Property(e => e.FlightDate).IsFixedLength();

                entity.Property(e => e.NewExecuteDate).IsFixedLength();

                entity.Property(e => e.OriginExecuteDate).IsFixedLength();
            });

            modelBuilder.Entity<VwAect1>(entity =>
            {
                entity.ToView("vw_Aect1");

                entity.Property(e => e.TrfDate).IsFixedLength();
            });

            modelBuilder.Entity<VwAect2>(entity =>
            {
                entity.ToView("vw_Aect2");

                entity.Property(e => e.FlightDate).IsFixedLength();
            });

            modelBuilder.Entity<VwAeiv1>(entity =>
            {
                entity.ToView("vw_Aeiv1");

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.FlightDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwAeiv1Vat>(entity =>
            {
                entity.ToView("vw_Aeiv1_Vat");
            });

            modelBuilder.Entity<VwAeiv2>(entity =>
            {
                entity.ToView("vw_Aeiv2");
            });

            modelBuilder.Entity<VwAeiv2Vat>(entity =>
            {
                entity.ToView("vw_Aeiv2_Vat");
            });

            modelBuilder.Entity<VwAemp1>(entity =>
            {
                entity.ToView("vw_Aemp1");

                entity.Property(e => e.CargoReceiptDate).IsFixedLength();

                entity.Property(e => e.DeliveryDateTime).IsFixedLength();

                entity.Property(e => e.FirstFlightDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwAemp2>(entity =>
            {
                entity.ToView("vw_Aemp2");
            });

            modelBuilder.Entity<VwAepa1>(entity =>
            {
                entity.ToView("vw_Aepa1");

                entity.Property(e => e.CsrDate).IsFixedLength();

                entity.Property(e => e.LastPostDate).IsFixedLength();

                entity.Property(e => e.NextTrfDate).IsFixedLength();
            });

            modelBuilder.Entity<VwAepa2>(entity =>
            {
                entity.ToView("vw_Aepa2");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwAepv1>(entity =>
            {
                entity.ToView("vw_Aepv1");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwAepv2>(entity =>
            {
                entity.ToView("vw_Aepv2");
            });

            modelBuilder.Entity<VwAewb1>(entity =>
            {
                entity.ToView("vw_Aewb1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwAiaw1>(entity =>
            {
                entity.ToView("vw_Aiaw1");

                entity.Property(e => e.CargoReadyDate).IsFixedLength();

                entity.Property(e => e.CargoReceiptDate).IsFixedLength();

                entity.Property(e => e.DocReleaseDate).IsFixedLength();

                entity.Property(e => e.FirstEtaDate).IsFixedLength();

                entity.Property(e => e.FirstEtaTime).IsFixedLength();

                entity.Property(e => e.FirstEtdDate).IsFixedLength();

                entity.Property(e => e.FirstEtdTime).IsFixedLength();

                entity.Property(e => e.FirstFlightDate).IsFixedLength();

                entity.Property(e => e.FirstFlightTime).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.PermitDate).IsFixedLength();

                entity.Property(e => e.SecondEtaDate).IsFixedLength();

                entity.Property(e => e.SecondEtaTime).IsFixedLength();

                entity.Property(e => e.SecondEtdDate).IsFixedLength();

                entity.Property(e => e.SecondEtdTime).IsFixedLength();

                entity.Property(e => e.ThirdEtaDate).IsFixedLength();

                entity.Property(e => e.ThirdEtaTime).IsFixedLength();

                entity.Property(e => e.ThirdEtdDate).IsFixedLength();

                entity.Property(e => e.ThirdEtdTime).IsFixedLength();

                entity.Property(e => e.TrkReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwAiaw2>(entity =>
            {
                entity.ToView("vw_Aiaw2");
            });

            modelBuilder.Entity<VwAiawJob>(entity =>
            {
                entity.ToView("vw_Aiaw_Job");
            });

            modelBuilder.Entity<VwAido1>(entity =>
            {
                entity.ToView("vw_Aido1");

                entity.Property(e => e.FlightDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwAiiv1>(entity =>
            {
                entity.ToView("vw_Aiiv1");

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.FlightDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwAiiv1Vat>(entity =>
            {
                entity.ToView("vw_Aiiv1_Vat");
            });

            modelBuilder.Entity<VwAiiv2>(entity =>
            {
                entity.ToView("vw_Aiiv2");
            });

            modelBuilder.Entity<VwAiiv2Vat>(entity =>
            {
                entity.ToView("vw_Aiiv2_Vat");
            });

            modelBuilder.Entity<VwAipa1>(entity =>
            {
                entity.ToView("vw_Aipa1");

                entity.Property(e => e.LastPostDate).IsFixedLength();

                entity.Property(e => e.NextTrfDate).IsFixedLength();
            });

            modelBuilder.Entity<VwAipv1>(entity =>
            {
                entity.ToView("vw_Aipv1");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwAipv2>(entity =>
            {
                entity.ToView("vw_Aipv2");
            });

            modelBuilder.Entity<VwAmac1>(entity =>
            {
                entity.ToView("vw_Amac1");

                entity.Property(e => e.EffectiveDate).IsFixedLength();

                entity.Property(e => e.ExpiryDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwAmac2>(entity =>
            {
                entity.ToView("vw_Amac2");
            });

            modelBuilder.Entity<VwAmac3>(entity =>
            {
                entity.ToView("vw_Amac3");
            });

            modelBuilder.Entity<VwAmad1>(entity =>
            {
                entity.ToView("vw_Amad1");
            });

            modelBuilder.Entity<VwAmad2>(entity =>
            {
                entity.ToView("vw_Amad2");
            });

            modelBuilder.Entity<VwAmah1>(entity =>
            {
                entity.ToView("vw_Amah1");

                entity.Property(e => e.FlightDate).IsFixedLength();

                entity.Property(e => e.LastPrintDate).IsFixedLength();

                entity.Property(e => e.NegotiateDate).IsFixedLength();
            });

            modelBuilder.Entity<VwAmaq1>(entity =>
            {
                entity.ToView("vw_Amaq1");

                entity.Property(e => e.EffectiveDate).IsFixedLength();
            });

            modelBuilder.Entity<VwAmbr1>(entity =>
            {
                entity.ToView("vw_Ambr1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwAmdc1>(entity =>
            {
                entity.ToView("vw_Amdc1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwAmfe1>(entity =>
            {
                entity.ToView("vw_Amfe1");

                entity.Property(e => e.FirstFlightDate).IsFixedLength();

                entity.Property(e => e.LastQuoteDate).IsFixedLength();

                entity.Property(e => e.QuoteDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwAmfq1>(entity =>
            {
                entity.ToView("vw_Amfq1");

                entity.Property(e => e.EffectiveDate).IsFixedLength();

                entity.Property(e => e.ExpiryDate).IsFixedLength();

                entity.Property(e => e.LastQuoteDate).IsFixedLength();

                entity.Property(e => e.QuoteDate).IsFixedLength();

                entity.Property(e => e.RevisionDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();

                entity.Property(e => e.ValidateDate).IsFixedLength();
            });

            modelBuilder.Entity<VwAmfq2>(entity =>
            {
                entity.ToView("vw_Amfq2");
            });

            modelBuilder.Entity<VwAmfq3>(entity =>
            {
                entity.ToView("vw_Amfq3");
            });

            modelBuilder.Entity<VwAmfq4>(entity =>
            {
                entity.ToView("vw_Amfq4");
            });

            modelBuilder.Entity<VwAmfq5>(entity =>
            {
                entity.ToView("vw_Amfq5");
            });

            modelBuilder.Entity<VwAmfq6>(entity =>
            {
                entity.ToView("vw_Amfq6");
            });

            modelBuilder.Entity<VwAmic1>(entity =>
            {
                entity.ToView("vw_Amic1");

                entity.Property(e => e.EffectiveDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwAmid1>(entity =>
            {
                entity.ToView("vw_Amid1");
            });

            modelBuilder.Entity<VwAmid2>(entity =>
            {
                entity.ToView("vw_Amid2");
            });

            modelBuilder.Entity<VwAmie1>(entity =>
            {
                entity.ToView("vw_Amie1");

                entity.Property(e => e.FirstFlightDate).IsFixedLength();

                entity.Property(e => e.LastQuoteDate).IsFixedLength();

                entity.Property(e => e.QuoteDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwAmif1>(entity =>
            {
                entity.ToView("vw_Amif1");

                entity.Property(e => e.EffectiveDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwAmio1>(entity =>
            {
                entity.ToView("vw_Amio1");
            });

            modelBuilder.Entity<VwAmio2>(entity =>
            {
                entity.ToView("vw_Amio2");
            });

            modelBuilder.Entity<VwAmir1>(entity =>
            {
                entity.ToView("vw_Amir1");

                entity.Property(e => e.EffectiveDate).IsFixedLength();

                entity.Property(e => e.ExpiryDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwAmpa1>(entity =>
            {
                entity.ToView("vw_Ampa1");
            });

            modelBuilder.Entity<VwAmqo1>(entity =>
            {
                entity.ToView("vw_Amqo1");
            });

            modelBuilder.Entity<VwAmqo2>(entity =>
            {
                entity.ToView("vw_Amqo2");
            });

            modelBuilder.Entity<VwAnac1>(entity =>
            {
                entity.ToView("vw_Anac1");

                entity.Property(e => e.LastReceiptDate).IsFixedLength();

                entity.Property(e => e.LastUseDate).IsFixedLength();
            });

            modelBuilder.Entity<VwAnam1>(entity =>
            {
                entity.ToView("vw_Anam1");

                entity.Property(e => e.AgentIssueDate).IsFixedLength();

                entity.Property(e => e.AgentReturnDate).IsFixedLength();

                entity.Property(e => e.ExecuteDate).IsFixedLength();

                entity.Property(e => e.FirstFlightDate).IsFixedLength();

                entity.Property(e => e.OccReservedDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.ReleaseDate).IsFixedLength();

                entity.Property(e => e.ReturnDate).IsFixedLength();
            });

            modelBuilder.Entity<VwAnat1>(entity =>
            {
                entity.ToView("vw_Anat1");

                entity.Property(e => e.FormNo).ValueGeneratedOnAdd();

                entity.Property(e => e.TrxDate).IsFixedLength();
            });

            modelBuilder.Entity<VwAnat2>(entity =>
            {
                entity.ToView("vw_Anat2");
            });

            modelBuilder.Entity<VwAnbb1>(entity =>
            {
                entity.ToView("vw_Anbb1");

                entity.Property(e => e.AssignmentDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwAnbb2>(entity =>
            {
                entity.ToView("vw_Anbb2");

                entity.Property(e => e.FlightDate).IsFixedLength();
            });

            modelBuilder.Entity<VwAnbb3>(entity =>
            {
                entity.ToView("vw_anbb3");
            });

            modelBuilder.Entity<VwAncf1>(entity =>
            {
                entity.ToView("vw_Ancf1");

                entity.Property(e => e.LastYrReceiveDate).IsFixedLength();

                entity.Property(e => e.LastYrUseDate).IsFixedLength();
            });

            modelBuilder.Entity<VwAsjd1>(entity =>
            {
                entity.ToView("vw_Asjd1");
            });

            modelBuilder.Entity<VwAsjd2>(entity =>
            {
                entity.ToView("vw_Asjd2");

                entity.Property(e => e.InvoiceDate).IsFixedLength();
            });

            modelBuilder.Entity<VwAsjd3>(entity =>
            {
                entity.ToView("vw_Asjd3");

                entity.Property(e => e.InvoiceDate).IsFixedLength();
            });

            modelBuilder.Entity<VwAsst1>(entity =>
            {
                entity.ToView("vw_Asst1");
            });

            modelBuilder.Entity<VwBankTransaction>(entity =>
            {
                entity.ToView("vw_BankTransaction");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<VwBrba1>(entity =>
            {
                entity.ToView("vw_Brba1");
            });

            modelBuilder.Entity<VwBrtx1>(entity =>
            {
                entity.ToView("vw_Brtx1");

                entity.Property(e => e.BankStatementDate).IsFixedLength();

                entity.Property(e => e.Date).IsFixedLength();
            });

            modelBuilder.Entity<VwCntrIdlingPort>(entity =>
            {
                entity.ToView("vw_Cntr_Idling_Port");

                entity.Property(e => e.EventDate).IsFixedLength();
            });

            modelBuilder.Entity<VwCsbk1>(entity =>
            {
                entity.ToView("vw_Csbk1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwCsbk2>(entity =>
            {
                entity.ToView("vw_Csbk2");
            });

            modelBuilder.Entity<VwCtcl1>(entity =>
            {
                entity.ToView("vw_Ctcl1");

                entity.Property(e => e.DestEta).IsFixedLength();

                entity.Property(e => e.Eta).IsFixedLength();

                entity.Property(e => e.EventDate).IsFixedLength();

                entity.Property(e => e.ReleaseDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwCtdo1>(entity =>
            {
                entity.ToView("vw_Ctdo1");

                entity.Property(e => e.ExpiryDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwCtdo2>(entity =>
            {
                entity.ToView("vw_Ctdo2");
            });

            modelBuilder.Entity<VwCtfa1>(entity =>
            {
                entity.ToView("vw_Ctfa1");

                entity.Property(e => e.Eta).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwCtri1>(entity =>
            {
                entity.ToView("vw_Ctri1");

                entity.Property(e => e.DetentionStartDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwCtro1>(entity =>
            {
                entity.ToView("vw_Ctro1");

                entity.Property(e => e.CollectionDate).IsFixedLength();

                entity.Property(e => e.RoReleaseDate).IsFixedLength();
            });

            modelBuilder.Entity<VwCtro2>(entity =>
            {
                entity.ToView("vw_Ctro2");

                entity.Property(e => e.ReleaseDate).IsFixedLength();

                entity.Property(e => e.RoReleaseDate).IsFixedLength();
            });

            modelBuilder.Entity<VwCtrp1>(entity =>
            {
                entity.ToView("vw_Ctrp1");

                entity.Property(e => e.FromDate).IsFixedLength();

                entity.Property(e => e.ToDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwCtrp2>(entity =>
            {
                entity.ToView("vw_Ctrp2");

                entity.Property(e => e.Date1).IsFixedLength();

                entity.Property(e => e.Date2).IsFixedLength();

                entity.Property(e => e.Date3).IsFixedLength();

                entity.Property(e => e.Date4).IsFixedLength();

                entity.Property(e => e.Date5).IsFixedLength();

                entity.Property(e => e.LineItemNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwCtso1>(entity =>
            {
                entity.ToView("vw_Ctso1");

                entity.Property(e => e.CompleteDate).IsFixedLength();

                entity.Property(e => e.DemurrageStartDate).IsFixedLength();

                entity.Property(e => e.DetentionStartDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwCtso2>(entity =>
            {
                entity.ToView("vw_Ctso2");

                entity.Property(e => e.ReceiveDate).IsFixedLength();
            });

            modelBuilder.Entity<VwEdal1>(entity =>
            {
                entity.ToView("vw_Edal1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwEdci1>(entity =>
            {
                entity.ToView("vw_Edci1");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwEdct1>(entity =>
            {
                entity.ToView("Vw_Edct1");

                entity.Property(e => e.ReleaseDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwEdpk1>(entity =>
            {
                entity.ToView("vw_Edpk1");
            });

            modelBuilder.Entity<VwExportAirTrackpoint>(entity =>
            {
                entity.ToView("vw_ExportAirTrackpoints");
            });

            modelBuilder.Entity<VwExportAirTrackpoints20160902>(entity =>
            {
                entity.ToView("vw_ExportAirTrackpoints_20160902");
            });

            modelBuilder.Entity<VwExportSeaTrackpoint>(entity =>
            {
                entity.ToView("vw_ExportSeaTrackpoints");
            });

            modelBuilder.Entity<VwExportSeaTrackpoints20160902>(entity =>
            {
                entity.ToView("vw_ExportSeaTrackpoints_20160902");
            });

            modelBuilder.Entity<VwGlbc1>(entity =>
            {
                entity.ToView("vw_Glbc1");
            });

            modelBuilder.Entity<VwGlbc2>(entity =>
            {
                entity.ToView("vw_Glbc2");
            });

            modelBuilder.Entity<VwGlbc3>(entity =>
            {
                entity.ToView("vw_Glbc3");

                entity.Property(e => e.ReceivedDate).IsFixedLength();
            });

            modelBuilder.Entity<VwGlbh1>(entity =>
            {
                entity.ToView("vw_Glbh1");
            });

            modelBuilder.Entity<VwGlbh2>(entity =>
            {
                entity.ToView("vw_Glbh2");
            });

            modelBuilder.Entity<VwGlbl1>(entity =>
            {
                entity.ToView("vw_Glbl1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGlbl1B>(entity =>
            {
                entity.ToView("vw_Glbl1_BS");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGlbl1Bs1>(entity =>
            {
                entity.ToView("vw_Glbl1_BS_1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGlbl1DebitCredit>(entity =>
            {
                entity.ToView("vw_Glbl1_Debit_Credit");
            });

            modelBuilder.Entity<VwGlbl1Pl>(entity =>
            {
                entity.ToView("vw_Glbl1_PL");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGlbl1PlSummary>(entity =>
            {
                entity.ToView("vw_Glbl1_PL_Summary");
            });

            modelBuilder.Entity<VwGlbr1>(entity =>
            {
                entity.ToView("vw_Glbr1");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.ClearDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();
            });

            modelBuilder.Entity<VwGlbt1>(entity =>
            {
                entity.ToView("vw_Glbt1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGlcc1>(entity =>
            {
                entity.ToView("vw_Glcc1");
            });

            modelBuilder.Entity<VwGlcf1>(entity =>
            {
                entity.ToView("vw_Glcf1");
            });

            modelBuilder.Entity<VwGlch1>(entity =>
            {
                entity.ToView("vw_Glch1");
            });

            modelBuilder.Entity<VwGlch2>(entity =>
            {
                entity.ToView("vw_Glch2");
            });

            modelBuilder.Entity<VwGlct1>(entity =>
            {
                entity.ToView("vw_Glct1");
            });

            modelBuilder.Entity<VwGldc1>(entity =>
            {
                entity.ToView("vw_Gldc1");
            });

            modelBuilder.Entity<VwGleh1>(entity =>
            {
                entity.ToView("vw_Gleh1");

                entity.Property(e => e.EffectiveDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGlex1>(entity =>
            {
                entity.ToView("vw_Glex1");
            });

            modelBuilder.Entity<VwGlex2>(entity =>
            {
                entity.ToView("vw_Glex2");

                entity.Property(e => e.EffectiveDate).IsFixedLength();
            });

            modelBuilder.Entity<VwGlex21>(entity =>
            {
                entity.ToView("vw_Glex2_1");

                entity.Property(e => e.EffectiveDate).IsFixedLength();
            });

            modelBuilder.Entity<VwGlfa1>(entity =>
            {
                entity.ToView("vw_Glfa1");

                entity.Property(e => e.NextJournalDate).IsFixedLength();

                entity.Property(e => e.PurchaseDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGlfb1>(entity =>
            {
                entity.ToView("vw_Glfb1");
            });

            modelBuilder.Entity<VwGlfv1>(entity =>
            {
                entity.ToView("vw_Glfv1");

                entity.Property(e => e.Date).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<VwGljv1>(entity =>
            {
                entity.ToView("vw_Gljv1");

                entity.Property(e => e.ApproveDate).IsFixedLength();

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.ClearDate).IsFixedLength();

                entity.Property(e => e.JournalDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGljv2>(entity =>
            {
                entity.ToView("vw_Gljv2");
            });

            modelBuilder.Entity<VwGljvAcc>(entity =>
            {
                entity.ToView("vw_Gljv_Acc");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGljvJob>(entity =>
            {
                entity.ToView("vw_Gljv_Job");
            });

            modelBuilder.Entity<VwGlma1>(entity =>
            {
                entity.ToView("vw_Glma1");
            });

            modelBuilder.Entity<VwGlml1>(entity =>
            {
                entity.ToView("vw_Glml1");

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGloc1>(entity =>
            {
                entity.ToView("vw_Gloc1");
            });

            modelBuilder.Entity<VwGlpa1>(entity =>
            {
                entity.ToView("vw_Glpa1");

                entity.Property(e => e.LastYr01FromDate).IsFixedLength();

                entity.Property(e => e.LastYr01ToDate).IsFixedLength();

                entity.Property(e => e.LastYr02FromDate).IsFixedLength();

                entity.Property(e => e.LastYr02ToDate).IsFixedLength();

                entity.Property(e => e.LastYr03FromDate).IsFixedLength();

                entity.Property(e => e.LastYr03ToDate).IsFixedLength();

                entity.Property(e => e.LastYr04FromDate).IsFixedLength();

                entity.Property(e => e.LastYr04ToDate).IsFixedLength();

                entity.Property(e => e.LastYr05FromDate).IsFixedLength();

                entity.Property(e => e.LastYr05ToDate).IsFixedLength();

                entity.Property(e => e.LastYr06FromDate).IsFixedLength();

                entity.Property(e => e.LastYr06ToDate).IsFixedLength();

                entity.Property(e => e.LastYr07FromDate).IsFixedLength();

                entity.Property(e => e.LastYr07ToDate).IsFixedLength();

                entity.Property(e => e.LastYr08FromDate).IsFixedLength();

                entity.Property(e => e.LastYr08ToDate).IsFixedLength();

                entity.Property(e => e.LastYr09FromDate).IsFixedLength();

                entity.Property(e => e.LastYr09ToDate).IsFixedLength();

                entity.Property(e => e.LastYr10FromDate).IsFixedLength();

                entity.Property(e => e.LastYr10ToDate).IsFixedLength();

                entity.Property(e => e.LastYr11FromDate).IsFixedLength();

                entity.Property(e => e.LastYr11ToDate).IsFixedLength();

                entity.Property(e => e.LastYr12FromDate).IsFixedLength();

                entity.Property(e => e.LastYr12ToDate).IsFixedLength();

                entity.Property(e => e.LastYr13FromDate).IsFixedLength();

                entity.Property(e => e.LastYr13ToDate).IsFixedLength();

                entity.Property(e => e.LastYr14FromDate).IsFixedLength();

                entity.Property(e => e.LastYr14ToDate).IsFixedLength();

                entity.Property(e => e.LastYr15FromDate).IsFixedLength();

                entity.Property(e => e.LastYr15ToDate).IsFixedLength();

                entity.Property(e => e.LastYr16FromDate).IsFixedLength();

                entity.Property(e => e.LastYr16ToDate).IsFixedLength();

                entity.Property(e => e.LastYr17FromDate).IsFixedLength();

                entity.Property(e => e.LastYr17ToDate).IsFixedLength();

                entity.Property(e => e.LastYr18FromDate).IsFixedLength();

                entity.Property(e => e.LastYr18ToDate).IsFixedLength();

                entity.Property(e => e.ThisYr01FromDate).IsFixedLength();

                entity.Property(e => e.ThisYr01ToDate).IsFixedLength();

                entity.Property(e => e.ThisYr02FromDate).IsFixedLength();

                entity.Property(e => e.ThisYr02ToDate).IsFixedLength();

                entity.Property(e => e.ThisYr03FromDate).IsFixedLength();

                entity.Property(e => e.ThisYr03ToDate).IsFixedLength();

                entity.Property(e => e.ThisYr04FromDate).IsFixedLength();

                entity.Property(e => e.ThisYr04ToDate).IsFixedLength();

                entity.Property(e => e.ThisYr05FromDate).IsFixedLength();

                entity.Property(e => e.ThisYr05ToDate).IsFixedLength();

                entity.Property(e => e.ThisYr06FromDate).IsFixedLength();

                entity.Property(e => e.ThisYr06ToDate).IsFixedLength();

                entity.Property(e => e.ThisYr07FromDate).IsFixedLength();

                entity.Property(e => e.ThisYr07ToDate).IsFixedLength();

                entity.Property(e => e.ThisYr08FromDate).IsFixedLength();

                entity.Property(e => e.ThisYr08ToDate).IsFixedLength();

                entity.Property(e => e.ThisYr09FromDate).IsFixedLength();

                entity.Property(e => e.ThisYr09ToDate).IsFixedLength();

                entity.Property(e => e.ThisYr10FromDate).IsFixedLength();

                entity.Property(e => e.ThisYr10ToDate).IsFixedLength();

                entity.Property(e => e.ThisYr11FromDate).IsFixedLength();

                entity.Property(e => e.ThisYr11ToDate).IsFixedLength();

                entity.Property(e => e.ThisYr12FromDate).IsFixedLength();

                entity.Property(e => e.ThisYr12ToDate).IsFixedLength();

                entity.Property(e => e.ThisYr13FromDate).IsFixedLength();

                entity.Property(e => e.ThisYr13ToDate).IsFixedLength();

                entity.Property(e => e.ThisYr14FromDate).IsFixedLength();

                entity.Property(e => e.ThisYr14ToDate).IsFixedLength();

                entity.Property(e => e.ThisYr15FromDate).IsFixedLength();

                entity.Property(e => e.ThisYr15ToDate).IsFixedLength();

                entity.Property(e => e.ThisYr16FromDate).IsFixedLength();

                entity.Property(e => e.ThisYr16ToDate).IsFixedLength();

                entity.Property(e => e.ThisYr17FromDate).IsFixedLength();

                entity.Property(e => e.ThisYr17ToDate).IsFixedLength();

                entity.Property(e => e.ThisYr18FromDate).IsFixedLength();

                entity.Property(e => e.ThisYr18ToDate).IsFixedLength();

                entity.Property(e => e.WhtReportDate).IsFixedLength();
            });

            modelBuilder.Entity<VwGlpa2>(entity =>
            {
                entity.ToView("vw_Glpa2");

                entity.Property(e => e.Mth01FromDate).IsFixedLength();

                entity.Property(e => e.Mth01toDate).IsFixedLength();

                entity.Property(e => e.Mth02FromDate).IsFixedLength();

                entity.Property(e => e.Mth02ToDate).IsFixedLength();

                entity.Property(e => e.Mth03FromDate).IsFixedLength();

                entity.Property(e => e.Mth03ToDate).IsFixedLength();

                entity.Property(e => e.Mth04FromDate).IsFixedLength();

                entity.Property(e => e.Mth04ToDate).IsFixedLength();

                entity.Property(e => e.Mth05FromDate).IsFixedLength();

                entity.Property(e => e.Mth05ToDate).IsFixedLength();

                entity.Property(e => e.Mth06FromDate).IsFixedLength();

                entity.Property(e => e.Mth06ToDate).IsFixedLength();

                entity.Property(e => e.Mth07FromDate).IsFixedLength();

                entity.Property(e => e.Mth07ToDate).IsFixedLength();

                entity.Property(e => e.Mth08FromDate).IsFixedLength();

                entity.Property(e => e.Mth08ToDate).IsFixedLength();

                entity.Property(e => e.Mth09FromDate).IsFixedLength();

                entity.Property(e => e.Mth09ToDate).IsFixedLength();

                entity.Property(e => e.Mth10FromDate).IsFixedLength();

                entity.Property(e => e.Mth10ToDate).IsFixedLength();

                entity.Property(e => e.Mth11FromDate).IsFixedLength();

                entity.Property(e => e.Mth11ToDate).IsFixedLength();

                entity.Property(e => e.Mth12FromDate).IsFixedLength();

                entity.Property(e => e.Mth12ToDate).IsFixedLength();

                entity.Property(e => e.Mth13FromDate).IsFixedLength();

                entity.Property(e => e.Mth13ToDate).IsFixedLength();

                entity.Property(e => e.Mth14FromDate).IsFixedLength();

                entity.Property(e => e.Mth14ToDate).IsFixedLength();

                entity.Property(e => e.Mth15FromDate).IsFixedLength();

                entity.Property(e => e.Mth15ToDate).IsFixedLength();

                entity.Property(e => e.Mth16FromDate).IsFixedLength();

                entity.Property(e => e.Mth16ToDate).IsFixedLength();

                entity.Property(e => e.Mth17FromDate).IsFixedLength();

                entity.Property(e => e.Mth17ToDate).IsFixedLength();

                entity.Property(e => e.Mth18FromDate).IsFixedLength();

                entity.Property(e => e.Mth18ToDate).IsFixedLength();
            });

            modelBuilder.Entity<VwGlpp1>(entity =>
            {
                entity.ToView("vw_Glpp1");

                entity.Property(e => e.NextJournalDate).IsFixedLength();

                entity.Property(e => e.PaymentDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGlrv1>(entity =>
            {
                entity.ToView("vw_Glrv1");

                entity.Property(e => e.RevaluateDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGlvx1>(entity =>
            {
                entity.ToView("vw_Glvx1");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();
            });

            modelBuilder.Entity<VwGlwh1>(entity =>
            {
                entity.ToView("vw_Glwh1");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<VwGlyl1>(entity =>
            {
                entity.ToView("vw_Glyl1");

                entity.Property(e => e.BankSlipDate).IsFixedLength();

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.ClearDate).IsFixedLength();

                entity.Property(e => e.JournalDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGlyl1Jmjm1>(entity =>
            {
                entity.ToView("vw_Glyl1_Jmjm1");

                entity.Property(e => e.BankSlipDate).IsFixedLength();

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.ClearDate).IsFixedLength();

                entity.Property(e => e.Eta).IsFixedLength();

                entity.Property(e => e.Etd).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.JournalDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.SalesDate).IsFixedLength();

                entity.Property(e => e.ShipmentDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGlyl2>(entity =>
            {
                entity.ToView("vw_Glyl2");

                entity.Property(e => e.BankSlipDate).IsFixedLength();

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.ClearDate).IsFixedLength();

                entity.Property(e => e.JournalDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwIaOhInv>(entity =>
            {
                entity.ToView("vw_ia_oh_inv");
            });

            modelBuilder.Entity<VwImcc1>(entity =>
            {
                entity.ToView("vw_Imcc1");

                entity.Property(e => e.CycleCountDateTime).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwImcc2>(entity =>
            {
                entity.ToView("vw_Imcc2");
            });

            modelBuilder.Entity<VwImga1>(entity =>
            {
                entity.ToView("vw_Imga1");

                entity.Property(e => e.AdjustDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwImga2>(entity =>
            {
                entity.ToView("vw_Imga2");

                entity.Property(e => e.ExpiryDate).IsFixedLength();

                entity.Property(e => e.ManufactureDate).IsFixedLength();
            });

            modelBuilder.Entity<VwImgd1>(entity =>
            {
                entity.ToView("vw_Imgd1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwImgd2>(entity =>
            {
                entity.ToView("vw_Imgd2");

                entity.Property(e => e.ExpiryDate).IsFixedLength();

                entity.Property(e => e.ManufactureDate).IsFixedLength();
            });

            modelBuilder.Entity<VwImgi1>(entity =>
            {
                entity.ToView("vw_Imgi1");

                entity.Property(e => e.CompleteDate).IsFixedLength();

                entity.Property(e => e.IssueDate).IsFixedLength();

                entity.Property(e => e.LastBillDate).IsFixedLength();

                entity.Property(e => e.PickDateTime).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwImgi2>(entity =>
            {
                entity.ToView("vw_Imgi2");

                entity.Property(e => e.ExpiryDate).IsFixedLength();

                entity.Property(e => e.ManufactureDate).IsFixedLength();
            });

            modelBuilder.Entity<VwImgi3>(entity =>
            {
                entity.ToView("vw_Imgi3");
            });

            modelBuilder.Entity<VwImgi4>(entity =>
            {
                entity.ToView("vw_Imgi4");
            });

            modelBuilder.Entity<VwImgi5>(entity =>
            {
                entity.ToView("vw_Imgi5");
            });

            modelBuilder.Entity<VwImgi6>(entity =>
            {
                entity.ToView("vw_Imgi6");
            });

            modelBuilder.Entity<VwImgr1>(entity =>
            {
                entity.ToView("vw_Imgr1");

                entity.Property(e => e.ExecuteDate).IsFixedLength();

                entity.Property(e => e.LastBillDate).IsFixedLength();

                entity.Property(e => e.PutAwayDateTime).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwImgr2>(entity =>
            {
                entity.ToView("vw_Imgr2");

                entity.Property(e => e.ExpiryDate).IsFixedLength();

                entity.Property(e => e.ManufactureDate).IsFixedLength();
            });

            modelBuilder.Entity<VwImgr3>(entity =>
            {
                entity.ToView("vw_Imgr3");
            });

            modelBuilder.Entity<VwImia1>(entity =>
            {
                entity.ToView("vw_Imia1");

                entity.Property(e => e.AdjustDate).IsFixedLength();

                entity.Property(e => e.BatchNo).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PostFlag).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ProductCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RefNo).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Status).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreLocation).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreNo).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();

                entity.Property(e => e.TrxType).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.WarehouseCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.WorkStation).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwImip1>(entity =>
            {
                entity.ToView("vw_Imip1");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.InProductCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.InWarehouseCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.OutProductCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.OutWarehouseCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ReferenceNo).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Status).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TransferDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwImit1>(entity =>
            {
                entity.ToView("vw_Imit1");

                entity.Property(e => e.TransferDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwImit2>(entity =>
            {
                entity.ToView("vw_Imit2");

                entity.Property(e => e.ExpiryDate).IsFixedLength();

                entity.Property(e => e.ManufactureDate).IsFixedLength();
            });

            modelBuilder.Entity<VwImlt1>(entity =>
            {
                entity.ToView("vw_Imlt1");
            });

            modelBuilder.Entity<VwImlt2>(entity =>
            {
                entity.ToView("vw_Imlt2");

                entity.Property(e => e.ReceiveOrIssueDate).IsFixedLength();
            });

            modelBuilder.Entity<VwImms1>(entity =>
            {
                entity.ToView("vw_Imms1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwImpa1>(entity =>
            {
                entity.ToView("vw_Impa1");
            });

            modelBuilder.Entity<VwImpc1>(entity =>
            {
                entity.ToView("vw_Impc1");
            });

            modelBuilder.Entity<VwImpm1>(entity =>
            {
                entity.ToView("vw_Impm1");

                entity.Property(e => e.BillingStartDate).IsFixedLength();

                entity.Property(e => e.ExpiryDate).IsFixedLength();

                entity.Property(e => e.LastBillDate).IsFixedLength();

                entity.Property(e => e.ManufactureDate).IsFixedLength();

                entity.Property(e => e.MovementDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwImpm11>(entity =>
            {
                entity.ToView("vw_Impm1_1");

                entity.Property(e => e.BillingStartDate).IsFixedLength();

                entity.Property(e => e.ExpiryDate).IsFixedLength();

                entity.Property(e => e.LastBillDate).IsFixedLength();

                entity.Property(e => e.ManufactureDate).IsFixedLength();

                entity.Property(e => e.MovementDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwImpm1ActualStatus>(entity =>
            {
                entity.ToView("vw_Impm1_Actual_Status");
            });

            modelBuilder.Entity<VwImpm1Batch>(entity =>
            {
                entity.ToView("vw_Impm1_Batch");

                entity.Property(e => e.BillingStartDate).IsFixedLength();

                entity.Property(e => e.LastBillDate).IsFixedLength();

                entity.Property(e => e.MovementDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();
            });

            modelBuilder.Entity<VwImpm1Imgr1>(entity =>
            {
                entity.ToView("vw_Impm1_Imgr1");

                entity.Property(e => e.BillingStartDate).IsFixedLength();

                entity.Property(e => e.ExpiryDate).IsFixedLength();

                entity.Property(e => e.LastBillDate).IsFixedLength();

                entity.Property(e => e.ManufactureDate).IsFixedLength();

                entity.Property(e => e.MovementDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();
            });

            modelBuilder.Entity<VwImpm1Issue>(entity =>
            {
                entity.ToView("vw_Impm1_Issue");

                entity.Property(e => e.BillingStartDate).IsFixedLength();

                entity.Property(e => e.ExpiryDate).IsFixedLength();

                entity.Property(e => e.LastBillDate).IsFixedLength();

                entity.Property(e => e.ManufactureDate).IsFixedLength();

                entity.Property(e => e.MovementDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwImpm1Picked>(entity =>
            {
                entity.ToView("vw_Impm1_Picked");

                entity.Property(e => e.BillingStartDate).IsFixedLength();

                entity.Property(e => e.ExpiryDate).IsFixedLength();

                entity.Property(e => e.LastBillDate).IsFixedLength();

                entity.Property(e => e.ManufactureDate).IsFixedLength();

                entity.Property(e => e.MovementDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwImpm2>(entity =>
            {
                entity.ToView("vw_Impm2");

                entity.Property(e => e.BillingStartDate).IsFixedLength();

                entity.Property(e => e.ExpiryDate).IsFixedLength();

                entity.Property(e => e.LastBillDate).IsFixedLength();

                entity.Property(e => e.ManufactureDate).IsFixedLength();

                entity.Property(e => e.MovementDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwImpmStoreType>(entity =>
            {
                entity.ToView("vw_Impm_StoreType");

                entity.Property(e => e.BillingStartDate).IsFixedLength();

                entity.Property(e => e.ExpiryDate).IsFixedLength();

                entity.Property(e => e.LastBillDate).IsFixedLength();

                entity.Property(e => e.ManufactureDate).IsFixedLength();

                entity.Property(e => e.MovementDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwImpn1>(entity =>
            {
                entity.ToView("vw_Impn1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwImpo1>(entity =>
            {
                entity.ToView("vw_Impo1");

                entity.Property(e => e.DeliveryDate).IsFixedLength();

                entity.Property(e => e.OrderDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwImpo2>(entity =>
            {
                entity.ToView("vw_Impo2");
            });

            modelBuilder.Entity<VwImpo3>(entity =>
            {
                entity.ToView("vw_Impo3");
            });

            modelBuilder.Entity<VwImpo4>(entity =>
            {
                entity.ToView("vw_Impo4");
            });

            modelBuilder.Entity<VwImportAirTrackpoint>(entity =>
            {
                entity.ToView("vw_ImportAirTrackpoints");
            });

            modelBuilder.Entity<VwImportAirTrackpoints20160902>(entity =>
            {
                entity.ToView("vw_ImportAirTrackpoints_20160902");
            });

            modelBuilder.Entity<VwImportSeaTrackpoint>(entity =>
            {
                entity.ToView("vw_ImportSeaTrackpoints");
            });

            modelBuilder.Entity<VwImportSeaTrackpoints20160902>(entity =>
            {
                entity.ToView("vw_ImportSeaTrackpoints_20160902");
            });

            modelBuilder.Entity<VwImpr1>(entity =>
            {
                entity.ToView("vw_Impr1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwImpr2>(entity =>
            {
                entity.ToView("vw_Impr2");

                entity.Property(e => e.QuoteDate).IsFixedLength();
            });

            modelBuilder.Entity<VwImpr3>(entity =>
            {
                entity.ToView("vw_Impr3");
            });

            modelBuilder.Entity<VwImpv1>(entity =>
            {
                entity.ToView("vw_Impv1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwImpv2>(entity =>
            {
                entity.ToView("vw_Impv2");

                entity.Property(e => e.ReceiptOrIssueDate).IsFixedLength();
            });

            modelBuilder.Entity<VwImsd1>(entity =>
            {
                entity.ToView("vw_Imsd1");
            });

            modelBuilder.Entity<VwImsl1>(entity =>
            {
                entity.ToView("vw_Imsl1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwImsn1>(entity =>
            {
                entity.ToView("vw_Imsn1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwImso1>(entity =>
            {
                entity.ToView("vw_Imso1");

                entity.Property(e => e.DeliveryDate).IsFixedLength();

                entity.Property(e => e.ExpiryDate).IsFixedLength();

                entity.Property(e => e.OrderDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwImso2>(entity =>
            {
                entity.ToView("vw_Imso2");

                entity.Property(e => e.LocalAmt).IsFixedLength();
            });

            modelBuilder.Entity<VwImso3>(entity =>
            {
                entity.ToView("vw_Imso3");
            });

            modelBuilder.Entity<VwInms1>(entity =>
            {
                entity.ToView("vw_Inms1");

                entity.Property(e => e.EffectiveDate).IsFixedLength();

                entity.Property(e => e.EndDate).IsFixedLength();
            });

            modelBuilder.Entity<VwIvch1>(entity =>
            {
                entity.ToView("vw_Ivch1");

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwIvch1Vat>(entity =>
            {
                entity.ToView("vw_Ivch1_Vat");
            });

            modelBuilder.Entity<VwIvch2>(entity =>
            {
                entity.ToView("vw_Ivch2");
            });

            modelBuilder.Entity<VwIvch2Vat>(entity =>
            {
                entity.ToView("vw_Ivch2_Vat");
            });

            modelBuilder.Entity<VwIvchAcc>(entity =>
            {
                entity.ToView("vw_Ivch_Acc");
            });

            modelBuilder.Entity<VwIvci1>(entity =>
            {
                entity.ToView("vw_Ivci1");

                entity.Property(e => e.DeclarationDateTime).IsFixedLength();

                entity.Property(e => e.EntryDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.ReleaseDateTime).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwIvcr1>(entity =>
            {
                entity.ToView("vw_Ivcr1");

                entity.Property(e => e.AcknowledgementDate).IsFixedLength();

                entity.Property(e => e.ApproveDate).IsFixedLength();

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.ClearDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.GroupInvoiceDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PeriodFromDate).IsFixedLength();

                entity.Property(e => e.PeriodToDate).IsFixedLength();

                entity.Property(e => e.PlanCollectionDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwIvcr1ForeignAmt>(entity =>
            {
                entity.ToView("vw_Ivcr1_Foreign_Amt");
            });

            modelBuilder.Entity<VwIvcr1FreightCollect>(entity =>
            {
                entity.ToView("vw_Ivcr1_Freight_Collect");

                entity.Property(e => e.AcknowledgementDate).IsFixedLength();

                entity.Property(e => e.ApproveDate).IsFixedLength();

                entity.Property(e => e.ClearDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.GroupInvoiceDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PeriodFromDate).IsFixedLength();

                entity.Property(e => e.PeriodToDate).IsFixedLength();

                entity.Property(e => e.PlanCollectionDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwIvcr1Gst>(entity =>
            {
                entity.ToView("vw_Ivcr1_Gst");

                entity.Property(e => e.AcknowledgementDate).IsFixedLength();

                entity.Property(e => e.ApproveDate).IsFixedLength();

                entity.Property(e => e.ClearDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.GroupInvoiceDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PeriodFromDate).IsFixedLength();

                entity.Property(e => e.PeriodToDate).IsFixedLength();

                entity.Property(e => e.PlanCollectionDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwIvcr1LocalInvoice>(entity =>
            {
                entity.ToView("vw_Ivcr1_Local_Invoice");

                entity.Property(e => e.ApproveDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PeriodFromDate).IsFixedLength();

                entity.Property(e => e.PeriodToDate).IsFixedLength();

                entity.Property(e => e.PlanCollectionDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwIvcr1NoDel>(entity =>
            {
                entity.ToView("vw_Ivcr1_NoDel");

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<VwIvcr1NoVatOutLay>(entity =>
            {
                entity.ToView("vw_Ivcr1_No_Vat_Out_lay");

                entity.Property(e => e.AcknowledgementDate).IsFixedLength();

                entity.Property(e => e.ApproveDate).IsFixedLength();

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.ClearDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.GroupInvoiceDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PeriodFromDate).IsFixedLength();

                entity.Property(e => e.PeriodToDate).IsFixedLength();

                entity.Property(e => e.PlanCollectionDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwIvcr1Rebate>(entity =>
            {
                entity.ToView("vw_Ivcr1_Rebate");

                entity.Property(e => e.AcknowledgementDate).IsFixedLength();

                entity.Property(e => e.ApproveDate).IsFixedLength();

                entity.Property(e => e.ClearDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.GroupInvoiceDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PeriodFromDate).IsFixedLength();

                entity.Property(e => e.PeriodToDate).IsFixedLength();

                entity.Property(e => e.PlanCollectionDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwIvcr1Vat>(entity =>
            {
                entity.ToView("vw_Ivcr1_Vat");
            });

            modelBuilder.Entity<VwIvcr1VatOutLay>(entity =>
            {
                entity.ToView("vw_Ivcr1_Vat_Out_Lay");

                entity.Property(e => e.AcknowledgementDate).IsFixedLength();

                entity.Property(e => e.ApproveDate).IsFixedLength();

                entity.Property(e => e.ClearDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.GroupInvoiceDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PeriodFromDate).IsFixedLength();

                entity.Property(e => e.PeriodToDate).IsFixedLength();

                entity.Property(e => e.PlanCollectionDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwIvcr2>(entity =>
            {
                entity.ToView("vw_Ivcr2");

                entity.Property(e => e.CurrDate).IsFixedLength();

                entity.Property(e => e.ItemTrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwIvcr21>(entity =>
            {
                entity.ToView("vw_Ivcr2_1");

                entity.Property(e => e.ItemTrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwIvcr2Job>(entity =>
            {
                entity.ToView("vw_Ivcr2_Job");
            });

            modelBuilder.Entity<VwIvcr2Plvi2Cost>(entity =>
            {
                entity.ToView("vw_Ivcr2_Plvi2_Cost");
            });

            modelBuilder.Entity<VwIvcr2Vat>(entity =>
            {
                entity.ToView("vw_Ivcr2_Vat");
            });

            modelBuilder.Entity<VwIvcr3>(entity =>
            {
                entity.ToView("vw_ivcr3");
            });

            modelBuilder.Entity<VwIvcrAcc>(entity =>
            {
                entity.ToView("vw_Ivcr_Acc");
            });

            modelBuilder.Entity<VwIvcrFlag>(entity =>
            {
                entity.ToView("vw_ivcr_Flag");
            });

            modelBuilder.Entity<VwIvcsl>(entity =>
            {
                entity.ToView("vw_Ivcsl");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwIvpa1>(entity =>
            {
                entity.ToView("vw_Ivpa1");
            });

            modelBuilder.Entity<VwIvpa2>(entity =>
            {
                entity.ToView("vw_Ivpa2");

                entity.Property(e => e.LineItemNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwIvpa3>(entity =>
            {
                entity.ToView("vw_Ivpa3");

                entity.Property(e => e.LineItemNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwJmaj1>(entity =>
            {
                entity.ToView("vw_Jmaj1");

                entity.Property(e => e.AdjustmentDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwJmce1>(entity =>
            {
                entity.ToView("vw_Jmce1");

                entity.Property(e => e.ImportDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();
            });

            modelBuilder.Entity<VwJmce2>(entity =>
            {
                entity.ToView("vw_Jmce2");

                entity.Property(e => e.ManufactureDate).IsFixedLength();
            });

            modelBuilder.Entity<VwJmce3>(entity =>
            {
                entity.ToView("vw_Jmce3");

                entity.Property(e => e.DocDate).IsFixedLength();
            });

            modelBuilder.Entity<VwJmce4>(entity =>
            {
                entity.ToView("vw_Jmce4");
            });

            modelBuilder.Entity<VwJmcm1>(entity =>
            {
                entity.ToView("vw_Jmcm1");

                entity.Property(e => e.ContainerReturnDate).IsFixedLength();

                entity.Property(e => e.ContainerTransferDate).IsFixedLength();

                entity.Property(e => e.DoReleaseDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.FinalDestDate).IsFixedLength();
            });

            modelBuilder.Entity<VwJmcs1>(entity =>
            {
                entity.ToView("vw_Jmcs1");

                entity.Property(e => e.JournalDate).IsFixedLength();

                entity.Property(e => e.KeyId).ValueGeneratedOnAdd();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<VwJmct1>(entity =>
            {
                entity.ToView("vw_Jmct1");

                entity.Property(e => e.DepotInDate).IsFixedLength();

                entity.Property(e => e.DepotOutDate).IsFixedLength();

                entity.Property(e => e.Eta).IsFixedLength();

                entity.Property(e => e.Etd).IsFixedLength();

                entity.Property(e => e.GateInDate).IsFixedLength();

                entity.Property(e => e.GateOutDate).IsFixedLength();

                entity.Property(e => e.InboundLastDateBeforeDemurrage).IsFixedLength();

                entity.Property(e => e.LastDateBeforeDetention).IsFixedLength();

                entity.Property(e => e.OutboundLadenDate).IsFixedLength();

                entity.Property(e => e.OutboundLastDateBeforeDemurrage).IsFixedLength();

                entity.Property(e => e.OutboundLastDateBeforeDetention).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwJmdo1>(entity =>
            {
                entity.ToView("vw_Jmdo1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwJmdt1>(entity =>
            {
                entity.ToView("vw_Jmdt1");
            });

            modelBuilder.Entity<VwJmdt2>(entity =>
            {
                entity.ToView("vw_Jmdt2");

                entity.Property(e => e.InvoiceDate).IsFixedLength();
            });

            modelBuilder.Entity<VwJmdt3>(entity =>
            {
                entity.ToView("vw_Jmdt3");

                entity.Property(e => e.InvoiceDate).IsFixedLength();
            });

            modelBuilder.Entity<VwJmdt4>(entity =>
            {
                entity.ToView("vw_Jmdt4");

                entity.Property(e => e.InvoiceDate).IsFixedLength();
            });

            modelBuilder.Entity<VwJmeg1>(entity =>
            {
                entity.ToView("vw_jmeg1");
            });

            modelBuilder.Entity<VwJmeg2>(entity =>
            {
                entity.ToView("vw_jmeg2");
            });

            modelBuilder.Entity<VwJmfb1>(entity =>
            {
                entity.ToView("vw_Jmfb1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwJmje1>(entity =>
            {
                entity.ToView("vw_jmje1");

                entity.Property(e => e.EventDate).IsFixedLength();

                entity.Property(e => e.EventTime).IsFixedLength();
            });

            modelBuilder.Entity<VwJmje2>(entity =>
            {
                entity.ToView("vw_jmje2");
            });

            modelBuilder.Entity<VwJmjm1>(entity =>
            {
                entity.ToView("vw_Jmjm1");

                entity.Property(e => e.Eta).IsFixedLength();

                entity.Property(e => e.Etd).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.SalesDate).IsFixedLength();

                entity.Property(e => e.ShipmentDate).IsFixedLength();
            });

            modelBuilder.Entity<VwJmjm11>(entity =>
            {
                entity.ToView("vw_Jmjm1_1");

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();
            });

            modelBuilder.Entity<VwJmjm12>(entity =>
            {
                entity.ToView("vw_Jmjm1_2");

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();
            });

            modelBuilder.Entity<VwJmjm1ContainerTotal>(entity =>
            {
                entity.ToView("vw_jmjm1_Container_Total");
            });

            modelBuilder.Entity<VwJmjm1Customer>(entity =>
            {
                entity.ToView("vw_Jmjm1_Customer");

                entity.Property(e => e.Eta).IsFixedLength();

                entity.Property(e => e.Etd).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();
            });

            modelBuilder.Entity<VwJmjm1DocNo>(entity =>
            {
                entity.ToView("vw_Jmjm1_Doc_No");

                entity.Property(e => e.Eta).IsFixedLength();

                entity.Property(e => e.Etd).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.SalesDate).IsFixedLength();

                entity.Property(e => e.ShipmentDate).IsFixedLength();
            });

            modelBuilder.Entity<VwJmjm1InvoiceDate>(entity =>
            {
                entity.ToView("vw_Jmjm1_Invoice_Date");

                entity.Property(e => e.CostDate).IsFixedLength();

                entity.Property(e => e.Eta).IsFixedLength();

                entity.Property(e => e.Etd).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();
            });

            modelBuilder.Entity<VwJmjm1SalesDate>(entity =>
            {
                entity.ToView("vw_Jmjm1_Sales_Date");

                entity.Property(e => e.Eta).IsFixedLength();

                entity.Property(e => e.Etd).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<VwJmjm1UserDefine>(entity =>
            {
                entity.ToView("vw_Jmjm1_User_Define");
            });

            modelBuilder.Entity<VwJmjm2>(entity =>
            {
                entity.ToView("vw_Jmjm2");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwJmjm2CostAedoc>(entity =>
            {
                entity.ToView("vw_Jmjm2_Cost_AEDOC");
            });

            modelBuilder.Entity<VwJmjm2CostAidoc>(entity =>
            {
                entity.ToView("vw_Jmjm2_Cost_AIDOC");
            });

            modelBuilder.Entity<VwJmjm2CostInvoice>(entity =>
            {
                entity.ToView("vw_Jmjm2_Cost_Invoice");
            });

            modelBuilder.Entity<VwJmjm2NoInvoice>(entity =>
            {
                entity.ToView("vw_Jmjm2_No_Invoice");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwJmjm2NoInvoiceByJob>(entity =>
            {
                entity.ToView("vw_Jmjm2_No_Invoice_By_Job");
            });

            modelBuilder.Entity<VwJmjm2NoInvoiceByMasterJob>(entity =>
            {
                entity.ToView("vw_Jmjm2_No_Invoice_By_Master_Job");
            });

            modelBuilder.Entity<VwJmjm2NoPurchase>(entity =>
            {
                entity.ToView("vw_Jmjm2_No_Purchase");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwJmjm2NoPurchaseByJob>(entity =>
            {
                entity.ToView("vw_Jmjm2_No_Purchase_By_Job");
            });

            modelBuilder.Entity<VwJmjm2NoPurchaseByMasterJob>(entity =>
            {
                entity.ToView("vw_Jmjm2_No_Purchase_By_Master_Job");
            });

            modelBuilder.Entity<VwJmjm2WithInvoice>(entity =>
            {
                entity.ToView("vw_Jmjm2_With_Invoice");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwJmjm3>(entity =>
            {
                entity.ToView("vw_Jmjm3");
            });

            modelBuilder.Entity<VwJmjm4>(entity =>
            {
                entity.ToView("vw_jmjm4");

                entity.Property(e => e.LastAlertEmailDate).IsFixedLength();
            });

            modelBuilder.Entity<VwJmjm5>(entity =>
            {
                entity.ToView("vw_Jmjm5");
            });

            modelBuilder.Entity<VwJmjm6>(entity =>
            {
                entity.ToView("vw_Jmjm6");
            });

            modelBuilder.Entity<VwJmjm7>(entity =>
            {
                entity.ToView("vw_jmjm7");
            });

            modelBuilder.Entity<VwJmjs1>(entity =>
            {
                entity.ToView("vw_Jmjs1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwJmjs2>(entity =>
            {
                entity.ToView("vw_Jmjs2");
            });

            modelBuilder.Entity<VwJmjt1>(entity =>
            {
                entity.ToView("vw_Jmjt1");
            });

            modelBuilder.Entity<VwJmmp1>(entity =>
            {
                entity.ToView("vw_Jmmp1");

                entity.Property(e => e.DateAdded).IsFixedLength();
            });

            modelBuilder.Entity<VwJmpa1>(entity =>
            {
                entity.ToView("vw_Jmpa1");

                entity.Property(e => e.ImplementDate).IsFixedLength();

                entity.Property(e => e.LastPostDate).IsFixedLength();
            });

            modelBuilder.Entity<VwJmpa2>(entity =>
            {
                entity.ToView("vw_Jmpa2");

                entity.Property(e => e.LineItemNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwJmpa3>(entity =>
            {
                entity.ToView("vw_Jmpa3");
            });

            modelBuilder.Entity<VwJmpj1>(entity =>
            {
                entity.ToView("vw_Jmpj1");

                entity.Property(e => e.ProvisionDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwJmpt1>(entity =>
            {
                entity.ToView("vw_Jmpt1");

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwJmrk1>(entity =>
            {
                entity.ToView("vw_Jmrk1");
            });

            modelBuilder.Entity<VwJmsc1>(entity =>
            {
                entity.ToView("vw_Jmsc1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwJmsc2>(entity =>
            {
                entity.ToView("vw_Jmsc2");

                entity.Property(e => e.InvoiceDate).IsFixedLength();
            });

            modelBuilder.Entity<VwJmtn1>(entity =>
            {
                entity.ToView("vw_Jmtn1");

                entity.Property(e => e.ApproveDate).IsFixedLength();

                entity.Property(e => e.BlanketStartDate).IsFixedLength();

                entity.Property(e => e.CaAppDateTime).IsFixedLength();

                entity.Property(e => e.CertDate).IsFixedLength();

                entity.Property(e => e.EndDateOfExhibition).IsFixedLength();

                entity.Property(e => e.Eta).IsFixedLength();

                entity.Property(e => e.Etd).IsFixedLength();

                entity.Property(e => e.OrgAppDate).IsFixedLength();

                entity.Property(e => e.PermitAppDateTime).IsFixedLength();

                entity.Property(e => e.PermitEndDate).IsFixedLength();

                entity.Property(e => e.PermitStartDate).IsFixedLength();

                entity.Property(e => e.RemovalDate).IsFixedLength();

                entity.Property(e => e.StartDateOfExhibition).IsFixedLength();

                entity.Property(e => e.SubmissionDatetime).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwJmtn2>(entity =>
            {
                entity.ToView("vw_Jmtn2");
            });

            modelBuilder.Entity<VwJmtn3>(entity =>
            {
                entity.ToView("vw_Jmtn3");

                entity.Property(e => e.CostStatementDate).IsFixedLength();

                entity.Property(e => e.InvDate).IsFixedLength();

                entity.Property(e => e.RegDate).IsFixedLength();
            });

            modelBuilder.Entity<VwJmtn4>(entity =>
            {
                entity.ToView("vw_Jmtn4");
            });

            modelBuilder.Entity<VwJmtn5>(entity =>
            {
                entity.ToView("vw_Jmtn5");

                entity.Property(e => e.InvoiceDate).IsFixedLength();
            });

            modelBuilder.Entity<VwJmtn6>(entity =>
            {
                entity.ToView("vw_Jmtn6");
            });

            modelBuilder.Entity<VwJmtn8>(entity =>
            {
                entity.ToView("vw_Jmtn8");
            });

            modelBuilder.Entity<VwJmwo1>(entity =>
            {
                entity.ToView("vw_Jmwo1");
            });

            modelBuilder.Entity<VwMovementEnquiry>(entity =>
            {
                entity.ToView("vw_MovementEnquiry");

                entity.Property(e => e.TrxDate).IsFixedLength();
            });

            modelBuilder.Entity<VwOmdy1>(entity =>
            {
                entity.ToView("vw_Omdy1");
            });

            modelBuilder.Entity<VwOmdy2>(entity =>
            {
                entity.ToView("vw_Omdy2");

                entity.Property(e => e.ClearDate).IsFixedLength();

                entity.Property(e => e.SurveyDate).IsFixedLength();
            });

            modelBuilder.Entity<VwOmlc1>(entity =>
            {
                entity.ToView("vw_Omlc1");

                entity.Property(e => e.ExpiryDate).IsFixedLength();
            });

            modelBuilder.Entity<VwOmoh1>(entity =>
            {
                entity.ToView("vw_Omoh1");
            });

            modelBuilder.Entity<VwOmor1>(entity =>
            {
                entity.ToView("vw_Omor1");

                entity.Property(e => e.DateAdded).IsFixedLength();

                entity.Property(e => e.DateChanged).IsFixedLength();

                entity.Property(e => e.DateContrEff).IsFixedLength();

                entity.Property(e => e.DateContrSign).IsFixedLength();

                entity.Property(e => e.DateLastRecv).IsFixedLength();
            });

            modelBuilder.Entity<VwOmor2>(entity =>
            {
                entity.ToView("vw_Omor2");
            });

            modelBuilder.Entity<VwOmpa1>(entity =>
            {
                entity.ToView("vw_Ompa1");
            });

            modelBuilder.Entity<VwOmsr1>(entity =>
            {
                entity.ToView("vw_Omsr1");
            });

            modelBuilder.Entity<VwOmtx1>(entity =>
            {
                entity.ToView("vw_Omtx1");

                entity.Property(e => e.CargoReadyDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.ExportFlightDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.OrderDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwOmtx11>(entity =>
            {
                entity.ToView("vw_Omtx1_1");

                entity.Property(e => e.CargoReadyDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.ExportFlightDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.OrderDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwOmtx2>(entity =>
            {
                entity.ToView("vw_Omtx2");

                entity.Property(e => e.Date).IsFixedLength();
            });

            modelBuilder.Entity<VwOmtx3>(entity =>
            {
                entity.ToView("vw_Omtx3");
            });

            modelBuilder.Entity<VwOmtx4>(entity =>
            {
                entity.ToView("vw_Omtx4");

                entity.Property(e => e.SortNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwOmtx5>(entity =>
            {
                entity.ToView("vw_Omtx5");
            });

            modelBuilder.Entity<VwOmtx6>(entity =>
            {
                entity.ToView("vw_Omtx6");
            });

            modelBuilder.Entity<VwOmtx7>(entity =>
            {
                entity.ToView("vw_Omtx7");

                entity.Property(e => e.Date).IsFixedLength();
            });

            modelBuilder.Entity<VwPlaj1>(entity =>
            {
                entity.ToView("vw_Plaj1");

                entity.Property(e => e.AdjustDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwPlcp1>(entity =>
            {
                entity.ToView("vw_Plcp1");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwPlcp2>(entity =>
            {
                entity.ToView("vw_Plcp2");
            });

            modelBuilder.Entity<VwPlcpAcc>(entity =>
            {
                entity.ToView("vw_Plcp_Acc");
            });

            modelBuilder.Entity<VwPlcs1>(entity =>
            {
                entity.ToView("vw_Plcs1");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.JournalDate).IsFixedLength();

                entity.Property(e => e.KeyId).ValueGeneratedOnAdd();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();
            });

            modelBuilder.Entity<VwPlcs2>(entity =>
            {
                entity.ToView("vw_Plcs2");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.JournalDate).IsFixedLength();

                entity.Property(e => e.KeyId).ValueGeneratedOnAdd();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();
            });

            modelBuilder.Entity<VwPlcsl>(entity =>
            {
                entity.ToView("vw_plcsl");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwPlhp1>(entity =>
            {
                entity.ToView("vw_Plhp1");

                entity.Property(e => e.HirePurchaseDate).IsFixedLength();

                entity.Property(e => e.NextDueDate).IsFixedLength();

                entity.Property(e => e.PurchaseDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwPlpa1>(entity =>
            {
                entity.ToView("vw_Plpa1");
            });

            modelBuilder.Entity<VwPlpm1>(entity =>
            {
                entity.ToView("vw_Plpm1");

                entity.Property(e => e.ApproveDate).IsFixedLength();

                entity.Property(e => e.CheckDate).IsFixedLength();

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.ClearDate).IsFixedLength();

                entity.Property(e => e.PaymentDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwPlpm2>(entity =>
            {
                entity.ToView("vw_Plpm2");
            });

            modelBuilder.Entity<VwPlpm3>(entity =>
            {
                entity.ToView("vw_Plpm3");

                entity.Property(e => e.ChequeDate).IsFixedLength();
            });

            modelBuilder.Entity<VwPlpmAcc>(entity =>
            {
                entity.ToView("vw_Plpm_Acc");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<VwPlti1>(entity =>
            {
                entity.ToView("vw_Plti1");

                entity.Property(e => e.TaxInvoiceDate).IsFixedLength();

                entity.Property(e => e.TaxInvoiceReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwPltx1>(entity =>
            {
                entity.ToView("vw_Pltx1");

                entity.Property(e => e.AgeingDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwPlvi1>(entity =>
            {
                entity.ToView("vw_Plvi1");

                entity.Property(e => e.ActivityDate).IsFixedLength();

                entity.Property(e => e.ApproveDate).IsFixedLength();

                entity.Property(e => e.CheckDate).IsFixedLength();

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.ClearDate).IsFixedLength();

                entity.Property(e => e.CurrDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.PaymentDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();

                entity.Property(e => e.VatDate).IsFixedLength();
            });

            modelBuilder.Entity<VwPlvi1Gst>(entity =>
            {
                entity.ToView("vw_Plvi1_Gst");

                entity.Property(e => e.ActivityDate).IsFixedLength();

                entity.Property(e => e.ApproveDate).IsFixedLength();

                entity.Property(e => e.CheckDate).IsFixedLength();

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.CurrDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();

                entity.Property(e => e.VatDate).IsFixedLength();
            });

            modelBuilder.Entity<VwPlvi2>(entity =>
            {
                entity.ToView("vw_Plvi2");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.ItemTrxNo).ValueGeneratedOnAdd();

                entity.Property(e => e.TaxInvoiceDate).IsFixedLength();

                entity.Property(e => e.TaxInvoiceReceiptDate).IsFixedLength();
            });

            modelBuilder.Entity<VwPlvi2Job>(entity =>
            {
                entity.ToView("vw_Plvi2_Job");
            });

            modelBuilder.Entity<VwPlvi3>(entity =>
            {
                entity.ToView("vw_Plvi3");
            });

            modelBuilder.Entity<VwPlvi4>(entity =>
            {
                entity.ToView("vw_Plvi4");
            });

            modelBuilder.Entity<VwPlvi5>(entity =>
            {
                entity.ToView("vw_Plvi5");

                entity.Property(e => e.ChequeDate).IsFixedLength();
            });

            modelBuilder.Entity<VwPlvi6>(entity =>
            {
                entity.ToView("vw_Plvi6");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.ItemTrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwPlviAcc>(entity =>
            {
                entity.ToView("vw_Plvi_Acc");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<VwPlvn1>(entity =>
            {
                entity.ToView("vw_Plvn1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwPlvn2>(entity =>
            {
                entity.ToView("vw_Plvn2");
            });

            modelBuilder.Entity<VwPlvn3>(entity =>
            {
                entity.ToView("vw_Plvn3");
            });

            modelBuilder.Entity<VwPlvn4>(entity =>
            {
                entity.ToView("vw_Plvn4");

                entity.Property(e => e.AgeingDate).IsFixedLength();
            });

            modelBuilder.Entity<VwPlvt1>(entity =>
            {
                entity.ToView("vw_Plvt1");
            });

            modelBuilder.Entity<VwPlvx1>(entity =>
            {
                entity.ToView("vw_Plvx1");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PaidDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.VatReceiptDate).IsFixedLength();
            });

            modelBuilder.Entity<VwPlvx11>(entity =>
            {
                entity.ToView("vw_Plvx1_1");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<VwPlvx1Aug>(entity =>
            {
                entity.ToView("vw_Plvx1_AUG");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<VwPlvx1Na>(entity =>
            {
                entity.ToView("vw_Plvx1_NA");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<VwPlvx1Sin>(entity =>
            {
                entity.ToView("vw_Plvx1_SIN");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<VwPopo1>(entity =>
            {
                entity.ToView("vw_Popo1");

                entity.Property(e => e.Eta).IsFixedLength();

                entity.Property(e => e.Etd).IsFixedLength();

                entity.Property(e => e.PoIssueDate).IsFixedLength();

                entity.Property(e => e.RequiredDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwPopo2>(entity =>
            {
                entity.ToView("vw_Popo2");

                entity.Property(e => e.DateRequested).IsFixedLength();

                entity.Property(e => e.DateRequestedAtSite).IsFixedLength();

                entity.Property(e => e.LatestDeliveryDate).IsFixedLength();
            });

            modelBuilder.Entity<VwPopo3>(entity =>
            {
                entity.ToView("vw_Popo3");

                entity.Property(e => e.CreateDate).IsFixedLength();

                entity.Property(e => e.EventDate).IsFixedLength();
            });

            modelBuilder.Entity<VwRcab1>(entity =>
            {
                entity.ToView("vw_Rcab1");
            });

            modelBuilder.Entity<VwRcal1>(entity =>
            {
                entity.ToView("vw_Rcal1");
            });

            modelBuilder.Entity<VwRcam1>(entity =>
            {
                entity.ToView("vw_Rcam1");
            });

            modelBuilder.Entity<VwRcap1>(entity =>
            {
                entity.ToView("vw_Rcap1");
            });

            modelBuilder.Entity<VwRcbo1>(entity =>
            {
                entity.ToView("vw_Rcbo1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwRcbp1>(entity =>
            {
                entity.ToView("vw_Rcbp1");

                entity.Property(e => e.ExpiryDate).IsFixedLength();

                entity.Property(e => e.SatLunchFromTime).IsFixedLength();

                entity.Property(e => e.SatLunchToTime).IsFixedLength();

                entity.Property(e => e.SatWorkFromTime).IsFixedLength();

                entity.Property(e => e.SatWorkToTime).IsFixedLength();

                entity.Property(e => e.SunLunchFromTime).IsFixedLength();

                entity.Property(e => e.SunLunchToTime).IsFixedLength();

                entity.Property(e => e.SunWorkFromTime).IsFixedLength();

                entity.Property(e => e.SunWorkToTime).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();

                entity.Property(e => e.WeekLunchFromTime).IsFixedLength();

                entity.Property(e => e.WeekLunchToTime).IsFixedLength();

                entity.Property(e => e.WeekWorkFromTime).IsFixedLength();

                entity.Property(e => e.WeekWorkToTime).IsFixedLength();
            });

            modelBuilder.Entity<VwRcbp10>(entity =>
            {
                entity.ToView("vw_Rcbp10");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwRcbp11>(entity =>
            {
                entity.ToView("vw_Rcbp11");
            });

            modelBuilder.Entity<VwRcbp12>(entity =>
            {
                entity.ToView("vw_Rcbp12");
            });

            modelBuilder.Entity<VwRcbp2>(entity =>
            {
                entity.ToView("vw_Rcbp2");
            });

            modelBuilder.Entity<VwRcbp3>(entity =>
            {
                entity.ToView("vw_Rcbp3");
            });

            modelBuilder.Entity<VwRcbp4>(entity =>
            {
                entity.ToView("vw_Rcbp4");
            });

            modelBuilder.Entity<VwRcbp5>(entity =>
            {
                entity.ToView("vw_Rcbp5");
            });

            modelBuilder.Entity<VwRcbp6>(entity =>
            {
                entity.ToView("vw_Rcbp6");
            });

            modelBuilder.Entity<VwRcbp7>(entity =>
            {
                entity.ToView("vw_Rcbp7");
            });

            modelBuilder.Entity<VwRcbp8>(entity =>
            {
                entity.ToView("vw_Rcbp8");
            });

            modelBuilder.Entity<VwRcbp9>(entity =>
            {
                entity.ToView("vw_Rcbp9");
            });

            modelBuilder.Entity<VwRcbt1>(entity =>
            {
                entity.ToView("vw_Rcbt1");
            });

            modelBuilder.Entity<VwRcbx1>(entity =>
            {
                entity.ToView("vw_Rcbx1");
            });

            modelBuilder.Entity<VwRcbx2>(entity =>
            {
                entity.ToView("vw_Rcbx2");
            });

            modelBuilder.Entity<VwRccc1>(entity =>
            {
                entity.ToView("vw_Rccc1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwRccd1>(entity =>
            {
                entity.ToView("vw_Rccd1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwRccf1>(entity =>
            {
                entity.ToView("vw_Rccf1");

                entity.Property(e => e.LastInspectionDate).IsFixedLength();

                entity.Property(e => e.NextInspectionDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwRccf2>(entity =>
            {
                entity.ToView("vw_Rccf2");

                entity.Property(e => e.ServiceDate).IsFixedLength();

                entity.Property(e => e.ServiceEndDate).IsFixedLength();
            });

            modelBuilder.Entity<VwRccm1>(entity =>
            {
                entity.ToView("vw_Rccm1");
            });

            modelBuilder.Entity<VwRcco1>(entity =>
            {
                entity.ToView("vw_Rcco1");
            });

            modelBuilder.Entity<VwRcct1>(entity =>
            {
                entity.ToView("vw_Rcct1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwRccy1>(entity =>
            {
                entity.ToView("vw_Rccy1");
            });

            modelBuilder.Entity<VwRccy1HandlingInstruction>(entity =>
            {
                entity.ToView("vw_Rccy1_Handling_Instruction");
            });

            modelBuilder.Entity<VwRccy2>(entity =>
            {
                entity.ToView("vw_Rccy2");
            });

            modelBuilder.Entity<VwRccy3>(entity =>
            {
                entity.ToView("vw_Rccy3");
            });

            modelBuilder.Entity<VwRcdc1>(entity =>
            {
                entity.ToView("vw_Rcdc1");
            });

            modelBuilder.Entity<VwRcdg1>(entity =>
            {
                entity.ToView("vw_Rcdg1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwRcdl1>(entity =>
            {
                entity.ToView("vw_Rcdl1");
            });

            modelBuilder.Entity<VwRcdp1>(entity =>
            {
                entity.ToView("vw_Rcdp1");
            });

            modelBuilder.Entity<VwRchc1>(entity =>
            {
                entity.ToView("vw_Rchc1");
            });

            modelBuilder.Entity<VwRchd1>(entity =>
            {
                entity.ToView("vw_Rchd1");

                entity.Property(e => e.Date).IsFixedLength();

                entity.Property(e => e.GatewayCode).IsFixedLength();

                entity.Property(e => e.HolidayEndDate).IsFixedLength();

                entity.Property(e => e.HolidayStartDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwRcit1>(entity =>
            {
                entity.ToView("vw_Rcit1");
            });

            modelBuilder.Entity<VwRcla1>(entity =>
            {
                entity.ToView("vw_Rcla1");
            });

            modelBuilder.Entity<VwRcnt1>(entity =>
            {
                entity.ToView("vw_Rcnt1");
            });

            modelBuilder.Entity<VwRcpb1>(entity =>
            {
                entity.ToView("vw_Rcpb1");
            });

            modelBuilder.Entity<VwRcpc1>(entity =>
            {
                entity.ToView("vw_Rcpc1");
            });

            modelBuilder.Entity<VwRcpm1>(entity =>
            {
                entity.ToView("vw_Rcpm1");
            });

            modelBuilder.Entity<VwRcpt1>(entity =>
            {
                entity.ToView("vw_Rcpt1");
            });

            modelBuilder.Entity<VwRcsl1>(entity =>
            {
                entity.ToView("vw_Rcsl1");
            });

            modelBuilder.Entity<VwRcsm1>(entity =>
            {
                entity.ToView("vw_Rcsm1");

                entity.Property(e => e.JoinDate).IsFixedLength();

                entity.Property(e => e.ResignDate).IsFixedLength();
            });

            modelBuilder.Entity<VwRcsm2>(entity =>
            {
                entity.ToView("vw_Rcsm2");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwRcsp1>(entity =>
            {
                entity.ToView("vw_Rcsp1");
            });

            modelBuilder.Entity<VwRcsp2>(entity =>
            {
                entity.ToView("vw_Rcsp2");
            });

            modelBuilder.Entity<VwRctc1>(entity =>
            {
                entity.ToView("vw_Rctc1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwRctl1>(entity =>
            {
                entity.ToView("vw_Rctl1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwRcum1>(entity =>
            {
                entity.ToView("vw_Rcum1");
            });

            modelBuilder.Entity<VwRcun1>(entity =>
            {
                entity.ToView("vw_Rcun1");
            });

            modelBuilder.Entity<VwRcvs1>(entity =>
            {
                entity.ToView("vw_Rcvs1");
            });

            modelBuilder.Entity<VwRcvy1>(entity =>
            {
                entity.ToView("vw_Rcvy1");

                entity.Property(e => e.Ata).IsFixedLength();

                entity.Property(e => e.AtaDate).IsFixedLength();

                entity.Property(e => e.Eta).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.Etd).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.FirstViaPortEtaDate).IsFixedLength();

                entity.Property(e => e.FirstViaPortEtdDate).IsFixedLength();

                entity.Property(e => e.SecondViaPortEtaDate).IsFixedLength();

                entity.Property(e => e.SecondViaPortEtdDate).IsFixedLength();

                entity.Property(e => e.ThirdViaPortEtaDate).IsFixedLength();

                entity.Property(e => e.ThirdViaPortEtdDate).IsFixedLength();
            });

            modelBuilder.Entity<VwRcvy2>(entity =>
            {
                entity.ToView("vw_Rcvy2");

                entity.Property(e => e.Eta).IsFixedLength();
            });

            modelBuilder.Entity<VwSaaa1>(entity =>
            {
                entity.ToView("vw_Saaa1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSaal1>(entity =>
            {
                entity.ToView("vw_Saal1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSaat1>(entity =>
            {
                entity.ToView("vw_Saat1");
            });

            modelBuilder.Entity<VwSabr1>(entity =>
            {
                entity.ToView("vw_Sabr1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSacb1>(entity =>
            {
                entity.ToView("vw_Sacb1");

                entity.Property(e => e.IntendedCustomsReleaseDate).IsFixedLength();

                entity.Property(e => e.LicenseApprovedDate01).IsFixedLength();

                entity.Property(e => e.LicenseApprovedDate02).IsFixedLength();

                entity.Property(e => e.LicenseApprovedDate03).IsFixedLength();

                entity.Property(e => e.LicenseApprovedDate04).IsFixedLength();

                entity.Property(e => e.LicenseApprovedDate05).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSacd1>(entity =>
            {
                entity.ToView("vw_Sacd1");
            });

            modelBuilder.Entity<VwSaco1>(entity =>
            {
                entity.ToView("vw_Saco1");

                entity.Property(e => e.EffectiveDate).IsFixedLength();

                entity.Property(e => e.ExpiryDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSaco2>(entity =>
            {
                entity.ToView("vw_Saco2");
            });

            modelBuilder.Entity<VwSaco3>(entity =>
            {
                entity.ToView("vw_Saco3");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSaco4>(entity =>
            {
                entity.ToView("vw_Saco4");
            });

            modelBuilder.Entity<VwSaco5>(entity =>
            {
                entity.ToView("vw_Saco5");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSaco6>(entity =>
            {
                entity.ToView("vw_Saco6");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSadl1>(entity =>
            {
                entity.ToView("vw_Sadl1");
            });

            modelBuilder.Entity<VwSadl2>(entity =>
            {
                entity.ToView("vw_Sadl2");
            });

            modelBuilder.Entity<VwSaed1>(entity =>
            {
                entity.ToView("vw_Saed1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSaed2>(entity =>
            {
                entity.ToView("vw_Saed2");
            });

            modelBuilder.Entity<VwSael1>(entity =>
            {
                entity.ToView("vw_Sael1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSaem1>(entity =>
            {
                entity.ToView("vw_Saem1");

                entity.Property(e => e.JoinDate).IsFixedLength();

                entity.Property(e => e.WorkFromTime).IsFixedLength();

                entity.Property(e => e.WorkToTime).IsFixedLength();
            });

            modelBuilder.Entity<VwSaem2>(entity =>
            {
                entity.ToView("vw_Saem2");
            });

            modelBuilder.Entity<VwSafd1>(entity =>
            {
                entity.ToView("vw_Safd1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSafm1>(entity =>
            {
                entity.ToView("vw_Safm1");
            });

            modelBuilder.Entity<VwSafm2>(entity =>
            {
                entity.ToView("vw_Safm2");
            });

            modelBuilder.Entity<VwSafr1>(entity =>
            {
                entity.ToView("vw_Safr1");
            });

            modelBuilder.Entity<VwSafr2>(entity =>
            {
                entity.ToView("vw_Safr2");
            });

            modelBuilder.Entity<VwSahd1>(entity =>
            {
                entity.ToView("vw_Sahd1");

                entity.Property(e => e.HolidayDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSajm1>(entity =>
            {
                entity.ToView("vw_Sajm1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSamt1>(entity =>
            {
                entity.ToView("vw_Samt1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSanm1>(entity =>
            {
                entity.ToView("vw_Sanm1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSanm2>(entity =>
            {
                entity.ToView("vw_Sanm2");
            });

            modelBuilder.Entity<VwSant1>(entity =>
            {
                entity.ToView("vw_Sant1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSaoh1>(entity =>
            {
                entity.ToView("vw_Saoh1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSapa1>(entity =>
            {
                entity.ToView("vw_Sapa1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSapb1>(entity =>
            {
                entity.ToView("vw_Sapb1");

                entity.Property(e => e.Birthday).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSapl1>(entity =>
            {
                entity.ToView("vw_Sapl1");
            });

            modelBuilder.Entity<VwSapp1>(entity =>
            {
                entity.ToView("vw_Sapp1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSapp2>(entity =>
            {
                entity.ToView("vw_Sapp2");
            });

            modelBuilder.Entity<VwSapp3>(entity =>
            {
                entity.ToView("vw_Sapp3");
            });

            modelBuilder.Entity<VwSapp4>(entity =>
            {
                entity.ToView("vw_Sapp4");
            });

            modelBuilder.Entity<VwSapp5>(entity =>
            {
                entity.ToView("vw_Sapp5");
            });

            modelBuilder.Entity<VwSapp6>(entity =>
            {
                entity.ToView("vw_Sapp6");
            });

            modelBuilder.Entity<VwSard1>(entity =>
            {
                entity.ToView("vw_Sard1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSarl1>(entity =>
            {
                entity.ToView("vw_Sarl1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSarm1>(entity =>
            {
                entity.ToView("vw_Sarm1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSarn1>(entity =>
            {
                entity.ToView("vw_Sarn1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSasc1>(entity =>
            {
                entity.ToView("vw_Sasc1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSatb1>(entity =>
            {
                entity.ToView("vw_Satb1");
            });

            modelBuilder.Entity<VwSatb2>(entity =>
            {
                entity.ToView("vw_Satb2");
            });

            modelBuilder.Entity<VwSatp1>(entity =>
            {
                entity.ToView("vw_Satp1");

                entity.Property(e => e.Date).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSaud1>(entity =>
            {
                entity.ToView("vw_Saud1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSaug1>(entity =>
            {
                entity.ToView("vw_Saug1");

                entity.Property(e => e.LId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSaus1>(entity =>
            {
                entity.ToView("vw_Saus1");

                entity.Property(e => e.JoinDate).IsFixedLength();

                entity.Property(e => e.LastLoginDate).IsFixedLength();

                entity.Property(e => e.NextPasswordResetDate).IsFixedLength();

                entity.Property(e => e.ResignDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSaus10>(entity =>
            {
                entity.ToView("vw_Saus10");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSaus11>(entity =>
            {
                entity.ToView("vw_Saus11");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSaus2>(entity =>
            {
                entity.ToView("vw_Saus2");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSaus3>(entity =>
            {
                entity.ToView("vw_Saus3");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSaus4>(entity =>
            {
                entity.ToView("vw_Saus4");
            });

            modelBuilder.Entity<VwSaus5>(entity =>
            {
                entity.ToView("vw_Saus5");
            });

            modelBuilder.Entity<VwSaus6>(entity =>
            {
                entity.ToView("vw_Saus6");
            });

            modelBuilder.Entity<VwSaus7>(entity =>
            {
                entity.ToView("vw_Saus7");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSaus8>(entity =>
            {
                entity.ToView("vw_Saus8");
            });

            modelBuilder.Entity<VwSaus9>(entity =>
            {
                entity.ToView("vw_Saus9");
            });

            modelBuilder.Entity<VwSavl1>(entity =>
            {
                entity.ToView("vw_Savl1");
            });

            modelBuilder.Entity<VwSawf1>(entity =>
            {
                entity.ToView("vw_Sawf1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSawf2>(entity =>
            {
                entity.ToView("vw_Sawf2");
            });

            modelBuilder.Entity<VwSearchCriteriaExport>(entity =>
            {
                entity.ToView("vw_SearchCriteriaExport");
            });

            modelBuilder.Entity<VwSearchCriteriaImport>(entity =>
            {
                entity.ToView("vw_SearchCriteriaImport");
            });

            modelBuilder.Entity<VwSeat1>(entity =>
            {
                entity.ToView("vw_Seat1");
            });

            modelBuilder.Entity<VwSebh1>(entity =>
            {
                entity.ToView("vw_Sebh1");

                entity.Property(e => e.BookingDate).IsFixedLength();

                entity.Property(e => e.DestEta).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.FirstViaAtaDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtaDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtdDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.StuffDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSebh2>(entity =>
            {
                entity.ToView("vw_Sebh2");
            });

            modelBuilder.Entity<VwSebk1>(entity =>
            {
                entity.ToView("vw_Sebk1");

                entity.Property(e => e.BookingDate).IsFixedLength();

                entity.Property(e => e.DestEta).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.FirstViaAtaDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtaDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtdDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.StuffDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSebk2>(entity =>
            {
                entity.ToView("vw_Sebk2");
            });

            modelBuilder.Entity<VwSebk21>(entity =>
            {
                entity.ToView("vw_Sebk2_1");
            });

            modelBuilder.Entity<VwSebk3>(entity =>
            {
                entity.ToView("vw_Sebk3");
            });

            modelBuilder.Entity<VwSebk4>(entity =>
            {
                entity.ToView("vw_Sebk4");
            });

            modelBuilder.Entity<VwSebk5>(entity =>
            {
                entity.ToView("vw_Sebk5");
            });

            modelBuilder.Entity<VwSebkContainer>(entity =>
            {
                entity.ToView("vw_Sebk_Container");
            });

            modelBuilder.Entity<VwSebkNomination>(entity =>
            {
                entity.ToView("vw_sebk_Nomination");
            });

            modelBuilder.Entity<VwSebkTranshipment>(entity =>
            {
                entity.ToView("vw_Sebk_Transhipment");

                entity.Property(e => e.AtaDate).IsFixedLength();

                entity.Property(e => e.BookingDate).IsFixedLength();

                entity.Property(e => e.DestEta).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.FirstViaAtaDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtaDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtdDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.StuffDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSebl1>(entity =>
            {
                entity.ToView("vw_Sebl1");

                entity.Property(e => e.BillingDate).IsFixedLength();

                entity.Property(e => e.BlIssueDate).IsFixedLength();

                entity.Property(e => e.BlReadyDate).IsFixedLength();

                entity.Property(e => e.CargoCollectionDate).IsFixedLength();

                entity.Property(e => e.CargoReceiptDate).IsFixedLength();

                entity.Property(e => e.CfsUpdateDateTime).IsFixedLength();

                entity.Property(e => e.ConfirmArrivalDate).IsFixedLength();

                entity.Property(e => e.ConfirmDepartureDate).IsFixedLength();

                entity.Property(e => e.DeliveryOrderReleaseDate).IsFixedLength();

                entity.Property(e => e.DestEta).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtaDateDdMmYyyy).IsFixedLength();

                entity.Property(e => e.EtaDateDest).IsFixedLength();

                entity.Property(e => e.EtaDatePod).IsFixedLength();

                entity.Property(e => e.EtaDatePol).IsFixedLength();

                entity.Property(e => e.EtaDateSin).IsFixedLength();

                entity.Property(e => e.EtaPod).IsFixedLength();

                entity.Property(e => e.EtaPol).IsFixedLength();

                entity.Property(e => e.EtaSin).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.EtdDateDdMmYyyy).IsFixedLength();

                entity.Property(e => e.EtdDatePol).IsFixedLength();

                entity.Property(e => e.EtdPol).IsFixedLength();

                entity.Property(e => e.FfReceiptDate).IsFixedLength();

                entity.Property(e => e.FirstViaAtaDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtaDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtdDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.LadenDate).IsFixedLength();

                entity.Property(e => e.LodgeDate).IsFixedLength();

                entity.Property(e => e.PickUpDate).IsFixedLength();

                entity.Property(e => e.PreAlertDestDate).IsFixedLength();

                entity.Property(e => e.RequestDate).IsFixedLength();

                entity.Property(e => e.ShipDate).IsFixedLength();

                entity.Property(e => e.StuffDate).IsFixedLength();

                entity.Property(e => e.TaxRefundIssueDate).IsFixedLength();

                entity.Property(e => e.TaxRefundReturnDate).IsFixedLength();

                entity.Property(e => e.TruckingDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSebl1C>(entity =>
            {
                entity.ToView("vw_Sebl1_c");

                entity.Property(e => e.BillingDate).IsFixedLength();

                entity.Property(e => e.BlIssueDate).IsFixedLength();

                entity.Property(e => e.BlReadyDate).IsFixedLength();

                entity.Property(e => e.CargoCollectionDate).IsFixedLength();

                entity.Property(e => e.CfsUpdateDateTime).IsFixedLength();

                entity.Property(e => e.DeliveryOrderReleaseDate).IsFixedLength();

                entity.Property(e => e.DestEta).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.FirstViaAtaDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtaDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtdDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.LadenDate).IsFixedLength();

                entity.Property(e => e.PreAlertDestDate).IsFixedLength();

                entity.Property(e => e.ShipDate).IsFixedLength();

                entity.Property(e => e.StuffDate).IsFixedLength();

                entity.Property(e => e.TruckingDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSebl1HouseSubHouse>(entity =>
            {
                entity.ToView("vw_Sebl1_House_Sub_House");

                entity.Property(e => e.AtaDate).IsFixedLength();

                entity.Property(e => e.BillingDate).IsFixedLength();

                entity.Property(e => e.BlIssueDate).IsFixedLength();

                entity.Property(e => e.BlReadyDate).IsFixedLength();

                entity.Property(e => e.CargoCollectionDate).IsFixedLength();

                entity.Property(e => e.CargoReceiptDate).IsFixedLength();

                entity.Property(e => e.CfsUpdateDateTime).IsFixedLength();

                entity.Property(e => e.ConfirmArrivalDate).IsFixedLength();

                entity.Property(e => e.ConfirmDepartureDate).IsFixedLength();

                entity.Property(e => e.DeliveryOrderReleaseDate).IsFixedLength();

                entity.Property(e => e.DestEta).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.FfReceiptDate).IsFixedLength();

                entity.Property(e => e.FirstViaAtaDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtaDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtdDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.LadenDate).IsFixedLength();

                entity.Property(e => e.LodgeDate).IsFixedLength();

                entity.Property(e => e.PickUpDate).IsFixedLength();

                entity.Property(e => e.PreAlertDestDate).IsFixedLength();

                entity.Property(e => e.RequestDate).IsFixedLength();

                entity.Property(e => e.ShipDate).IsFixedLength();

                entity.Property(e => e.StuffDate).IsFixedLength();

                entity.Property(e => e.TaxRefundIssueDate).IsFixedLength();

                entity.Property(e => e.TaxRefundReturnDate).IsFixedLength();

                entity.Property(e => e.TruckingDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSebl1NoCnDn>(entity =>
            {
                entity.ToView("vw_Sebl1_No_Cn_Dn");

                entity.Property(e => e.AtaDate).IsFixedLength();

                entity.Property(e => e.AtaDateDdMmYyyy).IsFixedLength();

                entity.Property(e => e.BillingDate).IsFixedLength();

                entity.Property(e => e.BlIssueDate).IsFixedLength();

                entity.Property(e => e.BlReadyDate).IsFixedLength();

                entity.Property(e => e.CargoCollectionDate).IsFixedLength();

                entity.Property(e => e.CargoReceiptDate).IsFixedLength();

                entity.Property(e => e.CfsUpdateDateTime).IsFixedLength();

                entity.Property(e => e.ConfirmArrivalDate).IsFixedLength();

                entity.Property(e => e.ConfirmDepartureDate).IsFixedLength();

                entity.Property(e => e.DeliveryOrderReleaseDate).IsFixedLength();

                entity.Property(e => e.DestEta).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtaDateDdMmYyyy).IsFixedLength();

                entity.Property(e => e.EtaDestDate).IsFixedLength();

                entity.Property(e => e.EtaPolDate).IsFixedLength();

                entity.Property(e => e.EtaPolYyyyMmDd).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.EtdDateDdMmYyyy).IsFixedLength();

                entity.Property(e => e.FfReceiptDate).IsFixedLength();

                entity.Property(e => e.FirstViaAtaDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtaDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtdDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.LadenDate).IsFixedLength();

                entity.Property(e => e.LodgeDate).IsFixedLength();

                entity.Property(e => e.PickUpDate).IsFixedLength();

                entity.Property(e => e.PreAlertDestDate).IsFixedLength();

                entity.Property(e => e.RequestDate).IsFixedLength();

                entity.Property(e => e.ShipDate).IsFixedLength();

                entity.Property(e => e.StuffDate).IsFixedLength();

                entity.Property(e => e.TaxRefundIssueDate).IsFixedLength();

                entity.Property(e => e.TaxRefundReturnDate).IsFixedLength();

                entity.Property(e => e.TruckingDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSebl1T>(entity =>
            {
                entity.ToView("vw_Sebl1_TS");

                entity.Property(e => e.BillingDate).IsFixedLength();

                entity.Property(e => e.BlIssueDate).IsFixedLength();

                entity.Property(e => e.BlReadyDate).IsFixedLength();

                entity.Property(e => e.CargoCollectionDate).IsFixedLength();

                entity.Property(e => e.CargoReceiptDate).IsFixedLength();

                entity.Property(e => e.CfsUpdateDateTime).IsFixedLength();

                entity.Property(e => e.ConfirmArrivalDate).IsFixedLength();

                entity.Property(e => e.ConfirmDepartureDate).IsFixedLength();

                entity.Property(e => e.DeliveryOrderReleaseDate).IsFixedLength();

                entity.Property(e => e.DestEta).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtaDatePod).IsFixedLength();

                entity.Property(e => e.EtaDatePol).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.EtdDatePol).IsFixedLength();

                entity.Property(e => e.FfReceiptDate).IsFixedLength();

                entity.Property(e => e.FirstViaAtaDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtaDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtdDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.LadenDate).IsFixedLength();

                entity.Property(e => e.LodgeDate).IsFixedLength();

                entity.Property(e => e.PickUpDate).IsFixedLength();

                entity.Property(e => e.PreAlertDestDate).IsFixedLength();

                entity.Property(e => e.RequestDate).IsFixedLength();

                entity.Property(e => e.ShipDate).IsFixedLength();

                entity.Property(e => e.StuffDate).IsFixedLength();

                entity.Property(e => e.TaxRefundIssueDate).IsFixedLength();

                entity.Property(e => e.TaxRefundReturnDate).IsFixedLength();

                entity.Property(e => e.TruckingDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSebl1W>(entity =>
            {
                entity.ToView("vw_Sebl1_w");

                entity.Property(e => e.BillingDate).IsFixedLength();

                entity.Property(e => e.BlIssueDate).IsFixedLength();

                entity.Property(e => e.BlReadyDate).IsFixedLength();

                entity.Property(e => e.CargoCollectionDate).IsFixedLength();

                entity.Property(e => e.CfsUpdateDateTime).IsFixedLength();

                entity.Property(e => e.DeliveryOrderReleaseDate).IsFixedLength();

                entity.Property(e => e.DestEta).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.FirstViaAtaDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtaDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtdDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.LadenDate).IsFixedLength();

                entity.Property(e => e.PreAlertDestDate).IsFixedLength();

                entity.Property(e => e.ShipDate).IsFixedLength();

                entity.Property(e => e.StuffDate).IsFixedLength();

                entity.Property(e => e.TruckingDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSebl2>(entity =>
            {
                entity.ToView("vw_Sebl2");

                entity.Property(e => e.CompletionDate).IsFixedLength();

                entity.Property(e => e.ContainerReturnDate).IsFixedLength();

                entity.Property(e => e.ContainerTransferDate).IsFixedLength();

                entity.Property(e => e.DischargeDate).IsFixedLength();

                entity.Property(e => e.DoReleaseDate).IsFixedLength();

                entity.Property(e => e.EmptyDate).IsFixedLength();

                entity.Property(e => e.FinalDestDate).IsFixedLength();

                entity.Property(e => e.HODate).IsFixedLength();

                entity.Property(e => e.LadenDate).IsFixedLength();

                entity.Property(e => e.PickupDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSebl21>(entity =>
            {
                entity.ToView("vw_Sebl2_1");

                entity.Property(e => e.CompletionDate).IsFixedLength();

                entity.Property(e => e.ContainerReturnDate).IsFixedLength();

                entity.Property(e => e.ContainerTransferDate).IsFixedLength();

                entity.Property(e => e.DischargeDate).IsFixedLength();

                entity.Property(e => e.DoReleaseDate).IsFixedLength();

                entity.Property(e => e.EmptyDate).IsFixedLength();

                entity.Property(e => e.FinalDestDate).IsFixedLength();

                entity.Property(e => e.HODate).IsFixedLength();

                entity.Property(e => e.LadenDate).IsFixedLength();

                entity.Property(e => e.PickupDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSebl22>(entity =>
            {
                entity.ToView("vw_Sebl2_2");

                entity.Property(e => e.CompletionDate).IsFixedLength();

                entity.Property(e => e.ContainerReturnDate).IsFixedLength();

                entity.Property(e => e.ContainerTransferDate).IsFixedLength();

                entity.Property(e => e.DischargeDate).IsFixedLength();

                entity.Property(e => e.DoReleaseDate).IsFixedLength();

                entity.Property(e => e.EmptyDate).IsFixedLength();

                entity.Property(e => e.FinalDestDate).IsFixedLength();

                entity.Property(e => e.HODate).IsFixedLength();

                entity.Property(e => e.LadenDate).IsFixedLength();

                entity.Property(e => e.PickupDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSebl2Container>(entity =>
            {
                entity.ToView("vw_Sebl2_Container");

                entity.Property(e => e.CompletionDate).IsFixedLength();

                entity.Property(e => e.ContainerReturnDate).IsFixedLength();

                entity.Property(e => e.ContainerTransferDate).IsFixedLength();

                entity.Property(e => e.DischargeDate).IsFixedLength();

                entity.Property(e => e.DoReleaseDate).IsFixedLength();

                entity.Property(e => e.EmptyDate).IsFixedLength();

                entity.Property(e => e.FinalDestDate).IsFixedLength();

                entity.Property(e => e.HODate).IsFixedLength();

                entity.Property(e => e.LadenDate).IsFixedLength();

                entity.Property(e => e.PickupDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSebl3>(entity =>
            {
                entity.ToView("vw_Sebl3");
            });

            modelBuilder.Entity<VwSebl4>(entity =>
            {
                entity.ToView("vw_Sebl4");

                entity.Property(e => e.ReqDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSebl5>(entity =>
            {
                entity.ToView("vw_Sebl5");
            });

            modelBuilder.Entity<VwSebl6>(entity =>
            {
                entity.ToView("vw_Sebl6");
            });

            modelBuilder.Entity<VwSebl7>(entity =>
            {
                entity.ToView("vw_Sebl7");
            });

            modelBuilder.Entity<VwSebl8>(entity =>
            {
                entity.ToView("vw_Sebl8");
            });

            modelBuilder.Entity<VwSebl9>(entity =>
            {
                entity.ToView("vw_Sebl9");
            });

            modelBuilder.Entity<VwSeblContainer>(entity =>
            {
                entity.ToView("vw_Sebl_Container");
            });

            modelBuilder.Entity<VwSeblContainerTotal>(entity =>
            {
                entity.ToView("vw_Sebl_Container_Total");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSeblJob>(entity =>
            {
                entity.ToView("vw_Sebl_Job");
            });

            modelBuilder.Entity<VwSeblNonTranshipment>(entity =>
            {
                entity.ToView("vw_Sebl_Non_Transhipment");
            });

            modelBuilder.Entity<VwSeblTranshipment>(entity =>
            {
                entity.ToView("vw_Sebl_Transhipment");
            });

            modelBuilder.Entity<VwSeblTsVolByMaster>(entity =>
            {
                entity.ToView("vw_Sebl_Ts_Vol_By_Master");
            });

            modelBuilder.Entity<VwSecp1>(entity =>
            {
                entity.ToView("vw_Secp1");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSecp2>(entity =>
            {
                entity.ToView("vw_Secp2");
            });

            modelBuilder.Entity<VwSecsl>(entity =>
            {
                entity.ToView("vw_Secsl");

                entity.Property(e => e.Eta).IsFixedLength();

                entity.Property(e => e.Etd).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSefp1>(entity =>
            {
                entity.ToView("vw_Sefp1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSeiv1>(entity =>
            {
                entity.ToView("vw_Seiv1");

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSeiv1Vat>(entity =>
            {
                entity.ToView("vw_Seiv1_Vat");
            });

            modelBuilder.Entity<VwSeiv2>(entity =>
            {
                entity.ToView("vw_Seiv2");
            });

            modelBuilder.Entity<VwSeiv2Vat>(entity =>
            {
                entity.ToView("vw_Seiv2_Vat");
            });

            modelBuilder.Entity<VwSemp1>(entity =>
            {
                entity.ToView("vw_Semp1");

                entity.Property(e => e.CargoReceiptDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSemp2>(entity =>
            {
                entity.ToView("vw_Semp2");
            });

            modelBuilder.Entity<VwSepa1>(entity =>
            {
                entity.ToView("vw_Sepa1");

                entity.Property(e => e.LastInvoiceTransferDate).IsFixedLength();

                entity.Property(e => e.LastJobPostDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSepi1>(entity =>
            {
                entity.ToView("vw_Sepi1");

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSepi2>(entity =>
            {
                entity.ToView("vw_Sepi2");
            });

            modelBuilder.Entity<VwSepv1>(entity =>
            {
                entity.ToView("vw_Sepv1");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSepv2>(entity =>
            {
                entity.ToView("vw_Sepv2");
            });

            modelBuilder.Entity<VwSibl1>(entity =>
            {
                entity.ToView("vw_Sibl1");

                entity.Property(e => e.AtaDate).IsFixedLength();

                entity.Property(e => e.BillingDate).IsFixedLength();

                entity.Property(e => e.BlIssueDate).IsFixedLength();

                entity.Property(e => e.CargoCollectionDate).IsFixedLength();

                entity.Property(e => e.CargoRcvDate).IsFixedLength();

                entity.Property(e => e.CargoReadyDate).IsFixedLength();

                entity.Property(e => e.CargoReceiptDate).IsFixedLength();

                entity.Property(e => e.CfsUpdateDateTime).IsFixedLength();

                entity.Property(e => e.DeliveryOrderReleaseDate).IsFixedLength();

                entity.Property(e => e.DestEta).IsFixedLength();

                entity.Property(e => e.DocRcvDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtaTime).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.ExportAtaDate).IsFixedLength();

                entity.Property(e => e.ExportEtaDate).IsFixedLength();

                entity.Property(e => e.ExportEtdDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtaDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtdDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.LadenDate).IsFixedLength();

                entity.Property(e => e.ShipDate).IsFixedLength();

                entity.Property(e => e.TrkRcvDateDate).IsFixedLength();

                entity.Property(e => e.TrkReceiptDate).IsFixedLength();

                entity.Property(e => e.TruckingDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();

                entity.Property(e => e.UnstuffDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSibl10>(entity =>
            {
                entity.ToView("vw_Sibl10");
            });

            modelBuilder.Entity<VwSibl11>(entity =>
            {
                entity.ToView("vw_Sibl11");
            });

            modelBuilder.Entity<VwSibl1CfsHouse>(entity =>
            {
                entity.ToView("vw_Sibl1_CFS_House");

                entity.Property(e => e.BillingDate).IsFixedLength();

                entity.Property(e => e.BlIssueDate).IsFixedLength();

                entity.Property(e => e.CargoCollectionDate).IsFixedLength();

                entity.Property(e => e.CargoRcvDate).IsFixedLength();

                entity.Property(e => e.CargoReadyDate).IsFixedLength();

                entity.Property(e => e.CargoReceiptDate).IsFixedLength();

                entity.Property(e => e.DeliveryDate).IsFixedLength();

                entity.Property(e => e.DeliveryOrderReleaseDate).IsFixedLength();

                entity.Property(e => e.DestEta).IsFixedLength();

                entity.Property(e => e.DocRcvDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtaTime).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.ExportAtaDate).IsFixedLength();

                entity.Property(e => e.ExportEta).IsFixedLength();

                entity.Property(e => e.ExportEtd).IsFixedLength();

                entity.Property(e => e.FirstViaEtaDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtdDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.LadenDate).IsFixedLength();

                entity.Property(e => e.ShipDate).IsFixedLength();

                entity.Property(e => e.TrkRcvDateDate).IsFixedLength();

                entity.Property(e => e.TrkReceiptDate).IsFixedLength();

                entity.Property(e => e.TruckingDate).IsFixedLength();

                entity.Property(e => e.UnstuffDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSibl1ContainerType>(entity =>
            {
                entity.ToView("vw_Sibl1_Container_Type");

                entity.Property(e => e.AtaDate).IsFixedLength();

                entity.Property(e => e.BillingDate).IsFixedLength();

                entity.Property(e => e.BlIssueDate).IsFixedLength();

                entity.Property(e => e.CargoCollectionDate).IsFixedLength();

                entity.Property(e => e.CargoRcvDate).IsFixedLength();

                entity.Property(e => e.CargoReadyDate).IsFixedLength();

                entity.Property(e => e.CargoReceiptDate).IsFixedLength();

                entity.Property(e => e.CfsUpdateDateTime).IsFixedLength();

                entity.Property(e => e.DeliveryOrderReleaseDate).IsFixedLength();

                entity.Property(e => e.DestEta).IsFixedLength();

                entity.Property(e => e.DocRcvDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtaTime).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.ExportEta).IsFixedLength();

                entity.Property(e => e.ExportEtd).IsFixedLength();

                entity.Property(e => e.FirstViaEtaDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtdDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.LadenDate).IsFixedLength();

                entity.Property(e => e.ShipDate).IsFixedLength();

                entity.Property(e => e.TrkRcvDateDate).IsFixedLength();

                entity.Property(e => e.TrkReceiptDate).IsFixedLength();

                entity.Property(e => e.TruckingDate).IsFixedLength();

                entity.Property(e => e.UnstuffDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSibl1HouseSubHouse>(entity =>
            {
                entity.ToView("vw_Sibl1_House_Sub_House");

                entity.Property(e => e.AtaDate).IsFixedLength();

                entity.Property(e => e.BillingDate).IsFixedLength();

                entity.Property(e => e.BlIssueDate).IsFixedLength();

                entity.Property(e => e.CargoCollectionDate).IsFixedLength();

                entity.Property(e => e.CargoRcvDate).IsFixedLength();

                entity.Property(e => e.CargoReadyDate).IsFixedLength();

                entity.Property(e => e.CargoReceiptDate).IsFixedLength();

                entity.Property(e => e.CfsUpdateDateTime).IsFixedLength();

                entity.Property(e => e.DeliveryOrderReleaseDate).IsFixedLength();

                entity.Property(e => e.DestEta).IsFixedLength();

                entity.Property(e => e.DocRcvDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtaTime).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.ExportAtaDate).IsFixedLength();

                entity.Property(e => e.ExportEtaDate).IsFixedLength();

                entity.Property(e => e.ExportEtdDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtaDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtdDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.LadenDate).IsFixedLength();

                entity.Property(e => e.ShipDate).IsFixedLength();

                entity.Property(e => e.TrkRcvDateDate).IsFixedLength();

                entity.Property(e => e.TrkReceiptDate).IsFixedLength();

                entity.Property(e => e.TruckingDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();

                entity.Property(e => e.UnstuffDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSibl1NonMaster>(entity =>
            {
                entity.ToView("vw_Sibl1_Non_Master");

                entity.Property(e => e.AtaDate).IsFixedLength();

                entity.Property(e => e.BillingDate).IsFixedLength();

                entity.Property(e => e.BlIssueDate).IsFixedLength();

                entity.Property(e => e.CargoCollectionDate).IsFixedLength();

                entity.Property(e => e.CargoRcvDate).IsFixedLength();

                entity.Property(e => e.CargoReadyDate).IsFixedLength();

                entity.Property(e => e.CargoReceiptDate).IsFixedLength();

                entity.Property(e => e.CfsUpdateDateTime).IsFixedLength();

                entity.Property(e => e.DeliveryOrderReleaseDate).IsFixedLength();

                entity.Property(e => e.DestEta).IsFixedLength();

                entity.Property(e => e.DocRcvDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.ExportEta).IsFixedLength();

                entity.Property(e => e.ExportEtd).IsFixedLength();

                entity.Property(e => e.FirstViaEtaDate).IsFixedLength();

                entity.Property(e => e.FirstViaEtdDate).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.LadenDate).IsFixedLength();

                entity.Property(e => e.ShipDate).IsFixedLength();

                entity.Property(e => e.TrkRcvDateDate).IsFixedLength();

                entity.Property(e => e.TrkReceiptDate).IsFixedLength();

                entity.Property(e => e.TruckingDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();

                entity.Property(e => e.UnstuffDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSibl1WarehouseCharge>(entity =>
            {
                entity.ToView("vw_sibl1_Warehouse_Charge");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSibl2>(entity =>
            {
                entity.ToView("vw_Sibl2");

                entity.Property(e => e.ContainerReturnDate).IsFixedLength();

                entity.Property(e => e.ContainerTransferDate).IsFixedLength();

                entity.Property(e => e.DeliveryDate).IsFixedLength();

                entity.Property(e => e.DischargeDate).IsFixedLength();

                entity.Property(e => e.DoReleaseDate).IsFixedLength();

                entity.Property(e => e.EmptyDate).IsFixedLength();

                entity.Property(e => e.FinalDestDate).IsFixedLength();

                entity.Property(e => e.HODate).IsFixedLength();

                entity.Property(e => e.RequestDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSibl21>(entity =>
            {
                entity.ToView("vw_Sibl2_1");

                entity.Property(e => e.ContainerReturnDate).IsFixedLength();

                entity.Property(e => e.ContainerTransferDate).IsFixedLength();

                entity.Property(e => e.DeliveryDate).IsFixedLength();

                entity.Property(e => e.DischargeDate).IsFixedLength();

                entity.Property(e => e.DoReleaseDate).IsFixedLength();

                entity.Property(e => e.EmptyDate).IsFixedLength();

                entity.Property(e => e.FinalDestDate).IsFixedLength();

                entity.Property(e => e.HODate).IsFixedLength();

                entity.Property(e => e.RequestDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSibl3>(entity =>
            {
                entity.ToView("vw_Sibl3");
            });

            modelBuilder.Entity<VwSibl4>(entity =>
            {
                entity.ToView("vw_Sibl4");
            });

            modelBuilder.Entity<VwSibl5>(entity =>
            {
                entity.ToView("vw_Sibl5");
            });

            modelBuilder.Entity<VwSibl6>(entity =>
            {
                entity.ToView("vw_Sibl6");

                entity.Property(e => e.SwitchBlIssueDate).IsFixedLength();

                entity.Property(e => e.SwitchLadenDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSibl7>(entity =>
            {
                entity.ToView("vw_Sibl7");
            });

            modelBuilder.Entity<VwSibl8>(entity =>
            {
                entity.ToView("vw_Sibl8");
            });

            modelBuilder.Entity<VwSibl9>(entity =>
            {
                entity.ToView("vw_Sibl9");
            });

            modelBuilder.Entity<VwSiblContainer>(entity =>
            {
                entity.ToView("vw_Sibl_Container");
            });

            modelBuilder.Entity<VwSiblContainerTotal>(entity =>
            {
                entity.ToView("vw_sibl_Container_Total");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSiblJob>(entity =>
            {
                entity.ToView("vw_Sibl_Job");
            });

            modelBuilder.Entity<VwSiblNonTranshipment>(entity =>
            {
                entity.ToView("vw_Sibl_Non_Transhipment");
            });

            modelBuilder.Entity<VwSiblTranshipment>(entity =>
            {
                entity.ToView("vw_Sibl_Transhipment");
            });

            modelBuilder.Entity<VwSiblTsVolByMaster>(entity =>
            {
                entity.ToView("vw_Sibl_Ts_Vol_By_Master");
            });

            modelBuilder.Entity<VwSicp1>(entity =>
            {
                entity.ToView("vw_Sicp1");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSicp2>(entity =>
            {
                entity.ToView("vw_Sicp2");
            });

            modelBuilder.Entity<VwSidi1>(entity =>
            {
                entity.ToView("vw_Sidi1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSidi2>(entity =>
            {
                entity.ToView("vw_Sidi2");

                entity.Property(e => e.DeliveryDateTime).IsFixedLength();
            });

            modelBuilder.Entity<VwSidi21>(entity =>
            {
                entity.ToView("vw_Sidi2_1");

                entity.Property(e => e.DeliveryDateTime).IsFixedLength();
            });

            modelBuilder.Entity<VwSido1>(entity =>
            {
                entity.ToView("vw_Sido1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSido2>(entity =>
            {
                entity.ToView("vw_Sido2");
            });

            modelBuilder.Entity<VwSido21>(entity =>
            {
                entity.ToView("vw_Sido2_1");
            });

            modelBuilder.Entity<VwSiiv1>(entity =>
            {
                entity.ToView("vw_Siiv1");

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSiiv1Vat>(entity =>
            {
                entity.ToView("vw_Siiv1_Vat");
            });

            modelBuilder.Entity<VwSiiv2>(entity =>
            {
                entity.ToView("vw_Siiv2");
            });

            modelBuilder.Entity<VwSiiv2Vat>(entity =>
            {
                entity.ToView("vw_Siiv2_Vat");
            });

            modelBuilder.Entity<VwSipa1>(entity =>
            {
                entity.ToView("vw_Sipa1");

                entity.Property(e => e.LastInvoiceTrfDate).IsFixedLength();

                entity.Property(e => e.LastJobPostDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSipv1>(entity =>
            {
                entity.ToView("vw_Sipv1");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSipv2>(entity =>
            {
                entity.ToView("vw_Sipv2");
            });

            modelBuilder.Entity<VwSlaj1>(entity =>
            {
                entity.ToView("vw_Slaj1");

                entity.Property(e => e.AdjustDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSlbs1>(entity =>
            {
                entity.ToView("vw_Slbs1");

                entity.Property(e => e.BankSlipDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSlcc1>(entity =>
            {
                entity.ToView("vw_Slcc1");
            });

            modelBuilder.Entity<VwSlcm1>(entity =>
            {
                entity.ToView("vw_Slcm1");

                entity.Property(e => e.BackupEndDate).IsFixedLength();

                entity.Property(e => e.BackupStartDate).IsFixedLength();

                entity.Property(e => e.EndDate).IsFixedLength();

                entity.Property(e => e.StartDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSlcm2>(entity =>
            {
                entity.ToView("vw_Slcm2");

                entity.Property(e => e.ExpiryDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSlcr1>(entity =>
            {
                entity.ToView("vw_Slcr1");

                entity.Property(e => e.BankSlipDate).IsFixedLength();

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.ClearDate).IsFixedLength();

                entity.Property(e => e.DueDateFrom).IsFixedLength();

                entity.Property(e => e.DueDateTo).IsFixedLength();

                entity.Property(e => e.PlanCollectionDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSlcr1Wht>(entity =>
            {
                entity.ToView("vw_Slcr1_WHT");

                entity.Property(e => e.BankSlipDate).IsFixedLength();

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.ClearDate).IsFixedLength();

                entity.Property(e => e.DueDateFrom).IsFixedLength();

                entity.Property(e => e.DueDateTo).IsFixedLength();

                entity.Property(e => e.PlanCollectionDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSlcr2>(entity =>
            {
                entity.ToView("vw_Slcr2");
            });

            modelBuilder.Entity<VwSlcr3>(entity =>
            {
                entity.ToView("vw_Slcr3");

                entity.Property(e => e.ChequeDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSlcr4>(entity =>
            {
                entity.ToView("vw_Slcr4");
            });

            modelBuilder.Entity<VwSlcrAcc>(entity =>
            {
                entity.ToView("vw_Slcr_Acc");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSlcs1>(entity =>
            {
                entity.ToView("vw_Slcs1");

                entity.Property(e => e.BankSlipDate).IsFixedLength();

                entity.Property(e => e.JournalDate).IsFixedLength();

                entity.Property(e => e.KeyId).ValueGeneratedOnAdd();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSlcs2>(entity =>
            {
                entity.ToView("vw_Slcs2");

                entity.Property(e => e.BankSlipDate).IsFixedLength();

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.JournalDate).IsFixedLength();

                entity.Property(e => e.KeyId).ValueGeneratedOnAdd();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSlct1>(entity =>
            {
                entity.ToView("vw_Slct1");
            });

            modelBuilder.Entity<VwSlcu1>(entity =>
            {
                entity.ToView("vw_Slcu1");

                entity.Property(e => e.CreditDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSlcu2>(entity =>
            {
                entity.ToView("vw_Slcu2");
            });

            modelBuilder.Entity<VwSlcu3>(entity =>
            {
                entity.ToView("vw_Slcu3");
            });

            modelBuilder.Entity<VwSlcu4>(entity =>
            {
                entity.ToView("vw_Slcu4");

                entity.Property(e => e.EndDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.StartDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSlcu5>(entity =>
            {
                entity.ToView("vw_Slcu5");

                entity.Property(e => e.AgeingDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSlcu6>(entity =>
            {
                entity.ToView("vw_Slcu6");

                entity.Property(e => e.EffectiveDate).IsFixedLength();

                entity.Property(e => e.ExpiryDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSlpa1>(entity =>
            {
                entity.ToView("vw_Slpa1");

                entity.Property(e => e.NextPostDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSltx1>(entity =>
            {
                entity.ToView("vw_Sltx1");

                entity.Property(e => e.AgeingDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSltx1CreditNote>(entity =>
            {
                entity.ToView("vw_Sltx1_Credit_Note");

                entity.Property(e => e.AgeingDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSltx1NoCn>(entity =>
            {
                entity.ToView("vw_Sltx1_No_Cn");

                entity.Property(e => e.AgeingDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSltx1Payment>(entity =>
            {
                entity.ToView("vw_Sltx1_Payment");

                entity.Property(e => e.AgeingDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSltx1VatOutLay>(entity =>
            {
                entity.ToView("vw_Sltx1_Vat_Out_Lay");

                entity.Property(e => e.AgeingDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSlvx1>(entity =>
            {
                entity.ToView("vw_Slvx1");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSlvx11>(entity =>
            {
                entity.ToView("vw_Slvx1_1");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSlvx12>(entity =>
            {
                entity.ToView("vw_Slvx1_2");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSlvx1Aug>(entity =>
            {
                entity.ToView("vw_Slvx1_AUG");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSlvx1Ira>(entity =>
            {
                entity.ToView("vw_Slvx1_IRAS");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSlvx1NoVat>(entity =>
            {
                entity.ToView("vw_Slvx1_No_Vat");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSlvx1Sin>(entity =>
            {
                entity.ToView("vw_Slvx1_SIN");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSmbr1>(entity =>
            {
                entity.ToView("vw_Smbr1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSmbr2>(entity =>
            {
                entity.ToView("vw_Smbr2");
            });

            modelBuilder.Entity<VwSmct1>(entity =>
            {
                entity.ToView("vw_Smct1");

                entity.Property(e => e.EffectiveDate).IsFixedLength();

                entity.Property(e => e.ExpiryDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSmct1A>(entity =>
            {
                entity.ToView("vw_Smct1_A");

                entity.Property(e => e.EffectiveDate).IsFixedLength();

                entity.Property(e => e.ExpiryDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSmct1NonDg>(entity =>
            {
                entity.ToView("vw_Smct1_Non_DG");

                entity.Property(e => e.EffectiveDate).IsFixedLength();

                entity.Property(e => e.ExpiryDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSmct1NonDg2StandardCharge>(entity =>
            {
                entity.ToView("vw_Smct1_Non_DG2_Standard_Charge");

                entity.Property(e => e.EffectiveDate).IsFixedLength();

                entity.Property(e => e.ExpiryDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSmct1NonDg3StandardCharge>(entity =>
            {
                entity.ToView("vw_Smct1_Non_DG3_Standard_Charge");

                entity.Property(e => e.EffectiveDate).IsFixedLength();

                entity.Property(e => e.ExpiryDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSmct2>(entity =>
            {
                entity.ToView("vw_Smct2");

                entity.Property(e => e.EffectiveDate).IsFixedLength();

                entity.Property(e => e.ExpiryDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSmct3>(entity =>
            {
                entity.ToView("vw_Smct3");

                entity.Property(e => e.BreakRateType).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.QuoteRate).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ZoneCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwSmec1>(entity =>
            {
                entity.ToView("vw_Smec1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSmec2>(entity =>
            {
                entity.ToView("vw_Smec2");
            });

            modelBuilder.Entity<VwSmef1>(entity =>
            {
                entity.ToView("vw_Smef1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSmef2>(entity =>
            {
                entity.ToView("vw_Smef2");
            });

            modelBuilder.Entity<VwSmfd1>(entity =>
            {
                entity.ToView("vw_Smfd1");

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtaPod).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSmfd2>(entity =>
            {
                entity.ToView("vw_Smfd2");
            });

            modelBuilder.Entity<VwSmfq1>(entity =>
            {
                entity.ToView("vw_Smfq1");

                entity.Property(e => e.EffectiveDate).IsFixedLength();

                entity.Property(e => e.ExpiryDate).IsFixedLength();

                entity.Property(e => e.LastQuoteDate).IsFixedLength();

                entity.Property(e => e.QuoteDate).IsFixedLength();

                entity.Property(e => e.RevisionDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();

                entity.Property(e => e.ValidateDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSmfq2>(entity =>
            {
                entity.ToView("vw_Smfq2");

                entity.Property(e => e.EffectiveDate).IsFixedLength();

                entity.Property(e => e.QuoteDate).IsFixedLength();

                entity.Property(e => e.RevisionDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSmfq2StandardCharge>(entity =>
            {
                entity.ToView("vw_Smfq2_Standard_Charge");

                entity.Property(e => e.EffectiveDate).IsFixedLength();

                entity.Property(e => e.QuoteDate).IsFixedLength();

                entity.Property(e => e.RevisionDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSmfq3>(entity =>
            {
                entity.ToView("vw_Smfq3");
            });

            modelBuilder.Entity<VwSmfq3NonDg2>(entity =>
            {
                entity.ToView("vw_Smfq3_Non_Dg2");
            });

            modelBuilder.Entity<VwSmfq3NonDg3>(entity =>
            {
                entity.ToView("vw_Smfq3_Non_Dg3");
            });

            modelBuilder.Entity<VwSmfq3StandardCharge>(entity =>
            {
                entity.ToView("vw_Smfq3_Standard_Charge");
            });

            modelBuilder.Entity<VwSmfq3Uom>(entity =>
            {
                entity.ToView("vw_Smfq3_Uom");
            });

            modelBuilder.Entity<VwSmfq4>(entity =>
            {
                entity.ToView("vw_Smfq4");
            });

            modelBuilder.Entity<VwSmfq6>(entity =>
            {
                entity.ToView("vw_Smfq6");
            });

            modelBuilder.Entity<VwSmhq1>(entity =>
            {
                entity.ToView("vw_Smhq1");
            });

            modelBuilder.Entity<VwSmhq2>(entity =>
            {
                entity.ToView("vw_Smhq2");
            });

            modelBuilder.Entity<VwSmht1>(entity =>
            {
                entity.ToView("vw_Smht1");
            });

            modelBuilder.Entity<VwSmht2>(entity =>
            {
                entity.ToView("vw_Smht2");
            });

            modelBuilder.Entity<VwSmic1>(entity =>
            {
                entity.ToView("vw_Smic1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSmic2>(entity =>
            {
                entity.ToView("vw_Smic2");
            });

            modelBuilder.Entity<VwSmif1>(entity =>
            {
                entity.ToView("vw_Smif1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSmif2>(entity =>
            {
                entity.ToView("vw_Smif2");
            });

            modelBuilder.Entity<VwSmiq1>(entity =>
            {
                entity.ToView("vw_Smiq1");
            });

            modelBuilder.Entity<VwSmiq2>(entity =>
            {
                entity.ToView("vw_Smiq2");
            });

            modelBuilder.Entity<VwSmit1>(entity =>
            {
                entity.ToView("vw_Smit1");
            });

            modelBuilder.Entity<VwSmit2>(entity =>
            {
                entity.ToView("vw_Smit2");
            });

            modelBuilder.Entity<VwSmpa1>(entity =>
            {
                entity.ToView("vw_Smpa1");
            });

            modelBuilder.Entity<VwSmpa2>(entity =>
            {
                entity.ToView("vw_Smpa2");
            });

            modelBuilder.Entity<VwSmqt1>(entity =>
            {
                entity.ToView("vw_Smqt1");
            });

            modelBuilder.Entity<VwSmsa1>(entity =>
            {
                entity.ToView("vw_Smsa1");

                entity.Property(e => e.ClosedDate).IsFixedLength();

                entity.Property(e => e.DateTime).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwSmsa2>(entity =>
            {
                entity.ToView("vw_Smsa2");

                entity.Property(e => e.DateTime).IsFixedLength();
            });

            modelBuilder.Entity<VwSsjd1>(entity =>
            {
                entity.ToView("vw_Ssjd1");

                entity.Property(e => e.InvoiceDate).IsFixedLength();
            });

            modelBuilder.Entity<VwSsst1>(entity =>
            {
                entity.ToView("vw_Ssst1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwTestGlex1>(entity =>
            {
                entity.ToView("vw_test_glex1");
            });

            modelBuilder.Entity<VwTjms1>(entity =>
            {
                entity.ToView("vw_Tjms1");

                entity.Property(e => e.ApprovedDate).IsFixedLength();
            });

            modelBuilder.Entity<VwTmbi1>(entity =>
            {
                entity.ToView("vw_Tmbi1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwTmbi2>(entity =>
            {
                entity.ToView("vw_Tmbi2");
            });

            modelBuilder.Entity<VwTmpJmpl1>(entity =>
            {
                entity.ToView("vw_Tmp_Jmpl1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwTmpJmpl1ByJob>(entity =>
            {
                entity.ToView("vw_Tmp_Jmpl1_By_Job");
            });

            modelBuilder.Entity<VwTmpJmpl1Internal>(entity =>
            {
                entity.ToView("vw_Tmp_Jmpl1_Internal");
            });

            modelBuilder.Entity<VwTncl1>(entity =>
            {
                entity.ToView("vw_Tncl1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwTncp1>(entity =>
            {
                entity.ToView("vw_Tncp1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwTnem1>(entity =>
            {
                entity.ToView("vw_Tnem1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwTnex1>(entity =>
            {
                entity.ToView("vw_Tnex1");
            });

            modelBuilder.Entity<VwTnex2>(entity =>
            {
                entity.ToView("vw_Tnex2");

                entity.Property(e => e.EffectiveDate).IsFixedLength();
            });

            modelBuilder.Entity<VwTnhs1>(entity =>
            {
                entity.ToView("vw_Tnhs1");
            });

            modelBuilder.Entity<VwTnmp1>(entity =>
            {
                entity.ToView("vw_Tnmp1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwTnpa1>(entity =>
            {
                entity.ToView("vw_Tnpa1");

                entity.Property(e => e.PasswordUpdateDate).IsFixedLength();
            });

            modelBuilder.Entity<VwTnrc1>(entity =>
            {
                entity.ToView("vw_Tnrc1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwTnrf1>(entity =>
            {
                entity.ToView("vw_Tnrf1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwTnrf2>(entity =>
            {
                entity.ToView("vw_Tnrf2");
            });

            modelBuilder.Entity<VwTnsl1>(entity =>
            {
                entity.ToView("vw_Tnsl1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwTntRoleFunction>(entity =>
            {
                entity.ToView("vw_TNT_RoleFunction");
            });

            modelBuilder.Entity<VwTntUserPageAccess>(entity =>
            {
                entity.ToView("vw_TNT_UserPageAccess");
            });

            modelBuilder.Entity<VwTntWmstrackingBalance>(entity =>
            {
                entity.ToView("vw_TNT_WMSTracking_Balance");
            });

            modelBuilder.Entity<VwTntWmstrackingMovement>(entity =>
            {
                entity.ToView("vw_TNT_WMSTracking_Movement");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwTntWmstrackingMovement20180206Bk>(entity =>
            {
                entity.ToView("vw_TNT_WMSTracking_Movement_20180206_BK");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwTnum1>(entity =>
            {
                entity.ToView("vw_Tnum1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwToac1>(entity =>
            {
                entity.ToView("vw_Toac1");
            });

            modelBuilder.Entity<VwTobk1>(entity =>
            {
                entity.ToView("vw_Tobk1");

                entity.Property(e => e.CloseDateTime).IsFixedLength();

                entity.Property(e => e.DeliveryEndDate).IsFixedLength();

                entity.Property(e => e.DestDeliveryDateTime).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtaDate2).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.EtdDate2).IsFixedLength();

                entity.Property(e => e.JobDate).IsFixedLength();

                entity.Property(e => e.ScheduleDate).IsFixedLength();
            });

            modelBuilder.Entity<VwTobk2>(entity =>
            {
                entity.ToView("vw_Tobk2");

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtaDate2).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.EtdDate2).IsFixedLength();

                entity.Property(e => e.ExportTime).IsFixedLength();

                entity.Property(e => e.GateInDateTime).IsFixedLength();

                entity.Property(e => e.LastDayPsaDateTime).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();
            });

            modelBuilder.Entity<VwTobk21>(entity =>
            {
                entity.ToView("vw_Tobk2_1");

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtaDate2).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.EtdDate2).IsFixedLength();

                entity.Property(e => e.ExportTime).IsFixedLength();

                entity.Property(e => e.GateInDateTime).IsFixedLength();

                entity.Property(e => e.LastDayPsaDateTime).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();
            });

            modelBuilder.Entity<VwTobk3>(entity =>
            {
                entity.ToView("vw_Tobk3");

                entity.Property(e => e.OrderDate).IsFixedLength();

                entity.Property(e => e.ScheduleDate).IsFixedLength();
            });

            modelBuilder.Entity<VwTobk4>(entity =>
            {
                entity.ToView("vw_Tobk4");
            });

            modelBuilder.Entity<VwTobk5>(entity =>
            {
                entity.ToView("vw_Tobk5");

                entity.Property(e => e.ChargeDate).IsFixedLength();
            });

            modelBuilder.Entity<VwTobk6>(entity =>
            {
                entity.ToView("vw_Tobk6");
            });

            modelBuilder.Entity<VwTobkContainer>(entity =>
            {
                entity.ToView("vw_Tobk_Container");
            });

            modelBuilder.Entity<VwToct1>(entity =>
            {
                entity.ToView("vw_Toct1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwTodo1>(entity =>
            {
                entity.ToView("vw_Todo1");

                entity.Property(e => e.DateOfSigning).IsFixedLength();

                entity.Property(e => e.FlightDate).IsFixedLength();

                entity.Property(e => e.TimeOfSigning).IsFixedLength();
            });

            modelBuilder.Entity<VwTodo2>(entity =>
            {
                entity.ToView("vw_Todo2");
            });

            modelBuilder.Entity<VwTodo3>(entity =>
            {
                entity.ToView("vw_Todo3");
            });

            modelBuilder.Entity<VwTodr1>(entity =>
            {
                entity.ToView("vw_Todr1");

                entity.Property(e => e.AirportPassExpiryDate).IsFixedLength();

                entity.Property(e => e.DateOfBirth).IsFixedLength();

                entity.Property(e => e.HazmatDateTime).IsFixedLength();

                entity.Property(e => e.JurongPortExpiryDate).IsFixedLength();

                entity.Property(e => e.LicenceEffectiveDate).IsFixedLength();

                entity.Property(e => e.LicenceExpiryDate).IsFixedLength();

                entity.Property(e => e.PsaPassExpiryDate).IsFixedLength();

                entity.Property(e => e.PsocDateTime).IsFixedLength();

                entity.Property(e => e.WorkPermitExpiryDate).IsFixedLength();
            });

            modelBuilder.Entity<VwTodr2>(entity =>
            {
                entity.ToView("vw_Todr2");
            });

            modelBuilder.Entity<VwToet1>(entity =>
            {
                entity.ToView("vw_Toet1");
            });

            modelBuilder.Entity<VwToiv1>(entity =>
            {
                entity.ToView("vw_Toiv1");

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwToiv1Vat>(entity =>
            {
                entity.ToView("vw_Toiv1_Vat");
            });

            modelBuilder.Entity<VwToiv2>(entity =>
            {
                entity.ToView("vw_Toiv2");
            });

            modelBuilder.Entity<VwToiv2Vat>(entity =>
            {
                entity.ToView("vw_Toiv2_Vat");
            });

            modelBuilder.Entity<VwTopa1>(entity =>
            {
                entity.ToView("vw_Topa1");

                entity.Property(e => e.NextTransferDate).IsFixedLength();
            });

            modelBuilder.Entity<VwTopa2>(entity =>
            {
                entity.ToView("vw_Topa2");
            });

            modelBuilder.Entity<VwTopv1>(entity =>
            {
                entity.ToView("vw_Topv1");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.PostDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwTopv2>(entity =>
            {
                entity.ToView("vw_Topv2");
            });

            modelBuilder.Entity<VwTorc1>(entity =>
            {
                entity.ToView("vw_Torc1");

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwTorl1>(entity =>
            {
                entity.ToView("vw_Torl1");
            });

            modelBuilder.Entity<VwTosh1>(entity =>
            {
                entity.ToView("vw_Tosh1");

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.ScheduleDate).IsFixedLength();

                entity.Property(e => e.TruckDepartureDate).IsFixedLength();
            });

            modelBuilder.Entity<VwToso1>(entity =>
            {
                entity.ToView("vw_Toso1");

                entity.Property(e => e.EtaDate).IsFixedLength();

                entity.Property(e => e.EtdDate).IsFixedLength();

                entity.Property(e => e.TransferDate).IsFixedLength();
            });

            modelBuilder.Entity<VwToso2>(entity =>
            {
                entity.ToView("vw_Toso2");
            });

            modelBuilder.Entity<VwTost1>(entity =>
            {
                entity.ToView("vw_Tost1");
            });

            modelBuilder.Entity<VwTotc1>(entity =>
            {
                entity.ToView("vw_Totc1");
            });

            modelBuilder.Entity<VwTotc2>(entity =>
            {
                entity.ToView("vw_Totc2");

                entity.Property(e => e.Eta).IsFixedLength();
            });

            modelBuilder.Entity<VwTotd1>(entity =>
            {
                entity.ToView("vw_Totd1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwTotd2>(entity =>
            {
                entity.ToView("vw_Totd2");
            });

            modelBuilder.Entity<VwTotr1>(entity =>
            {
                entity.ToView("vw_Totr1");
            });

            modelBuilder.Entity<VwTovl1>(entity =>
            {
                entity.ToView("vw_Tovl1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwTovm1>(entity =>
            {
                entity.ToView("vw_Tovm1");

                entity.Property(e => e.EffectDate).IsFixedLength();

                entity.Property(e => e.ExpiryDate).IsFixedLength();

                entity.Property(e => e.InsuranceEffDate).IsFixedLength();

                entity.Property(e => e.InsuranceExpiry).IsFixedLength();

                entity.Property(e => e.LicenceExpiryDate).IsFixedLength();

                entity.Property(e => e.MonthToDateBilled01).IsFixedLength();

                entity.Property(e => e.MonthToDateBilled02).IsFixedLength();

                entity.Property(e => e.MonthToDateBilled03).IsFixedLength();

                entity.Property(e => e.MonthToDateBilled04).IsFixedLength();

                entity.Property(e => e.MonthToDateBilled05).IsFixedLength();

                entity.Property(e => e.MonthToDateBilled06).IsFixedLength();

                entity.Property(e => e.MonthToDateBilled07).IsFixedLength();

                entity.Property(e => e.MonthToDateBilled08).IsFixedLength();

                entity.Property(e => e.MonthToDateBilled09).IsFixedLength();

                entity.Property(e => e.MonthToDateBilled10).IsFixedLength();

                entity.Property(e => e.MonthToDateBilled11).IsFixedLength();

                entity.Property(e => e.MonthToDateBilled12).IsFixedLength();

                entity.Property(e => e.MonthToDateFuelCost01).IsFixedLength();

                entity.Property(e => e.MonthToDateFuelCost02).IsFixedLength();

                entity.Property(e => e.MonthToDateFuelCost03).IsFixedLength();

                entity.Property(e => e.MonthToDateFuelCost04).IsFixedLength();

                entity.Property(e => e.MonthToDateFuelCost05).IsFixedLength();

                entity.Property(e => e.MonthToDateFuelCost06).IsFixedLength();

                entity.Property(e => e.MonthToDateFuelCost07).IsFixedLength();

                entity.Property(e => e.MonthToDateFuelCost08).IsFixedLength();

                entity.Property(e => e.MonthToDateFuelCost09).IsFixedLength();

                entity.Property(e => e.MonthToDateFuelCost10).IsFixedLength();

                entity.Property(e => e.MonthToDateFuelCost11).IsFixedLength();

                entity.Property(e => e.MonthToDateFuelCost12).IsFixedLength();

                entity.Property(e => e.MonthToDateHrs01).IsFixedLength();

                entity.Property(e => e.MonthToDateHrs02).IsFixedLength();

                entity.Property(e => e.MonthToDateHrs03).IsFixedLength();

                entity.Property(e => e.MonthToDateHrs04).IsFixedLength();

                entity.Property(e => e.MonthToDateHrs05).IsFixedLength();

                entity.Property(e => e.MonthToDateHrs06).IsFixedLength();

                entity.Property(e => e.MonthToDateHrs07).IsFixedLength();

                entity.Property(e => e.MonthToDateHrs08).IsFixedLength();

                entity.Property(e => e.MonthToDateHrs09).IsFixedLength();

                entity.Property(e => e.MonthToDateHrs10).IsFixedLength();

                entity.Property(e => e.MonthToDateHrs11).IsFixedLength();

                entity.Property(e => e.MonthToDateHrs12).IsFixedLength();

                entity.Property(e => e.MonthToDateKm01).IsFixedLength();

                entity.Property(e => e.MonthToDateKm02).IsFixedLength();

                entity.Property(e => e.MonthToDateKm03).IsFixedLength();

                entity.Property(e => e.MonthToDateKm04).IsFixedLength();

                entity.Property(e => e.MonthToDateKm05).IsFixedLength();

                entity.Property(e => e.MonthToDateKm06).IsFixedLength();

                entity.Property(e => e.MonthToDateKm07).IsFixedLength();

                entity.Property(e => e.MonthToDateKm08).IsFixedLength();

                entity.Property(e => e.MonthToDateKm09).IsFixedLength();

                entity.Property(e => e.MonthToDateKm10).IsFixedLength();

                entity.Property(e => e.MonthToDateKm11).IsFixedLength();

                entity.Property(e => e.MonthToDateKm12).IsFixedLength();

                entity.Property(e => e.MonthToDateMaintenance01).IsFixedLength();

                entity.Property(e => e.MonthToDateMaintenance02).IsFixedLength();

                entity.Property(e => e.MonthToDateMaintenance03).IsFixedLength();

                entity.Property(e => e.MonthToDateMaintenance04).IsFixedLength();

                entity.Property(e => e.MonthToDateMaintenance05).IsFixedLength();

                entity.Property(e => e.MonthToDateMaintenance06).IsFixedLength();

                entity.Property(e => e.MonthToDateMaintenance07).IsFixedLength();

                entity.Property(e => e.MonthToDateMaintenance08).IsFixedLength();

                entity.Property(e => e.MonthToDateMaintenance09).IsFixedLength();

                entity.Property(e => e.MonthToDateMaintenance10).IsFixedLength();

                entity.Property(e => e.MonthToDateMaintenance11).IsFixedLength();

                entity.Property(e => e.MonthToDateMaintenance12).IsFixedLength();

                entity.Property(e => e.MonthToDateRepair01).IsFixedLength();

                entity.Property(e => e.MonthToDateRepair02).IsFixedLength();

                entity.Property(e => e.MonthToDateRepair03).IsFixedLength();

                entity.Property(e => e.MonthToDateRepair04).IsFixedLength();

                entity.Property(e => e.MonthToDateRepair05).IsFixedLength();

                entity.Property(e => e.MonthToDateRepair06).IsFixedLength();

                entity.Property(e => e.MonthToDateRepair07).IsFixedLength();

                entity.Property(e => e.MonthToDateRepair08).IsFixedLength();

                entity.Property(e => e.MonthToDateRepair09).IsFixedLength();

                entity.Property(e => e.MonthToDateRepair10).IsFixedLength();

                entity.Property(e => e.MonthToDateRepair11).IsFixedLength();

                entity.Property(e => e.MonthToDateRepair12).IsFixedLength();

                entity.Property(e => e.PurchaseDate).IsFixedLength();

                entity.Property(e => e.RegistrationEffectiveDate).IsFixedLength();

                entity.Property(e => e.RegistrationExpiryDate).IsFixedLength();

                entity.Property(e => e.RoadTaxEffDate).IsFixedLength();

                entity.Property(e => e.RoadTaxExpDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();

                entity.Property(e => e.YearToDateBilled).IsFixedLength();

                entity.Property(e => e.YearToDateFuel).IsFixedLength();

                entity.Property(e => e.YearToDateHrs).IsFixedLength();

                entity.Property(e => e.YearToDateKm).IsFixedLength();

                entity.Property(e => e.YearToDateMaintenance).IsFixedLength();

                entity.Property(e => e.YearToDateRepair).IsFixedLength();
            });

            modelBuilder.Entity<VwTovm2>(entity =>
            {
                entity.ToView("vw_Tovm2");

                entity.Property(e => e.Remark).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ServiceDate).IsFixedLength();

                entity.Property(e => e.ServiceEndDate).IsFixedLength();

                entity.Property(e => e.ServiceType).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VehicleNo).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwTovt1>(entity =>
            {
                entity.ToView("vw_Tovt1");
            });

            modelBuilder.Entity<VwTpts1>(entity =>
            {
                entity.ToView("vw_Tpts1");
            });

            modelBuilder.Entity<VwTranshipment>(entity =>
            {
                entity.ToView("vw_Transhipment");
            });

            modelBuilder.Entity<VwWhbt1>(entity =>
            {
                entity.ToView("vw_Whbt1");
            });

            modelBuilder.Entity<VwWhbt2>(entity =>
            {
                entity.ToView("vw_Whbt2");
            });

            modelBuilder.Entity<VwWhiv1>(entity =>
            {
                entity.ToView("vw_Whiv1");

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.PeriodFromDate).IsFixedLength();

                entity.Property(e => e.PeriodToDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();
            });

            modelBuilder.Entity<VwWhiv1Vat>(entity =>
            {
                entity.ToView("vw_Whiv1_Vat");
            });

            modelBuilder.Entity<VwWhiv2>(entity =>
            {
                entity.ToView("vw_Whiv2");
            });

            modelBuilder.Entity<VwWhiv2Vat>(entity =>
            {
                entity.ToView("vw_Whiv2_Vat");
            });

            modelBuilder.Entity<VwWhpa1>(entity =>
            {
                entity.ToView("vw_Whpa1");

                entity.Property(e => e.LastRunEodDate).IsFixedLength();

                entity.Property(e => e.RenewNoticeDate).IsFixedLength();
            });

            modelBuilder.Entity<VwWhpv1>(entity =>
            {
                entity.ToView("vw_Whpv1");

                entity.Property(e => e.ChequeDate).IsFixedLength();

                entity.Property(e => e.DiscountDate).IsFixedLength();

                entity.Property(e => e.DiscountDueDate).IsFixedLength();

                entity.Property(e => e.DueDate).IsFixedLength();

                entity.Property(e => e.InvoiceDate).IsFixedLength();

                entity.Property(e => e.NetOfDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwWhpv2>(entity =>
            {
                entity.ToView("vw_Whpv2");
            });

            modelBuilder.Entity<VwWhsf1>(entity =>
            {
                entity.ToView("vw_Whsf1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwWhst1>(entity =>
            {
                entity.ToView("vw_Whst1");
            });

            modelBuilder.Entity<VwWhwh1>(entity =>
            {
                entity.ToView("vw_Whwh1");
            });

            modelBuilder.Entity<VwWhwh2>(entity =>
            {
                entity.ToView("vw_Whwh2");
            });

            modelBuilder.Entity<VwWicepo1>(entity =>
            {
                entity.ToView("vw_Wicepo1");

                entity.Property(e => e.PurchaseOrderDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwWicepo2>(entity =>
            {
                entity.ToView("vw_Wicepo2");
            });

            modelBuilder.Entity<VwWmbc1>(entity =>
            {
                entity.ToView("vw_Wmbc1");
            });

            modelBuilder.Entity<VwWmbr1>(entity =>
            {
                entity.ToView("vw_Wmbr1");

                entity.Property(e => e.EffectiveDate).IsFixedLength();

                entity.Property(e => e.ExpiryDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwWmbr2>(entity =>
            {
                entity.ToView("vw_Wmbr2");
            });

            modelBuilder.Entity<VwWmbt1>(entity =>
            {
                entity.ToView("vw_Wmbt1");

                entity.Property(e => e.IssueDate).IsFixedLength();

                entity.Property(e => e.LastBillDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwWmbt1OpenBal>(entity =>
            {
                entity.ToView("vw_Wmbt1_OpenBal");
            });

            modelBuilder.Entity<VwWmbt2>(entity =>
            {
                entity.ToView("vw_Wmbt2");

                entity.Property(e => e.IssueDate).IsFixedLength();

                entity.Property(e => e.LastBillDate).IsFixedLength();

                entity.Property(e => e.ReceiptDate).IsFixedLength();

                entity.Property(e => e.TrxDate).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwWmct1>(entity =>
            {
                entity.ToView("vw_Wmct1");
            });

            modelBuilder.Entity<VwWmcy1>(entity =>
            {
                entity.ToView("vw_Wmcy1");
            });

            modelBuilder.Entity<VwWmvl1>(entity =>
            {
                entity.ToView("vw_Wmvl1");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwWrApplist>(entity =>
            {
                entity.ToView("vw_wrApplist");

                entity.Property(e => e.NodeType).IsFixedLength();
            });

            modelBuilder.Entity<VwWrApplist2>(entity =>
            {
                entity.ToView("vw_WrApplist2");
            });

            modelBuilder.Entity<VwWrGridFlag>(entity =>
            {
                entity.ToView("vw_wrGridFlag");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwWrLanguageList>(entity =>
            {
                entity.ToView("vw_wrLanguageList");
            });

            modelBuilder.Entity<VwWrMainControl>(entity =>
            {
                entity.ToView("vw_wrMainControl");
            });

            modelBuilder.Entity<VwWrMessage>(entity =>
            {
                entity.ToView("vw_wrMessage");

                entity.Property(e => e.ReadyRead).IsFixedLength();

                entity.Property(e => e.ReceiveDate).IsFixedLength();

                entity.Property(e => e.RecipientStatusCode).IsFixedLength();

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwWrMultiLanguage>(entity =>
            {
                entity.ToView("vw_wrMultiLanguage");
            });

            modelBuilder.Entity<VwWrNote>(entity =>
            {
                entity.ToView("vw_wrNote");

                entity.Property(e => e.NoteDate).IsFixedLength();
            });

            modelBuilder.Entity<VwWrPersonRole>(entity =>
            {
                entity.ToView("vw_wrPersonRole");
            });

            modelBuilder.Entity<VwWrRoleRight>(entity =>
            {
                entity.ToView("vw_wrRoleRight");
            });

            modelBuilder.Entity<VwWrSysTmplt>(entity =>
            {
                entity.ToView("vw_wrSysTmplt");

                entity.Property(e => e.TrxNo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwWrUseSysBasAndAdv>(entity =>
            {
                entity.ToView("vw_wrUseSysBasAndAdv");
            });

            modelBuilder.Entity<VwWrUser>(entity =>
            {
                entity.ToView("vw_wrUser");
            });

            modelBuilder.Entity<VwWrUserControl>(entity =>
            {
                entity.ToView("vw_wrUserControl");
            });

            modelBuilder.Entity<VwWrUsrShortCut>(entity =>
            {
                entity.ToView("vw_wrUsrShortCut");
            });

            modelBuilder.Entity<VwWrViewDefine>(entity =>
            {
                entity.ToView("vw_wrViewDefine");
            });

            modelBuilder.Entity<WebSubMenu>(entity =>
            {
                entity.HasKey(e => e.SequenceId)
                    .HasName("PK_CmsSubMenu");
            });

            modelBuilder.Entity<WebUser>(entity =>
            {
                entity.HasKey(e => e.SequenceId)
                    .HasName("PK_User_1");
            });

            modelBuilder.Entity<WhCheckCustBill>(entity =>
            {
                entity.ToView("wh_CheckCustBill");
            });

            modelBuilder.Entity<Whbt1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Whbt2>(entity =>
            {
                entity.HasKey(e => new { e.TableNo, e.LineItemNo });

                entity.HasOne(d => d.SalesItemCodeNavigation)
                    .WithMany(p => p.Whbt2s)
                    .HasForeignKey(d => d.SalesItemCode)
                    .HasConstraintName("FK_whbt2_acit1");

                entity.HasOne(d => d.TableNoNavigation)
                    .WithMany(p => p.Whbt2s)
                    .HasForeignKey(d => d.TableNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_whbt2_whbt1");
            });

            modelBuilder.Entity<Whiv1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PostFlag).HasDefaultValueSql("('N')");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Whiv2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Whiv2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_whiv2_whiv1");
            });

            modelBuilder.Entity<Whpa1>(entity =>
            {
                entity.Property(e => e.AccCode).HasComment("Update the Account Code for the Sales Item when transferring warehouse product invoice.");

                entity.Property(e => e.Address1).HasComment("NOT IN USE");

                entity.Property(e => e.Address2).HasComment("NOT IN USE");

                entity.Property(e => e.Address3).HasComment("NOT IN USE");

                entity.Property(e => e.Address4).HasComment("NOT IN USE");

                entity.Property(e => e.BillingType).HasComment("Control the button in Whiv1\r\nIf set as \"CUSTOMER\"\r\n- 1. Disable the button “Billing By Warrant” \r\n- 2. Hide the button “Delivery Order Items”\r\nIf set as “ORDER”\r\n- 1. Hide the label “ Period From Date” and “Period To Date” and “Your Ref No”\r\n- 2. the label “Batch No” change to “Sales Order No”\r\n- 3. Disable the button “Billing By Customer” and “Billing By Warrant”\r\n- 4. Hide the grid\r\nIf set as “WARRANT”\r\n- 1. Hide the button “Delivery Order”\r\n- 2. Disable the button “Billing By Customer”");

                entity.Property(e => e.ContactName).HasComment("NOT IN USE");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrCode).HasComment("NOT IN USE");

                entity.Property(e => e.DefaultStorageChargeCode).HasComment("Define the Storage Charge Code to Charge Item Code in Whiv when do Billing By Customer, if MinAmt > Total Amt. If leave blank, default “CLSTO”");

                entity.Property(e => e.DocumentFooter1).HasComment("Print to footer 1 of the documents");

                entity.Property(e => e.DocumentFooter2).HasComment("Print to footer 2 of the documents");

                entity.Property(e => e.Fax).HasComment("NOT IN USE");

                entity.Property(e => e.FeetSquare).HasComment("NOT IN USE");

                entity.Property(e => e.LastRunEodDate).HasComment("NOT IN USE");

                entity.Property(e => e.MeterSquare).HasComment("NOT IN USE");

                entity.Property(e => e.NextContractNo).HasComment("NOT IN USE");

                entity.Property(e => e.Position).HasComment("NOT IN USE");

                entity.Property(e => e.RenewNoticeDate).HasComment("NOT IN USE");

                entity.Property(e => e.ShowBillingDetailFlag).HasComment("Default the Show Billing Detail Flag to Billing by Customer / Billing By Warrant");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.TelePhone).HasComment("NOT IN USE");

                entity.Property(e => e.UomCode).HasComment("NOT IN USE");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WarehouseName).HasComment("NOT IN USE");

                entity.HasOne(d => d.UomCodeNavigation)
                    .WithMany(p => p.Whpa1s)
                    .HasForeignKey(d => d.UomCode)
                    .HasConstraintName("FK_whpa1_rcum1");
            });

            modelBuilder.Entity<Whpv1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_Whpv1");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(upper(host_name()))");
            });

            modelBuilder.Entity<Whpv2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo })
                    .HasName("PK_Whpv2");

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.Whpv2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Whpv2_Whpv1");
            });

            modelBuilder.Entity<Whsf1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .IsClustered(false);

                entity.HasIndex(e => new { e.WarehouseCode, e.StoreNo }, "IX_whsf1")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Whst1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Whwh1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.UomCodeNavigation)
                    .WithMany(p => p.Whwh1s)
                    .HasForeignKey(d => d.UomCode)
                    .HasConstraintName("FK_whwh1_rcum1");
            });

            modelBuilder.Entity<Whwh2>(entity =>
            {
                entity.HasKey(e => new { e.WarehouseCode, e.LineItemNo })
                    .HasName("pk_whwh2");
            });

            modelBuilder.Entity<WicePo1>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_WicePO");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<WicePo2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });

                entity.HasOne(d => d.TrxNoNavigation)
                    .WithMany(p => p.WicePo2s)
                    .HasForeignKey(d => d.TrxNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WicePO2_WicePO1");
            });

            modelBuilder.Entity<Wmbc1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Wmbr1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<Wmbr2>(entity =>
            {
                entity.HasKey(e => new { e.TrxNo, e.LineItemNo });
            });

            modelBuilder.Entity<Wmbt1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Wmbt2>(entity =>
            {
                entity.Property(e => e.AuditBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.AuditDatetime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Wmct1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Wmcy1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Wmvl1>(entity =>
            {
                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkStation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<WrAppList>(entity =>
            {
                entity.Property(e => e.NodeType).IsFixedLength();
            });

            modelBuilder.Entity<WrAppList2>(entity =>
            {
                entity.HasKey(e => new { e.NodeName, e.LineItemNo });
            });

            modelBuilder.Entity<WrAppointment>(entity =>
            {
                entity.Property(e => e.AppointmentId).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WrAppointments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_wrAppointments_saus1");
            });

            modelBuilder.Entity<WrAppointmentCategory>(entity =>
            {
                entity.Property(e => e.AppointmentCategoryId).ValueGeneratedNever();
            });

            modelBuilder.Entity<WrDisplayFormTitle>(entity =>
            {
                entity.HasKey(e => new { e.NodeName, e.DisplayCol });
            });

            modelBuilder.Entity<WrGridFlag>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_wrGridflag");

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.LineItemNo).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<WrJobFileShipmentStatus>(entity =>
            {
                entity.HasKey(e => e.JobNo)
                    .HasName("PK_WrJobFileShipmentStatus");
            });

            modelBuilder.Entity<WrMessage>(entity =>
            {
                entity.Property(e => e.ReadyRead)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.ReceiveDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecipientStatusCode)
                    .HasDefaultValueSql("('USE')")
                    .IsFixedLength();

                entity.Property(e => e.SenderStatusCode).HasDefaultValueSql("('USE')");
            });

            modelBuilder.Entity<WrMultiLanguage>(entity =>
            {
                entity.HasKey(e => new { e.FrmName, e.CtlName, e.CtlColumnNo });
            });

            modelBuilder.Entity<WrNote>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.NoteItemNo, e.NoteDate });
            });

            modelBuilder.Entity<WrPersonRole>(entity =>
            {
                entity.Property(e => e.RoleId).ValueGeneratedNever();

                entity.Property(e => e.CreateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusCode).HasDefaultValueSql("('USE')");

                entity.Property(e => e.UpdateBy).HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.UpdateDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<WrRoleRight>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.NodeName });
            });

            modelBuilder.Entity<WrSysTmplt>(entity =>
            {
                entity.HasKey(e => e.TrxNo)
                    .HasName("PK_wrSysTmplt_1");
            });

            modelBuilder.Entity<WrUseSysBasAndAdv>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.SearchName });
            });

            modelBuilder.Entity<WrUserControl>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.NetWordMacAddress, e.LineItemNo });

                entity.Property(e => e.LineItemNo).HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<WrUserNotify>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.DateTime });
            });

            modelBuilder.Entity<WrUsrShortCut>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.NodeName, e.TextType });
            });

            modelBuilder.Entity<WrViewDefine>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ViewName });
            });

            modelBuilder.Entity<VwUserMenu>(entity =>
            {
                entity.ToView("vw_UserMenu");

                entity.Property(e => e.NodeType).IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
