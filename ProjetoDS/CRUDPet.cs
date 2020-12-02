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
    public partial class CRUDPet : Form
    {
        MySqlConnection connectbd = new MySqlConnection();

        MySqlCommand comandoMysql;

        MySqlDataReader leitorDadosClassificacaoPet;
        string classificacaoPet;
        int idClassificacao;

        MySqlDataReader leitorDadosPortePet;
        string portePet;
        int idPorte;

        MySqlDataReader leitorDadosResponsavel;
        string responsavelPet;
        int idResponsavel;


        public CRUDPet(string funcao)
        {
            InitializeComponent();

            if (funcao == "Cadastrar")
            {
                labelTituloPet.Text = funcao + " Pet";

                buttonAlterarPet.Hide();
                buttonExcluirPet.Hide();
            }
            if (funcao == "Buscar")
            {
                labelTituloPet.Text = funcao + " Pet";
                buttonCadastrarPet.Hide();
            }
            if (funcao != "Buscar" && funcao != "Cadastrar")
            {
                labelTituloPet.Text = "Alterar Pet";
                buttonCadastrarPet.Hide();

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
                    
                    string buscarPet = "select * from Pets " +
                        "inner join Clientes on Pets.id_cliente = Clientes.id_cliente " +
                        "inner join ClassificacaoPet on Pets.id_classificacao = ClassificacaoPet.id_classificacao " +
                        "inner join PortesPet on Pets.id_porte = PortesPet.id_porte " +
                        "where id_pet = '"+ funcao +"'";

                    comandoMysql = new MySqlCommand(buscarPet, connectbd);

                    reader = comandoMysql.ExecuteReader();

                    if (reader.Read())
                    {
                        string pet_name = reader["nome_pet"].ToString();
                        string sex = reader["sexo"].ToString();
                        string responsible = reader["nome"].ToString();
                        string classification = reader["classificacao"].ToString();
                        string port = reader["porte"].ToString();
                        string description = reader["descricao"].ToString();

                        //int reponsibleINT = Convert.ToInt32(responsible);
                        //int classificationINT = Convert.ToInt32(classification);
                        //int portINT = Convert.ToInt32(port);

                        //MessageBox.Show("id responsavel: "+ reponsibleINT + " || id classificação: "+ classificationINT +" || id porte: "+ portINT);

                        txtBoxNomePet.Text = pet_name;
                        txtBoxSexo.Text = sex;

                        cmbBoxResponsavel.Text = responsible;
                        //cmbBoxResponsavel.Enabled = false;

                        cmbBoxClassificacao.Text = classification;
                        //cmbBoxClassificacao.Enabled = false;

                        cmbBoxPorte.Text = port;
                        //cmbBoxPorte.Enabled = false;

                        txtBoxDescricao.Text = description;
                        
                    }
                    else
                    {
                        MessageBox.Show("Nenhum Pet foi encontrado!", "Falha ao procurar Pet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    connectbd.Close();
                }
                catch (MySqlException x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private void buttonCadastrarPet_Click(object sender, EventArgs e)
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

                if (string.IsNullOrWhiteSpace(txtBoxNomePet.Text) ||
                    string.IsNullOrEmpty(cmbBoxResponsavel.Text) ||
                    string.IsNullOrEmpty(cmbBoxClassificacao.Text) ||
                    string.IsNullOrEmpty(txtBoxSexo.Text))
                {
                    MessageBox.Show("Por favor, insira ao menos o Nome do Pet, Responsável, Classificação e o Sexo.", "Erro ao cadastrar Pet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string cadastrarCliente = "insert into Pets (nome_pet, id_cliente, id_classificacao, id_porte, sexo, descricao) value (" +
                        "'" + txtBoxNomePet.Text + "', " +
                        "'" + idResponsavel + "', " +
                        "'" + idClassificacao + "', " +
                        "'" + idPorte + "', " +
                        "'" + txtBoxSexo.Text + "', " +
                        "'" + txtBoxDescricao.Text + "')";

                    comandoMysql = new MySqlCommand(cadastrarCliente, connectbd);

                    reader = comandoMysql.ExecuteReader();

                    MessageBox.Show("Pet " + txtBoxNomePet.Text + " cadastrado com sucesso!");

                    txtBoxNomePet.Clear();
                    cmbBoxResponsavel.Text = "";
                    cmbBoxClassificacao.Text = "";
                    cmbBoxPorte.Text = "";
                    txtBoxSexo.Clear();
                    txtBoxDescricao.Clear();

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

        private void buttonAlterarPet_Click(object sender, EventArgs e)
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

                if (string.IsNullOrWhiteSpace(txtBoxNomePet.Text) ||
                    string.IsNullOrEmpty(cmbBoxResponsavel.Text) ||
                    string.IsNullOrEmpty(cmbBoxClassificacao.Text) ||
                    string.IsNullOrEmpty(txtBoxSexo.Text))
                {
                    MessageBox.Show("Por favor, insira ao menos o Nome do Pet, Responsável, Classificação e o Sexo.", "Erro ao atualizar Pet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string alterarPet = "update Pets set " +
                        "nome_pet = '" + txtBoxNomePet.Text + "', " +
                        "id_cliente = '" + idResponsavel + "', " +
                        "id_classificacao = '" + idClassificacao + "', " +
                        "id_porte = '" + idPorte + "', " +
                        "sexo = '" + txtBoxSexo.Text + "', " +
                        "descricao = '" + txtBoxDescricao.Text + "' " +
                        "where id_pet = '" + BuscaPet.pet_id + "'";

                    comandoMysql = new MySqlCommand(alterarPet, connectbd);

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
                MessageBox.Show("Se você ver esta tela selecione novamente o Responsável, a Classificação e o Porte para realizar as alterações no Pet", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CRUDPet_Load(object sender, EventArgs e)
        {

            try
            {
                connectbd.ConnectionString =
                    "server=localhost;" +
                    "database= bd_petfamily; " +
                    "user id=root; Password=";

                connectbd.Open();

                // Insere os dados da classificação do Pet no ComboBox
                classificacaoPet = "select * from ClassificacaoPet";
                comandoMysql = new MySqlCommand(classificacaoPet, connectbd);
                leitorDadosClassificacaoPet = comandoMysql.ExecuteReader();

                while (leitorDadosClassificacaoPet.Read())
                {
                    cmbBoxClassificacao.Items.Add(leitorDadosClassificacaoPet["classificacao"]);
                }

                leitorDadosClassificacaoPet.Close();

                // Insere os dados de porte do Pet no Combobox
                portePet = "select * from PortesPet";
                comandoMysql = new MySqlCommand(portePet, connectbd);
                leitorDadosPortePet = comandoMysql.ExecuteReader();

                while (leitorDadosPortePet.Read())
                {
                    cmbBoxPorte.Items.Add(leitorDadosPortePet["porte"]);
                }

                leitorDadosPortePet.Close();

                // Insere os dados do responsável do Pet no Combobox
                responsavelPet = "select * from Clientes";
                comandoMysql = new MySqlCommand(responsavelPet, connectbd);
                leitorDadosResponsavel = comandoMysql.ExecuteReader();

                while (leitorDadosResponsavel.Read())
                {
                    cmbBoxResponsavel.Items.Add(leitorDadosResponsavel["nome"]);
                }

                leitorDadosResponsavel.Close();
            }
            catch (MySqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void cmbBoxClassificacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            idClassificacao = cmbBoxClassificacao.SelectedIndex + 1;
        }

        private void cmbBoxPorte_SelectedIndexChanged(object sender, EventArgs e)
        {
            idPorte = cmbBoxPorte.SelectedIndex + 1;
        }

        private void cmbBoxResponsavel_SelectedIndexChanged(object sender, EventArgs e)
        {
            idResponsavel = cmbBoxResponsavel.SelectedIndex + 1;
        }

        private void buttonExcluirPet_Click(object sender, EventArgs e)
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

                if (MessageBox.Show("Deseja mesmo excluir o Cliente " + txtBoxNomePet.Text + "? A ação não poderá ser desfeita!", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string deletarPet = "delete from Pets where id_pet = '" + BuscaPet.pet_id + "'";

                    comandoMysql = new MySqlCommand(deletarPet, connectbd);

                    reader = comandoMysql.ExecuteReader();                    

                    txtBoxNomePet.Clear();
                    txtBoxSexo.Clear();
                    cmbBoxResponsavel.Text = "";
                    cmbBoxClassificacao.Text = "";
                    cmbBoxPorte.Text = "";
                    txtBoxDescricao.Clear();

                    MessageBox.Show("Pet excluído com sucesso!");

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

        private void buttonCancelarCadastroPet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TelaInicial fromInicialScreen = new TelaInicial();
                this.Dispose();
                fromInicialScreen.ShowDialog();
            }
        }

        private void CRUDPet_FormClosed(object sender, FormClosedEventArgs e)
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
