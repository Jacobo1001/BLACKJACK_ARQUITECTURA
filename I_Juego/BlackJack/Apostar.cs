using Biblioteca_Cartas.Clases;
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
    public partial class Apostar : Form
    {
        public Apostar()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string valorApostar = TB_CantidadApostar.Text;
                string cantPuntos = TB_Puntos.Text;

                MessageBox.Show(String.IsNullOrEmpty(valorApostar) ? "Debe ingresar una cantidad para apostar" :
                    !(int.TryParse(cantPuntos, out int puntos) && int.TryParse(valorApostar, out int apostado)) ? "Se debe ingresar un valor numérico" :
                    apostado <= 0 ? "La cantidad a apostar debe ser mayor a cero" :
                    puntos < apostado && apostado > 0 ? "La cantidad a apostar debe ser menor o igual a los puntos actuales del jugador" :
                    "Apuesta válida");

                if (String.IsNullOrEmpty(valorApostar) || !(int.TryParse(cantPuntos, out puntos) && int.TryParse(valorApostar, out apostado)) || apostado <= 0 || (puntos < apostado && apostado > 0))
                    return;

                Juego_Baraja juego = new Juego_Baraja();
                juego.Show();
                this.Visible = false;

                juego.TB_ApodoJuego.Text = TB_ApodoJuego.Text;
                juego.TB_Puntos.Text = (puntos - apostado).ToString();
                juego.TB_CantApostada.Text = valorApostar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en función apostar" + ex);
            }
        }

        private void B_regresar_Click(object sender, EventArgs e)
        {
            Inicio mostrar_inicio = new Inicio();
            mostrar_inicio.Show();
            this.Visible = false;
        
        }

        private void Baraja_Click(object sender, EventArgs e)
        {

        }

        private void TB_ApodoJuego_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_Puntos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
