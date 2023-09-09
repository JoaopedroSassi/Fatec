<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        TabPages = New TabControl()
        TabPage1 = New TabPage()
        BtnSalvar = New Button()
        GroupBox1 = New GroupBox()
        Label7 = New Label()
        TxtLiquido = New TextBox()
        Label6 = New Label()
        TxtINSS = New TextBox()
        Label5 = New Label()
        TxtBruto = New TextBox()
        Label4 = New Label()
        TxtSalarios = New TextBox()
        DtpData = New DateTimePicker()
        Label3 = New Label()
        Label2 = New Label()
        CmbCargo = New ComboBox()
        PicFoto = New PictureBox()
        TxtNome = New TextBox()
        Label1 = New Label()
        TabPage2 = New TabPage()
        TxtPesquisa = New TextBox()
        DgvDados = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewImageColumn()
        Column7 = New DataGridViewImageColumn()
        OpenFileDialog1 = New OpenFileDialog()
        TabPages.SuspendLayout()
        TabPage1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PicFoto, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(DgvDados, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabPages
        ' 
        TabPages.Controls.Add(TabPage1)
        TabPages.Controls.Add(TabPage2)
        TabPages.Location = New Point(12, 12)
        TabPages.Name = "TabPages"
        TabPages.SelectedIndex = 0
        TabPages.Size = New Size(806, 439)
        TabPages.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(BtnSalvar)
        TabPage1.Controls.Add(GroupBox1)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(TxtSalarios)
        TabPage1.Controls.Add(DtpData)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(CmbCargo)
        TabPage1.Controls.Add(PicFoto)
        TabPage1.Controls.Add(TxtNome)
        TabPage1.Controls.Add(Label1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(798, 411)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Dados funcionário"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' BtnSalvar
        ' 
        BtnSalvar.FlatAppearance.BorderColor = Color.Black
        BtnSalvar.FlatStyle = FlatStyle.Flat
        BtnSalvar.ForeColor = Color.Black
        BtnSalvar.Location = New Point(653, 321)
        BtnSalvar.Name = "BtnSalvar"
        BtnSalvar.Size = New Size(75, 23)
        BtnSalvar.TabIndex = 10
        BtnSalvar.Text = "Salvar"
        BtnSalvar.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(TxtLiquido)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TxtINSS)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(TxtBruto)
        GroupBox1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(38, 257)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(576, 134)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Demonstrativo de Pagamentos"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(366, 44)
        Label7.Name = "Label7"
        Label7.Size = New Size(106, 20)
        Label7.TabIndex = 15
        Label7.Text = "Salário líquido"
        ' 
        ' TxtLiquido
        ' 
        TxtLiquido.Enabled = False
        TxtLiquido.Location = New Point(366, 75)
        TxtLiquido.Name = "TxtLiquido"
        TxtLiquido.Size = New Size(149, 27)
        TxtLiquido.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(191, 44)
        Label6.Name = "Label6"
        Label6.Size = New Size(40, 20)
        Label6.TabIndex = 13
        Label6.Text = "INSS"
        ' 
        ' TxtINSS
        ' 
        TxtINSS.Enabled = False
        TxtINSS.Location = New Point(191, 75)
        TxtINSS.Name = "TxtINSS"
        TxtINSS.Size = New Size(149, 27)
        TxtINSS.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(22, 44)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 20)
        Label5.TabIndex = 11
        Label5.Text = "Salário bruto"
        ' 
        ' TxtBruto
        ' 
        TxtBruto.Enabled = False
        TxtBruto.Location = New Point(22, 75)
        TxtBruto.Name = "TxtBruto"
        TxtBruto.Size = New Size(149, 27)
        TxtBruto.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(38, 190)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 20)
        Label4.TabIndex = 8
        Label4.Text = "Salários"
        ' 
        ' TxtSalarios
        ' 
        TxtSalarios.Location = New Point(38, 213)
        TxtSalarios.Name = "TxtSalarios"
        TxtSalarios.Size = New Size(171, 23)
        TxtSalarios.TabIndex = 7
        ' 
        ' DtpData
        ' 
        DtpData.Location = New Point(257, 140)
        DtpData.Name = "DtpData"
        DtpData.Size = New Size(212, 23)
        DtpData.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(257, 111)
        Label3.Name = "Label3"
        Label3.Size = New Size(131, 20)
        Label3.TabIndex = 5
        Label3.Text = "Data de Admissão"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(38, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 4
        Label2.Text = "Cargo"
        ' 
        ' CmbCargo
        ' 
        CmbCargo.FormattingEnabled = True
        CmbCargo.Items.AddRange(New Object() {"Analista Sênior", "Desenvolvedor C#", "Quality Assurence", "Desenvolvedor PHP", "Scrum Master", "Desenvolvedor JAVA", "Desenvolvedor Node JS", "Product Owner"})
        CmbCargo.Location = New Point(38, 143)
        CmbCargo.Name = "CmbCargo"
        CmbCargo.Size = New Size(153, 23)
        CmbCargo.TabIndex = 3
        ' 
        ' PicFoto
        ' 
        PicFoto.BorderStyle = BorderStyle.FixedSingle
        PicFoto.Image = CType(resources.GetObject("PicFoto.Image"), Image)
        PicFoto.Location = New Point(599, 28)
        PicFoto.Name = "PicFoto"
        PicFoto.Size = New Size(129, 129)
        PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
        PicFoto.TabIndex = 2
        PicFoto.TabStop = False
        ' 
        ' TxtNome
        ' 
        TxtNome.Location = New Point(38, 66)
        TxtNome.Name = "TxtNome"
        TxtNome.Size = New Size(431, 23)
        TxtNome.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(38, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nome funcionário"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(TxtPesquisa)
        TabPage2.Controls.Add(DgvDados)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(798, 411)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Listagem Geral Rendimentos"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' TxtPesquisa
        ' 
        TxtPesquisa.Location = New Point(605, 18)
        TxtPesquisa.Name = "TxtPesquisa"
        TxtPesquisa.Size = New Size(176, 23)
        TxtPesquisa.TabIndex = 1
        ' 
        ' DgvDados
        ' 
        DgvDados.AllowUserToAddRows = False
        DgvDados.AllowUserToDeleteRows = False
        DgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvDados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvDados.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        DgvDados.Location = New Point(3, 59)
        DgvDados.Name = "DgvDados"
        DgvDados.ReadOnly = True
        DgvDados.RowTemplate.Height = 25
        DgvDados.Size = New Size(789, 337)
        DgvDados.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ID"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 43
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Nome"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 65
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Cargo"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 64
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Salário Bruto"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 99
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Salário Líquido"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 110
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Editar"
        Column6.Image = CType(resources.GetObject("Column6.Image"), Image)
        Column6.ImageLayout = DataGridViewImageCellLayout.Zoom
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 43
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Excluir"
        Column7.Image = CType(resources.GetObject("Column7.Image"), Image)
        Column7.ImageLayout = DataGridViewImageCellLayout.Zoom
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 48
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(827, 469)
        Controls.Add(TabPages)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Formulário Principal"
        TabPages.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PicFoto, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(DgvDados, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabPages As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents CmbCargo As ComboBox
    Friend WithEvents PicFoto As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtSalarios As TextBox
    Friend WithEvents DtpData As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBruto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtLiquido As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtINSS As TextBox
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DgvDados As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
    Friend WithEvents TxtPesquisa As TextBox
End Class
