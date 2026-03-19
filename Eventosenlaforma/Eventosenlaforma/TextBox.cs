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
    public partial class TextBox : Form
    {
        public TextBox()
        {
            InitializeComponent();
        }
        private void TextBox_Load(object sender, EventArgs e)
        {
            lblmensaje.Text = "";
        }

        private void btnsaludo_Click(object sender, EventArgs e)
        {
         lblmensaje.Text = txtnombre.Text + " es el nombre, ¡Hola!";
        }
    }
}
