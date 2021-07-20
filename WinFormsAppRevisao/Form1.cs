using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppRevisao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double primeiro_num = Convert.ToDouble(txt_primero_numero.Text);
            double segundo_num = Convert.ToDouble(txt_segundo_numero.Text);

            double resultado = primeiro_num + segundo_num;

            MessageBox.Show("A soma dos números é " + resultado);

            MessageBox.Show(
                "Resultado", 
                "A soma dos números é " + resultado, 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information
            );
        }
    }
}
