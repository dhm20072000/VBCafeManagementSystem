<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Items
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Items))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ItemDGV = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CatTb = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.CatCb = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ItNameTb = New System.Windows.Forms.TextBox()
        Me.QuantityTb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ItPriceTb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.ItemDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.ItemDGV)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.CatTb)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(132, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(853, 527)
        Me.Panel1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(484, 51)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(176, 34)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = " Delete Category"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label7.Location = New System.Drawing.Point(374, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 24)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Items List"
        '
        'ItemDGV
        '
        Me.ItemDGV.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.ItemDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ItemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemDGV.Location = New System.Drawing.Point(48, 289)
        Me.ItemDGV.Name = "ItemDGV"
        Me.ItemDGV.RowTemplate.Height = 25
        Me.ItemDGV.Size = New System.Drawing.Size(751, 217)
        Me.ItemDGV.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(263, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 34)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Add Category"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(48, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 21)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Name"
        '
        'CatTb
        '
        Me.CatTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CatTb.Location = New System.Drawing.Point(124, 55)
        Me.CatTb.Name = "CatTb"
        Me.CatTb.Size = New System.Drawing.Size(127, 27)
        Me.CatTb.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ResetBtn)
        Me.Panel2.Controls.Add(Me.DeleteBtn)
        Me.Panel2.Controls.Add(Me.EditBtn)
        Me.Panel2.Controls.Add(Me.AddBtn)
        Me.Panel2.Controls.Add(Me.CatCb)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.ItNameTb)
        Me.Panel2.Controls.Add(Me.QuantityTb)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ItPriceTb)
        Me.Panel2.Location = New System.Drawing.Point(48, 98)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(751, 139)
        Me.Panel2.TabIndex = 13
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.ResetBtn.FlatAppearance.BorderSize = 0
        Me.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBtn.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ResetBtn.ForeColor = System.Drawing.Color.White
        Me.ResetBtn.Location = New System.Drawing.Point(506, 94)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(117, 31)
        Me.ResetBtn.TabIndex = 20
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.DeleteBtn.FlatAppearance.BorderSize = 0
        Me.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBtn.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DeleteBtn.ForeColor = System.Drawing.Color.White
        Me.DeleteBtn.Location = New System.Drawing.Point(366, 94)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(117, 31)
        Me.DeleteBtn.TabIndex = 19
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = False
        '
        'EditBtn
        '
        Me.EditBtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.EditBtn.FlatAppearance.BorderSize = 0
        Me.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditBtn.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EditBtn.ForeColor = System.Drawing.Color.White
        Me.EditBtn.Location = New System.Drawing.Point(226, 94)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(117, 31)
        Me.EditBtn.TabIndex = 18
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.UseVisualStyleBackColor = False
        '
        'AddBtn
        '
        Me.AddBtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.AddBtn.FlatAppearance.BorderSize = 0
        Me.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBtn.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AddBtn.ForeColor = System.Drawing.Color.White
        Me.AddBtn.Location = New System.Drawing.Point(87, 94)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(117, 31)
        Me.AddBtn.TabIndex = 17
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = False
        '
        'CatCb
        '
        Me.CatCb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CatCb.FormattingEnabled = True
        Me.CatCb.Location = New System.Drawing.Point(214, 49)
        Me.CatCb.Name = "CatCb"
        Me.CatCb.Size = New System.Drawing.Size(159, 29)
        Me.CatCb.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(214, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 21)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(47, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Name"
        '
        'ItNameTb
        '
        Me.ItNameTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ItNameTb.Location = New System.Drawing.Point(47, 51)
        Me.ItNameTb.Name = "ItNameTb"
        Me.ItNameTb.Size = New System.Drawing.Size(127, 27)
        Me.ItNameTb.TabIndex = 6
        '
        'QuantityTb
        '
        Me.QuantityTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.QuantityTb.Location = New System.Drawing.Point(550, 51)
        Me.QuantityTb.Name = "QuantityTb"
        Me.QuantityTb.Size = New System.Drawing.Size(127, 27)
        Me.QuantityTb.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(403, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(550, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 21)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Quantity"
        '
        'ItPriceTb
        '
        Me.ItPriceTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ItPriceTb.Location = New System.Drawing.Point(403, 51)
        Me.ItPriceTb.Name = "ItPriceTb"
        Me.ItPriceTb.Size = New System.Drawing.Size(127, 27)
        Me.ItPriceTb.TabIndex = 8
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(22, 526)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 22)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Logout"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(950, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(997, 581)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Items"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Items"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ItemDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CatTb As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CatCb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ItNameTb As TextBox
    Friend WithEvents QuantityTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ItPriceTb As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents ItemDGV As DataGridView
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents AddBtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ResetBtn As Button
    Friend WithEvents Button2 As Button
End Class
