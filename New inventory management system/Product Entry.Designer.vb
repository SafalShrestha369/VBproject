<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product_Entry
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
        Me.ProductEntryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnPNew = New System.Windows.Forms.Button()
        Me.btnPUpdate = New System.Windows.Forms.Button()
        Me.btnPDelete = New System.Windows.Forms.Button()
        Me.btnPSave = New System.Windows.Forms.Button()
        Me.DateTimePickerExpire = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerEntry = New System.Windows.Forms.DateTimePicker()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtBlock = New System.Windows.Forms.TextBox()
        Me.txtPname = New System.Windows.Forms.TextBox()
        Me.txtPid = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BlockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntryDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpiryDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductEntryBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RealProjectDataSet7 = New New_inventory_management_system.RealProjectDataSet7()
        Me.ProductEntryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RealProjectDataSet1 = New New_inventory_management_system.RealProjectDataSet1()
        Me.Product_entryTableAdapter = New New_inventory_management_system.RealProjectDataSet1TableAdapters.Product_entryTableAdapter()
        Me.RealProjectDataSet5 = New New_inventory_management_system.RealProjectDataSet5()
        Me.ProductEntryBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Product_entryTableAdapter1 = New New_inventory_management_system.RealProjectDataSet5TableAdapters.Product_entryTableAdapter()
        Me.Product_entryTableAdapter2 = New New_inventory_management_system.RealProjectDataSet7TableAdapters.Product_entryTableAdapter()
        CType(Me.ProductEntryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductEntryBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RealProjectDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductEntryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RealProjectDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RealProjectDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductEntryBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductEntryBindingSource
        '
        Me.ProductEntryBindingSource.DataMember = "Product entry"
        '
        'btnPNew
        '
        Me.btnPNew.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPNew.Location = New System.Drawing.Point(131, 369)
        Me.btnPNew.Name = "btnPNew"
        Me.btnPNew.Size = New System.Drawing.Size(75, 30)
        Me.btnPNew.TabIndex = 33
        Me.btnPNew.Text = "New"
        Me.btnPNew.UseVisualStyleBackColor = True
        '
        'btnPUpdate
        '
        Me.btnPUpdate.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPUpdate.Location = New System.Drawing.Point(31, 369)
        Me.btnPUpdate.Name = "btnPUpdate"
        Me.btnPUpdate.Size = New System.Drawing.Size(75, 30)
        Me.btnPUpdate.TabIndex = 32
        Me.btnPUpdate.Text = "Update"
        Me.btnPUpdate.UseVisualStyleBackColor = True
        '
        'btnPDelete
        '
        Me.btnPDelete.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPDelete.Location = New System.Drawing.Point(131, 322)
        Me.btnPDelete.Name = "btnPDelete"
        Me.btnPDelete.Size = New System.Drawing.Size(75, 30)
        Me.btnPDelete.TabIndex = 31
        Me.btnPDelete.Text = "Delete"
        Me.btnPDelete.UseVisualStyleBackColor = True
        '
        'btnPSave
        '
        Me.btnPSave.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPSave.Location = New System.Drawing.Point(31, 322)
        Me.btnPSave.Name = "btnPSave"
        Me.btnPSave.Size = New System.Drawing.Size(75, 30)
        Me.btnPSave.TabIndex = 30
        Me.btnPSave.Text = "Save"
        Me.btnPSave.UseVisualStyleBackColor = True
        '
        'DateTimePickerExpire
        '
        Me.DateTimePickerExpire.Location = New System.Drawing.Point(143, 261)
        Me.DateTimePickerExpire.Name = "DateTimePickerExpire"
        Me.DateTimePickerExpire.Size = New System.Drawing.Size(164, 22)
        Me.DateTimePickerExpire.TabIndex = 29
        '
        'DateTimePickerEntry
        '
        Me.DateTimePickerEntry.Location = New System.Drawing.Point(143, 208)
        Me.DateTimePickerEntry.MaxDate = New Date(2026, 2, 5, 0, 0, 0, 0)
        Me.DateTimePickerEntry.Name = "DateTimePickerEntry"
        Me.DateTimePickerEntry.Size = New System.Drawing.Size(164, 22)
        Me.DateTimePickerEntry.TabIndex = 28
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(160, 169)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtPrice.TabIndex = 27
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(160, 141)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 22)
        Me.txtWeight.TabIndex = 26
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(160, 113)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 22)
        Me.txtQuantity.TabIndex = 25
        '
        'txtBlock
        '
        Me.txtBlock.Location = New System.Drawing.Point(160, 82)
        Me.txtBlock.Name = "txtBlock"
        Me.txtBlock.Size = New System.Drawing.Size(100, 22)
        Me.txtBlock.TabIndex = 24
        '
        'txtPname
        '
        Me.txtPname.Location = New System.Drawing.Point(160, 54)
        Me.txtPname.Name = "txtPname"
        Me.txtPname.Size = New System.Drawing.Size(100, 22)
        Me.txtPname.TabIndex = 23
        '
        'txtPid
        '
        Me.txtPid.Location = New System.Drawing.Point(160, 26)
        Me.txtPid.Name = "txtPid"
        Me.txtPid.Size = New System.Drawing.Size(100, 22)
        Me.txtPid.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 266)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 24)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Expire Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 24)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Entry Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 24)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 24)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Weight"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 24)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 24)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Block"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 24)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Product Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 24)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Product Id"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PIdDataGridViewTextBoxColumn, Me.PNameDataGridViewTextBoxColumn, Me.BlockDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.WeightDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.EntryDateDataGridViewTextBoxColumn, Me.ExpiryDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductEntryBindingSource3
        Me.DataGridView1.Location = New System.Drawing.Point(340, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(822, 283)
        Me.DataGridView1.TabIndex = 34
        '
        'PIdDataGridViewTextBoxColumn
        '
        Me.PIdDataGridViewTextBoxColumn.DataPropertyName = "PId"
        Me.PIdDataGridViewTextBoxColumn.HeaderText = "PId"
        Me.PIdDataGridViewTextBoxColumn.Name = "PIdDataGridViewTextBoxColumn"
        '
        'PNameDataGridViewTextBoxColumn
        '
        Me.PNameDataGridViewTextBoxColumn.DataPropertyName = "PName"
        Me.PNameDataGridViewTextBoxColumn.HeaderText = "PName"
        Me.PNameDataGridViewTextBoxColumn.Name = "PNameDataGridViewTextBoxColumn"
        '
        'BlockDataGridViewTextBoxColumn
        '
        Me.BlockDataGridViewTextBoxColumn.DataPropertyName = "Block"
        Me.BlockDataGridViewTextBoxColumn.HeaderText = "Block"
        Me.BlockDataGridViewTextBoxColumn.Name = "BlockDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "Weight"
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "Weight"
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'EntryDateDataGridViewTextBoxColumn
        '
        Me.EntryDateDataGridViewTextBoxColumn.DataPropertyName = "EntryDate"
        Me.EntryDateDataGridViewTextBoxColumn.HeaderText = "EntryDate"
        Me.EntryDateDataGridViewTextBoxColumn.Name = "EntryDateDataGridViewTextBoxColumn"
        '
        'ExpiryDateDataGridViewTextBoxColumn
        '
        Me.ExpiryDateDataGridViewTextBoxColumn.DataPropertyName = "ExpiryDate"
        Me.ExpiryDateDataGridViewTextBoxColumn.HeaderText = "ExpiryDate"
        Me.ExpiryDateDataGridViewTextBoxColumn.Name = "ExpiryDateDataGridViewTextBoxColumn"
        '
        'ProductEntryBindingSource3
        '
        Me.ProductEntryBindingSource3.DataMember = "Product entry"
        Me.ProductEntryBindingSource3.DataSource = Me.RealProjectDataSet7
        '
        'RealProjectDataSet7
        '
        Me.RealProjectDataSet7.DataSetName = "RealProjectDataSet7"
        Me.RealProjectDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductEntryBindingSource1
        '
        Me.ProductEntryBindingSource1.DataMember = "Product entry"
        Me.ProductEntryBindingSource1.DataSource = Me.RealProjectDataSet1
        '
        'RealProjectDataSet1
        '
        Me.RealProjectDataSet1.DataSetName = "RealProjectDataSet1"
        Me.RealProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Product_entryTableAdapter
        '
        Me.Product_entryTableAdapter.ClearBeforeFill = True
        '
        'RealProjectDataSet5
        '
        Me.RealProjectDataSet5.DataSetName = "RealProjectDataSet5"
        Me.RealProjectDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductEntryBindingSource2
        '
        Me.ProductEntryBindingSource2.DataMember = "Product entry"
        Me.ProductEntryBindingSource2.DataSource = Me.RealProjectDataSet5
        '
        'Product_entryTableAdapter1
        '
        Me.Product_entryTableAdapter1.ClearBeforeFill = True
        '
        'Product_entryTableAdapter2
        '
        Me.Product_entryTableAdapter2.ClearBeforeFill = True
        '
        'Product_Entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 653)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnPNew)
        Me.Controls.Add(Me.btnPUpdate)
        Me.Controls.Add(Me.btnPDelete)
        Me.Controls.Add(Me.btnPSave)
        Me.Controls.Add(Me.DateTimePickerExpire)
        Me.Controls.Add(Me.DateTimePickerEntry)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtBlock)
        Me.Controls.Add(Me.txtPname)
        Me.Controls.Add(Me.txtPid)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Product_Entry"
        Me.Text = "Product_Entry"
        CType(Me.ProductEntryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductEntryBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RealProjectDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductEntryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RealProjectDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RealProjectDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductEntryBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductEntryBindingSource As BindingSource
    Friend WithEvents btnPNew As Button
    Friend WithEvents btnPUpdate As Button
    Friend WithEvents btnPDelete As Button
    Friend WithEvents btnPSave As Button
    Friend WithEvents DateTimePickerExpire As DateTimePicker
    Friend WithEvents DateTimePickerEntry As DateTimePicker
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtBlock As TextBox
    Friend WithEvents txtPname As TextBox
    Friend WithEvents txtPid As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RealProjectDataSet1 As RealProjectDataSet1
    Friend WithEvents ProductEntryBindingSource1 As BindingSource
    Friend WithEvents Product_entryTableAdapter As RealProjectDataSet1TableAdapters.Product_entryTableAdapter
    Friend WithEvents PIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BlockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EntryDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExpiryDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RealProjectDataSet5 As RealProjectDataSet5
    Friend WithEvents ProductEntryBindingSource2 As BindingSource
    Friend WithEvents Product_entryTableAdapter1 As RealProjectDataSet5TableAdapters.Product_entryTableAdapter
    Friend WithEvents RealProjectDataSet7 As RealProjectDataSet7
    Friend WithEvents ProductEntryBindingSource3 As BindingSource
    Friend WithEvents Product_entryTableAdapter2 As RealProjectDataSet7TableAdapters.Product_entryTableAdapter
End Class
