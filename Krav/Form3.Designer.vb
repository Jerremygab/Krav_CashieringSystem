<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.ui2 = New System.Windows.Forms.Button()
        Me.ui1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ui2
        '
        Me.ui2.BackColor = System.Drawing.Color.Transparent
        Me.ui2.BackgroundImage = Global.Krav.My.Resources.Resources.BUT
        Me.ui2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ui2.FlatAppearance.BorderSize = 0
        Me.ui2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ui2.Font = New System.Drawing.Font("HGSGyoshotai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ui2.Location = New System.Drawing.Point(632, 365)
        Me.ui2.Name = "ui2"
        Me.ui2.Size = New System.Drawing.Size(124, 113)
        Me.ui2.TabIndex = 353
        Me.ui2.Text = "  SELECT UI"
        Me.ui2.UseVisualStyleBackColor = False
        '
        'ui1
        '
        Me.ui1.BackColor = System.Drawing.Color.Transparent
        Me.ui1.BackgroundImage = Global.Krav.My.Resources.Resources.BUT
        Me.ui1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ui1.FlatAppearance.BorderSize = 0
        Me.ui1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ui1.Font = New System.Drawing.Font("HGSGyoshotai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ui1.Location = New System.Drawing.Point(135, 215)
        Me.ui1.Name = "ui1"
        Me.ui1.Size = New System.Drawing.Size(124, 110)
        Me.ui1.TabIndex = 354
        Me.ui1.Text = "  SELECT UI"
        Me.ui1.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Krav.My.Resources.Resources.bgbgbgbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(859, 710)
        Me.Controls.Add(Me.ui1)
        Me.Controls.Add(Me.ui2)
        Me.DoubleBuffered = True
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ui2 As Button
    Friend WithEvents ui1 As Button
End Class
