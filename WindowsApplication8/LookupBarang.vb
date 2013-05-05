Public Class LookupBarang

    'Dim i As Integer
    Private mForm1 As FormPenjualanParent

    Friend Property FormParent() As FormPenjualanParent
        Get
            Return mForm1
        End Get
        Set(ByVal value As FormPenjualanParent)
            mForm1 = value
        End Set
    End Property

    Sub Tampilbarang(ByVal sql As String)
        SqlConnection.Open()
        SqlCommand.Connection = SqlConnection
        SqlCommand.CommandType = CommandType.Text
        SqlCommand.CommandText = sql
        SqlDataAdapter.SelectCommand = SqlCommand
        CurentDataSet.Tables.Clear()
        SqlDataAdapter.Fill(CurentDataSet, "barang")
        dgv.DataSource = (CurentDataSet.Tables("barang"))
        SqlConnection.Close()

    End Sub

    Sub Muncul()
        SqlConnection.Open()
        SqlCommand.Connection = SqlConnection
        SqlCommand.CommandType = CommandType.Text
        SqlCommand.CommandText = "select barang.barangid, barang.barangnama, barang.jumlah, barang.harga from barang"
        SqlDataAdapter.SelectCommand = SqlCommand

        CurentDataSet.Tables.Clear()
        SqlDataAdapter.Fill(CurentDataSet, "barang")
        dgv.DataSource = CurentDataSet.Tables("barang")
        SqlConnection.Close()

    End Sub



    Private Sub TxtcaribarangTextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtcaribarang.TextChanged
        tampilbarang(String.Format("select barang.barangid, barang.barangnama, barang.jumlah, barang.harga from barang where barangnama like '%{0}%' or barangid like '%{0}%'", txtcaribarang.Text))
    End Sub

    Private Sub FormCariBarangLoad(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        muncul()
    End Sub

    Private Sub DgvCellClick(ByVal sender As Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellClick

        Dim i = dgv.CurrentRow.Index
        Dim x = FormParent.dg.RowCount - 1
        FormParent.dg.Rows(x).Cells(0).Value = dgv.Rows.Item(i).Cells(0).Value
        FormParent.dg.Rows(x).Cells(1).Value = dgv.Rows.Item(i).Cells(1).Value
        FormParent.dg.Rows(x).Cells(2).Value = dgv.Rows.Item(i).Cells(2).Value
        FormParent.dg.Rows(x).Cells(3).Value = dgv.Rows.Item(i).Cells(3).Value

        Close()
        Dim cell = FormParent.dg.Rows(x).Cells(4)
        FormParent.dg.CurrentCell = cell
        FormParent.dg.BeginEdit(True)
    End Sub

    Private Sub Button2Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button2.Click
        Dispose()
    End Sub
End Class