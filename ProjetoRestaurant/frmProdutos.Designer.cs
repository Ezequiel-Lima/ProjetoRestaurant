
namespace ProjetoRestaurant
{
    partial class frmProdutos
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
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dgvfunc = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txbLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txbInfo12 = new System.Windows.Forms.TextBox();
            this.txbInfo11 = new System.Windows.Forms.TextBox();
            this.txbInfo10 = new System.Windows.Forms.TextBox();
            this.txbCodigoProduto = new System.Windows.Forms.TextBox();
            this.txbInfo9 = new System.Windows.Forms.TextBox();
            this.txbValorTotal = new System.Windows.Forms.TextBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.txbValorProduto = new System.Windows.Forms.TextBox();
            this.txbNomeProduto = new System.Windows.Forms.TextBox();
            this.txbInfo8 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfunc)).BeginInit();
            this.SuspendLayout();
            // 
            // txbBuscar
            // 
            this.txbBuscar.Location = new System.Drawing.Point(140, 287);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(581, 26);
            this.txbBuscar.TabIndex = 36;
            this.txbBuscar.TextChanged += new System.EventHandler(this.txbBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(377, 244);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(70, 26);
            this.lblBuscar.TabIndex = 46;
            this.lblBuscar.Text = "Buscar";
            // 
            // dgvfunc
            // 
            this.dgvfunc.AllowUserToAddRows = false;
            this.dgvfunc.AllowUserToDeleteRows = false;
            this.dgvfunc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvfunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfunc.Location = new System.Drawing.Point(12, 396);
            this.dgvfunc.Name = "dgvfunc";
            this.dgvfunc.ReadOnly = true;
            this.dgvfunc.RowHeadersWidth = 62;
            this.dgvfunc.RowTemplate.Height = 28;
            this.dgvfunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvfunc.Size = new System.Drawing.Size(836, 310);
            this.dgvfunc.TabIndex = 47;
            this.dgvfunc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfunc_CellDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(480, 335);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 34);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txbLimpar
            // 
            this.txbLimpar.Location = new System.Drawing.Point(365, 335);
            this.txbLimpar.Name = "txbLimpar";
            this.txbLimpar.Size = new System.Drawing.Size(109, 34);
            this.txbLimpar.TabIndex = 38;
            this.txbLimpar.Text = "Limpar";
            this.txbLimpar.UseVisualStyleBackColor = true;
            this.txbLimpar.Click += new System.EventHandler(this.txbLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(250, 335);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(109, 34);
            this.btnSalvar.TabIndex = 37;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txbInfo12
            // 
            this.txbInfo12.Enabled = false;
            this.txbInfo12.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInfo12.Location = new System.Drawing.Point(140, 32);
            this.txbInfo12.Name = "txbInfo12";
            this.txbInfo12.Size = new System.Drawing.Size(187, 34);
            this.txbInfo12.TabIndex = 45;
            this.txbInfo12.Text = "Código Do Produto ";
            // 
            // txbInfo11
            // 
            this.txbInfo11.Enabled = false;
            this.txbInfo11.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInfo11.Location = new System.Drawing.Point(140, 192);
            this.txbInfo11.Name = "txbInfo11";
            this.txbInfo11.Size = new System.Drawing.Size(187, 34);
            this.txbInfo11.TabIndex = 43;
            this.txbInfo11.Text = "Valor Total";
            // 
            // txbInfo10
            // 
            this.txbInfo10.Enabled = false;
            this.txbInfo10.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInfo10.Location = new System.Drawing.Point(140, 152);
            this.txbInfo10.Name = "txbInfo10";
            this.txbInfo10.Size = new System.Drawing.Size(187, 34);
            this.txbInfo10.TabIndex = 42;
            this.txbInfo10.Text = "Quantidade";
            // 
            // txbCodigoProduto
            // 
            this.txbCodigoProduto.Enabled = false;
            this.txbCodigoProduto.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigoProduto.Location = new System.Drawing.Point(333, 32);
            this.txbCodigoProduto.Name = "txbCodigoProduto";
            this.txbCodigoProduto.Size = new System.Drawing.Size(410, 34);
            this.txbCodigoProduto.TabIndex = 0;
            // 
            // txbInfo9
            // 
            this.txbInfo9.Enabled = false;
            this.txbInfo9.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInfo9.Location = new System.Drawing.Point(140, 112);
            this.txbInfo9.Name = "txbInfo9";
            this.txbInfo9.Size = new System.Drawing.Size(187, 34);
            this.txbInfo9.TabIndex = 41;
            this.txbInfo9.Text = "Valor do Produto";
            // 
            // txbValorTotal
            // 
            this.txbValorTotal.Enabled = false;
            this.txbValorTotal.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValorTotal.Location = new System.Drawing.Point(333, 192);
            this.txbValorTotal.Name = "txbValorTotal";
            this.txbValorTotal.Size = new System.Drawing.Size(410, 34);
            this.txbValorTotal.TabIndex = 4;
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantidade.Location = new System.Drawing.Point(333, 152);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(410, 34);
            this.txbQuantidade.TabIndex = 3;
            // 
            // txbValorProduto
            // 
            this.txbValorProduto.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValorProduto.Location = new System.Drawing.Point(333, 112);
            this.txbValorProduto.Name = "txbValorProduto";
            this.txbValorProduto.Size = new System.Drawing.Size(410, 34);
            this.txbValorProduto.TabIndex = 2;
            // 
            // txbNomeProduto
            // 
            this.txbNomeProduto.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeProduto.Location = new System.Drawing.Point(333, 72);
            this.txbNomeProduto.Name = "txbNomeProduto";
            this.txbNomeProduto.Size = new System.Drawing.Size(410, 34);
            this.txbNomeProduto.TabIndex = 1;
            // 
            // txbInfo8
            // 
            this.txbInfo8.Enabled = false;
            this.txbInfo8.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInfo8.Location = new System.Drawing.Point(140, 72);
            this.txbInfo8.Name = "txbInfo8";
            this.txbInfo8.Size = new System.Drawing.Size(187, 34);
            this.txbInfo8.TabIndex = 40;
            this.txbInfo8.Text = "Nome do Produto";
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(861, 723);
            this.Controls.Add(this.txbBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dgvfunc);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txbLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txbInfo12);
            this.Controls.Add(this.txbInfo11);
            this.Controls.Add(this.txbInfo10);
            this.Controls.Add(this.txbCodigoProduto);
            this.Controls.Add(this.txbInfo9);
            this.Controls.Add(this.txbValorTotal);
            this.Controls.Add(this.txbQuantidade);
            this.Controls.Add(this.txbValorProduto);
            this.Controls.Add(this.txbNomeProduto);
            this.Controls.Add(this.txbInfo8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvfunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dgvfunc;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button txbLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txbInfo12;
        private System.Windows.Forms.TextBox txbInfo11;
        private System.Windows.Forms.TextBox txbInfo10;
        private System.Windows.Forms.TextBox txbCodigoProduto;
        private System.Windows.Forms.TextBox txbInfo9;
        private System.Windows.Forms.TextBox txbValorTotal;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.TextBox txbValorProduto;
        private System.Windows.Forms.TextBox txbNomeProduto;
        private System.Windows.Forms.TextBox txbInfo8;
    }
}