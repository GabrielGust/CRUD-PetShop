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
    public partial class CRUDUser : Form
    {
        public CRUDUser(string funcao)
        {
            InitializeComponent();
            labelTituloUsuario.Text = funcao + " Usuário";
            if (funcao == "Cadastrar")
            {
                buttonAtualizarUsuario.Hide();
                buttonExcluirUsuario.Hide();
            }
            if (funcao == "Buscar")
            {
                labelTituloUsuario.Text = funcao + " Usuário";
                buttonCadastrarUsuario.Hide();
            }
            if (funcao != "Buscar" && funcao != "Cadastrar")
            {
                labelTituloUsuario.Text = "Alterar Usuário";
                buttonCadastrarUsuario.Hide();

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

                    string buscarUser = "select * from LoginSistema " +
                        "where id_login = '" + funcao + "'";

                    comandoMysql = new MySqlCommand(buscarUser, connectbd);

                    reader = comandoMysql.ExecuteReader();

                    if (reader.Read())
                    {
                        string username = reader["usuario"].ToString();
                        string password = reader["senha"].ToString();
                        string keyword = reader["palavra_chave"].ToString();  

                        txtBoxNomeUsuario.Text = username;
                        txtBoxSenhaUsuario.Text = password;
                        txtBoxPalavraChave.Text = keyword;                                     
                    }
                    else
                    {
                        MessageBox.Show("Nenhum Usuário foi encontrado!", "Falha ao procurar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    connectbd.Close();
                }
                catch (MySqlException x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private void buttonCadastrarUsuario_Click(object sender, EventArgs e)
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

                if (string.IsNullOrWhiteSpace(txtBoxNomeUsuario.Text) || 
                    string.IsNullOrEmpty(txtBoxSenhaUsuario.Text) || 
                    string.IsNullOrEmpty(txtBoxPalavraChave.Text))
                {
                    MessageBox.Show("Preencha todos os campos para cadastrar o Usuário.", "Erro ao cadastrar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string cadastrarCliente = "insert into LoginSistema (usuario, senha, palavra_chave) value (" +
                        "'" + txtBoxNomeUsuario.Text + "', " +
                        "'" + txtBoxSenhaUsuario.Text + "', " +
                        "'" + txtBoxPalavraChave.Text + "')";

                    comandoMysql = new MySqlCommand(cadastrarCliente, connectbd);

                    reader = comandoMysql.ExecuteReader();

                    MessageBox.Show("Usuário " + txtBoxNomeUsuario.Text + " cadastrado com sucesso!");

                    txtBoxNomeUsuario.Clear();
                    txtBoxSenhaUsuario.Clear();                  
                    txtBoxPalavraChave.Clear();

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

        private void buttonAtualizarUsuario_Click(object sender, EventArgs e)
        {
            if (TelaLogin.LoginAcess == 1)
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

                    if (string.IsNullOrWhiteSpace(txtBoxNomeUsuario.Text) ||
                        string.IsNullOrEmpty(txtBoxSenhaUsuario.Text) ||
                        string.IsNullOrEmpty(txtBoxPalavraChave.Text))
                    {
                        MessageBox.Show("Preencha todos os campos para atualizar o Usuário.", "Erro ao atualizar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string alterarUsuariot = "update LoginSistema set " +
                            "usuario = '" + txtBoxNomeUsuario.Text + "', " +
                            "senha = '" + txtBoxSenhaUsuario.Text + "', " +
                            "palavra_chave = '" + txtBoxPalavraChave.Text + "' " +
                            "where id_login = '" + BuscaUsuário.user_id + "'";

                        comandoMysql = new MySqlCommand(alterarUsuariot, connectbd);

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
            else
            {
                MessageBox.Show("Somente o administrador pode visualizar a senha de outros usuários.", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }        

        private void buttonExcluirUsuario_Click(object sender, EventArgs e)
        {
            if (TelaLogin.LoginAcess == 1)
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

                    if (MessageBox.Show("Deseja mesmo excluir o Usuário " + txtBoxNomeUsuario.Text + "? A ação não poderá ser desfeita!", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string deletarCliente = "delete from LoginSistema where id_login = '" + BuscaUsuário.user_id + "'";

                        comandoMysql = new MySqlCommand(deletarCliente, connectbd);

                        reader = comandoMysql.ExecuteReader();

                        txtBoxNomeUsuario.Clear();
                        txtBoxSenhaUsuario.Clear();
                        txtBoxPalavraChave.Clear();

                        MessageBox.Show("Usuário excluído com sucesso!");

                        string acao = "Específico";
                        BuscaUsuário frmBuscaUsuário = new BuscaUsuário(acao);
                        this.Dispose();
                        frmBuscaUsuário.ShowDialog();
                    }

                    connectbd.Close();
                }
                catch (MySqlException x)
                {
                    MessageBox.Show(x.Message);
                }
            }
            else
            {
                MessageBox.Show("Somente o administrador pode excluir outros usuários.", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                        
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (TelaLogin.LoginAcess == 1)
            {
                if (txtBoxSenhaUsuario.UseSystemPasswordChar == true)
                {
                    txtBoxSenhaUsuario.UseSystemPasswordChar = false;
                }
                else
                {
                    txtBoxSenhaUsuario.UseSystemPasswordChar = true;
                }
            }
            else
            {
                MessageBox.Show("Somente o administrador pode visualizar a senha de outros usuários.", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
         }

        private void buttonCancelarCadastroUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TelaInicial fromInicialScreen = new TelaInicial();
                this.Dispose();
                fromInicialScreen.ShowDialog();
            }
        }

        private void CRUDUser_FormClosed(object sender, FormClosedEventArgs e)
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
