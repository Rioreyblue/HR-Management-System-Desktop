Imports Newtonsoft.Json

Public Class PayrollCutoff
    <JsonProperty("cutoff")>
    Public Property Cutoff As String

    <JsonProperty("datestart")>
    Public Property DateStart As DateTime?

    <JsonProperty("dateend")>
    Public Property DateEnd As DateTime?

    <JsonProperty("hide")>
    Public Property Hide As Boolean = False

    <JsonProperty("taxwithheld")>
    Public Property TaxWithheld As String

    <JsonProperty("tax_based")>
    Public Property TaxBased As String

    <JsonProperty("phealth_prem")>
    Public Property PHealthPrem As Boolean = False

    <JsonProperty("phealth_based")>
    Public Property PHealthBased As String

    <JsonProperty("sss_prem")>
    Public Property SSSPrem As Boolean = False

    <JsonProperty("sss_based")>
    Public Property SSSBased As String

    <JsonProperty("hdmf_prem")>
    Public Property HDMFPrem As Boolean = False

    <JsonProperty("hdmf_based")>
    Public Property HDMFBased As String

    <JsonProperty("gsis_prem")>
    Public Property GSISPrem As Boolean = False

    <JsonProperty("gsis_based")>
    Public Property GSISBased As String

    <JsonProperty("medicare_prem")>
    Public Property MedicarePrem As Boolean = False

    <JsonProperty("medicare_based")>
    Public Property MedicareBased As String

    <JsonProperty("loan_sss_sal")>
    Public Property LoanSSSSal As Boolean = False

    <JsonProperty("loan_sss_cal")>
    Public Property LoanSSSCal As Boolean = False

    <JsonProperty("loan_sss_emr")>
    Public Property LoanSSSEmr As Boolean = False

    <JsonProperty("loan_hdmf_sal")>
    Public Property LoanHDMFSal As Boolean = False

    <JsonProperty("loan_hdmf_cal")>
    Public Property LoanHDMFCal As Boolean = False

    <JsonProperty("loan_hdmf_hou")>
    Public Property LoanHDMFHou As Boolean = False

    <JsonProperty("loan_gsis_sal")>
    Public Property LoanGSISSal As Boolean = False

    <JsonProperty("loan_gsis_emr")>
    Public Property LoanGSISEmr As Boolean = False

    <JsonProperty("loan_company_1")>
    Public Property LoanCompany1 As Boolean = False

    <JsonProperty("loan_company_2")>
    Public Property LoanCompany2 As Boolean = False

    <JsonProperty("loan_company_3")>
    Public Property LoanCompany3 As Boolean = False

    <JsonProperty("loan_company_4")>
    Public Property LoanCompany4 As Boolean = False

    <JsonProperty("loan_company_5")>
    Public Property LoanCompany5 As Boolean = False

    <JsonProperty("loan_company_6")>
    Public Property LoanCompany6 As Boolean = False

    <JsonProperty("loan_multiple")>
    Public Property LoanMultiple As Boolean = False

    <JsonProperty("sharedben")>
    Public Property SharedBen As Boolean = False

    <JsonProperty("b_5days")>
    Public Property B5Days As Boolean = False

    <JsonProperty("b_13thmonth")>
    Public Property B13thMonth As Boolean = False

    <JsonProperty("trail")>
    Public Property Trail As String

    <JsonProperty("loan_gsis_pol")>
    Public Property LoanGSISPol As Boolean = False

    <JsonProperty("loan_gsis_hou")>
    Public Property LoanGSISHou As Boolean = False

    <JsonProperty("b_13thmonth_based")>
    Public Property B13thMonthBased As String

    <JsonProperty("net_dec_savings")>
    Public Property NetDecSavings As Boolean = False

    <JsonProperty("payroll_date")>
    Public Property PayrollDate As DateTime = #1/1/1901#

    <JsonProperty("active")>
    Public Property Active As Boolean = False

    <JsonProperty("company_")>
    Public Property CompanyID As Long?

    <JsonProperty("othearn")>
    Public Property OtHeard As Boolean = False

    <JsonProperty("othded")>
    Public Property OthDed As Boolean = False

    <JsonProperty("payroll_type")>
    Public Property PayrollType As Decimal = 1

    <JsonProperty("loan_gsis_ecp")>
    Public Property LoanGSISEcp As Boolean = False

    <JsonProperty("loan_gsis_eal")>
    Public Property LoanGSISEal As Boolean = False

    <JsonProperty("half_pay")>
    Public Property HalfPay As Boolean = False

    <JsonProperty("oid")>
    Public Property OID As Long?

End Class
