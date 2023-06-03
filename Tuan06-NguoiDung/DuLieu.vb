Imports System.Data.OleDb

Module DuLieu
    Public conn_string As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=True"

    Public Function DocCauTruc(ByVal select_command As String) As DataTable
        Dim connection As OleDbConnection = New OleDbConnection(conn_string)
        Dim command As OleDbCommand = New OleDbCommand(select_command, connection)
        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(command)
        Dim table As DataTable = New DataTable()
        adapter.FillSchema(table, SchemaType.Source)
        Return table
    End Function

    Public Function DocDuLieu(ByVal select_command As String) As DataTable
        Dim connection As OleDbConnection = New OleDbConnection(conn_string)
        Dim command As OleDbCommand = New OleDbCommand(select_command, connection)
        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(command)
        Dim table As DataTable = New DataTable()
        adapter.Fill(table)
        Return table
    End Function

    Public Sub GhiDuLieu(ByVal ten_bang As String, ByVal table As DataTable)
        Dim connection As OleDbConnection = New OleDbConnection(conn_string)
        Dim sql As String = String.Format("SELECT * FROM {0}", ten_bang)
        Dim select_command As OleDbCommand = New OleDbCommand(sql, connection)
        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(select_command)
        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(adapter)
        AddHandler adapter.RowUpdated, AddressOf CapNhatMaSo
        adapter.Update(table)
    End Sub

    Private Sub CapNhatMaSo(ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)
        Dim connection As OleDbConnection = e.Command.Connection
        If e.StatementType = StatementType.Insert Then
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT @@IDENTITY", connection)
            Dim maso As Integer = Integer.Parse(cmd.ExecuteScalar())
            e.Row(0) = maso
        End If
    End Sub
End Module
