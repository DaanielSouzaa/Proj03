
namespace CleanApp_v2
{
    partial class addServico
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
            this.NomeServico = new System.Windows.Forms.TextBox();
            this.tempoServico = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.labelServico = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkEtapas = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.tempoServico)).BeginInit();
            this.SuspendLayout();
            // 
            // NomeServico
            // 
            this.NomeServico.Location = new System.Drawing.Point(12, 40);
            this.NomeServico.Name = "NomeServico";
            this.NomeServico.Size = new System.Drawing.Size(281, 34);
            this.NomeServico.TabIndex = 0;
            // 
            // tempoServico
            // 
            this.tempoServico.DecimalPlaces = 1;
            this.tempoServico.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tempoServico.Location = new System.Drawing.Point(388, 40);
            this.tempoServico.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tempoServico.Name = "tempoServico";
            this.tempoServico.Size = new System.Drawing.Size(281, 34);
            this.tempoServico.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelServico
            // 
            this.labelServico.AutoSize = true;
            this.labelServico.Location = new System.Drawing.Point(12, 9);
            this.labelServico.Name = "labelServico";
            this.labelServico.Size = new System.Drawing.Size(165, 28);
            this.labelServico.TabIndex = 3;
            this.labelServico.Text = "Nome do serviço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Horas duração:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Location = new System.Drawing.Point(12, 96);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(149, 28);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cadastrar etapa";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // checkEtapas
            // 
            this.checkEtapas.FormattingEnabled = true;
            this.checkEtapas.Location = new System.Drawing.Point(203, 130);
            this.checkEtapas.Name = "checkEtapas";
            this.checkEtapas.Size = new System.Drawing.Size(290, 91);
            this.checkEtapas.TabIndex = 6;
            // 
            // addServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(681, 315);
            this.Controls.Add(this.checkEtapas);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelServico);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tempoServico);
            this.Controls.Add(this.NomeServico);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "addServico";
            this.Text = "CleanApp";
            ((System.ComponentModel.ISupportInitialize)(this.tempoServico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NomeServico;
        private System.Windows.Forms.NumericUpDown tempoServico;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelServico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckedListBox checkEtapas;
    }
}