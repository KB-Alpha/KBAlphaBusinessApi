using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Models.StockModels.Yahoo_Models
{
    public class TickerDetails
    {
        public QuoteSummary quoteSummary { get; set; }
    }

    public class QuoteSummary
    {
        public IList<TickerDetailsResult> result { get; set; }
        public object error { get; set; }
    }

    public class TickerDetailsResult
    {
        public AssetProfile assetProfile { get; set; }
        public DefaultKeyStatistics defaultKeyStatistics { get; set; }
    }

    public class DefaultKeyStatistics
    {
        public int maxAge { get; set; }
        public PriceHint priceHint { get; set; }
        public EnterpriseValue enterpriseValue { get; set; }
        public ForwardPE forwardPE { get; set; }
        public ProfitMargins profitMargins { get; set; }
        public FloatShares floatShares { get; set; }
        public SharesOutstanding sharesOutstanding { get; set; }
        public SharesShort sharesShort { get; set; }
        public SharesShortPriorMonth sharesShortPriorMonth { get; set; }
        public SharesShortPreviousMonthDate sharesShortPreviousMonthDate { get; set; }

        public DateShortInterest dateShortInterest { get; set; }
        public SharesPercentSharesOut sharesPercentSharesOut { get; set; }
        public HeldPercentInsiders heldPercentInsiders { get; set; }
        public HeldPercentInstitutions heldPercentInstitutions { get; set; }
        public ShortRatio shortRatio { get; set; }
        public ShortPercentOfFloat shortPercentOfFloat { get; set; }
        public Beta beta { get; set; }
        public ImpliedSharesOutstanding impliedSharesOutstanding { get; set; }
        public MorningStarOverallRating morningStarOverallRating { get; set; }
        public MorningStarRiskRating morningStarRiskRating { get; set; }
        public object category { get; set; }
        public BookValue bookValue { get; set; }
        public PriceToBook priceToBook { get; set; }
        public AnnualReportExpenseRatio annualReportExpenseRatio { get; set; }
        public YtdReturn ytdReturn { get; set; }
        public Beta3Year beta3Year { get; set; }
        public TotalAssets totalAssets { get; set; }
        public Yield yield { get; set; }
        public object fundFamily { get; set; }

        public FundInceptionDate fundInceptionDate { get; set; }
        public object legalType { get; set; }
        public ThreeYearAverageReturn threeYearAverageReturn { get; set; }
        public FiveYearAverageReturn fiveYearAverageReturn { get; set; }
        public PriceToSalesTrailing12Months priceToSalesTrailing12Months { get; set; }
        public LastFiscalYearEnd lastFiscalYearEnd { get; set; }
        public NextFiscalYearEnd nextFiscalYearEnd { get; set; }
        public MostRecentQuarter mostRecentQuarter { get; set; }
        public EarningsQuarterlyGrowth earningsQuarterlyGrowth { get; set; }
        public RevenueQuarterlyGrowth revenueQuarterlyGrowth { get; set; }
        public NetIncomeToCommon netIncomeToCommon { get; set; }

        public TrailingEps trailingEps { get; set; }

        public ForwardEps forwardEps { get; set; }
        public PegRatio pegRatio { get; set; }
        public string lastSplitFactor { get; set; }
        public LastSplitDate lastSplitDate { get; set; }

        public EnterpriseToRevenue enterpriseToRevenue { get; set; }

        public EnterpriseToEbitda enterpriseToEbitda { get; set; }

        public FiftyTwoWeekChange fiftyTwoWeekWeekChange { get; set; }

        public SandP52WeekChange SandP52WeekChange { get; set; }

        public LastDividendValue lastDividendValue { get; set; }

        public LastDividendDate lastDividendDate { get; set; }

        public LastCapGain lastCapGain { get; set; }

        public AnnualHoldingsTurnover annualHoldingsTurnover { get; set; }

    }

    public class FiftyTwoWeekChange
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class SandP52WeekChange
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class LastDividendValue
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class LastDividendDate
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class LastCapGain
    {
    }

    public class AnnualHoldingsTurnover
    {
    }

    public class TrailingEps
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class ForwardEps
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class PegRatio
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class LastSplitDate
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class EnterpriseToRevenue
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class EnterpriseToEbitda
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class FundInceptionDate
    {
    }

    public class ThreeYearAverageReturn
    {
    }

    public class FiveYearAverageReturn
    {
    }

    public class PriceToSalesTrailing12Months
    {
    }

    public class LastFiscalYearEnd
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class NextFiscalYearEnd
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class MostRecentQuarter
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class EarningsQuarterlyGrowth
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class RevenueQuarterlyGrowth
    {
    }

    public class NetIncomeToCommon
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class MorningStarOverallRating
    {
    }

    public class MorningStarRiskRating
    {
    }

    public class BookValue
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class PriceToBook
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class AnnualReportExpenseRatio
    {

    }

    public class YtdReturn
    {
    }

    public class Beta3Year
    {
    }

    public class TotalAssets
    {
    }

    public class Yield
    {
    }

    public class ImpliedSharesOutstanding
    {
        public int raw { get; set; }
        public object fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class Beta
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class ShortPercentOfFloat
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class ShortRatio
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class HeldPercentInstitutions
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class HeldPercentInsiders
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class SharesPercentSharesOut
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class DateShortInterest
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class SharesShortPreviousMonthDate
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class SharesShortPriorMonth
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class SharesShort
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class SharesOutstanding
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class FloatShares
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class ProfitMargins
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class ForwardPE
    {
        public double raw { get; set; }
        public string fmt { get; set; }
    }

    public class EnterpriseValue
    {
        public long raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class PriceHint
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class AssetProfile
    {
        public string address1 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public string industry { get; set; }
        public string sector { get; set; }
        public string longBusinessSummary { get; set; }
        public int fullTimeEmployees { get; set; }
        public IList<CompanyOfficer> companyOfficers { get; set; }
        public int auditRisk { get; set; }
        public int boardRisk { get; set; }
        public int compensationRisk { get; set; }
        public int shareHolderRightsRisk { get; set; }
        public int overallRisk { get; set; }
        public int governanceEpochDate { get; set; }
        public int compensationAsOfEpochDate { get; set; }
        public int maxAge { get; set; }
    }

    public class CompanyOfficer
    {
        public int maxAge { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string title { get; set; }
        public int yearBorn { get; set; }
        public int fiscalYear { get; set; }
        public TotalPay totalPay { get; set; }
        public ExercisedValue exercisedValue { get; set; }
        public UnexercisedValue unexercisedValue { get; set; }
    }

    public class UnexercisedValue
    {
        public int raw { get; set; }
        public object fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class ExercisedValue
    {
        public int raw { get; set; }
        public object fmt { get; set; }
        public string longFmt { get; set; }
    }

    public class TotalPay
    {
        public int raw { get; set; }
        public string fmt { get; set; }
        public string longFmt { get; set; }
    }
}
