using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            contadorTempo = new DateTime(0);

        }

        private DateTime contadorTempo;
        public int pausa = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {

            toolStripStatusLabelHora.Text = DateTime.Now.ToLongTimeString();
            contadorTempo = contadorTempo.Add(new TimeSpan(0, 0, 0, 10));
            toolStripStatusLabelContador.Text = contadorTempo.ToLongTimeString();
        }


        private void button_reset_Click(object sender, EventArgs e)
        {
            contadorTempo = new DateTime(0);
        }

        private void button_adicionar_elementos_Click(object sender, EventArgs e)
        {
            listBox_Informacao.Items.Add(toolStripStatusLabelHora.Text + "  " + toolStripStatusLabelContador.Text);
        }

        private void button_parar_e_voltar_Click(object sender, EventArgs e)
        {
            if(pausa == 1)
            {
                button_parar_e_voltar.Text = "Play";
                timer1.Stop();
                pausa = 0;
            }
            else
            {
                button_parar_e_voltar.Text = "Pause";
                timer1.Start();
                pausa = 1;
                
            }
        }
    }
}


