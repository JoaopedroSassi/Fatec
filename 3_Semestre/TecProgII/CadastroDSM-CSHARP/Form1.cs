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
                Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Local"].ConnectionString);
                Conexao.Open();
                MessageBox.Show("Conexão magna!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao conectar! - {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void LimparCampos()
        {
            TxtCPF.Clear();
            TxtNome.Clear();
            TxtCPF.Focus();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(GlobalData.MyDictionary["isUpdate"]) is true)
            {
                try
                {
                    string id = GlobalData.MyDictionary["idUsuarioUPD"].ToString();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = Conexao;
                        cmd.CommandText = "UPDATE tb_cadastro SET nome = @NOME, cpf = @CPF WHERE id_user = @ID";

                        cmd.Parameters.AddWithValue("@CPF", TxtCPF.Text);
                        cmd.Parameters.AddWithValue("@NOME", TxtNome.Text);
                        cmd.Parameters.AddWithValue("@ID", id);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Dados atualizados com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    GlobalData.MyDictionary["idUsuarioUPD"] = "";
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
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = Conexao;
                        cmd.CommandText = "INSERT INTO tb_cadastro VALUES (@CPF, @NOME)";

                        cmd.Parameters.AddWithValue("@CPF", TxtCPF.Text);
                        cmd.Parameters.AddWithValue("@NOME", TxtNome.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Dados gravados com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar no DB - {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw ex;
                }
            }

            LimparCampos();
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
                        GlobalData.MyDictionary["isUpdate"] = true;
                    }
                    else
                    {
                        GlobalData.MyDictionary["isUpdate"] = false;
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar CPF - {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (TxtCPF.Text == "   .   .   -")
            {
                MessageBox.Show($"Digite um CPF", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCPF.Focus();
                return;
            }

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Conexao;
                cmd.CommandText = "SELECT TOP(1) * FROM tb_cadastro WHERE cpf = @CPF";
                cmd.Parameters.AddWithValue("@CPF", TxtCPF.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                if (!(reader.Read()))
                {
                    MessageBox.Show($"CPF não encontrando no DB", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtCPF.Clear();
                    TxtCPF.Focus();
                    reader.Close();
                    return;
                }
                else
                {
                    string id = reader.GetValue(0).ToString();
                    reader.Close();

                    cmd.CommandText = "DELETE FROM tb_cadastro WHERE id_user = @ID";

                    cmd.Parameters.AddWithValue("@ID", id);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados excluídos com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reader.Close();
                    LimparCampos();
                }
            }
        }
    }
}
