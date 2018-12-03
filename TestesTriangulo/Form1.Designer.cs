namespace TestesTriangulo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxLado1 = new System.Windows.Forms.TextBox();
            this.lblLado1 = new System.Windows.Forms.Label();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.tbxLado2 = new System.Windows.Forms.TextBox();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.tbxLado3 = new System.Windows.Forms.TextBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxLado1
            // 
            this.tbxLado1.Location = new System.Drawing.Point(77, 42);
            this.tbxLado1.Name = "tbxLado1";
            this.tbxLado1.Size = new System.Drawing.Size(100, 20);
            this.tbxLado1.TabIndex = 0;
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado1.Location = new System.Drawing.Point(12, 49);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(46, 13);
            this.lblLado1.TabIndex = 1;
            this.lblLado1.Text = "Lado 1";
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado2.Location = new System.Drawing.Point(12, 75);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(46, 13);
            this.lblLado2.TabIndex = 3;
            this.lblLado2.Text = "Lado 2";
            // 
            // tbxLado2
            // 
            this.tbxLado2.Location = new System.Drawing.Point(77, 68);
            this.tbxLado2.Name = "tbxLado2";
            this.tbxLado2.Size = new System.Drawing.Size(100, 20);
            this.tbxLado2.TabIndex = 2;
            // 
            // lblLado3
            // 
            this.lblLado3.AutoSize = true;
            this.lblLado3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado3.Location = new System.Drawing.Point(12, 101);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(46, 13);
            this.lblLado3.TabIndex = 5;
            this.lblLado3.Text = "Lado 3";
            // 
            // tbxLado3
            // 
            this.tbxLado3.Location = new System.Drawing.Point(77, 94);
            this.tbxLado3.Name = "tbxLado3";
            this.tbxLado3.Size = new System.Drawing.Size(100, 20);
            this.tbxLado3.TabIndex = 4;
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(77, 226);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(100, 23);
            this.btnCalcula.TabIndex = 6;
            this.btnCalcula.Text = "Calcula";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Red;
            this.lblResultado.Location = new System.Drawing.Point(77, 154);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(19, 13);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.lblLado3);
            this.Controls.Add(this.tbxLado3);
            this.Controls.Add(this.lblLado2);
            this.Controls.Add(this.tbxLado2);
            this.Controls.Add(this.lblLado1);
            this.Controls.Add(this.tbxLado1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxLado1;
        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.TextBox tbxLado2;
        private System.Windows.Forms.Label lblLado3;
        private System.Windows.Forms.TextBox tbxLado3;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Label lblResultado;
    }
}

