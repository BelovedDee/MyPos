<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplier
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDeleteSupplier = New System.Windows.Forms.Button()
        Me.btnEditSupplier = New System.Windows.Forms.Button()
        Me.btnSaveSupplier = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSupplierRemarks = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSupplierPhone = New System.Windows.Forms.TextBox()
        Me.lblSupplierPhone = New System.Windows.Forms.Label()
        Me.txtSupplierAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSupplierName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvSupplier = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Baskerville Old Face", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(198, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(212, 54)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Suppliers"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.btnDeleteSupplier)
        Me.Panel1.Controls.Add(Me.btnEditSupplier)
        Me.Panel1.Controls.Add(Me.btnSaveSupplier)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtSupplierRemarks)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtSupplierPhone)
        Me.Panel1.Controls.Add(Me.lblSupplierPhone)
        Me.Panel1.Controls.Add(Me.txtSupplierAddress)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtSupplierName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(296, 366)
        Me.Panel1.TabIndex = 21
        '
        'btnDeleteSupplier
        '
        Me.btnDeleteSupplier.BackColor = System.Drawing.Color.Teal
        Me.btnDeleteSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteSupplier.ForeColor = System.Drawing.Color.White
        Me.btnDeleteSupplier.Location = New System.Drawing.Point(195, 247)
        Me.btnDeleteSupplier.Name = "btnDeleteSupplier"
        Me.btnDeleteSupplier.Size = New System.Drawing.Size(75, 38)
        Me.btnDeleteSupplier.TabIndex = 21
        Me.btnDeleteSupplier.Text = "Delete"
        Me.btnDeleteSupplier.UseVisualStyleBackColor = False
        '
        'btnEditSupplier
        '
        Me.btnEditSupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditSupplier.ForeColor = System.Drawing.Color.White
        Me.btnEditSupplier.Location = New System.Drawing.Point(195, 184)
        Me.btnEditSupplier.Name = "btnEditSupplier"
        Me.btnEditSupplier.Size = New System.Drawing.Size(75, 38)
        Me.btnEditSupplier.TabIndex = 20
        Me.btnEditSupplier.Text = "Edit"
        Me.btnEditSupplier.UseVisualStyleBackColor = False
        '
        'btnSaveSupplier
        '
        Me.btnSaveSupplier.BackColor = System.Drawing.Color.Teal
        Me.btnSaveSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveSupplier.ForeColor = System.Drawing.Color.White
        Me.btnSaveSupplier.Location = New System.Drawing.Point(195, 121)
        Me.btnSaveSupplier.Name = "btnSaveSupplier"
        Me.btnSaveSupplier.Size = New System.Drawing.Size(75, 38)
        Me.btnSaveSupplier.TabIndex = 19
        Me.btnSaveSupplier.Text = "Save"
        Me.btnSaveSupplier.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(14, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(223, 25)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Supplier Information"
        '
        'txtSupplierRemarks
        '
        Me.txtSupplierRemarks.Location = New System.Drawing.Point(19, 258)
        Me.txtSupplierRemarks.Multiline = True
        Me.txtSupplierRemarks.Name = "txtSupplierRemarks"
        Me.txtSupplierRemarks.Size = New System.Drawing.Size(164, 67)
        Me.txtSupplierRemarks.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(16, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 18)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Remarks:"
        '
        'txtSupplierPhone
        '
        Me.txtSupplierPhone.Location = New System.Drawing.Point(19, 214)
        Me.txtSupplierPhone.Name = "txtSupplierPhone"
        Me.txtSupplierPhone.Size = New System.Drawing.Size(164, 20)
        Me.txtSupplierPhone.TabIndex = 13
        '
        'lblSupplierPhone
        '
        Me.lblSupplierPhone.AutoSize = True
        Me.lblSupplierPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplierPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSupplierPhone.Location = New System.Drawing.Point(16, 193)
        Me.lblSupplierPhone.Name = "lblSupplierPhone"
        Me.lblSupplierPhone.Size = New System.Drawing.Size(136, 18)
        Me.lblSupplierPhone.TabIndex = 12
        Me.lblSupplierPhone.Text = "Supplier Phone &No:"
        Me.lblSupplierPhone.UseWaitCursor = True
        '
        'txtSupplierAddress
        '
        Me.txtSupplierAddress.Location = New System.Drawing.Point(19, 126)
        Me.txtSupplierAddress.Multiline = True
        Me.txtSupplierAddress.Name = "txtSupplierAddress"
        Me.txtSupplierAddress.Size = New System.Drawing.Size(164, 67)
        Me.txtSupplierAddress.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(16, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Supplier Address:"
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Location = New System.Drawing.Point(19, 82)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(164, 20)
        Me.txtSupplierName.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Supplier Name:"
        '
        'dgvSupplier
        '
        Me.dgvSupplier.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSupplier.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSupplier.ColumnHeadersHeight = 28
        Me.dgvSupplier.Location = New System.Drawing.Point(315, 103)
        Me.dgvSupplier.Name = "dgvSupplier"
        Me.dgvSupplier.Size = New System.Drawing.Size(563, 365)
        Me.dgvSupplier.TabIndex = 24
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox2.Image = Global.pos1.My.Resources.Resources.no
        Me.PictureBox2.Location = New System.Drawing.Point(850, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 50
        Me.PictureBox2.TabStop = False
        '
        'frmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(890, 480)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.dgvSupplier)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmSupplier"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDeleteSupplier As Button
    Friend WithEvents btnEditSupplier As Button
    Friend WithEvents btnSaveSupplier As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSupplierRemarks As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSupplierPhone As TextBox
    Friend WithEvents lblSupplierPhone As Label
    Friend WithEvents txtSupplierAddress As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSupplierName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvSupplier As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
End Class
