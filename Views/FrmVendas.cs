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
    public partial class FrmVendas : Form
    {

        double total;

        Cliente cl;
        Produto pr;
        VendaCab vc;
        VendaDet vd;

        void limpaProduto()
        {
            cboProdutos.SelectedIndex = -1;
            txtEstoque.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
            txtMarca.Clear();
            txtCategoria.Clear();
            picProduto.ImageLocation = "";
        }

        void CarregarTela()
        {
            dgvProdutos.RowCount = 0;
            cboClientes.SelectedIndex = -1;
            txtCidade.Clear();
            txtUF.Clear();
            txtRenda.Clear();
            mskCPF.Clear();
            mskDataNasc.Clear();
            chkVenda.Checked = false;
            picCliente.ImageLocation = "";
            total = 0;
            lblTotal.Text = total.ToString("C");
            grpBCliente.Enabled = true;
            grpBProdutos.Enabled = false;

            limpaProduto();
        }

        public FrmVendas()
        {
            InitializeComponent();

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            cl = new Cliente();
            cboClientes.DataSource = cl.Consultar();
            cboClientes.DisplayMember = "nome";
            cboClientes.ValueMember = "id";

            pr = new Produto();
            cboProdutos.DataSource = pr.Consultar();
            cboProdutos.DisplayMember = "descricao";
            cboProdutos.ValueMember = "id";

            CarregarTela();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo Cancelar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                dgvProdutos.RowCount = 0;
                cboClientes.SelectedIndex = -1;
                txtCidade.Clear();
                txtUF.Clear();
                txtRenda.Clear();
                mskCPF.Clear();
                mskDataNasc.Clear();
                chkVenda.Checked = false;
                picCliente.ImageLocation = "";
                total = 0;
                lblTotal.Text = total.ToString("C");
                grpBCliente.Enabled = true;
                grpBProdutos.Enabled = false;

                limpaProduto();
            }
        }

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboClientes.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboClientes.SelectedItem;
                txtCidade.Text = reg["cidade"].ToString();
                txtUF.Text = reg["uf"].ToString();
                txtRenda.Text = reg["renda"].ToString();
                mskCPF.Text = reg["cpf"].ToString();
                mskDataNasc.Text = reg["datanasc"].ToString();
                picCliente.ImageLocation = reg["foto"].ToString();
                chkVenda.Checked = (bool)reg["venda"];
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            
            if(cboClientes.SelectedIndex != -1)
            {
                if(chkVenda.Checked)
                {
                    MessageBox.Show("Cliente Bloqueado para Venda", "Vendas", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnCancelar.PerformClick();
                    return;
                }
                grpBCliente.Enabled = false;
                grpBProdutos.Enabled = true;
            }
            else
            {
                MessageBox.Show("Selecione um Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cboProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(cboProdutos.SelectedIndex !=-1)
            {
                DataRowView reg = (DataRowView)cboProdutos.SelectedItem;
                txtEstoque.Text = reg["estoque"].ToString();
                txtPreco.Text = reg["valorVenda"].ToString();
                txtMarca.Text = reg["marca"].ToString();
                txtCategoria.Text = reg["categoria"].ToString();
                picProduto.ImageLocation = reg["foto"].ToString();
            }

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
           
            if(cboProdutos.SelectedIndex ==-1)
            {
                MessageBox.Show("Selecione um Produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtQuantidade.Text == null || txtQuantidade.Text == "")
            {
                MessageBox.Show("Defina a Quantidade de Produtos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtQuantidade.Focus();
            }
            else
            {

                double quantidade = double.Parse(txtQuantidade.Text);
                double estoque = double.Parse(txtEstoque.Text);

                if (quantidade > estoque)
                {
                    MessageBox.Show("Estoque Insuficiente", "Vendas",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtQuantidade.SelectAll();
                    return;
                }

                dgvProdutos.Rows.Add(cboProdutos.SelectedValue,
                    cboProdutos.Text, txtQuantidade.Text, txtPreco.Text);

                double preco = double.Parse(txtPreco.Text);

                total += quantidade * preco;

                lblTotal.Text = total.ToString("C");

                limpaProduto();

            }


        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(dgvProdutos.RowCount > 0)
            {
                double quantidade = double.Parse(dgvProdutos.CurrentRow.Cells["quantidade"].Value.ToString());
                double preco = double.Parse(dgvProdutos.CurrentRow.Cells["valor"].Value.ToString());

                total -= quantidade * preco;
                lblTotal.Text = total.ToString("C");

                dgvProdutos.Rows.RemoveAt(dgvProdutos.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Não há Produtos para Remover", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void btnGravar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.RowCount <= 0)
            {
                MessageBox.Show("Não há produtos para Gravar a venda", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {


                vc = new VendaCab()
                {
                    idCliente = (int)cboClientes.SelectedValue,
                    data = DateTime.Now,
                    total = total
                };

                int idVenda = vc.Incluir();

                foreach (DataGridViewRow linha in dgvProdutos.Rows)
                {

                    vd = new VendaDet()
                    {
                        idVendaCab = idVenda,
                        idProduto = Convert.ToInt32(linha.Cells[0].Value),
                        qtde = Convert.ToDouble(linha.Cells[2].Value),
                        valorUnitario = Convert.ToDouble(linha.Cells[3].Value)
                    };
                    vd.Incluir();

                    pr = new Produto()
                    {
                        id = (int)linha.Cells[0].Value
                    };
                    pr.atualizaEstoque(Convert.ToDouble(linha.Cells["quantidade"].Value));

                }
                btnCancelar.PerformClick();

            }

        }

        private void grpBCliente_Enter(object sender, EventArgs e)
        {

        }
    }
}
