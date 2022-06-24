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
    public partial class FrmClientes : Form
    {
        Cidade ci;
        Cliente cl;

        void limpaControles()
        {
            txtID.Clear();
            txtNome.Clear();
            cboCidades.SelectedIndex = -1;
            txtUF.Clear();
            mskCPF.Clear();
            txtRenda.Clear();
            dtpDataNascimento.Value=DateTime.Now;
            picFoto.ImageLocation = "";
            chkVenda.Checked = false;
        }

        void carregarGrid(string pesquisa)
        {
            cl = new Cliente()
            {
                nome = pesquisa
            };
            dgvClientes.DataSource = cl.Consultar();
        }

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            // Cria um objeto do tipo Cidade
            // e alimenta o comboBox
            ci = new Cidade();
            cboCidades.DataSource = ci.Consultar();
            cboCidades.DisplayMember = "nome";
            cboCidades.ValueMember = "id";

            limpaControles();
            carregarGrid("");

            // deixa invisivel colunas do Grid
            dgvClientes.Columns["idCidade"].Visible = false;
            dgvClientes.Columns["foto"].Visible = false;
        }

        private void cboCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboCidades.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboCidades.SelectedItem;
                txtUF.Text = reg["uf"].ToString();
            }
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            ofdArquivo.InitialDirectory = "&userprofile%";
            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();
            picFoto.ImageLocation = ofdArquivo.FileName;
            ofdArquivo.Multiselect = false;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == "" || txtNome.Text == null) return;

                cl = new Cliente()
                {
                    nome = txtNome.Text.ToUpper(),
                    idCidade = (int)cboCidades.SelectedValue,
                    dataNasc = dtpDataNascimento.Value,
                    renda = double.Parse(txtRenda.Text),
                    cpf = mskCPF.Text,
                    foto = picFoto.ImageLocation,
                    venda = chkVenda.Checked
                };
                cl.Incluir();

                limpaControles();
                carregarGrid("");
                txtNome.Focus();
            }
            catch(Exception)
            {
                MessageBox.Show("Confira os Dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cboCidades_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvClientes.RowCount >0)
            {
                btnIncluir.Enabled = false;

                txtID.Text = dgvClientes.CurrentRow.Cells["id"].Value.ToString();
                txtNome.Text = dgvClientes.CurrentRow.Cells["nome"].Value.ToString();
                cboCidades.Text = dgvClientes.CurrentRow.Cells["cidade"].Value.ToString();
                txtUF.Text = dgvClientes.CurrentRow.Cells["uf"].Value.ToString();
                chkVenda.Checked = (bool)dgvClientes.CurrentRow.Cells["venda"].Value;
                mskCPF.Text = dgvClientes.CurrentRow.Cells["cpf"].Value.ToString();
                dtpDataNascimento.Text = dgvClientes.CurrentRow.Cells["dataNasc"].Value.ToString();
                txtRenda.Text = dgvClientes.CurrentRow.Cells["renda"].Value.ToString();
                picFoto.ImageLocation = dgvClientes.CurrentRow.Cells["foto"].Value.ToString();
            }
        }

        private void ofdArquivo_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtID.Text == null)
            { 
                return;
            }
            else
            {

                btnIncluir.Enabled = false;

                cl = new Cliente()
                {
                    id = int.Parse(txtID.Text),
                    nome = txtNome.Text.ToUpper(),
                    idCidade = (int)cboCidades.SelectedValue,
                    dataNasc = dtpDataNascimento.Value,
                    renda = double.Parse(txtRenda.Text),
                    cpf = mskCPF.Text,
                    foto = picFoto.ImageLocation,
                    venda = chkVenda.Checked
                };

                cl.Alterar();

                limpaControles();
                carregarGrid("");

                txtNome.Focus();

                btnIncluir.Enabled = true;

            }

            
        }

        private void FrmClientes_TextChanged(object sender, EventArgs e)
        {

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
                    cl = new Cliente()
                    {
                        id = int.Parse(txtID.Text)
                    };
                    cl.Excluir();

                }
            }

            limpaControles();
            carregarGrid("");

            txtNome.Focus();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaControles();
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

        private void txtRenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
