Public Class FormPenjualanParent
    Dim i As Integer
    Dim kode, kodebaru, tgl As String
    Dim no As Integer

    Function Num2Word(ByVal n As Double) As String

        Dim satuan As String() = {"", "Satu", "Dua", "Tiga", "Empat", "Lima", "Enam", "Tujuh", "Delapan", "Sembilan", "Sepuluh", "Sebelas"}
        Select Case n
            Case 0 To 11
                num2word = " " + satuan(Fix(n))
            Case 12 To 19
                num2word = (num2word(n Mod 10) + " Belas")
            Case 20 To 99
                num2word = num2word(Fix(n / 10)) + " Puluh" + num2word(n Mod 10)
            Case 100 To 199
                num2word = " Seratus" + num2word(n - 100)
            Case 200 To 999
                num2word = num2word(Fix(n / 100)) + " Ratus" + num2word(n Mod 100)
            Case 1000 To 1999
                num2word = " Seribu" + num2word(n - 1000)
            Case 2000 To 999999
                num2word = num2word(Fix(n / 1000)) + " Ribu" + num2word(n Mod 1000)
            Case 1000000 To 999999999
                num2word = num2word(Fix(n / 1000000)) + " Juta" + num2word(n Mod 1000000)
            Case 1000000000 To 999999999999
                num2word = num2word(Fix(n / 1000000000)) + " Milyar" + num2word(n Mod 1000000000)
            Case Else
                num2word = num2word(Fix(n / 1000000000000)) + " Trilyun" + num2word(n Mod 1000000000000)

        End Select
    End Function

    Sub Buatkolom()
        dg.Columns.Add("kode", "Kode Barang")
        dg.Columns.Add("nama", "Nama Barang")
        dg.Columns.Add("stok", "Jumlah Stok")
        dg.Columns.Add("harga", "Harga Jual")
        dg.Columns.Add("jualqty", "Jumlah Keluar")
        dg.Columns.Add("subtotal", "Sub Total (Rp)")


        dg.Columns(0).Width = 80
        dg.Columns(1).Width = 170
        dg.Columns(2).Width = 90
        dg.Columns(3).Width = 100
        dg.Columns(4).Width = 90
        dg.Columns(5).Width = 140



        dg.Columns(1).ReadOnly = True
        dg.Columns(2).ReadOnly = True
        dg.Columns(3).ReadOnly = True
        dg.Columns(5).ReadOnly = True


    End Sub


    Sub Hitungtotal()
        Dim total As Double
        For i As Integer = 0 To dg.Rows.Count - 1
            total = total + dg.Rows(i).Cells(5).Value
        Next
        lbltotbay.Text = Format(total, "Rp ###,###,###")
        lblterbilang.Text = UCase(Num2Word(total)) & " RUPIAH"

    End Sub


    Sub hitungtotqty()
        Dim totqty As Double
        For i As Integer = 0 To dg.Rows.Count - 1
            totqty = totqty + dg.Rows(i).Cells(4).Value
        Next
        lbltotqty.Text = totqty


    End Sub

    Sub simpantransaksi()
        Try
            For i = 0 To dg.Rows.Count - 1
                SqlConnection.Open()
                SqlCommand.Connection = SqlConnection
                SqlCommand.CommandType = CommandType.Text
                SqlCommand.CommandText = "insert into kanvas (kanvasnofaktur,kanvastgl,kanvasuserid,kanvasbarangid,kanvasharga,kanvasqty,kanvasuserinput) Values ('" & txtkanvasnofaktur.Text & "', now(),'" & txtsalesid.Text & "','" & dg.Rows.Item(i).Cells(0).Value & "', '" & dg.Rows.Item(i).Cells(3).Value & "','" & dg.Rows.Item(i).Cells(4).Value & "','" & user.Text & "')"
                SqlCommand.ExecuteNonQuery()
                SqlConnection.Close()

            Next
        Catch ex As Exception

        End Try
    End Sub

    Sub kosong()

        txtsalesid.Text = ""
        lblsalesnama.Text = ""
        lblalamat.Text = ""
        lbltelpon.Text = ""
        lbltotbay.Text = ""
        lbltotqty.Text = ""

    End Sub

    Sub buatfaktur()
        tgl = Format(Now, "ddMMyyyy")
        SqlConnection.Close()
        SqlConnection.Open()
        SqlCommand.Connection = SqlConnection
        SqlCommand.CommandType = CommandType.Text
        SqlCommand.CommandText = "select kanvasnofaktur from kanvas order by kanvasnofaktur desc limit 1"
        SqlDataReader = SqlCommand.ExecuteReader()
        SqlDataReader.Read()
        If SqlDataReader.HasRows Then
            kode = SqlDataReader.Item("kanvasnofaktur")
            no = Val(Microsoft.VisualBasic.Mid(kode, 3, 4))
            no = (no + 1)
            kodebaru = "K-" + Format(no, "0000") + tgl
            txtkanvasnofaktur.Text = kodebaru
        Else
            txtkanvasnofaktur.Text = "K-0001" + tgl

        End If
        SqlDataReader.Close()
        SqlConnection.Close()

    End Sub
    Private Sub FormKanvas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call buatkolom()
        Button3.Enabled = False
        Button4.Enabled = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbltgl.Text = Format(Now, "dd MMMM yyyy") & " - " & Format(Now, "H : mm : ss")
    End Sub



    Private Sub dg_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellEndEdit
        If e.ColumnIndex = 0 Then
            SqlConnection.Open()
            SqlCommand.Connection = SqlConnection
            SqlCommand.CommandType = CommandType.Text
            SqlCommand.CommandText = "Select barang.barangid, barang.barangnama, barang.jumlah, barang.harga from barang where barangid='" & dg.Rows(e.RowIndex).Cells(0).Value & " '"

            SqlDataReader = SqlCommand.ExecuteReader
            SqlDataReader.Read()
            If SqlDataReader.HasRows Then
                'menampilkan data pada kolom di datagrid
                dg.Rows(e.RowIndex).Cells(1).Value = SqlDataReader.Item("barangnama")
                dg.Rows(e.RowIndex).Cells(2).Value = SqlDataReader.Item("jumlah")
                dg.Rows(e.RowIndex).Cells(3).Value = SqlDataReader.Item("harga")

            Else
                MsgBox("Data Barang Tidak Ada", MsgBoxStyle.Information, "Informasi")

            End If
            SqlDataReader.Close()
            SqlConnection.Close()

        End If

        If dg.Rows(e.RowIndex).Cells(4).Value > dg.Rows(e.RowIndex).Cells(2).Value Then
            MsgBox("Jumlah Barang Tidak Mencukupi", MsgBoxStyle.Information, "Informasi")
            dg.Rows(e.RowIndex).Cells(4).Value = 0
        End If



        If e.ColumnIndex = 4 Then
            dg.CurrentRow.Cells(5).Value = dg.CurrentRow.Cells(3).Value * dg.CurrentRow.Cells(4).Value
            Call hitungtotal()
            Call hitungtotqty()

        End If
    End Sub

    Private Sub cmdbaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbaru.Click
        Call buatfaktur()
    End Sub




    Private Sub txtkanvasid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsalesid.KeyPress
        If e.KeyChar = Chr(13) Then
            SqlConnection.Open()
            SqlCommand.Connection = SqlConnection
            SqlCommand.CommandType = CommandType.Text
            SqlCommand.CommandText = "select *from user where username='" & txtsalesid.Text & "'"
            SqlDataReader = SqlCommand.ExecuteReader
            SqlDataReader.Read()
            If SqlDataReader.HasRows Then
                lblsalesnama.Text = SqlDataReader.Item("userfullname")
            Else
                MsgBox("Kode Sales Tidak Ada", MsgBoxStyle.Information, "Informasi")

            End If
            SqlConnection.Close()

        End If
    End Sub



    Private Sub btsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsimpan.Click

        Call simpantransaksi()
        MsgBox("Data Sukses Tersimpan", MsgBoxStyle.Information, "Informasi")


        Call buatkolom()
        SqlConnection.Close()
        Button3.Enabled = True
        Button4.Enabled = True


    End Sub



    Private Sub Button1Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
        Dim mform As New LookupBarang
        mform.FormParent = Me
        mform.Show(Me)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()

    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        kosong()
        dg.Columns.Clear()
        Call buatkolom()
        SqlConnection.Close()
        Button3.Enabled = False
        txtkanvasnofaktur.Text = ""
        Button4.Enabled = False
    End Sub
End Class
