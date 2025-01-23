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
    public partial class MojBrojEndDialog : Form
    {
        private string formula;
        private double yourResult;
        private string trueFormula;
        private int baranBroj;
        public MojBrojEndDialog(string formula, double yourResult, string trueFormula, int baranBroj)
        {
            InitializeComponent();
            this.formula = formula;
            this.yourResult = yourResult;
            this.trueFormula = trueFormula;
            this.baranBroj = baranBroj;
        }

        private void MojBrojEndDialog_Load(object sender, EventArgs e)
        {
            if (yourResult == baranBroj)
            {
                lblAnswer.Text = "Точен број!";
            }
            else if(yourResult == -1)
            {
                lblAnswer.Text = "Невалидна формула!";
            }
            else
            {
                lblAnswer.Text = "Неточен број!";
            }

            if (formula == "Немате внесено израз!")
            {
                lblYourFormula.Text = formula;
                lblYourResult.Text = "";
            }
            else if(yourResult == -1)
            {
                lblYourFormula.Text += "\n" + this.formula;
                lblYourResult.Text += "\nНевалидна формула!";
            }
            else
            {
                lblYourFormula.Text += "\n" + this.formula;
                lblYourResult.Text += "\n" + this.yourResult.ToString();
            }
            lblTrueResult.Text += "\n" + this.trueFormula.ToString();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
