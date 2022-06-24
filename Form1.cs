using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraAplicacion
{
    public partial class btn1 : Form
    {
        public btn1()
        {
            InitializeComponent();
        }

        private void Name_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void Name_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Adios y buena suerte...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se disparo el evento Click", "Atención");
            this.BackColor = Color.CadetBlue ;

        }

        private void form_Click(object sender, EventArgs e)
        {
            MouseEventArgs Click = (MouseEventArgs) e;

            if (Click.Button == MouseButtons.Left)

                MessageBox.Show("Presiono el botón Izquierdo", "Atención");

            else if (Click.Button == MouseButtons.Right)

                MessageBox.Show("Presiono el Botón Derecho", "Atención");
            else

            if (Click.Button == MouseButtons.Middle)

                MessageBox.Show("Presiono el botón del Medio", "Atención");

        }

        private void lbl1_MouseMove(object sender, MouseEventArgs e)
        {

            lbl1.BackColor = Color.Cyan;
            lbl1.Cursor = Cursors.Hand;
        }










    }
}
