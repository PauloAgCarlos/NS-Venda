namespace NS_Venda
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
            this.gradientPanel1 = new NS_Venda.GradientPanel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.labelPronto = new System.Windows.Forms.Label();
            this.labelAcertarHora = new System.Windows.Forms.Label();
            this.labelHoje = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gradientPanel1.Controls.Add(this.btnEntrar);
            this.gradientPanel1.Controls.Add(this.labelPronto);
            this.gradientPanel1.Controls.Add(this.labelAcertarHora);
            this.gradientPanel1.Controls.Add(this.labelHoje);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.dateTimePicker1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(886, 497);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.Click += new System.EventHandler(this.gradientPanel1_Click);
            this.gradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(378, 252);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(180, 58);
            this.btnEntrar.TabIndex = 9;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelPronto
            // 
            this.labelPronto.AutoSize = true;
            this.labelPronto.BackColor = System.Drawing.Color.Transparent;
            this.labelPronto.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPronto.ForeColor = System.Drawing.Color.Lime;
            this.labelPronto.Location = new System.Drawing.Point(356, 337);
            this.labelPronto.Name = "labelPronto";
            this.labelPronto.Size = new System.Drawing.Size(226, 19);
            this.labelPronto.TabIndex = 8;
            this.labelPronto.Text = "Tudo pronto, podes entrar";
            // 
            // labelAcertarHora
            // 
            this.labelAcertarHora.AutoSize = true;
            this.labelAcertarHora.BackColor = System.Drawing.Color.Transparent;
            this.labelAcertarHora.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcertarHora.ForeColor = System.Drawing.Color.Maroon;
            this.labelAcertarHora.Location = new System.Drawing.Point(287, 359);
            this.labelAcertarHora.Name = "labelAcertarHora";
            this.labelAcertarHora.Size = new System.Drawing.Size(356, 19);
            this.labelAcertarHora.TabIndex = 7;
            this.labelAcertarHora.Text = "Por favor, acerte a data do teu computador";
            this.labelAcertarHora.Visible = false;
            // 
            // labelHoje
            // 
            this.labelHoje.AutoSize = true;
            this.labelHoje.BackColor = System.Drawing.Color.Transparent;
            this.labelHoje.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHoje.Location = new System.Drawing.Point(729, 464);
            this.labelHoje.Name = "labelHoje";
            this.labelHoje.Size = new System.Drawing.Size(62, 24);
            this.labelHoje.TabIndex = 5;
            this.labelHoje.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(806, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 43);
            this.label4.TabIndex = 4;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "By: Programador Amador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(313, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistema de Gestão de Vendas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(244, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "NS-SOFTWARE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(674, 432);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2020, 12, 4, 0, 0, 0, 0);
            this.dateTimePicker1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 497);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelHoje;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelAcertarHora;
        private System.Windows.Forms.Label labelPronto;
        private System.Windows.Forms.Button btnEntrar;
    }
}

