using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CleanApp_v2
{
    public partial class telalistaEmpresas : Form
    {
        private Empresa emp;
        private double valor;
        public telalistaEmpresas()
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
            foreach(Empresa p in Program.empresas)
            {
                if(p.RazaoSocial == emp.RazaoSocial)
                {
                    p.pagar(valor);
                    MessageBox.Show("Limpeza efetuada e pagamento realizado com sucesso!");
                    this.Hide();
                }
            }
        }

        private void boxEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            showValue.Text = "";
            boxServicos.Items.Clear();
            boxServicos.Text = "";

            foreach (Empresa p in Program.empresas)
            {
                if (p.RazaoSocial == boxEmpresas.Text)
                {
                    populaServicos(p);
                    emp = p;
                }
            }
        }

        private void populaServicos(Empresa emp)
        {
            boxServicos.Items.Clear();
            foreach(Servico s in emp.listServ)
            {
                boxServicos.Items.Add(s.NomeLimpeza);
            }
        }

        private void boxServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Servico s in emp.listServ)
            {
                if (s.NomeLimpeza == boxServicos.Text)
                {
                    showValue.Text = "Preço: R$ " + s.ValorTotal;
                    valor = s.ValorTotal;
                }
            }
        }

        private void returnForm_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
