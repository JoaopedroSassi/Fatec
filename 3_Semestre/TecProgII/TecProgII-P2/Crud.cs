using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using TecProgII_P2.Utils;

namespace TecProgII_P2
{
    public partial class Crud : Form
    {
        SqlConnection Connection;
        public Crud()
        {
            InitializeComponent();
        }

        private void Crud_Load(object sender, EventArgs e)
        {
            try
            {
                Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Local"].ConnectionString);
                Connection.Open();
                TxtGameID.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao conectar! - {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void LimparCampos()
        {
            TxtGameID.Clear();
            TxtNome.Clear();
            DtmLancamento.Value = DateTime.Now;
            TxtGameID.Focus(); 
        }

        private void TxtGameID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Crud_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1();
            form1.ShowDialog();
            
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(GlobalData.MyDictionary["isUpdate"]) is true)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = Connection;
                        cmd.CommandText = "UPDATE tb_games SET Nome = @NOME, DataLancamento = @DATALANCAMENTO WHERE GameID = @GAMEID";

                        cmd.Parameters.AddWithValue("@DATALANCAMENTO", DtmLancamento.Value);
                        cmd.Parameters.AddWithValue("@NOME", TxtNome.Text);
                        cmd.Parameters.AddWithValue("@GAMEID", TxtGameID.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Dados atualizados com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar no DB - {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = Connection;
                        cmd.CommandText = "INSERT INTO tb_games VALUES (@GAMEID, @NOME, @DATALANCAMENTO)";

                        cmd.Parameters.AddWithValue("@DATALANCAMENTO", DtmLancamento.Value);
                        cmd.Parameters.AddWithValue("@NOME", TxtNome.Text);
                        cmd.Parameters.AddWithValue("@GAMEID", TxtGameID.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Dados gravados com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar no DB - {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LimparCampos();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtGameID.Text == string.Empty)
                {
                    MessageBox.Show($"Digite um GameID!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtGameID.Focus();
                    return;
                }

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Connection;

                    cmd.CommandText = "SELECT TOP(1) * FROM tb_games WHERE GameID = @GAMEID";
                    cmd.Parameters.AddWithValue("@GAMEID", TxtGameID.Text);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (!(reader.Read()))
                    {
                        MessageBox.Show("Game não encontrando no DB", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtGameID.Clear();
                        TxtNome.Clear();
                        TxtGameID.Focus();
                        reader.Close();
                        return;
                    }
                    else
                    {
                        reader.Close();
                        using (SqlCommand cmd2 = new SqlCommand())
                        {
                            cmd2.Connection = Connection;
                            cmd2.CommandText = "DELETE FROM tb_games WHERE GameID = @GAMEID";

                            cmd2.Parameters.AddWithValue("@GAMEID", TxtGameID.Text);

                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("Game excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                        reader.Close();
                        LimparCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao deletar game - {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtGameID_Leave(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Connection;

                    cmd.CommandText = "SELECT TOP(1) * FROM tb_games WHERE GameID = @GAMEID";
                    cmd.Parameters.AddWithValue("@GAMEID", TxtGameID.Text);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        TxtNome.Text = reader.GetValue(1).ToString();
                        DtmLancamento.Value = Convert.ToDateTime(reader.GetValue(2).ToString());
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
                MessageBox.Show($"Erro ao buscar GameID - {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
