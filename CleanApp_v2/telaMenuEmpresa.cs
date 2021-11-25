﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CleanApp_v2
{
    public partial class telaMenuEmpresa : Form
    {
        private string empresa;
        public telaMenuEmpresa(string empresa)
        {
            InitializeComponent();
            this.empresa = empresa;
            openTela();
        }

        private void telaMenuEmpresa_Load(object sender, EventArgs e)
        {
            
        }

        private void openTela()
        {
            foreach (Empresa p in Program.empresas)
            {
                if (empresa == p.RazaoSocial)
                {
                    caixaValor.Text = "R$ " + p.Caixa.ToString();
                    cnpjValor.Text = p.Cnpj.ToString();
                    dlValor.Text = p.Repasse * 100 + "%";

                    listaServicos.Items.Clear();
                    listaFuncionarios.Items.Clear();

                    foreach (Servico s in p.listServ)
                    {
                        listaServicos.Items.Add("Produto: " + s.NomeLimpeza + " | Valor: " + s.ValorTotal + " | Horas Exec: " + s.HorasExecucao);
                    }

                    foreach (Pessoa p2 in p.listFunc)
                    {
                        listaFuncionarios.Items.Add("Nome: " + p2.Nome + " | Cpf: " + p2.Cpf + " | Idade: " + p2.Idade);
                    }
                }
            }
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void distribuirLucros_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Empresa p in Program.empresas)
            {
                if (empresa == p.RazaoSocial)
                {
                    if(p.Caixa > 0)
                    {
                        p.DistribuirLucros();
                        openTela();
                        MessageBox.Show("Lucro distribuídos com sucesso!");
                    }
                }
            }
        }

        private void Form_closeForm(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
            MessageBox.Show("Fechado com sucesso!");
        }
    }
}
