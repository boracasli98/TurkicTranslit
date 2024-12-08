<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        Latin = New RadioButton()
        Kiril = New RadioButton()
        Arap = New RadioButton()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(12, 27)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(215, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 1
        Label1.Text = "Lehçe:"
        ' 
        ' Latin
        ' 
        Latin.AutoSize = True
        Latin.Location = New Point(233, 28)
        Latin.Name = "Latin"
        Latin.Size = New Size(51, 19)
        Latin.TabIndex = 2
        Latin.TabStop = True
        Latin.Text = "Latin"
        Latin.UseVisualStyleBackColor = True
        ' 
        ' Kiril
        ' 
        Kiril.AutoSize = True
        Kiril.Location = New Point(290, 28)
        Kiril.Name = "Kiril"
        Kiril.Size = New Size(45, 19)
        Kiril.TabIndex = 3
        Kiril.TabStop = True
        Kiril.Text = "Kiril"
        Kiril.UseVisualStyleBackColor = True
        ' 
        ' Arap
        ' 
        Arap.AutoSize = True
        Arap.Location = New Point(341, 28)
        Arap.Name = "Arap"
        Arap.Size = New Size(50, 19)
        Arap.TabIndex = 4
        Arap.TabStop = True
        Arap.Text = "Arap"
        Arap.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Times New Roman", 15F)
        TextBox1.Location = New Point(12, 56)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(379, 382)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.Window
        TextBox2.Font = New Font("Times New Roman", 15F)
        TextBox2.Location = New Point(397, 56)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(379, 382)
        TextBox2.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(787, 447)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Arap)
        Controls.Add(Kiril)
        Controls.Add(Latin)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        Text = "TurkicTranslit"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Latin As RadioButton
    Friend WithEvents Kiril As RadioButton
    Friend WithEvents Arap As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox

End Class
