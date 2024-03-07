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

                // Verifica se os campos de usu�rio e senha foram preenchidos
                if (string.IsNullOrWhiteSpace(txtUsuario1.Text) || string.IsNullOrWhiteSpace(txtSenha1.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Percorre a lista de usu�rios cadastrados
                foreach (var usuario in usuarios)
                {
                    // Verifica se o nome de usu�rio e a senha correspondem aos cadastrados
                    if (usuario.Nome == txtUsuario1.Text && usuario.Senha == txtSenha1.Text)
                    {
                        MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return; // Encerra o m�todo ap�s encontrar um usu�rio correspondente
                    }
                }

                // Se nenhum usu�rio correspondente for encontrado, exibe uma mensagem de erro
                MessageBox.Show("Usu�rio ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            FrmCasdastro frmCasdastro = new FrmCasdastro(); 
            frmCasdastro.ShowDialog();
        }
    }
}
