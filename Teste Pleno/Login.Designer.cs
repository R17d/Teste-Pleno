namespace Teste_Pleno
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtUsuario1 = new TextBox();
            txtSenha1 = new TextBox();
            btnLogin = new Button();
            txt2FA = new TextBox();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // txtUsuario1
            // 
            txtUsuario1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario1.BackColor = Color.FromArgb(239, 239, 239);
            txtUsuario1.BorderStyle = BorderStyle.None;
            txtUsuario1.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtUsuario1.Location = new Point(143, 180);
            txtUsuario1.Name = "txtUsuario1";
            txtUsuario1.PlaceholderText = "Usuário";
            txtUsuario1.Size = new Size(231, 17);
            txtUsuario1.TabIndex = 2;
            txtUsuario1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSenha1
            // 
            txtSenha1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSenha1.BackColor = Color.FromArgb(239, 239, 239);
            txtSenha1.BorderStyle = BorderStyle.None;
            txtSenha1.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtSenha1.Location = new Point(145, 301);
            txtSenha1.Name = "txtSenha1";
            txtSenha1.PasswordChar = '*';
            txtSenha1.PlaceholderText = "Senha";
            txtSenha1.Size = new Size(231, 17);
            txtSenha1.TabIndex = 3;
            txtSenha1.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.FromArgb(0, 191, 99);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(17, 204, 149);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(17, 204, 149);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(17, 204, 149);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnLogin.ForeColor = SystemColors.Window;
            btnLogin.Location = new Point(134, 507);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(255, 52);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txt2FA
            // 
            txt2FA.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt2FA.BackColor = Color.FromArgb(239, 239, 239);
            txt2FA.BorderStyle = BorderStyle.None;
            txt2FA.Font = new Font("Microsoft Sans Serif", 11.25F);
            txt2FA.Location = new Point(149, 414);
            txt2FA.Name = "txt2FA";
            txt2FA.PlaceholderText = "Digite o 2FA";
            txt2FA.Size = new Size(231, 17);
            txt2FA.TabIndex = 6;
            txt2FA.TextAlign = HorizontalAlignment.Center;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(225, 575);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(69, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Inscreva-se ";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1044, 623);
            Controls.Add(linkLabel1);
            Controls.Add(txt2FA);
            Controls.Add(btnLogin);
            Controls.Add(txtSenha1);
            Controls.Add(txtUsuario1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario1;
        private TextBox txtSenha1;
        private Button btnLogin;
        private TextBox txt2FA;
        private LinkLabel linkLabel1;
    }
}
