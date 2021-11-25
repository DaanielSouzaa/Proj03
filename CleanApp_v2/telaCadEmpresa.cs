using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CleanApp_v2
{
    public partial class formCadEmpresa : Form
    {
        public formCadEmpresa()
        {
            InitializeComponent();
            this.Top = 0;
            this.Left = 0;
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
        }//CARREGAMENTO DA TELA DE INCLUSAO DE EMPRESAS

        private void cadEmpresa_Click(object sender, EventArgs e)
        {
            if (rzTxtBox.Text != "" && (rdLucroPresumido.Checked || rdLucroReal.Checked))
            {//VALIDACOES DOS CAMPOS
                try
                {//VALIDACOES DOS CAMPOS

                    if (int.Parse(cnpj.Text) > 0)
                    {//VALIDACOES DOS CAMPOS
                        if (double.Parse(dlPercentual.Text) >= 0 && double.Parse(dlPercentual.Text) <= 100)
                        {//VALIDACOES DOS CAMPOS
                            if (Caixa.Text != "")
                            {//VALIDACOES DOS CAMPOS
                                if (rdLucroPresumido.Checked && Program.servicos.Count > 0 && Program.pessoas.Count > 0)
                                {//VALIDACOES DOS CAMPOS, CASO SEJA LUCRO PRESUMIDO E TENHA CAIXA DECLARADO NA INSTANCIACAO
                                    EmpresaLucroPresumido emp = new EmpresaLucroPresumido(rzTxtBox.Text, int.Parse(cnpj.Text), double.Parse(dlPercentual.Text) / 100, double.Parse(Caixa.Text));
                                    for(int i = 0;i < Program.servicos.Count; i++)//GERA EMPRESA
                                    {
                                        emp.addServico(Program.servicos[i]);//INCLUINDO SERVICOS NA EMPRESA
                                    }
                                    for(int i = 0; i < Program.pessoas.Count; i++)//INCLUINDO PESSOAS NA EMPRESA
                                    {
                                        emp.addFunc(Program.pessoas[i]);
                                    }
                                    Program.pessoas.Clear();//LIMPA ESTRUTURA DO PROGRAM QUE ARMAZENA AS PESSOAS
                                    Program.servicos.Clear();//LIMPA ESTRUTURA DO PROGRAM QUE ARMAZENA OS SERVICOS
                                    Program.empresas.Add(emp);//INCLUI NA LISTA DE EMPRESAS
                                    MessageBox.Show("Cadastrado com sucesso!");
                                    this.Hide();
                                } else if(rdLucroReal.Checked && Program.servicos.Count > 0 && Program.pessoas.Count > 0)
                                { //CASO SEJA LUCRO REAL E TENHA CAIXA DECLARADO NA INSTANCIACAO
                                    EmpresaLucroReal emp = new EmpresaLucroReal(rzTxtBox.Text, int.Parse(cnpj.Text), double.Parse(dlPercentual.Text) / 100, double.Parse(Caixa.Text));
                                    for (int i = 0; i < Program.servicos.Count; i++)
                                    {
                                        emp.addServico(Program.servicos[i]);
                                    }
                                    for (int i = 0; i < Program.pessoas.Count; i++)
                                    {
                                        emp.addFunc(Program.pessoas[i]);
                                    }
                                    Program.pessoas.Clear();
                                    Program.servicos.Clear();
                                    Program.empresas.Add(emp);
                                    MessageBox.Show("Cadastrado com sucesso!");
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Confira os funcionários e serviços!");
                                }
                            } else
                            { //CASO SEJA LUCRO PRESUMIDO E NAO TENHA CAIXA DECLARADO NA INSTANCIACAO
                                if (rdLucroPresumido.Checked && Program.servicos.Count > 0 && Program.pessoas.Count > 0)
                                {
                                    EmpresaLucroPresumido emp = new EmpresaLucroPresumido(rzTxtBox.Text, int.Parse(cnpj.Text), double.Parse(dlPercentual.Text) / 100);
                                    for (int i = 0; i < Program.servicos.Count; i++)
                                    {
                                        emp.addServico(Program.servicos[i]);
                                    }
                                    for (int i = 0; i < Program.pessoas.Count; i++)
                                    {
                                        emp.addFunc(Program.pessoas[i]);
                                    }
                                    Program.pessoas.Clear();
                                    Program.servicos.Clear();
                                    Program.empresas.Add(emp);
                                    MessageBox.Show("Cadastrado com sucesso!");
                                    this.Hide();
                                }
                                else if(rdLucroReal.Checked && Program.servicos.Count > 0 && Program.pessoas.Count > 0)
                                {//CASO SEJA LUCRO REAL E NAO TENHA CAIXA DECLARADO NA INSTANCIACAO
                                    EmpresaLucroReal emp = new EmpresaLucroReal(rzTxtBox.Text, int.Parse(cnpj.Text), double.Parse(dlPercentual.Text) / 100);
                                    for (int i = 0; i < Program.servicos.Count; i++)
                                    {
                                        emp.addServico(Program.servicos[i]);
                                    }
                                    for (int i = 0; i < Program.pessoas.Count; i++)
                                    {
                                        emp.addFunc(Program.pessoas[i]);
                                    }
                                    Program.pessoas.Clear();
                                    Program.servicos.Clear();
                                    Program.empresas.Add(emp);
                                    MessageBox.Show("Cadastrado com sucesso!");
                                    this.Hide();
                                } else
                                {
                                    MessageBox.Show("Confira os funcionários e serviços!");
                                }
                                
                            }
                        } else
                        {
                            MessageBox.Show("O percentual da distribuição de lucros está em formato incorreto!");
                        }
                    } else
                    {
                        MessageBox.Show("CNPJ inválido!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Favor Preencher corretamente os campos!\nCPNJ somente inteiros com até 8 caracteres\nDL Func percentual entre 0 e 100");
                }
            }
            else
            {
                MessageBox.Show("Favor Preencher o campo Razão social e marcar um dos tipos!");
            }
        }
        private void Form_closeForm(object sender, FormClosedEventArgs e)
        {
            //CLOSE DO PROGRAMA
            Environment.Exit(0);
            MessageBox.Show("Fechado com sucesso!");
        }

        private void cadServico_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {//EVENTO BOTAO DE CADASTRO DE SERVICO
            Program.cadServicos();

            atualizaBoxServicos();
        }

        private void cadFunc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {//EVENTO BOTAO DE CADASTRO DE FUNCIONARIO
            Program.cadPessoas();
            atualizaBoxFuncionarios();
        }

        private void atualizaBoxServicos()
        {//ATUALIZA LISTA DE SERVICOS
            BoxlistServicos.Items.Clear();
            foreach (Servico s in Program.servicos)
            {
                BoxlistServicos.Items.Add(s.NomeLimpeza);
            }
        }

        private void atualizaBoxFuncionarios()
        {//ATUALIZA LISTA DE FUNCIONARIOS
            BoxlistFunc.Items.Clear();
            foreach(Pessoa p in Program.pessoas)
            {
                BoxlistFunc.Items.Add(p.Nome);
            }
        }
    }

}
