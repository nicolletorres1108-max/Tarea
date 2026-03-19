using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventosenlaforma
{
    public partial class TextBox_valores_númericos : Form
    {
        public TextBox_valores_númericos()
        {
            InitializeComponent();
        }

        private void TextBox_valores_númericos_Load(object sender, EventArgs e)
        {
            lblresultado.Text = "";
            txta.Text = "0";
            txtb.Text = "0";
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txta.Text);
            double b = Convert.ToDouble(txtb.Text);

            double r = a + b;

            lblresultado.Text = r.ToString();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txta.Text);
            double b = Convert.ToDouble(txtb.Text);

            double r = a - b;

            lblresultado.Text = r.ToString();
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txta.Text);
            double b = Convert.ToDouble(txtb.Text);

            double r = a * b;

            lblresultado.Text = r.ToString();
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txta.Text);
            double b = Convert.ToDouble(txtb.Text);

            double r = a / b;

            lblresultado.Text = r.ToString();
        }
    }
}
