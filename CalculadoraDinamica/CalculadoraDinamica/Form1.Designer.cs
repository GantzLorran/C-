namespace CalculadoraDinamica
{
    partial class Form1
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
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btsoma = new System.Windows.Forms.Button();
            this.btsub = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.btmult = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.btdiv = new System.Windows.Forms.Button();
            this.btresult = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(1, 230);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(108, 29);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.gerarnumero);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(115, 230);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(108, 29);
            this.bt2.TabIndex = 1;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.gerarnumero);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(229, 230);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(108, 29);
            this.bt3.TabIndex = 2;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.gerarnumero);
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(1, 126);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(373, 20);
            this.txtresultado.TabIndex = 17;
            this.txtresultado.TextChanged += new System.EventHandler(this.txtresultado_TextChanged);
            // 
            // btsoma
            // 
            this.btsoma.Location = new System.Drawing.Point(343, 160);
            this.btsoma.Name = "btsoma";
            this.btsoma.Size = new System.Drawing.Size(31, 29);
            this.btsoma.TabIndex = 4;
            this.btsoma.Text = "+";
            this.btsoma.UseVisualStyleBackColor = true;
            this.btsoma.Click += new System.EventHandler(this.operadores);
            // 
            // btsub
            // 
            this.btsub.Location = new System.Drawing.Point(343, 195);
            this.btsub.Name = "btsub";
            this.btsub.Size = new System.Drawing.Size(31, 29);
            this.btsub.TabIndex = 8;
            this.btsub.Text = "-";
            this.btsub.UseVisualStyleBackColor = true;
            this.btsub.Click += new System.EventHandler(this.operadores);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(229, 195);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(108, 29);
            this.bt6.TabIndex = 7;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.gerarnumero);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(115, 195);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(108, 29);
            this.bt5.TabIndex = 6;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.gerarnumero);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(1, 195);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(108, 29);
            this.bt4.TabIndex = 5;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.gerarnumero);
            // 
            // btmult
            // 
            this.btmult.Location = new System.Drawing.Point(343, 230);
            this.btmult.Name = "btmult";
            this.btmult.Size = new System.Drawing.Size(31, 29);
            this.btmult.TabIndex = 12;
            this.btmult.Text = "*";
            this.btmult.UseVisualStyleBackColor = true;
            this.btmult.Click += new System.EventHandler(this.operadores);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(229, 160);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(108, 29);
            this.bt9.TabIndex = 11;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.gerarnumero);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(115, 160);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(108, 29);
            this.bt8.TabIndex = 10;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.gerarnumero);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(1, 160);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(108, 29);
            this.bt7.TabIndex = 9;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.gerarnumero);
            // 
            // btdiv
            // 
            this.btdiv.Location = new System.Drawing.Point(343, 265);
            this.btdiv.Name = "btdiv";
            this.btdiv.Size = new System.Drawing.Size(31, 29);
            this.btdiv.TabIndex = 16;
            this.btdiv.Text = "/";
            this.btdiv.UseVisualStyleBackColor = true;
            this.btdiv.Click += new System.EventHandler(this.operadores);
            // 
            // btresult
            // 
            this.btresult.Location = new System.Drawing.Point(229, 265);
            this.btresult.Name = "btresult";
            this.btresult.Size = new System.Drawing.Size(108, 29);
            this.btresult.TabIndex = 15;
            this.btresult.Text = "=";
            this.btresult.UseVisualStyleBackColor = true;
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(115, 265);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(108, 29);
            this.bt0.TabIndex = 14;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.gerarnumero);
            // 
            // btlimpar
            // 
            this.btlimpar.Location = new System.Drawing.Point(1, 265);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(108, 29);
            this.btlimpar.TabIndex = 13;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 353);
            this.Controls.Add(this.btdiv);
            this.Controls.Add(this.btresult);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btmult);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.btsub);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.btsoma);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btsoma;
        private System.Windows.Forms.Button btsub;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button btmult;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button btdiv;
        private System.Windows.Forms.Button btresult;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btlimpar;
    }
}

