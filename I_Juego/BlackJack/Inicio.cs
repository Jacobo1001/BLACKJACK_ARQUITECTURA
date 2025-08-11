using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca_Cartas.Clases;

namespace BlackJack
{
    public partial class Inicio : Form
    {

        private string apodo;

        public string Apodo { get => apodo; }

        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Bt_Jugar_Click(object sender, EventArgs e)
        {
            try
            {
                apodo = tb_Apodo.Text;

                apodo = (string.IsNullOrEmpty(apodo) || string.IsNullOrWhiteSpace(apodo))
                    ? throw new Exception("El apodo ingresado no puede estar vacío.")
                    : apodo;

                MessageBox.Show(apodo.Length < 3 ? "El apodo ingresado no es válido, debe tener al menos 3 caracteres." :
                                apodo.Length > 13 ? "El apodo ingresado no es válido, debe tener menos de 13 caracteres." : "BIENVENIDO " + apodo.ToUpper());

                Jugador jugador = new Jugador(apodo);
                Juego juego = new Juego(jugador.Puntos, jugador.Apodo);

                Apostar mostrar_apostar = new Apostar();
                mostrar_apostar.Show();
                this.Visible = false;

                mostrar_apostar.TB_Puntos.Text = juego.j1.Puntos.ToString();
                mostrar_apostar.TB_ApodoJuego.Text = apodo.ToUpper();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Apodo inválido: " + ex.Message);
            }
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
