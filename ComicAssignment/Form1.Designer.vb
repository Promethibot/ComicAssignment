<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rdiConSu = New System.Windows.Forms.RadioButton()
        Me.rdiConAu = New System.Windows.Forms.RadioButton()
        Me.rdiCon1 = New System.Windows.Forms.RadioButton()
        Me.tbxInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblBefPrice = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(569, 276)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'rdiConSu
        '
        Me.rdiConSu.AutoSize = True
        Me.rdiConSu.BackColor = System.Drawing.Color.Transparent
        Me.rdiConSu.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdiConSu.Location = New System.Drawing.Point(119, 395)
        Me.rdiConSu.Name = "rdiConSu"
        Me.rdiConSu.Size = New System.Drawing.Size(307, 35)
        Me.rdiConSu.TabIndex = 1
        Me.rdiConSu.TabStop = True
        Me.rdiConSu.Text = "Convention + Superhero Experience"
        Me.rdiConSu.UseVisualStyleBackColor = False
        '
        'rdiConAu
        '
        Me.rdiConAu.AutoSize = True
        Me.rdiConAu.BackColor = System.Drawing.Color.Transparent
        Me.rdiConAu.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdiConAu.Location = New System.Drawing.Point(119, 429)
        Me.rdiConAu.Name = "rdiConAu"
        Me.rdiConAu.Size = New System.Drawing.Size(224, 35)
        Me.rdiConAu.TabIndex = 2
        Me.rdiConAu.TabStop = True
        Me.rdiConAu.Text = "Convention + Autographs"
        Me.rdiConAu.UseVisualStyleBackColor = False
        '
        'rdiCon1
        '
        Me.rdiCon1.AutoSize = True
        Me.rdiCon1.BackColor = System.Drawing.Color.Transparent
        Me.rdiCon1.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdiCon1.Location = New System.Drawing.Point(119, 463)
        Me.rdiCon1.Name = "rdiCon1"
        Me.rdiCon1.Size = New System.Drawing.Size(116, 35)
        Me.rdiCon1.TabIndex = 3
        Me.rdiCon1.TabStop = True
        Me.rdiCon1.Text = "Convention"
        Me.rdiCon1.UseVisualStyleBackColor = False
        '
        'tbxInput
        '
        Me.tbxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxInput.Font = New System.Drawing.Font("CC Wild Words", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxInput.Location = New System.Drawing.Point(274, 329)
        Me.tbxInput.Name = "tbxInput"
        Me.tbxInput.Size = New System.Drawing.Size(100, 23)
        Me.tbxInput.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 322)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Group Size:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("CC Wild Words", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(533, 28)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Comic Convention Registration"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("CC Wild Words", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(114, 375)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Select Badge Type:"
        '
        'btnCalc
        '
        Me.btnCalc.Enabled = False
        Me.btnCalc.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(170, 551)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(95, 35)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(300, 551)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(95, 35)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblBefPrice
        '
        Me.lblBefPrice.AutoSize = True
        Me.lblBefPrice.Font = New System.Drawing.Font("CC Wild Words", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBefPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBefPrice.Location = New System.Drawing.Point(118, 514)
        Me.lblBefPrice.Name = "lblBefPrice"
        Me.lblBefPrice.Size = New System.Drawing.Size(238, 20)
        Me.lblBefPrice.TabIndex = 10
        Me.lblBefPrice.Text = "Registration Cost: "
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("CC Wild Words", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPrice.Location = New System.Drawing.Point(354, 514)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(93, 20)
        Me.lblPrice.TabIndex = 11
        Me.lblPrice.Text = "Label5"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 601)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblBefPrice)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbxInput)
        Me.Controls.Add(Me.rdiCon1)
        Me.Controls.Add(Me.rdiConAu)
        Me.Controls.Add(Me.rdiConSu)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Comic Convention Registration"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents rdiConSu As RadioButton
    Friend WithEvents rdiConAu As RadioButton
    Friend WithEvents rdiCon1 As RadioButton
    Friend WithEvents tbxInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblBefPrice As Label
    Friend WithEvents lblPrice As Label
End Class
