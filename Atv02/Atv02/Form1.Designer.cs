using System;

namespace Atv02
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lable_login = new System.Windows.Forms.Label();
            this.label_senha = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.dataGridView_BDs = new System.Windows.Forms.DataGridView();
            this.btnListarTabelas = new System.Windows.Forms.Button();
            this.dataGridView_Tabelas = new System.Windows.Forms.DataGridView();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.label_senhaNovoUsuario = new System.Windows.Forms.Label();
            this.label_tituloNovoUsuario = new System.Windows.Forms.Label();
            this.panel_Login = new System.Windows.Forms.Panel();
            this.panel_novoUsuario = new System.Windows.Forms.Panel();
            this.label_loginNovoUsuario = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonGravarPermissoes = new System.Windows.Forms.Button();
            this.label_titulo = new System.Windows.Forms.Label();
            this.dataGridView_Usuarios = new System.Windows.Forms.DataGridView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.buttonSelecionarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tabelas)).BeginInit();
            this.panel_Login.SuspendLayout();
            this.panel_novoUsuario.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Usuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lable_login
            // 
            this.lable_login.AutoSize = true;
            this.lable_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_login.Location = new System.Drawing.Point(17, 20);
            this.lable_login.Name = "lable_login";
            this.lable_login.Size = new System.Drawing.Size(52, 20);
            this.lable_login.TabIndex = 0;
            this.lable_login.Text = "Login:";
            // 
            // label_senha
            // 
            this.label_senha.AutoSize = true;
            this.label_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_senha.Location = new System.Drawing.Point(17, 96);
            this.label_senha.Name = "label_senha";
            this.label_senha.Size = new System.Drawing.Size(60, 20);
            this.label_senha.TabIndex = 1;
            this.label_senha.Text = "Senha:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(57, 179);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(115, 37);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(21, 43);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(194, 26);
            this.txtLogin.TabIndex = 3;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(21, 119);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(194, 26);
            this.txtSenha.TabIndex = 4;
            // 
            // dataGridView_BDs
            // 
            this.dataGridView_BDs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BDs.Location = new System.Drawing.Point(27, 355);
            this.dataGridView_BDs.Name = "dataGridView_BDs";
            this.dataGridView_BDs.RowHeadersWidth = 51;
            this.dataGridView_BDs.Size = new System.Drawing.Size(240, 198);
            this.dataGridView_BDs.TabIndex = 5;
            // 
            // btnListarTabelas
            // 
            this.btnListarTabelas.Location = new System.Drawing.Point(318, 315);
            this.btnListarTabelas.Name = "btnListarTabelas";
            this.btnListarTabelas.Size = new System.Drawing.Size(124, 23);
            this.btnListarTabelas.TabIndex = 6;
            this.btnListarTabelas.Text = "Listar tabelas";
            this.btnListarTabelas.UseVisualStyleBackColor = true;
            this.btnListarTabelas.Click += new System.EventHandler(this.btnListarTabelas_Click);
            // 
            // dataGridView_Tabelas
            // 
            this.dataGridView_Tabelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tabelas.Location = new System.Drawing.Point(315, 107);
            this.dataGridView_Tabelas.Name = "dataGridView_Tabelas";
            this.dataGridView_Tabelas.RowHeadersWidth = 51;
            this.dataGridView_Tabelas.Size = new System.Drawing.Size(346, 202);
            this.dataGridView_Tabelas.TabIndex = 7;
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaUsuario.Location = new System.Drawing.Point(34, 162);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.ReadOnly = true;
            this.txtSenhaUsuario.Size = new System.Drawing.Size(194, 26);
            this.txtSenhaUsuario.TabIndex = 12;
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUsuario.Location = new System.Drawing.Point(34, 85);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.ReadOnly = true;
            this.txtLoginUsuario.Size = new System.Drawing.Size(194, 26);
            this.txtLoginUsuario.TabIndex = 11;
            // 
            // btnUsuario
            // 
            this.btnUsuario.Enabled = false;
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.Location = new System.Drawing.Point(70, 219);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(118, 37);
            this.btnUsuario.TabIndex = 10;
            this.btnUsuario.Text = "Gravar";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // label_senhaNovoUsuario
            // 
            this.label_senhaNovoUsuario.AutoSize = true;
            this.label_senhaNovoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_senhaNovoUsuario.Location = new System.Drawing.Point(31, 138);
            this.label_senhaNovoUsuario.Name = "label_senhaNovoUsuario";
            this.label_senhaNovoUsuario.Size = new System.Drawing.Size(60, 20);
            this.label_senhaNovoUsuario.TabIndex = 9;
            this.label_senhaNovoUsuario.Text = "Senha:";
            // 
            // label_tituloNovoUsuario
            // 
            this.label_tituloNovoUsuario.AutoSize = true;
            this.label_tituloNovoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tituloNovoUsuario.Location = new System.Drawing.Point(80, 11);
            this.label_tituloNovoUsuario.Name = "label_tituloNovoUsuario";
            this.label_tituloNovoUsuario.Size = new System.Drawing.Size(104, 20);
            this.label_tituloNovoUsuario.TabIndex = 14;
            this.label_tituloNovoUsuario.Text = "Novo Usuário";
            // 
            // panel_Login
            // 
            this.panel_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Login.Controls.Add(this.txtLogin);
            this.panel_Login.Controls.Add(this.label_senha);
            this.panel_Login.Controls.Add(this.btnEnviar);
            this.panel_Login.Controls.Add(this.txtSenha);
            this.panel_Login.Controls.Add(this.lable_login);
            this.panel_Login.Location = new System.Drawing.Point(27, 107);
            this.panel_Login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(240, 230);
            this.panel_Login.TabIndex = 15;
            // 
            // panel_novoUsuario
            // 
            this.panel_novoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_novoUsuario.Controls.Add(this.label_loginNovoUsuario);
            this.panel_novoUsuario.Controls.Add(this.label_tituloNovoUsuario);
            this.panel_novoUsuario.Controls.Add(this.label_senhaNovoUsuario);
            this.panel_novoUsuario.Controls.Add(this.btnUsuario);
            this.panel_novoUsuario.Controls.Add(this.txtSenhaUsuario);
            this.panel_novoUsuario.Controls.Add(this.txtLoginUsuario);
            this.panel_novoUsuario.Location = new System.Drawing.Point(712, 107);
            this.panel_novoUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_novoUsuario.Name = "panel_novoUsuario";
            this.panel_novoUsuario.Size = new System.Drawing.Size(256, 274);
            this.panel_novoUsuario.TabIndex = 16;
            // 
            // label_loginNovoUsuario
            // 
            this.label_loginNovoUsuario.AutoSize = true;
            this.label_loginNovoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loginNovoUsuario.Location = new System.Drawing.Point(30, 62);
            this.label_loginNovoUsuario.Name = "label_loginNovoUsuario";
            this.label_loginNovoUsuario.Size = new System.Drawing.Size(52, 20);
            this.label_loginNovoUsuario.TabIndex = 5;
            this.label_loginNovoUsuario.Text = "Login:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.buttonGravarPermissoes);
            this.panel3.Location = new System.Drawing.Point(712, 396);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 157);
            this.panel3.TabIndex = 17;
            // 
            // buttonGravarPermissoes
            // 
            this.buttonGravarPermissoes.Enabled = false;
            this.buttonGravarPermissoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGravarPermissoes.Location = new System.Drawing.Point(70, 115);
            this.buttonGravarPermissoes.Name = "buttonGravarPermissoes";
            this.buttonGravarPermissoes.Size = new System.Drawing.Size(118, 37);
            this.buttonGravarPermissoes.TabIndex = 15;
            this.buttonGravarPermissoes.Text = "Gravar";
            this.buttonGravarPermissoes.UseVisualStyleBackColor = true;
            this.buttonGravarPermissoes.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(312, 30);
            this.label_titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(375, 31);
            this.label_titulo.TabIndex = 18;
            this.label_titulo.Text = "Sistema Gerenciador de DB";
            // 
            // dataGridView_Usuarios
            // 
            this.dataGridView_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Usuarios.Location = new System.Drawing.Point(318, 355);
            this.dataGridView_Usuarios.Name = "dataGridView_Usuarios";
            this.dataGridView_Usuarios.RowHeadersWidth = 51;
            this.dataGridView_Usuarios.Size = new System.Drawing.Size(346, 169);
            this.dataGridView_Usuarios.TabIndex = 19;
            this.dataGridView_Usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(7, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 17);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Grant";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 97);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(7, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Deny";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(7, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(63, 17);
            this.radioButton3.TabIndex = 18;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Revoke";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // buttonSelecionarUsuario
            // 
            this.buttonSelecionarUsuario.Location = new System.Drawing.Point(540, 530);
            this.buttonSelecionarUsuario.Name = "buttonSelecionarUsuario";
            this.buttonSelecionarUsuario.Size = new System.Drawing.Size(124, 23);
            this.buttonSelecionarUsuario.TabIndex = 20;
            this.buttonSelecionarUsuario.Text = "Selecionar Usuario";
            this.buttonSelecionarUsuario.UseVisualStyleBackColor = true;
            this.buttonSelecionarUsuario.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 630);
            this.Controls.Add(this.buttonSelecionarUsuario);
            this.Controls.Add(this.dataGridView_Usuarios);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_novoUsuario);
            this.Controls.Add(this.panel_Login);
            this.Controls.Add(this.dataGridView_Tabelas);
            this.Controls.Add(this.btnListarTabelas);
            this.Controls.Add(this.dataGridView_BDs);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tabelas)).EndInit();
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            this.panel_novoUsuario.ResumeLayout(false);
            this.panel_novoUsuario.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Usuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable_login;
        private System.Windows.Forms.Label label_senha;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.DataGridView dataGridView_BDs;
        private System.Windows.Forms.Button btnListarTabelas;
        private System.Windows.Forms.DataGridView dataGridView_Tabelas;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Label label_senhaNovoUsuario;
        private System.Windows.Forms.Label label_tituloNovoUsuario;
        private System.Windows.Forms.Panel panel_Login;
        private System.Windows.Forms.Panel panel_novoUsuario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_loginNovoUsuario;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Button buttonGravarPermissoes;
        private System.Windows.Forms.DataGridView dataGridView_Usuarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button buttonSelecionarUsuario;
    }
}

