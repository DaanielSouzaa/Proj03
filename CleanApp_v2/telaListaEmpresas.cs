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
            
        }//POPULA O COMBOBOX COM AS EMPRESAS

        private void selectEmpresa_Click(object sender, EventArgs e)
        {//REALIZA O PAGAMENTO
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
        {//VERIFICA A EMPRESA ESCOLHIDA E POPULA OS DADOS
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
        {//POPULA O LIST DE SERVICOS
            boxServicos.Items.Clear();
            foreach(Servico s in emp.listServ)
            {
                boxServicos.Items.Add(s.NomeLimpeza);
            }
        }

        private void boxServicos_SelectedIndexChanged(object sender, EventArgs e)
        {//PREENCHE O VALOR DO SERVICO ESCOLHIDO
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
        }//FECHA A JANELA ATUAL

        private void Form_closeForm(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
            MessageBox.Show("Fechado com sucesso!");
        }//FECHA A EXECUCAO DO PROGRAMA
    }
}
