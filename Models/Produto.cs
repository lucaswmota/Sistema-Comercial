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
    public class Produto
    {

        public int id { get; set; }
        public string descricao { get; set; }
        public int idCategoria { get; set; }   
        public int idMarca { get; set; }
        public double estoque { get; set; }
        public double valorVenda { get; set; }
        public string foto { get; set; }

        public DataTable Consultar()
        {
            try
            {
                Banco.Comando = new MySqlCommand("select pr.*, ca.categoria categoria, ma.marca marca " +
                    "from produtos pr " +
                    "inner join categorias ca on (ca.id = pr.idCategoria) " +
                    "inner join marcas ma on (ma.id = pr.idMarca) " +
                    "where pr.descricao like @descricao order by pr.descricao", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@descricao", descricao + "%");
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.datTabela = new DataTable();
                Banco.Adaptador.Fill(Banco.datTabela);
                return Banco.datTabela;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void Incluir()
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand("insert into produtos (descricao, " +
                    "idCategoria, " +
                    "idMarca, " +
                    "estoque, " +
                    "valorVenda, " +
                    "foto) " +
                    "values " +
                    "(@descricao, " +
                    "@idCategoria, " +
                    "@idMarca, " +
                    "@estoque, " +
                    "@valorVenda, " +
                    "@foto)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@descricao", descricao);
                Banco.Comando.Parameters.AddWithValue("@idCategoria", idCategoria);
                Banco.Comando.Parameters.AddWithValue("@idMarca", idMarca);
                Banco.Comando.Parameters.AddWithValue("@estoque", estoque);
                Banco.Comando.Parameters.AddWithValue("@valorVenda", valorVenda);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();

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
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand("update produtos set " +
                    "descricao=@descricao, " +
                    "idCategoria=@idCategoria, " +
                    "idMarca=@idMarca, " +
                    "estoque=@estoque " +
                    "valorvenda=@valorVenda, " +
                    "foto=@foto", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@descricao", descricao);
                Banco.Comando.Parameters.AddWithValue("@idCategoria", idCategoria);
                Banco.Comando.Parameters.AddWithValue("@idMarca", idMarca);
                Banco.Comando.Parameters.AddWithValue("@estoque", estoque);
                Banco.Comando.Parameters.AddWithValue("@valorVenda", valorVenda);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void excluir()
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand("Delete from produtos where id=@id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
