'Imports System.Runtime.CompilerServices
Imports System.IO
Module Initial
    Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short

    Public Sub InitialLineRead()

        Dim Address As String
        Dim FileName As String
        Dim Path As String
        Dim TempStr As String
        Dim Stat As Integer

        Address = My.Application.Info.DirectoryPath
        FileName = "Dicer_setup.ini"
        Path = Address & "\" & FileName
        TempStr = Space(255)

        Stat = GetPrivateProfileString("Save_Path", "Save", "Default", TempStr, 255, Path)
        save_path = Microsoft.VisualBasic.Left(TempStr, InStr(TempStr, Chr(0)) - 1)

        Stat = GetPrivateProfileString("Log_Path", "Log", "Default", TempStr, 255, Path)
        log_path = Microsoft.VisualBasic.Left(TempStr, InStr(TempStr, Chr(0)) - 1)

    End Sub

    Public Sub get_log_file()
        'Dim Address As String
        'Dim FileName As String
        Dim Path As String
        Dim TempStr As String
        Dim Stat As Integer

        'Address = My.Application.Info.DirectoryPath
        'FileName = "EFT.ini"
        'Path = Address & "\" & FileName
        If Not Right(log_path, 1) = "\" Then
            log_path = log_path & "\"
        End If
        Path = log_path & model_name & "\" & lotno & ".log"
        TempStr = Space(255)
        If System.IO.File.Exists(Path) = False Then
            count_g = 0
            count_ng = 0
        Else
            Stat = GetPrivateProfileString("COUNT", "G", "0", TempStr, 255, Path)
            count_g = Microsoft.VisualBasic.Left(TempStr, InStr(TempStr, Chr(0)) - 1)
            Stat = WritePrivateProfileString("COUNT", "G", count_g, Path)

            Stat = GetPrivateProfileString("COUNT", "NG", "0", TempStr, 255, Path)
            count_ng = Microsoft.VisualBasic.Left(TempStr, InStr(TempStr, Chr(0)) - 1)
            Stat = WritePrivateProfileString("COUNT", "NG", count_ng, Path)

        End If
        Form1.Gtxt.Text = count_g
        Form1.NGtxt.Text = count_ng
        operate = count_g + count_ng
        Form1.OPtxt.Text = operate

    End Sub

    Public Sub save_logfile(Judge As String)
        'Dim Address As String = String.Empty
        Dim FileName As String = String.Empty
        'Dim TextLine As String = String.Empty
        Dim i As Short = 0

        If Judge = "G" Then
            count_g = count_g + 1
            Form1.Gtxt.Text = count_g
            Judge = ""
        ElseIf Judge = "NG" Then
            count_ng = count_ng + 1
            Form1.NGtxt.Text = count_ng
            Judge = ""
        End If

        'Address = My.Application.Info.DirectoryPath
        If Not Right(log_path, 1) = "\" Then
            log_path = log_path & "\"
        End If

        FileName = log_path & model_name
        If Directory.Exists(FileName) = False Then MkDir(FileName)
        FileName = log_path & model_name & "\" & lotno & ".log"

        'If System.IO.File.Exists(FileName) = True Then
        Dim objReader As New System.IO.StreamWriter(FileName)

        objReader.WriteLine("[INFO]")
        objReader.WriteLine("PRODUCT=" & model_name)
        objReader.WriteLine("LOTNO=" & lotno)
        'objReader.WriteLine("MACHINE=" & val_machine)
        'objReader.WriteLine("OPERATOR=" & operator_code)

        objReader.WriteLine("[UPDATE]")
        objReader.WriteLine("DATE=" & Format(Now, "dd/MMM/yy"))
        objReader.WriteLine("TIME=" & Format(Now, "HH:mm:ss"))

        objReader.WriteLine("[COUNT]")
        objReader.WriteLine("G=" & count_g)
        objReader.WriteLine("NG=" & count_ng)

        objReader.WriteLine("[BLADE]")
        objReader.WriteLine("Blade=" & blade_code)

        'objReader.WriteLine("RATIO=" & Format(count_ratio, "#0.00"))

        objReader.Close()
        'Else
        'MessageBox.Show("File Does Not Exist")
        'End If
    End Sub

    Public Sub save_data(Data1 As String, Data2 As String, Data3 As String, Data4 As String, Data5 As String)

        Dim tmp_path As String
        Dim sample_path As String
        Dim FileFlag As Boolean

        'On Error GoTo Err_RecordData

        If Not Right(save_path, 1) = "\" Then
            save_path = save_path & "\"
        End If
        tmp_path = save_path & model_name
        If Directory.Exists(tmp_path) = False Then MkDir(tmp_path)

        If File.Exists(save_path & model_name & "\" & lotno & ".end") Then
            My.Computer.FileSystem.RenameFile(save_path & model_name & "\" & lotno & ".end", lotno & ".txt")
        End If
        tmp_path = save_path & model_name & "\" & lotno & ".txt"

        'If Not Right(folder_sample, 1) = "\" Then
        '    folder_sample = folder_sample & "\"
        'End If
        'sample_path = folder_sample & model_name & "\eDATA"
        'If Directory.Exists(sample_path) = False Then MkDir(sample_path)
        'sample_path = folder_sample & model_name & "\eDATA\" & lotno & "_sample.txt"
        'Check file exists
        If File.Exists(tmp_path) = True Then 'Or File.Exists(sample_path) = True Then
            FileFlag = True
        Else
            FileFlag = False
        End If

        If FileFlag = False Then
            Using Txt As StreamWriter = File.CreateText(tmp_path)
                Txt.WriteLine("*MODEL=" & model_name & Space(1))
                Txt.WriteLine("*LOT=" & lotno & Space(1))
                Txt.WriteLine("*OPERATOR CODE=" & operator_code & Space(1))
                Txt.WriteLine("*DATE=" & Format(Now, "dd-MMM-yy") & Space(1))
                Txt.WriteLine("*BLADE=" & blade_code & Space(1))
                'Txt.WriteLine("*REEL_NO.=" & reelNo & Space(1))

                Txt.WriteLine("")
                Txt.WriteLine("SERIAL_NO,START,FINISH,USING TIME,OPERATOR_CODE,JUDGEMENT")
                Txt.WriteLine(Data1 & "," &
                              Data2 & "," &
                              Data3 & "," &
                              Data4 & "," &
                              operator_code & "," &
                              Data5)
            End Using
        Else
            Using Txt As StreamWriter = File.AppendText(tmp_path)
                Txt.WriteLine(Data1 & "," &
                              Data2 & "," &
                              Data3 & "," &
                              Data4 & "," &
                              operator_code & "," &
                              Data5)
            End Using
        End If

    End Sub

    Public Sub Waiting(ByVal Interval As Integer)
        Dim SW As New Stopwatch

        SW.Start()
        Do While SW.ElapsedMilliseconds < Interval
            'Nothing to Do (Delay)
        Loop
        SW.Stop()
    End Sub

End Module
