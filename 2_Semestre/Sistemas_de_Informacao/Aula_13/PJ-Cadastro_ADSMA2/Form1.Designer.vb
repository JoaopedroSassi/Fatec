<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerenciamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CriaContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AplicativosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairDoSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.GerenciamentoToolStripMenuItem, Me.AplicativosToolStripMenuItem, Me.EncerrarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.FuncionáriosToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.CadastroToolStripMenuItem.Text = "&Cadastro"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Image = Global.PJ_Cadastro_ADSMA2.My.Resources.Resources.add_clientes
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'FuncionáriosToolStripMenuItem
        '
        Me.FuncionáriosToolStripMenuItem.Name = "FuncionáriosToolStripMenuItem"
        Me.FuncionáriosToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.FuncionáriosToolStripMenuItem.Text = "Funcionários"
        '
        'GerenciamentoToolStripMenuItem
        '
        Me.GerenciamentoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContasToolStripMenuItem})
        Me.GerenciamentoToolStripMenuItem.Image = CType(resources.GetObject("GerenciamentoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GerenciamentoToolStripMenuItem.Name = "GerenciamentoToolStripMenuItem"
        Me.GerenciamentoToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.GerenciamentoToolStripMenuItem.Text = "&Gerenciamento"
        '
        'ContasToolStripMenuItem
        '
        Me.ContasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CriaContasToolStripMenuItem, Me.AlterarContasToolStripMenuItem})
        Me.ContasToolStripMenuItem.Name = "ContasToolStripMenuItem"
        Me.ContasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ContasToolStripMenuItem.Text = "Contas"
        '
        'CriaContasToolStripMenuItem
        '
        Me.CriaContasToolStripMenuItem.Name = "CriaContasToolStripMenuItem"
        Me.CriaContasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CriaContasToolStripMenuItem.Text = "Criar contas"
        '
        'AlterarContasToolStripMenuItem
        '
        Me.AlterarContasToolStripMenuItem.Name = "AlterarContasToolStripMenuItem"
        Me.AlterarContasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AlterarContasToolStripMenuItem.Text = "Alterar contas"
        '
        'AplicativosToolStripMenuItem
        '
        Me.AplicativosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem})
        Me.AplicativosToolStripMenuItem.Name = "AplicativosToolStripMenuItem"
        Me.AplicativosToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.AplicativosToolStripMenuItem.Text = "&Aplicativos"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Image = CType(resources.GetObject("CalculadoraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'EncerrarToolStripMenuItem
        '
        Me.EncerrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairDoSistemaToolStripMenuItem})
        Me.EncerrarToolStripMenuItem.Name = "EncerrarToolStripMenuItem"
        Me.EncerrarToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.EncerrarToolStripMenuItem.Text = "&Encerrar"
        '
        'SairDoSistemaToolStripMenuItem
        '
        Me.SairDoSistemaToolStripMenuItem.Name = "SairDoSistemaToolStripMenuItem"
        Me.SairDoSistemaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SairDoSistemaToolStripMenuItem.Text = "Sair do sistema"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Menu principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerenciamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CriaContasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlterarContasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AplicativosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairDoSistemaToolStripMenuItem As ToolStripMenuItem
End Class
