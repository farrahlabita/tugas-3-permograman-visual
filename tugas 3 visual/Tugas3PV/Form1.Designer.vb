<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SubarrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubenumerationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubconstantsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubstructuresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(57, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(482, 74)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CHAPTER 5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WORKING WITH DATA STRUCTURES"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubarrayToolStripMenuItem, Me.SubenumerationsToolStripMenuItem, Me.SubconstantsToolStripMenuItem, Me.SubstructuresToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(602, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SubarrayToolStripMenuItem
        '
        Me.SubarrayToolStripMenuItem.Name = "SubarrayToolStripMenuItem"
        Me.SubarrayToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.SubarrayToolStripMenuItem.Text = "subarray"
        '
        'SubenumerationsToolStripMenuItem
        '
        Me.SubenumerationsToolStripMenuItem.Name = "SubenumerationsToolStripMenuItem"
        Me.SubenumerationsToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.SubenumerationsToolStripMenuItem.Text = "subenumerations"
        '
        'SubconstantsToolStripMenuItem
        '
        Me.SubconstantsToolStripMenuItem.Name = "SubconstantsToolStripMenuItem"
        Me.SubconstantsToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.SubconstantsToolStripMenuItem.Text = "subconstants"
        '
        'SubstructuresToolStripMenuItem
        '
        Me.SubstructuresToolStripMenuItem.Name = "SubstructuresToolStripMenuItem"
        Me.SubstructuresToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.SubstructuresToolStripMenuItem.Text = "substructures"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 302)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Bab 5"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SubarrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubenumerationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubconstantsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubstructuresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubarraylistToolStripMenuItem As ToolStripMenuItem
End Class
