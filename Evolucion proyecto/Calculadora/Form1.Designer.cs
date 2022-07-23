namespace Calculadora
{
    partial class frmBasica
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBasica));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.basicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figurasGeometricasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figurasGeometricas3DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.btnBorrarParte = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnBorrarChar = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicaToolStripMenuItem,
            this.figurasGeometricasToolStripMenuItem,
            this.figurasGeometricas3DToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(581, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // basicaToolStripMenuItem
            // 
            this.basicaToolStripMenuItem.Name = "basicaToolStripMenuItem";
            this.basicaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.basicaToolStripMenuItem.Text = "Basica";
            // 
            // figurasGeometricasToolStripMenuItem
            // 
            this.figurasGeometricasToolStripMenuItem.Name = "figurasGeometricasToolStripMenuItem";
            this.figurasGeometricasToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.figurasGeometricasToolStripMenuItem.Text = "Figuras geometricas";
            // 
            // figurasGeometricas3DToolStripMenuItem
            // 
            this.figurasGeometricas3DToolStripMenuItem.Name = "figurasGeometricas3DToolStripMenuItem";
            this.figurasGeometricas3DToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.figurasGeometricas3DToolStripMenuItem.Text = "Figuras geometricas 3D";
            // 
            // txtRes
            // 
            this.txtRes.BackColor = System.Drawing.Color.DarkGreen;
            this.txtRes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRes.Font = new System.Drawing.Font("Digital-7", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRes.ForeColor = System.Drawing.Color.White;
            this.txtRes.Location = new System.Drawing.Point(28, 31);
            this.txtRes.Name = "txtRes";
            this.txtRes.ReadOnly = true;
            this.txtRes.Size = new System.Drawing.Size(531, 54);
            this.txtRes.TabIndex = 1;
            this.txtRes.Text = "0";
            this.txtRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBorrarParte
            // 
            this.btnBorrarParte.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBorrarParte.Location = new System.Drawing.Point(31, 101);
            this.btnBorrarParte.Name = "btnBorrarParte";
            this.btnBorrarParte.Size = new System.Drawing.Size(91, 107);
            this.btnBorrarParte.TabIndex = 2;
            this.btnBorrarParte.Text = "CE";
            this.btnBorrarParte.UseVisualStyleBackColor = true;
            this.btnBorrarParte.Click += new System.EventHandler(this.btnBorrarParte_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBorrarTodo.Location = new System.Drawing.Point(167, 101);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(91, 107);
            this.btnBorrarTodo.TabIndex = 3;
            this.btnBorrarTodo.Text = "C";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // btnBorrarChar
            // 
            this.btnBorrarChar.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrarChar.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBorrarChar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrarChar.Image")));
            this.btnBorrarChar.Location = new System.Drawing.Point(303, 101);
            this.btnBorrarChar.Name = "btnBorrarChar";
            this.btnBorrarChar.Size = new System.Drawing.Size(124, 107);
            this.btnBorrarChar.TabIndex = 4;
            this.btnBorrarChar.UseVisualStyleBackColor = false;
            this.btnBorrarChar.Click += new System.EventHandler(this.btnBorrarChar_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDiv.Location = new System.Drawing.Point(468, 101);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(91, 107);
            this.btnDiv.TabIndex = 5;
            this.btnDiv.Text = "÷";
            this.btnDiv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMulti.Location = new System.Drawing.Point(468, 228);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(91, 107);
            this.btnMulti.TabIndex = 9;
            this.btnMulti.Text = "x";
            this.btnMulti.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Transparent;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(303, 228);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(124, 107);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(167, 228);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(91, 107);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(31, 228);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(91, 107);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResta.Location = new System.Drawing.Point(468, 363);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(91, 107);
            this.btnResta.TabIndex = 13;
            this.btnResta.Text = "-";
            this.btnResta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Transparent;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(303, 363);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(124, 107);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(167, 363);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(91, 107);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(31, 363);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(91, 107);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSuma.Location = new System.Drawing.Point(468, 502);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(91, 107);
            this.btnSuma.TabIndex = 17;
            this.btnSuma.Text = "+";
            this.btnSuma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(303, 502);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(124, 107);
            this.btn3.TabIndex = 16;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(167, 502);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(91, 107);
            this.btn2.TabIndex = 15;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(31, 502);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(91, 107);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnRes
            // 
            this.btnRes.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRes.Location = new System.Drawing.Point(35, 638);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(223, 81);
            this.btnRes.TabIndex = 18;
            this.btnRes.Text = "=";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.button13_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPunto.Location = new System.Drawing.Point(467, 638);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(92, 81);
            this.btnPunto.TabIndex = 19;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(295, 643);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(132, 76);
            this.btn0.TabIndex = 20;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // frmBasica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 731);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnBorrarChar);
            this.Controls.Add(this.btnBorrarTodo);
            this.Controls.Add(this.btnBorrarParte);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBasica";
            this.Text = "Calculadora Basica";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem basicaToolStripMenuItem;
        private ToolStripMenuItem figurasGeometricasToolStripMenuItem;
        private ToolStripMenuItem figurasGeometricas3DToolStripMenuItem;
        private TextBox txtRes;
        private Button btnBorrarParte;
        private Button btnBorrarTodo;
        private Button btnBorrarChar;
        private Button btnDiv;
        private Button btnMulti;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnResta;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnSuma;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnRes;
        private Button btnPunto;
        private Button btn0;
    }
}