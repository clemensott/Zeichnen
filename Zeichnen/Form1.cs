using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Numerics;

namespace Zeichnen
{
    public partial class Form1 : Form
    {
        Strichdicke Dicke;
        
        Bitmap bild;

        Color[] farben = new Color[0];
        Rectangle[] alle = new Rectangle[0];

        bool drucken = false, changed = false, leaved = false, zeit_an = false;
        int old, form = 0, schritt = 0, abziehen = 0, zeit;
        int[] anzahlen = new int[0], formen = new int[0];
        string pfad = "";

        public Form1()
        {
            InitializeComponent();
            Dicke = new Strichdicke(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bild = new Bitmap(Size.Width, Size.Height);

            pbx_bild.Dock = DockStyle.Fill;
            pbx_bild.BackColor = Color.Transparent;
            pbx_bild.SendToBack();

            pbx_farbe.BackColor = cdg.Color = Color.Blue;

            pbx_kreis.Invalidate();
            pbx_rechteck.Invalidate();
        }

        private void pbx_bild_MouseMove(object sender, MouseEventArgs e)
        {
            leaved = false;

            if (e.Button == MouseButtons.Left && e.X != 0 && e.Y != 0)
            {
                if (!drucken)
                {
                    drucken = true;
                    abziehen = 0;

                    for (int i = 0; i < schritt; i++)
                        abziehen += anzahlen[anzahlen.Length - 1 - i];

                    Array.Resize(ref alle, alle.Length + 1 - abziehen);
                    Array.Resize(ref farben, farben.Length + 1 - schritt);
                    Array.Resize(ref anzahlen, anzahlen.Length + 1 - schritt);
                    Array.Resize(ref formen, formen.Length + 1 - schritt);

                    alle[alle.Length - 1] = new Rectangle(e.X - Convert.ToInt32(nud_dicke.Value) / 2, e.Y - Convert.ToInt32(nud_dicke.Value) / 2, Convert.ToInt32(nud_dicke.Value), Convert.ToInt32(nud_dicke.Value));
                    farben[farben.Length - 1] = cdg.Color;
                    anzahlen[anzahlen.Length - 1] = 1;
                    formen[formen.Length - 1] = form;
                    schritt = 0; abziehen = 0;

                    bitmap_erweitern();
                }
                else if ((alle[alle.Length - 1].X != e.X || alle[alle.Length - 1].Y != e.Y))
                {
                    Rectangle[] cache = new Rectangle[0];

                    int be_x = e.X - alle[alle.Length - 1].X - Convert.ToInt32(nud_dicke.Value) / 2, be_y = e.Y - alle[alle.Length - 1].Y - Convert.ToInt32(nud_dicke.Value) / 2;
                    int vor_x = 1, vor_y = 1;

                    if (be_x != 0)
                        vor_x = be_x / Math.Abs(be_x);

                    if (be_y != 0)
                        vor_y = be_y / Math.Abs(be_y);

                    if (Math.Abs(be_x) <= Math.Abs(be_y))
                    {
                        Array.Resize(ref cache, Math.Abs(be_y));

                        for (int i = 0; i < cache.Length; i++)
                            cache[i] = new Rectangle(alle[alle.Length - 1].X + Convert.ToInt32(Convert.ToDouble((i + 1) * be_x * vor_x) / Convert.ToDouble(be_y * vor_y)) * vor_x, alle[alle.Length - 1].Y + vor_y * (i + 1), Convert.ToInt32(nud_dicke.Value), Convert.ToInt32(nud_dicke.Value));
                    }
                    else
                    {
                        Array.Resize(ref cache, Math.Abs(be_x));

                        for (int i = 0; i < cache.Length; i++)
                            cache[i] = new Rectangle(alle[alle.Length - 1].X + (i + 1) * vor_x, alle[alle.Length - 1].Y + Convert.ToInt32(Convert.ToDouble((i + 1) * be_y * vor_y) / Convert.ToDouble(be_x * vor_x)) * vor_y, Convert.ToInt32(nud_dicke.Value), Convert.ToInt32(nud_dicke.Value));
                    }

                    int davor = alle.Length;
                    Array.Resize(ref alle, alle.Length + cache.Length);

                    for (int i = davor; i < alle.Length; i++)
                        alle[i] = cache[i - davor];

                    anzahlen[anzahlen.Length - 1] += alle.Length - davor;

                    bitmap_erweitern();
                }
            }
            else
            {
                drucken = false;
            }

            if (drucken || ckb_vorschau.Checked)
                pbx_bild.Invalidate();
        }

        private void pbx_bild_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                farbe_andern();
            }
            else if (!drucken && e.Button == MouseButtons.Left && e.X != 0 && e.Y != 0)
            {
                int abziehen = 0;
                old = alle.Length;

                for (int i = 0; i < schritt; i++)
                    abziehen += anzahlen[anzahlen.Length - 1 - i];

                Array.Resize(ref alle, alle.Length + 1 - abziehen);
                Array.Resize(ref farben, farben.Length + 1 - schritt);
                Array.Resize(ref anzahlen, anzahlen.Length + 1 - schritt);
                Array.Resize(ref formen, formen.Length + 1 - schritt);

                alle[alle.Length - 1] = new Rectangle(MousePosition.X - Location.X - 8 - Convert.ToInt32(nud_dicke.Value) / 2, MousePosition.Y - Location.Y - 30 - Convert.ToInt32(nud_dicke.Value) / 2, Convert.ToInt32(nud_dicke.Value), Convert.ToInt32(nud_dicke.Value));
                farben[farben.Length - 1] = cdg.Color;
                anzahlen[anzahlen.Length - 1] = 1;
                formen[formen.Length - 1] = form;
                schritt = 0;

                bitmap_erweitern();
                pbx_bild.Invalidate();
            }
        }

