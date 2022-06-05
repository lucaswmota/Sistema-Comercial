namespace _14688.Views
{
    partial class FrmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutos));
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // ofdArquivo
            // 
            this.ofdArquivo.FileName = "openFileDialog1";
            this.ofdArquivo.Filter = "|*.jpg||*.png||*.jpeg||*.*";
            this.ofdArquivo.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdArquivo_FileOk);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 77;
            this.label7.Text = "Estoque:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Marca:";
            // 
            // picFoto
            // 
            this.picFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("picFoto.InitialImage")));
            this.picFoto.Location = new System.Drawing.Point(519, 26);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(155, 155);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 75;
            this.picFoto.TabStop = false;
            this.picFoto.Click += new System.EventHandler(this.picFoto_Click);
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(15, 105);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(155, 20);
            this.txtEstoque.TabIndex = 59;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(15, 65);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(246, 21);
            this.cboCategoria.TabIndex = 55;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Categoria:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(15, 199);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(403, 20);
            this.txtPesquisa.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Digite para Pesquisar:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(424, 188);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(85, 39);
            this.btnConsultar.TabIndex = 65;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(424, 135);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(85, 32);
            this.btnFechar.TabIndex = 67;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(324, 135);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 32);
            this.btnExcluir.TabIndex = 63;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(224, 135);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 32);
            this.btnCancelar.TabIndex = 62;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(124, 135);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(85, 32);
            this.btnAlterar.TabIndex = 61;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(24, 135);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(85, 32);
            this.btnIncluir.TabIndex = 60;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(124, 26);
            this.txtDescricao.MaxLength = 40;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(327, 20);
            this.txtDescricao.TabIndex = 54;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(15, 26);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Código:";
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(267, 65);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(246, 21);
            this.cboMarca.TabIndex = 79;
            this.cboMarca.SelectedIndexChanged += new System.EventHandler(this.cboMarca_SelectedIndexChanged);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(15, 233);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(659, 159);
            this.dgvProdutos.TabIndex = 80;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Valor de Venda:";
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(267, 105);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(155, 20);
            this.txtValorVenda.TabIndex = 81;
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 404);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdArquivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorVenda;
    }
}