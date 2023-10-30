using System;
using System.Windows.Forms;

namespace TecProgII_P2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (TxtEmail.Text.ToUpper() == "ADMIN" && TxtSenha.Text.ToUpper() == "ADMIN")
            {
                Hide();

                Crud crud = new Crud();
                crud.ShowDialog();

                Close();
            }
            else
            {
                MessageBox.Show("ERRO - Login inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtEmail.Text = string.Empty;
                TxtSenha.Text = string.Empty;
                TxtEmail.Focus();
            }
        }
    }
}
