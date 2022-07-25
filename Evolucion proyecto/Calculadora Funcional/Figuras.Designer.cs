namespace Calculadora_Funcional
{
    partial class Figuras
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
            this.txtResArea = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCuadrado = new System.Windows.Forms.RadioButton();
            this.rdbCirculo = new System.Windows.Forms.RadioButton();
            this.rdbRect = new System.Windows.Forms.RadioButton();
            this.rdbRombo = new System.Windows.Forms.RadioButton();
            this.rdbOvalo = new System.Windows.Forms.RadioButton();
            this.rdbPoligono = new System.Windows.Forms.RadioButton();
            this.lblDato1 = new System.Windows.Forms.Label();
            this.txtDato1 = new System.Windows.Forms.TextBox();
            this.rdbTrapecio = new System.Windows.Forms.RadioButton();
            this.txtDato2 = new System.Windows.Forms.TextBox();
            this.lblDato2 = new System.Windows.Forms.Label();
            this.txtDato3 = new System.Windows.Forms.TextBox();
            this.lblDato3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rdbTriangulo = new System.Windows.Forms.RadioButton();
            this.txtResPerimetro = new System.Windows.Forms.TextBox();
            this.txtDato4 = new System.Windows.Forms.TextBox();
            this.lblDato4 = new System.Windows.Forms.Label();
            this.txtDato5 = new System.Windows.Forms.TextBox();
            this.lblDato5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResArea
            // 
            this.txtResArea.BackColor = System.Drawing.Color.DarkGreen;
            this.txtResArea.Font = new System.Drawing.Font("Digital-7", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResArea.ForeColor = System.Drawing.Color.White;
            this.txtResArea.Location = new System.Drawing.Point(12, 12);
            this.txtResArea.Name = "txtResArea";
            this.txtResArea.ReadOnly = true;
            this.txtResArea.Size = new System.Drawing.Size(290, 54);
            this.txtResArea.TabIndex = 2;
            this.txtResArea.Text = "Area:";
            this.txtResArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTriangulo);
            this.groupBox1.Controls.Add(this.rdbTrapecio);
            this.groupBox1.Controls.Add(this.rdbPoligono);
            this.groupBox1.Controls.Add(this.rdbOvalo);
            this.groupBox1.Controls.Add(this.rdbRombo);
            this.groupBox1.Controls.Add(this.rdbRect);
            this.groupBox1.Controls.Add(this.rdbCirculo);
            this.groupBox1.Controls.Add(this.rdbCuadrado);
            this.groupBox1.Font = new System.Drawing.Font("Digital-7", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 137);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Figuras";
            // 
            // rdbCuadrado
            // 
            this.rdbCuadrado.AutoSize = true;
            this.rdbCuadrado.Location = new System.Drawing.Point(26, 33);
            this.rdbCuadrado.Name = "rdbCuadrado";
            this.rdbCuadrado.Size = new System.Drawing.Size(126, 27);
            this.rdbCuadrado.TabIndex = 0;
            this.rdbCuadrado.TabStop = true;
            this.rdbCuadrado.Text = "Cuadrado";
            this.rdbCuadrado.UseVisualStyleBackColor = true;
            this.rdbCuadrado.CheckedChanged += new System.EventHandler(this.FigurasTipo);
            // 
            // rdbCirculo
            // 
            this.rdbCirculo.AutoSize = true;
            this.rdbCirculo.Location = new System.Drawing.Point(158, 33);
            this.rdbCirculo.Name = "rdbCirculo";
            this.rdbCirculo.Size = new System.Drawing.Size(106, 27);
            this.rdbCirculo.TabIndex = 1;
            this.rdbCirculo.TabStop = true;
            this.rdbCirculo.Text = "Circulo";
            this.rdbCirculo.UseVisualStyleBackColor = true;
            this.rdbCirculo.CheckedChanged += new System.EventHandler(this.FigurasTipo);
            // 
            // rdbRect
            // 
            this.rdbRect.AutoSize = true;
            this.rdbRect.Location = new System.Drawing.Point(141, 84);
            this.rdbRect.Name = "rdbRect";
            this.rdbRect.Size = new System.Drawing.Size(149, 27);
            this.rdbRect.TabIndex = 2;
            this.rdbRect.TabStop = true;
            this.rdbRect.Text = "Rectangulo";
            this.rdbRect.UseVisualStyleBackColor = true;
            this.rdbRect.CheckedChanged += new System.EventHandler(this.FigurasTipo);
            // 
            // rdbRombo
            // 
            this.rdbRombo.AutoSize = true;
            this.rdbRombo.Location = new System.Drawing.Point(281, 33);
            this.rdbRombo.Name = "rdbRombo";
            this.rdbRombo.Size = new System.Drawing.Size(90, 27);
            this.rdbRombo.TabIndex = 3;
            this.rdbRombo.TabStop = true;
            this.rdbRombo.Text = "Rombo";
            this.rdbRombo.UseVisualStyleBackColor = true;
            this.rdbRombo.CheckedChanged += new System.EventHandler(this.FigurasTipo);
            // 
            // rdbOvalo
            // 
            this.rdbOvalo.AutoSize = true;
            this.rdbOvalo.Location = new System.Drawing.Point(26, 84);
            this.rdbOvalo.Name = "rdbOvalo";
            this.rdbOvalo.Size = new System.Drawing.Size(91, 27);
            this.rdbOvalo.TabIndex = 4;
            this.rdbOvalo.TabStop = true;
            this.rdbOvalo.Text = "Ovalo";
            this.rdbOvalo.UseVisualStyleBackColor = true;
            this.rdbOvalo.CheckedChanged += new System.EventHandler(this.FigurasTipo);
            // 
            // rdbPoligono
            // 
            this.rdbPoligono.AutoSize = true;
            this.rdbPoligono.Location = new System.Drawing.Point(306, 84);
            this.rdbPoligono.Name = "rdbPoligono";
            this.rdbPoligono.Size = new System.Drawing.Size(120, 27);
            this.rdbPoligono.TabIndex = 5;
            this.rdbPoligono.TabStop = true;
            this.rdbPoligono.Text = "Poligono";
            this.rdbPoligono.UseVisualStyleBackColor = true;
            this.rdbPoligono.CheckedChanged += new System.EventHandler(this.FigurasTipo);
            // 
            // lblDato1
            // 
            this.lblDato1.AutoSize = true;
            this.lblDato1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDato1.Location = new System.Drawing.Point(12, 269);
            this.lblDato1.Name = "lblDato1";
            this.lblDato1.Size = new System.Drawing.Size(75, 23);
            this.lblDato1.TabIndex = 4;
            this.lblDato1.Text = "Dato 1";
            // 
            // txtDato1
            // 
            this.txtDato1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDato1.Location = new System.Drawing.Point(93, 266);
            this.txtDato1.Name = "txtDato1";
            this.txtDato1.Size = new System.Drawing.Size(124, 31);
            this.txtDato1.TabIndex = 5;
            // 
            // rdbTrapecio
            // 
            this.rdbTrapecio.AutoSize = true;
            this.rdbTrapecio.Location = new System.Drawing.Point(391, 33);
            this.rdbTrapecio.Name = "rdbTrapecio";
            this.rdbTrapecio.Size = new System.Drawing.Size(118, 27);
            this.rdbTrapecio.TabIndex = 6;
            this.rdbTrapecio.TabStop = true;
            this.rdbTrapecio.Text = "Trapecio";
            this.rdbTrapecio.UseVisualStyleBackColor = true;
            this.rdbTrapecio.CheckedChanged += new System.EventHandler(this.FigurasTipo);
            // 
            // txtDato2
            // 
            this.txtDato2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDato2.Location = new System.Drawing.Point(311, 266);
            this.txtDato2.Name = "txtDato2";
            this.txtDato2.Size = new System.Drawing.Size(124, 31);
            this.txtDato2.TabIndex = 7;
            // 
            // lblDato2
            // 
            this.lblDato2.AutoSize = true;
            this.lblDato2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDato2.Location = new System.Drawing.Point(230, 269);
            this.lblDato2.Name = "lblDato2";
            this.lblDato2.Size = new System.Drawing.Size(75, 23);
            this.lblDato2.TabIndex = 6;
            this.lblDato2.Text = "Dato 2";
            // 
            // txtDato3
            // 
            this.txtDato3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDato3.Location = new System.Drawing.Point(93, 319);
            this.txtDato3.Name = "txtDato3";
            this.txtDato3.Size = new System.Drawing.Size(124, 31);
            this.txtDato3.TabIndex = 9;
            // 
            // lblDato3
            // 
            this.lblDato3.AutoSize = true;
            this.lblDato3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDato3.Location = new System.Drawing.Point(12, 322);
            this.lblDato3.Name = "lblDato3";
            this.lblDato3.Size = new System.Drawing.Size(75, 23);
            this.lblDato3.TabIndex = 8;
            this.lblDato3.Text = "Dato 3";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(256, 436);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(127, 33);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rdbTriangulo
            // 
            this.rdbTriangulo.AutoSize = true;
            this.rdbTriangulo.Location = new System.Drawing.Point(432, 84);
            this.rdbTriangulo.Name = "rdbTriangulo";
            this.rdbTriangulo.Size = new System.Drawing.Size(132, 27);
            this.rdbTriangulo.TabIndex = 7;
            this.rdbTriangulo.TabStop = true;
            this.rdbTriangulo.Text = "Triangulo";
            this.rdbTriangulo.UseVisualStyleBackColor = true;
            this.rdbTriangulo.CheckedChanged += new System.EventHandler(this.FigurasTipo);
            // 
            // txtResPerimetro
            // 
            this.txtResPerimetro.BackColor = System.Drawing.Color.DarkGreen;
            this.txtResPerimetro.Font = new System.Drawing.Font("Digital-7", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResPerimetro.ForeColor = System.Drawing.Color.White;
            this.txtResPerimetro.Location = new System.Drawing.Point(311, 12);
            this.txtResPerimetro.Name = "txtResPerimetro";
            this.txtResPerimetro.ReadOnly = true;
            this.txtResPerimetro.Size = new System.Drawing.Size(328, 54);
            this.txtResPerimetro.TabIndex = 12;
            this.txtResPerimetro.Text = "Perimetro:";
            this.txtResPerimetro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDato4
            // 
            this.txtDato4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDato4.Location = new System.Drawing.Point(311, 319);
            this.txtDato4.Name = "txtDato4";
            this.txtDato4.Size = new System.Drawing.Size(124, 31);
            this.txtDato4.TabIndex = 14;
            // 
            // lblDato4
            // 
            this.lblDato4.AutoSize = true;
            this.lblDato4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDato4.Location = new System.Drawing.Point(230, 322);
            this.lblDato4.Name = "lblDato4";
            this.lblDato4.Size = new System.Drawing.Size(75, 23);
            this.lblDato4.TabIndex = 13;
            this.lblDato4.Text = "Dato 4";
            // 
            // txtDato5
            // 
            this.txtDato5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDato5.Location = new System.Drawing.Point(93, 370);
            this.txtDato5.Name = "txtDato5";
            this.txtDato5.Size = new System.Drawing.Size(124, 31);
            this.txtDato5.TabIndex = 16;
            // 
            // lblDato5
            // 
            this.lblDato5.AutoSize = true;
            this.lblDato5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDato5.Location = new System.Drawing.Point(12, 373);
            this.lblDato5.Name = "lblDato5";
            this.lblDato5.Size = new System.Drawing.Size(75, 23);
            this.lblDato5.TabIndex = 15;
            this.lblDato5.Text = "Dato 5";
            // 
            // Figuras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 497);
            this.Controls.Add(this.txtDato5);
            this.Controls.Add(this.lblDato5);
            this.Controls.Add(this.txtDato4);
            this.Controls.Add(this.lblDato4);
            this.Controls.Add(this.txtResPerimetro);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDato3);
            this.Controls.Add(this.lblDato3);
            this.Controls.Add(this.txtDato2);
            this.Controls.Add(this.lblDato2);
            this.Controls.Add(this.txtDato1);
            this.Controls.Add(this.lblDato1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtResArea);
            this.Name = "Figuras";
            this.Text = "Figuras geometricas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResArea;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbOvalo;
        private System.Windows.Forms.RadioButton rdbRombo;
        private System.Windows.Forms.RadioButton rdbRect;
        private System.Windows.Forms.RadioButton rdbCirculo;
        private System.Windows.Forms.RadioButton rdbCuadrado;
        private System.Windows.Forms.RadioButton rdbTrapecio;
        private System.Windows.Forms.RadioButton rdbPoligono;
        private System.Windows.Forms.Label lblDato1;
        private System.Windows.Forms.TextBox txtDato1;
        private System.Windows.Forms.TextBox txtDato2;
        private System.Windows.Forms.Label lblDato2;
        private System.Windows.Forms.TextBox txtDato3;
        private System.Windows.Forms.Label lblDato3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton rdbTriangulo;
        private System.Windows.Forms.TextBox txtResPerimetro;
        private System.Windows.Forms.TextBox txtDato4;
        private System.Windows.Forms.Label lblDato4;
        private System.Windows.Forms.TextBox txtDato5;
        private System.Windows.Forms.Label lblDato5;
    }
}