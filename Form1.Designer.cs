namespace DesafioLista
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_numAlunos = new System.Windows.Forms.TextBox();
            this.textBox_numPessoas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_listaAlunos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade de Alunos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade de Pessoas";
            // 
            // textBox_numAlunos
            // 
            this.textBox_numAlunos.Enabled = false;
            this.textBox_numAlunos.Location = new System.Drawing.Point(143, 10);
            this.textBox_numAlunos.Name = "textBox_numAlunos";
            this.textBox_numAlunos.Size = new System.Drawing.Size(43, 20);
            this.textBox_numAlunos.TabIndex = 2;
            // 
            // textBox_numPessoas
            // 
            this.textBox_numPessoas.Enabled = false;
            this.textBox_numPessoas.Location = new System.Drawing.Point(143, 36);
            this.textBox_numPessoas.Name = "textBox_numPessoas";
            this.textBox_numPessoas.Size = new System.Drawing.Size(43, 20);
            this.textBox_numPessoas.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lista Alunos";
            // 
            // textBox_listaAlunos
            // 
            this.textBox_listaAlunos.Enabled = false;
            this.textBox_listaAlunos.Location = new System.Drawing.Point(261, 42);
            this.textBox_listaAlunos.Multiline = true;
            this.textBox_listaAlunos.Name = "textBox_listaAlunos";
            this.textBox_listaAlunos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_listaAlunos.Size = new System.Drawing.Size(337, 217);
            this.textBox_listaAlunos.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Gerar Relatório";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_listaAlunos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_numPessoas);
            this.Controls.Add(this.textBox_numAlunos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_numAlunos;
        private System.Windows.Forms.TextBox textBox_numPessoas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_listaAlunos;
        private System.Windows.Forms.Button button1;
    }
}

