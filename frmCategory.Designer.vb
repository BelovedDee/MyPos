<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategory
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
        Me.dgvCategory = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelProduct = New System.Windows.Forms.Panel()
        Me.btnDeleteCategory = New System.Windows.Forms.Button()
        Me.btnEditCategory = New System.Windows.Forms.Button()
        Me.btnSaveCategory = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtProductCategory = New System.Windows.Forms.TextBox()
        Me.lblProName = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelProduct.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCategory
        '
        Me.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategory.GridColor = System.Drawing.Color.Silver
        Me.dgvCategory.Location = New System.Drawing.Point(259, 94)
        Me.dgvCategory.Name = "dgvCategory"
        Me.dgvCategory.Size = New System.Drawing.Size(267, 366)
        Me.dgvCategory.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Baskerville Old Face", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(145, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 54)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Category"
        '
        'PanelProduct
        '
        Me.PanelProduct.BackColor = System.Drawing.Color.Silver
        Me.PanelProduct.Controls.Add(Me.btnDeleteCategory)
        Me.PanelProduct.Controls.Add(Me.btnEditCategory)
        Me.PanelProduct.Controls.Add(Me.btnSaveCategory)
        Me.PanelProduct.Controls.Add(Me.Label6)
        Me.PanelProduct.Controls.Add(Me.txtProductCategory)
        Me.PanelProduct.Controls.Add(Me.lblProName)
        Me.PanelProduct.Location = New System.Drawing.Point(10, 169)
        Me.PanelProduct.Name = "PanelProduct"
        Me.PanelProduct.Size = New System.Drawing.Size(243, 234)
        Me.PanelProduct.TabIndex = 52
        '
        'btnDeleteCategory
        '
        Me.btnDeleteCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeleteCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteCategory.ForeColor = System.Drawing.Color.White
        Me.btnDeleteCategory.Location = New System.Drawing.Point(120, 140)
        Me.btnDeleteCategory.Name = "btnDeleteCategory"
        Me.btnDeleteCategory.Size = New System.Drawing.Size(75, 38)
        Me.btnDeleteCategory.TabIndex = 37
        Me.btnDeleteCategory.Text = "Delete"
        Me.btnDeleteCategory.UseVisualStyleBackColor = False
        '
        'btnEditCategory
        '
        Me.btnEditCategory.BackColor = System.Drawing.Color.Teal
        Me.btnEditCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditCategory.ForeColor = System.Drawing.Color.White
        Me.btnEditCategory.Location = New System.Drawing.Point(87, 184)
        Me.btnEditCategory.Name = "btnEditCategory"
        Me.btnEditCategory.Size = New System.Drawing.Size(75, 38)
        Me.btnEditCategory.TabIndex = 36
        Me.btnEditCategory.Text = "Edit"
        Me.btnEditCategory.UseVisualStyleBackColor = False
        '
        'btnSaveCategory
        '
        Me.btnSaveCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSaveCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveCategory.ForeColor = System.Drawing.Color.White
        Me.btnSaveCategory.Location = New System.Drawing.Point(31, 140)
        Me.btnSaveCategory.Name = "btnSaveCategory"
        Me.btnSaveCategory.Size = New System.Drawing.Size(75, 38)
        Me.btnSaveCategory.TabIndex = 35
        Me.btnSaveCategory.Text = "Save"
        Me.btnSaveCategory.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(12, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(211, 25)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Category Information"
        '
        'txtProductCategory
        '
        Me.txtProductCategory.Location = New System.Drawing.Point(31, 89)
        Me.txtProductCategory.Name = "txtProductCategory"
        Me.txtProductCategory.Size = New System.Drawing.Size(164, 20)
        Me.txtProductCategory.TabIndex = 30
        '
        'lblProName
        '
        Me.lblProName.AutoSize = True
        Me.lblProName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblProName.Location = New System.Drawing.Point(28, 68)
        Me.lblProName.Name = "lblProName"
        Me.lblProName.Size = New System.Drawing.Size(116, 18)
        Me.lblProName.TabIndex = 29
        Me.lblProName.Text = "Category Name:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox2.Image = Global.pos1.My.Resources.Resources.no1
        Me.PictureBox2.Location = New System.Drawing.Point(503, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 54
        Me.PictureBox2.TabStop = False
        '
        'frmCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(536, 480)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.dgvCategory)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PanelProduct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCategory"
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelProduct.ResumeLayout(False)
        Me.PanelProduct.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCategory As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelProduct As Panel
    Friend WithEvents btnDeleteCategory As Button
    Friend WithEvents btnEditCategory As Button
    Friend WithEvents btnSaveCategory As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtProductCategory As TextBox
    Friend WithEvents lblProName As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
