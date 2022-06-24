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
    public class VendaCab
    {

        public int id { get; set; }

        public int idCliente { get; set; }

        public DateTime data { get; set; }

        public double total { get; set; }

        // 

        public int Incluir()
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand(
                    "Insert into vendaCab(idCliente, data, total) " +
                    "Values(@idCliente, @data, @total)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@idCliente", idCliente);
                Banco.Comando.Parameters.AddWithValue("@data", data);
                Banco.Comando.Parameters.AddWithValue("@total", total);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();
                return (int)Banco.Comando.LastInsertedId;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

    }

    

}
