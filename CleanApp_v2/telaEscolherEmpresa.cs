using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CleanApp_v2
{
    public partial class visaoEmpresa : Form
    {
        public visaoEmpresa()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {//CARREGAMENTO DO FORM
            PopulaComboBox();
            this.Top = 0;
            this.Left = 0;
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
        }       

        private void PopulaComboBox()
        {//POPULA O COMBOBOX COM AS EMPRESAS
            this.selectEmpresas.Items.Clear();
            this.selectEmpresas.Items.Add("Incluir");
            if(Program.empresas.Count > 0)
            {
                for (int i = 0; i < Program.empresas.Count; i++)
                {
                    this.selectEmpresas.Items.Add(Program.empresas[i].RazaoSocial);                
                }
            }            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {//ESCOLHE A EMPRESA OU CHAMA A TELA DE INCLUSAO
            if(selectEmpresas.Text == "Incluir")
            {
                this.Hide();
                Program.cadEmpresa();
            } else
            {
                showTelaEmpresa(selectEmpresas.Text);
                this.Hide();
            }
        }
        private void Form_closeForm(object sender, FormClosedEventArgs e)
        {//FECHA O PROGRAMA
            Environment.Exit(0);
            MessageBox.Show("Fechado com sucesso!");
        }
        private void showTelaEmpresa(string empresa)
        {//EXIBE A EMPRESA ESCOLHIDA
            Program.telaEmpresa(empresa);
        }
    }
}
