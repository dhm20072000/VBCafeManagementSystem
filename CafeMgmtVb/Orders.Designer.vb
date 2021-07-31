<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Orders))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ItemDGV = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TotalLbl = New System.Windows.Forms.Label()
        Me.AddBillBtn = New System.Windows.Forms.Button()
        Me.QuantityTb = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.CatCb = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BillDGV = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.ItemDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.ItemDGV)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.TotalLbl)
        Me.Panel1.Controls.Add(Me.AddBillBtn)
        Me.Panel1.Controls.Add(Me.QuantityTb)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.CatCb)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.BillDGV)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(122, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(853, 527)
        Me.Panel1.TabIndex = 1
        '
        'ItemDGV
        '
        Me.ItemDGV.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.ItemDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ItemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemDGV.Location = New System.Drawing.Point(299, 75)
        Me.ItemDGV.Name = "ItemDGV"
        Me.ItemDGV.RowTemplate.Height = 25
        Me.ItemDGV.Size = New System.Drawing.Size(551, 129)
        Me.ItemDGV.TabIndex = 29
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(564, 477)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 34)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "View Orders"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(344, 477)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 34)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TotalLbl
        '
        Me.TotalLbl.AutoSize = True
        Me.TotalLbl.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TotalLbl.ForeColor = System.Drawing.Color.SteelBlue
        Me.TotalLbl.Location = New System.Drawing.Point(478, 484)
        Me.TotalLbl.Name = "TotalLbl"
        Me.TotalLbl.Size = New System.Drawing.Size(49, 21)
        Me.TotalLbl.TabIndex = 26
        Me.TotalLbl.Text = "Total"
        '
        'AddBillBtn
        '
        Me.AddBillBtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.AddBillBtn.FlatAppearance.BorderSize = 0
        Me.AddBillBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBillBtn.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AddBillBtn.ForeColor = System.Drawing.Color.White
        Me.AddBillBtn.Location = New System.Drawing.Point(697, 206)
        Me.AddBillBtn.Name = "AddBillBtn"
        Me.AddBillBtn.Size = New System.Drawing.Size(117, 31)
        Me.AddBillBtn.TabIndex = 19
        Me.AddBillBtn.Text = "Add To Bill"
        Me.AddBillBtn.UseVisualStyleBackColor = False
        '
        'QuantityTb
        '
        Me.QuantityTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.QuantityTb.Location = New System.Drawing.Point(564, 208)
        Me.QuantityTb.Name = "QuantityTb"
        Me.QuantityTb.Size = New System.Drawing.Size(127, 27)
        Me.QuantityTb.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label10.Location = New System.Drawing.Point(478, 214)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 21)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Quantity"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label9.Location = New System.Drawing.Point(508, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 24)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Item List"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(168, 48)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(105, 34)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "Refresh"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'CatCb
        '
        Me.CatCb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CatCb.FormattingEnabled = True
        Me.CatCb.Location = New System.Drawing.Point(3, 52)
        Me.CatCb.Name = "CatCb"
        Me.CatCb.Size = New System.Drawing.Size(159, 29)
        Me.CatCb.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label7.Location = New System.Drawing.Point(357, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 24)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Your Order"
        '
        'BillDGV
        '
        Me.BillDGV.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.BillDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BillDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BillDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.BillDGV.Location = New System.Drawing.Point(51, 311)
        Me.BillDGV.Name = "BillDGV"
        Me.BillDGV.RowTemplate.Height = 25
        Me.BillDGV.Size = New System.Drawing.Size(751, 160)
        Me.BillDGV.TabIndex = 17
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Product"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Price"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Quantity"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total"
        Me.Column5.Name = "Column5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(374, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Manage Items"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(23, 501)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 22)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Logout"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(962, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(997, 581)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Orders"
        Me.Text = "Orders"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ItemDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents AddBillBtn As Button
    Friend WithEvents QuantityTb As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents CatCb As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BillDGV As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TotalLbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ItemDGV As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
