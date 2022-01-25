using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalculaSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         void CalculaSalario(double salario, double perc, ref double aumento, ref double novo)
        {
            aumento = salario * (perc / 100);
            novo    = salario + aumento;
            //MessageBox.Show("Aumento " + aumento);
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double varSalario, varPerc, varAumento=0, varNovoSalario=0;

            varSalario = Convert.ToDouble(txtSalario.Text);
            varPerc = Convert.ToDouble(txtPercentual.Text);

            CalculaSalario(varSalario, varPerc, ref varAumento, ref varNovoSalario);

            txtAumento.Text = varAumento.ToString("c");
            txtNovoSalario.Text = varNovoSalario.ToString("c");


        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            int id;
            double it;

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show(" Nome esta em branco");
                txtNome.Focus();
                return;
                
            }

            if (int.TryParse(txtIdade.Text, out id) == false)
            {
                MessageBox.Show(" Idade nãe é um inteiro ou está em branco");
                txtIdade.Focus();
                return;
            }

            if (double.TryParse (txtSal.Text, out it) == false)
            {
                MessageBox.Show(" Salario em branco");
                txtSal.Focus();
                return;
            }
                       

        }
    }
}
