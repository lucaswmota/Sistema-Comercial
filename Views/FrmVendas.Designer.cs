namespace _14688.Views
{
    partial class FrmVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.MaskedTextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRenda = new System.Windows.Forms.TextBox();
            this.chkVenda = new System.Windows.Forms.CheckBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboProdutos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.picCliente = new System.Windows.Forms.PictureBox();
            this.picProduto = new System.Windows.Forms.PictureBox();
            this.grpBCliente = new System.Windows.Forms.GroupBox();
            this.mskDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.grpBProdutos = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).BeginInit();
            this.grpBCliente.SuspendLayout();
            this.grpBProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(75, 13);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(443, 21);
            this.cboClientes.TabIndex = 1;
            this.cboClientes.SelectedIndexChanged += new System.EventHandler(this.cboClientes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cidade";
            // 
            // txtUF
            // 
            this.txtUF.Enabled = false;
            this.txtUF.Location = new System.Drawing.Point(418, 40);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(100, 20);
            this.txtUF.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nascimento";
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(75, 40);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(337, 20);
            this.txtCidade.TabIndex = 6;
            // 
            // mskCPF
            // 
            this.mskCPF.Enabled = false;
            this.mskCPF.Location = new System.Drawing.Point(245, 67);
            this.mskCPF.Mask = "999.999.999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(100, 20);
            this.mskCPF.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Renda";
            // 
            // txtRenda
            // 
            this.txtRenda.Enabled = false;
            this.txtRenda.Location = new System.Drawing.Point(418, 67);
            this.txtRenda.Name = "txtRenda";
            this.txtRenda.Size = new System.Drawing.Size(100, 20);
            this.txtRenda.TabIndex = 10;
            // 
            // chkVenda
            // 
            this.chkVenda.AutoSize = true;
            this.chkVenda.Location = new System.Drawing.Point(75, 103);
            this.chkVenda.Name = "chkVenda";
            this.chkVenda.Size = new System.Drawing.Size(110, 17);
            this.chkVenda.TabIndex = 2;
            this.chkVenda.Text = "Bloqueia a Venda";
            this.chkVenda.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(418, 92);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 37);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Produto";
            // 
            // cboProdutos
            // 
            this.cboProdutos.FormattingEnabled = true;
            this.cboProdutos.Location = new System.Drawing.Point(75, 13);
            this.cboProdutos.Name = "cboProdutos";
            this.cboProdutos.Size = new System.Drawing.Size(443, 21);
            this.cboProdutos.TabIndex = 4;
            this.cboProdutos.SelectedIndexChanged += new System.EventHandler(this.cboProdutos_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(75, 40);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(443, 20);
            this.txtMarca.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Categoria";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Location = new System.Drawing.Point(75, 66);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(281, 20);
            this.txtCategoria.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Quantidade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Preço";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Estoque";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(75, 92);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(57, 20);
            this.txtQuantidade.TabIndex = 5;
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(179, 92);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(69, 20);
            this.txtPreco.TabIndex = 23;
            this.txtPreco.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtEstoque
            // 
            this.txtEstoque.Enabled = false;
            this.txtEstoque.Location = new System.Drawing.Point(301, 92);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(55, 20);
            this.txtEstoque.TabIndex = 24;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(362, 65);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 47);
            this.btnInserir.TabIndex = 25;
            this.btnInserir.Text = "Inserir Produto";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(443, 66);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 47);
            this.btnRemover.TabIndex = 26;
            this.btnRemover.Text = "Remover Produto";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToOrderColumns = true;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.produto,
            this.quantidade,
            this.valor});
            this.dgvProdutos.Location = new System.Drawing.Point(9, 287);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(637, 150);
            this.dgvProdutos.TabIndex = 27;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // picCliente
            // 
            this.picCliente.Location = new System.Drawing.Point(524, 20);
            this.picCliente.Name = "picCliente";
            this.picCliente.Size = new System.Drawing.Size(100, 100);
            this.picCliente.TabIndex = 28;
            this.picCliente.TabStop = false;
            // 
            // picProduto
            // 
            this.picProduto.Location = new System.Drawing.Point(524, 13);
            this.picProduto.Name = "picProduto";
            this.picProduto.Size = new System.Drawing.Size(100, 100);
            this.picProduto.TabIndex = 29;
            this.picProduto.TabStop = false;
            // 
            // grpBCliente
            // 
            this.grpBCliente.Controls.Add(this.mskDataNasc);
            this.grpBCliente.Controls.Add(this.cboClientes);
            this.grpBCliente.Controls.Add(this.picCliente);
            this.grpBCliente.Controls.Add(this.label1);
            this.grpBCliente.Controls.Add(this.txtUF);
            this.grpBCliente.Controls.Add(this.label2);
            this.grpBCliente.Controls.Add(this.txtCidade);
            this.grpBCliente.Controls.Add(this.label3);
            this.grpBCliente.Controls.Add(this.mskCPF);
            this.grpBCliente.Controls.Add(this.txtRenda);
            this.grpBCliente.Controls.Add(this.label4);
            this.grpBCliente.Controls.Add(this.label5);
            this.grpBCliente.Controls.Add(this.chkVenda);
            this.grpBCliente.Controls.Add(this.btnConfirmar);
            this.grpBCliente.Location = new System.Drawing.Point(9, 6);
            this.grpBCliente.Name = "grpBCliente";
            this.grpBCliente.Size = new System.Drawing.Size(637, 143);
            this.grpBCliente.TabIndex = 30;
            this.grpBCliente.TabStop = false;
            this.grpBCliente.Enter += new System.EventHandler(this.grpBCliente_Enter);
            // 
            // mskDataNasc
            // 
            this.mskDataNasc.Enabled = false;
            this.mskDataNasc.Location = new System.Drawing.Point(73, 67);
            this.mskDataNasc.Mask = "99/99/9999";
            this.mskDataNasc.Name = "mskDataNasc";
            this.mskDataNasc.Size = new System.Drawing.Size(100, 20);
            this.mskDataNasc.TabIndex = 29;
            // 
            // grpBProdutos
            // 
            this.grpBProdutos.Controls.Add(this.picProduto);
            this.grpBProdutos.Controls.Add(this.label10);
            this.grpBProdutos.Controls.Add(this.label6);
            this.grpBProdutos.Controls.Add(this.label9);
            this.grpBProdutos.Controls.Add(this.cboProdutos);
            this.grpBProdutos.Controls.Add(this.btnRemover);
            this.grpBProdutos.Controls.Add(this.txtMarca);
            this.grpBProdutos.Controls.Add(this.btnInserir);
            this.grpBProdutos.Controls.Add(this.label7);
            this.grpBProdutos.Controls.Add(this.label11);
            this.grpBProdutos.Controls.Add(this.txtPreco);
            this.grpBProdutos.Controls.Add(this.txtEstoque);
            this.grpBProdutos.Controls.Add(this.txtCategoria);
            this.grpBProdutos.Controls.Add(this.label8);
            this.grpBProdutos.Controls.Add(this.txtQuantidade);
            this.grpBProdutos.Location = new System.Drawing.Point(9, 155);
            this.grpBProdutos.Name = "grpBProdutos";
            this.grpBProdutos.Size = new System.Drawing.Size(637, 126);
            this.grpBProdutos.TabIndex = 31;
            this.grpBProdutos.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 449);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(100, 449);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 13);
            this.lblTotal.TabIndex = 33;
            this.lblTotal.Text = "R$ 0,00";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(409, 444);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(490, 444);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(571, 444);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // produto
            // 
            this.produto.HeaderText = "PRODUTO";
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "QUANTIDADE";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.HeaderText = "VALOR";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 492);
            this.ControlBox = false;
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.grpBCliente);
            this.Controls.Add(this.grpBProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).EndInit();
            this.grpBCliente.ResumeLayout(false);
            this.grpBCliente.PerformLayout();
            this.grpBProdutos.ResumeLayout(false);
            this.grpBProdutos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtCidade;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRenda;
        private System.Windows.Forms.CheckBox chkVenda;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboProdutos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.PictureBox picCliente;
        private System.Windows.Forms.PictureBox picProduto;
        private System.Windows.Forms.GroupBox grpBCliente;
        private System.Windows.Forms.GroupBox grpBProdutos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.MaskedTextBox mskDataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
    }
}