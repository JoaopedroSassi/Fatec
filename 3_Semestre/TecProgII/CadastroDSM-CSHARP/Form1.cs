using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using CadastroDSM_CSHARP.Utils;

namespace CadastroDSM_CSHARP
{
    public partial class Form1 : Form
    {
        SqlConnection Conexao;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Fatec"].ConnectionString);
                Conexao.Open();
                MessageBox.Show("Conexão magna!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao conectar! - {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conexao;
                    cmd.CommandText = "SELECT TOP(1) id_user FROM tb_cadastro WHERE id = @ID";

                    //cmd.Parameters.AddWithValue("@ID", );

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (GlobalData.MyDictionary.ContainsKey("idUsuarioUPD"))
                    {
                        try
                        {
                            string id = reader.GetValue(0).ToString();
                            reader.Close();

                            using (SqlCommand cmd2 = new SqlCommand())
                            {
                                cmd2.Connection = Conexao;
                                cmd2.CommandText = "UPDATE tb_cadastro SET nome = @NOME, cpf = @CPF WHERE id_user = @ID";

                                cmd2.Parameters.AddWithValue("@CPF", TxtCPF.Text);
                                cmd2.Parameters.AddWithValue("@NOME", TxtNome.Text);
                                cmd2.Parameters.AddWithValue("@ID", id);

                                cmd2.ExecuteNonQuery();
                                MessageBox.Show("Dados atualizados com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao atualizar no DB - {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            throw ex;
                        }
                    }
                    else
                    {
                        try
                        {
                            reader.Close();

                            using (SqlCommand cmd2 = new SqlCommand())
                            {
                                cmd2.Connection = Conexao;
                                cmd2.CommandText = "INSERT INTO tb_cadastro VALUES (@CPF, @NOME)";

                                cmd2.Parameters.AddWithValue("@CPF", TxtCPF.Text);
                                cmd2.Parameters.AddWithValue("@NOME", TxtNome.Text);

                                cmd2.ExecuteNonQuery();
                                MessageBox.Show("Dados gravados com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao salvar no DB - {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            throw ex;
                        }
                    }

                    TxtCPF.Clear();
                    TxtNome.Clear();
                    TxtCPF.Focus();

                    if (GlobalData.MyDictionary.ContainsKey("idUsuarioUPD"))
                        GlobalData.MyDictionary["idUsuarioUPD"] = "";                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar CPF - {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void TxtCPF_Leave(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conexao;
                    cmd.CommandText = "SELECT TOP(1) * FROM tb_cadastro WHERE cpf = @CPF";

                    cmd.Parameters.AddWithValue("@CPF", TxtCPF.Text);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        TxtNome.Text = reader.GetValue(2).ToString();
                        GlobalData.MyDictionary["idUsuarioUPD"] = reader.GetValue(0).ToString();
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar CPF - {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }
    }
}
