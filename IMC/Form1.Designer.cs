namespace IMC
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
            this.Label1Peso1 = new System.Windows.Forms.Label();
            this.label2Altura = new System.Windows.Forms.Label();
            this.label3IMC = new System.Windows.Forms.Label();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.textBoxIMC = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.pictureBoxIMC = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIMC)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1Peso1
            // 
            this.Label1Peso1.AutoSize = true;
            this.Label1Peso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1Peso1.Location = new System.Drawing.Point(33, 24);
            this.Label1Peso1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1Peso1.Name = "Label1Peso1";
            this.Label1Peso1.Size = new System.Drawing.Size(92, 39);
            this.Label1Peso1.TabIndex = 0;
            this.Label1Peso1.Text = "peso";
            this.Label1Peso1.Click += new System.EventHandler(this.Peso_Click);
            // 
            // label2Altura
            // 
            this.label2Altura.AutoSize = true;
            this.label2Altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Altura.Location = new System.Drawing.Point(33, 72);
            this.label2Altura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2Altura.Name = "label2Altura";
            this.label2Altura.Size = new System.Drawing.Size(104, 39);
            this.label2Altura.TabIndex = 1;
            this.label2Altura.Text = "altura";
            this.label2Altura.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3IMC
            // 
            this.label3IMC.AutoSize = true;
            this.label3IMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3IMC.Location = new System.Drawing.Point(33, 206);
            this.label3IMC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3IMC.Name = "label3IMC";
            this.label3IMC.Size = new System.Drawing.Size(80, 39);
            this.label3IMC.TabIndex = 2;
            this.label3IMC.Text = "IMC";
            this.label3IMC.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPeso.Location = new System.Drawing.Point(166, 20);
            this.textBoxPeso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(93, 47);
            this.textBoxPeso.TabIndex = 3;
            this.textBoxPeso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAltura.Location = new System.Drawing.Point(166, 72);
            this.textBoxAltura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(93, 47);
            this.textBoxAltura.TabIndex = 4;
            this.textBoxAltura.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxIMC
            // 
            this.textBoxIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIMC.Location = new System.Drawing.Point(166, 202);
            this.textBoxIMC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIMC.Name = "textBoxIMC";
            this.textBoxIMC.Size = new System.Drawing.Size(93, 47);
            this.textBoxIMC.TabIndex = 5;
            this.textBoxIMC.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.Location = new System.Drawing.Point(40, 139);
            this.buttonCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(134, 42);
            this.buttonCalcular.TabIndex = 6;
            this.buttonCalcular.Text = "calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.calcular);
            // 
            // pictureBoxIMC
            // 
            this.pictureBoxIMC.Location = new System.Drawing.Point(294, 20);
            this.pictureBoxIMC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxIMC.Name = "pictureBoxIMC";
            this.pictureBoxIMC.Size = new System.Drawing.Size(309, 291);
            this.pictureBoxIMC.TabIndex = 7;
            this.pictureBoxIMC.TabStop = false;
            this.pictureBoxIMC.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 332);
            this.Controls.Add(this.pictureBoxIMC);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxIMC);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.label3IMC);
            this.Controls.Add(this.label2Altura);
            this.Controls.Add(this.Label1Peso1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIMC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1Peso1;
        private System.Windows.Forms.Label label2Altura;
        private System.Windows.Forms.Label label3IMC;
        private System.Windows.Forms.TextBox textBoxPeso;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.TextBox textBoxIMC;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.PictureBox pictureBoxIMC;
    }
}

