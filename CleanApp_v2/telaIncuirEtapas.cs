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
        }//CARREGA A TELA E POPULA O COMBOBOX

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addEtapa();
            populaCheck();
        }//INCLUIR ETAPA

        private void populaCheck()
        {//POPULA A LISTA
            checkEtapas.Items.Clear();
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
        {//ENVIA OS DADOS
            if(NomeServico.Text != "" && double.Parse(tempoServico.Value.ToString()) > 0 && Program.etapas.Count > 0)
            {//VALIDACAO DOS CAMPOS
                Servico srv = new Servico(NomeServico.Text, double.Parse(tempoServico.Value.ToString()));
                for(int i = 0; i < Program.etapas.Count; i++)
                {
                    srv.cadLimpeza(Program.etapas[i],Program.valorEtapas[i]);
                }
                srv.calcularPrecoTotal();//CALCULA O PRECO TOTAL DO SERVICO
                Program.etapas.Clear();//TRATAMENTO DAS ESTRUTURAS PRINCIPAIS NO ARQUIVO PROGRAM
                Program.valorEtapas.Clear();
                Program.servicos.Add(srv);
                this.Hide();
                //Program.showServicos();
            } else
            {
                MessageBox.Show("Algum dos dados está incorreto.\nValor precisa ser maior do que 0.\nAlguma etapa precisa ser cadastrada.");
            }
        }

        private void addEtapa()
        {//CHAMA TELA DE INCLUSAO DE ETAPA
            telaAddEtapa ae = new telaAddEtapa();
            ae.ShowDialog();
        }

        private void Form_closeForm(object sender, FormClosedEventArgs e)
        {//FECHA O PROGRAMA
            Environment.Exit(0);
            MessageBox.Show("Fechado com sucesso!");
        }
    }
}
