<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduct
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
        Me.components = New System.ComponentModel.Container()
        Me.cbProdSupID = New System.Windows.Forms.ComboBox()
        Me.lblSupId = New System.Windows.Forms.Label()
        Me.txtSupplierName = New System.Windows.Forms.TextBox()
        Me.lblSupName = New System.Windows.Forms.Label()
        Me.txtProductPrice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDeleteProduct = New System.Windows.Forms.Button()
        Me.btnEditProduct = New System.Windows.Forms.Button()
        Me.btnSaveProduct = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtProductQty = New System.Windows.Forms.TextBox()
        Me.lblProQty = New System.Windows.Forms.Label()
        Me.lblProCategory = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.lblProName = New System.Windows.Forms.Label()
        Me.PanelProduct = New System.Windows.Forms.Panel()
        Me.btnEditCat = New System.Windows.Forms.Button()
        Me.cbProductCat = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dgvProduct = New System.Windows.Forms.DataGridView()
        Me.Pos_SystemDataSet = New pos1.Pos_SystemDataSet()
        Me.PosSystemDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelProduct.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pos_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PosSystemDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbProdSupID
        '
        Me.cbProdSupID.FormattingEnabled = True
        Me.cbProdSupID.Location = New System.Drawing.Point(9, 244)
        Me.cbProdSupID.Name = "cbProdSupID"
        Me.cbProdSupID.Size = New System.Drawing.Size(164, 21)
        Me.cbProdSupID.TabIndex = 44
        '
        'lblSupId
        '
        Me.lblSupId.AutoSize = True
        Me.lblSupId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSupId.Location = New System.Drawing.Point(9, 225)
        Me.lblSupId.Name = "lblSupId"
        Me.lblSupId.Size = New System.Drawing.Size(83, 18)
        Me.lblSupId.TabIndex = 43
        Me.lblSupId.Text = "Supplier ID:"
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Enabled = False
        Me.txtSupplierName.Location = New System.Drawing.Point(9, 287)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(164, 20)
        Me.txtSupplierName.TabIndex = 42
        '
        'lblSupName
        '
        Me.lblSupName.AutoSize = True
        Me.lblSupName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupName.ForeColor = System.Drawing.Color.Teal
        Me.lblSupName.Location = New System.Drawing.Point(9, 268)
        Me.lblSupName.Name = "lblSupName"
        Me.lblSupName.Size = New System.Drawing.Size(109, 18)
        Me.lblSupName.TabIndex = 41
        Me.lblSupName.Text = "Supplier Name:"
        '
        'txtProductPrice
        '
        Me.txtProductPrice.Location = New System.Drawing.Point(9, 203)
        Me.txtProductPrice.Name = "txtProductPrice"
        Me.txtProductPrice.Size = New System.Drawing.Size(164, 20)
        Me.txtProductPrice.TabIndex = 40
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Teal
        Me.Label8.Location = New System.Drawing.Point(9, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 18)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Price ($):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Baskerville Old Face", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(144, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 54)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Products"
        '
        'btnDeleteProduct
        '
        Me.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeleteProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteProduct.ForeColor = System.Drawing.Color.White
        Me.btnDeleteProduct.Location = New System.Drawing.Point(193, 206)
        Me.btnDeleteProduct.Name = "btnDeleteProduct"
        Me.btnDeleteProduct.Size = New System.Drawing.Size(75, 38)
        Me.btnDeleteProduct.TabIndex = 37
        Me.btnDeleteProduct.Text = "Delete"
        Me.btnDeleteProduct.UseVisualStyleBackColor = False
        '
        'btnEditProduct
        '
        Me.btnEditProduct.BackColor = System.Drawing.Color.Teal
        Me.btnEditProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditProduct.ForeColor = System.Drawing.Color.White
        Me.btnEditProduct.Location = New System.Drawing.Point(193, 150)
        Me.btnEditProduct.Name = "btnEditProduct"
        Me.btnEditProduct.Size = New System.Drawing.Size(75, 38)
        Me.btnEditProduct.TabIndex = 36
        Me.btnEditProduct.Text = "Edit"
        Me.btnEditProduct.UseVisualStyleBackColor = False
        '
        'btnSaveProduct
        '
        Me.btnSaveProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSaveProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveProduct.ForeColor = System.Drawing.Color.White
        Me.btnSaveProduct.Location = New System.Drawing.Point(193, 94)
        Me.btnSaveProduct.Name = "btnSaveProduct"
        Me.btnSaveProduct.Size = New System.Drawing.Size(75, 38)
        Me.btnSaveProduct.TabIndex = 35
        Me.btnSaveProduct.Text = "Save"
        Me.btnSaveProduct.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(44, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 25)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Product Information"
        '
        'txtProductQty
        '
        Me.txtProductQty.Location = New System.Drawing.Point(9, 163)
        Me.txtProductQty.Name = "txtProductQty"
        Me.txtProductQty.Size = New System.Drawing.Size(164, 20)
        Me.txtProductQty.TabIndex = 33
        '
        'lblProQty
        '
        Me.lblProQty.AutoSize = True
        Me.lblProQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProQty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblProQty.Location = New System.Drawing.Point(9, 144)
        Me.lblProQty.Name = "lblProQty"
        Me.lblProQty.Size = New System.Drawing.Size(66, 18)
        Me.lblProQty.TabIndex = 32
        Me.lblProQty.Text = "Quantity:"
        '
        'lblProCategory
        '
        Me.lblProCategory.AutoSize = True
        Me.lblProCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProCategory.ForeColor = System.Drawing.Color.Teal
        Me.lblProCategory.Location = New System.Drawing.Point(9, 103)
        Me.lblProCategory.Name = "lblProCategory"
        Me.lblProCategory.Size = New System.Drawing.Size(72, 18)
        Me.lblProCategory.TabIndex = 31
        Me.lblProCategory.Text = "Category:"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(9, 82)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(164, 20)
        Me.txtProductName.TabIndex = 30
        '
        'lblProName
        '
        Me.lblProName.AutoSize = True
        Me.lblProName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblProName.Location = New System.Drawing.Point(9, 63)
        Me.lblProName.Name = "lblProName"
        Me.lblProName.Size = New System.Drawing.Size(108, 18)
        Me.lblProName.TabIndex = 29
        Me.lblProName.Text = "Product Name:"
        '
        'PanelProduct
        '
        Me.PanelProduct.BackColor = System.Drawing.Color.Silver
        Me.PanelProduct.Controls.Add(Me.btnEditCat)
        Me.PanelProduct.Controls.Add(Me.cbProductCat)
        Me.PanelProduct.Controls.Add(Me.cbProdSupID)
        Me.PanelProduct.Controls.Add(Me.lblSupId)
        Me.PanelProduct.Controls.Add(Me.txtSupplierName)
        Me.PanelProduct.Controls.Add(Me.lblSupName)
        Me.PanelProduct.Controls.Add(Me.txtProductPrice)
        Me.PanelProduct.Controls.Add(Me.Label8)
        Me.PanelProduct.Controls.Add(Me.btnDeleteProduct)
        Me.PanelProduct.Controls.Add(Me.btnEditProduct)
        Me.PanelProduct.Controls.Add(Me.btnSaveProduct)
        Me.PanelProduct.Controls.Add(Me.Label6)
        Me.PanelProduct.Controls.Add(Me.txtProductQty)
        Me.PanelProduct.Controls.Add(Me.lblProQty)
        Me.PanelProduct.Controls.Add(Me.lblProCategory)
        Me.PanelProduct.Controls.Add(Me.txtProductName)
        Me.PanelProduct.Controls.Add(Me.lblProName)
        Me.PanelProduct.Location = New System.Drawing.Point(9, 108)
        Me.PanelProduct.Name = "PanelProduct"
        Me.PanelProduct.Size = New System.Drawing.Size(293, 366)
        Me.PanelProduct.TabIndex = 48
        '
        'btnEditCat
        '
        Me.btnEditCat.BackColor = System.Drawing.Color.Teal
        Me.btnEditCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditCat.ForeColor = System.Drawing.Color.White
        Me.btnEditCat.Location = New System.Drawing.Point(193, 262)
        Me.btnEditCat.Name = "btnEditCat"
        Me.btnEditCat.Size = New System.Drawing.Size(89, 44)
        Me.btnEditCat.TabIndex = 46
        Me.btnEditCat.Text = "Edit Category"
        Me.btnEditCat.UseVisualStyleBackColor = False
        '
        'cbProductCat
        '
        Me.cbProductCat.FormattingEnabled = True
        Me.cbProductCat.Location = New System.Drawing.Point(9, 125)
        Me.cbProductCat.Name = "cbProductCat"
        Me.cbProductCat.Size = New System.Drawing.Size(164, 21)
        Me.cbProductCat.TabIndex = 45
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox2.Image = Global.pos1.My.Resources.Resources.no1
        Me.PictureBox2.Location = New System.Drawing.Point(845, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 49
        Me.PictureBox2.TabStop = False
        '
        'dgvProduct
        '
        Me.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduct.GridColor = System.Drawing.Color.Silver
        Me.dgvProduct.Location = New System.Drawing.Point(308, 108)
        Me.dgvProduct.Name = "dgvProduct"
        Me.dgvProduct.Size = New System.Drawing.Size(574, 366)
        Me.dgvProduct.TabIndex = 50
        '
        'Pos_SystemDataSet
        '
        Me.Pos_SystemDataSet.DataSetName = "Pos_SystemDataSet"
        Me.Pos_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PosSystemDataSetBindingSource
        '
        Me.PosSystemDataSetBindingSource.DataSource = Me.Pos_SystemDataSet
        Me.PosSystemDataSetBindingSource.Position = 0
        '
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(893, 480)
        Me.Controls.Add(Me.dgvProduct)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PanelProduct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmProduct"
        Me.PanelProduct.ResumeLayout(False)
        Me.PanelProduct.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pos_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PosSystemDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cbProdSupID As ComboBox
    Friend WithEvents lblSupId As Label
    Friend WithEvents txtSupplierName As TextBox
    Friend WithEvents lblSupName As Label
    Friend WithEvents txtProductPrice As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDeleteProduct As Button
    Friend WithEvents btnEditProduct As Button
    Friend WithEvents btnSaveProduct As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtProductQty As TextBox
    Friend WithEvents lblProQty As Label
    Friend WithEvents lblProCategory As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents lblProName As Label
    Friend WithEvents PanelProduct As Panel
    Friend WithEvents dgvProduct As DataGridView
    Friend WithEvents PosSystemDataSetBindingSource As BindingSource
    Friend WithEvents Pos_SystemDataSet As Pos_SystemDataSet
    Friend WithEvents cbProductCat As ComboBox
    Friend WithEvents btnEditCat As Button
End Class
