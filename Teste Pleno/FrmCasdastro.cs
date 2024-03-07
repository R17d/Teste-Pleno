using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_Pleno
{
    public partial class FrmCasdastro : Form
    {
        public FrmCasdastro()
        {
            InitializeComponent();

        }

        public class Usuario
        {
            public string Nome { get; set; }
            public string Senha { get; set; }
        }

        // Lista para armazenar os usuários cadastrados
        private List<Usuario> usuarios = new List<Usuario>();

        /*public SeuFormulario()
        {
            InitializeComponent();
            btnSalvar.Click += BtnSalvar_Click;
        }*/

      
        private void LimparCampos()
        {
            txtUsuario.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {

            // Verifica se ambos os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cria um novo objeto de usuário com os dados inseridos
            Usuario novoUsuario = new Usuario
            {
                Nome = txtUsuario.Text,
                Senha = txtSenha.Text
            };

            // Adiciona o novo usuário à lista de usuários
            usuarios.Add(novoUsuario);

            // Limpa os campos de texto após salvar
            LimparCampos();

            MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Fecha o formulário atual (de cadastro)
            this.Close();

            // Abre o formulário de login
            Login Login = new Login();
            Login.Show();
        }
    }
}

