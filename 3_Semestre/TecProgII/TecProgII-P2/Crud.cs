using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TecProgII_P2.Utils;

namespace TecProgII_P2
{
    public partial class Crud : Form
    {
        public Crud()
        {
            InitializeComponent();
        }

        private void Crud_Load(object sender, EventArgs e)
        {
            if (GlobalData.MyDictionary["role"].ToString() == "admin")
                tabControl1.TabPages[1].Parent = tabControl1;
            else
                tabControl1.TabPages[1].Parent = null;
        }

        private void CarregarDados()
        {
            try
            {
                DgvDados.Rows.Clear();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conexao.Connection;

                    cmd.CommandText = "SELECT id_user, user_name, user_email, user_password, user_role, user_active FROM tb_users ORDER BY id_user DESC";
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        DgvDados.Rows.Add(reader["id_user"], reader["user_name"], reader["user_email"], reader["user_role"], reader["user_active"]);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erro ao carregar os dados - {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            TxtNome.Clear();
            TxtEmail.Clear();
            TxtSenha.Clear();
            TxtSenha.Enabled = true;
            CmbCargo.SelectedIndex = -1;
            TxtEmail.Focus();
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
                        cmd.Connection = Conexao.Connection;
                        cmd.CommandText = "UPDATE tb_users SET user_name = @USERNAME, user_email = @USEREMAIL, user_password = @USERPASSWORD, user_role = @USERROLE WHERE id_user = @IDUSER";

                        cmd.Parameters.AddWithValue("@USERNAME", TxtNome.Text);
                        cmd.Parameters.AddWithValue("@USEREMAIL", TxtEmail.Text);
                        cmd.Parameters.AddWithValue("@USERPASSWORD", PasswordExtensions.CodifyPassword(TxtSenha.Text));
                        cmd.Parameters.AddWithValue("@USERROLE", CmbCargo.Text);
                        cmd.Parameters.AddWithValue("@IDUSER", GlobalData.MyDictionary["idUser"]);

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
                        cmd.Connection = Conexao.Connection;
                        cmd.CommandText = "INSERT INTO tb_users VALUES (@USERNAME, @USEREMAIL, @USERPASSWORD, @USERROLE, 1)";

                        cmd.Parameters.AddWithValue("@USERNAME", TxtNome.Text);
                        cmd.Parameters.AddWithValue("@USEREMAIL", TxtEmail.Text);
                        cmd.Parameters.AddWithValue("@USERPASSWORD", PasswordExtensions.CodifyPassword(TxtSenha.Text));
                        cmd.Parameters.AddWithValue("@USERROLE", CmbCargo.Text);

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

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conexao.Connection;

                    cmd.CommandText = "SELECT TOP(1) * FROM tb_users WHERE user_email = @USEREMAIL";
                    cmd.Parameters.AddWithValue("@USEREMAIL", TxtEmail.Text);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        TxtNome.Text = reader.GetValue(1).ToString();
                        TxtSenha.Text = reader.GetValue(3).ToString();
                        TxtSenha.Enabled = false;
                        CmbCargo.Text = reader.GetValue(4).ToString();

                        GlobalData.MyDictionary["isUpdate"] = true;
                        GlobalData.MyDictionary["idUser"] = reader.GetValue(0).ToString();
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
                MessageBox.Show($"Erro ao buscar Usuário - {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtEmail.Text == string.Empty)
                {
                    MessageBox.Show($"Digite um Email!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtEmail.Focus();
                    return;
                }

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conexao.Connection;

                    cmd.CommandText = "SELECT TOP(1) * FROM tb_users WHERE user_email = @USEREMAIL";
                    cmd.Parameters.AddWithValue("@USEREMAIL", TxtEmail.Text);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (!(reader.Read()))
                    {
                        reader.Close();
                        throw new Exception("Usuário não encontrando no DB");
                    }
                    else
                    {
                        reader.Close();
                        using (SqlCommand cmd2 = new SqlCommand())
                        {
                            cmd2.Connection = Conexao.Connection;
                            cmd2.CommandText = "DELETE FROM tb_users WHERE id_user = @IDUSER";

                            cmd2.Parameters.AddWithValue("@IDUSER", GlobalData.MyDictionary["idUser"]);

                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("Usuário excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao deletar usuário - {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages[1])
            {
                CarregarDados();
            }
        }
    }
}
