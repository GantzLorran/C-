using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CrudsComCsharp
{
    public partial class Cadastro : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;
        public Cadastro()
        {
            InitializeComponent();
        }

        //INSERIR DADOS NO BANCO DE DADOS SQLSERVER
        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-C9C1RB6\MSSQLSERVER01;Database=cliente2;User Id=sa;Password=lorran;");

                strSQL = "INSERT INTO cad_cliente4 (NOME, NUMERO) VALUES (@NOME, @NUMERO)";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@NUMERO", txtNumero.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao.Close();
                conexao = null;
                comando = null;
            }


        }

        //EXIBIR OS DADOS DO BANCO DE DADOS
        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-C9C1RB6\MSSQLSERVER01;Database=cliente2;User Id=sa;Password=lorran;");

                strSQL = "SELECT * FROM cad_cliente4";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);
                
                conexao.Open();

                da.Fill(ds);

                dgvDados.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        //CONSULTAR DADOS DO BANCO DE DADOS
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-C9C1RB6\MSSQLSERVER01;Database=cliente2;User Id=sa;Password=lorran;");

                strSQL = "SELECT * FROM cad_cliente4 WHERE ID = @ID";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ID", txtId.Text);
                

                conexao.Open();
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txtNome.Text = (string)dr["nome"];
                    txtNumero.Text = Convert.ToString(dr["numero"]);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        //EDITAR TABELAS
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-C9C1RB6\MSSQLSERVER01;Database=cliente2;User Id=sa;Password=lorran;");

                strSQL = "UPDATE cad_cliente4 SET NOME = @NOME, NUMERO = @NUMERO WHERE ID = @ID";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ID", txtId.Text);
                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@NUMERO", txtNumero.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        //DELETAR USUÁRIO DO BANCO DE DADOS
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-C9C1RB6\MSSQLSERVER01;Database=cliente2;User Id=sa;Password=lorran;");

                strSQL = "DELETE cad_cliente4 WHERE ID = @ID";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ID", txtId.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }
    }
}
