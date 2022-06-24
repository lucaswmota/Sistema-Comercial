using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _14688.Models;
using MySql.Data.MySqlClient;


namespace _14688.Views
{
    public partial class FrmMarcas : Form
    {

        Marca c;

        void carregarGrid(string pesquisa)
        {
            c = new Marca()
            {
                marca = pesquisa
            };
            dgvMarcas.DataSource = c.Consultar();

        }

        public FrmMarcas()
        {
            InitializeComponent();


        }
        void LimpaControles()
        {
            txtID.Clear();
            txtNome.Clear();
        }

        
        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            LimpaControles();
            carregarGrid("");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == String.Empty) return;

            c = new Marca()
            {
                marca = txtNome.Text.ToUpper()

            };
            c.Incluir();

            LimpaControles();
            carregarGrid("");

            txtNome.Focus();
        }

        private void dgvMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMarcas.RowCount > 0)
            {
                btnIncluir.Enabled = false;

                txtID.Text=dgvMarcas.CurrentRow.Cells["id"].Value.ToString();
                txtNome.Text=dgvMarcas.CurrentRow.Cells["marca"].Value.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {


            if (txtNome.Text == String.Empty || txtNome.Text == null)
            {
                return;
            }
            else
            {
                btnIncluir.Enabled = false;

                c = new Marca()
                {
                    id = int.Parse(txtID.Text),
                    marca = txtNome.Text.ToUpper()
                };

                c.Alterar();

                LimpaControles();
                carregarGrid("");

                txtNome.Focus();

                btnIncluir.Enabled = true;
            }

            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Nenhum item selecionado para exclusão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("Deseja Excluir a Marca?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    c = new Marca()
                    {
                        id = int.Parse(txtID.Text.ToUpper())
                    };
                    c.Excluir();

                }
            }
            LimpaControles();
            carregarGrid("");

            txtNome.Focus();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaControles();

            carregarGrid("");

            txtNome.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text != "" || txtPesquisa.Text != null)
            {
                carregarGrid(txtPesquisa.Text);
            }
            else
            {
                MessageBox.Show("Digite algo para Pesquisar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPesquisa.Focus();
            }
        }
    } 
}

    



