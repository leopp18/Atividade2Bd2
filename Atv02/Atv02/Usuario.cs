using System;
using System.Data;
using System.Data.SqlClient;

namespace Atv02
{
    internal class Usuario
    {
        public int id;
        public string usuario;
        public string password;
        public string banco;

        public Usuario(string usuario, string password, string banco)
        {
            this.usuario = usuario;
            this.password = password;
            this.banco = banco;
        }

        public void executarTransacao(SqlCommand comando, SqlTransaction transacao)
        {
            try
            {
                comando.ExecuteNonQuery();
                transacao.Commit();
            }
            catch (Exception ex)
            {
                transacao.Rollback();
            }
        }

        public bool gravarUsuario()
        {
            Banco bd = new Banco();
            bd.Db = banco;
            //Console.WriteLine(banco + " Printando Banco");
            SqlConnection cn = bd.abrirConexao();

            SqlTransaction transacao = cn.BeginTransaction();
            SqlCommand comando1 = new SqlCommand();
            SqlCommand comando2 = new SqlCommand();
            SqlCommand comando3 = new SqlCommand();

            comando1.Connection = cn;
            comando1.Transaction = transacao;
            comando1.CommandType = CommandType.Text;

            comando2.Connection = cn;
            comando2.Transaction = transacao;
            comando2.CommandType = CommandType.Text;

            comando3.Connection = cn;
            comando3.Transaction = transacao;
            comando3.CommandType = CommandType.Text;
            //Message
            try
            {

                //comando1.CommandText = "create login @usuario with password= @password;";
                //comando1.Parameters.Add("@usuario", SqlDbType.VarChar);
                //comando1.Parameters.Add("@password", SqlDbType.VarChar);
                //comando1.Parameters[0].Value = usuario;
                //comando1.Parameters[1].Value = password;
                comando1.CommandText = "create login '" + usuario + "' with password='" + password+ "';";
                Console.WriteLine("Usuario " + usuario + " Senha: " + password);

                executarTransacao(comando1, transacao);
                
                comando2.CommandText = "create user '" + usuario + "' from login '" + usuario + "';";
                //comando2.Parameters.Add("@usuario", SqlDbType.VarChar);
                //comando2.Parameters.Add("@usuario2", SqlDbType.VarChar);
                //comando2.Parameters[0].Value = usuario;
                //comando2.Parameters[1].Value = usuario;

                Console.WriteLine("Antes do comando 2 com " + usuario);
                executarTransacao(comando2, transacao);
                Console.WriteLine("Depois do comando 2");

                comando3.CommandText = "exec sp_addrolemember 'DB_DATAREADER', '" + usuario + "';" + "exec sp_addrolemember 'DB_DATAWRITER', '" + usuario + "';";
                //comando3.Parameters.Add("@usuario", SqlDbType.VarChar);
                //comando3.Parameters[0].Value = usuario;
                executarTransacao(comando3, transacao);
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }


        }
    }
}
