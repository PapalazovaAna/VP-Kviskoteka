namespace Kviskoteka
{
    partial class Kvizomanija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kvizomanija));
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTimeLeft = new System.Windows.Forms.RichTextBox();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblQuestionNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInstructions.Location = new System.Drawing.Point(212, 18);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(96, 16);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Инструкции";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQuestion.Location = new System.Drawing.Point(29, 181);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(36, 20);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(405, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Преостанато време:";
            // 
            // tbTimeLeft
            // 
            this.tbTimeLeft.BackColor = System.Drawing.Color.LightGreen;
            this.tbTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTimeLeft.Location = new System.Drawing.Point(480, 146);
            this.tbTimeLeft.Name = "tbTimeLeft";
            this.tbTimeLeft.ReadOnly = true;
            this.tbTimeLeft.Size = new System.Drawing.Size(53, 33);
            this.tbTimeLeft.TabIndex = 3;
            this.tbTimeLeft.Text = "50";
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.Enabled = false;
            this.btnAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAnswer1.Location = new System.Drawing.Point(51, 228);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(186, 44);
            this.btnAnswer1.TabIndex = 4;
            this.btnAnswer1.Text = "?";
            this.btnAnswer1.UseVisualStyleBackColor = true;
            this.btnAnswer1.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.Enabled = false;
            this.btnAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAnswer2.Location = new System.Drawing.Point(285, 228);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(186, 44);
            this.btnAnswer2.TabIndex = 5;
            this.btnAnswer2.Text = "?";
            this.btnAnswer2.UseVisualStyleBackColor = true;
            this.btnAnswer2.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.Enabled = false;
            this.btnAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAnswer3.Location = new System.Drawing.Point(51, 278);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(186, 44);
            this.btnAnswer3.TabIndex = 6;
            this.btnAnswer3.Text = "?";
            this.btnAnswer3.UseVisualStyleBackColor = true;
            this.btnAnswer3.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.Enabled = false;
            this.btnAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAnswer4.Location = new System.Drawing.Point(285, 278);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(186, 44);
            this.btnAnswer4.TabIndex = 7;
            this.btnAnswer4.Text = "?";
            this.btnAnswer4.UseVisualStyleBackColor = true;
            this.btnAnswer4.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Enabled = false;
            this.btnNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNextQuestion.Location = new System.Drawing.Point(185, 345);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(152, 26);
            this.btnNextQuestion.TabIndex = 8;
            this.btnNextQuestion.Text = "Следно прашање";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.SlateGray;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStart.Location = new System.Drawing.Point(201, 416);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 42);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblQuestionNum
            // 
            this.lblQuestionNum.AutoSize = true;
            this.lblQuestionNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblQuestionNum.Location = new System.Drawing.Point(182, 128);
            this.lblQuestionNum.Name = "lblQuestionNum";
            this.lblQuestionNum.Size = new System.Drawing.Size(46, 17);
            this.lblQuestionNum.TabIndex = 10;
            this.lblQuestionNum.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 68);
            this.label1.TabIndex = 11;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Kvizomanija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(559, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQuestionNum);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.btnAnswer4);
            this.Controls.Add(this.btnAnswer3);
            this.Controls.Add(this.btnAnswer2);
            this.Controls.Add(this.btnAnswer1);
            this.Controls.Add(this.tbTimeLeft);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblInstructions);
            this.Name = "Kvizomanija";
            this.Text = "Квизоманија";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tbTimeLeft;
        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblQuestionNum;
        private System.Windows.Forms.Label label1;
    }
}