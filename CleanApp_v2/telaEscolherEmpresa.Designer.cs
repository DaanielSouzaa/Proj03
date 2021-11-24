
namespace CleanApp_v2
{
    partial class visaoEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(visaoEmpresa));
            this.selectEmpresas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // selectEmpresas
            // 
            resources.ApplyResources(this.selectEmpresas, "selectEmpresas");
            this.selectEmpresas.FormattingEnabled = true;
            this.selectEmpresas.Items.AddRange(new object[] {
            resources.GetString("selectEmpresas.Items")});
            this.selectEmpresas.Name = "selectEmpresas";
            this.selectEmpresas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // visaoEmpresa
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.selectEmpresas);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "visaoEmpresa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_closeForm);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox selectEmpresas;
    }
}