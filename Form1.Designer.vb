<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBoxTablas = New System.Windows.Forms.ListBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.CheckBoxGuardar = New System.Windows.Forms.CheckBox()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignaturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MatriculasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBoxTablas
        '
        Me.ListBoxTablas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxTablas.FormattingEnabled = True
        Me.ListBoxTablas.ItemHeight = 20
        Me.ListBoxTablas.Location = New System.Drawing.Point(27, 47)
        Me.ListBoxTablas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBoxTablas.Name = "ListBoxTablas"
        Me.ListBoxTablas.Size = New System.Drawing.Size(151, 64)
        Me.ListBoxTablas.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(199, 47)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(747, 273)
        Me.DataGridView1.TabIndex = 1
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.Location = New System.Drawing.Point(27, 241)
        Me.ButtonGuardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(155, 42)
        Me.ButtonGuardar.TabIndex = 2
        Me.ButtonGuardar.Text = "Guardar Cambios"
        Me.ButtonGuardar.UseVisualStyleBackColor = True
        '
        'CheckBoxGuardar
        '
        Me.CheckBoxGuardar.AutoSize = True
        Me.CheckBoxGuardar.Location = New System.Drawing.Point(199, 326)
        Me.CheckBoxGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxGuardar.Name = "CheckBoxGuardar"
        Me.CheckBoxGuardar.Size = New System.Drawing.Size(267, 21)
        Me.CheckBoxGuardar.TabIndex = 3
        Me.CheckBoxGuardar.Text = "Guardar cambios  al cambiar de tabla"
        Me.CheckBoxGuardar.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(27, 305)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(155, 42)
        Me.ButtonClose.TabIndex = 4
        Me.ButtonClose.Text = "Salir sin guardar"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlumnosToolStripMenuItem, Me.AsignaturasToolStripMenuItem, Me.MatriculasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(972, 28)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AlumnosToolStripMenuItem
        '
        Me.AlumnosToolStripMenuItem.Name = "AlumnosToolStripMenuItem"
        Me.AlumnosToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.AlumnosToolStripMenuItem.Text = "Alumnos"
        '
        'AsignaturasToolStripMenuItem
        '
        Me.AsignaturasToolStripMenuItem.Name = "AsignaturasToolStripMenuItem"
        Me.AsignaturasToolStripMenuItem.Size = New System.Drawing.Size(100, 24)
        Me.AsignaturasToolStripMenuItem.Text = "Asignaturas"
        '
        'MatriculasToolStripMenuItem
        '
        Me.MatriculasToolStripMenuItem.Name = "MatriculasToolStripMenuItem"
        Me.MatriculasToolStripMenuItem.Size = New System.Drawing.Size(91, 24)
        Me.MatriculasToolStripMenuItem.Text = "Matriculas"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 378)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.CheckBoxGuardar)
        Me.Controls.Add(Me.ButtonGuardar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ListBoxTablas)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Mantenimiento Escuela"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxTablas As ListBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents CheckBoxGuardar As CheckBox
    Friend WithEvents ButtonClose As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AlumnosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsignaturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MatriculasToolStripMenuItem As ToolStripMenuItem
End Class
