
namespace CleanApp_v2
{
    partial class telaMenuEmpresa
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
            this.caixaValor = new System.Windows.Forms.Label();
            this.listaServicos = new System.Windows.Forms.ListBox();
            this.listaFuncionarios = new System.Windows.Forms.ListBox();
            this.cnpjLabel = new System.Windows.Forms.Label();
            this.cnpjValor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dlValor = new System.Windows.Forms.Label();
            this.Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caixa:";
            // 
            // caixaValor
            // 
            this.caixaValor.AutoSize = true;
            this.caixaValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.caixaValor.Location = new System.Drawing.Point(12, 37);
            this.caixaValor.Name = "caixaValor";
            this.caixaValor.Size = new System.Drawing.Size(42, 21);
            this.caixaValor.TabIndex = 1;
            this.caixaValor.Text = "R$ 0";
            this.caixaValor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listaServicos
            // 
            this.listaServicos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listaServicos.FormattingEnabled = true;
            this.listaServicos.ItemHeight = 28;
            this.listaServicos.Location = new System.Drawing.Point(12, 100);
            this.listaServicos.Name = "listaServicos";
            this.listaServicos.Size = new System.Drawing.Size(362, 116);
            this.listaServicos.TabIndex = 2;
            // 
            // listaFuncionarios
            // 
            this.listaFuncionarios.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listaFuncionarios.FormattingEnabled = true;
            this.listaFuncionarios.ItemHeight = 28;
            this.listaFuncionarios.Location = new System.Drawing.Point(390, 100);
            this.listaFuncionarios.Name = "listaFuncionarios";
            this.listaFuncionarios.Size = new System.Drawing.Size(362, 116);
            this.listaFuncionarios.TabIndex = 3;
            // 
            // cnpjLabel
            // 
            this.cnpjLabel.AutoSize = true;
            this.cnpjLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cnpjLabel.Location = new System.Drawing.Point(111, 9);
            this.cnpjLabel.Name = "cnpjLabel";
            this.cnpjLabel.Size = new System.Drawing.Size(56, 28);
            this.cnpjLabel.TabIndex = 4;
            this.cnpjLabel.Text = "Cnpj:";
            // 
            // cnpjValor
            // 
            this.cnpjValor.AutoSize = true;
            this.cnpjValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cnpjValor.Location = new System.Drawing.Point(111, 37);
            this.cnpjValor.Name = "cnpjValor";
            this.cnpjValor.Size = new System.Drawing.Size(42, 21);
            this.cnpjValor.TabIndex = 5;
            this.cnpjValor.Text = "R$ 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(206, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "% de DL";
            // 
            // dlValor
            // 
            this.dlValor.AutoSize = true;
            this.dlValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dlValor.Location = new System.Drawing.Point(206, 37);
            this.dlValor.Name = "dlValor";
            this.dlValor.Size = new System.Drawing.Size(59, 21);
            this.dlValor.TabIndex = 7;
            this.dlValor.Text = "dlValor";
            // 
            // Voltar
            // 
            this.Voltar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Voltar.Location = new System.Drawing.Point(328, 248);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(119, 39);
            this.Voltar.TabIndex = 8;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // telaMenuEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 311);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.dlValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cnpjValor);
            this.Controls.Add(this.cnpjLabel);
            this.Controls.Add(this.listaFuncionarios);
            this.Controls.Add(this.listaServicos);
            this.Controls.Add(this.caixaValor);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "telaMenuEmpresa";
            this.Text = "CleanApp";
            this.Load += new System.EventHandler(this.telaMenuEmpresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label caixaValor;
        private System.Windows.Forms.ListBox listaServicos;
        private System.Windows.Forms.ListBox listaFuncionarios;
        private System.Windows.Forms.Label cnpjLabel;
        private System.Windows.Forms.Label cnpjValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dlValor;
        private System.Windows.Forms.Button Voltar;
    }
}