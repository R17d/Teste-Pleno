namespace Teste_Pleno
{
    partial class FrmCasdastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCasdastro));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            DtGrid = new DataGridView();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            txtAtivar2fa = new TextBox();
            bntAtivar = new Button();
            btnSalvar = new Button();
            lb_user2 = new Label();
            lb_password2 = new Label();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            dataQR = new DataGridView();
            txtCodQr = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DtGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataQR).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nunito", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(565, 30);
            label1.Name = "label1";
            label1.Size = new Size(228, 46);
            label1.TabIndex = 0;
            label1.Text = "Novo usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 48);
            label2.Name = "label2";
            label2.Size = new Size(342, 22);
            label2.TabIndex = 1;
            label2.Text = "Digitalize o código ou digite a chave";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 85);
            label3.Name = "label3";
            label3.Size = new Size(357, 20);
            label3.TabIndex = 2;
            label3.Text = "Digitalize o código abaixo com seu aplicativo autenticador";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 104);
            label4.Name = "label4";
            label4.Size = new Size(373, 20);
            label4.TabIndex = 3;
            label4.Text = " para adicionar essa conta. Alguns aplicativos autenticadores";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(68, 124);
            label5.Name = "label5";
            label5.Size = new Size(328, 20);
            label5.TabIndex = 4;
            label5.Text = "também permitem que você digite a versão de texto.";
            // 
            // DtGrid
            // 
            DtGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtGrid.Location = new Point(44, 176);
            DtGrid.Name = "DtGrid";
            DtGrid.Size = new Size(398, 376);
            DtGrid.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(554, 145);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(239, 29);
            txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(554, 265);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(239, 29);
            txtSenha.TabIndex = 2;
            // 
            // txtAtivar2fa
            // 
            txtAtivar2fa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAtivar2fa.Location = new Point(554, 396);
            txtAtivar2fa.Name = "txtAtivar2fa";
            txtAtivar2fa.Size = new Size(239, 29);
            txtAtivar2fa.TabIndex = 3;
            // 
            // bntAtivar
            // 
            bntAtivar.BackColor = Color.FromArgb(192, 0, 0);
            bntAtivar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntAtivar.ForeColor = Color.White;
            bntAtivar.Location = new Point(632, 435);
            bntAtivar.Name = "bntAtivar";
            bntAtivar.Size = new Size(94, 32);
            bntAtivar.TabIndex = 4;
            bntAtivar.Text = "Ativar";
            bntAtivar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(192, 0, 0);
            btnSalvar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(543, 498);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(267, 38);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Finalizar e voltar para o Login";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // lb_user2
            // 
            lb_user2.AutoSize = true;
            lb_user2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_user2.Location = new Point(637, 109);
            lb_user2.Name = "lb_user2";
            lb_user2.Size = new Size(100, 20);
            lb_user2.TabIndex = 11;
            lb_user2.Text = "Novo usuário:";
            // 
            // lb_password2
            // 
            lb_password2.AutoSize = true;
            lb_password2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_password2.Location = new Point(637, 235);
            lb_password2.Name = "lb_password2";
            lb_password2.Size = new Size(89, 20);
            lb_password2.TabIndex = 12;
            lb_password2.Text = "Nova senha:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(529, 330);
            label8.Name = "label8";
            label8.Size = new Size(318, 20);
            label8.TabIndex = 13;
            label8.Text = "Digite o código de seu aplicativo autenticador";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(529, 350);
            label6.Name = "label6";
            label6.Size = new Size(303, 20);
            label6.TabIndex = 14;
            label6.Text = " abaixo para verificar e ativar a autenticação";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(572, 370);
            label7.Name = "label7";
            label7.Size = new Size(221, 20);
            label7.TabIndex = 15;
            label7.Text = " de dois fatores para esta conta.";
            // 
            // dataQR
            // 
            dataQR.BackgroundColor = SystemColors.ButtonHighlight;
            dataQR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataQR.Location = new Point(68, 204);
            dataQR.Name = "dataQR";
            dataQR.Size = new Size(349, 263);
            dataQR.TabIndex = 8;
            // 
            // txtCodQr
            // 
            txtCodQr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodQr.Location = new Point(71, 498);
            txtCodQr.Name = "txtCodQr";
            txtCodQr.Size = new Size(344, 29);
            txtCodQr.TabIndex = 7;
            // 
            // FrmCasdastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(912, 601);
            Controls.Add(txtCodQr);
            Controls.Add(dataQR);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(lb_password2);
            Controls.Add(lb_user2);
            Controls.Add(btnSalvar);
            Controls.Add(bntAtivar);
            Controls.Add(txtAtivar2fa);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(DtGrid);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCasdastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar usuário ";
            ((System.ComponentModel.ISupportInitialize)DtGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataQR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView DtGrid;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private TextBox txtAtivar2fa;
        private Button bntAtivar;
        private Button btnSalvar;
        private Label lb_user2;
        private Label lb_password2;
        private Label label8;
        private Label label6;
        private Label label7;
        private DataGridView dataQR;
        private TextBox txtCodQr;
    }
}