namespace Escuela
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.sacarPromedioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unSalonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escuelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reinscripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEscuelas = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sacarPromedioToolStripMenuItem,
            this.inscripcionesToolStripMenuItem,
            this.reinscripcionesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1200, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "Menu";
            // 
            // sacarPromedioToolStripMenuItem
            // 
            this.sacarPromedioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salonesToolStripMenuItem,
            this.unSalonToolStripMenuItem,
            this.escuelaToolStripMenuItem});
            this.sacarPromedioToolStripMenuItem.Name = "sacarPromedioToolStripMenuItem";
            this.sacarPromedioToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.sacarPromedioToolStripMenuItem.Text = "Sacar promedio";
            // 
            // salonesToolStripMenuItem
            // 
            this.salonesToolStripMenuItem.Name = "salonesToolStripMenuItem";
            this.salonesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salonesToolStripMenuItem.Text = "Salones";
            this.salonesToolStripMenuItem.Click += new System.EventHandler(this.salonesToolStripMenuItem_Click);
            // 
            // unSalonToolStripMenuItem
            // 
            this.unSalonToolStripMenuItem.Name = "unSalonToolStripMenuItem";
            this.unSalonToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.unSalonToolStripMenuItem.Text = "Un salon";
            this.unSalonToolStripMenuItem.Click += new System.EventHandler(this.unSalonToolStripMenuItem_Click);
            // 
            // escuelaToolStripMenuItem
            // 
            this.escuelaToolStripMenuItem.Name = "escuelaToolStripMenuItem";
            this.escuelaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.escuelaToolStripMenuItem.Text = "Escuela";
            this.escuelaToolStripMenuItem.Click += new System.EventHandler(this.escuelaToolStripMenuItem_Click);
            // 
            // inscripcionesToolStripMenuItem
            // 
            this.inscripcionesToolStripMenuItem.Name = "inscripcionesToolStripMenuItem";
            this.inscripcionesToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.inscripcionesToolStripMenuItem.Text = "Inscripciones";
            this.inscripcionesToolStripMenuItem.Click += new System.EventHandler(this.inscripcionesToolStripMenuItem_Click);
            // 
            // reinscripcionesToolStripMenuItem
            // 
            this.reinscripcionesToolStripMenuItem.Name = "reinscripcionesToolStripMenuItem";
            this.reinscripcionesToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.reinscripcionesToolStripMenuItem.Text = "Reinscripciones";
            this.reinscripcionesToolStripMenuItem.Click += new System.EventHandler(this.reinscripcionesToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(546, 377);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(608, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escuela Nacional para niños";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(616, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(476, 328);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(526, 82);
            this.label2.TabIndex = 4;
            this.label2.Text = "Elige la mejor escuela para tus hijos \r\ncon nosotros";
            // 
            // btnEscuelas
            // 
            this.btnEscuelas.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscuelas.Location = new System.Drawing.Point(719, 504);
            this.btnEscuelas.Name = "btnEscuelas";
            this.btnEscuelas.Size = new System.Drawing.Size(285, 71);
            this.btnEscuelas.TabIndex = 5;
            this.btnEscuelas.Text = "Buscar";
            this.btnEscuelas.UseVisualStyleBackColor = true;
            this.btnEscuelas.Click += new System.EventHandler(this.btnEscuelas_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 654);
            this.Controls.Add(this.btnEscuelas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem sacarPromedioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unSalonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escuelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reinscripcionesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEscuelas;
    }
}

