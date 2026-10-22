namespace tareaClase
{
    partial class FrmProyeccion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblAx = new System.Windows.Forms.Label();
            this.txtAx = new System.Windows.Forms.TextBox();
            this.lblAy = new System.Windows.Forms.Label();
            this.txtAy = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.lblBx = new System.Windows.Forms.Label();
            this.txtBx = new System.Windows.Forms.TextBox();
            this.lblBy = new System.Windows.Forms.Label();
            this.txtBy = new System.Windows.Forms.TextBox();
            this.lblP = new System.Windows.Forms.Label();
            this.lblPx = new System.Windows.Forms.Label();
            this.txtPx = new System.Windows.Forms.TextBox();
            this.lblPy = new System.Windows.Forms.Label();
            this.txtPy = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grpResultados = new System.Windows.Forms.GroupBox();
            this.lblTituloQ = new System.Windows.Forms.Label();
            this.lblQ = new System.Windows.Forms.Label();
            this.lblTituloDistancia = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.picGrafica = new System.Windows.Forms.PictureBox();
            this.grpDatos.SuspendLayout();
            this.grpResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrafica)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.lblA);
            this.grpDatos.Controls.Add(this.lblAx);
            this.grpDatos.Controls.Add(this.txtAx);
            this.grpDatos.Controls.Add(this.lblAy);
            this.grpDatos.Controls.Add(this.txtAy);
            this.grpDatos.Controls.Add(this.lblB);
            this.grpDatos.Controls.Add(this.lblBx);
            this.grpDatos.Controls.Add(this.txtBx);
            this.grpDatos.Controls.Add(this.lblBy);
            this.grpDatos.Controls.Add(this.txtBy);
            this.grpDatos.Controls.Add(this.lblP);
            this.grpDatos.Controls.Add(this.lblPx);
            this.grpDatos.Controls.Add(this.txtPx);
            this.grpDatos.Controls.Add(this.lblPy);
            this.grpDatos.Controls.Add(this.txtPy);
            this.grpDatos.Controls.Add(this.btnCalcular);
            this.grpDatos.Location = new System.Drawing.Point(12, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(235, 205);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Puntos de Entrada";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblA.Location = new System.Drawing.Point(10, 30);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(56, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Punto A:";
            // 
            // lblAx
            // 
            this.lblAx.AutoSize = true;
            this.lblAx.Location = new System.Drawing.Point(75, 30);
            this.lblAx.Name = "lblAx";
            this.lblAx.Size = new System.Drawing.Size(17, 13);
            this.lblAx.TabIndex = 1;
            this.lblAx.Text = "X:";
            // 
            // txtAx
            // 
            this.txtAx.Location = new System.Drawing.Point(95, 27);
            this.txtAx.Name = "txtAx";
            this.txtAx.Size = new System.Drawing.Size(45, 20);
            this.txtAx.TabIndex = 2;
            this.txtAx.Text = "2";
            // 
            // lblAy
            // 
            this.lblAy.AutoSize = true;
            this.lblAy.Location = new System.Drawing.Point(150, 30);
            this.lblAy.Name = "lblAy";
            this.lblAy.Size = new System.Drawing.Size(17, 13);
            this.lblAy.TabIndex = 3;
            this.lblAy.Text = "Y:";
            // 
            // txtAy
            // 
            this.txtAy.Location = new System.Drawing.Point(170, 27);
            this.txtAy.Name = "txtAy";
            this.txtAy.Size = new System.Drawing.Size(45, 20);
            this.txtAy.TabIndex = 4;
            this.txtAy.Text = "2";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblB.Location = new System.Drawing.Point(10, 68);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(56, 13);
            this.lblB.TabIndex = 5;
            this.lblB.Text = "Punto B:";
            // 
            // lblBx
            // 
            this.lblBx.AutoSize = true;
            this.lblBx.Location = new System.Drawing.Point(75, 68);
            this.lblBx.Name = "lblBx";
            this.lblBx.Size = new System.Drawing.Size(17, 13);
            this.lblBx.TabIndex = 6;
            this.lblBx.Text = "X:";
            // 
            // txtBx
            // 
            this.txtBx.Location = new System.Drawing.Point(95, 65);
            this.txtBx.Name = "txtBx";
            this.txtBx.Size = new System.Drawing.Size(45, 20);
            this.txtBx.TabIndex = 7;
            this.txtBx.Text = "8";
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.Location = new System.Drawing.Point(150, 68);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(17, 13);
            this.lblBy.TabIndex = 8;
            this.lblBy.Text = "Y:";
            // 
            // txtBy
            // 
            this.txtBy.Location = new System.Drawing.Point(170, 65);
            this.txtBy.Name = "txtBy";
            this.txtBy.Size = new System.Drawing.Size(45, 20);
            this.txtBy.TabIndex = 9;
            this.txtBy.Text = "4";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblP.Location = new System.Drawing.Point(10, 106);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(56, 13);
            this.lblP.TabIndex = 10;
            this.lblP.Text = "Punto P:";
            // 
            // lblPx
            // 
            this.lblPx.AutoSize = true;
            this.lblPx.Location = new System.Drawing.Point(75, 106);
            this.lblPx.Name = "lblPx";
            this.lblPx.Size = new System.Drawing.Size(17, 13);
            this.lblPx.TabIndex = 11;
            this.lblPx.Text = "X:";
            // 
            // txtPx
            // 
            this.txtPx.Location = new System.Drawing.Point(95, 103);
            this.txtPx.Name = "txtPx";
            this.txtPx.Size = new System.Drawing.Size(45, 20);
            this.txtPx.TabIndex = 12;
            this.txtPx.Text = "5";
            // 
            // lblPy
            // 
            this.lblPy.AutoSize = true;
            this.lblPy.Location = new System.Drawing.Point(150, 106);
            this.lblPy.Name = "lblPy";
            this.lblPy.Size = new System.Drawing.Size(17, 13);
            this.lblPy.TabIndex = 13;
            this.lblPy.Text = "Y:";
            // 
            // txtPy
            // 
            this.txtPy.Location = new System.Drawing.Point(170, 103);
            this.txtPy.Name = "txtPy";
            this.txtPy.Size = new System.Drawing.Size(45, 20);
            this.txtPy.TabIndex = 14;
            this.txtPy.Text = "6";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(13, 147);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(202, 38);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular y Graficar";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // grpResultados
            // 
            this.grpResultados.Controls.Add(this.lblTituloQ);
            this.grpResultados.Controls.Add(this.lblQ);
            this.grpResultados.Controls.Add(this.lblTituloDistancia);
            this.grpResultados.Controls.Add(this.lblDistancia);
            this.grpResultados.Controls.Add(this.lblMensaje);
            this.grpResultados.Location = new System.Drawing.Point(12, 230);
            this.grpResultados.Name = "grpResultados";
            this.grpResultados.Size = new System.Drawing.Size(235, 230);
            this.grpResultados.TabIndex = 1;
            this.grpResultados.TabStop = false;
            this.grpResultados.Text = "Resultados";
            // 
            // lblTituloQ
            // 
            this.lblTituloQ.AutoSize = true;
            this.lblTituloQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloQ.Location = new System.Drawing.Point(10, 25);
            this.lblTituloQ.Name = "lblTituloQ";
            this.lblTituloQ.Size = new System.Drawing.Size(129, 13);
            this.lblTituloQ.TabIndex = 0;
            this.lblTituloQ.Text = "Punto Q (Proyección):";
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblQ.Location = new System.Drawing.Point(10, 48);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(90, 16);
            this.lblQ.TabIndex = 1;
            this.lblQ.Text = "Q = (0.0, 0.0)";
            // 
            // lblTituloDistancia
            // 
            this.lblTituloDistancia.AutoSize = true;
            this.lblTituloDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDistancia.Location = new System.Drawing.Point(10, 85);
            this.lblTituloDistancia.Name = "lblTituloDistancia";
            this.lblTituloDistancia.Size = new System.Drawing.Size(107, 13);
            this.lblTituloDistancia.TabIndex = 2;
            this.lblTituloDistancia.Text = "Distancia Mínima:";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistancia.ForeColor = System.Drawing.Color.Crimson;
            this.lblDistancia.Location = new System.Drawing.Point(10, 108);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(35, 16);
            this.lblDistancia.TabIndex = 3;
            this.lblDistancia.Text = "0.00";
            // 
            // lblMensaje
            // 
            this.lblMensaje.ForeColor = System.Drawing.Color.DimGray;
            this.lblMensaje.Location = new System.Drawing.Point(10, 140);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(210, 75);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.Text = "Estado";
            // 
            // picGrafica
            // 
            this.picGrafica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picGrafica.BackColor = System.Drawing.Color.White;
            this.picGrafica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGrafica.Location = new System.Drawing.Point(260, 12);
            this.picGrafica.Name = "picGrafica";
            this.picGrafica.Size = new System.Drawing.Size(612, 450);
            this.picGrafica.TabIndex = 2;
            this.picGrafica.TabStop = false;
            this.picGrafica.Paint += new System.Windows.Forms.PaintEventHandler(this.picGrafica_Paint);
            this.picGrafica.Resize += new System.EventHandler(this.picGrafica_Resize);
            // 
            // FrmProyeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 474);
            this.Controls.Add(this.picGrafica);
            this.Controls.Add(this.grpResultados);
            this.Controls.Add(this.grpDatos);
            this.MinimumSize = new System.Drawing.Size(700, 480);
            this.Name = "FrmProyeccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyección sobre Segmentos";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpResultados.ResumeLayout(false);
            this.grpResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrafica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblAx;
        private System.Windows.Forms.TextBox txtAx;
        private System.Windows.Forms.Label lblAy;
        private System.Windows.Forms.TextBox txtAy;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblBx;
        private System.Windows.Forms.TextBox txtBx;
        private System.Windows.Forms.Label lblBy;
        private System.Windows.Forms.TextBox txtBy;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblPx;
        private System.Windows.Forms.TextBox txtPx;
        private System.Windows.Forms.Label lblPy;
        private System.Windows.Forms.TextBox txtPy;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox grpResultados;
        private System.Windows.Forms.Label lblTituloQ;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblTituloDistancia;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.PictureBox picGrafica;
    }
}
