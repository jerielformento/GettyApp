<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BreakApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BreakApp))
        Me.cb_pauses = New System.Windows.Forms.ComboBox()
        Me.btn_break = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cb_pauses
        '
        Me.cb_pauses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_pauses.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_pauses.ForeColor = System.Drawing.Color.DimGray
        Me.cb_pauses.Items.AddRange(New Object() {"Short Break", "Bath Break", "Lunch Break", "Tech Issue(Internal)", "Tech Issue(External)", "Admin", "Coaching(IFS)", "Coaching(QA)", "Coaching(Performance)", "Coaching(Others)", "Trng(Trainee)", "Trng(Up train)", "TL Task"})
        Me.cb_pauses.Location = New System.Drawing.Point(20, 30)
        Me.cb_pauses.Name = "cb_pauses"
        Me.cb_pauses.Size = New System.Drawing.Size(303, 27)
        Me.cb_pauses.TabIndex = 0
        '
        'btn_break
        '
        Me.btn_break.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_break.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_break.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_break.ForeColor = System.Drawing.Color.AliceBlue
        Me.btn_break.Location = New System.Drawing.Point(219, 63)
        Me.btn_break.Name = "btn_break"
        Me.btn_break.Size = New System.Drawing.Size(104, 28)
        Me.btn_break.TabIndex = 5
        Me.btn_break.Text = "Start Break"
        Me.btn_break.UseVisualStyleBackColor = False
        '
        'BreakApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(350, 117)
        Me.Controls.Add(Me.btn_break)
        Me.Controls.Add(Me.cb_pauses)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(356, 145)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(356, 145)
        Me.Name = "BreakApp"
        Me.Text = "Pause"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cb_pauses As System.Windows.Forms.ComboBox
    Friend WithEvents btn_break As System.Windows.Forms.Button
End Class
