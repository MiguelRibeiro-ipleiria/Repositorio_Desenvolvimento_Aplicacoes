using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha3
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome_da_pessoa = NomeTextBox.Text;
            string morada_da_pessoa = MoradaTextBox.Text;
            DateTime dataNascimento = Data_Nascimento_Calendario.SelectionStart;

            if(DateTime.Now.Date  < dataNascimento.Date)
            {
                data_erro.Text = "Insira uma data correta!";
            }
            else if(nome_da_pessoa == "")
            {
                nome_erro.Text = "Insira uma nome correto!";
            }
            else if (morada_da_pessoa == "")
            {
                morada_erro.Text = "Insira uma morada correta!";
            }
            else
            {
                Pessoa novaPessoa = new Pessoa(nome_da_pessoa, dataNascimento, morada_da_pessoa);
                listBox1.Items.Add(novaPessoa);
                data_erro.Text = "";
                nome_erro.Text = "";
                morada_erro.Text = "";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pessoa pessoaselecionada = (Pessoa)listBox1.SelectedItem;
            if(pessoaselecionada == null)
            {
                MessageBox.Show("Selecione alguma pessoa");
            }
            else
            {
                pessoaselecionada.Pontuar(1);
                listBox1.Items[listBox1.SelectedIndex] = pessoaselecionada;
            }
        }
    }
}
