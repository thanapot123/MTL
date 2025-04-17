Imports System.IO
Imports System.Text

Module modGenePro

    Public Enc As Encoding = Encoding.GetEncoding("Shift_JIS")

    Public Function gblCheckProductTable(ByVal sProduct As String, ByVal sblade As String) As Integer

        'Dim sFullPath As String = tinfo.sInfoFolder & "Product.txt"
        Dim sFullPath As String = Application.StartupPath & "\Product1.txt"
        Dim strInfo() As String = Nothing
        Dim stritem() As String = Nothing

        Dim i As Integer
        Dim n As Integer

        gblCheckProductTable = 99

        gblLoadFile_Bin(sFullPath, strInfo)

        n = UBound(strInfo)
        For i = 0 To n Step 1
            stritem = Split(strInfo(i), ",")
            If sProduct = Trim(UCase(stritem(0))) Then
                model_name = UCase(stritem(0))
                minTime = stritem(1)
                maxTime = stritem(2)

                If Trim(UCase(sblade)) = Trim(UCase(stritem(3))) Then
                    blade_code = UCase(stritem(3))
                    gblCheckProductTable = 0

                Else
                    gblCheckProductTable = 2

                End If
                Exit Function
            Else
                gblCheckProductTable = 1
            End If
        Next i

    End Function

    Public Sub gblLoadFile_Bin(ByVal sFullPath As String, ByRef strInfo() As String)

        Dim FileNum As Integer = FreeFile()
        Dim strItem() As Stream = Nothing

        Dim sr As StreamReader = New StreamReader(sFullPath, System.Text.Encoding.Default)


        Dim sBuff As String

        sBuff = sr.ReadToEnd()
        strInfo = Split(sBuff, vbCrLf)

        sr.Close()

    End Sub

    Public Sub gblLoadInit()

        Dim sFullPath As String = Application.StartupPath & "\Fc502n.ini"


        With tinfo

            '.sLanguage = gblLoadInitItem(sFullPath, "Info", "Language", "J")
            .sInfoFolder = gblLoadInitItem(sFullPath, "Folder", "Info", "D:\Dicer2\Dicer2\bin\Debug\")
            '.sInputFolder = gblLoadInitItem(sFullPath, "Folder", "Input", "C:\vt_data\")
            .sOutputFolder = gblLoadInitItem(sFullPath, "Folder", "Output", "D:\Fc502n\metek\")
        End With

    End Sub

End Module
