<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtDir1 = New System.Windows.Forms.TextBox()
        Me.btnCompare = New System.Windows.Forms.Button()
        Me.txtDir2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvFiles = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Dir1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dir2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateMod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateMod2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDir1
        '
        Me.txtDir1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDir1.Location = New System.Drawing.Point(72, 32)
        Me.txtDir1.Name = "txtDir1"
        Me.txtDir1.Size = New System.Drawing.Size(630, 20)
        Me.txtDir1.TabIndex = 2
        '
        'btnCompare
        '
        Me.btnCompare.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCompare.Location = New System.Drawing.Point(323, 56)
        Me.btnCompare.Name = "btnCompare"
        Me.btnCompare.Size = New System.Drawing.Size(64, 40)
        Me.btnCompare.TabIndex = 4
        Me.btnCompare.Text = "Compare"
        Me.btnCompare.UseVisualStyleBackColor = True
        '
        'txtDir2
        '
        Me.txtDir2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDir2.Location = New System.Drawing.Point(72, 8)
        Me.txtDir2.Name = "txtDir2"
        Me.txtDir2.Size = New System.Drawing.Size(630, 20)
        Me.txtDir2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Directory 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Directory 2:"
        '
        'dgvFiles
        '
        Me.dgvFiles.AllowUserToAddRows = False
        Me.dgvFiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFiles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Dir1, Me.Dir2, Me.colDateMod, Me.colDateMod2})
        Me.dgvFiles.Location = New System.Drawing.Point(8, 104)
        Me.dgvFiles.Name = "dgvFiles"
        Me.dgvFiles.Size = New System.Drawing.Size(693, 208)
        Me.dgvFiles.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.Location = New System.Drawing.Point(547, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 39)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Clear Results"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button2.Location = New System.Drawing.Point(97, 58)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 40)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Export"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Dir1
        '
        Me.Dir1.HeaderText = "Directory 1"
        Me.Dir1.Name = "Dir1"
        '
        'Dir2
        '
        Me.Dir2.HeaderText = "Directory 2"
        Me.Dir2.Name = "Dir2"
        '
        'colDateMod
        '
        Me.colDateMod.HeaderText = "Date Modified"
        Me.colDateMod.Name = "colDateMod"
        '
        'colDateMod2
        '
        Me.colDateMod2.HeaderText = "Date Modified 2"
        Me.colDateMod2.Name = "colDateMod2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 320)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvFiles)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCompare)
        Me.Controls.Add(Me.txtDir2)
        Me.Controls.Add(Me.txtDir1)
        Me.Name = "Form1"
        Me.Text = "Bin Comparison Tool"
        CType(Me.dgvFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDir1 As System.Windows.Forms.TextBox
    Friend WithEvents btnCompare As System.Windows.Forms.Button
    Friend WithEvents txtDir2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvFiles As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Dir1 As DataGridViewTextBoxColumn
    Friend WithEvents Dir2 As DataGridViewTextBoxColumn
    Friend WithEvents colDateMod As DataGridViewTextBoxColumn
    Friend WithEvents colDateMod2 As DataGridViewTextBoxColumn
End Class
