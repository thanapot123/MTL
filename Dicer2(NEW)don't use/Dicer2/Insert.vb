Public Class Insert
    Private Sub Insert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_model.Text = ""
        txt_lotno.Text = ""
        txt_operator.Text = ""
    End Sub

    Private Sub Input_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txt_model.Focus()
        button_OK.Enabled = False
    End Sub

    Private Sub txt_model_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_model.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            If txt_model.Text = "" Then
                MessageBox.Show("Please fill in model name", "Error")
                txt_model.Focus()
                Exit Sub
            End If
            txt_model.Text = Trim(UCase(txt_model.Text))
            model_name = txt_model.Text
            txt_lotno.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            txt_model.Text = ""
            txt_model.Focus()
        End If
    End Sub

    Private Sub txt_lotno_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_lotno.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            If txt_lotno.Text = "" Then
                MessageBox.Show("Please fill in Lot no.", "Error")
                txt_lotno.Focus()
                Exit Sub
            End If
            txt_lotno.Text = Trim(UCase(txt_lotno.Text))
            Lotno = txt_lotno.Text
            txt_operator.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            txt_lotno.Text = ""
            txt_lotno.Focus()
        End If
    End Sub

    Private Sub txt_operator_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_operator.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            If txt_operator.Text = "" Then
                MessageBox.Show("Please fill in employee code", "Error")
                txt_operator.Focus()
                Exit Sub
            End If
            txt_operator.Text = Trim(UCase(txt_operator.Text))
            operator_code = txt_operator.Text
            txt_blade.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            txt_operator.Text = ""
            txt_operator.Focus()
        End If
    End Sub

    Private Sub txt_blade_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_blade.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            If txt_blade.Text = "" Then
                MessageBox.Show("Please fill in blade code", "Error")
                txt_blade.Focus()
                Exit Sub
            End If
            txt_blade.Text = Trim(UCase(txt_blade.Text))
            'blade_code = txt_blade.Text
            button_OK.Enabled = True
            button_OK.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            txt_blade.Text = ""
            txt_blade.Focus()
        End If


    End Sub

    Private Sub button_cancel_Click(sender As Object, e As EventArgs) Handles button_cancel.Click
        txt_model.Text = ""
        txt_lotno.Text = ""
        txt_operator.Text = ""
        txt_blade.Text = ""
        Me.Close()

    End Sub

    Private Sub button_OK_Click(sender As Object, e As EventArgs) Handles button_OK.Click
        txt_model.Text = UCase(txt_model.Text)
        txt_lotno.Text = UCase(txt_lotno.Text)
        txt_blade.Text = UCase(txt_blade.Text)

        txt_blade.Text = Mid(txt_blade.Text, 1, 7)
        Select Case gblCheckProductTable(txt_model.Text, txt_blade.Text)
            Case 0
            Case 1
                MsgBox("Model not found!", vbExclamation + vbOKOnly)
                txt_model.Text = ""
                txt_lotno.Text = ""
                txt_operator.Text = ""
                txt_blade.Text = ""
                txt_model.Focus()
                Exit Sub
            Case 2
                MsgBox("Cutting blade mistake!", vbCritical + vbOKOnly)
                txt_blade.Text = ""
                txt_blade.Focus()
                Exit Sub
            Case 99
                MsgBox("error")
                Exit Sub
        End Select

        'If gblCheckProductTable(txt_model.Text, txt_blade.Text) = 1 Then
        '    MsgBox("Model not found!")
        '    txt_model.Text = ""
        '    txt_lotno.Text = ""
        '    txt_operator.Text = ""
        '    txt_blade.Text = ""
        '    txt_model.Focus()
        '    Exit Sub
        'ElseIf gblCheckProductTable(txt_blade.Text) = 2 Then
        '    MsgBox("blade not found!")
        '    txt_model.Text = ""
        '    txt_lotno.Text = ""
        '    txt_operator.Text = ""
        '    txt_blade.Text = ""
        '    txt_blade.Focus()
        '    Exit Sub
        'End If

        model_name = txt_model.Text
        Lotno = txt_lotno.Text
        operator_code = txt_operator.Text
        blade_code = txt_blade.Text

        Form1.Label9.Text = model_name
        Form1.Label10.Text = lotno
        Form1.Label12.Text = operator_code
        Form1.Label18.Text = blade_code
        Form1.Code_txt.Enabled = True
        Form1.Button2.Visible = False
        Form1.Status.Visible = True
        Form1.lblMax.Text = maxTime
        Form1.lblMin.Text = minTime

        Call get_log_file()
        Form1.Timer1.Enabled = True
        Me.Close()


        'StatusDraw(0)

        'Call ProgramInitial()
        'Call createfolder()
        'FormMain.Show()
        'Reel_No.Show()
        'Reel_Alert.Show()

        'FormMain.Timer1.Enabled = True


    End Sub


End Class