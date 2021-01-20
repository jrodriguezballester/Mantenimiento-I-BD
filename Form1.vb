Imports MySql.Data.MySqlClient

Public Class Form1
    ' Base de datos
    ReadOnly servidor = "localhost"
    ReadOnly nameDB = "dbescuela"
    Dim usuario = "root"
    Dim pswd = "root"
    ' Variables generales
    Dim sql1, sql2, sql3 As String
    Dim adapter1, adapter2, adapter3 As MySqlDataAdapter
    Dim cmdBuilder1, cmdBuilder2, cmdBuilder3 As MySqlCommandBuilder
    Dim ds As New DataSet
    Dim changes As DataSet

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As MySqlConnection
        connection = New MySqlConnection("Server=" & servidor & "; Database=" & nameDB & "; Uid=" & usuario & ";Pwd=" & pswd)

        sql1 = "select * from asignaturas"
        sql2 = "select * from alumnos"
        sql3 = "select * from matriculas"

        With ListBoxTablas.Items
            .Add("asignaturas")
            .Add("alumnos")
            .Add("matriculas")
        End With

        Try
            connection.Open()

            adapter1 = New MySqlDataAdapter(sql1, connection)
            adapter2 = New MySqlDataAdapter(sql2, connection)
            adapter3 = New MySqlDataAdapter(sql3, connection)

            adapter1.Fill(ds, "asignaturas")
            adapter2.Fill(ds, "alumnos")
            adapter3.Fill(ds, "matriculas")

            cmdBuilder1 = New MySqlCommandBuilder(adapter1)
            cmdBuilder2 = New MySqlCommandBuilder(adapter2)
            cmdBuilder3 = New MySqlCommandBuilder(adapter3)

            connection.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Guardar()
    End Sub

    Private Sub AlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlumnosToolStripMenuItem.Click
        If CheckBoxGuardar.Checked Then Guardar()
        FormularioAlumno()
    End Sub

    Private Sub AsignaturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignaturasToolStripMenuItem.Click
        If CheckBoxGuardar.Checked Then Guardar()
        FormularioAsignaturas()
    End Sub

    Private Sub MatriculasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatriculasToolStripMenuItem.Click
        If CheckBoxGuardar.Checked Then Guardar()
        FormularioMatriculas()
    End Sub

    Private Sub Guardar()
        Try
            changes = ds.GetChanges()

            If changes IsNot Nothing Then
                adapter1.Update(ds, "asignaturas")
                adapter2.Update(ds, "alumnos")
                adapter3.Update(ds, "matriculas")
                ds.AcceptChanges()
                MsgBox("Cambios guardados")
            End If
            ds.AcceptChanges()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub FormularioTabla(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxTablas.SelectedIndexChanged
        If CheckBoxGuardar.Checked Then Guardar()

        Dim curItem As String = ListBoxTablas.SelectedItem.ToString()
        Select Case curItem
            Case "alumnos"
                FormularioAlumno()
            Case "asignaturas"
                FormularioAsignaturas()
            Case "matriculas"
                FormularioMatriculas()
            Case Else
                MsgBox("none")
        End Select
    End Sub
    Private Sub FormularioAlumno()
        DataGridView1.DataSource = ds.Tables("alumnos")
        DataGridView1.Columns("id").Visible = True
        DataGridView1.Columns("id").ReadOnly = True
    End Sub
    Private Sub FormularioAsignaturas()
        DataGridView1.DataSource = ds.Tables("asignaturas")
        DataGridView1.Columns("id").Visible = True
        DataGridView1.Columns("id").ReadOnly = False
    End Sub
    Private Sub FormularioMatriculas()
        DataGridView1.DataSource = ds.Tables("matriculas")
        DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        changes = ds.GetChanges()

        If changes IsNot Nothing Then
            Dim result As DialogResult = MessageBox.Show("Seguro que quiere salir sin guardar los cambios", "Ojo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = DialogResult.Yes Then
                Close()
            End If
        Else
            Close()
        End If

    End Sub

End Class
