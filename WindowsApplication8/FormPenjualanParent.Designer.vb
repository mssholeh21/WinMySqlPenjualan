<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenjualanParent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lbltotqty = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmdcariuser = New System.Windows.Forms.Button
        Me.cmdbaru = New System.Windows.Forms.Button
        Me.txtsalesid = New System.Windows.Forms.TextBox
        Me.txtkanvasnofaktur = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblterbilang = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.btsimpan = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lbltelpon = New System.Windows.Forms.Label
        Me.lblalamat = New System.Windows.Forms.Label
        Me.lblsalesnama = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbltotbay = New System.Windows.Forms.Label
        Me.lbltgl = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.user = New System.Windows.Forms.Label
        Me.dg = New System.Windows.Forms.DataGridView
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(342, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 50)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'lbltotqty
        '
        Me.lbltotqty.AutoSize = True
        Me.lbltotqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotqty.Location = New System.Drawing.Point(16, 40)
        Me.lbltotqty.Name = "lbltotqty"
        Me.lbltotqty.Size = New System.Drawing.Size(0, 20)
        Me.lbltotqty.TabIndex = 0
        Me.lbltotqty.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(117, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(12, 18)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = ":"
        '
        'cmdcariuser
        '
        Me.cmdcariuser.Location = New System.Drawing.Point(232, 56)
        Me.cmdcariuser.Name = "cmdcariuser"
        Me.cmdcariuser.Size = New System.Drawing.Size(43, 21)
        Me.cmdcariuser.TabIndex = 9
        Me.cmdcariuser.Text = "......"
        Me.cmdcariuser.UseVisualStyleBackColor = True
        '
        'cmdbaru
        '
        Me.cmdbaru.Location = New System.Drawing.Point(232, 24)
        Me.cmdbaru.Name = "cmdbaru"
        Me.cmdbaru.Size = New System.Drawing.Size(44, 21)
        Me.cmdbaru.TabIndex = 8
        Me.cmdbaru.Text = "baru"
        Me.cmdbaru.UseVisualStyleBackColor = True
        '
        'txtsalesid
        '
        Me.txtsalesid.Location = New System.Drawing.Point(135, 57)
        Me.txtsalesid.Name = "txtsalesid"
        Me.txtsalesid.Size = New System.Drawing.Size(100, 20)
        Me.txtsalesid.TabIndex = 6
        '
        'txtkanvasnofaktur
        '
        Me.txtkanvasnofaktur.Location = New System.Drawing.Point(135, 24)
        Me.txtkanvasnofaktur.Name = "txtkanvasnofaktur"
        Me.txtkanvasnofaktur.Size = New System.Drawing.Size(100, 20)
        Me.txtkanvasnofaktur.TabIndex = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbltotqty)
        Me.GroupBox3.Location = New System.Drawing.Point(412, 148)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(312, 63)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Quantity"
        '
        'lblterbilang
        '
        Me.lblterbilang.AutoSize = True
        Me.lblterbilang.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblterbilang.Location = New System.Drawing.Point(66, 29)
        Me.lblterbilang.Name = "lblterbilang"
        Me.lblterbilang.Size = New System.Drawing.Size(277, 25)
        Me.lblterbilang.TabIndex = 0
        Me.lblterbilang.Text = "....................................................."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(117, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(12, 18)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(117, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(12, 18)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = ":"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(235, 544)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(166, 31)
        Me.Button4.TabIndex = 48
        Me.Button4.Text = "Input Data Baru"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsimpan.ForeColor = System.Drawing.Color.Black
        Me.btsimpan.Location = New System.Drawing.Point(598, 543)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(156, 32)
        Me.btsimpan.TabIndex = 42
        Me.btsimpan.Text = "Simpan"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbltelpon)
        Me.GroupBox1.Controls.Add(Me.lblalamat)
        Me.GroupBox1.Controls.Add(Me.lblsalesnama)
        Me.GroupBox1.Controls.Add(Me.cmdcariuser)
        Me.GroupBox1.Controls.Add(Me.cmdbaru)
        Me.GroupBox1.Controls.Add(Me.txtsalesid)
        Me.GroupBox1.Controls.Add(Me.txtkanvasnofaktur)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.lbltgl)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(742, 230)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Data Sales"
        '
        'lbltelpon
        '
        Me.lbltelpon.AutoSize = True
        Me.lbltelpon.Location = New System.Drawing.Point(136, 169)
        Me.lbltelpon.Name = "lbltelpon"
        Me.lbltelpon.Size = New System.Drawing.Size(37, 13)
        Me.lbltelpon.TabIndex = 12
        Me.lbltelpon.Text = ".........."
        '
        'lblalamat
        '
        Me.lblalamat.AutoSize = True
        Me.lblalamat.Location = New System.Drawing.Point(136, 134)
        Me.lblalamat.Name = "lblalamat"
        Me.lblalamat.Size = New System.Drawing.Size(37, 13)
        Me.lblalamat.TabIndex = 11
        Me.lblalamat.Text = ".........."
        '
        'lblsalesnama
        '
        Me.lblsalesnama.AutoSize = True
        Me.lblsalesnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsalesnama.Location = New System.Drawing.Point(136, 101)
        Me.lblsalesnama.Name = "lblsalesnama"
        Me.lblsalesnama.Size = New System.Drawing.Size(47, 13)
        Me.lblsalesnama.TabIndex = 10
        Me.lblsalesnama.Text = ".........."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbltotbay)
        Me.GroupBox2.Location = New System.Drawing.Point(412, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(313, 81)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total Harga Barang Kanvas"
        '
        'lbltotbay
        '
        Me.lbltotbay.AutoSize = True
        Me.lbltotbay.Font = New System.Drawing.Font("Arial Black", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotbay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbltotbay.Location = New System.Drawing.Point(11, 16)
        Me.lbltotbay.Name = "lbltotbay"
        Me.lbltotbay.Size = New System.Drawing.Size(0, 52)
        Me.lbltotbay.TabIndex = 0
        Me.lbltotbay.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbltgl
        '
        Me.lbltgl.AutoSize = True
        Me.lbltgl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltgl.ForeColor = System.Drawing.Color.Black
        Me.lbltgl.Location = New System.Drawing.Point(462, 31)
        Me.lbltgl.Name = "lbltgl"
        Me.lbltgl.Size = New System.Drawing.Size(44, 16)
        Me.lbltgl.TabIndex = 2
        Me.lbltgl.Text = "............"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Dokumen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Sales"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(424, 543)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(157, 32)
        Me.Button3.TabIndex = 47
        Me.Button3.Text = "Cetak"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblterbilang)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 248)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(742, 57)
        Me.GroupBox4.TabIndex = 40
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Terbilang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(578, 594)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "User Login :"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(12, 594)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 22)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Keluar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(12, 543)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 32)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Lihat Kode Barang"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'user
        '
        Me.user.AutoSize = True
        Me.user.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.user.Location = New System.Drawing.Point(642, 582)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(117, 33)
        Me.user.TabIndex = 45
        Me.user.Text = "................."
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(11, 19)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(714, 203)
        Me.dg.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dg)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 309)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(742, 228)
        Me.GroupBox5.TabIndex = 41
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Data Produk"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 592)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.GroupBox5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbltotqty As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmdcariuser As System.Windows.Forms.Button
    Friend WithEvents cmdbaru As System.Windows.Forms.Button
    Friend WithEvents txtsalesid As System.Windows.Forms.TextBox
    Friend WithEvents txtkanvasnofaktur As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblterbilang As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltelpon As System.Windows.Forms.Label
    Friend WithEvents lblalamat As System.Windows.Forms.Label
    Friend WithEvents lblsalesnama As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbltotbay As System.Windows.Forms.Label
    Friend WithEvents lbltgl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents user As System.Windows.Forms.Label
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox

End Class
