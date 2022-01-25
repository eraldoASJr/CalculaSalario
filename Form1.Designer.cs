namespace ProjetoCalculaSalario
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtPercentual = new System.Windows.Forms.TextBox();
            this.txtAumento = new System.Windows.Forms.TextBox();
            this.txtNovoSalario = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Percentual de reajuste";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Novo Salario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor Aumento";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(492, 57);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(166, 38);
            this.txtSalario.TabIndex = 4;
            // 
            // txtPercentual
            // 
            this.txtPercentual.Location = new System.Drawing.Point(492, 119);
            this.txtPercentual.Name = "txtPercentual";
            this.txtPercentual.Size = new System.Drawing.Size(166, 38);
            this.txtPercentual.TabIndex = 5;
            // 
            // txtAumento
            // 
            this.txtAumento.Location = new System.Drawing.Point(492, 181);
            this.txtAumento.Name = "txtAumento";
            this.txtAumento.Size = new System.Drawing.Size(166, 38);
            this.txtAumento.TabIndex = 6;
            // 
            // txtNovoSalario
            // 
            this.txtNovoSalario.Location = new System.Drawing.Point(492, 253);
            this.txtNovoSalario.Name = "txtNovoSalario";
            this.txtNovoSalario.Size = new System.Drawing.Size(166, 38);
            this.txtNovoSalario.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(718, 130);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(134, 76);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Idade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "Salario:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(492, 337);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(213, 38);
            this.txtNome.TabIndex = 12;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(492, 388);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(213, 38);
            this.txtIdade.TabIndex = 13;
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(492, 442);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(213, 38);
            this.txtSal.TabIndex = 14;
            // 
            // btnVerifica
            // 
            this.btnVerifica.Location = new System.Drawing.Point(740, 385);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(131, 47);
            this.btnVerifica.TabIndex = 15;
            this.btnVerifica.Text = "Verifica";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNovoSalario);
            this.Controls.Add(this.txtAumento);
            this.Controls.Add(this.txtPercentual);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtPercentual;
        private System.Windows.Forms.TextBox txtAumento;
        private System.Windows.Forms.TextBox txtNovoSalario;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.Button btnVerifica;
    }
}

