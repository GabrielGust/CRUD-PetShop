using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoDS
{
    public partial class BuscaUsuário : Form
    {
        public static string user_id;
        public BuscaUsuário(string funcao)
        {
            InitializeComponent();

            if (funcao == "Todos")
            {
                labelBuscarNomeUsuario.Hide();
                txtBoxBuscarNomeUsuario.Hide();
                labelBuscarCodigoUsuario.Hide();
                txtBoxBuscarCodigoUsuario.Hide();
                buttonBuscarUsuario.Hide();

                //GridViewPets.Size(739, 527);
                //GridViewPets.Height(527);
                //GridViewPets

                MySqlConnection connectbd = new MySqlConnection();

                connectbd.ConnectionString =
                        "server=localhost;" +
                        "database= bd_petfamily; " +
                        "user id=root; Password=";

                try
                {
                    GridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    string sqlSearchAll = "select id_login as Código," +
                        "usuario as Usuário," +
                        "palavra_chave as PalavraChave " +
                        "from LoginSistema";

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

                    dataAdapter = new MySqlDataAdapter(sqlSearchAll, connectbd);

                    DataSet dataGroup = new DataSet();

                    dataAdapter.Fill(dataGroup);

                    GridViewUsuarios.DataSource = dataGroup.Tables[0];
                }
                catch (MySqlException x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private void buttonBuscarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxBuscarNomeUsuario.Text) && string.IsNullOrWhiteSpace(txtBoxBuscarCodigoUsuario.Text))
            {
                MessageBox.Show("Insira o nome ou o código para buscar o Usuário.", "Erro ao buscar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(txtBoxBuscarCodigoUsuario.Text))
            {
                MySqlConnection connectbd = new MySqlConnection();

                connectbd.ConnectionString =
                        "server=localhost;" +
                        "database= bd_petfamily; " +
                        "user id=root; Password=";

                try
                {
                    GridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    string sqlSearchOne = "select id_login as Código," +
                        "usuario as Usuário," +
                        "palavra_chave as PalavraChave " +
                        "from LoginSistema where usuario like '%" + txtBoxBuscarNomeUsuario.Text + "%'";

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

                    dataAdapter = new MySqlDataAdapter(sqlSearchOne, connectbd);

                    DataSet dataGroup = new DataSet();

                    dataAdapter.Fill(dataGroup);

                    GridViewUsuarios.DataSource = dataGroup.Tables[0];
                }
                catch (MySqlException x)
                {
                    MessageBox.Show(x.Message);
                }
            }
            else if (string.IsNullOrWhiteSpace(txtBoxBuscarNomeUsuario.Text))
            {
                MySqlConnection connectbd = new MySqlConnection();

                connectbd.ConnectionString =
                        "server=localhost;" +
                        "database= bd_petfamily; " +
                        "user id=root; Password=";

                try
                {
                    GridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    string sqlSearchOne = "select id_login as Código," +
                        "usuario as Usuário," +
                        "palavra_chave as PalavraChave " +
                        "from LoginSistema where id_login like '%" + txtBoxBuscarCodigoUsuario.Text + "%'";

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

                    dataAdapter = new MySqlDataAdapter(sqlSearchOne, connectbd);

                    DataSet dataGroup = new DataSet();

                    dataAdapter.Fill(dataGroup);

                    GridViewUsuarios.DataSource = dataGroup.Tables[0];
                }
                catch (MySqlException x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private void GridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            user_id = GridViewUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();

            CRUDUser frmCRUDUser = new CRUDUser(user_id);
            this.Dispose();
            frmCRUDUser.ShowDialog();
        }

        private void BuscaUsuário_FormClosed(object sender, FormClosedEventArgs e)
        {
            TelaInicial fromInicialScreen = new TelaInicial();
            this.Dispose();
            fromInicialScreen.ShowDialog();
        }        
    }
}
