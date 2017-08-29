<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BasketDisplayForm
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
        Me.viewBasket = New System.Windows.Forms.DataGridView()
        CType(Me.viewBasket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'viewBasket
        '
        Me.viewBasket.AllowUserToAddRows = False
        Me.viewBasket.AllowUserToDeleteRows = False
        Me.viewBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewBasket.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewBasket.Location = New System.Drawing.Point(0, 0)
        Me.viewBasket.Name = "viewBasket"
        Me.viewBasket.ReadOnly = True
        Me.viewBasket.RowTemplate.Height = 24
        Me.viewBasket.Size = New System.Drawing.Size(582, 253)
        Me.viewBasket.TabIndex = 0
        '
        'BasketDisplayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(582, 253)
        Me.Controls.Add(Me.viewBasket)
        Me.Name = "BasketDisplayForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Basket Contents"
        CType(Me.viewBasket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents viewBasket As System.Windows.Forms.DataGridView
End Class
