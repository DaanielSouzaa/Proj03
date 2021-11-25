using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanApp_v2
{
    public partial class nome : Form
    {
        public string name;

        public nome()
        {
            InitializeComponent();
            this.Top = 0;
            this.Left = 0;
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
        }
        //TELA PARA PREENCHIMENTO DO NOME
        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            if(name != "")
            {
                this.Hide();
            } else {
                MessageBox.Show("Favor informar seu nome!");
            }
        }

        private void Form_closeForm(object sender,FormClosedEventArgs e)
        {
            Environment.Exit(0);
            MessageBox.Show("Fechado com sucesso!");
        }

    }
}
