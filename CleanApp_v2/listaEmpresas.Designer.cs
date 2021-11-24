
namespace CleanApp_v2
{
    partial class listaEmpresas
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
            // 
            // selectEmpresa
            // 
            this.selectEmpresa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectEmpresa.Location = new System.Drawing.Point(117, 115);
            this.selectEmpresa.Name = "selectEmpresa";
            this.selectEmpresa.Size = new System.Drawing.Size(133, 41);
            this.selectEmpresa.TabIndex = 1;
            this.selectEmpresa.Text = "Selecionar";
            this.selectEmpresa.UseVisualStyleBackColor = true;
            this.selectEmpresa.Click += new System.EventHandler(this.selectEmpresa_Click);
            // 
            // listaEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(387, 262);
            this.Controls.Add(this.selectEmpresa);
            this.Controls.Add(this.boxEmpresas);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "listaEmpresas";
            this.Text = "listaEmpresas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox boxEmpresas;
        private System.Windows.Forms.Button selectEmpresa;
    }
}