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
    public partial class CRUDCliente : Form
    {
        public CRUDCliente(string funcao)
        {
            InitializeComponent();

            if (funcao == "Cadastrar")
            {
                labelTituloCliente.Text = funcao + " Usuário";

                buttonAlterarCliente.Hide();
                buttonExcluirCliente.Hide();
            }
            if (funcao == "Buscar")
            {
                labelTituloCliente.Text = funcao + " Usuário";
                buttonCadastrarCliente.Hide();
            }
            if (funcao != "Buscar" && funcao != "Cadastrar")
            {
                labelTituloCliente.Text = "Alterar Usuário";
                buttonCadastrarCliente.Hide();

                try
                {
                    MySqlConnection connectbd = new MySqlConnection();

                    MySqlCommand comandoMysql;

                    MySqlDataReader reader;

                    connectbd.ConnectionString =
                        "server=localhost;" +
                        "database= bd_petfamily; " +
                        "user id=root; Password=";

                    connectbd.Open();
                    
                    //MessageBox.Show("Por favor, insira o nome do cliente para buscar.", "Erro ao procurar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    string buscarCliente = "select * from Clientes where id_cliente = '" + funcao + "'";

                    comandoMysql = new MySqlCommand(buscarCliente, connectbd);

                    reader = comandoMysql.ExecuteReader();

                    if (reader.Read())
                    {
                        string name = reader["nome"].ToString();
                        string cpf = reader["cpf"].ToString();
                        string rg = reader["rg"].ToString();
                        string fone1 = reader["fone1"].ToString();
                        string fone2 = reader["fone2"].ToString();
                        string endereco = reader["endereco"].ToString();
                        string numero = reader["numero"].ToString();
                        string bairro = reader["bairro"].ToString();
                        string cidade = reader["cidade"].ToString();

                        txtBoxNome.Text = name;
                        txtBoxCPF.Text = cpf;
                        txtBoxRG.Text = rg;
                        txtBoxFone1.Text = fone1;
                        txtBoxFone2.Text = fone2;
                        txtBoxEndereco.Text = endereco;
                        txtBoxNumero.Text = numero;
                        txtBoxBairro.Text = bairro;
                        txtBoxCidade.Text = cidade;
                    }
                    else
                    {
                        MessageBox.Show("Nenhum cliente foi encontrado!", "Falha ao procurar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                

                    connectbd.Close();
                }
                catch (MySqlException x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private void buttonCadastrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connectbd = new MySqlConnection();

                MySqlCommand comandoMysql;

                MySqlDataReader reader;                

                connectbd.ConnectionString =
                    "server=localhost;" +
                    "database= bd_petfamily; " +
                    "user id=root; Password=";

                connectbd.Open();

                if (string.IsNullOrWhiteSpace(txtBoxNome.Text) || string.IsNullOrEmpty(txtBoxFone1.Text))
                {
                    MessageBox.Show("Insira ao menos um Nome e um Fone (Fone1).", "Erro ao cadastrar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string cadastrarCliente = "insert into Clientes (nome, cpf, rg, fone1, fone2, endereco, numero, bairro, cidade) value (" +
                        "'" + txtBoxNome.Text + "', " +
                        "'" + txtBoxCPF.Text + "', " +
                        "'" + txtBoxRG.Text + "', " +
                        "'" + txtBoxFone1.Text + "', " +
                        "'" + txtBoxFone2.Text + "', " +
                        "'" + txtBoxEndereco.Text + "', " +
                        "'" + txtBoxNumero.Text + "', " +
                        "'" + txtBoxBairro.Text + "', " +
                        "'" + txtBoxCidade.Text + "')";

                    comandoMysql = new MySqlCommand(cadastrarCliente, connectbd);

                    reader = comandoMysql.ExecuteReader();

                    MessageBox.Show("Cliente " + txtBoxNome.Text + " cadastrado com sucesso!");

                    TelaInicial fromInicialScreen = new TelaInicial();
                    this.Dispose();
                    fromInicialScreen.ShowDialog();
                }

                connectbd.Close();
            }
            catch (MySqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void buttonAlterarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connectbd = new MySqlConnection();

                MySqlCommand comandoMysql;

                MySqlDataReader reader;

                connectbd.ConnectionString =
                    "server=localhost;" +
                    "database= bd_petfamily; " +
                    "user id=root; Password=";

                connectbd.Open();

                if (string.IsNullOrWhiteSpace(txtBoxNome.Text) || string.IsNullOrEmpty(txtBoxFone1.Text))
                {
                    MessageBox.Show("Insira ao menos um Nome e um Fone (Fone1).", "Erro ao cadastrar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string alterarCliente = "update Clientes set " +
                        "nome = '" + txtBoxNome.Text + "', " +
	                    "cpf = '" + txtBoxCPF.Text + "', " +
	                    "rg = '" + txtBoxRG.Text + "', " +
	                    "fone1 = '" + txtBoxFone1.Text + "', " +
	                    "fone2 = '" + txtBoxFone2.Text + "', " +
	                    "endereco = '" + txtBoxEndereco.Text + "', " +
	                    "numero = '" + txtBoxNumero.Text + "', " +
	                    "bairro = '" + txtBoxBairro.Text + "', " +
	                    "cidade = '" + txtBoxCidade.Text + "'" +
                        "where id_cliente = '" + BuscaCliente.cliente_id + "'";

                    comandoMysql = new MySqlCommand(alterarCliente, connectbd);

                    reader = comandoMysql.ExecuteReader();

                    MessageBox.Show("Dados atualizados com sucesso!");

                    TelaInicial fromInicialScreen = new TelaInicial();
                    this.Dispose();
                    fromInicialScreen.ShowDialog();
                }

                connectbd.Close();
            }
            catch (MySqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void buttonExcluirCliente_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connectbd = new MySqlConnection();

                MySqlCommand comandoMysql;

                MySqlDataReader reader;

                connectbd.ConnectionString =
                    "server=localhost;" +
                    "database= bd_petfamily; " +
                    "user id=root; Password=";

                connectbd.Open();

                if (MessageBox.Show("Deseja mesmo excluir o Cliente " + txtBoxNome.Text + "? A ação não poderá ser desfeita!", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string deletarCliente = "delete from Clientes where id_cliente = '" + BuscaCliente.cliente_id + "'";

                    comandoMysql = new MySqlCommand(deletarCliente, connectbd);

                    reader = comandoMysql.ExecuteReader();                    

                    txtBoxNome.Clear();
                    txtBoxCPF.Clear();
                    txtBoxRG.Clear();
                    txtBoxFone1.Clear();
                    txtBoxFone2.Clear();
                    txtBoxEndereco.Clear();
                    txtBoxNumero.Clear();
                    txtBoxBairro.Clear();
                    txtBoxCidade.Clear();

                    MessageBox.Show("Cliente excluído com sucesso!");

                    string acao = "Específico";
                    BuscaCliente frmBuscaCliente = new BuscaCliente(acao);
                    this.Dispose();
                    frmBuscaCliente.ShowDialog();
                }

                connectbd.Close();
            }
            catch (MySqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void buttonCancelarCadastroCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TelaInicial fromInicialScreen = new TelaInicial();
                this.Dispose();
                fromInicialScreen.ShowDialog();
            }
        }

        private void CRUDCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TelaInicial fromInicialScreen = new TelaInicial();
                this.Dispose();
                fromInicialScreen.ShowDialog();
            }
        }        
    }
}