        private void pbx_bild_MouseLeave(object sender, EventArgs e)
        {
            leaved = true;
            Invalidate();
        }

        private void farbe_andern()
        {
            if (cdg.ShowDialog() == DialogResult.OK)
                pbx_farbe.BackColor = cdg.Color;
        }

        private void pbx_radiren_Click(object sender, EventArgs e)
        {
            pbx_farbe.BackColor = cdg.Color = Form1.DefaultBackColor;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics cache = e.Graphics;
            cache.DrawImage(bild, 0, 0);
            changed = false;
        }

        private void pbx_bild_Paint(object sender, PaintEventArgs e)
        {
            if (ckb_vorschau.Checked && !leaved)
            {
                Rectangle akt = new Rectangle(MousePosition.X - Location.X - 8 - Convert.ToInt32(nud_dicke.Value) / 2, MousePosition.Y - Location.Y - 30 - Convert.ToInt32(nud_dicke.Value) / 2, Convert.ToInt32(nud_dicke.Value), Convert.ToInt32(nud_dicke.Value));
                
                if (form == 0)
                    e.Graphics.FillRectangle(new SolidBrush(cdg.Color), akt);
                else
                    e.Graphics.FillEllipse(new SolidBrush(cdg.Color), akt);
            }

            if (changed)
                Invalidate();
        }

        private void bitmap_erweitern()
        {
            changed = true;

            using (var graphics = Graphics.FromImage(bild))
            {
                if (formen[formen.Length - 1 - schritt] == 0)
                    for (int j = old; old < alle.Length - abziehen; old++)
                        graphics.FillRectangle(new SolidBrush(farben[farben.Length - schritt - 1]), alle[old]);
                else
                    for (int j = old; old < alle.Length - abziehen; old++)
                        graphics.FillEllipse(new SolidBrush(farben[farben.Length - schritt - 1]), alle[old]);
            }
        }

        private void bitmap_neu()
        {
            changed = true;
            bild = new Bitmap(Size.Width, Size.Height);

            for (int i = 0; i < anzahlen.Length - schritt; i++)
            {
                using (var graphics = Graphics.FromImage(bild))
                {
                    if (formen[i] == 0)
                        for (int j = 0; j < anzahlen[i]; old++, j++)
                            graphics.FillRectangle(new SolidBrush(farben[i]), alle[old]);
                    else
                        for (int j = 0; j < anzahlen[i]; old++, j++)
                            graphics.FillEllipse(new SolidBrush(farben[i]), alle[old]);
                }
            }
        }

