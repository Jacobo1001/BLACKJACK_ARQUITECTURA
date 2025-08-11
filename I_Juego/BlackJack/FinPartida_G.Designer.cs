namespace BlackJack
{
    partial class FinPartida_G
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
            this.GB_gano = new System.Windows.Forms.GroupBox();
            this.B_regresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GB_gano.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_gano
            // 
            this.GB_gano.Controls.Add(this.B_regresar);
            this.GB_gano.Controls.Add(this.pictureBox1);
            this.GB_gano.Location = new System.Drawing.Point(1, -5);
            this.GB_gano.Margin = new System.Windows.Forms.Padding(2);
            this.GB_gano.Name = "GB_gano";
            this.GB_gano.Padding = new System.Windows.Forms.Padding(2);
            this.GB_gano.Size = new System.Drawing.Size(953, 634);
            this.GB_gano.TabIndex = 0;
            this.GB_gano.TabStop = false;
            this.GB_gano.Text = "GB_gano";
            // 
            // B_regresar
            // 
            this.B_regresar.BackColor = System.Drawing.Color.RosyBrown;
            this.B_regresar.Font = new System.Drawing.Font("Stencil", 17.25F, System.Drawing.FontStyle.Bold);
            this.B_regresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_regresar.Location = new System.Drawing.Point(357, 427);
            this.B_regresar.Margin = new System.Windows.Forms.Padding(2);
            this.B_regresar.Name = "B_regresar";
            this.B_regresar.Size = new System.Drawing.Size(256, 72);
            this.B_regresar.TabIndex = 5;
            this.B_regresar.Text = "NO TENDRAS LA \r\nMISMA SUERTE...";
            this.B_regresar.UseVisualStyleBackColor = false;
            this.B_regresar.Click += new System.EventHandler(this.B_regresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Image = global::BlackJack.Properties.Resources.PARTIDA_GANADA;
            this.pictureBox1.Location = new System.Drawing.Point(0, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(953, 626);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FinPartida_G
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 631);
            this.Controls.Add(this.GB_gano);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FinPartida_G";
            this.Text = "FinPartida_G";
            this.GB_gano.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_gano;
        private System.Windows.Forms.Button B_regresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}