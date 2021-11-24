using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CleanApp_v2
{
    public partial class addServico : Form
    {
        public addServico()
        {
            InitializeComponent();
            populaCheck();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addEtapa();
            populaCheck();
        }

        private void populaCheck()
        {
            if (Program.etapas.Count < 0)
            {
                checkEtapas.Hide();
            } else
            {
                foreach(string i in Program.etapas)
                {
                    checkEtapas.Items.Add(i);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(NomeServico.Text != "" && double.Parse(tempoServico.Value.ToString()) > 0 && Program.etapas.Count > 0)
            {
                Servico srv = new Servico(NomeServico.Text, double.Parse(tempoServico.Value.ToString()));
                for(int i = 0; i < Program.etapas.Count; i++)
                {
                    srv.cadLimpeza(Program.etapas[i],Program.valorEtapas[i]);
                    Program.etapas.Clear();
                    Program.valorEtapas.Clear();
                }
                    srv.calcularPrecoTotal();
                    Program.servicos.Add(srv);
                this.Hide();
                //Program.showServicos();
            } else
            {
                MessageBox.Show("Algum dos dados está incorreto.\nValor precisa ser maior do que 0.\nAlguma etapa precisa ser cadastrada.");
            }
        }

        private void addEtapa()
        {
            telaAddEtapa ae = new telaAddEtapa();
            ae.ShowDialog();
        }
    }
}
