
namespace CleanApp_v2
{
    partial class formServicos
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
            this.selectServicos = new System.Windows.Forms.ComboBox();
            this.servLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectServicos
            // 
            this.selectServicos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectServicos.FormattingEnabled = true;
            this.selectServicos.Items.AddRange(new object[] {
            "Incluir"});
            this.selectServicos.Location = new System.Drawing.Point(63, 73);
            this.selectServicos.Name = "selectServicos";
            this.selectServicos.Size = new System.Drawing.Size(253, 36);
            this.selectServicos.TabIndex = 0;
            this.selectServicos.SelectedIndexChanged += new System.EventHandler(this.selectServicos_SelectedIndexChanged);
            // 
            // servLabel
            // 
            this.servLabel.AutoSize = true;
            this.servLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.servLabel.Location = new System.Drawing.Point(155, 30);
            this.servLabel.Name = "servLabel";
            this.servLabel.Size = new System.Drawing.Size(84, 28);
            this.servLabel.TabIndex = 1;
            this.servLabel.Text = "Servicos";
            this.servLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // formServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(387, 193);
            this.Controls.Add(this.servLabel);
            this.Controls.Add(this.selectServicos);
            this.Name = "formServicos";
            this.Text = "CleanApp - Serviço";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectServicos;
        private System.Windows.Forms.Label servLabel;
    }
}