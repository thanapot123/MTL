<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Insert
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.button_cancel = New System.Windows.Forms.Button()
        Me.button_OK = New System.Windows.Forms.Button()
        Me.txt_operator = New System.Windows.Forms.TextBox()
        Me.txt_lotno = New System.Windows.Forms.TextBox()
        Me.txt_model = New System.Windows.Forms.TextBox()
        Me.txt_blade = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(30, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Model name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(99, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Lot no. :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(74, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 32)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Operator :"
        '
        'button_cancel
        '
        Me.button_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_cancel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_cancel.ForeColor = System.Drawing.Color.Black
        Me.button_cancel.Location = New System.Drawing.Point(337, 311)
        Me.button_cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.button_cancel.Name = "button_cancel"
        Me.button_cancel.Size = New System.Drawing.Size(148, 50)
        Me.button_cancel.TabIndex = 17
        Me.button_cancel.Text = "CANCEL"
        Me.button_cancel.UseVisualStyleBackColor = False
        '
        'button_OK
        '
        Me.button_OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button_OK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_OK.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_OK.ForeColor = System.Drawing.Color.Black
        Me.button_OK.Location = New System.Drawing.Point(129, 311)
        Me.button_OK.Margin = New System.Windows.Forms.Padding(4)
        Me.button_OK.Name = "button_OK"
        Me.button_OK.Size = New System.Drawing.Size(148, 50)
        Me.button_OK.TabIndex = 16
        Me.button_OK.Text = "OK"
        Me.button_OK.UseVisualStyleBackColor = False
        '
        'txt_operator
        '
        Me.txt_operator.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_operator.Location = New System.Drawing.Point(223, 156)
        Me.txt_operator.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_operator.Name = "txt_operator"
        Me.txt_operator.Size = New System.Drawing.Size(291, 41)
        Me.txt_operator.TabIndex = 15
        '
        'txt_lotno
        '
        Me.txt_lotno.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lotno.Location = New System.Drawing.Point(223, 95)
        Me.txt_lotno.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_lotno.Name = "txt_lotno"
        Me.txt_lotno.Size = New System.Drawing.Size(291, 41)
        Me.txt_lotno.TabIndex = 14
        '
        'txt_model
        '
        Me.txt_model.BackColor = System.Drawing.SystemColors.Window
        Me.txt_model.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_model.Location = New System.Drawing.Point(223, 36)
        Me.txt_model.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_model.Name = "txt_model"
        Me.txt_model.Size = New System.Drawing.Size(291, 41)
        Me.txt_model.TabIndex = 13
        Me.txt_model.Text = "model name"
        '
        'txt_blade
        '
        Me.txt_blade.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_blade.Location = New System.Drawing.Point(223, 216)
        Me.txt_blade.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_blade.Name = "txt_blade"
        Me.txt_blade.Size = New System.Drawing.Size(291, 41)
        Me.txt_blade.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(114, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 32)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "blade :"
        '
        'Insert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(541, 418)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_blade)
        Me.Controls.Add(Me.button_cancel)
        Me.Controls.Add(Me.button_OK)
        Me.Controls.Add(Me.txt_operator)
        Me.Controls.Add(Me.txt_lotno)
        Me.Controls.Add(Me.txt_model)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Insert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insert"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents button_cancel As Button
    Friend WithEvents button_OK As Button
    Friend WithEvents txt_operator As TextBox
    Friend WithEvents txt_lotno As TextBox
    Friend WithEvents txt_model As TextBox
    Friend WithEvents txt_blade As TextBox
    Friend WithEvents Label4 As Label
End Class
