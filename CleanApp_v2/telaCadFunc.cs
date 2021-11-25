using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CleanApp_v2
{
    public partial class telaCadFunc : Form
    {
        public telaCadFunc()
        {
            InitializeComponent();
        }

        public void populaList()
        {
            listFunc.Items.Clear();
            foreach(Pessoa p in Program.pessoas)
            {
                listFunc.Items.Add(p.Nome);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(nomeFunc.Text != "" && int.Parse(cpfFunc.Text) > 0 && int.Parse(idadeFunc.Value.ToString()) > 0)
                {
                    Program.pessoas.Add(new Pessoa(int.Parse(cpfFunc.Text), nomeFunc.Text, int.Parse(idadeFunc.Value.ToString())));
                    nomeFunc.Text = "";
                    cpfFunc.Text = "";
                    idadeFunc.Value = 0;
                    populaList();
                } else
                {
                    MessageBox.Show("Algum dos campos está incorreto.\nCpf em número inteiro com até 8 caracteres.\nIdade maior que 0.");
                }
            } catch(Exception)
            {
                MessageBox.Show("Erro ao inserir funcionário!");
            }
        }

        private void cadFuncBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
