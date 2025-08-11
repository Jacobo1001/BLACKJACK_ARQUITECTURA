namespace BlackJack
{
    partial class FinPartida_P
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
            this.Gb_perdio = new System.Windows.Forms.GroupBox();
            this.B_regresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Gb_perdio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Gb_perdio
            // 
            this.Gb_perdio.Controls.Add(this.B_regresar);
            this.Gb_perdio.Controls.Add(this.pictureBox1);
            this.Gb_perdio.Location = new System.Drawing.Point(2, -1);
            this.Gb_perdio.Margin = new System.Windows.Forms.Padding(2);
            this.Gb_perdio.Name = "Gb_perdio";
            this.Gb_perdio.Padding = new System.Windows.Forms.Padding(2);
            this.Gb_perdio.Size = new System.Drawing.Size(947, 613);
            this.Gb_perdio.TabIndex = 0;
            this.Gb_perdio.TabStop = false;
            this.Gb_perdio.Text = "Gb_perdio";
            // 
            // B_regresar
            // 
            this.B_regresar.BackColor = System.Drawing.Color.RosyBrown;
            this.B_regresar.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_regresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_regresar.Location = new System.Drawing.Point(672, 534);
            this.B_regresar.Margin = new System.Windows.Forms.Padding(2);
            this.B_regresar.Name = "B_regresar";
            this.B_regresar.Size = new System.Drawing.Size(265, 65);
            this.B_regresar.TabIndex = 4;
            this.B_regresar.Text = "TE ATREVES A \r\nVOLVER A INTENTAR...\r\n";
            this.B_regresar.UseVisualStyleBackColor = false;
            this.B_regresar.Click += new System.EventHandler(this.B_regresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BlackJack.Properties.Resources.PARTIDA_PERDIDA;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(947, 613);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FinPartida_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 609);
            this.Controls.Add(this.Gb_perdio);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FinPartida_P";
            this.Text = "FinPartida_P";
            this.Gb_perdio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gb_perdio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button B_regresar;
    }
}