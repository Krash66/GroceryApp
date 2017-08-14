<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GroceryItemForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemView = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblBrandName = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblAisle = New System.Windows.Forms.Label()
        Me.numPrice = New System.Windows.Forms.NumericUpDown()
        Me.grpDescription = New System.Windows.Forms.GroupBox()
        Me.txtDescription = New System.Windows.Forms.RichTextBox()
        Me.btnAddToBasket = New System.Windows.Forms.Button()
        Me.cboAisle = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtScanNumber = New System.Windows.Forms.TextBox()
        Me.txtBrandName = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDescription.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(496, 31)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemExit})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(108, 27)
        Me.ToolStripMenuItem1.Text = "&Application"
        '
        'ToolStripMenuItemExit
        '
        Me.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit"
        Me.ToolStripMenuItemExit.Size = New System.Drawing.Size(107, 28)
        Me.ToolStripMenuItemExit.Text = "E&xit"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemAdd, Me.ToolStripMenuItemView})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(71, 27)
        Me.ToolStripMenuItem2.Text = "&Basket"
        '
        'ToolStripMenuItemAdd
        '
        Me.ToolStripMenuItemAdd.Name = "ToolStripMenuItemAdd"
        Me.ToolStripMenuItemAdd.Size = New System.Drawing.Size(116, 28)
        Me.ToolStripMenuItemAdd.Text = "A&dd"
        '
        'ToolStripMenuItemView
        '
        Me.ToolStripMenuItemView.Name = "ToolStripMenuItemView"
        Me.ToolStripMenuItemView.Size = New System.Drawing.Size(116, 28)
        Me.ToolStripMenuItemView.Text = "&View"
        '
        'lblBrandName
        '
        Me.lblBrandName.AutoSize = True
        Me.lblBrandName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrandName.Location = New System.Drawing.Point(42, 125)
        Me.lblBrandName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBrandName.Name = "lblBrandName"
        Me.lblBrandName.Size = New System.Drawing.Size(53, 20)
        Me.lblBrandName.TabIndex = 2
        Me.lblBrandName.Text = "&Name"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(42, 165)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(48, 20)
        Me.lblPrice.TabIndex = 3
        Me.lblPrice.Text = "&Price"
        '
        'lblAisle
        '
        Me.lblAisle.AutoSize = True
        Me.lblAisle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAisle.Location = New System.Drawing.Point(42, 201)
        Me.lblAisle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAisle.Name = "lblAisle"
        Me.lblAisle.Size = New System.Drawing.Size(46, 20)
        Me.lblAisle.TabIndex = 4
        Me.lblAisle.Text = "A&isle"
        '
        'numPrice
        '
        Me.numPrice.DecimalPlaces = 2
        Me.numPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPrice.Location = New System.Drawing.Point(152, 163)
        Me.numPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.numPrice.Name = "numPrice"
        Me.numPrice.Size = New System.Drawing.Size(312, 24)
        Me.numPrice.TabIndex = 1
        '
        'grpDescription
        '
        Me.grpDescription.Controls.Add(Me.txtDescription)
        Me.grpDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDescription.Location = New System.Drawing.Point(41, 231)
        Me.grpDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDescription.Name = "grpDescription"
        Me.grpDescription.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDescription.Size = New System.Drawing.Size(424, 110)
        Me.grpDescription.TabIndex = 3
        Me.grpDescription.TabStop = False
        Me.grpDescription.Text = "&Description"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescription.Location = New System.Drawing.Point(4, 24)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(416, 82)
        Me.txtDescription.TabIndex = 3
        Me.txtDescription.Text = ""
        '
        'btnAddToBasket
        '
        Me.btnAddToBasket.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToBasket.Location = New System.Drawing.Point(41, 355)
        Me.btnAddToBasket.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddToBasket.Name = "btnAddToBasket"
        Me.btnAddToBasket.Size = New System.Drawing.Size(424, 28)
        Me.btnAddToBasket.TabIndex = 5
        Me.btnAddToBasket.Text = "A&dd to Basket"
        Me.btnAddToBasket.UseVisualStyleBackColor = True
        '
        'cboAisle
        '
        Me.cboAisle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAisle.FormattingEnabled = True
        Me.cboAisle.Items.AddRange(New Object() {" Bakery", " CannedGood", " Drinks", " Deli", " DryGoods", " FrozenFood", " Produce"})
        Me.cboAisle.Location = New System.Drawing.Point(153, 198)
        Me.cboAisle.Margin = New System.Windows.Forms.Padding(4)
        Me.cboAisle.Name = "cboAisle"
        Me.cboAisle.Size = New System.Drawing.Size(311, 26)
        Me.cboAisle.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 87)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "&Scan"
        '
        'txtScanNumber
        '
        Me.txtScanNumber.BackColor = System.Drawing.SystemColors.Window
        Me.txtScanNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScanNumber.Location = New System.Drawing.Point(153, 84)
        Me.txtScanNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtScanNumber.Name = "txtScanNumber"
        Me.txtScanNumber.ReadOnly = True
        Me.txtScanNumber.Size = New System.Drawing.Size(311, 24)
        Me.txtScanNumber.TabIndex = 12
        Me.txtScanNumber.TabStop = False
        '
        'txtBrandName
        '
        Me.txtBrandName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrandName.Location = New System.Drawing.Point(153, 122)
        Me.txtBrandName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBrandName.Name = "txtBrandName"
        Me.txtBrandName.Size = New System.Drawing.Size(311, 24)
        Me.txtBrandName.TabIndex = 0
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblUser.Location = New System.Drawing.Point(46, 49)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(0, 18)
        Me.lblUser.TabIndex = 13
        '
        'GroceryItemForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 411)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.txtBrandName)
        Me.Controls.Add(Me.txtScanNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboAisle)
        Me.Controls.Add(Me.btnAddToBasket)
        Me.Controls.Add(Me.grpDescription)
        Me.Controls.Add(Me.numPrice)
        Me.Controls.Add(Me.lblAisle)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblBrandName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "GroceryItemForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grocery Item"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDescription.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblBrandName As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblAisle As System.Windows.Forms.Label
    Friend WithEvents numPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents grpDescription As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddToBasket As System.Windows.Forms.Button
    Friend WithEvents cboAisle As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtScanNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtBrandName As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents ToolStripMenuItemExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblUser As System.Windows.Forms.Label
End Class
