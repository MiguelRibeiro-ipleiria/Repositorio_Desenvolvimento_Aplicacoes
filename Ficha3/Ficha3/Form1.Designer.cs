namespace Ficha3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MoradaTextBox = new System.Windows.Forms.TextBox();
            this.NomeTextBox = new System.Windows.Forms.TextBox();
            this.Data_Nascimento_Calendario = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.nome_erro = new System.Windows.Forms.Label();
            this.data_erro = new System.Windows.Forms.Label();
            this.morada_erro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Morada";
            // 
            // MoradaTextBox
            // 
            this.MoradaTextBox.Location = new System.Drawing.Point(38, 450);
            this.MoradaTextBox.Name = "MoradaTextBox";
            this.MoradaTextBox.Size = new System.Drawing.Size(269, 22);
            this.MoradaTextBox.TabIndex = 3;
            // 
            // NomeTextBox
            // 
            this.NomeTextBox.Location = new System.Drawing.Point(38, 51);
            this.NomeTextBox.Name = "NomeTextBox";
            this.NomeTextBox.Size = new System.Drawing.Size(269, 22);
            this.NomeTextBox.TabIndex = 4;
            // 
            // Data_Nascimento_Calendario
            // 
            this.Data_Nascimento_Calendario.Location = new System.Drawing.Point(38, 148);
            this.Data_Nascimento_Calendario.Name = "Data_Nascimento_Calendario";
            this.Data_Nascimento_Calendario.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Adicionar >>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(368, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(294, 340);
            this.listBox1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(482, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Pontuar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nome_erro
            // 
            this.nome_erro.AutoSize = true;
            this.nome_erro.ForeColor = System.Drawing.Color.Red;
            this.nome_erro.Location = new System.Drawing.Point(56, 76);
            this.nome_erro.Name = "nome_erro";
            this.nome_erro.Size = new System.Drawing.Size(0, 16);
            this.nome_erro.TabIndex = 9;
            // 
            // data_erro
            // 
            this.data_erro.AutoSize = true;
            this.data_erro.ForeColor = System.Drawing.Color.Red;
            this.data_erro.Location = new System.Drawing.Point(56, 364);
            this.data_erro.Name = "data_erro";
            this.data_erro.Size = new System.Drawing.Size(0, 16);
            this.data_erro.TabIndex = 10;
            // 
            // morada_erro
            // 
            this.morada_erro.AutoSize = true;
            this.morada_erro.ForeColor = System.Drawing.Color.Red;
            this.morada_erro.Location = new System.Drawing.Point(45, 475);
            this.morada_erro.Name = "morada_erro";
            this.morada_erro.Size = new System.Drawing.Size(0, 16);
            this.morada_erro.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 553);
            this.Controls.Add(this.morada_erro);
            this.Controls.Add(this.data_erro);
            this.Controls.Add(this.nome_erro);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Data_Nascimento_Calendario);
            this.Controls.Add(this.NomeTextBox);
            this.Controls.Add(this.MoradaTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Formulário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MoradaTextBox;
        private System.Windows.Forms.TextBox NomeTextBox;
        private System.Windows.Forms.MonthCalendar Data_Nascimento_Calendario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label nome_erro;
        private System.Windows.Forms.Label data_erro;
        private System.Windows.Forms.Label morada_erro;
    }
}

