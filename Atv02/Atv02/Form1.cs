using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atv02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void consultarUsuarios()
        {
            Banco banco = new Banco();
            dataGridView_Usuarios.DataSource = banco.executaConsulta("select principal_id, name, create_date from sys.sql_logins where name not like '#%' and principal_id >1;");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            if(banco.User == txtLogin.Text && banco.Password == txtSenha.Text)
            {
                dataGridView_BDs.DataSource = banco.executaConsulta("select database_id, name, create_date from sys.databases where database_id > 4;");
                consultarUsuarios();
                btnUsuario.Enabled = true;
                txtLoginUsuario.ReadOnly = false;
                txtSenhaUsuario.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("Login e/ou senha incorreto", "ERRO!");
            }
        }

        private void btnListarTabelas_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            banco.Db = dataGridView_BDs.CurrentRow.Cells[1].Value.ToString();
            dataGridView_Tabelas.DataSource = banco.executaConsulta("select table_catalog, table_schema, table_name, table_type from information_schema.tables;");
            //LEMBRAR DE DAR PERMISSÃO AO USUARIO NO SQLSERVER PARA CADA BANCO DE DADOS e PARA O USUARIO IR EM MECANISMO DE SEGURANÇA E ATIVAR SYSADMIN
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario(txtLoginUsuario.Text, txtSenhaUsuario.Text, dataGridView_BDs.CurrentRow.Cells[1].Value.ToString());
            consultarUsuarios();
            //bool aux = u.gravarUsuario();
            if (u.gravarUsuario())
            {
                MessageBox.Show("Sucesso!");
            }
            else
            {
                MessageBox.Show("Deu xabu");
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tabela = dataGridView_Tabelas.CurrentRow.Cells[2].Value.ToString();
            string usuario = dataGridView_Usuarios.CurrentRow.Cells[1].Value.ToString();
            string permissao;
            MessageBox.Show(tabela + " e " + usuario);
            Usuario u = new Usuario();
            if (radioButton1.Checked)
            {
                permissao = "grant";
                u.permissoes(permissao, tabela, usuario);
            }
            else if (radioButton2.Checked)
            {
                permissao = "deny";
                u.permissoes(permissao, tabela, usuario);
            }
            else if (radioButton3.Checked)
            {
                permissao = "revoke";
                u.permissoes(permissao, tabela, usuario);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            banco.Db = dataGridView_BDs.CurrentRow.Cells[1].Value.ToString();
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            buttonGravarPermissoes.Enabled = true;
        }
    }
}
