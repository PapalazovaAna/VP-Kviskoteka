using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kviskoteka
{
    public partial class KvizomanijaEndDialog : Form
    {
        public KvizomanijaEndDialog(int numCorrectAnswers, int numWrongAnswers)
        {
            InitializeComponent();
            lblCorrectAnswers.Text += " " + numCorrectAnswers.ToString();
            lblWrongAnswers.Text += " " + numWrongAnswers.ToString();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
