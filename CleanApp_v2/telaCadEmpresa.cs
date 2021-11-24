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
        }

        private void cadEmpresa_Click(object sender, EventArgs e)
        {
            if (rzTxtBox.Text != "" && (rdLucroPresumido.Checked || rdLucroReal.Checked))
            {
                try
                {

                    if (int.Parse(cnpj.Text) > 0)
                    {
                        if (double.Parse(dlPercentual.Text) >= 0 && double.Parse(dlPercentual.Text) <= 100)
                        {
                            if(Caixa.Text != "")
                            {
                                if (rdLucroPresumido.Checked && Program.servicos.Count > 0 && Program.pessoas.Count > 0)
                                {
                                    EmpresaLucroPresumido emp = new EmpresaLucroPresumido(rzTxtBox.Text, int.Parse(cnpj.Text), double.Parse(dlPercentual.Text) / 100, double.Parse(Caixa.Text));
                                    for(int i = 0;i < Program.servicos.Count; i++)
                                    {
                                        emp.addServico(Program.servicos[i]);
                                    }
                                    for(int i = 0; i < Program.pessoas.Count; i++)
                                    {
                                        emp.addFunc(Program.pessoas[i]);
                                    }
                                    Program.pessoas.Clear();
                                    Program.servicos.Clear();
                                    Program.empresas.Add(emp);
                                    MessageBox.Show("Cadastrado com sucesso!");
                                    this.Hide();
                                } else if(rdLucroReal.Checked && Program.servicos.Count > 0 && Program.pessoas.Count > 0)
                                {
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
                            {
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
                                {
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
            Environment.Exit(0);
            MessageBox.Show("Fechado com sucesso!");
        }

        private void cadServico_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.cadServicos();

            atualizaBoxServicos();
        }

        private void cadFunc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.cadPessoas();
            atualizaBoxFuncionarios();
        }

        private void atualizaBoxServicos()
        {
            foreach (Servico s in Program.servicos)
            {
                BoxlistServicos.Items.Add(s.NomeLimpeza);
            }
        }

        private void atualizaBoxFuncionarios()
        {
            foreach(Pessoa p in Program.pessoas)
            {
                BoxlistFunc.Items.Add(p.Nome);
            }
        }
    }

}
