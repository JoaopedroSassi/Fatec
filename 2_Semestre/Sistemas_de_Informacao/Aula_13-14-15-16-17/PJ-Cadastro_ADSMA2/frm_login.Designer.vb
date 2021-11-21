<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Me.tab_control_login = New System.Windows.Forms.TabControl()
        Me.ident_conta = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_us_senha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_us_nome = New System.Windows.Forms.TextBox()
        Me.nova_conta = New System.Windows.Forms.TabPage()
        Me.btn_criar_conta = New System.Windows.Forms.Button()
        Me.chk_visualizar = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_confirma_senha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_email_us = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nome_us = New System.Windows.Forms.TextBox()
        Me.manut_conta = New System.Windows.Forms.TabPage()
        Me.lbl_admin = New System.Windows.Forms.LinkLabel()
        Me.tab_control_login.SuspendLayout()
        Me.ident_conta.SuspendLayout()
        Me.nova_conta.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_control_login
        '
        Me.tab_control_login.Controls.Add(Me.ident_conta)
        Me.tab_control_login.Controls.Add(Me.nova_conta)
        Me.tab_control_login.Controls.Add(Me.manut_conta)
        Me.tab_control_login.Location = New System.Drawing.Point(12, 40)
        Me.tab_control_login.Name = "tab_control_login"
        Me.tab_control_login.SelectedIndex = 0
        Me.tab_control_login.Size = New System.Drawing.Size(736, 383)
        Me.tab_control_login.TabIndex = 0
        '
        'ident_conta
        '
        Me.ident_conta.Controls.Add(Me.Button1)
        Me.ident_conta.Controls.Add(Me.Label6)
        Me.ident_conta.Controls.Add(Me.txt_us_senha)
        Me.ident_conta.Controls.Add(Me.Label5)
        Me.ident_conta.Controls.Add(Me.txt_us_nome)
        Me.ident_conta.Location = New System.Drawing.Point(4, 24)
        Me.ident_conta.Name = "ident_conta"
        Me.ident_conta.Padding = New System.Windows.Forms.Padding(3)
        Me.ident_conta.Size = New System.Drawing.Size(728, 355)
        Me.ident_conta.TabIndex = 0
        Me.ident_conta.Text = "Identificação de Conta"
        Me.ident_conta.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(309, 101)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 36)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Entrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Senha"
        '
        'txt_us_senha
        '
        Me.txt_us_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_us_senha.Location = New System.Drawing.Point(34, 150)
        Me.txt_us_senha.Name = "txt_us_senha"
        Me.txt_us_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_us_senha.Size = New System.Drawing.Size(251, 23)
        Me.txt_us_senha.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Usuário | Email"
        '
        'txt_us_nome
        '
        Me.txt_us_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_us_nome.Location = New System.Drawing.Point(34, 64)
        Me.txt_us_nome.Name = "txt_us_nome"
        Me.txt_us_nome.Size = New System.Drawing.Size(251, 23)
        Me.txt_us_nome.TabIndex = 0
        '
        'nova_conta
        '
        Me.nova_conta.Controls.Add(Me.btn_criar_conta)
        Me.nova_conta.Controls.Add(Me.chk_visualizar)
        Me.nova_conta.Controls.Add(Me.Label4)
        Me.nova_conta.Controls.Add(Me.txt_confirma_senha)
        Me.nova_conta.Controls.Add(Me.Label3)
        Me.nova_conta.Controls.Add(Me.txt_senha)
        Me.nova_conta.Controls.Add(Me.Label2)
        Me.nova_conta.Controls.Add(Me.txt_email_us)
        Me.nova_conta.Controls.Add(Me.Label1)
        Me.nova_conta.Controls.Add(Me.txt_nome_us)
        Me.nova_conta.Location = New System.Drawing.Point(4, 24)
        Me.nova_conta.Name = "nova_conta"
        Me.nova_conta.Padding = New System.Windows.Forms.Padding(3)
        Me.nova_conta.Size = New System.Drawing.Size(728, 355)
        Me.nova_conta.TabIndex = 1
        Me.nova_conta.Text = "Nova conta"
        Me.nova_conta.UseVisualStyleBackColor = True
        '
        'btn_criar_conta
        '
        Me.btn_criar_conta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_criar_conta.Location = New System.Drawing.Point(271, 279)
        Me.btn_criar_conta.Name = "btn_criar_conta"
        Me.btn_criar_conta.Size = New System.Drawing.Size(144, 26)
        Me.btn_criar_conta.TabIndex = 9
        Me.btn_criar_conta.Text = "Criar conta"
        Me.btn_criar_conta.UseVisualStyleBackColor = True
        '
        'chk_visualizar
        '
        Me.chk_visualizar.AutoSize = True
        Me.chk_visualizar.Location = New System.Drawing.Point(499, 211)
        Me.chk_visualizar.Name = "chk_visualizar"
        Me.chk_visualizar.Size = New System.Drawing.Size(75, 19)
        Me.chk_visualizar.TabIndex = 8
        Me.chk_visualizar.Text = "Visualizar"
        Me.chk_visualizar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(271, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Repetir senha"
        '
        'txt_confirma_senha
        '
        Me.txt_confirma_senha.Location = New System.Drawing.Point(271, 211)
        Me.txt_confirma_senha.Name = "txt_confirma_senha"
        Me.txt_confirma_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_confirma_senha.Size = New System.Drawing.Size(186, 23)
        Me.txt_confirma_senha.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(44, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Senha"
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(44, 211)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_senha.Size = New System.Drawing.Size(186, 23)
        Me.txt_senha.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(44, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Email"
        '
        'txt_email_us
        '
        Me.txt_email_us.Location = New System.Drawing.Point(44, 124)
        Me.txt_email_us.Name = "txt_email_us"
        Me.txt_email_us.Size = New System.Drawing.Size(540, 23)
        Me.txt_email_us.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(44, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome do usuário"
        '
        'txt_nome_us
        '
        Me.txt_nome_us.Location = New System.Drawing.Point(44, 48)
        Me.txt_nome_us.Name = "txt_nome_us"
        Me.txt_nome_us.Size = New System.Drawing.Size(540, 23)
        Me.txt_nome_us.TabIndex = 0
        '
        'manut_conta
        '
        Me.manut_conta.Location = New System.Drawing.Point(4, 24)
        Me.manut_conta.Name = "manut_conta"
        Me.manut_conta.Size = New System.Drawing.Size(728, 355)
        Me.manut_conta.TabIndex = 2
        Me.manut_conta.Text = "Manutenção de Contas"
        Me.manut_conta.UseVisualStyleBackColor = True
        '
        'lbl_admin
        '
        Me.lbl_admin.AutoSize = True
        Me.lbl_admin.Location = New System.Drawing.Point(614, 22)
        Me.lbl_admin.Name = "lbl_admin"
        Me.lbl_admin.Size = New System.Drawing.Size(134, 15)
        Me.lbl_admin.TabIndex = 5
        Me.lbl_admin.TabStop = True
        Me.lbl_admin.Text = "Encerrar sessão - Admin"
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 432)
        Me.Controls.Add(Me.lbl_admin)
        Me.Controls.Add(Me.tab_control_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_login"
        Me.Text = "frm_login"
        Me.tab_control_login.ResumeLayout(False)
        Me.ident_conta.ResumeLayout(False)
        Me.ident_conta.PerformLayout()
        Me.nova_conta.ResumeLayout(False)
        Me.nova_conta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tab_control_login As TabControl
    Friend WithEvents ident_conta As TabPage
    Friend WithEvents nova_conta As TabPage
    Friend WithEvents btn_criar_conta As Button
    Friend WithEvents chk_visualizar As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_confirma_senha As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_email_us As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nome_us As TextBox
    Friend WithEvents manut_conta As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_us_senha As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_us_nome As TextBox
    Friend WithEvents lbl_admin As LinkLabel
End Class
