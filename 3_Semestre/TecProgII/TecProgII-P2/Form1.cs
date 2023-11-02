using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using TecProgII_P2.Utils;

namespace TecProgII_P2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexao.Connect();
        }

        private void LimpaCampos()
        {
            TxtEmail.Text = string.Empty;
            TxtSenha.Text = string.Empty;
            TxtEmail.Focus();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conexao.Connection;
                    cmd.CommandText = "SELECT * FROM tb_users WHERE user_email = @EMAIL";

                    cmd.Parameters.AddWithValue("@EMAIL", TxtEmail.Text);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (!(reader.Read()))
                    {
                        reader.Close();
                        throw new Exception("Usuário não encontrado!");                   
                    }                      
                    else
                    {
                        if (!(PasswordExtensions.ComparePassword(TxtSenha.Text, reader.GetValue(3).ToString())))
                        {
                            reader.Close();
                            throw new Exception("Senha inválida!");
                        }
                        else if (reader.GetValue(5).ToString().ToLower() == "false")
                        {
                            reader.Close();
                            throw new Exception("Usuário inátivo!");
                        }
                        else
                        {
                            GlobalData.MyDictionary["role"] = reader.GetValue(4).ToString();
                            reader.Close();

                            MessageBox.Show("Login realizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Hide();

                            Crud crud = new Crud();
                            crud.ShowDialog();

                            Close();
                        }
                    }                   
                }
            }
            catch (Exception ex)
            {
                LimpaCampos();
                MessageBox.Show($"Erro ao logar - {ex.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
