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
    public partial class BrziSimboliEndDialog : Form
    {
        public BrziSimboliEndDialog(string answer, List<string> targetArray, Dictionary<string, Image> symbolImages)
        {
            InitializeComponent();

            lblAnswer.Text = answer;

            pb1.Image = symbolImages[targetArray[0]];
            pb2.Image = symbolImages[targetArray[1]];
            pb3.Image = symbolImages[targetArray[2]];
            pb4.Image = symbolImages[targetArray[3]];
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}
