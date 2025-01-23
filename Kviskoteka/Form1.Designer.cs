namespace Kviskoteka
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
            this.btnMojBroj = new System.Windows.Forms.Button();
            this.btnKvizomanija = new System.Windows.Forms.Button();
            this.btnBrziSimboli = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMojBroj
            // 
            this.btnMojBroj.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMojBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMojBroj.Location = new System.Drawing.Point(103, 233);
            this.btnMojBroj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMojBroj.Name = "btnMojBroj";
            this.btnMojBroj.Size = new System.Drawing.Size(160, 57);
            this.btnMojBroj.TabIndex = 0;
            this.btnMojBroj.Text = "Мој број";
            this.btnMojBroj.UseVisualStyleBackColor = false;
            this.btnMojBroj.Click += new System.EventHandler(this.btnMojBroj_Click);
            // 
            // btnKvizomanija
            // 
            this.btnKvizomanija.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnKvizomanija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnKvizomanija.Location = new System.Drawing.Point(357, 233);
            this.btnKvizomanija.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKvizomanija.Name = "btnKvizomanija";
            this.btnKvizomanija.Size = new System.Drawing.Size(160, 57);
            this.btnKvizomanija.TabIndex = 1;
            this.btnKvizomanija.Text = "Квизоманија";
            this.btnKvizomanija.UseVisualStyleBackColor = false;
            this.btnKvizomanija.Click += new System.EventHandler(this.btnKvizomanija_Click);
            // 
            // btnBrziSimboli
            // 
            this.btnBrziSimboli.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBrziSimboli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBrziSimboli.Location = new System.Drawing.Point(620, 233);
            this.btnBrziSimboli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrziSimboli.Name = "btnBrziSimboli";
            this.btnBrziSimboli.Size = new System.Drawing.Size(160, 57);
            this.btnBrziSimboli.TabIndex = 2;
            this.btnBrziSimboli.Text = "Брзи симболи";
            this.btnBrziSimboli.UseVisualStyleBackColor = false;
            this.btnBrziSimboli.Click += new System.EventHandler(this.btnBrziSimboli_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 50.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(199, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 104);
            this.label1.TabIndex = 3;
            this.label1.Text = "Квискотека";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(928, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrziSimboli);
            this.Controls.Add(this.btnKvizomanija);
            this.Controls.Add(this.btnMojBroj);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Квискотека";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMojBroj;
        private System.Windows.Forms.Button btnKvizomanija;
        private System.Windows.Forms.Button btnBrziSimboli;
        private System.Windows.Forms.Label label1;
    }
}

