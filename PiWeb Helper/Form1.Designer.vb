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
        Me.tbCustomer = New System.Windows.Forms.TextBox()
        Me.tbPartNumber = New System.Windows.Forms.TextBox()
        Me.tbOPN = New System.Windows.Forms.TextBox()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.lblPartNumber = New System.Windows.Forms.Label()
        Me.lblOPN = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.lbFiles = New System.Windows.Forms.ListBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbCustomer
        '
        Me.tbCustomer.Location = New System.Drawing.Point(12, 25)
        Me.tbCustomer.Name = "tbCustomer"
        Me.tbCustomer.Size = New System.Drawing.Size(247, 20)
        Me.tbCustomer.TabIndex = 0
        '
        'tbPartNumber
        '
        Me.tbPartNumber.Location = New System.Drawing.Point(12, 64)
        Me.tbPartNumber.Name = "tbPartNumber"
        Me.tbPartNumber.Size = New System.Drawing.Size(247, 20)
        Me.tbPartNumber.TabIndex = 1
        '
        'tbOPN
        '
        Me.tbOPN.Location = New System.Drawing.Point(12, 103)
        Me.tbOPN.Name = "tbOPN"
        Me.tbOPN.Size = New System.Drawing.Size(247, 20)
        Me.tbOPN.TabIndex = 2
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Location = New System.Drawing.Point(12, 9)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(54, 13)
        Me.lblCustomer.TabIndex = 3
        Me.lblCustomer.Text = "Customer:"
        '
        'lblPartNumber
        '
        Me.lblPartNumber.AutoSize = True
        Me.lblPartNumber.Location = New System.Drawing.Point(12, 48)
        Me.lblPartNumber.Name = "lblPartNumber"
        Me.lblPartNumber.Size = New System.Drawing.Size(69, 13)
        Me.lblPartNumber.TabIndex = 4
        Me.lblPartNumber.Text = "Part Number:"
        '
        'lblOPN
        '
        Me.lblOPN.AutoSize = True
        Me.lblOPN.Location = New System.Drawing.Point(12, 87)
        Me.lblOPN.Name = "lblOPN"
        Me.lblOPN.Size = New System.Drawing.Size(96, 13)
        Me.lblOPN.TabIndex = 5
        Me.lblOPN.Text = "Operation Number:"
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(184, 129)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 6
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'lbFiles
        '
        Me.lbFiles.FormattingEnabled = True
        Me.lbFiles.Location = New System.Drawing.Point(12, 158)
        Me.lbFiles.Name = "lbFiles"
        Me.lbFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbFiles.Size = New System.Drawing.Size(247, 134)
        Me.lbFiles.TabIndex = 7
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(184, 298)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 8
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 330)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lbFiles)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.lblOPN)
        Me.Controls.Add(Me.lblPartNumber)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.tbOPN)
        Me.Controls.Add(Me.tbPartNumber)
        Me.Controls.Add(Me.tbCustomer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PiWeb Helper"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbCustomer As TextBox
    Friend WithEvents tbPartNumber As TextBox
    Friend WithEvents tbOPN As TextBox
    Friend WithEvents lblCustomer As Label
    Friend WithEvents lblPartNumber As Label
    Friend WithEvents lblOPN As Label
    Friend WithEvents btnCheck As Button
    Friend WithEvents lbFiles As ListBox
    Friend WithEvents btnConfirm As Button
End Class
