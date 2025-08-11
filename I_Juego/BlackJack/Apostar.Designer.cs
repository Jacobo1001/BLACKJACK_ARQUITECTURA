namespace BlackJack
{
    partial class Apostar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.TB_CantidadApostar = new System.Windows.Forms.TextBox();
            this.TB_Puntos = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TB_ApodoJuego = new System.Windows.Forms.TextBox();
            this.B_regresar = new System.Windows.Forms.Button();
            this.B_apostar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.jugadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.juegoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.juegoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.TB_CantidadApostar);
            this.groupBox1.Controls.Add(this.TB_Puntos);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.TB_ApodoJuego);
            this.groupBox1.Controls.Add(this.B_regresar);
            this.groupBox1.Controls.Add(this.B_apostar);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(-2, -5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1004, 642);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.textBox1.Font = new System.Drawing.Font("Stencil", 17.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(672, 422);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(267, 35);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "CANTIDAD A APOSTAR";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::BlackJack.Properties.Resources.fondo_juego;
            this.pictureBox4.Image = global::BlackJack.Properties.Resources.REGLAS;
            this.pictureBox4.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(397, 640);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // TB_CantidadApostar
            // 
            this.TB_CantidadApostar.Font = new System.Drawing.Font("Stencil", 17.25F, System.Drawing.FontStyle.Bold);
            this.TB_CantidadApostar.Location = new System.Drawing.Point(672, 466);
            this.TB_CantidadApostar.Margin = new System.Windows.Forms.Padding(2);
            this.TB_CantidadApostar.Name = "TB_CantidadApostar";
            this.TB_CantidadApostar.Size = new System.Drawing.Size(267, 35);
            this.TB_CantidadApostar.TabIndex = 13;
            this.TB_CantidadApostar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_CantidadApostar.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TB_Puntos
            // 
            this.TB_Puntos.BackColor = System.Drawing.Color.RosyBrown;
            this.TB_Puntos.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.juegoBindingSource, "Contador_PGenerales", true));
            this.TB_Puntos.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Puntos.ForeColor = System.Drawing.SystemColors.Window;
            this.TB_Puntos.Location = new System.Drawing.Point(597, 332);
            this.TB_Puntos.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Puntos.Name = "TB_Puntos";
            this.TB_Puntos.ReadOnly = true;
            this.TB_Puntos.Size = new System.Drawing.Size(55, 30);
            this.TB_Puntos.TabIndex = 12;
            this.TB_Puntos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_Puntos.TextChanged += new System.EventHandler(this.TB_Puntos_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BlackJack.Properties.Resources.VILLANO;
            this.pictureBox3.Location = new System.Drawing.Point(785, 25);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(199, 214);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BlackJack.Properties.Resources.HEROE;
            this.pictureBox2.Location = new System.Drawing.Point(420, 366);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(232, 232);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // TB_ApodoJuego
            // 
            this.TB_ApodoJuego.BackColor = System.Drawing.Color.RosyBrown;
            this.TB_ApodoJuego.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.jugadorBindingSource, "Apodo", true));
            this.TB_ApodoJuego.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadorBindingSource, "Apodo", true));
            this.TB_ApodoJuego.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ApodoJuego.ForeColor = System.Drawing.SystemColors.Window;
            this.TB_ApodoJuego.Location = new System.Drawing.Point(420, 332);
            this.TB_ApodoJuego.Margin = new System.Windows.Forms.Padding(2);
            this.TB_ApodoJuego.Name = "TB_ApodoJuego";
            this.TB_ApodoJuego.ReadOnly = true;
            this.TB_ApodoJuego.Size = new System.Drawing.Size(173, 30);
            this.TB_ApodoJuego.TabIndex = 8;
            this.TB_ApodoJuego.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_ApodoJuego.TextChanged += new System.EventHandler(this.TB_ApodoJuego_TextChanged);
            // 
            // B_regresar
            // 
            this.B_regresar.BackColor = System.Drawing.Color.RosyBrown;
            this.B_regresar.Font = new System.Drawing.Font("Stencil", 17.25F, System.Drawing.FontStyle.Bold);
            this.B_regresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_regresar.Location = new System.Drawing.Point(420, 16);
            this.B_regresar.Margin = new System.Windows.Forms.Padding(2);
            this.B_regresar.Name = "B_regresar";
            this.B_regresar.Size = new System.Drawing.Size(132, 48);
            this.B_regresar.TabIndex = 6;
            this.B_regresar.Text = "Inicio";
            this.B_regresar.UseVisualStyleBackColor = false;
            this.B_regresar.Click += new System.EventHandler(this.B_regresar_Click);
            // 
            // B_apostar
            // 
            this.B_apostar.BackColor = System.Drawing.Color.RosyBrown;
            this.B_apostar.Font = new System.Drawing.Font("Stencil", 17.25F, System.Drawing.FontStyle.Bold);
            this.B_apostar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_apostar.Location = new System.Drawing.Point(672, 496);
            this.B_apostar.Margin = new System.Windows.Forms.Padding(2);
            this.B_apostar.Name = "B_apostar";
            this.B_apostar.Size = new System.Drawing.Size(267, 38);
            this.B_apostar.TabIndex = 3;
            this.B_apostar.Text = "Apostar";
            this.B_apostar.UseVisualStyleBackColor = false;
            this.B_apostar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BlackJack.Properties.Resources.fondo_juego;
            this.pictureBox1.Image = global::BlackJack.Properties.Resources.fondo_juego;
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1008, 637);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // jugadorBindingSource
            // 
            this.jugadorBindingSource.DataSource = typeof(Biblioteca_Cartas.Clases.Jugador);
            // 
            // juegoBindingSource
            // 
            this.juegoBindingSource.DataSource = typeof(Biblioteca_Cartas.Clases.Juego);
            // 
            // Apostar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 609);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Apostar";
            this.Text = "Apostar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juegoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button B_apostar;
        private System.Windows.Forms.Button B_regresar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox TB_ApodoJuego;
        public System.Windows.Forms.TextBox TB_Puntos;
        public System.Windows.Forms.TextBox TB_CantidadApostar;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource jugadorBindingSource;
        private System.Windows.Forms.BindingSource juegoBindingSource;
    }
}