        private void pbx_rechteck_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), e.ClipRectangle.X + 1, e.ClipRectangle.Y + 1, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
        }

        private void pbx_kreis_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(new SolidBrush(Color.Black), e.ClipRectangle.X + 1, e.ClipRectangle.Y + 1, e.ClipRectangle.Width - 3, e.ClipRectangle.Height - 3);
        }

        private void neu_zeichnen()
        {
            if (form == 0)
            {
                pbx_kreis.BorderStyle = BorderStyle.None;
                pbx_rechteck.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                pbx_kreis.BorderStyle = BorderStyle.FixedSingle;
                pbx_rechteck.BorderStyle = BorderStyle.None;
            }

            pbx_bild.Refresh();
            pbx_kreis.Refresh();
            pbx_rechteck.Refresh();
        }

        private void pbx_rechteck_Click(object sender, EventArgs e)
        {
            mst_b_form_recht.Checked = true;
            mst_b_form_kreis.Checked = false;

            form = 0;
            neu_zeichnen();
        }

        private void pbx_kreis_Click(object sender, EventArgs e)
        {
            mst_b_form_recht.Checked = false;
            mst_b_form_kreis.Checked = true;

            form = 1;
            neu_zeichnen();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            mst_b_vorschau.Checked = ckb_vorschau.Checked;
            pbx_bild.Invalidate();
        }

        private void farbeWählenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            farbe_andern();
        }

        private void pbx_farbe_Click(object sender, EventArgs e)
        {
            farbe_andern();
        }

        private void mst_d_vorschau_Click(object sender, EventArgs e)
        {
            mst_b_vorschau.Checked = !mst_b_vorschau.Checked;
            ckb_vorschau.Checked = mst_b_vorschau.Checked;
            pbx_bild.Invalidate();
        }

        private void mst_b_zuruc_Click(object sender, EventArgs e)
        {
            if (schritt < anzahlen.Length)
            {
                schritt++;
                old = 0;

                bitmap_neu();
                pbx_bild.Invalidate();
            }
        }

        private void mst_b_vor_Click(object sender, EventArgs e)
        {
            if (schritt > 0)
            {
                schritt--;
                abziehen = 0;

                for (int i = 0; i < schritt; i++)
                    abziehen += anzahlen[anzahlen.Length - 1 - i];

                bitmap_erweitern();
                pbx_bild.Invalidate();
            }
        }

        private void mst_a_farbe_Click(object sender, EventArgs e)
        {
            int weniger = 31 - Convert.ToInt32(mst_a_farbe.Checked) * 62;

            pbx_bild.Visible = pbx_radiren.Visible = !mst_a_farbe.Checked;
            mst_a_farbe.Checked = !mst_a_farbe.Checked;

            pbx_rechteck.Top += weniger;
            pbx_kreis.Top += weniger;
            ckb_vorschau.Top += weniger;

            MinimumSize = new Size(MinimumSize.Width, MinimumSize.Height - weniger);
            neu_zeichnen();
        }

        private void mst_a_dicke_Click(object sender, EventArgs e)
        {
            int weniger = -26 + Convert.ToInt32(mst_a_dicke.Checked) * 52;

            nud_dicke.Visible = !mst_a_dicke.Checked;

            pbx_farbe.Top -= weniger;
            pbx_radiren.Top -= weniger;
            pbx_rechteck.Top -= weniger;
            pbx_kreis.Top -= weniger;

            ckb_vorschau.Top -= weniger;

            mst_a_dicke.Checked = !mst_a_dicke.Checked;
            MinimumSize = new Size(MinimumSize.Width, MinimumSize.Height - weniger);
            neu_zeichnen();
        }

        private void mst_a_form_Click(object sender, EventArgs e)
        {
            int weniger = 31 - Convert.ToInt32(mst_a_form.Checked) * 62;

            ckb_vorschau.Top += weniger;

            mst_a_form.Checked = pbx_rechteck.Visible = pbx_kreis.Visible = !mst_a_form.Checked;
            MinimumSize = new Size(MinimumSize.Width, MinimumSize.Height + weniger);
            neu_zeichnen();
        }

        private void mst_a_vorschau_Click(object sender, EventArgs e)
        {
            mst_a_vorschau.Checked = !mst_a_vorschau.Checked;
            ckb_vorschau.Visible = mst_a_vorschau.Checked;

            int weniger = 23 - Convert.ToInt32(mst_a_vorschau.Checked) * 46;

            MinimumSize = new Size(MinimumSize.Width, MinimumSize.Height - weniger);
            neu_zeichnen();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            bild = new Bitmap(Size.Width, Size.Height);
            old = 0;

            bitmap_neu();
            neu_zeichnen();
        }

        private void mst_d_neu_Click(object sender, EventArgs e)
        {
            anzahlen = new int[0];
            farben = new Color[0];
            formen = new int[0];
            alle = new Rectangle[0];
            schritt = 0;
            old = 0;
            bild = new Bitmap(Size.Width, Size.Height);

            pbx_bild.Invalidate();
        }

        private void mst_d_offnen_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader datei = new StreamReader(ofd.FileName);

                int gesamt_lange = 0;
                string[] art = datei.ReadToEnd().Split('|');
                BigInteger form_de = new BigInteger(Convert.ToDouble(art[0]));
                string[] werte_text = art[1].Split('.');

                anzahlen = new int[werte_text.Length];
                farben = new Color[werte_text.Length];
                formen = new int[werte_text.Length];

                for (int i = 0; i < anzahlen.Length; i++)
                {
                    string[] cache = werte_text[i].Split(';');
                    anzahlen[i] = cache.Length - 2;
                    gesamt_lange += anzahlen[i];
                }

                for (int i = 0; i < formen.Length; i++)
                {
                    formen[i] = (int)BigInteger.Remainder(form_de, new BigInteger(2));
                    form_de = BigInteger.Divide(form_de, new BigInteger(2));
                }

                string[] werte_x = new string[gesamt_lange];
                string[] werte_y = new string[gesamt_lange];
                string[] werte_w = new string[gesamt_lange];

                alle = new Rectangle[gesamt_lange];

                for (int i = 0, k = 0; i < werte_text.Length; i++)
                {
                    string[] werte_strich = werte_text[i].Split(';');
                    farben[i] = Color.FromArgb(-1 * Convert.ToInt32(werte_strich[0]));
                    string dicke = werte_strich[1];

                    for (int j = 2; j < werte_strich.Length; j++, k++)
                    {
                        string[] cache = werte_strich[j].Split(',');

                        werte_x[k] = cache[0];
                        werte_y[k] = cache[1];
                        werte_w[k] = dicke;
                    }
                }

                for (int i = 0; i < alle.Length; i++)
                    alle[i] = new Rectangle(Convert.ToInt32(werte_x[i]), Convert.ToInt32(werte_y[i]), Convert.ToInt32(werte_w[i]), Convert.ToInt32(werte_w[i]));
                
                datei.Close();
                old = 0;
                bitmap_neu();
                pbx_bild.Invalidate();
            }
        }

        private void mst_d_speichen_Click(object sender, EventArgs e)
        {
            if (pfad != "")
            {
                speichern();
            }
            else
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    pfad = sfd.FileName;
                    speichern();
                }
            }
        }

        private void mst_d_speichern_unter_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pfad = sfd.FileName;
                speichern();
            }
        }

        private void speichern()
        {
            StreamWriter datei = new StreamWriter(sfd.FileName, false);

            int form_zahl = 0;
            string text = "";

            for (int i = 0, j = 0; i < formen.Length - schritt; i++, j++)
            {
                if (j % 31 == 0 && j != 0)
                {
                    text += Convert.ToString(form_zahl);

                    j = 0;
                    form_zahl = 0;
                }

                form_zahl += Convert.ToInt32(formen[i] * Math.Pow(2, j));
            }

            text += Convert.ToString(form_zahl) + "|";

            for (int i = 0, k = 0; i < anzahlen.Length - schritt; i++)
            {
                text += (-1 * farben[i].ToArgb()).ToString() + ";" + (alle[k].Width).ToString() + ";";

                for (int j = 0; j < anzahlen[i]; j++, k++)
                    text += Convert.ToString(alle[k].X) + "," + Convert.ToString(alle[k].Y) + ";";

                text = text.TrimEnd(';');
                text += ".";
            }

            text = text.TrimEnd('.');

            datei.Write(text);
            datei.Close();
        }

        private void mst_b_dicke_Click(object sender, EventArgs e)
        {
            Dicke.dicke = nud_dicke.Value;

            Dicke.ShowDialog();

            if (Dicke.ok)
                nud_dicke.Value = Dicke.dicke;
        }

        private void farbeWählenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            farbe_andern();
        }
    }
}
