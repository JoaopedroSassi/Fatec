<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LinguagensToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VBNETToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BásicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntermediáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvançadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PHPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JavaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AplicativosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlocoDeNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LinguagensToolStripMenuItem, Me.AplicativosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LinguagensToolStripMenuItem
        '
        Me.LinguagensToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VBNETToolStripMenuItem, Me.CToolStripMenuItem, Me.PHPToolStripMenuItem, Me.JavaToolStripMenuItem})
        Me.LinguagensToolStripMenuItem.Name = "LinguagensToolStripMenuItem"
        Me.LinguagensToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.LinguagensToolStripMenuItem.Text = "&Linguagens"
        '
        'VBNETToolStripMenuItem
        '
        Me.VBNETToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramasToolStripMenuItem})
        Me.VBNETToolStripMenuItem.Image = CType(resources.GetObject("VBNETToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VBNETToolStripMenuItem.Name = "VBNETToolStripMenuItem"
        Me.VBNETToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VBNETToolStripMenuItem.Text = "VB.NET"
        '
        'ProgramasToolStripMenuItem
        '
        Me.ProgramasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BásicosToolStripMenuItem, Me.IntermediáriosToolStripMenuItem, Me.AvançadosToolStripMenuItem})
        Me.ProgramasToolStripMenuItem.Name = "ProgramasToolStripMenuItem"
        Me.ProgramasToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ProgramasToolStripMenuItem.Text = "Programas"
        '
        'BásicosToolStripMenuItem
        '
        Me.BásicosToolStripMenuItem.Name = "BásicosToolStripMenuItem"
        Me.BásicosToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.BásicosToolStripMenuItem.Text = "Básicos"
        '
        'IntermediáriosToolStripMenuItem
        '
        Me.IntermediáriosToolStripMenuItem.Name = "IntermediáriosToolStripMenuItem"
        Me.IntermediáriosToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.IntermediáriosToolStripMenuItem.Text = "Intermediários"
        '
        'AvançadosToolStripMenuItem
        '
        Me.AvançadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroClientesToolStripMenuItem})
        Me.AvançadosToolStripMenuItem.Name = "AvançadosToolStripMenuItem"
        Me.AvançadosToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.AvançadosToolStripMenuItem.Text = "Avançados"
        '
        'CadastroClientesToolStripMenuItem
        '
        Me.CadastroClientesToolStripMenuItem.Name = "CadastroClientesToolStripMenuItem"
        Me.CadastroClientesToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CadastroClientesToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.CadastroClientesToolStripMenuItem.Text = "Cadastro Clientes"
        '
        'CToolStripMenuItem
        '
        Me.CToolStripMenuItem.Image = CType(resources.GetObject("CToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CToolStripMenuItem.Name = "CToolStripMenuItem"
        Me.CToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CToolStripMenuItem.Text = "C#"
        '
        'PHPToolStripMenuItem
        '
        Me.PHPToolStripMenuItem.Image = CType(resources.GetObject("PHPToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PHPToolStripMenuItem.Name = "PHPToolStripMenuItem"
        Me.PHPToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PHPToolStripMenuItem.Text = "PHP"
        '
        'JavaToolStripMenuItem
        '
        Me.JavaToolStripMenuItem.Image = CType(resources.GetObject("JavaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.JavaToolStripMenuItem.Name = "JavaToolStripMenuItem"
        Me.JavaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.JavaToolStripMenuItem.Text = "Java"
        '
        'AplicativosToolStripMenuItem
        '
        Me.AplicativosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem, Me.ExcelToolStripMenuItem, Me.BlocoDeNotasToolStripMenuItem})
        Me.AplicativosToolStripMenuItem.Name = "AplicativosToolStripMenuItem"
        Me.AplicativosToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.AplicativosToolStripMenuItem.Text = "Aplicativos"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Image = CType(resources.GetObject("CalculadoraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.CalculadoraToolStripMenuItem.Tag = "calc.exe"
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'ExcelToolStripMenuItem
        '
        Me.ExcelToolStripMenuItem.Image = CType(resources.GetObject("ExcelToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem"
        Me.ExcelToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F2), System.Windows.Forms.Keys)
        Me.ExcelToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ExcelToolStripMenuItem.Tag = "excel.exe"
        Me.ExcelToolStripMenuItem.Text = "Excel"
        '
        'BlocoDeNotasToolStripMenuItem
        '
        Me.BlocoDeNotasToolStripMenuItem.Image = CType(resources.GetObject("BlocoDeNotasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BlocoDeNotasToolStripMenuItem.Name = "BlocoDeNotasToolStripMenuItem"
        Me.BlocoDeNotasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F3), System.Windows.Forms.Keys)
        Me.BlocoDeNotasToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.BlocoDeNotasToolStripMenuItem.Tag = "notepad.exe"
        Me.BlocoDeNotasToolStripMenuItem.Text = "Bloco de Notas"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LinguagensToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VBNETToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BásicosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntermediáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvançadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PHPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JavaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AplicativosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlocoDeNotasToolStripMenuItem As ToolStripMenuItem
End Class
