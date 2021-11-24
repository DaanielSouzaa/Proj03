using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CleanApp_v2
{
    public partial class telaAddEtapa : Form
    {
        public telaAddEtapa()
        {
            InitializeComponent();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            try
            {
                if (nomeEtapa.Text != "" && double.Parse(valorEtapa.Text) > 0)
                {
                    Program.etapas.Add(nomeEtapa.Text);
                    Program.valorEtapas.Add(double.Parse(valorEtapa.Text));
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao incluir serviço, favor verificar os campos\n*Valor etapa deve ser somente de números!");
            }
        }
    }
}
