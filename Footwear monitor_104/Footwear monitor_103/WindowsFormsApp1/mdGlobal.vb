Module mdGlobal
    Public empName(100) As String
    Public empCode(100) As String
    Public empSection(100) As String
    Public empResult(100) As String
    Public empCshift(100) As String
    Public empID(100) As String

    'Public mTextBox(10) As TextBox

    Public TagID(10) As String
    Public mGetState As Boolean

    Public Con As New ADODB.Connection
    Public Rs As New ADODB.Recordset

    Public showTimer(10) As Integer

    Public autoStop As Boolean

    Public buf As buffer

    Public Cshift_check As String
    Structure buffer
        Public user_name As String
        Public user_code As String
        Public user_id As String
        Public user_section As String
        Public user_result As String
        Public user_Cshift As String
    End Structure

    Public ngLog(200) As ngMember
    Structure ngMember
        Public ng_name As String
        Public ng_code As String
        Public ng_section As String
        Public ng_result As String
        Public ng_Cshift As String
    End Structure

    Public Sub connectFootwearDB()
        Dim DB_File As String
        Dim tmpPassword As String
        Dim sFullPath As String = Application.StartupPath & "\footwear.ini"

        On Error GoTo errHandle

        DB_File = gblLoadInitItem(sFullPath, "INFO", "DB_FILE", "\footwear.mdb")
        csvFilePath = ("\\800-footwear1\D\ngLog.log")
        cshift = gblLoadInitItem(sFullPath, "INFO", "TXT_FILE", "\\800-footwear1\D\ESD Checking Tool_r325\footwear.txt")

        Con = New ADODB.Connection()
        'Con.Open("Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source = D:\footwear.mdb;Jet OLEDB:Database Password =")
        Con.Open("Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source = " & DB_File & ";Jet OLEDB:Database Password =")
        Exit Sub
errHandle:
        MsgBox("Connection failed < " & DB_File & " >" & vbCrLf & "ErrorNo: " & Err.Number & vbCrLf & "Descript: " & Err.Description, vbOKOnly, "Database error!")
        End

    End Sub

    Public csvFilePath As String
    Public cshift As String
    Private Declare Function GetPrivateProfileStringKey Lib "kernel32" Alias _
"GetPrivateProfileStringA" (ByVal lpApplicationName As String,
                    ByVal lpKeyName As String,
                    ByVal lpDefault As String,
                    ByVal lpReturnedString As String,
                    ByRef nSize As Integer,
                    ByVal lpFileName As String) As Integer

    Public Function gblLoadInitItem(ByVal sFullPath As String,
                                   ByVal sSecName As String,
                                   ByVal sKeyName As String,
                                   ByVal sDefVal As String) As String

        '読み込み値
        Dim sData As String = Space(255)
        Dim sDummy As String
        Dim iLen As Integer = 255


        '戻り値の初期化
        gblLoadInitItem = ""

        GetPrivateProfileStringKey(sSecName, sKeyName, sDefVal, sData, Len(sData), sFullPath)
        'GetPrivateProfileStringKey(sSecName, sKeyName, sDefVal, sData, iLen, sFullPath)

        '文末のNULL文字を取り除き返す
        sDummy = Microsoft.VisualBasic.Left(sData, InStr(sData, Chr(0)) - 1)

        '戻り値のセット
        gblLoadInitItem = sDummy

    End Function

End Module
