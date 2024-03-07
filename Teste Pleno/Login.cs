using System;
using System.Windows.Forms;
using static Teste_Pleno.FrmCasdastro;

    namespace Teste_Pleno
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private List<Usuario> usuarios = new List<Usuario>();

        private void btnLogin_Click(object sender, EventArgs e)
        {

                // Verifica se os campos de usuário e senha foram preenchidos
                if (string.IsNullOrWhiteSpace(txtUsuario1.Text) || string.IsNullOrWhiteSpace(txtSenha1.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Percorre a lista de usuários cadastrados
                foreach (var usuario in usuarios)
                {
                    // Verifica se o nome de usuário e a senha correspondem aos cadastrados
                    if (usuario.Nome == txtUsuario1.Text && usuario.Senha == txtSenha1.Text)
                    {
                        MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return; // Encerra o método após encontrar um usuário correspondente
                    }
                }

                // Se nenhum usuário correspondente for encontrado, exibe uma mensagem de erro
                MessageBox.Show("Usuário ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            FrmCasdastro frmCasdastro = new FrmCasdastro(); 
            frmCasdastro.ShowDialog();
        }
    }
}
