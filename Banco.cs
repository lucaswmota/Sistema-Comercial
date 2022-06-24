using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14688
{
    public class Banco
    {

        // Criando variaveis publicas para conexao e consulta serão usadas
        
        // Connection responsavel pela conexao com MySql
        public static MySqlConnection Conexao;

        // Command responsavel pelas instrucoes SQL a serem executadas
        public static MySqlCommand Comando;

        // Adapter responsavel por inserir dados em um DataTable
        public static MySqlDataAdapter Adaptador;

        // DataTable responsavel por ligar o banco em controles com a propriedade...
        public static DataTable datTabela;

        
        
        // FUncao para Abrir COnexao
        public static void AbrirConexao()
        {
            try
            {
                // Estabelece os parametros para a conexao com o banco
                // porta SQL 3307 / porta Wamp 3306 (Padrao)

                Conexao = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau");

                // Abre a conexao com o banco dados
                Conexao.Open();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Funcao para Fechar COnexao
        public static void FecharConexao()
        {
            //Fecha a conexao com o banco de dados
            try
            {
                Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public static void CriarBanco()
        {
            try
            {
                // Chama a funcao para abertura de conexao com o banco
                AbrirConexao();

                // Informa a INstrucao SQL
                Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS vendas; USE vendas;", Conexao);
                // Executa a Query o MySql (Raio do Workbench)
                Comando.ExecuteNonQuery();

                // Cria Tabela CIDADES

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS cidades " +
                    "(id integer auto_increment primary key, " +
                    "nome char(40), " +
                    "uf char(02));", Conexao);
                Comando.ExecuteNonQuery();

                // Cria Tabela MARCAS

                Comando=new MySqlCommand("CREATE TABLE IF NOT EXISTS marcas " +
                    "(id integer auto_increment primary key," +
                    "marca char(20));", Conexao);
                Comando.ExecuteNonQuery();

                // Cria Tabela Categorias

                Comando=new MySqlCommand("CREATE TABLE IF NOT EXISTS categorias " +
                    "(id integer auto_increment primary key, " +
                    "categoria char(20));", Conexao);
                Comando.ExecuteNonQuery();

                // Cria tabela Clientes

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS clientes " +
                    "(id integer auto_increment primary key, " +
                    "nome char(40)," +
                    "idCidade integer," +
                    "dataNasc date," +
                    "renda decimal(10,2), " +
                    "cpf char(14)," +
                    "foto varchar(100)," +
                    "venda boolean)", Conexao);
                Comando.ExecuteNonQuery();

                // Cria Tabela Produtos

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS produtos " +
                    "(id integer auto_increment primary key, " +
                    "descricao char(40), " +
                    "idCategoria integer, " +
                    "idMarca integer, " +
                    "estoque decimal(10,3), " +
                    "valorVenda decimal(10,2), " +
                    "foto varchar(100))", Conexao);
                Comando.ExecuteNonQuery();

                // Cria tabela Venda Cabecalho

                Comando = new MySqlCommand("Create table if not exists vendaCab " +
                    "(id integer auto_increment primary key, " +
                    "idCliente int, " +
                    "data date, " +
                    "total decimal(10,2))", Conexao);
                Comando.ExecuteNonQuery();

                // Cria tabela venda Detalhe

                Comando = new MySqlCommand("Create table if not exists vendaDet " +
                    "(id integer auto_increment primary key, " +
                    "idVendaCab int, " +
                    "idProduto int, " +
                    "qtde decimal(10,3), " +
                    "valorUnitario decimal(10,2))", Conexao);
                Comando.ExecuteNonQuery();

                // Chama a funcao para fechar a conexao com o banco
                FecharConexao();


            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }








    }
}
