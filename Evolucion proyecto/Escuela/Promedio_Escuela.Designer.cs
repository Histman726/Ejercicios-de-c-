namespace Escuela
{
    partial class Promedio_Escuela
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPromedioSalones = new System.Windows.Forms.Label();
            this.btnPromediar2 = new System.Windows.Forms.Button();
            this.lblPromedioAlumnos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlumnos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalones = new System.Windows.Forms.Button();
            this.lblPromedios = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblPromedios);
            this.splitContainer1.Panel1.Controls.Add(this.btnSalones);
            this.splitContainer1.Panel1.Controls.Add(this.lblPromedioSalones);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtSalones);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnRegresar);
            this.splitContainer1.Panel2.Controls.Add(this.btnAgregar);
            this.splitContainer1.Panel2.Controls.Add(this.btnPromediar2);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.lblPromedioAlumnos);
            this.splitContainer1.Panel2.Controls.Add(this.txtAlumnos);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Size = new System.Drawing.Size(1152, 287);
            this.splitContainer1.SplitterDistance = 525;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salones a promediar";
            // 
            // txtSalones
            // 
            this.txtSalones.Location = new System.Drawing.Point(235, 32);
            this.txtSalones.Name = "txtSalones";
            this.txtSalones.ReadOnly = true;
            this.txtSalones.Size = new System.Drawing.Size(193, 22);
            this.txtSalones.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Promedio Salones";
            // 
            // lblPromedioSalones
            // 
            this.lblPromedioSalones.AutoSize = true;
            this.lblPromedioSalones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioSalones.Location = new System.Drawing.Point(215, 109);
            this.lblPromedioSalones.Name = "lblPromedioSalones";
            this.lblPromedioSalones.Size = new System.Drawing.Size(23, 25);
            this.lblPromedioSalones.TabIndex = 3;
            this.lblPromedioSalones.Text = "0";
            // 
            // btnPromediar2
            // 
            this.btnPromediar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromediar2.Location = new System.Drawing.Point(486, 21);
            this.btnPromediar2.Name = "btnPromediar2";
            this.btnPromediar2.Size = new System.Drawing.Size(125, 39);
            this.btnPromediar2.TabIndex = 9;
            this.btnPromediar2.Text = "Promediar";
            this.btnPromediar2.UseVisualStyleBackColor = true;
            this.btnPromediar2.Click += new System.EventHandler(this.btnPromediar2_Click);
            // 
            // lblPromedioAlumnos
            // 
            this.lblPromedioAlumnos.AutoSize = true;
            this.lblPromedioAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioAlumnos.Location = new System.Drawing.Point(234, 109);
            this.lblPromedioAlumnos.Name = "lblPromedioAlumnos";
            this.lblPromedioAlumnos.Size = new System.Drawing.Size(23, 25);
            this.lblPromedioAlumnos.TabIndex = 8;
            this.lblPromedioAlumnos.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Promedio Alumnos";
            // 
            // txtAlumnos
            // 
            this.txtAlumnos.Location = new System.Drawing.Point(254, 32);
            this.txtAlumnos.Name = "txtAlumnos";
            this.txtAlumnos.Size = new System.Drawing.Size(193, 22);
            this.txtAlumnos.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Alumnos a promediar";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(486, 72);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 39);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalones
            // 
            this.btnSalones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalones.Location = new System.Drawing.Point(327, 81);
            this.btnSalones.Name = "btnSalones";
            this.btnSalones.Size = new System.Drawing.Size(171, 62);
            this.btnSalones.TabIndex = 11;
            this.btnSalones.Text = "Promediar Escuela";
            this.btnSalones.UseVisualStyleBackColor = true;
            this.btnSalones.Click += new System.EventHandler(this.btnSalones_Click);
            // 
            // lblPromedios
            // 
            this.lblPromedios.AutoSize = true;
            this.lblPromedios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedios.Location = new System.Drawing.Point(12, 172);
            this.lblPromedios.Name = "lblPromedios";
            this.lblPromedios.Size = new System.Drawing.Size(105, 25);
            this.lblPromedios.TabIndex = 12;
            this.lblPromedios.Text = "Promedios";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(411, 222);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(115, 35);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Promedio_Escuela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 287);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Promedio_Escuela";
            this.Text = "Promedio Escuela";
            this.Load += new System.EventHandler(this.Promedio_Escuela_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblPromedioSalones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPromediar2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPromedioAlumnos;
        private System.Windows.Forms.TextBox txtAlumnos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalones;
        private System.Windows.Forms.Label lblPromedios;
        private System.Windows.Forms.Button btnRegresar;
    }
}