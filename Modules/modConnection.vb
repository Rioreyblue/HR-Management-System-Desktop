Public Module modConnection

    Public ServerTxt As String = "http://192.168.99.234:95/hrmaxv16_hiring/xdesktop/"
    'Public ServerTxt As String = "http://127.0.0.1/hrmaxv16_hiring/xdesktop/"


    Public LoginLockOnly As Boolean = False

    Public ActiveUser As String
    Public ActiveUserID As String
    Public ActiveCompany As String
    Public ActiveCompanyName As String
    Public ActiveCompanyAddress As String
    Public ActiveCompanyContact As String
    Public ActiveUserName As String
    Public ActiveImage As String
    Public ActiveYear As String
    Public GroupCode As String

    Public ActiveUserPwd As String
    Public ActiveIdno As String
    Public isConnected As Boolean = False

    Public WebServer As String
    Public MyMacAdd As String
    Public MC As String

    Public ClientCode As String 'Client Code
    Public ClientName As String 'Client Name
    Public BrnCode As String 'Active Branch Code
    Public BrnName As String 'Active Branch Name
    Public LicenseType As String = "SC" 'OT-One Time, SC-Subscription
    Public ExpDate As Date 'Expiration Date
    Public TBar_enable As Boolean

    Public dtBranches As DataTable

    Public mdiClient_ As MdiClient = Nothing
    Public Function isEven(numToCheck As Integer) As Boolean
        Return (numToCheck And 1) <> 0
    End Function
End Module
