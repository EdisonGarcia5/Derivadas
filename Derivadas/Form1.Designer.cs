namespace Derivadas
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtExtremoInferior = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExtremoSuperior = new System.Windows.Forms.TextBox();
            this.txtNumRectangulos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(357, 110);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(44, 16);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "label1";
            // 
            // txtExtremoInferior
            // 
            this.txtExtremoInferior.Location = new System.Drawing.Point(220, 104);
            this.txtExtremoInferior.Name = "txtExtremoInferior";
            this.txtExtremoInferior.Size = new System.Drawing.Size(100, 22);
            this.txtExtremoInferior.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingresar valores ";
            // 
            // txtExtremoSuperior
            // 
            this.txtExtremoSuperior.Location = new System.Drawing.Point(220, 156);
            this.txtExtremoSuperior.Name = "txtExtremoSuperior";
            this.txtExtremoSuperior.Size = new System.Drawing.Size(100, 22);
            this.txtExtremoSuperior.TabIndex = 5;
            // 
            // txtNumRectangulos
            // 
            this.txtNumRectangulos.Location = new System.Drawing.Point(220, 214);
            this.txtNumRectangulos.Name = "txtNumRectangulos";
            this.txtNumRectangulos.Size = new System.Drawing.Size(100, 22);
            this.txtNumRectangulos.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Extremo Inferior";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numero de Rectangulos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Extremo Superior";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumRectangulos);
            this.Controls.Add(this.txtExtremoSuperior);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtExtremoInferior);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtExtremoInferior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExtremoSuperior;
        private System.Windows.Forms.TextBox txtNumRectangulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

