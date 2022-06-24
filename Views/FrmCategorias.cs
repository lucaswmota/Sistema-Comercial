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

namespace _14688.Views
{

    public partial class FrmCategorias : Form
    {

        Categoria c;

        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void LimpaControles()
        {
            txtID.Clear();
            txtNome.Clear();
            txtPesquisa.Clear();
        }

        void CarregarGrid(string pesquisa)
        {
            c = new Categoria()
            {
                categoria = pesquisa
            };
            dgvCategorias.DataSource = c.Consultar();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            LimpaControles();
            CarregarGrid("");
            txtNome.Focus();
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            btnIncluir.Enabled = false;

            if (dgvCategorias.RowCount > 0)
            {
                txtID.Text = dgvCategorias.CurrentRow.Cells["id"].Value.ToString();
                txtNome.Text = dgvCategorias.CurrentRow.Cells["categoria"].Value.ToString();
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == String.Empty) return;

            c = new Categoria()
            {
                categoria = txtNome.Text.ToUpper()
            };
            c.Incluir();

            LimpaControles();
            CarregarGrid("");

            txtNome.Focus();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text == "" || txtNome.Text == null)
            {
                return;
            }
            else
            {
                btnIncluir.Enabled = false;


                c = new Categoria()
                {
                    id = int.Parse(txtID.Text),
                    categoria = txtNome.Text.ToUpper()
                };
                c.Alterar();

                LimpaControles();
                CarregarGrid("");

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
                if (MessageBox.Show("Deseja Mesmo Excluir?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    c = new Categoria()
                    {
                        id = int.Parse(txtID.Text)
                    };
                    c.Excluir();

                }
            }
            LimpaControles();
            CarregarGrid("");

            txtNome.Focus();



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaControles();
            CarregarGrid("");

            txtNome.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if(txtPesquisa.Text != "" || txtPesquisa.Text != null)
            {
                CarregarGrid(txtPesquisa.Text);
            }
            else
            {
                MessageBox.Show("Digite algo para Pesquisar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPesquisa.Focus();
            }
            
        }

        private void FrmCategorias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
               if (txtNome.Text=="")
                {
                    this.Close();
                }
               else
;
            }
        }
    }
}

