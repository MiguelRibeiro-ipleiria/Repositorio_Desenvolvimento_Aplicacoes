namespace Ficha2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelContador = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_reset = new System.Windows.Forms.Button();
            this.listBox_Informacao = new System.Windows.Forms.ListBox();
            this.button_adicionar_elementos = new System.Windows.Forms.Button();
            this.button_parar_e_voltar = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHora,
            this.toolStripStatusLabelContador});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHora
            // 
            this.toolStripStatusLabelHora.Name = "toolStripStatusLabelHora";
            this.toolStripStatusLabelHora.Size = new System.Drawing.Size(63, 20);
            this.toolStripStatusLabelHora.Text = "00:00:00";
            // 
            // toolStripStatusLabelContador
            // 
            this.toolStripStatusLabelContador.Name = "toolStripStatusLabelContador";
            this.toolStripStatusLabelContador.Size = new System.Drawing.Size(63, 20);
            this.toolStripStatusLabelContador.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(12, 282);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(233, 46);
            this.button_reset.TabIndex = 1;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // listBox_Informacao
            // 
            this.listBox_Informacao.FormattingEnabled = true;
            this.listBox_Informacao.ItemHeight = 16;
            this.listBox_Informacao.Location = new System.Drawing.Point(12, 12);
            this.listBox_Informacao.Name = "listBox_Informacao";
            this.listBox_Informacao.Size = new System.Drawing.Size(233, 212);
            this.listBox_Informacao.TabIndex = 2;
            // 
            // button_adicionar_elementos
            // 
            this.button_adicionar_elementos.Location = new System.Drawing.Point(12, 334);
            this.button_adicionar_elementos.Name = "button_adicionar_elementos";
            this.button_adicionar_elementos.Size = new System.Drawing.Size(233, 46);
            this.button_adicionar_elementos.TabIndex = 3;
            this.button_adicionar_elementos.Text = "Adicionar Informação";
            this.button_adicionar_elementos.UseVisualStyleBackColor = true;
            this.button_adicionar_elementos.Click += new System.EventHandler(this.button_adicionar_elementos_Click);
            // 
            // button_parar_e_voltar
            // 
            this.button_parar_e_voltar.Location = new System.Drawing.Point(13, 230);
            this.button_parar_e_voltar.Name = "button_parar_e_voltar";
            this.button_parar_e_voltar.Size = new System.Drawing.Size(232, 46);
            this.button_parar_e_voltar.TabIndex = 4;
            this.button_parar_e_voltar.Text = "Pause";
            this.button_parar_e_voltar.UseVisualStyleBackColor = true;
            this.button_parar_e_voltar.Click += new System.EventHandler(this.button_parar_e_voltar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_parar_e_voltar);
            this.Controls.Add(this.button_adicionar_elementos);
            this.Controls.Add(this.listBox_Informacao);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "A minha Aplicação";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelContador;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.ListBox listBox_Informacao;
        private System.Windows.Forms.Button button_adicionar_elementos;
        private System.Windows.Forms.Button button_parar_e_voltar;
    }
}

