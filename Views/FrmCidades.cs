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
    public partial class FrmCidades : Form
    {

        Cidade c;


        public FrmCidades()
        {
            
            InitializeComponent();
        }

        void limpaControles()
        {
            txtID.Clear();
            txtNome.Clear();
            txtUF.Clear();
            txtPesquisa.Clear();
        }

        void CarregarGrid(string pesquisa)
        {
            c = new Cidade()
            {
                nome = pesquisa
            };
            dgvCidades.DataSource = c.Consultar();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCidades_Load(object sender, EventArgs e)
        {
            limpaControles();
            CarregarGrid("");
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == String.Empty) return;

            c = new Cidade()
            {
                nome = txtNome.Text.ToUpper(),
                uf = txtUF.Text.ToUpper()
            };
            c.Incluir();

            limpaControles();
            CarregarGrid("");

            txtNome.Focus();
        }

        private void dgvCidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvCidades.RowCount >0)
            {
                txtID.Text = dgvCidades.CurrentRow.Cells["id"].Value.ToString();
                txtNome.Text = dgvCidades.CurrentRow.Cells["nome"].Value.ToString();
                txtUF.Text = dgvCidades.CurrentRow.Cells["uf"].Value.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(txtID.Text== String.Empty) return;

            c = new Cidade()
            {
                id = int.Parse(txtID.Text),
                nome = txtNome.Text.ToUpper(),
                uf = txtUF.Text.ToUpper()

            };
            c.Alterar();

            limpaControles();
            CarregarGrid("");

            txtNome.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Nenhum item selecionado para exclusão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("Deseja mesmo exluir?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    c = new Cidade()
                    {
                        id = int.Parse(txtID.Text),
                        nome = txtNome.Text.ToUpper(),
                        uf = txtUF.Text.ToUpper()

                    };
                    c.Excluir();
                }


                limpaControles();
                CarregarGrid("");

                txtNome.Focus();


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaControles();

            CarregarGrid("");

            txtNome.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CarregarGrid(txtPesquisa.Text);
        }
    }
}