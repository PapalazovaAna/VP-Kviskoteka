using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kviskoteka
{
    public partial class BrziSimboli : Form
    {
        private List<string> symbols;
        private List<string> targetArray;
        private List<PictureBox> thisRowPicturesId;
        private List<string> yourChosenRow;
        private Button btnOK;
        private PictureBox pbRow;
        private int rowNum;
        private Dictionary<string, Image> symbolImages;

        public BrziSimboli()
        {
            InitializeComponent();

            symbols = new List<string>();
            symbols.Add("square");
            symbols.Add("pentagon");
            symbols.Add("circle");
            symbols.Add("star");
            symbols.Add("halfMoon");
            symbols.Add("hexagon");

            symbolImages = new Dictionary<string, Image>
            {
                { "square", Properties.Resources.square },
                { "pentagon", Properties.Resources.pentagon },
                { "circle", Properties.Resources.circle },
                { "star", Properties.Resources.star },
                { "halfMoon", Properties.Resources.halfMoon },
                { "hexagon", Properties.Resources.hexagon }
            };

            timer3 = new Timer();
            timer3.Interval = 1000;
            timer3.Tick += timer3_Tick;

            pb1.Image = symbolImages[symbols[0]];
            pb2.Image = symbolImages[symbols[1]];
            pb3.Image = symbolImages[symbols[2]];
            pb4.Image = symbolImages[symbols[3]];
            pb5.Image = symbolImages[symbols[4]];
            pb6.Image = symbolImages[symbols[5]];
        }

        private void newGame()
        {
            pb1.Enabled = true;
            pb2.Enabled = true;
            pb3.Enabled = true;
            pb4.Enabled = true;
            pb5.Enabled = true;
            pb6.Enabled = true;
            btnDelete.Enabled = true;
            tbTimeLeft.Text = "120";

            string pbName = "";
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    pbName = "pb" + i.ToString() + "_" + j.ToString();
                    PictureBox pb = this.Controls.Find(pbName, true).FirstOrDefault() as PictureBox;
                    pb.Image = null;
                }
                PictureBox pbRowTemp = this.Controls.Find("pbRow" + i.ToString(), true).FirstOrDefault() as PictureBox;
                pbRowTemp.Image = null;
            }

            timer3.Start();

            targetArray = new List<string>();
            targetArray = randomArray();

            this.rowNum = 0;

            newRow();
        }

        private void newRow()
        {
            if(rowNum == 6)
            {
                endGame(false);
                return;
            }
            rowNum++;

            thisRowPicturesId = new List<PictureBox>();
            yourChosenRow = new List<string>();

            string pbRowName = "pbRow" + rowNum.ToString();
            pbRow = this.Controls.Find(pbRowName, true).FirstOrDefault() as PictureBox;

            string buttonName = "btnOK" + rowNum.ToString();
            btnOK = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;

            string rowPicturesName = "pb" + rowNum + "_";
            thisRowPicturesId.Add(this.Controls.Find(rowPicturesName + "1", true).FirstOrDefault() as PictureBox);
            thisRowPicturesId.Add(this.Controls.Find(rowPicturesName + "2", true).FirstOrDefault() as PictureBox);
            thisRowPicturesId.Add(this.Controls.Find(rowPicturesName + "3", true).FirstOrDefault() as PictureBox);
            thisRowPicturesId.Add(this.Controls.Find(rowPicturesName + "4", true).FirstOrDefault() as PictureBox);
        }


        private List<string> randomArray()
        {
            Random random = new Random();
            int num;
            List<string> list = new List<string>();

            for (int i = 0; i < 4; i++)
            {
                num = random.Next(0, 6);
                list.Add(symbols.ElementAt(num));
            }

            return list;
        }


        private void pbSymbol_Click(object sender, EventArgs e)
        {
            if (yourChosenRow.Count < 4)
            {
                PictureBox pictureBox = (PictureBox)sender;

                int n = -1;
                string name = pictureBox.Name;
                if (!string.IsNullOrEmpty(name))
                {
                    char lastChar = name[name.Length - 1];
                    if (char.IsDigit(lastChar))
                    {
                        n = int.Parse(lastChar.ToString());
                    }
                }

                yourChosenRow.Add(symbols.ElementAt(n - 1));
                thisRowPicturesId[yourChosenRow.Count - 1].Image = pictureBox.Image;
            }

            if (yourChosenRow.Count == 4)
            {
                btnOK.Visible = true;
                btnOK.Enabled = true;
            }

        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            btnOK.Visible = false;

            List<int> trueFalse = count();
            int truePosition = trueFalse[0];
            int falsePosition = trueFalse[1];

            pbRow.Image = chooseImage(truePosition, falsePosition);

            if (truePosition == 4)
            {
                endGame(true);
            }
            else
            {
                newRow();
            }
        }


        private List<int> count()
        {
            List<int> temp1 = new List<int>() {1, 1, 1, 1};
            List<int> temp2 = new List<int>() {1, 1, 1, 1};

            int truePosition = 0;
            for (int i = 0; i < 4; i++)
            {
                if (targetArray[i] == yourChosenRow[i])
                {
                    truePosition++;
                    temp1[i] = 0;
                    temp2[i] = 0;
                }
            }

            int falsePosition = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j) continue;

                    if (yourChosenRow[i] == targetArray[j] && temp1[i] != 0 && temp2[j] != 0)
                    {
                        falsePosition++;
                        temp1[i] = 0;
                        temp2[j] = 0;
                    }
                }
            }
            return new List<int> { truePosition, falsePosition };
        }
    



        private Image chooseImage(int truePosition, int falsePosition)
        {
            if (truePosition == 0)
            {
                if (falsePosition == 0) return Properties.Resources.none;
                if (falsePosition == 1) return Properties.Resources._1F;
                if (falsePosition == 2) return Properties.Resources._2F;
                if (falsePosition == 3) return Properties.Resources._3F;
                if (falsePosition == 4) return Properties.Resources._4F;
            }
            if (truePosition == 1)
            {
                if (falsePosition == 0) return Properties.Resources._1T;
                if (falsePosition == 1) return Properties.Resources._1T1F;
                if (falsePosition == 2) return Properties.Resources._1T2F;
                if (falsePosition == 3) return Properties.Resources._1T3F;
            }
            if (truePosition == 2)
            {
                if (falsePosition == 0) return Properties.Resources._2T;
                if (falsePosition == 1) return Properties.Resources._2T1F;
                if (falsePosition == 2) return Properties.Resources._2T2F;
            }
            if (truePosition == 3)
            {
                if (falsePosition == 0) return Properties.Resources._3T;
                if (falsePosition == 1) return Properties.Resources._3T1F;
            }
            if(truePosition == 4)
            {
                return Properties.Resources._4T;
            }
            return Properties.Resources.none;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            newGame();
            btnStart.Visible = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int timeLeft = int.Parse(tbTimeLeft.Text);

            if(timeLeft == 0)
            {
                endGame(false);
            }
            else
            {
                timeLeft--;
                tbTimeLeft.Text = timeLeft.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(yourChosenRow.Count > 0)
            {
                yourChosenRow.RemoveAt(yourChosenRow.Count - 1);
                thisRowPicturesId[yourChosenRow.Count].Image = null;
            }
        }


        private void endGame(bool correctGuess)
        {
            timer3.Stop();
            string answer = "";
            if (correctGuess)
            {
                answer = "Точно!";
            }
            else
            {
                answer = "Неточно! Ова е точното решение:";
            }
            BrziSimboliEndDialog dialog = new BrziSimboliEndDialog(answer, targetArray, symbolImages);
            var result = dialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                newGame();
            }
            if(result == DialogResult.Cancel)
            {
                this.Close();
            }
        }
    }
}
