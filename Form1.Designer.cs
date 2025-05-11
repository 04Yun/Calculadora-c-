namespace Hellokittycalculator
{
    partial class Form1
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
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.bsuma = new System.Windows.Forms.Button();
            this.bnresta = new System.Windows.Forms.Button();
            this.btnmultiplicacion = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnpunto = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDisplay
            // 
            this.tbDisplay.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDisplay.ForeColor = System.Drawing.Color.DimGray;
            this.tbDisplay.Location = new System.Drawing.Point(12, 12);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbDisplay.Size = new System.Drawing.Size(240, 70);
            this.tbDisplay.TabIndex = 0;
            this.tbDisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bsuma
            // 
            this.bsuma.BackColor = System.Drawing.Color.Pink;
            this.bsuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsuma.Location = new System.Drawing.Point(12, 88);
            this.bsuma.Name = "bsuma";
            this.bsuma.Size = new System.Drawing.Size(65, 57);
            this.bsuma.TabIndex = 1;
            this.bsuma.Text = "+";
            this.bsuma.UseVisualStyleBackColor = false;
            this.bsuma.Click += new System.EventHandler(this.bsuma_Click);
            // 
            // bnresta
            // 
            this.bnresta.BackColor = System.Drawing.Color.Pink;
            this.bnresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnresta.Location = new System.Drawing.Point(95, 88);
            this.bnresta.Name = "bnresta";
            this.bnresta.Size = new System.Drawing.Size(67, 57);
            this.bnresta.TabIndex = 2;
            this.bnresta.Text = "-";
            this.bnresta.UseVisualStyleBackColor = false;
            this.bnresta.Click += new System.EventHandler(this.bnresta_Click);
            // 
            // btnmultiplicacion
            // 
            this.btnmultiplicacion.BackColor = System.Drawing.Color.Pink;
            this.btnmultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiplicacion.Location = new System.Drawing.Point(178, 88);
            this.btnmultiplicacion.Name = "btnmultiplicacion";
            this.btnmultiplicacion.Size = new System.Drawing.Size(74, 57);
            this.btnmultiplicacion.TabIndex = 3;
            this.btnmultiplicacion.Text = "x";
            this.btnmultiplicacion.UseVisualStyleBackColor = false;
            this.btnmultiplicacion.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Thistle;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 151);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(95, 68);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnigual
            // 
            this.btnigual.BackColor = System.Drawing.Color.Pink;
            this.btnigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnigual.Location = new System.Drawing.Point(234, 396);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(95, 68);
            this.btnigual.TabIndex = 15;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = false;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Thistle;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(234, 151);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(95, 68);
            this.btn9.TabIndex = 6;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Thistle;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 225);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(95, 68);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Thistle;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(124, 225);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(95, 68);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Thistle;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(234, 225);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(95, 68);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.button9_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Thistle;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 310);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(95, 68);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.button10_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Thistle;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(124, 310);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(95, 68);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.button11_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Thistle;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(234, 310);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(95, 68);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnpunto
            // 
            this.btnpunto.BackColor = System.Drawing.Color.Pink;
            this.btnpunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpunto.Location = new System.Drawing.Point(12, 396);
            this.btnpunto.Name = "btnpunto";
            this.btnpunto.Size = new System.Drawing.Size(95, 68);
            this.btnpunto.TabIndex = 13;
            this.btnpunto.Text = ".";
            this.btnpunto.UseVisualStyleBackColor = false;
            this.btnpunto.Click += new System.EventHandler(this.btnpunto_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Thistle;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(124, 396);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(95, 68);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Thistle;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(124, 151);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(95, 68);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btndivision
            // 
            this.btndivision.BackColor = System.Drawing.Color.Pink;
            this.btndivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivision.Location = new System.Drawing.Point(260, 66);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(70, 65);
            this.btndivision.TabIndex = 16;
            this.btndivision.Text = "/";
            this.btndivision.UseVisualStyleBackColor = false;
            this.btndivision.Click += new System.EventHandler(this.button16_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(259, 12);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(71, 48);
            this.btnlimpiar.TabIndex = 17;
            this.btnlimpiar.Text = "C";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(342, 491);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btndivision);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnpunto);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnmultiplicacion);
            this.Controls.Add(this.bnresta);
            this.Controls.Add(this.bsuma);
            this.Controls.Add(this.tbDisplay);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button bsuma;
        private System.Windows.Forms.Button bnresta;
        private System.Windows.Forms.Button btnmultiplicacion;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnpunto;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btndivision;
        private System.Windows.Forms.Button btnlimpiar;
    }
}

