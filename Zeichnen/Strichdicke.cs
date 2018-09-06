using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zeichnen
{
    public partial class Strichdicke : Form
    {
        public bool ok;
        public decimal dicke;
        Form1 Haupt;

        public Strichdicke(Form1 haupt)
        {
            InitializeComponent();
            Haupt = haupt;
        }

        private void Strichdicke_Load(object sender, EventArgs e)
        {
            ok = false;
            nud_dicke.Value = dicke;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            dicke = nud_dicke.Value;
            ok = true;
            Hide();
        }

        private void btn_abb_Click(object sender, EventArgs e)
        {
            ok = false;
            Hide();
        }

        private void Strichdicke_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
