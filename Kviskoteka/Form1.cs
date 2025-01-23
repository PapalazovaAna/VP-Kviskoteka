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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        }

        private void btnMojBroj_Click(object sender, EventArgs e)
        {
            MojBroj mojBroj = new MojBroj();
            mojBroj.ShowDialog();
        }

        private void btnKvizomanija_Click(object sender, EventArgs e)
        {
            Kvizomanija kvizomanija = new Kvizomanija();
            kvizomanija.ShowDialog();
        }

        private void btnBrziSimboli_Click(object sender, EventArgs e)
        {
            BrziSimboli brziSimboli = new BrziSimboli();
            brziSimboli.ShowDialog();
        }
    }
}
