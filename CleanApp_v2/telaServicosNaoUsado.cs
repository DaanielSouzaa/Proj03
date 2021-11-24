using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CleanApp_v2
{
    public partial class formServicos : Form
    {
        public formServicos()
        {
            InitializeComponent();
            atualizaComboBox();
        }

        private void selectServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(selectServicos.Text == "Incluir")
            {
                this.Hide();
                Program.cadServicos();
            } else
            {
                this.Hide();
            }
        }

        private void atualizaComboBox()
        {
            selectServicos.Items.Clear();
            selectServicos.Items.Add("Incluir");
            for (int i = 0; i < Program.empresas.Count; i++)
            {

            };
        }
    }
}
