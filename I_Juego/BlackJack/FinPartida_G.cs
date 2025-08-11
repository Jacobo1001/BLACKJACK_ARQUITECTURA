using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class FinPartida_G : Form
    {
        public FinPartida_G()
        {
            InitializeComponent();
        }

        private void B_regresar_Click(object sender, EventArgs e)
        {
            Inicio mostrar_inicio = new Inicio();
            mostrar_inicio.Show();
            this.Visible = false;
        }
    }
}
