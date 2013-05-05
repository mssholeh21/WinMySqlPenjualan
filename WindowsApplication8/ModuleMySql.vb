
Imports MySql.Data.MySqlClient

Module ModuleTrunojoyo
    Private Const CONS_STRING As String = "server=localhost;userid=root;password=root;database=dbtrunojoyo"
    Public SqlConnection As New MySqlConnection(CONS_STRING)
    Public SqlCommand As New MySqlCommand
    Public SqlDataAdapter As New MySqlDataAdapter
    Public CurentDataSet As New DataSet
    Public SqlDataReader As MySqlDataReader
    Public RandomNumber As Integer
    Public cek As MySqlDataReader
End Module
