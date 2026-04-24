Public Class classEmployee

    'used for traditional listview
    Public Shared Sub TriggerItemChecked(ByVal pListView As NxnControls.NxNListview, ByVal pListView_ As ListView)
        paramDiv = String.Empty
        For Each item As ListViewItem In pListView.Items
            If Not IsNothing(item) Then
                If item.Checked = True Then
                    If String.IsNullOrEmpty(paramDiv) Then
                        paramDiv = "'" & Trim(item.SubItems(0).Text) & "'"
                    Else
                        paramDiv = paramDiv & "," & "'" & Trim(item.SubItems(0).Text) & "'"
                    End If
                Else
                    pListView_.Items.Clear()
                End If
            End If
        Next
        If paramDiv <> "" Then
            Call LoadDivisionEmployee(getDivisionEmployee.Copy, pListView_)
        End If
    End Sub

    'Used only for Custom NxnListview
    Public Shared Sub TriggerItemChecked_(ByVal pListView As NxnControls.NxNListview, ByVal pListView_ As NxnControls.NxNListview, ByVal pJobStatus As String)
        paramDiv = String.Empty
        paramJobStatus = String.Empty
        For Each item As ListViewItem In pListView.Items
            If Not IsNothing(item) Then
                If item.Checked = True Then
                    If String.IsNullOrEmpty(paramDiv) Then
                        paramDiv = "'" & Trim(item.SubItems(0).Text) & "'"
                    Else
                        paramDiv = paramDiv & "," & "'" & Trim(item.SubItems(0).Text) & "'"
                    End If
                Else
                    pListView_.Items.Clear()
                End If
            End If
        Next
        If paramDiv <> "" Then
            paramJobStatus = pJobStatus
            Call LoadDivisionEmployee_(getDivisionEmployee, pListView_)
        End If
    End Sub

    Public Shared Sub TriggerItemCheckedReport(ByVal pListView As NxnControls.NxNListview, ByVal pListView_ As NxnControls.NxNListview, ByVal pJobStatus As String, ByVal reportType As String)
        paramDiv = String.Empty
        Dim division_ As New List(Of String)
        For Each item As ListViewItem In pListView.Items
            If item.Checked = True Then
                division_.Add(Trim(item.SubItems(0).Text))
            End If
        Next

        If division_.Count > 0 Then
            Select Case reportType
                Case "CL01" 'Certificate Listing
                    Call LoadDivisionEmployee_(getEmployeeWithCertifications(division_.ToArray, pJobStatus), pListView_)
                Case "EC01" 'Emergency Contact
                    Call LoadDivisionEmployee_(getEmployeeWithEmergencyContacts(division_.ToArray, pJobStatus), pListView_)
                Case "JS01" 'Job Status Listing
                    Call LoadDivisionEmployee_(getEmployeeWithJobStatus(division_.ToArray, pJobStatus), pListView_)
            End Select
        Else
            pListView_.Items.Clear()
        End If
    End Sub


    'For populate traditional listview
    Public Shared Sub LoadDivisionEmployee(ByVal pDTable As DataTable, ByVal pListView As ListView)
        Dim _dr As DataRow
        Dim counter As Integer = 0
        With pListView
            .Items.Clear()
            For Each _dr In pDTable.Rows
                Dim lv_ As ListViewItem = New ListViewItem(_dr("idno").ToString)
                lv_.SubItems.Add(StrConv(_dr("fullname").ToString, vbProperCase))
                lv_.SubItems.Add(_dr("divcode").ToString.ToUpper)
                If isEven(counter) Then lv_.BackColor = Color.White Else lv_.BackColor = Color.WhiteSmoke
                counter += 1
                .Items.Add(lv_)
            Next
        End With
    End Sub
    'For populate custom listview
    Public Shared Sub LoadDivisionEmployee_(ByVal pDTable As DataTable, ByVal pListView As NxnControls.NxNListview)
        Dim _dr As DataRow
        With pListView
            .Items.Clear()
            For Each _dr In pDTable.Rows
                Dim lv_ As ListViewItem = New ListViewItem(_dr("idno").ToString)
                lv_.SubItems.Add(StrConv(_dr("lname").ToString & ", " & _dr("fname").ToString & " " & _dr("mname").ToString, vbProperCase))
                lv_.SubItems.Add(_dr("divcode").ToString.ToUpper)
                lv_.SubItems.Add(_dr("deptcode").ToString.ToUpper)
                .Items.Add(lv_)
            Next
        End With
    End Sub
    Public Shared Sub LoadDivision(ByVal pDTable As DataTable, ByVal pListView As NxnControls.NxNListview)
        Dim _dr As DataRow
        With pListView
            .Items.Clear()
            For Each _dr In pDTable.Rows
                Dim lv_ As ListViewItem = New ListViewItem(_dr("divcode").ToString)
                lv_.SubItems.Add(StrConv(_dr("divname").ToString, vbProperCase))
                lv_.SubItems.Add(StrConv(_dr("address").ToString, vbProperCase))
                lv_.SubItems.Add(_dr("landline").ToString)
                lv_.SubItems.Add(_dr("mobile").ToString)
                lv_.SubItems.Add(_dr("fax").ToString)
                lv_.SubItems.Add(_dr("email").ToString)
                lv_.SubItems.Add(_dr("keyperson").ToString)
                lv_.SubItems.Add(_dr("area_").ToString)
                lv_.SubItems.Add(_dr("area_description").ToString)
                lv_.SubItems.Add(_dr("costcode").ToString)
                lv_.SubItems.Add(_dr("year_work_days").ToString)
                lv_.SubItems.Add(_dr("hourly_divisor").ToString)
                .Items.Add(lv_)
            Next
            .isCheckedAll = True
        End With
    End Sub

    Public Shared Sub LoadCostCenter(ByVal pDTable As DataTable, ByVal pListView As NxnControls.NxNListview)
        Dim _dr As DataRow
        Dim counter As Integer = 0
        With pListView
            .Items.Clear()
            For Each _dr In pDTable.Rows
                Dim lv_ As ListViewItem = New ListViewItem(_dr("costcode").ToString)
                lv_.SubItems.Add(StrConv(_dr("costname").ToString, vbProperCase))
                lv_.SubItems.Add(StrConv(_dr("description").ToString, vbProperCase))
                lv_.SubItems.Add(_dr("dr_account").ToString.ToUpper)
                lv_.SubItems.Add(StrConv(_dr("address").ToString, vbProperCase))
                lv_.SubItems.Add(_dr("contact").ToString.ToUpper)
                lv_.SubItems.Add(_dr("admin_fee").ToString.ToUpper)
                lv_.SubItems.Add(_dr("vat_ex").ToString.ToUpper)

                If isEven(counter) Then lv_.BackColor = Color.White Else lv_.BackColor = Color.WhiteSmoke
                counter += 1
                .Items.Add(lv_)
            Next
        End With
    End Sub

End Class
