<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.tbCustomer = New System.Windows.Forms.TextBox()
        Me.tbPartNumber = New System.Windows.Forms.TextBox()
        Me.tbOperation = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GBmanage = New System.Windows.Forms.GroupBox()
        Me.BtnMoveDown = New System.Windows.Forms.Button()
        Me.btnMoveUp = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.LVSettings = New System.Windows.Forms.ListView()
        Me.Customer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PartNum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Opn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GBmanage.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbCustomer
        '
        Me.tbCustomer.Location = New System.Drawing.Point(6, 51)
        Me.tbCustomer.Name = "tbCustomer"
        Me.tbCustomer.Size = New System.Drawing.Size(145, 20)
        Me.tbCustomer.TabIndex = 1
        '
        'tbPartNumber
        '
        Me.tbPartNumber.Location = New System.Drawing.Point(157, 50)
        Me.tbPartNumber.Name = "tbPartNumber"
        Me.tbPartNumber.Size = New System.Drawing.Size(149, 20)
        Me.tbPartNumber.TabIndex = 2
        '
        'tbOperation
        '
        Me.tbOperation.Location = New System.Drawing.Point(312, 50)
        Me.tbOperation.Name = "tbOperation"
        Me.tbOperation.Size = New System.Drawing.Size(149, 20)
        Me.tbOperation.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Customer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Part Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(309, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Operation"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(470, 18)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(114, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GBmanage
        '
        Me.GBmanage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBmanage.Controls.Add(Me.BtnMoveDown)
        Me.GBmanage.Controls.Add(Me.btnMoveUp)
        Me.GBmanage.Controls.Add(Me.btnDelete)
        Me.GBmanage.Controls.Add(Me.Label1)
        Me.GBmanage.Controls.Add(Me.btnAdd)
        Me.GBmanage.Controls.Add(Me.tbCustomer)
        Me.GBmanage.Controls.Add(Me.Label3)
        Me.GBmanage.Controls.Add(Me.tbPartNumber)
        Me.GBmanage.Controls.Add(Me.Label2)
        Me.GBmanage.Controls.Add(Me.tbOperation)
        Me.GBmanage.Location = New System.Drawing.Point(12, 308)
        Me.GBmanage.Name = "GBmanage"
        Me.GBmanage.Size = New System.Drawing.Size(590, 117)
        Me.GBmanage.TabIndex = 8
        Me.GBmanage.TabStop = False
        Me.GBmanage.Text = "Manage Frequently Used Parts"
        '
        'BtnMoveDown
        '
        Me.BtnMoveDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMoveDown.Location = New System.Drawing.Point(528, 78)
        Me.BtnMoveDown.Name = "BtnMoveDown"
        Me.BtnMoveDown.Size = New System.Drawing.Size(56, 23)
        Me.BtnMoveDown.TabIndex = 10
        Me.BtnMoveDown.Text = "Down"
        Me.BtnMoveDown.UseVisualStyleBackColor = True
        '
        'btnMoveUp
        '
        Me.btnMoveUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMoveUp.Location = New System.Drawing.Point(470, 78)
        Me.btnMoveUp.Name = "btnMoveUp"
        Me.btnMoveUp.Size = New System.Drawing.Size(56, 23)
        Me.btnMoveUp.TabIndex = 9
        Me.btnMoveUp.Text = "Up"
        Me.btnMoveUp.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(470, 48)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(114, 23)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'LVSettings
        '
        Me.LVSettings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LVSettings.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Customer, Me.PartNum, Me.Opn})
        Me.LVSettings.FullRowSelect = True
        Me.LVSettings.Location = New System.Drawing.Point(12, 12)
        Me.LVSettings.MultiSelect = False
        Me.LVSettings.Name = "LVSettings"
        Me.LVSettings.Size = New System.Drawing.Size(590, 290)
        Me.LVSettings.TabIndex = 9
        Me.LVSettings.UseCompatibleStateImageBehavior = False
        '
        'Customer
        '
        Me.Customer.Text = "Customer"
        Me.Customer.Width = 196
        '
        'PartNum
        '
        Me.PartNum.Text = "Part Number"
        Me.PartNum.Width = 195
        '
        'Opn
        '
        Me.Opn.Text = "Operation"
        Me.Opn.Width = 195
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 438)
        Me.Controls.Add(Me.LVSettings)
        Me.Controls.Add(Me.GBmanage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.GBmanage.ResumeLayout(False)
        Me.GBmanage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbCustomer As TextBox
    Friend WithEvents tbPartNumber As TextBox
    Friend WithEvents tbOperation As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents GBmanage As GroupBox
    Friend WithEvents btnMoveUp As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents LVSettings As ListView
    Friend WithEvents Customer As ColumnHeader
    Friend WithEvents PartNum As ColumnHeader
    Friend WithEvents Opn As ColumnHeader
    Friend WithEvents BtnMoveDown As Button
End Class
