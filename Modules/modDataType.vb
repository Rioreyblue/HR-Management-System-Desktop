Public Module modDataType
    'Pres 06/22/2024
    'Payroll

    Public Class EmpProfile
        Public Property gsis_id As String = String.Empty
        Public Property sss_id As String = String.Empty
        Public Property phic_id As String = String.Empty
        Public Property hdmf_id As String = String.Empty

    End Class
    Public Class OT_Config

        Public Property otcode As Integer = 0
        Public Property joblevel_ As String = String.Empty
        Public Property divcode As String = String.Empty
        Public Property DREG As Double = 0 'DAILY REG OT FIRST 8 HRS
        Public Property DREGOT As Double = 0 'DAILY REG OT EXCESS 8 HRS
        Public Property DNP As Double = 0 'DAILY NP
        Public Property DNPOT As Double = 0 'MONTHLY NPOT
        Public Property MREG As Double = 0 'MONTHLY REG OT FIRST 8 HRS
        Public Property MREGOT As Double = 0 'MONTHLY REG OT EXCESS 8 HRS
        Public Property MNP As Double = 0 'MONTHLYY NP
        Public Property MNPOT As Double = 0 'MONTHLY NPOT

    End Class

    Public Class cmpPayroll
        Public Property idno As String = String.Empty
        Public Property cutoff As String = String.Empty
        Public Property costcode As String = String.Empty
        Public Property divcode As String = String.Empty
        Public Property deptcode As String = String.Empty
        Public Property reghrs As Double = 0
        Public Property reghrsot As Double = 0
        Public Property regnp As Double = 0
        Public Property regnpot As Double = 0
        Public Property rsthrs As Double = 0
        Public Property rstot As Double = 0
        Public Property rstnp As Double = 0
        Public Property rstnpot As Double = 0
        Public Property splhrs As Double = 0
        Public Property splhrsot As Double = 0
        Public Property splnp As Double = 0
        Public Property splnpot As Double = 0
        Public Property cmphrs As Double = 0
        Public Property cmphrsot As Double = 0
        Public Property cmpnp As Double = 0
        Public Property cmpnpot As Double = 0
        Public Property lghrs As Double = 0
        Public Property lghrsot As Double = 0
        Public Property lgnp As Double = 0
        Public Property lgnpot As Double = 0
        Public Property rstsplhrs As Double = 0
        Public Property rstsplhrsot As Double = 0
        Public Property rstsplnp As Double = 0
        Public Property rstsplnpot As Double = 0
        Public Property rstlghrs As Double = 0
        Public Property rstlghrsot As Double = 0
        Public Property rstlgnp As Double = 0
        Public Property rstlgnpot As Double = 0
        Public Property rstcmphrs As Double = 0
        Public Property rstcmphrsot As Double = 0
        Public Property rstcmpnp As Double = 0
        Public Property rstcmpnpot As Double = 0
        Public Property acchrs As Double = 0
        Public Property late As Double = 0
        Public Property undertime As Double = 0
        Public Property absent_hrs As Double = 0
        Public Property legal_pay As Double = 0
        Public Property leavewopay As Double = 0
        Public Property leavewpay As Double = 0
        Public Property formulated_shift As Double = 0
        Public Property sl_wpay As Double = 0
        Public Property vl_wpay As Double = 0
        Public Property el_wpay As Double = 0
        Public Property pl_wpay As Double = 0
        Public Property ml_wpay As Double = 0
        Public Property ul_wpay As Double = 0
        Public Property ol_wpay As Double = 0
        Public Property xl_wpay As Double = 0
        Public Property al_wpay As Double = 0
        Public Property ashf_calculated_ot As Double = 0
        Public Property adv_calculated_ot As Double = 0
        Public Property payMode As String
        Public Property monthly_rate As Double = 0
        Public Property rate As Double = 0
        Public Property basic_pay As Double = 0 'basic rate for payroll
        Public Property actual_basic_pay As Double = 0 'rate minus absent hours
        Public Property gross_taxable As Double = 0 'gross taxable income
        Public Property gross_all As Double = 0 'gross with all income
        Public Property sss_yee As Double = 0
        Public Property sss_yer As Double = 0
        Public Property sss_ec As Double = 0
        Public Property sss_loan_salary As Double = 0
        Public Property sss_loan_calamity As Double = 0
        Public Property sss_loan_emergency As Double = 0
        Public Property hdmf_yee As Double = 0
        Public Property hdmf_yer As Double = 0
        Public Property hdmf_custom As Double = 0
        Public Property hdmf_loan_salary As Double = 0
        Public Property hdmf_loan_housing As Double = 0
        Public Property hdmf_loan_calamity As Double = 0
        Public Property company_loan_1 As Double = 0
        Public Property company_loan_2 As Double = 0
        Public Property company_loan_3 As Double = 0
        Public Property company_loan_4 As Double = 0
        Public Property company_loan_5 As Double = 0
        Public Property company_loan_6 As Double = 0
        Public Property phealth_yee As Double = 0
        Public Property phealth_yer As Double = 0
        Public Property gsis_yee As Double = 0
        Public Property gsis_yer As Double = 0
        Public Property medicare_yee As Double = 0
        Public Property medicare_yer As Double = 0
        Public Property multi_loan_1 As Double = 0
        Public Property multi_loan_2 As Double = 0
        Public Property multi_loan_3 As Double = 0
        Public Property multi_loan_4 As Double = 0
        Public Property multi_loan_5 As Double = 0
        Public Property multi_loan_6 As Double = 0
        Public Property multi_loan_7 As Double = 0
        Public Property multi_loan_8 As Double = 0
        Public Property multi_loan_9 As Double = 0
        Public Property multi_loan_10 As Double = 0
        Public Property multi_loan_11 As Double = 0
        Public Property multi_loan_12 As Double = 0
        Public Property multi_loan_13 As Double = 0
        Public Property multi_loan_14 As Double = 0
        Public Property multi_loan_15 As Double = 0
        Public Property my13th_month_taxable As Double = 0
        Public Property my13th_month_ntaxable As Double = 0
        Public Property my5th_days As Double = 0
        Public Property total_taxable_fixed_earnings_formulated As Double = 0
        Public Property total_ntaxable_fixed_earnings_formulated As Double = 0
        Public Property total_taxable_other_earnings_formulated As Double = 0
        Public Property total_ntaxable_other_earnings_formulated As Double = 0
        Public Property total_taxable_oth_earnings As Double = 0
        Public Property total_ntaxable_oth_earnings As Double = 0
        Public Property total_taxable_fixed_earnings As Double = 0
        Public Property total_ntaxable_fixed_earnings As Double = 0
        Public Property total_taxable_oth_deductions As Double = 0
        Public Property total_ntaxable_oth_deductions As Double = 0
        Public Property total_taxable_fixed_deductions As Double = 0
        Public Property total_ntaxable_fixed_deductions As Double = 0
        Public Property total_taxable_longevity_earnings As Double = 0
        Public Property netpay As Double = 0
        Public Property separation_pay As Double = 0
        Public Property shared_benefits_yee As Double = 0
        Public Property shared_benefits_yer As Double = 0
        Public Property taxcode As String
        Public Property mygov_tax As Double = 0
        Public Property process_year As String
        Public Property cashpaid As Boolean
        Public Property bank_code As String
        Public Property account_no As String
        Public Property job_status As String
        Public Property posted As Boolean
        Public Property trail As String
        Public Property xl_leave As Boolean
        Public Property minumum_earner As Boolean
        Public Property mintakehome As Double = 0
        Public Property electronic_log As Boolean
        Public Property union_member As Boolean
        Public Property gsis_loan_salary As Double = 0
        Public Property gsis_loan_housing As Double = 0
        Public Property gsis_loan_emergency As Double = 0
        Public Property gsis_loan_policy As Double = 0
        Public Property PERHOUR As Double = 0
        Public Property sss_ded As Boolean
        Public Property sss_ded_amt As Double = 0
        Public Property sss_ded_yer_amt As Double = 0
        Public Property sss_ded_ecc_amt As Double = 0
        Public Property phealth_ded As Boolean
        Public Property phealth_ded_amt As Double = 0
        Public Property phealth_ded_yer_amt As Double = 0
        Public Property hdmf_ded As Boolean
        Public Property hdmf_ded_amt As Double = 0
        Public Property hdmf_ded_yer_amt As Double = 0
        Public Property Taxwitheld As Boolean
        Public Property Taxwitheld_Amt As Double = 0 'tax shield %
        Public Property medicare_ded As Boolean
        Public Property medicare_ded_amt As Double = 0
        Public Property medicare_ded_yer_amt As Double = 0
        Public Property gsis_ded As Boolean
        Public Property gsis_ded_amt As Double = 0
        Public Property gsis_ded_yer_amt As Double = 0
        Public Property gsis_based As Double = 0
        Public Property sss_based As Double = 0
        Public Property phealth_based As Double = 0
        Public Property hdmf_based As Double = 0
        Public Property tax_based As Double = 0
        Public Property ashf_reghrsot As Double = 0
        Public Property adv_reghrsot As Double = 0
        Public Property ashf_splhrsot As Double = 0
        Public Property adv_splhrsot As Double = 0
        Public Property ashf_cmphrsot As Double = 0
        Public Property adv_cmphrsot As Double = 0
        Public Property ashf_lghrsot As Double = 0
        Public Property adv_lghrsot As Double = 0
        Public Property ashf_rsthrsot As Double = 0
        Public Property adv_rsthrsot As Double = 0
        Public Property ashf_rstsplhrsot As Double = 0
        Public Property adv_rstsplhrsot As Double = 0
        Public Property ashf_rstcmphrsot As Double = 0
        Public Property adv_rstcmphrsot As Double = 0
        Public Property ashf_rstlghrsot As Double = 0
        Public Property adv_rstlghrsot As Double = 0
        Public Property tax_shield As Double = 0
        Public Property gsis_ecc As Double = 0
        Public Property gsis_ehp As Double = 0
        Public Property taxable_13_mon As Double = 0
        Public Property taxanle_othearn As Double = 0
        Public Property bank_code1 As String
        Public Property bank_code2 As String
        Public Property account_no1 As String
        Public Property account_no2 As String
        Public Property bank_percentage As Boolean
        Public Property bank_percentage1 As Boolean
        Public Property bank_percentage2 As Boolean
        Public Property bank_net_amount As Double = 0
        Public Property bank_net_amount1 As Double = 0
        Public Property bank_net_amount2 As Double = 0
        Public Property bank_net_primary As Boolean
        Public Property bank_net_primary1 As Boolean
        Public Property bank_net_primary2 As Boolean
        Public Property sss_amt As Double = 0
        Public Property hdmf_amt As Double = 0
        Public Property phealth_amt As Double = 0
        Public Property tax_amt As Double = 0
        Public Property ecc_amt As Double = 0
        Public Property t13th_amt As Double = 0
        Public Property t5days_amt As Double = 0
        Public Property disregard_tax_config As Boolean
        Public Property special_taxation As Boolean
        Public Property special_tax_percentage As Double = 0
        Public Property ot_amt As Double = 0
        Public Property ProjectedTax As Boolean
        Public Property ntaxable_excess As Double = 0
        Public Property netpay_1 As Double = 0
        Public Property netpay_2 As Double = 0
        Public Property otdays As Double = 0
        Public Property numbdays As Double = 0
        Public Property monthly_late As Double = 0
        Public Property ovr_rate As Boolean
        Public Property ovr_rate_amt As Double = 0
        Public Property ovr_perhour As Double = 0
        Public Property allowances As Double = 0
        Public Property lglsplhrs As Double = 0
        Public Property lglsplhrsot As Double = 0
        Public Property lglsplnp As Double = 0
        Public Property lglsplnpot As Double = 0
        Public Property rstlglsplhrs As Double = 0
        Public Property rstlglsplhrsot As Double = 0
        Public Property rstlglsplnp As Double = 0
        Public Property rstlglsplnpot As Double = 0
        Public Property ashf_lglsplhrsot As Double = 0
        Public Property adv_lglsplhrsot As Double = 0
        Public Property ashf_rstlglsplhrsot As Double = 0
        Public Property adv_rstlglsplhrsot As Double = 0
        Public Property lgl_holiday As Double = 0
        Public Property dblhrs As Double = 0
        Public Property dblhrsot As Double = 0
        Public Property dblnp As Double = 0
        Public Property dblnpot As Double = 0
        Public Property rstdblhrs As Double = 0
        Public Property rstdblhrsot As Double = 0
        Public Property rstdblnp As Double = 0
        Public Property rstdblnpot As Double = 0
        Public Property ashf_dblhrsot As Double = 0
        Public Property adv_dblhrsot As Double = 0
        Public Property ashf_rstdblhrsot As Double = 0
        Public Property adv_rstdblhrsot As Double = 0

        'Pres
        Public Property interim_payroll As String = String.Empty

    End Class

    Public Class Cutoff_Config

        ' Basic cutoff and tax info
        Public Property cutoff As String
        Public Property taxwithheld As String
        Public Property taxmode As String
        Public Property tax_based As String

        ' Premiums and bases
        Public Property phealth_prem As Boolean
        Public Property phealth_based As String
        Public Property sss_prem As Boolean
        Public Property sss_based As String
        Public Property hdmf_prem As Boolean
        Public Property hdmf_based As String
        Public Property gsis_prem As Boolean
        Public Property gsis_based As String
        Public Property medicare_prem As Boolean
        Public Property medicare_based As String

        ' Loans
        Public Property loan_sss_sal As Boolean
        Public Property loan_sss_cal As Boolean
        Public Property loan_sss_emr As Boolean
        Public Property loan_hdmf_sal As Boolean
        Public Property loan_hdmf_cal As Boolean
        Public Property loan_hdmf_hou As Boolean
        Public Property loan_gsis_sal As Boolean
        Public Property loan_gsis_hou As Boolean
        Public Property loan_gsis_emr As Boolean
        Public Property loan_gsis_pol As Boolean
        Public Property loan_company_1 As Boolean
        Public Property loan_company_2 As Boolean
        Public Property loan_company_3 As Boolean
        Public Property loan_company_4 As Boolean
        Public Property loan_company_5 As Boolean
        Public Property loan_company_6 As Boolean
        Public Property loan_multiple As Boolean

        ' Benefits and deductions
        Public Property sharedben As Boolean
        Public Property b_5days As Boolean
        Public Property b_13thmonth As Boolean
        Public Property b_13thmonth_based As String
        Public Property net_dec_savings As Boolean
        Public Property othEarn As Boolean
        Public Property othDed As Boolean

        ' Payroll info
        Public Property payroll_type As String
        Public Property half_pay As Boolean
        Public Property payroll_date As Date
        Public Property mp2_savings As Boolean


    End Class

    Public Class ProjectedTax
        Public Property idno As String
        Public Property deminimis As String
        Public Property ntaxable As String
        Public Property taxable As String
        Public Property gross_all As Decimal
        Public Property gross_taxable As Decimal
        Public Property monthly_rate As Decimal
        Public Property tax_exemption As Decimal
        Public Property taxcode As String
        Public Property company As Integer
        Public Property divcode As String
        Public Property deptcode As String

        Public Property sss_based_on As String
        Public Property sss_prem As Boolean
        Public Property sss_based_amt As Decimal
        Public Property sss_yee As Decimal
        Public Property sss_yer As Decimal
        Public Property sss_ec As Decimal
        Public Property sss_ded_amt As Decimal
        Public Property sss_ded_yer_amt As Decimal
        Public Property sss_ded_ecc_amt As Decimal

        Public Property hdmf_based_on As String
        Public Property hdmf_prem As Boolean
        Public Property hdmf_based_amt As Decimal
        Public Property hdmf_yee As Decimal
        Public Property hdmf_yer As Decimal
        Public Property hdmf_ded_amt As Decimal
        Public Property hdmf_ded_yer_amt As Decimal
        Public Property hdmf_custom As Decimal

        Public Property phealth_based_on As String
        Public Property phealth_prem As Boolean
        Public Property phealth_based_amt As Decimal
        Public Property phealth_yee As Decimal
        Public Property phealth_yer As Decimal
        Public Property phealth_ded_amt As Decimal
        Public Property phealth_ded_yer_amt As Decimal

        Public Property gsis_based_on As String
        Public Property gsis_prem As Boolean
        Public Property gsis_based_amt As Decimal
        Public Property gsis_yee As Decimal
        Public Property gsis_yer As Decimal
        Public Property gsis_ded_amt As Decimal
        Public Property gsis_ded_yer_amt As Decimal
        Public Property gsis_ecc As Decimal
        Public Property gsis_ehp As Decimal

        Public Property tax_based_on As Decimal
        Public Property tax_based_amt As Decimal
        Public Property Taxwitheld_Amt As Decimal
        Public Property taxamt As Decimal
        Public Property mygov_tax As Decimal

        Public Property deminimis_excess As Decimal
        Public Property ntaxable_excess As Decimal
        Public Property taxable_13_mon As Decimal
        Public Property taxable_othearn As Decimal

        Public Property gsis_prem_ovr As Boolean
        Public Property sss_prem_ovr As Boolean
        Public Property hdmf_prem_ovr As Boolean
        Public Property phealth_prem_ovr As Boolean
        Public Property term As Integer
        Public Property override_status As Boolean

    End Class





End Module
