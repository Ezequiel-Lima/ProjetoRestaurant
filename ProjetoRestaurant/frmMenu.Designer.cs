
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
            this.btnEmpregado = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnDepartamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmpregado
            // 
            this.btnEmpregado.Location = new System.Drawing.Point(12, 12);
            this.btnEmpregado.Name = "btnEmpregado";
            this.btnEmpregado.Size = new System.Drawing.Size(155, 45);
            this.btnEmpregado.TabIndex = 0;
            this.btnEmpregado.Text = "Empregado";
            this.btnEmpregado.UseVisualStyleBackColor = true;
            this.btnEmpregado.Click += new System.EventHandler(this.btnEmpregado_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.Location = new System.Drawing.Point(183, 12);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(155, 45);
            this.btnProduto.TabIndex = 1;
            this.btnProduto.Text = "Produto";
            this.btnProduto.UseVisualStyleBackColor = true;
            // 
            // btnDepartamento
            // 
            this.btnDepartamento.Location = new System.Drawing.Point(355, 12);
            this.btnDepartamento.Name = "btnDepartamento";
            this.btnDepartamento.Size = new System.Drawing.Size(155, 45);
            this.btnDepartamento.TabIndex = 2;
            this.btnDepartamento.Text = "Departamento";
            this.btnDepartamento.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 72);
            this.Controls.Add(this.btnDepartamento);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.btnEmpregado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpregado;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnDepartamento;
    }
}