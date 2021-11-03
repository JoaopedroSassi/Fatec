<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_clientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_clientes))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_cell_phone = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_home_phone = New System.Windows.Forms.MaskedTextBox()
        Me.txt_uf = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_city = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_district = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_complement = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_date = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.pic_photo = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_data = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_create = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_search = New System.Windows.Forms.ToolStripTextBox()
        Me.btn_search = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.pic_photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 34)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(685, 361)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_email)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txt_cell_phone)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txt_home_phone)
        Me.TabPage1.Controls.Add(Me.txt_uf)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txt_city)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txt_district)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txt_complement)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txt_address)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txt_cep)
        Me.TabPage1.Controls.Add(Me.txt_name)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txt_date)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txt_cpf)
        Me.TabPage1.Controls.Add(Me.pic_photo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(677, 333)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados Pessoais"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(277, 286)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(379, 23)
        Me.txt_email.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(277, 266)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 17)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Email"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(175, 266)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 17)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Celular"
        '
        'txt_cell_phone
        '
        Me.txt_cell_phone.Location = New System.Drawing.Point(175, 286)
        Me.txt_cell_phone.Mask = "(99) 99999-9999"
        Me.txt_cell_phone.Name = "txt_cell_phone"
        Me.txt_cell_phone.Size = New System.Drawing.Size(92, 23)
        Me.txt_cell_phone.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(65, 266)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Residencial"
        '
        'txt_home_phone
        '
        Me.txt_home_phone.Location = New System.Drawing.Point(65, 286)
        Me.txt_home_phone.Mask = "(99) 9999-9999"
        Me.txt_home_phone.Name = "txt_home_phone"
        Me.txt_home_phone.Size = New System.Drawing.Size(90, 23)
        Me.txt_home_phone.TabIndex = 4
        '
        'txt_uf
        '
        Me.txt_uf.Location = New System.Drawing.Point(533, 231)
        Me.txt_uf.Name = "txt_uf"
        Me.txt_uf.Size = New System.Drawing.Size(23, 23)
        Me.txt_uf.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(533, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "UF"
        '
        'txt_city
        '
        Me.txt_city.Location = New System.Drawing.Point(187, 231)
        Me.txt_city.Name = "txt_city"
        Me.txt_city.Size = New System.Drawing.Size(90, 23)
        Me.txt_city.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(187, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Cidade"
        '
        'txt_district
        '
        Me.txt_district.Location = New System.Drawing.Point(297, 231)
        Me.txt_district.Name = "txt_district"
        Me.txt_district.Size = New System.Drawing.Size(209, 23)
        Me.txt_district.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(297, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Bairro"
        '
        'txt_complement
        '
        Me.txt_complement.Location = New System.Drawing.Point(65, 231)
        Me.txt_complement.Name = "txt_complement"
        Me.txt_complement.Size = New System.Drawing.Size(105, 23)
        Me.txt_complement.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(65, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Complemento"
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(156, 179)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(400, 23)
        Me.txt_address.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(156, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Endereço"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(65, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "CEP"
        '
        'txt_cep
        '
        Me.txt_cep.Location = New System.Drawing.Point(65, 179)
        Me.txt_cep.Mask = "99999-999"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(64, 23)
        Me.txt_cep.TabIndex = 2
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(65, 122)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(428, 23)
        Me.txt_name.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(65, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nome do cliente"
        '
        'txt_date
        '
        Me.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date.Location = New System.Drawing.Point(369, 66)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(124, 23)
        Me.txt_date.TabIndex = 98
        Me.txt_date.Value = New Date(2021, 10, 25, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(369, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data de nascimento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(65, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CPF do cliente"
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(65, 66)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(82, 23)
        Me.txt_cpf.TabIndex = 0
        Me.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pic_photo
        '
        Me.pic_photo.Image = CType(resources.GetObject("pic_photo.Image"), System.Drawing.Image)
        Me.pic_photo.Location = New System.Drawing.Point(509, 32)
        Me.pic_photo.Name = "pic_photo"
        Me.pic_photo.Size = New System.Drawing.Size(147, 141)
        Me.pic_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_photo.TabIndex = 0
        Me.pic_photo.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_data)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(677, 333)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Listagem de Clientes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_data
        '
        Me.dgv_data.AllowUserToAddRows = False
        Me.dgv_data.AllowUserToDeleteRows = False
        Me.dgv_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_data.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgv_data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_data.Location = New System.Drawing.Point(3, 3)
        Me.dgv_data.Name = "dgv_data"
        Me.dgv_data.ReadOnly = True
        Me.dgv_data.RowTemplate.Height = 25
        Me.dgv_data.Size = New System.Drawing.Size(671, 327)
        Me.dgv_data.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "N°"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 46
        '
        'Column2
        '
        Me.Column2.HeaderText = "Cpf"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 51
        '
        'Column3
        '
        Me.Column3.HeaderText = "Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 64
        '
        'Column4
        '
        Me.Column4.HeaderText = "Edit"
        Me.Column4.Image = CType(resources.GetObject("Column4.Image"), System.Drawing.Image)
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 33
        '
        'Column5
        '
        Me.Column5.HeaderText = "Delete"
        Me.Column5.Image = CType(resources.GetObject("Column5.Image"), System.Drawing.Image)
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 46
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_create, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.txt_search, Me.btn_search})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(706, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_create
        '
        Me.btn_create.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_create.Image = CType(resources.GetObject("btn_create.Image"), System.Drawing.Image)
        Me.btn_create.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(23, 22)
        Me.btn_create.Text = "ToolStripButton1"
        Me.btn_create.ToolTipText = "Create"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.ToolTipText = "Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(170, 22)
        Me.ToolStripLabel1.Text = "Digite um parâmetro de busca:"
        '
        'txt_search
        '
        Me.txt_search.Name = "txt_search"
        Me.txt_search.ShortcutsEnabled = False
        Me.txt_search.Size = New System.Drawing.Size(100, 25)
        '
        'btn_search
        '
        Me.btn_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_search.Image = CType(resources.GetObject("btn_search.Image"), System.Drawing.Image)
        Me.btn_search.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(23, 22)
        Me.btn_search.Text = "ToolStripButton3"
        Me.btn_search.ToolTipText = "Search"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 405)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frm_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_clientes"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.pic_photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents pic_photo As PictureBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_date As DateTimePicker
    Friend WithEvents txt_address As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_home_phone As MaskedTextBox
    Friend WithEvents txt_uf As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_city As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_district As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_complement As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_cell_phone As MaskedTextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents dgv_data As DataGridView
    Friend WithEvents btn_create As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_search As ToolStripTextBox
    Friend WithEvents btn_search As ToolStripButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
End Class
