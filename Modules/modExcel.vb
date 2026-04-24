Module modExcel
#Region "Basic Rate Listing"
    Public Sub GenerateBasicRateListingXLSX(dt As DataTable, fileName As String, companyName As String, totalRecords As Integer)
        Try
            'Create additional parameters
            Dim additionalParams As New Dictionary(Of String, String)
            'additionalParams.Add("Total Records:", totalRecords.ToString() & " employee(s)")

            'Get current date
            'Dim currentDate As String = Format(Now, "MMMM dd, yyyy")
            Dim currentDate As String = DateTime.Now.ToString("MMMM dd, yyyy")
            additionalParams.Add("Date Generated:", currentDate)
            For Each col As DataColumn In dt.Columns
                If col.ColumnName = "deptcode" Then
                    col.ColumnName = "DEPTCODE"
                End If
                If col.ColumnName = "idno" Then
                    col.ColumnName = "ID#"
                End If
                If col.ColumnName = "name_" Then
                    col.ColumnName = "NAME"
                End If
                If col.ColumnName = "basic_rate" Then
                    col.ColumnName = "BASIC RATE"
                End If
                If col.ColumnName = "paymode" Then
                    col.ColumnName = "PAYMODE"
                End If
            Next

            ' Call the generic function
            GenerateExcelReport(dt, fileName, "BASIC RATE LISTING",
                              companyName,
                              ActiveCompanyAddress,
                              ActiveCompanyContact,
                              additionalParams,
                              totalRecords & " record(s) found.", "1")

        Catch ex As Exception
            MessageBox.Show($"Error generating Basic Rate Listing: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Certificate Listing"
    Public Sub GenerateCertificateListingXLSX(dt As DataTable, fileName As String, companyName As String, totalCertificates As Integer)
        Try
            ' Create additional parameters
            Dim additionalParams As New Dictionary(Of String, String)
            'additionalParams.Add("Total Certificates:", totalCertificates.ToString())

            ' Get current date
            Dim currentDate As String = DateTime.Now.ToString("MMMM dd, yyyy")
            additionalParams.Add("Date Generated:", currentDate)
            For Each col As DataColumn In dt.Columns
                If col.ColumnName = "deptcode" Then
                    col.ColumnName = "DEPTCODE"
                End If
                If col.ColumnName = "idno" Then
                    col.ColumnName = "ID#"
                End If
                If col.ColumnName = "name_" Then
                    col.ColumnName = "NAME"
                End If
                If col.ColumnName = "divcode" Then
                    col.ColumnName = "DIVCODE"
                End If
                If col.ColumnName = "certification" Then
                    col.ColumnName = "CERTIFICATION"
                End If
                If col.ColumnName = "yearcert" Then
                    col.ColumnName = "YEAR"
                End If
                If col.ColumnName = "rate" Then
                    col.ColumnName = "RATE"
                End If
            Next

            ' Call the generic function
            GenerateExcelReport(dt, fileName, "CERTIFICATION LISTING",
                              companyName,
                              ActiveCompanyAddress,
                              ActiveCompanyContact,
                              additionalParams,
                              totalCertificates & " records(s) found.")

        Catch ex As Exception
            MessageBox.Show($"Error generating Certificate Listing: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Emergency Contacts"
    Public Sub GenerateEmergencyContactXLSX(dt As DataTable, fileName As String, companyName As String)
        Try
            ' Create additional parameters
            Dim additionalParams As New Dictionary(Of String, String)

            ' Get current date
            Dim currentDate As String = DateTime.Now.ToString("MMMM dd, yyyy")
            additionalParams.Add("Date Generated:", currentDate)

            Dim totalRecords As Integer = dt.Rows.Count

            For Each col As DataColumn In dt.Columns
                If col.ColumnName = "mobile" Then
                    col.ColumnName = "MOBILE"
                End If
                If col.ColumnName = "idno" Then
                    col.ColumnName = "ID#"
                End If
                If col.ColumnName = "fullname" Then
                    col.ColumnName = "NAME"
                End If
                If col.ColumnName = "contact_name" Then
                    col.ColumnName = "CONTACT NAME"
                End If
                If col.ColumnName = "relation" Then
                    col.ColumnName = "RELATION"
                End If
                If col.ColumnName = "address" Then
                    col.ColumnName = "ADDRESS"
                End If
                If col.ColumnName = "landline" Then
                    col.ColumnName = "LANDLINE"
                End If
                If col.ColumnName = "email" Then
                    col.ColumnName = "EMAIL"
                End If
            Next

            ' Call the generic function
            GenerateExcelReport(dt, fileName, "EMPLOYEE EMERGENCY CONTACTS",
                              companyName,
                              ActiveCompanyAddress,
                              ActiveCompanyContact,
                              additionalParams,
                              totalRecords & " record(s) found.")

        Catch ex As Exception
            MessageBox.Show($"Error generating Emergency Contact Report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Job Status Listing"
    Public Sub GenerateJobStatusListingXLSX(dt As DataTable, fileName As String, companyName As String, totalRecords As Integer)
        Try
            ' Create additional parameters
            Dim additionalParams As New Dictionary(Of String, String)
            'additionalParams.Add("Total Records:", totalRecords.ToString() & " employee(s)")

            ' Get current date
            'Dim currentDate As String = Format(Now, "MMMM dd, yyyy")
            Dim currentDate As String = DateTime.Now.ToString("MMMM dd, yyyy")
            additionalParams.Add("Date Generated:", currentDate)
            For Each col As DataColumn In dt.Columns
                If col.ColumnName = "deptname" Then
                    col.ColumnName = "DEPTCODE"
                End If
                If col.ColumnName = "idno" Then
                    col.ColumnName = "ID#"
                End If
                If col.ColumnName = "fullname" Then
                    col.ColumnName = "NAME"
                End If
                If col.ColumnName = "divname" Then
                    col.ColumnName = "DIVCODE"
                End If
                If col.ColumnName = "jstatusname" Then
                    col.ColumnName = "JOB STATUS"
                End If
                If col.ColumnName = "formatdate" Then
                    col.ColumnName = "STATUS DATE"
                End If
            Next

            ' Call the generic function
            GenerateExcelReport(dt, fileName, "JOB STATUS LISTING",
                              companyName,
                              ActiveCompanyAddress,
                              ActiveCompanyContact,
                              additionalParams,
                              totalRecords & " record(s) found.", "1")

        Catch ex As Exception
            MessageBox.Show($"Error generating Basic Rate Listing: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
End Module
