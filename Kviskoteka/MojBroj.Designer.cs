namespace Kviskoteka
{
    partial class MojBroj
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MojBroj));
            this.label1 = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.tbTimeLeft = new System.Windows.Forms.RichTextBox();
            this.tbFormula = new System.Windows.Forms.RichTextBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOperation6 = new System.Windows.Forms.Button();
            this.btnOperation5 = new System.Windows.Forms.Button();
            this.btnOperation4 = new System.Windows.Forms.Button();
            this.btnOperation3 = new System.Windows.Forms.Button();
            this.btnOperation2 = new System.Windows.Forms.Button();
            this.btnOperation1 = new System.Windows.Forms.Button();
            this.tbTargetNum = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(704, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Преостанато време:";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInstructions.Location = new System.Drawing.Point(357, 11);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(116, 20);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Инструкции";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(36, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Баран број:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(36, 442);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Формула:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(36, 335);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Математички операции:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(36, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Дадени броеви:";
            // 
            // btnNum1
            // 
            this.btnNum1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNum1.Enabled = false;
            this.btnNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNum1.Location = new System.Drawing.Point(40, 260);
            this.btnNum1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(64, 52);
            this.btnNum1.TabIndex = 6;
            this.btnNum1.Text = "?";
            this.btnNum1.UseVisualStyleBackColor = false;
            this.btnNum1.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNum2.Enabled = false;
            this.btnNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNum2.Location = new System.Drawing.Point(112, 260);
            this.btnNum2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(64, 52);
            this.btnNum2.TabIndex = 7;
            this.btnNum2.Text = "?";
            this.btnNum2.UseVisualStyleBackColor = false;
            this.btnNum2.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNum3.Enabled = false;
            this.btnNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNum3.Location = new System.Drawing.Point(184, 260);
            this.btnNum3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(64, 52);
            this.btnNum3.TabIndex = 8;
            this.btnNum3.Text = "?";
            this.btnNum3.UseVisualStyleBackColor = false;
            this.btnNum3.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNum4.Enabled = false;
            this.btnNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNum4.Location = new System.Drawing.Point(256, 260);
            this.btnNum4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(64, 50);
            this.btnNum4.TabIndex = 9;
            this.btnNum4.Text = "?";
            this.btnNum4.UseVisualStyleBackColor = false;
            this.btnNum4.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNum5.Enabled = false;
            this.btnNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNum5.Location = new System.Drawing.Point(328, 260);
            this.btnNum5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(64, 50);
            this.btnNum5.TabIndex = 10;
            this.btnNum5.Text = "?";
            this.btnNum5.UseVisualStyleBackColor = false;
            this.btnNum5.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNum6.Enabled = false;
            this.btnNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNum6.Location = new System.Drawing.Point(400, 260);
            this.btnNum6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(64, 52);
            this.btnNum6.TabIndex = 11;
            this.btnNum6.Text = "?";
            this.btnNum6.UseVisualStyleBackColor = false;
            this.btnNum6.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // tbTimeLeft
            // 
            this.tbTimeLeft.BackColor = System.Drawing.Color.LightGreen;
            this.tbTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTimeLeft.Location = new System.Drawing.Point(765, 182);
            this.tbTimeLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTimeLeft.Name = "tbTimeLeft";
            this.tbTimeLeft.ReadOnly = true;
            this.tbTimeLeft.Size = new System.Drawing.Size(89, 37);
            this.tbTimeLeft.TabIndex = 12;
            this.tbTimeLeft.Text = "100";
            // 
            // tbFormula
            // 
            this.tbFormula.Enabled = false;
            this.tbFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbFormula.Location = new System.Drawing.Point(40, 464);
            this.tbFormula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFormula.Name = "tbFormula";
            this.tbFormula.Size = new System.Drawing.Size(324, 47);
            this.tbFormula.TabIndex = 13;
            this.tbFormula.Text = "  x * (y - z)";
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEnd.Enabled = false;
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEnd.Location = new System.Drawing.Point(512, 464);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(123, 48);
            this.btnEnd.TabIndex = 14;
            this.btnEnd.Text = "Крај";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.Location = new System.Drawing.Point(384, 464);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 48);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Избриши";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOperation6
            // 
            this.btnOperation6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOperation6.Enabled = false;
            this.btnOperation6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnOperation6.Location = new System.Drawing.Point(400, 361);
            this.btnOperation6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOperation6.Name = "btnOperation6";
            this.btnOperation6.Size = new System.Drawing.Size(64, 52);
            this.btnOperation6.TabIndex = 21;
            this.btnOperation6.Text = ")";
            this.btnOperation6.UseVisualStyleBackColor = false;
            this.btnOperation6.Click += new System.EventHandler(this.btnCloseParenthesis_Click);
            // 
            // btnOperation5
            // 
            this.btnOperation5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOperation5.Enabled = false;
            this.btnOperation5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnOperation5.Location = new System.Drawing.Point(328, 361);
            this.btnOperation5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOperation5.Name = "btnOperation5";
            this.btnOperation5.Size = new System.Drawing.Size(64, 50);
            this.btnOperation5.TabIndex = 20;
            this.btnOperation5.Text = "(";
            this.btnOperation5.UseVisualStyleBackColor = false;
            this.btnOperation5.Click += new System.EventHandler(this.btnOpenParenthesis_Click);
            // 
            // btnOperation4
            // 
            this.btnOperation4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOperation4.Enabled = false;
            this.btnOperation4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnOperation4.Location = new System.Drawing.Point(256, 361);
            this.btnOperation4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOperation4.Name = "btnOperation4";
            this.btnOperation4.Size = new System.Drawing.Size(64, 50);
            this.btnOperation4.TabIndex = 19;
            this.btnOperation4.Text = "/";
            this.btnOperation4.UseVisualStyleBackColor = false;
            this.btnOperation4.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // btnOperation3
            // 
            this.btnOperation3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOperation3.Enabled = false;
            this.btnOperation3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnOperation3.Location = new System.Drawing.Point(184, 361);
            this.btnOperation3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOperation3.Name = "btnOperation3";
            this.btnOperation3.Size = new System.Drawing.Size(64, 52);
            this.btnOperation3.TabIndex = 18;
            this.btnOperation3.Text = "*";
            this.btnOperation3.UseVisualStyleBackColor = false;
            this.btnOperation3.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // btnOperation2
            // 
            this.btnOperation2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOperation2.Enabled = false;
            this.btnOperation2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnOperation2.Location = new System.Drawing.Point(112, 361);
            this.btnOperation2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOperation2.Name = "btnOperation2";
            this.btnOperation2.Size = new System.Drawing.Size(64, 52);
            this.btnOperation2.TabIndex = 17;
            this.btnOperation2.Text = "-";
            this.btnOperation2.UseVisualStyleBackColor = false;
            this.btnOperation2.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // btnOperation1
            // 
            this.btnOperation1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOperation1.Enabled = false;
            this.btnOperation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnOperation1.Location = new System.Drawing.Point(40, 361);
            this.btnOperation1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOperation1.Name = "btnOperation1";
            this.btnOperation1.Size = new System.Drawing.Size(64, 52);
            this.btnOperation1.TabIndex = 16;
            this.btnOperation1.Text = "+";
            this.btnOperation1.UseVisualStyleBackColor = false;
            this.btnOperation1.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // tbTargetNum
            // 
            this.tbTargetNum.BackColor = System.Drawing.Color.LightSlateGray;
            this.tbTargetNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTargetNum.Location = new System.Drawing.Point(40, 182);
            this.tbTargetNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTargetNum.Name = "tbTargetNum";
            this.tbTargetNum.ReadOnly = true;
            this.tbTargetNum.Size = new System.Drawing.Size(89, 37);
            this.tbTargetNum.TabIndex = 22;
            this.tbTargetNum.Text = "???";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.SlateGray;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStart.Location = new System.Drawing.Point(343, 580);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(161, 52);
            this.btnStart.TabIndex = 23;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(180, 535);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 18);
            this.lblError.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(826, 100);
            this.label2.TabIndex = 25;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // MojBroj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(900, 646);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbTargetNum);
            this.Controls.Add(this.btnOperation6);
            this.Controls.Add(this.btnOperation5);
            this.Controls.Add(this.btnOperation4);
            this.Controls.Add(this.btnOperation3);
            this.Controls.Add(this.btnOperation2);
            this.Controls.Add(this.btnOperation1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.tbFormula);
            this.Controls.Add(this.tbTimeLeft);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MojBroj";
            this.Text = "Мој број";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.RichTextBox tbTimeLeft;
        private System.Windows.Forms.RichTextBox tbFormula;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOperation6;
        private System.Windows.Forms.Button btnOperation5;
        private System.Windows.Forms.Button btnOperation4;
        private System.Windows.Forms.Button btnOperation3;
        private System.Windows.Forms.Button btnOperation2;
        private System.Windows.Forms.Button btnOperation1;
        private System.Windows.Forms.RichTextBox tbTargetNum;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label2;
    }
}