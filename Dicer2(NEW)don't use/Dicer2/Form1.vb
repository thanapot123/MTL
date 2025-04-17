'Imports System.IO.Ports
'Imports Keyence.AutoID.SDK
Public Class Form1
    Private Sub DrawModel()

    End Sub
    Private Sub Code_txt_KeyDown(sender As Object, e As KeyEventArgs) Handles Code_txt.KeyDown
        Dim CountRow As Integer = 0
        Dim Rcnt As Short = 0
        Dim Rcnt2 As Integer = 0
        Dim judge1 As String

        If e.KeyCode = Keys.Enter Then
            If Trim(Code_txt.Text) = "" Then
                Exit Sub
            End If
            Code_txt.Enabled = False
            Button1.Enabled = False
            With DataGridView1
                CountRow = DataGridView1.Rows.Count
                Timer2.Enabled = True
                Do
                    If Trim(Code_txt.Text) = .Rows(Rcnt).Cells(0).Value Then
                        If .Rows(Rcnt).Cells(2).Value <> "" Then
                            Code_txt.Text = ""
                            Exit Sub
                        End If
                        Rcnt2 = CountRow - Rcnt
                        Time1 = TimeT(Rcnt2 - 1)
                        Time2 = Now
                        TimeDif1 = Time2 - Time1
                        TimeDif2 = #9/19/2019 00:12:00# - #9/19/2019 00:00:00#
                        TimeDif3 = #9/19/2019 00:15:00# - #9/19/2019 00:00:00#
                        ShowTime0 = Format(Now, "HH:mm:ss")
                        ShowTime = TimeDif1.ToString
                        ShowTime = Mid(ShowTime, 1, 8)

                        Dim gTimeDif As Double
                        Dim gMaxTime As Double
                        Dim gMinTime As Double

                        Dim TS As TimeSpan



                        TS = TimeDif1
                        gTimeDif = ((TS.Hours * 60 * 60) + (TS.Minutes * 60) + TS.Seconds) / 60
                        gMaxTime = maxTime
                        gMinTime = minTime

                        .Rows(Rcnt).Cells(3).Value = ShowTime
                        .Rows(Rcnt).Cells(2).Value = ShowTime0

                        'If TimeDif1 < TimeDif2 Then
                        'If gTimeDif < TimeDif2 Then
                        '    .Rows(Rcnt).DefaultCellStyle.BackColor = Color.LightGreen
                        '    judge1 = "G"
                        '    .Rows(Rcnt).Cells(4).Value = "G"
                        'ElseIf TimeDif1 < TimeDif3 Then
                        '    .Rows(Rcnt).DefaultCellStyle.BackColor = Color.LightGreen
                        '    judge1 = "G"
                        '    .Rows(Rcnt).Cells(4).Value = "G"
                        'Else
                        '    .Rows(Rcnt).DefaultCellStyle.BackColor = Color.Red
                        '    judge1 = "NG"
                        '    .Rows(Rcnt).Cells(4).Value = "NG"
                        '    NG_form.ShowDialog()
                        '    Code_txt.Focus()
                        'End If

                        If gTimeDif > gMinTime And gTimeDif < gMaxTime Then
                            .Rows(Rcnt).DefaultCellStyle.BackColor = Color.LightGreen
                            judge1 = "G"
                            .Rows(Rcnt).Cells(4).Value = "G"
                        Else
                            .Rows(Rcnt).DefaultCellStyle.BackColor = Color.Red
                            judge1 = "NG"
                            .Rows(Rcnt).Cells(4).Value = "NG"
                            NG_form.ShowDialog()
                            Code_txt.Focus()
                        End If
                        Call save_data(Code_txt.Text, Time1, Time2, ShowTime, judge1)
                        Call save_logfile(judge1)
                        Code_txt.Text = ""
                        Exit Sub
                        Exit Do
                    End If
                    Rcnt = Rcnt + 1
                Loop Until Rcnt = CountRow
            End With

            With DataGridView1
                serial_no = Trim(Code_txt.Text)
                If Record > 0 Then
                    .Rows.Insert(0)
                    .Item(0, Record - 1).Selected = False
                End If
                TimeT(Record) = Now
                ShowTime0 = Format(Now, "HH:mm:ss")
                .Rows(0).Cells(0).Value = serial_no
                .Rows(0).Cells(1).Value = ShowTime0
                .Rows(0).DefaultCellStyle.BackColor = Color.White
                Me.Refresh()
                Code_txt.Text = ""
                Lcnt = Lcnt + 1
                Record = Record + 1
                operate = operate + 1
                OPtxt.Text = operate
            End With
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Insert.ShowDialog()
        Code_txt.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Code_txt.Enabled = False
        Button3.Visible = False
        Call InitialLineRead()
        Timer2.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label9.Text = "----------"
        Label10.Text = "----------"
        Label12.Text = "----------"
        Label18.Text = "----------"
        Code_txt.Enabled = False
        Button3.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Do you end this lot? /คุณต้องการปิดล็อตนี้มั้ย", vbYesNo + vbQuestion) = vbYes Then
            If System.IO.File.Exists(save_path & model_name & "\" & lotno & ".txt") Then
                My.Computer.FileSystem.RenameFile(save_path & model_name & "\" & lotno & ".txt", lotno & ".end")
            End If
            Waiting(1000)
        End If
        Me.Close()
    End Sub


    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim CountRow As Integer = 0
        Dim Rcnt As Short = 0
        Dim Rcnt2 As Integer = 0
        Dim judge1 As String

        Dim gTimeDif As Double
        Dim gMaxTime As Double
        Dim gMinTime As Double

        Dim TS As TimeSpan

        If AL = 0 Then
            AL = 1
        Else
            AL = 0
        End If
        With DataGridView1
            CountRow = DataGridView1.Rows.Count
            If .Rows(0).Cells(0).Value = "" Then
                Exit Sub
            End If
            Do
                If .Rows(Rcnt).Cells(2).Value = "" Then
                    Rcnt2 = CountRow - Rcnt
                    Time1 = TimeT(Rcnt2 - 1)
                    Time2 = Now
                    TimeDif1 = Time2 - Time1
                    TimeDif2 = #9/19/2019 00:13:00# - #9/19/2019 00:00:00#
                    TimeDif3 = #9/19/2019 00:15:00# - #9/19/2019 00:00:00#
                    ShowTime0 = Format(Now, "HH:mm:ss")


                    TS = TimeDif1
                    gTimeDif = ((TS.Hours * 60 * 60) + (TS.Minutes * 60) + TS.Seconds) / 60
                    gMaxTime = maxTime
                    gMinTime = minTime

                    'If TimeDif1 < TimeDif2 

                    'ElseIf TimeDif1 < TimeDif3 Then
                    '    If AL = 1 Then
                    '        .Rows(Rcnt).DefaultCellStyle.BackColor = Color.Orange
                    '    Else
                    '        .Rows(Rcnt).DefaultCellStyle.BackColor = Color.LightYellow
                    '    End If
                    'Else
                    '    .Rows(Rcnt).DefaultCellStyle.BackColor = Color.Red
                End If

                If gTimeDif > gMinTime And gTimeDif < gMaxTime Then
                    If gTimeDif < 13 Then GoTo aa
                    If AL = 1 Then
                        .Rows(Rcnt).DefaultCellStyle.BackColor = Color.Orange
                    Else
                        .Rows(Rcnt).DefaultCellStyle.BackColor = Color.LightYellow
                    End If
                Else
                    '.Rows(Rcnt).DefaultCellStyle.BackColor = Color.Red
                    If .Rows(Rcnt).Cells(4).Value = "NG" Then
                        .Rows(Rcnt).DefaultCellStyle.BackColor = Color.Red
                    ElseIf .Rows(Rcnt).Cells(4).Value = "G" Then
                        .Rows(Rcnt).DefaultCellStyle.BackColor = Color.LightGreen
                    Else
                        .Rows(Rcnt).DefaultCellStyle.BackColor = Color.LightYellow
                    End If
                End If
aa:
                Rcnt = Rcnt + 1
            Loop Until Rcnt = CountRow
        End With
    End Sub

    Private Sub Code_txt_TextChanged(sender As Object, e As EventArgs) Handles Code_txt.TextChanged

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Code_txt.Enabled = True
        Button1.Enabled = True
        Timer2.Enabled = False
        Code_txt.Focus()
    End Sub
End Class
