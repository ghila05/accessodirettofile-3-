namespace accessodirettofile_2_
{
    partial class File_scraping
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1_ingresso = new System.Windows.Forms.TextBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1_ingresso
            // 
            this.textBox1_ingresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_ingresso.Location = new System.Drawing.Point(13, 40);
            this.textBox1_ingresso.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1_ingresso.Multiline = true;
            this.textBox1_ingresso.Name = "textBox1_ingresso";
            this.textBox1_ingresso.Size = new System.Drawing.Size(275, 50);
            this.textBox1_ingresso.TabIndex = 2;
            this.textBox1_ingresso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.Location = new System.Drawing.Point(12, 111);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(80, 29);
            this.label_nome.TabIndex = 3;
            this.label_nome.Text = "nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inserisci un comune per trovare una locanda/bar/ristorante associato";
            // 
            // File_scraping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 189);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.textBox1_ingresso);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "File_scraping";
            this.Text = "File_scraping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1_ingresso;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.Label label1;
    }
}

