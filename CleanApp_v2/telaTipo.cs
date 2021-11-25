using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CleanApp_v2
{//TELA DE ESCOLHA DO TIPO DO USUARIO
    public partial class Tipo : Form
    {
        public string tipo;

        public Tipo()
        {
            InitializeComponent();
            this.Top = 0;
            this.Left = 0;
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            btnTeste.Text = "Dados para teste";
            btnTeste.Width = 200;
            btnTeste.Height = 38;
        }//EMPRESA OU CLIENTE

        private void button1_Click(object sender, EventArgs e)
        {
            if (rad1.Checked)
            {
                tipo = "Cliente";
            } else
            {
                tipo = "Empresa";
            }
            this.Hide();
        }

        private void Form_closeForm(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
            MessageBox.Show("Fechado com sucesso!");
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            Program.generateDados();
        }
    }
}
