
namespace ProjetoRestaurant
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnEmpregado = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnDepartamento = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmpregado
            // 
            this.btnEmpregado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(66)))), ((int)(((byte)(71)))));
            this.btnEmpregado.ForeColor = System.Drawing.Color.White;
            this.btnEmpregado.Location = new System.Drawing.Point(12, 210);
            this.btnEmpregado.Name = "btnEmpregado";
            this.btnEmpregado.Size = new System.Drawing.Size(155, 45);
            this.btnEmpregado.TabIndex = 0;
            this.btnEmpregado.Text = "Empregado";
            this.btnEmpregado.UseVisualStyleBackColor = false;
            this.btnEmpregado.Click += new System.EventHandler(this.btnEmpregado_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(66)))), ((int)(((byte)(71)))));
            this.btnProduto.ForeColor = System.Drawing.Color.White;
            this.btnProduto.Location = new System.Drawing.Point(188, 210);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(155, 45);
            this.btnProduto.TabIndex = 1;
            this.btnProduto.Text = "Produto";
            this.btnProduto.UseVisualStyleBackColor = false;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnDepartamento
            // 
            this.btnDepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(66)))), ((int)(((byte)(71)))));
            this.btnDepartamento.ForeColor = System.Drawing.Color.White;
            this.btnDepartamento.Location = new System.Drawing.Point(361, 210);
            this.btnDepartamento.Name = "btnDepartamento";
            this.btnDepartamento.Size = new System.Drawing.Size(155, 45);
            this.btnDepartamento.TabIndex = 2;
            this.btnDepartamento.Text = "Departamento";
            this.btnDepartamento.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(532, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 267);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDepartamento);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.btnEmpregado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpregado;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnDepartamento;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}