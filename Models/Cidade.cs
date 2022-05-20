using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;


namespace _14688.Models
{

    public class Cidade
    {
        // GET Lê a informação do Atributo
        // SET Grava informações no atributo

        public int id { get; set; }

        public string nome { get; set; }

        public string uf { get; set; }


        // Consultar

        public DataTable Consultar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("SELECT * FROM Cidades where nome like ?Nome order by nome", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@Nome", nome + "%");
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.datTabela = new DataTable();
                Banco.Adaptador.Fill(Banco.datTabela);
                Banco.FecharConexao();
                return Banco.datTabela;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // incluir

        public void Incluir()
        {
            try
            {
                //abre a conexao com o banco

                Banco.AbrirConexao();

                //alimenta o metodo command com a instrucao desejada e indica a conexao utilizada

                Banco.Comando = new MySqlCommand("INSERT INTO cidades (nome, uf) VALUES (@nome, @uf)", Banco.Conexao);

                //cria os parametros utilirzados na instrucao sql com seu respectivo conteudo

                Banco.Comando.Parameters.AddWithValue("@nome", nome); // parametro string

                Banco.Comando.Parameters.AddWithValue("@uf", uf);

                //executa o comando, no mysql, tem a funcao do raio do workbench

                Banco.Comando.ExecuteNonQuery();

                //fecha a conexao

                Banco.FecharConexao();

            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Alterar()
        {
            try
            {
                // abre a conexao com o banco
                Banco.AbrirConexao();

                //Alimenta o metodo command com a instrucao desejada e indica a conexao utilizada

                Banco.Comando = new MySqlCommand("Update cidades set nome= @nome, uf=@uf where id=@id", Banco.Conexao);

                // cria os parametros utiliDOS NA INSTRUCAo SQL com seu respectivo conteudo
                Banco.Comando.Parameters.AddWithValue("@nome", nome); // parametro string
                Banco.Comando.Parameters.AddWithValue("@uf", uf);
                Banco.Comando.Parameters.AddWithValue("@id", id);

                //Executa o comando no mysql com afuncao do raio
                Banco.Comando.ExecuteNonQuery();

                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            public void Excluir()
            {
            try
            {
                // abre a conexao com o banco
                Banco.AbrirConexao();

                //Alimenta o metodo command com a instrucao desejada e indica a conexao utilizada

                Banco.Comando = new MySqlCommand("delete from cidades where id=@id", Banco.Conexao);

                // cria os parametros utiliDOS NA INSTRUCAo SQL com seu respectivo conteudo
                Banco.Comando.Parameters.AddWithValue("@id", id);

                //Executa o comando no mysql com afuncao do raio
                Banco.Comando.ExecuteNonQuery();

                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
            

            
        


    }
}
