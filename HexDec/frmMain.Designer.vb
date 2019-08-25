<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HexDec
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblHex = New System.Windows.Forms.Label()
        Me.lblDec = New System.Windows.Forms.Label()
        Me.txtDec = New System.Windows.Forms.TextBox()
        Me.txtHex = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblHex
        '
        Me.lblHex.AutoSize = True
        Me.lblHex.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHex.Location = New System.Drawing.Point(77, 9)
        Me.lblHex.Name = "lblHex"
        Me.lblHex.Size = New System.Drawing.Size(48, 24)
        Me.lblHex.TabIndex = 0
        Me.lblHex.Text = "Hex"
        '
        'lblDec
        '
        Me.lblDec.AutoSize = True
        Me.lblDec.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDec.Location = New System.Drawing.Point(269, 9)
        Me.lblDec.Name = "lblDec"
        Me.lblDec.Size = New System.Drawing.Size(85, 24)
        Me.lblDec.TabIndex = 1
        Me.lblDec.Text = "Decimal"
        '
        'txtDec
        '
        Me.txtDec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDec.Location = New System.Drawing.Point(219, 36)
        Me.txtDec.Name = "txtDec"
        Me.txtDec.Size = New System.Drawing.Size(177, 26)
        Me.txtDec.TabIndex = 2
        '
        'txtHex
        '
        Me.txtHex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHex.Location = New System.Drawing.Point(12, 36)
        Me.txtHex.Name = "txtHex"
        Me.txtHex.Size = New System.Drawing.Size(179, 26)
        Me.txtHex.TabIndex = 3
        '
        'HexDec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 80)
        Me.Controls.Add(Me.txtHex)
        Me.Controls.Add(Me.txtDec)
        Me.Controls.Add(Me.lblDec)
        Me.Controls.Add(Me.lblHex)
        Me.Name = "HexDec"
        Me.Text = "HexDec"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHex As Label
    Friend WithEvents lblDec As Label
    Friend WithEvents txtDec As TextBox
    Friend WithEvents txtHex As TextBox
End Class
