
namespace CleanApp_v2
{
    partial class telaCadFunc
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
            this.nomeFunc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idadeFunc = new System.Windows.Forms.NumericUpDown();
            this.cpfFunc = new System.Windows.Forms.TextBox();
            this.cadFuncBtn = new System.Windows.Forms.Button();
            this.listFunc = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.idadeFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeFunc
            // 
            this.nomeFunc.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomeFunc.Location = new System.Drawing.Point(12, 41);
            this.nomeFunc.Name = "nomeFunc";
            this.nomeFunc.Size = new System.Drawing.Size(224, 34);
            this.nomeFunc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(260, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cpf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(520, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Idade";
            // 
            // idadeFunc
            // 
            this.idadeFunc.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idadeFunc.Location = new System.Drawing.Point(520, 40);
            this.idadeFunc.Name = "idadeFunc";
            this.idadeFunc.Size = new System.Drawing.Size(224, 34);
            this.idadeFunc.TabIndex = 4;
            // 
            // cpfFunc
            // 
            this.cpfFunc.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpfFunc.Location = new System.Drawing.Point(260, 40);
            this.cpfFunc.Name = "cpfFunc";
            this.cpfFunc.Size = new System.Drawing.Size(224, 34);
            this.cpfFunc.TabIndex = 5;
            // 
            // cadFuncBtn
            // 
            this.cadFuncBtn.Location = new System.Drawing.Point(302, 288);
            this.cadFuncBtn.Name = "cadFuncBtn";
            this.cadFuncBtn.Size = new System.Drawing.Size(191, 45);
            this.cadFuncBtn.TabIndex = 7;
            this.cadFuncBtn.Text = "Cadastrar";
            this.cadFuncBtn.UseVisualStyleBackColor = true;
            this.cadFuncBtn.Click += new System.EventHandler(this.cadFuncBtn_Click);
            // 
            // listFunc
            // 
            this.listFunc.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listFunc.FormattingEnabled = true;
            this.listFunc.ItemHeight = 28;
            this.listFunc.Location = new System.Drawing.Point(227, 114);
            this.listFunc.MultiColumn = true;
            this.listFunc.Name = "listFunc";
            this.listFunc.Size = new System.Drawing.Size(345, 144);
            this.listFunc.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(172, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "+";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // telaCadFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listFunc);
            this.Controls.Add(this.cadFuncBtn);
            this.Controls.Add(this.cpfFunc);
            this.Controls.Add(this.idadeFunc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeFunc);
            this.Name = "telaCadFunc";
            this.Text = "CleaApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_closeForm);
            ((System.ComponentModel.ISupportInitialize)(this.idadeFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown idadeFunc;
        private System.Windows.Forms.TextBox cpfFunc;
        private System.Windows.Forms.Button cadFuncBtn;
        private System.Windows.Forms.ListBox listFunc;
        private System.Windows.Forms.Button button1;
    }
}