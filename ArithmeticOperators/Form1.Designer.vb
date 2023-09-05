<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtNumber1 = New TextBox()
        txtNumber2 = New TextBox()
        txt1stNumber = New Label()
        txt2ndNumber = New Label()
        txtCalculate = New Button()
        SuspendLayout()
        ' 
        ' txtNumber1
        ' 
        txtNumber1.Location = New Point(299, 95)
        txtNumber1.Name = "txtNumber1"
        txtNumber1.Size = New Size(150, 31)
        txtNumber1.TabIndex = 0
        ' 
        ' txtNumber2
        ' 
        txtNumber2.Location = New Point(299, 165)
        txtNumber2.Name = "txtNumber2"
        txtNumber2.Size = New Size(150, 31)
        txtNumber2.TabIndex = 0
        ' 
        ' txt1stNumber
        ' 
        txt1stNumber.AutoSize = True
        txt1stNumber.Location = New Point(115, 98)
        txt1stNumber.Name = "txt1stNumber"
        txt1stNumber.Size = New Size(160, 25)
        txt1stNumber.TabIndex = 1
        txt1stNumber.Text = "Enter First Number"
        ' 
        ' txt2ndNumber
        ' 
        txt2ndNumber.AutoSize = True
        txt2ndNumber.Location = New Point(89, 171)
        txt2ndNumber.Name = "txt2ndNumber"
        txt2ndNumber.Size = New Size(186, 25)
        txt2ndNumber.TabIndex = 2
        txt2ndNumber.Text = "Enter Second Number"
        ' 
        ' txtCalculate
        ' 
        txtCalculate.Location = New Point(299, 248)
        txtCalculate.Name = "txtCalculate"
        txtCalculate.Size = New Size(150, 63)
        txtCalculate.TabIndex = 3
        txtCalculate.Text = "Calculate"
        txtCalculate.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtCalculate)
        Controls.Add(txt2ndNumber)
        Controls.Add(txt1stNumber)
        Controls.Add(txtNumber2)
        Controls.Add(txtNumber1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents txt1stNumber As Label
    Friend WithEvents txt2ndNumber As Label
    Friend WithEvents txtCalculate As Button
End Class
