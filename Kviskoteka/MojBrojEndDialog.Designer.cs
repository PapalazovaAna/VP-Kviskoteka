namespace Kviskoteka
{
    partial class MojBrojEndDialog
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
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblYourFormula = new System.Windows.Forms.Label();
            this.lblYourResult = new System.Windows.Forms.Label();
            this.lblTrueResult = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAnswer.Location = new System.Drawing.Point(12, 9);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(46, 17);
            this.lblAnswer.TabIndex = 0;
            this.lblAnswer.Text = "label1";
            // 
            // lblYourFormula
            // 
            this.lblYourFormula.AutoSize = true;
            this.lblYourFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblYourFormula.Location = new System.Drawing.Point(12, 31);
            this.lblYourFormula.Name = "lblYourFormula";
            this.lblYourFormula.Size = new System.Drawing.Size(109, 15);
            this.lblYourFormula.TabIndex = 1;
            this.lblYourFormula.Text = "Вашето решение:";
            // 
            // lblYourResult
            // 
            this.lblYourResult.AutoSize = true;
            this.lblYourResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblYourResult.Location = new System.Drawing.Point(16, 75);
            this.lblYourResult.Name = "lblYourResult";
            this.lblYourResult.Size = new System.Drawing.Size(111, 15);
            this.lblYourResult.TabIndex = 2;
            this.lblYourResult.Text = "Вашиот резултат:";
            // 
            // lblTrueResult
            // 
            this.lblTrueResult.AutoSize = true;
            this.lblTrueResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTrueResult.Location = new System.Drawing.Point(16, 122);
            this.lblTrueResult.Name = "lblTrueResult";
            this.lblTrueResult.Size = new System.Drawing.Size(110, 15);
            this.lblTrueResult.TabIndex = 3;
            this.lblTrueResult.Text = "Нашето решение:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(16, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дали сакате да играте повторно?";
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNewGame.Location = new System.Drawing.Point(28, 208);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 30);
            this.btnNewGame.TabIndex = 5;
            this.btnNewGame.Text = "Да";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.Location = new System.Drawing.Point(128, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Не";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MojBrojEndDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(247, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTrueResult);
            this.Controls.Add(this.lblYourResult);
            this.Controls.Add(this.lblYourFormula);
            this.Controls.Add(this.lblAnswer);
            this.Name = "MojBrojEndDialog";
            this.Text = "Резултат";
            this.Load += new System.EventHandler(this.MojBrojEndDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblYourFormula;
        private System.Windows.Forms.Label lblYourResult;
        private System.Windows.Forms.Label lblTrueResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnCancel;
    }
}