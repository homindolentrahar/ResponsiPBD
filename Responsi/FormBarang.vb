Imports System.Data.SqlClient

Public Class FormBarang
    Dim connectionString As String = "Data Source=DESKTOP-N3C1S9B;Initial catalog=PBD_0172;Integrated Security=True"
    Dim Connection As New SqlConnection(connectionString)

    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBarang()
    End Sub

    Private Sub ClearFields()
        id_barang_field.Clear()
        id_merk_field.Clear()
        nama_barang_field.Clear()
        deskripsi_field.Clear()
    End Sub

    Private Sub LoadBarang()
        Connection.Open()

        Dim Sql As String = "SELECT * FROM vTampilBarang"
        Dim DataAdapter As New SqlDataAdapter(Sql, Connection)
        Dim DS As New DataSet()

        DataAdapter.Fill(DS, "vTampilBarang")
        data_barang_grid.DataSource = DS
        data_barang_grid.DataMember = "vTampilBarang"
        Connection.Close()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Connection.Open()

        Dim command As SqlCommand = New SqlCommand("sp_InsertBarang", Connection)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@IdBarang", SqlDbType.VarChar).Value = id_barang_field.Text.Trim()
        command.Parameters.AddWithValue("@IdMerk", SqlDbType.VarChar).Value = id_merk_field.Text.Trim()
        command.Parameters.AddWithValue("@Nama", SqlDbType.VarChar).Value = nama_barang_field.Text.Trim()
        command.Parameters.AddWithValue("@Deskripsi", SqlDbType.VarChar).Value = deskripsi_field.Text.Trim()

        command.ExecuteNonQuery()

        MessageBox.Show("Barang added!")
        ClearFields()

        Connection.Close()

        LoadBarang()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Connection.Open()

        Dim command As SqlCommand = New SqlCommand("sp_UpdateBarang", Connection)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@IdBarang", SqlDbType.VarChar).Value = id_barang_field.Text.Trim()
        command.Parameters.AddWithValue("@IdMerk", SqlDbType.VarChar).Value = id_merk_field.Text.Trim()
        command.Parameters.AddWithValue("@Nama", SqlDbType.VarChar).Value = nama_barang_field.Text.Trim()
        command.Parameters.AddWithValue("@Deskripsi", SqlDbType.VarChar).Value = deskripsi_field.Text.Trim()

        command.ExecuteNonQuery()

        MessageBox.Show("Barang updated!")
        ClearFields()

        Connection.Close()

        LoadBarang()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Connection.Open()

        Dim command As SqlCommand = New SqlCommand("sp_DeleteBarang", Connection)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@IdBarang", SqlDbType.VarChar).Value = id_barang_field.Text.Trim()

        command.ExecuteNonQuery()

        MessageBox.Show("Barang deleted!")
        ClearFields()

        Connection.Close()

        LoadBarang()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ClearFields()
    End Sub
End Class
