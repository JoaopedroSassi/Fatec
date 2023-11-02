using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TecProgII_P2.Utils
{
    public static class Conexao
    {
        public static SqlConnection Connection;

        public static void Connect()
        {
            try
            {
                Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Local"].ConnectionString);
                Connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao conectar! - {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
