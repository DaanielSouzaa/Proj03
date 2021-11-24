using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CleanApp_v2
{
    public partial class listaEmpresas : Form
    {
        public listaEmpresas()
        {
            InitializeComponent();
            populaComboBox();
        }

        private void populaComboBox()
        {
            foreach(Empresa p in Program.empresas)
            {
                boxEmpresas.Items.Add(p.RazaoSocial);
            }
            
        }

        private void selectEmpresa_Click(object sender, EventArgs e)
        {
           
        }
    }
}
