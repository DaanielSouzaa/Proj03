
namespace CleanApp_v2
{
    partial class telaAddEtapa
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
            this.nomeEtapa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valorEtapa = new System.Windows.Forms.TextBox();
            this.btnCad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomeEtapa
            // 
            this.nomeEtapa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomeEtapa.Location = new System.Drawing.Point(46, 152);
            this.nomeEtapa.Name = "nomeEtapa";
            this.nomeEtapa.Size = new System.Drawing.Size(272, 34);
            this.nomeEtapa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome etapa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(422, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor etapa:";
            // 
            // valorEtapa
            // 
            this.valorEtapa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valorEtapa.Location = new System.Drawing.Point(422, 152);
            this.valorEtapa.Name = "valorEtapa";
            this.valorEtapa.Size = new System.Drawing.Size(272, 34);
            this.valorEtapa.TabIndex = 3;
            // 
            // btnCad
            // 
            this.btnCad.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCad.Location = new System.Drawing.Point(285, 259);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(190, 47);
            this.btnCad.TabIndex = 4;
            this.btnCad.Text = "Incluir";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // telaAddEtapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.valorEtapa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeEtapa);
            this.Name = "telaAddEtapa";
            this.Text = "CleanApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeEtapa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valorEtapa;
        private System.Windows.Forms.Button btnCad;
    }
}