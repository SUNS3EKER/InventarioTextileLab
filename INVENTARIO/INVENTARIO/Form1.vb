Imports System.Data.OleDb

Public Class Form1
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kalel\Desktop\INVENTARIO\InventarioTextilelab.accdb"
    Private dataAdapter As OleDbDataAdapter
    Private dataSet As DataSet

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub


    Private Sub autoconteo()
        If CBregistro.Checked = True Then
            Try
                Using connection As New OleDbConnection(connectionString)
                    connection.Open()
                    Using command As New OleDbCommand("SELECT MAX(Registro) FROM Inventario", connection)
                        Dim result = command.ExecuteScalar()
                        If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                            TBregistro.Text = (Convert.ToInt32(result) + 1).ToString()
                        Else
                            TBregistro.Text = "1"
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al obtener el siguiente ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub AutoConteoInvertido()
        If CBregistro.Checked Then
            Try
                Using connection As New OleDbConnection(connectionString)
                    connection.Open()
                    Using command As New OleDbCommand("SELECT MAX(Registro) FROM Inventario WHERE Registro < ?", connection)
                        command.Parameters.AddWithValue("?", TBregistro.Text)
                        Dim result = command.ExecuteScalar()
                        If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                            TBregistro.Text = result.ToString()
                        Else
                            TBregistro.Text = ""
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al obtener el ID anterior: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub



    Private Sub LoadData()
        Try
            Using connection As New OleDbConnection(connectionString)
                dataAdapter = New OleDbDataAdapter("SELECT * FROM Inventario", connection)
                dataSet = New DataSet()
                dataAdapter.Fill(dataSet, "Inventario")
                DataGridView1.DataSource = dataSet.Tables("Inventario")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TBregistro.Text = selectedRow.Cells("Registro").Value.ToString()
            CBXmodelo.Text = selectedRow.Cells("Modelo").Value.ToString()
            CBXcolor.Text = selectedRow.Cells("Color").Value.ToString()
        End If
    End Sub

    Private Sub BTcrear_Click(sender As Object, e As EventArgs) Handles BTcrear.Click
        Try
            If CBregistro.Checked = True Then
                autoconteo()
            End If

            If String.IsNullOrWhiteSpace(TBregistro.Text) OrElse
               String.IsNullOrWhiteSpace(CBXmodelo.Text) OrElse
               String.IsNullOrWhiteSpace(CBXcolor.Text) Then
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Using command As New OleDbCommand("INSERT INTO Inventario (Registro, Modelo, Color) VALUES (?, ?, ?)", connection)
                    command.Parameters.AddWithValue("?", TBregistro.Text)
                    command.Parameters.AddWithValue("?", CBXmodelo.Text)
                    command.Parameters.AddWithValue("?", CBXcolor.Text)
                    command.ExecuteNonQuery()
                End Using
            End Using

            LoadData()
            autoconteo()


        Catch ex As Exception
            MessageBox.Show("Error al insertar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub BTactualizar_Click(sender As Object, e As EventArgs) Handles BTactualizar.Click
        Try
            If String.IsNullOrWhiteSpace(TBregistro.Text) Then
                MessageBox.Show("Debes seleccionar un registro para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Using command As New OleDbCommand("UPDATE Inventario SET Modelo = ?, Color = ? WHERE Registro = ?", connection)
                    command.Parameters.AddWithValue("?", CBXmodelo.Text)
                    command.Parameters.AddWithValue("?", CBXcolor.Text)
                    command.Parameters.AddWithValue("?", TBregistro.Text)
                    command.ExecuteNonQuery()
                End Using
            End Using

            LoadData()

        Catch ex As Exception
            MessageBox.Show("Error al actualizar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTborrar_Click(sender As Object, e As EventArgs) Handles BTborrar.Click
        Try
            If String.IsNullOrWhiteSpace(TBregistro.Text) Then
                MessageBox.Show("Debe seleccionar un registro para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Using connection As New OleDbConnection(connectionString)
                    connection.Open()
                    Using command As New OleDbCommand("DELETE FROM Inventario WHERE Registro = ?", connection)
                        command.Parameters.AddWithValue("?", TBregistro.Text)
                        command.ExecuteNonQuery()
                    End Using
                End Using

                LoadData()
                AutoConteoInvertido()

            End If

        Catch ex As Exception
            MessageBox.Show("Error al eliminar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTbuscar_Click(sender As Object, e As EventArgs) Handles BTbuscar.Click
        Try
            If String.IsNullOrWhiteSpace(TBregistro.Text) Then
                MessageBox.Show("Debe ingresar un ID para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Using connection As New OleDbConnection(connectionString)
                Dim query As String = "SELECT * FROM Inventario WHERE Registro = ?"
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("?", TBregistro.Text)
                    connection.Open()
                    Using reader As OleDbDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            CBXmodelo.Text = reader("Modelo").ToString()
                            CBXcolor.Text = reader("Color").ToString()
                        Else
                            MessageBox.Show("No se encontró ningún registro con ese ID.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al buscar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
