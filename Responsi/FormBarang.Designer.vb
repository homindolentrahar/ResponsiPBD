<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.id_barang_field = New System.Windows.Forms.TextBox()
        Me.id_merk_field = New System.Windows.Forms.TextBox()
        Me.nama_barang_field = New System.Windows.Forms.TextBox()
        Me.deskripsi_field = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.data_barang_grid = New System.Windows.Forms.DataGridView()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        CType(Me.data_barang_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Merk"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Deskripsi"
        '
        'id_barang_field
        '
        Me.id_barang_field.Location = New System.Drawing.Point(140, 28)
        Me.id_barang_field.Name = "id_barang_field"
        Me.id_barang_field.Size = New System.Drawing.Size(125, 27)
        Me.id_barang_field.TabIndex = 4
        '
        'id_merk_field
        '
        Me.id_merk_field.Location = New System.Drawing.Point(140, 74)
        Me.id_merk_field.Name = "id_merk_field"
        Me.id_merk_field.Size = New System.Drawing.Size(125, 27)
        Me.id_merk_field.TabIndex = 5
        '
        'nama_barang_field
        '
        Me.nama_barang_field.Location = New System.Drawing.Point(140, 114)
        Me.nama_barang_field.Name = "nama_barang_field"
        Me.nama_barang_field.Size = New System.Drawing.Size(125, 27)
        Me.nama_barang_field.TabIndex = 6
        '
        'deskripsi_field
        '
        Me.deskripsi_field.Location = New System.Drawing.Point(140, 159)
        Me.deskripsi_field.Name = "deskripsi_field"
        Me.deskripsi_field.Size = New System.Drawing.Size(125, 27)
        Me.deskripsi_field.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(558, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "List Merk"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(558, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Chitato     101"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(558, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "So Nice     102"
        '
        'data_barang_grid
        '
        Me.data_barang_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_barang_grid.Location = New System.Drawing.Point(34, 219)
        Me.data_barang_grid.Name = "data_barang_grid"
        Me.data_barang_grid.RowHeadersWidth = 51
        Me.data_barang_grid.RowTemplate.Height = 29
        Me.data_barang_grid.Size = New System.Drawing.Size(743, 314)
        Me.data_barang_grid.TabIndex = 11
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(287, 26)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(94, 29)
        Me.BtnTambah.TabIndex = 12
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(287, 72)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(94, 29)
        Me.BtnUpdate.TabIndex = 13
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(287, 112)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(94, 29)
        Me.BtnHapus.TabIndex = 14
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(287, 157)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(94, 29)
        Me.BtnClear.TabIndex = 15
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 561)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.data_barang_grid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.deskripsi_field)
        Me.Controls.Add(Me.nama_barang_field)
        Me.Controls.Add(Me.id_merk_field)
        Me.Controls.Add(Me.id_barang_field)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormBarang"
        Me.Text = "Form Barang"
        CType(Me.data_barang_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents id_barang_field As TextBox
    Friend WithEvents id_merk_field As TextBox
    Friend WithEvents nama_barang_field As TextBox
    Friend WithEvents deskripsi_field As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents data_barang_grid As DataGridView
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnClear As Button
End Class
