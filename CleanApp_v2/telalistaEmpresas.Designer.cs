
namespace CleanApp_v2
{
    partial class telalistaEmpresas
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
            this.boxEmpresas = new System.Windows.Forms.ComboBox();
            this.selectEmpresa = new System.Windows.Forms.Button();
            this.boxServicos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showValue = new System.Windows.Forms.Label();
            this.returnForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxEmpresas
            // 
            this.boxEmpresas.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxEmpresas.FormattingEnabled = true;
            this.boxEmpresas.Location = new System.Drawing.Point(79, 54);
            this.boxEmpresas.Name = "boxEmpresas";
            this.boxEmpresas.Size = new System.Drawing.Size(216, 36);
            this.boxEmpresas.TabIndex = 0;
            this.boxEmpresas.SelectedIndexChanged += new System.EventHandler(this.boxEmpresas_SelectedIndexChanged);
            // 
            // selectEmpresa
            // 
            this.selectEmpresa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectEmpresa.Location = new System.Drawing.Point(197, 243);
            this.selectEmpresa.Name = "selectEmpresa";
            this.selectEmpresa.Size = new System.Drawing.Size(160, 79);
            this.selectEmpresa.TabIndex = 1;
            this.selectEmpresa.Text = "Pagar";
            this.selectEmpresa.UseVisualStyleBackColor = true;
            this.selectEmpresa.Click += new System.EventHandler(this.selectEmpresa_Click);
            // 
            // boxServicos
            // 
            this.boxServicos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxServicos.FormattingEnabled = true;
            this.boxServicos.Location = new System.Drawing.Point(79, 123);
            this.boxServicos.Name = "boxServicos";
            this.boxServicos.Size = new System.Drawing.Size(216, 36);
            this.boxServicos.TabIndex = 2;
            this.boxServicos.SelectedIndexChanged += new System.EventHandler(this.boxServicos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(141, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Empresas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(141, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Servicos";
            // 
            // showValue
            // 
            this.showValue.AutoSize = true;
            this.showValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showValue.Location = new System.Drawing.Point(79, 173);
            this.showValue.Name = "showValue";
            this.showValue.Size = new System.Drawing.Size(0, 37);
            this.showValue.TabIndex = 5;
            // 
            // returnForm
            // 
            this.returnForm.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnForm.Location = new System.Drawing.Point(31, 243);
            this.returnForm.Name = "returnForm";
            this.returnForm.Size = new System.Drawing.Size(160, 79);
            this.returnForm.TabIndex = 6;
            this.returnForm.Text = "Voltar";
            this.returnForm.UseVisualStyleBackColor = true;
            this.returnForm.Click += new System.EventHandler(this.returnForm_Click);
            // 
            // telalistaEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(387, 334);
            this.Controls.Add(this.returnForm);
            this.Controls.Add(this.showValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxServicos);
            this.Controls.Add(this.selectEmpresa);
            this.Controls.Add(this.boxEmpresas);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "telalistaEmpresas";
            this.Text = "listaEmpresas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_closeForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox boxEmpresas;
        private System.Windows.Forms.Button selectEmpresa;
        private System.Windows.Forms.ComboBox boxServicos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label showValue;
        private System.Windows.Forms.Button returnForm;
    }
}