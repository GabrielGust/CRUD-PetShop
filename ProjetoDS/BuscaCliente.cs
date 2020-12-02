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
    public partial class BuscaCliente : Form
    {
        public static string cliente_id;
        public BuscaCliente(string funcao)
        {
            InitializeComponent();

            if (funcao == "Todos")
            {
                labelBuscarNome.Hide();
                txtBoxBuscarNome.Hide();
                labelBuscarCodigo.Hide();
                txtBoxBuscarCodigo.Hide();
                buttonBuscar.Hide();

                MySqlConnection connectbd = new MySqlConnection();

                connectbd.ConnectionString =
                        "server=localhost;" +
                        "database= bd_petfamily; " +
                        "user id=root; Password=";

                try
                {
                    GridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    string sqlSearchOne = "select id_cliente as Código," +
                        "nome as Nome, " +
                        "cpf as CPF, " +
                        "rg as RG, " +
                        "fone1 as Contato1, " +
                        "fone2 as Contato2, " +
                        "endereco as Endereço, " +
                        "numero as Numero, " +
                        "bairro as Bairro, " +
                        "cidade as Cidade from Clientes";

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

                    dataAdapter = new MySqlDataAdapter(sqlSearchOne, connectbd);

                    DataSet dataGroup = new DataSet();

                    dataAdapter.Fill(dataGroup);

                    GridViewClientes.DataSource = dataGroup.Tables[0];
                }
                catch (MySqlException x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxBuscarNome.Text) && string.IsNullOrWhiteSpace(txtBoxBuscarCodigo.Text))
            {
                MessageBox.Show("Insira o nome ou o código para buscar o Cliente.", "Erro ao buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(txtBoxBuscarCodigo.Text))
            {
                MySqlConnection connectbd = new MySqlConnection();

                connectbd.ConnectionString =
                        "server=localhost;" +
                        "database= bd_petfamily; " +
                        "user id=root; Password=";

                try
                {
                    GridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    string sqlSearchOne = "select id_cliente as Código," +
                        "nome as Nome, " +
                        "cpf as CPF, " +
                        "rg as RG, " +
                        "fone1 as Contato1, " +
                        "fone2 as Contato2, " +
                        "endereco as Endereço, " +
                        "numero as Numero, " +
                        "bairro as Bairro, " +
                        "cidade as Cidade " +
                        "from Clientes where nome like '%" + txtBoxBuscarNome.Text + "%'";

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

                    dataAdapter = new MySqlDataAdapter(sqlSearchOne, connectbd);

                    DataSet dataGroup = new DataSet();

                    dataAdapter.Fill(dataGroup);

                    GridViewClientes.DataSource = dataGroup.Tables[0];
                }
                catch (MySqlException x)
                {
                    MessageBox.Show(x.Message);
                }
            }
            else if (string.IsNullOrWhiteSpace(txtBoxBuscarNome.Text))
            {
                MySqlConnection connectbd = new MySqlConnection();

                connectbd.ConnectionString =
                        "server=localhost;" +
                        "database= bd_petfamily; " +
                        "user id=root; Password=";

                try
                {
                    GridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    string sqlSearch = "select id_cliente as Código," +
                        "nome as Nome, " +
                        "cpf as CPF, " +
                        "rg as RG, " +
                        "fone1 as Contato1, " +
                        "fone2 as Contato2, " +
                        "endereco as Endereço, " +
                        "numero as Numero, " +
                        "bairro as Bairro, " +
                        "cidade as Cidade " +
                        "from Clientes where id_cliente= '" + txtBoxBuscarCodigo.Text + "'";

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

                    dataAdapter = new MySqlDataAdapter(sqlSearch, connectbd);

                    DataSet dataGroup = new DataSet();

                    dataAdapter.Fill(dataGroup);

                    GridViewClientes.DataSource = dataGroup.Tables[0];
                }
                catch (MySqlException x)
                {
                    MessageBox.Show(x.Message);
                }
            }

        }

        private void GridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cliente_id = GridViewClientes.Rows[e.RowIndex].Cells[0].Value.ToString();

            CRUDCliente frmCRUDCliente = new CRUDCliente(cliente_id);
            this.Dispose();
            frmCRUDCliente.ShowDialog();
        }

        private void BuscaCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            TelaInicial fromInicialScreen = new TelaInicial();
            this.Dispose();
            fromInicialScreen.ShowDialog();
        }
    }
}
