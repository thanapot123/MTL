Module PB

    Public Record As Integer = 0
    Public Lcnt As Short = 0

    Public ShowTime0 As String
    Public ShowTime As String

    Public Serial_code As String
    Public Minute As String

    Public G As String
    Public NG As String

    Public model_name As String
    Public lotno As String
    Public operator_code As String
    Public serial_no As String
    Public blade_code As String

    Public TimeT(1000) As String
    Public DateT(1000) As Date
    Public Time1 As Date
    Public Time2 As Date
    Public TimeDif1 As TimeSpan
    Public TimeDif2 As TimeSpan
    Public TimeDif3 As TimeSpan

    Public save_path As String
    Public log_path As String
    Public count_g As Integer
    Public count_ng As Integer
    Public operate As Integer
    Public AL As Integer

    Public maxTime As Double
    Public minTime As Double

    Public tinfo As tInfoList
    Public Structure tInfoList

        Public sInfoFolder As String
        Public sInputFolder As String
        Public sOutputFolder As String
        Public sDataFolder As String
        Public sProductFolder As String

    End Structure

End Module
