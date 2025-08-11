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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BlackJack
{
    public partial class Juego_Baraja : Form
    {

        private List<Carta> cartas_jugador;
        private List<Carta> cartas_maquina;

        public Juego_Baraja()
        {
            InitializeComponent();
        }

        private void B_regresar_Click(object sender, EventArgs e)
        {
            Inicio mostrar_inicio = new Inicio();
            mostrar_inicio.Show();
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TB_CantApostada_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Juego_Baraja_Load(object sender, EventArgs e)
        {

        }

        private void B_Plantarse_Click(object sender, EventArgs e)
        {
            try{ 
                int n = 0;
                int comodines = 0;

                Juego juego = new Juego(Convert.ToInt32(TB_Puntos.Text), TB_ApodoJuego.Text);
                juego.j1.Cartas_jugador = cartas_jugador;
                juego.maquina.Cartas_jugador = cartas_maquina;
                juego.contador_PGenerales = Convert.ToInt32(TB_Puntos.Text);

                List<PictureBox> cartasMaquina = new List<PictureBox>
                {
                    CartaMaquina1, CartaMaquina2, CartaMaquina3, CartaMaquina4
                };

                juego.CartasComodin(juego.j1.Cartas_jugador, juego.maquina.Cartas_jugador);


                juego.maquina.cartas_jugador.ForEach(carta =>
                {
                    cartasMaquina[n].Image = Image.FromFile("C:\\Users\\jacob\\Desktop\\NUEVO PROYECTO POO\\Imagenes\\" + carta.Descripcion + ".jpg");
                    n++;
                });


                TB_PuntosMaquina.Text = Convert.ToString(juego.maquina.cartas_jugador.Sum(carta => carta.Punto_carta));

                juego.Jugar(true, Convert.ToInt32(TB_CantApostada.Text));

                int.TryParse(TB_PuntosCartas.Text, out int puntosCarUsuario);
                int.TryParse(TB_PuntosMaquina.Text, out int puntosCarMaquina);

                comodines += juego.j1.cartas_jugador.Sum(carta =>
                    (carta.Valor_juego == 5) ? 5 :
                    (carta.Valor_juego == -5) ? -5 : 0);

                string mensaje = (puntosCarUsuario <= 21 && puntosCarMaquina <= 21) ?
                    (puntosCarUsuario > puntosCarMaquina ? "Ronda ganada, ganas " + TB_CantApostada.Text + " puntos\n Puntos de comodines: " + comodines :
                    puntosCarUsuario < puntosCarMaquina ? "Ronda perdida, pierdes " + TB_CantApostada.Text + " puntos\n Puntos de comodines: " + comodines :
                    "Ronda empatada\n Puntos de comodines: " + comodines) :
                    (puntosCarUsuario <= 21 && puntosCarMaquina > 21 ? "Ronda ganada, ganas " + TB_CantApostada.Text + " puntos\n Puntos de comodines: " + comodines :
                    puntosCarUsuario > 21 && puntosCarMaquina <= 21 ? "Ronda perdida, pierdes " + TB_CantApostada.Text + " puntos\n Puntos de comodines: " + comodines :
                    "Ronda empatada\n Puntos de comodines: " + comodines);

                MessageBox.Show(mensaje);



                TB_Puntos.Text = Convert.ToString(juego.contador_PGenerales);

                B_Plantarse.Visible = false;
                B_Pedir.Visible = false;
                B_terminar.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en función Plantarse: " + ex.Message);
            }

        }

        private void Repartir_cartas_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;

                Juego juego = new Juego(Convert.ToInt32(TB_Puntos.Text), TB_ApodoJuego.Text);
                juego.Apostar(Convert.ToInt32(TB_CantApostada.Text));
                juego.CartasComodin(juego.j1.Cartas_jugador, juego.maquina.Cartas_jugador);
                juego.Pedir_CMaquina(juego.maquina.Cartas_jugador);

                List<PictureBox> cartasJugador = new List<PictureBox>
                {
                    CartaJugador1, CartaJugador2, CartaJugador3, CartaJugador4, CartaJugador5, CartaJugador6
                };

                juego.j1.cartas_jugador.ForEach(carta =>
                {
                    cartasJugador[i].Image = Image.FromFile("C:\\Users\\jacob\\Desktop\\NUEVO PROYECTO POO\\Imagenes\\" + carta.Descripcion + ".jpg");
                    i++;
                });

                CartaMaquina1.Image = Image.FromFile("C:\\Users\\jacob\\Desktop\\NUEVO PROYECTO POO\\Imagenes\\" + juego.maquina.cartas_jugador[0].Descripcion + ".jpg");

                TB_PuntosCartas.Text = juego.j1.cartas_jugador.Sum(carta => carta.Punto_carta).ToString();

                cartas_jugador = new List<Carta>(juego.j1.cartas_jugador);
                cartas_maquina = new List<Carta>(juego.maquina.cartas_jugador);

                B_Plantarse.Visible = true;
                B_Pedir.Visible = true;
                Repartir_cartas.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en función Repartir Cartas: " + ex.Message);
            }
        }

        private void B_Pedir_Click(object sender, EventArgs e)
        {
            try
            {
                List<PictureBox> cartasJugador = new List<PictureBox>
                {
                    CartaJugador1, CartaJugador2, CartaJugador3, CartaJugador4, CartaJugador5, CartaJugador6
                };

                int i = 0;

                Juego juego = new Juego(Convert.ToInt32(TB_Puntos.Text), TB_ApodoJuego.Text);
                juego.j1.Cartas_jugador = cartas_jugador;
                juego.Jugar(false, Convert.ToInt32(TB_CantApostada.Text));
                cartas_jugador = new List<Carta>(juego.j1.cartas_jugador);
                juego.ControlAS(juego.j1.cartas_jugador);

                juego.j1.cartas_jugador.ForEach(carta =>
                {
                    if (i < 6)
                    {
                        cartasJugador[i].Image = Image.FromFile("C:\\Users\\jacob\\Desktop\\NUEVO PROYECTO POO\\Imagenes\\" + carta.Descripcion + ".jpg");
                        i++;
                        if (i == 6)
                        {
                            B_Pedir.Visible = false;
                        }
                    }
                });

                TB_PuntosCartas.Text = Convert.ToString(juego.j1.cartas_jugador.Sum(carta => carta.Punto_carta));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void B_terminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToInt32(TB_Puntos.Text) <= 0)
                {
                    FinPartida_P mostrar_fin = new FinPartida_P();
                    mostrar_fin.Show();
                    this.Visible = false;
                }
                else if(Convert.ToInt32(TB_Puntos.Text) >= 200)
                {
                    FinPartida_G mostrar_fin = new FinPartida_G();
                    mostrar_fin.Show();
                    this.Visible = false;
                }
                else
                {
                    Apostar mostrar_apostar = new Apostar();
                    mostrar_apostar.Show();
                    this.Visible = false;

                    mostrar_apostar.TB_ApodoJuego.Text = TB_ApodoJuego.Text;
                    mostrar_apostar.TB_Puntos.Text = TB_Puntos.Text;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error en boton terminar ronda");
            }
        }

        private void TB_ApodoJuego_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CartaJugador1_Click(object sender, EventArgs e)
        {

        }

        private void CartaJugador2_Click(object sender, EventArgs e)
        {

        }

        private void CartaJugador3_Click(object sender, EventArgs e)
        {

        }

        private void CartaJugador4_Click(object sender, EventArgs e)
        {

        }

        private void CartaJugador6_Click(object sender, EventArgs e)
        {

        }

        private void CartaJugador5_Click(object sender, EventArgs e)
        {

        }
    }
}
