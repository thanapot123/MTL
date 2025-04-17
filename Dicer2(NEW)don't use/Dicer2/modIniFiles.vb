Module modIniFiles

    Private Declare Function GetPrivateProfileStringKey Lib "kernel32" Alias _
"GetPrivateProfileStringA" (ByVal lpApplicationName As String, _
                    ByVal lpKeyName As String, _
                    ByVal lpDefault As String, _
                    ByVal lpReturnedString As String, _
                    ByRef nSize As Integer, _
                    ByVal lpFileName As String) As Integer


    Private Declare Function WritePrivateProfileString _
Lib "kernel32" Alias "WritePrivateProfileStringA" ( _
   ByVal lpApplicationName As String, _
   ByVal lpKeyName As String, _
   ByVal lpString As String, _
   ByVal lpFileName As String _
) As Long

    'INIファイルの書き込み
    Public Sub gblWriteInitItem(ByVal sFullPath As String, _
                               ByVal sSecName As String, _
                               ByVal sKeyName As String, _
                               ByVal sWriteStr As String)

        '書き込み
        WritePrivateProfileString(sSecName, sKeyName, sWriteStr, sFullPath)

    End Sub

    'INIファイルの読み込み
    Public Function gblLoadInitItem(ByVal sFullPath As String, _
                                   ByVal sSecName As String, _
                                   ByVal sKeyName As String, _
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
