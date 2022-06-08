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
    public partial class FrmProdutos : Form
    {

        Produto pr;
        Categoria ca;
        Marca ma;

        void LimpaControles()
        {
            
            txtID.Clear();
            txtDescricao.Clear();
            txtEstoque.Clear();
            txtPesquisa.Clear();
            cboCategoria.SelectedIndex=-1;
            cboMarca.SelectedIndex =-1;
            txtValorVenda.Clear();
            picFoto.ImageLocation = "";
            txtDescricao.Focus();
        }

        void CarregarGrid(string pesquisa)
        {

            pr = new Produto()
            {
                descricao = pesquisa
            };
            dgvProdutos.DataSource=pr.Consultar();

        }

        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {

            ca = new Categoria();
            cboCategoria.DataSource = ca.Consultar();
            cboCategoria.DisplayMember = "categoria";
            cboCategoria.ValueMember = "id";

            ma = new Marca();
            cboMarca.DataSource=ma.Consultar();
            cboMarca.DisplayMember = "marca";
            cboMarca.ValueMember = "id";

            LimpaControles();
            CarregarGrid("");

            dgvProdutos.Columns["idCategoria"].Visible = false;
            dgvProdutos.Columns["idMarca"].Visible = false;
            dgvProdutos.Columns["foto"].Visible = false;

        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboCategoria.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboCategoria.SelectedItem;
                
            }
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView reg = (DataRowView)cboMarca.SelectedItem;
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            ofdArquivo.InitialDirectory = "$USERPROFILE%";
            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();
            picFoto.ImageLocation = ofdArquivo.FileName;
            ofdArquivo.Multiselect = false;
        }

        private void ofdArquivo_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "") return;

            pr = new Produto()
            {
                descricao = txtDescricao.Text.ToUpper(),
                idCategoria = (int)cboCategoria.SelectedValue,
                idMarca = (int)cboMarca.SelectedValue,
                estoque = double.Parse(txtEstoque.Text),
                valorVenda=double.Parse(txtValorVenda.Text),
                foto = picFoto.ImageLocation
            };
            pr.Incluir();

            LimpaControles();
            CarregarGrid("");

            txtDescricao.Focus();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;

            pr = new Produto()
            {
                id = int.Parse(txtID.Text),
                descricao = txtDescricao.Text.ToUpper(),
                idCategoria = (int)cboCategoria.SelectedValue,
                idMarca = (int)cboMarca.SelectedValue,
                estoque = double.Parse(txtEstoque.Text),
                valorVenda = double.Parse(txtValorVenda.Text),
                foto = picFoto.ImageLocation
            };
            pr.Alterar();

            LimpaControles();
            CarregarGrid("");

            txtDescricao.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaControles();
            CarregarGrid("");

            txtDescricao.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Nenhum item selecionado para exclusão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("Deseja mesmo exluir o item selecionado?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    pr = new Produto()
                    {
                        id = int.Parse(txtID.Text)
                    };
                    pr.excluir();
                }                
            }
            LimpaControles();
            CarregarGrid("");

            txtDescricao.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CarregarGrid(txtPesquisa.Text);
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvProdutos.RowCount >0)
            {
                txtID.Text = dgvProdutos.CurrentRow.Cells["id"].Value.ToString();
                txtDescricao.Text = dgvProdutos.CurrentRow.Cells["descricao"].Value.ToString();
                cboCategoria.Text = dgvProdutos.CurrentRow.Cells["idCategoria"].Value.ToString();
                cboMarca.Text = dgvProdutos.CurrentRow.Cells["idMarca"].Value.ToString();
                txtEstoque.Text = dgvProdutos.CurrentRow.Cells["estoque"].Value.ToString();
                txtValorVenda.Text = dgvProdutos.CurrentRow.Cells["valorVenda"].Value.ToString();
                picFoto.ImageLocation = dgvProdutos.CurrentRow.Cells["foto"].Value.ToString();
            }
        }
    }
}
