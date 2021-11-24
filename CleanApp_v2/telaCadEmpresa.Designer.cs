
namespace CleanApp_v2
{
    partial class formCadEmpresa
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
            this.cadEmpresa = new System.Windows.Forms.Button();
            this.aviso = new System.Windows.Forms.Label();
            this.cnpj = new System.Windows.Forms.RichTextBox();
            this.dlPercentual = new System.Windows.Forms.RichTextBox();
            this.Caixa = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rzSocialLabel = new System.Windows.Forms.Label();
            this.rzTxtBox = new System.Windows.Forms.TextBox();
            this.rdLucroReal = new System.Windows.Forms.RadioButton();
            this.rdLucroPresumido = new System.Windows.Forms.RadioButton();
            this.cadServico = new System.Windows.Forms.LinkLabel();
            this.cadFunc = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cadEmpresa
            // 
            this.cadEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cadEmpresa.Location = new System.Drawing.Point(322, 334);
            this.cadEmpresa.Name = "cadEmpresa";
            this.cadEmpresa.Size = new System.Drawing.Size(122, 40);
            this.cadEmpresa.TabIndex = 22;
            this.cadEmpresa.Text = "Cadastrar";
            this.cadEmpresa.UseVisualStyleBackColor = true;
            this.cadEmpresa.Click += new System.EventHandler(this.cadEmpresa_Click);
            // 
            // aviso
            // 
            this.aviso.AutoSize = true;
            this.aviso.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aviso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.aviso.Location = new System.Drawing.Point(12, 388);
            this.aviso.Name = "aviso";
            this.aviso.Size = new System.Drawing.Size(129, 13);
            this.aviso.TabIndex = 21;
            this.aviso.Text = "Campos obrigatórios (*)";
            // 
            // cnpj
            // 
            this.cnpj.Location = new System.Drawing.Point(457, 147);
            this.cnpj.Name = "cnpj";
            this.cnpj.Size = new System.Drawing.Size(255, 34);
            this.cnpj.TabIndex = 20;
            this.cnpj.Text = "";
            // 
            // dlPercentual
            // 
            this.dlPercentual.Location = new System.Drawing.Point(69, 238);
            this.dlPercentual.Name = "dlPercentual";
            this.dlPercentual.Size = new System.Drawing.Size(255, 34);
            this.dlPercentual.TabIndex = 19;
            this.dlPercentual.Text = "";
            // 
            // Caixa
            // 
            this.Caixa.Location = new System.Drawing.Point(457, 236);
            this.Caixa.Name = "Caixa";
            this.Caixa.Size = new System.Drawing.Size(255, 34);
            this.Caixa.TabIndex = 18;
            this.Caixa.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(457, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Caixa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(69, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "Percentual DL*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(451, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "CNPJ*";
            // 
            // rzSocialLabel
            // 
            this.rzSocialLabel.AutoSize = true;
            this.rzSocialLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rzSocialLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rzSocialLabel.Location = new System.Drawing.Point(69, 116);
            this.rzSocialLabel.Name = "rzSocialLabel";
            this.rzSocialLabel.Size = new System.Drawing.Size(130, 28);
            this.rzSocialLabel.TabIndex = 13;
            this.rzSocialLabel.Text = "Razão Social*";
            // 
            // rzTxtBox
            // 
            this.rzTxtBox.Location = new System.Drawing.Point(69, 147);
            this.rzTxtBox.Name = "rzTxtBox";
            this.rzTxtBox.Size = new System.Drawing.Size(255, 23);
            this.rzTxtBox.TabIndex = 20;
            // 
            // rdLucroReal
            // 
            this.rdLucroReal.AutoSize = true;
            this.rdLucroReal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdLucroReal.Location = new System.Drawing.Point(69, 65);
            this.rdLucroReal.Name = "rdLucroReal";
            this.rdLucroReal.Size = new System.Drawing.Size(149, 32);
            this.rdLucroReal.TabIndex = 23;
            this.rdLucroReal.TabStop = true;
            this.rdLucroReal.Text = "Lucro Líquido";
            this.rdLucroReal.UseVisualStyleBackColor = true;
            // 
            // rdLucroPresumido
            // 
            this.rdLucroPresumido.AutoSize = true;
            this.rdLucroPresumido.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdLucroPresumido.Location = new System.Drawing.Point(224, 65);
            this.rdLucroPresumido.Name = "rdLucroPresumido";
            this.rdLucroPresumido.Size = new System.Drawing.Size(176, 32);
            this.rdLucroPresumido.TabIndex = 24;
            this.rdLucroPresumido.TabStop = true;
            this.rdLucroPresumido.Text = "Lucro Presumido";
            this.rdLucroPresumido.UseVisualStyleBackColor = true;
            // 
            // cadServico
            // 
            this.cadServico.AutoSize = true;
            this.cadServico.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cadServico.Location = new System.Drawing.Point(69, 285);
            this.cadServico.Name = "cadServico";
            this.cadServico.Size = new System.Drawing.Size(172, 28);
            this.cadServico.TabIndex = 25;
            this.cadServico.TabStop = true;
            this.cadServico.Text = "Cadastrar Servicos";
            this.cadServico.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cadServico_LinkClicked);
            // 
            // cadFunc
            // 
            this.cadFunc.AutoSize = true;
            this.cadFunc.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cadFunc.Location = new System.Drawing.Point(69, 313);
            this.cadFunc.Name = "cadFunc";
            this.cadFunc.Size = new System.Drawing.Size(207, 28);
            this.cadFunc.TabIndex = 26;
            this.cadFunc.TabStop = true;
            this.cadFunc.Text = "Cadastrar funcionários";
            this.cadFunc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cadFunc_LinkClicked);
            // 
            // formCadEmpresa
            // 
            this.AcceptButton = this.cadEmpresa;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(811, 386);
            this.Controls.Add(this.cadFunc);
            this.Controls.Add(this.cadServico);
            this.Controls.Add(this.rdLucroPresumido);
            this.Controls.Add(this.rdLucroReal);
            this.Controls.Add(this.rzTxtBox);
            this.Controls.Add(this.cadEmpresa);
            this.Controls.Add(this.aviso);
            this.Controls.Add(this.cnpj);
            this.Controls.Add(this.dlPercentual);
            this.Controls.Add(this.Caixa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rzSocialLabel);
            this.Name = "formCadEmpresa";
            this.Text = "CleanApp - Cadadastro de Empresa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_closeForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cadEmpresa;
        private System.Windows.Forms.Label aviso;
        private System.Windows.Forms.RichTextBox cnpj;
        private System.Windows.Forms.RichTextBox dlPercentual;
        private System.Windows.Forms.RichTextBox Caixa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label rzSocialLabel;
        private System.Windows.Forms.TextBox rzTxtBox;
        private System.Windows.Forms.RadioButton rdLucroReal;
        private System.Windows.Forms.RadioButton rdLucroPresumido;
        private System.Windows.Forms.LinkLabel cadServico;
        private System.Windows.Forms.LinkLabel cadFunc;
    }
}