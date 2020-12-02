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
    public partial class BuscaPet : Form
    {
        public static string pet_id;
        public BuscaPet(string funcao)
        {
            InitializeComponent();

            if (funcao == "Todos")
            {
                labelBuscarNomePet.Hide();
                txtBoxBuscarNomePet.Hide();
                labelBuscarCodigoPet.Hide();
                txtBoxBuscarCodigoPet.Hide();
                buttonBuscarPet.Hide();

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
                    GridViewPets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    string sqlSearchOne = "select Pets.id_pet as Código," +
                        "Pets.nome_pet as Nome, " +
                        "Clientes.nome as Responsável, " +
                        "ClassificacaoPet.classificacao as Classificação, " +
                        "PortesPet.porte as Porte, " +
                        "Pets.sexo as Sexo, " +
                        "Pets.descricao as Descrição " +
                        "from Pets " +
                        "inner join Clientes on Pets.id_cliente = Clientes.id_cliente " +
                        "inner join ClassificacaoPet on Pets.id_classificacao = ClassificacaoPet.id_classificacao " +
                        "inner join PortesPet on Pets.id_porte = PortesPet.id_porte order by id_pet";

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

                    dataAdapter = new MySqlDataAdapter(sqlSearchOne, connectbd);

                    DataSet dataGroup = new DataSet();

                    dataAdapter.Fill(dataGroup);

                    GridViewPets.DataSource = dataGroup.Tables[0];
                }
                catch (MySqlException x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private void buttonBuscarPet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxBuscarNomePet.Text) && string.IsNullOrWhiteSpace(txtBoxBuscarCodigoPet.Text))
            {
                MessageBox.Show("Insira o nome ou o código para buscar o Pet.", "Erro ao buscar Pet", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(txtBoxBuscarCodigoPet.Text))
            {
                MySqlConnection connectbd = new MySqlConnection();

                connectbd.ConnectionString =
                        "server=localhost;" +
                        "database= bd_petfamily; " +
                        "user id=root; Password=";

                try
                {
                    GridViewPets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    string sqlSearchAll = "select Pets.id_pet as Código," +
                        "Pets.nome_pet as Nome, " +
                        "Clientes.nome as Responsável, " +
                        "ClassificacaoPet.classificacao as Classificação, " +
                        "PortesPet.porte as Porte, " +
                        "Pets.sexo as Sexo, " +
                        "Pets.descricao as Descrição " +
                        "from Pets " +
                        "inner join Clientes on Pets.id_cliente = Clientes.id_cliente " +
                        "inner join ClassificacaoPet on Pets.id_classificacao = ClassificacaoPet.id_classificacao " +
                        "inner join PortesPet on Pets.id_porte = PortesPet.id_porte " +
                        "where nome_pet like '%" + txtBoxBuscarNomePet.Text + "%'";

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

                    dataAdapter = new MySqlDataAdapter(sqlSearchAll, connectbd);

                    DataSet dataGroup = new DataSet();

                    dataAdapter.Fill(dataGroup);

                    GridViewPets.DataSource = dataGroup.Tables[0];
                }
                catch (MySqlException x)
                {
                    MessageBox.Show(x.Message);
                }
            }
            else if (string.IsNullOrWhiteSpace(txtBoxBuscarNomePet.Text))
            {
                MySqlConnection connectbd = new MySqlConnection();

                connectbd.ConnectionString =
                        "server=localhost;" +
                        "database= bd_petfamily; " +
                        "user id=root; Password=";

                try
                {
                    GridViewPets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    string sqlSearchOne = "select Pets.id_pet as Código," +
                        "Pets.nome_pet as Nome, " +
                        "Clientes.nome as Responsável, " +
                        "ClassificacaoPet.classificacao as Classificação, " +
                        "PortesPet.porte as Porte, " +
                        "Pets.sexo as Sexo, " +
                        "Pets.descricao as Descrição " +
                        "from Pets " +
                        "inner join Clientes on Pets.id_cliente = Clientes.id_cliente " +
                        "inner join ClassificacaoPet on Pets.id_classificacao = ClassificacaoPet.id_classificacao " +
                        "inner join PortesPet on Pets.id_porte = PortesPet.id_porte " +
                        "where id_pet like '%" + txtBoxBuscarCodigoPet.Text + "%'";

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

                    dataAdapter = new MySqlDataAdapter(sqlSearchOne, connectbd);

                    DataSet dataGroup = new DataSet();

                    dataAdapter.Fill(dataGroup);

                    GridViewPets.DataSource = dataGroup.Tables[0];
                }
                catch (MySqlException x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private void GridViewPets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pet_id = GridViewPets.Rows[e.RowIndex].Cells[0].Value.ToString();

            CRUDPet frmCRUDPet = new CRUDPet(pet_id);
            this.Dispose();
            frmCRUDPet.ShowDialog();
        }

        private void BuscaPet_FormClosed(object sender, FormClosedEventArgs e)
        {
            TelaInicial fromInicialScreen = new TelaInicial();
            this.Dispose();
            fromInicialScreen.ShowDialog();
        }     
    }
}
